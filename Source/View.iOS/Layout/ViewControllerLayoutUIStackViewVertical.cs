using System;
using UIKit;

namespace ISoftware.Xamarin.Platforms.View.iOS
{
    public partial class ViewControllerLayoutUIStackViewVertical : UIViewController
    {
        public ViewControllerLayoutUIStackViewVertical (IntPtr handle) : base (handle)
        {
        }
        public override void ViewWillAppear(bool animated)
        {
            ViewDidAppear(animated);

            NavigationController.NavigationBar.Hidden = false;
            NavigationItem.Title = "UIStackView (Vertical)";
        }
    }
}