
using System;
using System.Collections.Generic;
using CoreGraphics;
using Library.iOS.ViewModelConnectors;

using UIKit;

using ISoftware.Xamarin.Platforms.Model;
using ISoftware.Xamarin.Platforms.ViewModel.ViewModelMenu;

namespace ISoftware.Xamarin.Platforms.View.iOS
{
    public partial class ViewControllerMenu : UIViewController
    {
        public string Label { get; set; }

        public string MenuIdentifier { get; set; }

        public ViewControllerMenu (IntPtr handle) : base (handle)
        {
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            NavigationController.NavigationBar.Hidden = false;
            NavigationItem.Title = Label;

            ViewModelMenu viewModel = new ViewModelMenu(Platform.iOS, MenuIdentifier);

            new ConnectorUITextView().Connect(Message, viewModel, nameof(viewModel.Message));

            List<UITableViewCellViewBinding> tableCellBindings = new List<UITableViewCellViewBinding>
            {
                new UITableViewCellViewBinding(UITableViewCellViewIdentifier.TextLabel, nameof(MenuItem.Label)),
                new UITableViewCellViewBinding(UITableViewCellViewIdentifier.DetailTextLabel, nameof(MenuItem.Description)),
                new UITableViewCellViewBinding(UITableViewCellViewIdentifier.ImageView, nameof(MenuItem.Image)),
            };

            new ConnectorUITableView(Items, UITableViewCellStyle.Subtitle, UITableViewCellAccessory.DisclosureIndicator, viewModel, viewModel.Items, tableCellBindings, nameof(viewModel.SelectedMenuItem));
        }
    }
}
