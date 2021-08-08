using System;
using ElVegetarianoFurio.Profile;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElVegetarianoFurio
{
    public partial class App : Application
    {
        public App()
        {
            var profilePage = Startup.ServiceProvider.GetService<ProfilePage>();
            InitializeComponent();

            MainPage = profilePage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
