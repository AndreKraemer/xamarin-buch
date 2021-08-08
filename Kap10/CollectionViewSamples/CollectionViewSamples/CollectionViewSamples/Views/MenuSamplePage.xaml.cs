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
    public partial class MenuSamplePage : ContentPage
    {
        private MenuSampleViewModel _viewModel;

        public MenuSamplePage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new MenuSampleViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.Initialize();
        }
    }
}