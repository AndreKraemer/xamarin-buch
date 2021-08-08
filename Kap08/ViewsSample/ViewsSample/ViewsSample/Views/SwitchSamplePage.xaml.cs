using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ViewsSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwitchSamplePage : ContentPage
    {
        public SwitchSamplePage()
        {
            InitializeComponent();
        }


        private async void Switch_OnToggled(object sender, ToggledEventArgs e)
        {
            try
            {
                if (e.Value)
                {
                    await Xamarin.Essentials.Flashlight.TurnOnAsync();
                }
                else
                {
                    await Xamarin.Essentials.Flashlight.TurnOffAsync();
                }
            }
            catch (FeatureNotSupportedException)
            {
                await DisplayAlert("Taschenlampe", $"Taschenlampe wird auf diesem Gerät nicht unterstützt. Wert: {e.Value}", "Ok");
            }
            catch (PermissionException)
            {
                await DisplayAlert("Taschenlampe", $"Berechtigung für Taschenlampe fehlt. Wert: {e.Value}", "Ok");
            }
        }
    }
}