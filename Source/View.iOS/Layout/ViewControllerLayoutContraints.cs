using System;
using UIKit;

namespace ISoftware.Xamarin.Platforms.View.iOS
{
    public partial class ViewControllerLayoutContraints : UIViewController
    {
        public ViewControllerLayoutContraints (IntPtr handle) : base (handle)
        {
        }

        public override void ViewWillAppear(bool animated)
        {
            ViewDidAppear(animated);

            NavigationController.NavigationBar.Hidden = false;
            NavigationItem.Title = "NSLayoutConstraint";
        }
    }
}