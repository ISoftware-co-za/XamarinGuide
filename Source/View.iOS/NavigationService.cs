using System;
using ISoftware.Xamarin.Platforms.ViewModel;
using ISoftware.Xamarin.Platforms.ViewModel.Navigation;
using UIKit;

namespace ISoftware.Xamarin.Platforms.View.iOS
{
    public class NavigationService : INavigationService
    {
        public UINavigationController NavigationController { get; }

        internal NavigationService(UINavigationController navigationController)
        {
            NavigationController = navigationController;
        }

        public void Back()
        {
        }

        public void NavigateToMenu(string menuIdentifier, string label)
        {
            try
            {
                UIStoryboard storyboard = UIStoryboard.FromName("Main", null);
                ViewControllerMenu viewControllerMenu = storyboard.InstantiateViewController("ViewControllerMenu") as ViewControllerMenu;

                viewControllerMenu.MenuIdentifier = menuIdentifier;
                viewControllerMenu.Label = label;

                NavigationController.PushViewController(viewControllerMenu, true);
            }
            catch (Exception exception)
            {
                string message = exception.ToString();
            }
        }

        public void NavigateToPage(string identifier)
        {
            string viewControllerName = "";

            if (identifier == "VerticalLayout")
                viewControllerName = "ViewControllerLayoutUIStackViewVertical";
            else if (identifier == "HorizontalLayout")
                viewControllerName = "ViewControllerLayoutUIStackViewHorizontal";
            else if (identifier == "ConstraintLayout")
                viewControllerName = "ViewControllerLayoutContraints";

            UIStoryboard storyboard = UIStoryboard.FromName("Main", null);
            UIViewController viewController = storyboard.InstantiateViewController(viewControllerName) ;

            NavigationController.PushViewController(viewController, true);
        }

        public static NavigationService GetInstance()
        {
            return (NavigationService)StateViewModel.NavigationService;
        }
    }
}