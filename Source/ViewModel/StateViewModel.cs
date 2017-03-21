using ISoftware.Xamarin.Platforms.Model;
using ISoftware.Xamarin.Platforms.ViewModel.Navigation;

namespace ISoftware.Xamarin.Platforms.ViewModel
{
    public static class StateViewModel
    {
        public static INavigationService NavigationService { get; set; }

        public static void Initialise(INavigationService navigationService)
        {
            NavigationService = navigationService;

            StateModel.Initialise();
        }
    }
}
