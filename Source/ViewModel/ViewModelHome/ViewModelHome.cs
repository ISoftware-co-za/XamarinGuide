using ISoftware.Xamarin.Platforms.Model;

namespace ISoftware.Xamarin.Platforms.ViewModel.ViewModelHome
{
    public class ViewModelHome : ViewModelBase
    {
        public PageMenu PageMenu { get; private set; }

        public MenuItem SelectedMenuItem
        {
            get { return _selectedMenuItem; }
            set
            {
                if (SetField(ref _selectedMenuItem, value))
                    StateViewModel.NavigationService.NavigateToMenu(value.Identifier, value.Label);
            }
        }
        private MenuItem _selectedMenuItem;


        public ViewModelHome()
        {
            PageMenu = PageMenu.Load("PageMenuHome");
        }
    }
}
