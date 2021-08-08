using Xamarin.Forms;

namespace FormsDemo
{
public class MainPageCs : ContentPage
{
    public MainPageCs()
    {
        Title = "Login via Code";
        BackgroundColor = Color.FromHex("#2196F3");

        var outerStackLayout = new StackLayout();

        var headerStackLayout = new StackLayout();
        headerStackLayout.Padding = 30;

        var headerLabel = new Label();
        headerLabel.TextColor = Color.White;
        headerLabel.FontSize = 20;
        headerLabel.Text = "Herzlich Willkommen zur Xamarin.Forms Demo";
        headerStackLayout.Children.Add(headerLabel);

        outerStackLayout.Children.Add(headerStackLayout);

        var frame = new Frame();
        frame.BackgroundColor = Color.White;
        frame.CornerRadius = 10;
        frame.Margin = 20;

        var loginStackLayout = new StackLayout();
        loginStackLayout.Padding = 10;

        var userLabel = new Label();
        userLabel.Text = "Benutzername";
        loginStackLayout.Children.Add(userLabel);

        var userEntry = new Entry();
        userEntry.Text = "Whilem.Brause";
        loginStackLayout.Children.Add(userEntry);

        var passwordLabel = new Label();
        passwordLabel.Text = "Passwort";
        loginStackLayout.Children.Add(passwordLabel);

        var passwordEntry = new Entry();
        passwordEntry.IsPassword = true;
        loginStackLayout.Children.Add(passwordEntry);

        var loginButton = new Button();
        loginButton.Text = "Absenden";
        loginStackLayout.Children.Add(loginButton);

        frame.Content = loginStackLayout;
        outerStackLayout.Children.Add(frame);
        Content = outerStackLayout;
    }
}
}