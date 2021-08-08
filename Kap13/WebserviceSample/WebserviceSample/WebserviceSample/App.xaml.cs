using System;
using MonkeyCache.FileStore;
using WebserviceSample.Services;
using WebserviceSample.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebserviceSample
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            Barrel.ApplicationId = "WebserviceSample Demo App";
            
            DependencyService.Register<SpeakerDataStore>();
            MainPage = new AppShell();
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
