using System.Collections.Generic;
using System.Linq;
using ISoftware.Xamarin.Platforms.Model;

namespace ISoftware.Xamarin.Platforms.ViewModel.ViewModelMenu
{
    public class ViewModelMenu : ViewModelBase
    {
        public string Message { get; private set; }

        public List<PlatformMenuItem> Items { get; private set; }

        public PlatformMenuItem SelectedMenuItem
        {
            get { return _selectedMenuItem; }
            set
            {
                if (SetField(ref _selectedMenuItem, value))
                    StateViewModel.NavigationService.NavigateToPage(value.Identifier);
            }
        }
        private PlatformMenuItem _selectedMenuItem;

        public ViewModelMenu(Platform platform, string identifier)
        {
            PlatformPageMenu menu = PlatformPageMenu.Load(identifier);

            bool isAndroid = platform == Platform.Android;
            bool isiOS = platform == Platform.iOS;
            bool isWUP = platform == Platform.UWP;

            Message = menu.Message;
            Items = menu.Items.Where(item => (isAndroid && item.SupportedOnAndroid) || (isiOS && item.SupportedOniOS) || (isWUP && item.SupportedOnWUP)).ToList();
        }
    }
}
