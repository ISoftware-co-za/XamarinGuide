using Windows.UI.Xaml.Controls;

using ISoftware.Xamarin.Platforms.ViewModel.ViewModelHome;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ISoftware.Xamarin.Platforms.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PageHome : Page
    {
        public PageHome()
        {
            this.InitializeComponent();
            
            ViewModelHome viewModel = new ViewModelHome();

            DataContext = viewModel;
        }
    }
}
