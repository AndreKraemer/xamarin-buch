using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionViewSamples.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewSamples.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstSamplePage : ContentPage
    {
        private FirstSampleViewModel _viewModel;

        public FirstSamplePage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new FirstSampleViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _viewModel.Initialize();
        }
    }
}