using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IocDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage(IDeviceInfo deviceInfo)
        {
            InitializeComponent();
            DeviceInfoLabel.Text = deviceInfo.GetName();
        }
    }
}
