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
    public partial class RadioButtonSamplePage : ContentPage
    {
        public RadioButtonSamplePage()
        {
            InitializeComponent();
        }

        private void RadioButtonGroup1_OnCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var value = (sender as RadioButton).Value;
            Option1ResultLabel.Text = $"Sie haben {value} ausgewählt";
        }

        private void RadioButtonGroup2_OnCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var value = (sender as RadioButton).Value;
            Option2ResultLabel.Text = $"Sie haben {value} ausgewählt";
        }
    }
}