using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ShellSample
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            //await Shell.Current.GoToAsync("//LoginPage");
        }

        private async void MenuItem_OnClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Versionsinfo", "1.0.0", "Ok");
            FlyoutIsPresented = false;
        }
    }
}
