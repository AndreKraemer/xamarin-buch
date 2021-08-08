using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalDataSample.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LocalDataSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoldersPage : ContentPage
    {
        private readonly FoldersViewModel _viewModel;

        public FoldersPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new FoldersViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}