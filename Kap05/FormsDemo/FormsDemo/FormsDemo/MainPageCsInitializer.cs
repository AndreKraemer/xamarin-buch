using System.Collections;
using Xamarin.Forms;

namespace FormsDemo
{
    public class MainPageCsInitializer : ContentPage
    {

        public MainPageCsInitializer()
        {
            Title = "Login via Code (Initializer)";
            BackgroundColor = Color.FromHex("#2196F3");
            Content = new StackLayout
            {
                Children =
                {
                    new StackLayout
                    {
                        Padding = 30,
                        Children =
                        {
                            new Label
                            {
                                TextColor = Color.White,
                                FontSize = 20,
                                Text = "Herzlich Willkommen zur Xamarin.Forms Demo"
                            }
                        }
                    },
                    new Frame()
                    {
                        BackgroundColor= Color.White,
                        CornerRadius=10,
                        Margin=20,
                        Content =
                        new StackLayout
                        {
                            Padding = 10,
                            Children =
                            {
                                new Label { Text = "Benutzername"},
                                new Entry { Text = "Wilhelm.Brause"},
                                new Label { Text = "Passwort"},
                                new Entry { IsPassword = true},
                                new Button {Text = "Absenden"}
                            }
                        }
                    }
                }
            };
        }
    }
}