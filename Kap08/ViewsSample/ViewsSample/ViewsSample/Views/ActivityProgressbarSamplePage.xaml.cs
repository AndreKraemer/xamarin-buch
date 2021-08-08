using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ViewsSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityProgressbarSamplePage : ContentPage
    {
        public ActivityProgressbarSamplePage()
        {
            InitializeComponent();
        }

        private void ActivityOn_Clicked(object sender, EventArgs e)
        {
            ActivityIndicator1.IsRunning = true;
        }

        private void ActivityOff_Clicked(object sender, EventArgs e)
        {
            ActivityIndicator1.IsRunning = false;
        }

        private void Button0_Clicked(object sender, EventArgs e)
        {
            ProgressBar1.Progress = 0;
        }

        private void Button33_Clicked(object sender, EventArgs e)
        {
            ProgressBar1.Progress = 0.33;
        }
        private void Button67_Clicked(object sender, EventArgs e)
        {
            ProgressBar1.Progress = 0.67;
        }
    }
}