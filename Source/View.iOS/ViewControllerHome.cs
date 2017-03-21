using System;
using System.Collections.Generic;
using ISoftware.Xamarin.Platforms.Model;

using UIKit;

using Library.iOS.ViewModelConnectors;
using ISoftware.Xamarin.Platforms.ViewModel.ViewModelHome;

namespace ISoftware.Xamarin.Platforms.View.iOS
{
    public partial class ViewControllerHome : UIViewController
    {
        public ViewControllerHome(IntPtr handle) : base(handle)
        {
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            NavigationController.NavigationBar.Hidden = true;

            ViewModelHome viewModel = new ViewModelHome();

            new ConnectorUITextView().Connect(Message, viewModel.PageMenu, nameof(viewModel.PageMenu.Message));

            List<UITableViewCellViewBinding> tableCellBindings = new List<UITableViewCellViewBinding>
            {
                new UITableViewCellViewBinding(UITableViewCellViewIdentifier.TextLabel, nameof(MenuItem.Label)),
                new UITableViewCellViewBinding(UITableViewCellViewIdentifier.DetailTextLabel, nameof(MenuItem.Description)),
                new UITableViewCellViewBinding(UITableViewCellViewIdentifier.ImageView, nameof(MenuItem.Image)),
            };

            new ConnectorUITableView(Items, UITableViewCellStyle.Subtitle, UITableViewCellAccessory.DisclosureIndicator, viewModel, viewModel.PageMenu.Items, tableCellBindings, nameof(viewModel.SelectedMenuItem));
        }
    }
}