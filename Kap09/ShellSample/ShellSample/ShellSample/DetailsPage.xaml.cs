using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty(nameof(FullName), nameof(FullName))]
    public partial class DetailsPage : ContentPage
    {
        public string FullName { get; set; }
        public DetailsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            FullNameLabel.Text = $"Ihr Name lautet {FullName}";
        }
    }
}