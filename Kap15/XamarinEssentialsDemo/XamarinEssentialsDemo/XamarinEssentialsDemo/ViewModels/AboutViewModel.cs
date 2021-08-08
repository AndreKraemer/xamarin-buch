using Xamarin.Essentials;

namespace XamarinEssentialsDemo.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Über";
            Version = AppInfo.VersionString;
            Name = AppInfo.Name;
        }

        public string Name { get; }
        public string Version { get; }
    }
}