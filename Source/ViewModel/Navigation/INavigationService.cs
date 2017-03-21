namespace ISoftware.Xamarin.Platforms.ViewModel.Navigation
{
    public interface INavigationService
    {
        void Back();

        void NavigateToMenu(string menuIdentifier, string label);

        void NavigateToPage(string identifier);
    }
}
