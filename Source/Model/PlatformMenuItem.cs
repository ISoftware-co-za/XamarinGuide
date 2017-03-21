namespace ISoftware.Xamarin.Platforms.Model
{
    public class PlatformMenuItem : MenuItem
    {
        public bool SupportedOnAndroid { get; set; }

        public bool SupportedOniOS { get; set; }

        public bool SupportedOnWUP { get; set; }
    }
}
