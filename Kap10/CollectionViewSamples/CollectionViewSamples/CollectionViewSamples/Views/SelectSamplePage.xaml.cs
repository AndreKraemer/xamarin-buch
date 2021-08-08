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
    public partial class SelectSamplePage : ContentPage
    {
        private SelectSampleViewModel _viewModel;

        public SelectSamplePage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new SelectSampleViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.Initialize();
        }
    }
}