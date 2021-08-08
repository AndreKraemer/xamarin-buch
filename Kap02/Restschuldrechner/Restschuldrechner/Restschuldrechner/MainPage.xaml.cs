using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Restschuldrechner
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new RestschuldViewModel();
        }

        private double _width;
        private double _height;
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if (width != _width || height != _height)
            {
                _width = width;
                _height = height;
                if (width > height)
                {
                    OuterLayout.Orientation = StackOrientation.Horizontal;
                    foreach (var view in OuterLayout.Children)
                    {
                        view.WidthRequest = width / OuterLayout.Children.Count;
                    }
                }
                else
                {
                    OuterLayout.Orientation = StackOrientation.Vertical;
                    foreach (var view in OuterLayout.Children)
                    {
                        view.WidthRequest = OuterLayout.Width;
                    }
                }
            }
        }
    }
}
