using Foundation;
using System;
using UIKit;

namespace ISoftware.Xamarin.Platforms.View.iOS
{
    public partial class NavigationController : UINavigationController
    {
        public NavigationController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidAppear(bool animated)
        {
            UIStoryboard storyboard = UIStoryboard.FromName("Main", null);
            ViewControllerHome homeViewController = storyboard.InstantiateViewController("ViewControllerHome") as ViewControllerHome;

            PushViewController(homeViewController, false);
        }
    }
}