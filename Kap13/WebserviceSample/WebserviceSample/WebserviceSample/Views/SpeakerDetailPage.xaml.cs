using System.ComponentModel;
using WebserviceSample.ViewModels;
using Xamarin.Forms;

namespace WebserviceSample.Views
{
    public partial class SpeakerDetailPage : ContentPage
    {
        public SpeakerDetailPage()
        {
            InitializeComponent();
            BindingContext = new SpeakerDetailViewModel();
        }
    }
}