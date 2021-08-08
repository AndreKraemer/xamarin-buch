using System;
using System.Collections.Generic;
using WebserviceSample.ViewModels;
using WebserviceSample.Views;
using Xamarin.Forms;

namespace WebserviceSample
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(SpeakerDetailPage), typeof(SpeakerDetailPage));
            Routing.RegisterRoute(nameof(NewSpeakerPage), typeof(NewSpeakerPage));
        }
    }
}
