using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamarinEssentialsDemo.ViewModels
{
    public class MediaViewModel : BaseViewModel
    {
        private ImageSource _image;
        public Command OpenGalleryCommand { get; }
        public Command OpenCameraCommand { get; }

        public ImageSource Image
        {
            get => _image;
            set => SetProperty(ref _image, value);
        }

        public MediaViewModel()
        {
            OpenGalleryCommand = new Command(OnGalleryClicked);
            OpenCameraCommand = new Command(OnCameraClicked);
        }

        private async void OnGalleryClicked()
        {
            // Foto auswählen
            var result = await MediaPicker.PickPhotoAsync(); 
            // Ergebnis auslesen
            var stream = await result.OpenReadAsync();
            // Ergebnisstream zur Anzeige an die Eigenschaft Image übergeben
            Image = ImageSource.FromStream(() => stream);
        }

        private async void OnCameraClicked()
        {
            // Foto aufnehmen
            var result = await MediaPicker.CapturePhotoAsync();
            // Ergebnis auslesen
            var stream = await result.OpenReadAsync();
            // Ergebnisstream zur Anzeige an die Eigenschaft Image übergeben
            Image = ImageSource.FromStream(() => stream);
        }
    }
}
