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
    public partial class ButtonSamplePage : ContentPage
    {
        public ButtonSamplePage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "geklickt";
        }
    }
}