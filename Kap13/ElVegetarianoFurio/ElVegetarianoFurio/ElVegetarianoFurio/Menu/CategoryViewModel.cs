﻿using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using ElVegetarianoFurio.Core;
using ElVegetarianoFurio.Data;
using Xamarin.Forms;

namespace ElVegetarianoFurio.Menu
{
    public class CategoryViewModel : BaseViewModel
    {
        private readonly IDataService _dataService;
        private readonly INavigationService _navigationService;
        private Category _category;
        private int _categoryId;

        public CategoryViewModel(IDataService dataService, INavigationService navigationService)
        {
            _dataService = dataService;
            _navigationService = navigationService;
            LoadDataCommand = new Command(async () => await LoadDataAsync());
            NavigateToDishCommand = new Command(NavigateToDish);
        }

        public ICommand LoadDataCommand { get; }
        public ICommand NavigateToDishCommand { get; }

        public ObservableCollection<Dish> Dishes { get; set; } = new ObservableCollection<Dish>();

        public Category Category
        {
            get => _category;
            set => SetProperty(ref _category, value);
        }

        public int CategoryId
        {
            get => _categoryId;
            set => SetProperty(ref _categoryId, value);
        }


        private async Task LoadDataAsync()
        {
            Dishes.Clear();

            Category = (await _dataService.GetCategoriesAsync()).First(c => c.Id == CategoryId);
            var dishes = await _dataService.GetDishesAsync(CategoryId);

            foreach (var dish in dishes)
            {
                Dishes.Add(dish);
            }
        }

        private async void NavigateToDish(object arg)
        {
            if (arg is Dish dish)
            {
                await _navigationService.GoToAsync($"{nameof(DishPage)}?DishId={dish.Id}");
            }
        }

        public override async Task Initialize()
        {
            await LoadDataAsync();
            await base.Initialize();
        }
    }
}