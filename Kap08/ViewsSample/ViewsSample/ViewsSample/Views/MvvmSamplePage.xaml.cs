using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewsSample.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ViewsSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MvvmSamplePage : ContentPage
    {
        public MvvmSamplePage()
        {
            InitializeComponent();
            BindingContext = new MvvmSampleViewModel();
        }
    }
}