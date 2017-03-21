using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace ISoftware.Xamarin.Platforms.View.Android.Layout
{
    [Activity(Label = "ActivityLayoutLinearLayoutHorizontal")]
    public class ActivityLayoutLinearLayoutHorizontal : ActionBarActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.LayoutLinearLayoutHorizontal);

            global::Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);

            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "LinearLayout (vertical)";
        }
    }
}