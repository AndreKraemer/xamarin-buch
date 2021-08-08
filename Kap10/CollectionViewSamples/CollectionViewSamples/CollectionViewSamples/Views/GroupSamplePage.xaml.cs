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
    public partial class GroupSamplePage : ContentPage
    {
        private GroupSampleViewModel _viewModel;

        public GroupSamplePage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new GroupSampleViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _viewModel.Initialize();
        }
    }
}