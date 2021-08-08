using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StylesSample.Themes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StylesSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThemesSamplePage : ContentPage
    {
        public ThemesSamplePage()
        {
            InitializeComponent();
        }

        private void LightTheme_Clicked(object sender, EventArgs e)
        {
            ChangeTheme(new LightTheme());
        }

        private void DarkTheme_Clicked(object sender, EventArgs e)
        {
            ChangeTheme(new DarkTheme());
        }

        private void GreenTheme_Clicked(object sender, EventArgs e)
        {
            ChangeTheme(new GreenTheme());
        }

        private void ChangeTheme(ResourceDictionary theme)
        {
            Resources.MergedDictionaries.Remove(Resources.MergedDictionaries.Last());
            Resources.MergedDictionaries.Add(theme);
        }
    }
}