using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SharedDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var text = "";
#if __ANDROID__
   // Dieser Code wird nur in das Android Projekt
   // herein kompiliert.
   text = Android.OS.Build.Device;
#elif __IOS__
            // Dieser Code wird nur in das iOS Projekt
            // herein kompiliert
            text = UIKit.UIDevice.CurrentDevice.Name;
#elif WINDOWS_UWP
            var hostNames = Windows.Networking.Connectivity.NetworkInformation.GetHostNames();
            var hostName = hostNames.FirstOrDefault();
            text = hostName.DisplayName;
#endif
            DeviceInfoLabel.Text = text;
        }
    }
}
