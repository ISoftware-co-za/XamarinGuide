using System.Collections.Generic;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

using ISoftware.Xamarin.Platforms.ViewModel.ViewModelMenu;

namespace ISoftware.Xamarin.Platforms.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PageMenu : Page
    {
        public PageMenu()
        {
            InitializeComponent();

            Loaded += (sender, args) =>
            {
                ViewModelMenu viewModel = new ViewModelMenu(Platform.UWP, _navigationParameters[NavigationService.KeyMenuIdentifier]);

                Toolbar.Title = _navigationParameters[NavigationService.KeyMenuLabel];
                DataContext = viewModel;
            };
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            _navigationParameters = e.Parameter as Dictionary<string, string>;
        }

        private Dictionary<string, string> _navigationParameters;
    }
}

