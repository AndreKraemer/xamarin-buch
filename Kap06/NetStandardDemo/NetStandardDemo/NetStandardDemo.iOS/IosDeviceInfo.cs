namespace NetStandardDemo.iOS
{
    public class IosDeviceInfo : IDeviceInfo
    {
        public string GetName()
        {
            return UIKit.UIDevice.CurrentDevice.Name;
        }
    }

}