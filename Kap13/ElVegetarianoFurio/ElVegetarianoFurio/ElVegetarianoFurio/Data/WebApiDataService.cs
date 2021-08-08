﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ElVegetarianoFurio.Menu;
using MonkeyCache.FileStore;
using Newtonsoft.Json;
using Xamarin.Essentials;

namespace ElVegetarianoFurio.Data
{
    public class WebApiDataService : IDataService
    {
        private static readonly HttpClient _client = new HttpClient
        {
            BaseAddress = new Uri(
                "https://my-json-server.typicode.com/AndreKraemer/vegi-data/")
        };

        public Task<List<Category>> GetCategoriesAsync()
        {
            return GetCachedAsync<List<Category>>("categories", TimeSpan.FromDays(1));
        }

        public async Task<List<Dish>> GetDishesAsync(int? categoryId = null)
        {
            var dishes = await GetCachedAsync<List<Dish>>("dishes");
            return categoryId.HasValue ? dishes.Where(d => d.CategoryId == categoryId.Value).ToList() : dishes;
        }

        public async Task<Dish> GetDishAsync(int id)
        {
            return await GetCachedAsync<Dish>($"dishes/{id}", TimeSpan.FromHours(1));
        }

        private async Task<T> GetCachedAsync<T>(string url, TimeSpan? cacheTime = null)
        {
            // Wenn keine Internetverbindung besteht gecachte Daten zurückgeben,
            // auch wenn diese bereits abgelaufen sind.
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                return Barrel.Current.Get<T>(url);
            }

            // Falls Internetverbindung besteht und es nicht abgelaufene
            // gecachte Daten gibt: Diese zurückgeben
            if (!Barrel.Current.IsExpired(url))
            {
                return Barrel.Current.Get<T>(url);
            }

            // Daten vom Webservice abrufen
            try
            {
                var json = await _client.GetStringAsync(url);
                var result = JsonConvert.DeserializeObject<T>(json);

                // Daten mit einer Lebensdauer von 5 Minuten im Cache ablegen
                Barrel.Current.Add(url, result, cacheTime ?? TimeSpan.FromMinutes(5));
                return result;
            }
            catch (HttpRequestException)
            {
                return default; // Im Fall einer Exception ein leeres Objekt zurückgeben
            }
        }
    }
}