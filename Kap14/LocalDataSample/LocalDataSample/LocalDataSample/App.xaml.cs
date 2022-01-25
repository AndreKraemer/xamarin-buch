using LocalDataSample.Services;
using LocalDataSample.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LocalDataSample
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<DbDataStore>();
            //DependencyService.Register<FileDataStore>();
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
