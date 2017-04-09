using System;
using Android.Content;
using ISoftware.Xamarin.Platforms.View.Android.Layout;
using ISoftware.Xamarin.Platforms.ViewModel.Navigation;

namespace ISoftware.Xamarin.Platforms.View.Android
{
    public class NavigationService : INavigationService
    {
        public const string KeyMenuIdentifier = "MenuIdentifier";
        public const string KeyMenuLabel = "MenuLabel";

        internal NavigationService(Context context)
        {
            _context = context;
        }

        public void Back()
        {
        }

        public void NavigateToMenu(string identifier, string label)
        {
            Intent navigationIntent = new Intent(_context, typeof(ActivityMenu));

            navigationIntent.AddFlags(ActivityFlags.NewTask);

            navigationIntent.PutExtra(KeyMenuIdentifier, identifier);
            navigationIntent.PutExtra(KeyMenuLabel, label);

            _context.StartActivity(navigationIntent);
        }

        public void NavigateToPage(string identifier)
        {
            try
            {
                Type activityType = null;

                if (identifier == "VerticalLayout")
                    activityType = typeof(ActivityLayoutLinearLayoutVertical);
                else if (identifier == "HorizontalLayout")
                    activityType = typeof(ActivityLayoutLinearLayoutHorizontal);
                else if (identifier == "RelativeLayout")
                    activityType = typeof(ActivityLayoutRelativeLayout);
                else if (identifier == "FrameLayout")
                    activityType = typeof(ActivityLayoutFrameLayout);

                Intent navigationIntent = new Intent(_context, activityType);

                navigationIntent.AddFlags(ActivityFlags.NewTask);

                _context.StartActivity(navigationIntent);
            }
            catch (Exception e)
            {
                string wtf = e.ToString();
            }
        }

        private readonly Context _context;
    }
}