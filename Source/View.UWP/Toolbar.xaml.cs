using Windows.UI.Xaml.Controls;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace ISoftware.Xamarin.Platforms.UWP
{
    public sealed partial class Toolbar : UserControl
    {
        public string Title
        {
            get { return TitleTextBlock.Text; }
            set { TitleTextBlock.Text = value; }
        }

        public Toolbar()
        {
            this.InitializeComponent();
        }
    }
}
