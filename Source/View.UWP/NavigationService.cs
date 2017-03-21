using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using ISoftware.Xamarin.Platforms.ViewModel.Navigation;

namespace ISoftware.Xamarin.Platforms.UWP
{
    public class NavigationService : INavigationService
    {
        public const string KeyMenuIdentifier = "KeyMenuIdentifier";
        public const string KeyMenuLabel = "KeyMenuLabel";

        internal NavigationService(Frame frame)
        {
            _frame = frame;
        }

        public void Back()
        {
        }

        public void NavigateToMenu(string identifier, string label)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>
            {
                [KeyMenuIdentifier] = identifier,
                [KeyMenuLabel] = label
            };

            _frame.Navigate(typeof(PageMenu), parameters);
        }

        public void NavigateToPage(string identifier)
        {
        }

        private readonly Frame _frame;
    }
}
