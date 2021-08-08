using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebserviceSample.Models;
using WebserviceSample.ViewModels;
using WebserviceSample.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebserviceSample.Views
{
    public partial class SpeakersPage : ContentPage
    {
        SpeakersViewModel _viewModel;

        public SpeakersPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new SpeakersViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}