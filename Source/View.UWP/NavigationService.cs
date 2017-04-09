using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using ISoftware.Xamarin.Platforms.UWP.Layout;
using ISoftware.Xamarin.Platforms.ViewModel.Navigation;
using Library.Common.Exceptions;

namespace ISoftware.Xamarin.Platforms.UWP
{
    public class NavigationService : INavigationService
    {
        public const string KeyMenuIdentifier = "KeyMenuIdentifier";
        public const string KeyMenuLabel = "KeyMenuLabel";

        internal NavigationService(Frame frame)
        {
            _frame = frame;

            Windows.UI.Core.SystemNavigationManager.GetForCurrentView().BackRequested += (sender, e) =>
            {
                _frame.GoBack();
                e.Handled = true;
            };
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
            Type pageType = null;

            if (identifier == "VerticalLayout")
                pageType = typeof(PageLayoutStackPanelVertical);
            else if (identifier == "HorizontalLayout")
                pageType = typeof(PageLayoutStackPanelHorizontal);
            else if (identifier == "RelativeLayout")
                pageType = typeof(PageLayoutRelativePanel);
            else if (identifier == "GridLayout")
                pageType = typeof(PageLayoutGrid);
            else if (identifier == "Border")
                pageType = typeof(PageLayoutBorder);
            else if (identifier == "WrapGridVertical")
                pageType = typeof(PageLayoutVariableWidthWrapGridVertical);
            else if (identifier == "WrapGridHorizontal")
                pageType = typeof(PageLayoutVariableWidthWrapGridHorizontal);
            else if (identifier == "AbsoluteLayout")
                pageType = typeof(PageLayoutAbsolute);
            else
                throw new DeveloperException($"Cannot navigate to {identifier} as it is an undefined destination.");

            _frame.Navigate(pageType, null);
        }

        private readonly Frame _frame;
    }
}
