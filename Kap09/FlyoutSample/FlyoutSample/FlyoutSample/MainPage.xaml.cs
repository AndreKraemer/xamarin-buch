using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlyoutSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : FlyoutPage
    {
        public MainPage()
        {
            InitializeComponent();
            FlyoutPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // prüfen, ob der ausgewählte Eintrag vom korrekten Typ ist
            if (!(e.SelectedItem is MainPageFlyoutMenuItem item))
            {
                return;
            }

            // Detailseite erzeugen und die Navigation durchführen
            var page = (Page)Activator.CreateInstance(item.TargetType);
            Detail = new NavigationPage(page);

            // Flyout wieder einklappen
            IsPresented = false;
            FlyoutPage.ListView.SelectedItem = null;
        }
    }
}