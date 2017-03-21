
using Android.App;
using Android.Runtime;
using ISoftware.Xamarin.Platforms.ViewModel;
using System;

namespace ISoftware.Xamarin.Platforms.View.Android
{
    [Application]
    public class AndroidApplication : Application
    {
        public AndroidApplication(IntPtr handle, JniHandleOwnership ownerShip) : base(handle, ownerShip)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();

            StateViewModel.Initialise(new NavigationService(Context));
        }
    }
}