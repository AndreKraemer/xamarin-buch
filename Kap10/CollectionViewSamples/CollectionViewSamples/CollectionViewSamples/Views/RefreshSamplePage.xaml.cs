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
    public partial class RefreshSamplePage : ContentPage
    {
        private RefreshSampleViewModel _viewModel;

        public RefreshSamplePage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new RefreshSampleViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.Initialize();
        }
    }
}