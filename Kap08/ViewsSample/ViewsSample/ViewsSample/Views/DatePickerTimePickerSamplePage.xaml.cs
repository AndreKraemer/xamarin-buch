using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ViewsSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatePickerTimePickerSamplePage : ContentPage
    {
        public DatePickerTimePickerSamplePage()
        {
            InitializeComponent();
        }

        private void DatePicker_OnDateSelected(object sender, DateChangedEventArgs e)
        {
            ResultDateLabel.Text = e.NewDate.ToShortDateString();
        }

        private void TimePicker_Changed(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Time") // prüfen, ob die Uhrzeit verändert wurde
            {
                var timepicker = (TimePicker)sender;
                ResultTimeLabel.Text = timepicker.Time.ToString("g");
            }
        }
    }
}