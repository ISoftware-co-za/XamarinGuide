using System;
using Windows.UI.Xaml.Data;

namespace ISoftware.Xamarin.Platforms.UWP
{
    internal class ImageFileNameToImagePathConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return $"Assets\\Icons\\{value}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
