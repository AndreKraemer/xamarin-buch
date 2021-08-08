using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StylesSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DarkModeLightModeSamplePage : ContentPage
    {
        public DarkModeLightModeSamplePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DisplayCurrentTheme();
            Application.Current.RequestedThemeChanged += Application_ThemeChanged;
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Application.Current.RequestedThemeChanged -= Application_ThemeChanged;
        }

        private void Application_ThemeChanged(object sender, AppThemeChangedEventArgs e)
        {
            DisplayCurrentTheme();
        }

        private void DisplayCurrentTheme()
        {
            var currentTheme = Application.Current.RequestedTheme;
            switch (currentTheme)
            {
                case OSAppTheme.Unspecified:
                    CurrentThemeLabel.Text = "Das aktuelle Theme ist nicht spezifiziert";
                    break;
                case OSAppTheme.Dark:
                    CurrentThemeLabel.Text = "Das aktuelle Theme ist dunkel";
                    break;
                case OSAppTheme.Light:
                    CurrentThemeLabel.Text = "Das aktuelle Theme ist hell";
                    break;
            }
        }
    }
}