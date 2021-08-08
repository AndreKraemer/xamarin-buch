using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NetStandardDemo
{
    public partial class App : Application
    {
        public App(IDeviceInfo deviceInfo)
        {
            InitializeComponent();

            MainPage = new MainPage(deviceInfo);
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
