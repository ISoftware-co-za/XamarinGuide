using System;
using UIKit;

namespace ISoftware.Xamarin.Platforms.View.iOS
{
    public static class Styles
    {
        public static void Initialise()
        {
            UINavigationBar.UINavigationBarAppearance navigationBarAppearance = UINavigationBar.GetAppearance(new UITraitCollection());

            navigationBarAppearance.BarTintColor = new UIColor((nfloat)(70 / 255.0), (nfloat)(130 / 255.0), (nfloat)(180 / 255.0), (nfloat)(1.0));
            navigationBarAppearance.TintColor = new UIColor(1,1,0,1);
            navigationBarAppearance.TitleTextAttributes = new UIStringAttributes
            {
                ForegroundColor = new UIColor(1, 1, 1, 1)
            };
        }
    }
}