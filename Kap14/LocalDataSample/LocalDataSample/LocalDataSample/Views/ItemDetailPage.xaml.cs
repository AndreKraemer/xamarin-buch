using LocalDataSample.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace LocalDataSample.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}