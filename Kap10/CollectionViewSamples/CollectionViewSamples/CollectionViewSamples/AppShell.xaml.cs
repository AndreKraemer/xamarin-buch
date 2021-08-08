using CollectionViewSamples.ViewModels;
using CollectionViewSamples.Views;
using System;
using System.Collections.Generic;
using CollectionViewSamples.Services;
using Xamarin.Forms;

namespace CollectionViewSamples
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            DependencyService.Register<MockDataStore>();
        }
    }
}
