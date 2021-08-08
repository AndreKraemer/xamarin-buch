using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebserviceSample.Models;

namespace WebserviceSample.Services
{
    public class MockDataStore : IDataStore<Speaker>
    {
        readonly List<Speaker> items;

        public MockDataStore()
        {
            items = new List<Speaker>()
            {
                new Speaker { Id = 1, Name = "First item", Company="This is an item description." },
                new Speaker { Id = 2, Name = "Second item", Company="This is an item description." },
                new Speaker { Id = 3, Name = "Third item", Company="This is an item description." },
                new Speaker { Id = 4, Name = "Fourth item", Company="This is an item description." },
                new Speaker { Id = 5, Name = "Fifth item", Company="This is an item description." },
                new Speaker { Id = 6, Name = "Sixth item", Company="This is an item description." }
            };
        }

        public async Task<bool> AddItemAsync(Speaker speaker)
        {
            items.Add(speaker);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Speaker speaker)
        {
            var oldItem = items.Where((Speaker arg) => arg.Id == speaker.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(speaker);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            var oldItem = items.Where((Speaker arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Speaker> GetItemAsync(int id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Speaker>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}