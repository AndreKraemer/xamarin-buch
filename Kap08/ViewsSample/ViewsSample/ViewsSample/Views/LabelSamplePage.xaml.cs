using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ViewsSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LabelSamplePage : ContentPage
    {
        public LabelSamplePage()
        {
            InitializeComponent();
            MeinLabel.Text = "Hallo";
        }
    }
}