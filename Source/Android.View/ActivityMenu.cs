using System.Collections.Generic;

using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using Android.Widget;

using Library.Android.ViewModelConnectors;

using ISoftware.Xamarin.Platforms.Model;
using ISoftware.Xamarin.Platforms.ViewModel.ViewModelMenu;

namespace ISoftware.Xamarin.Platforms.View.Android
{
    [Activity(Label = "Menu")]
    public class ActivityMenu : ActionBarActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Menu);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);

            SetSupportActionBar(toolbar);
            SupportActionBar.Title = Intent.Extras.GetString(NavigationService.KeyMenuLabel);
        }

        protected override void OnStart()
        {
            base.OnStart();

            ViewModelMenu viewModel = new ViewModelMenu(Platform.Android, Intent.Extras.GetString(NavigationService.KeyMenuIdentifier));

            SetupConnectors(viewModel);
        }

        private void SetupConnectors(ViewModelMenu viewModel)
        {
            TextView message = FindViewById<TextView>(Resource.Id.menuMessage);

            new ConnectorTextView(message, viewModel, nameof(PageMenu.Message));

            ListView listView = FindViewById<ListView>(Resource.Id.menuItems);

            List<ViewPropertyBinding> bindings = new List<ViewPropertyBinding>
            {
                new ViewPropertyBinding(Resource.Id.Title, "Label"),
                new ViewPropertyBinding(Resource.Id.Description, "Description"),
                new ViewPropertyBinding(Resource.Id.Icon, "Image")
            };

            ConnectorListView connectorListView = new ConnectorListView(this, listView, Resource.Layout.TemplateMenuItem, viewModel, viewModel.Items, bindings, "SelectedMenuItem");
        }
    }
}