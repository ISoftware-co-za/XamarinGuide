using System.Collections.Generic;
using Android.App;
using Android.OS;

using Android.Support.V7.App;
using Android.Widget;
using ISoftware.Xamarin.Platforms.Model;
using Library.Android.ViewModelConnectors;

using ISoftware.Xamarin.Platforms.ViewModel.ViewModelHome;

namespace ISoftware.Xamarin.Platforms.View.Android
{
    [Activity(Label = "ISoftware.Xamarin.Platforms.View.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class ActivityMain : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView (Resource.Layout.Main);
        }

        protected override void OnStart()
        {
            base.OnStart();

            ViewModelHome viewModel = new ViewModelHome();

            SetupConnectors(viewModel);
        }

        private void SetupConnectors(ViewModelHome viewModel)
        {
            TextView message = FindViewById<TextView>(Resource.Id.mainMessage);

            new ConnectorTextView(message, viewModel.PageMenu, nameof(PageMenu.Message));

            ListView listView = FindViewById<ListView>(Resource.Id.mainItems);

            List<ViewPropertyBinding> bindings = new List<ViewPropertyBinding>
            {
                new ViewPropertyBinding(Resource.Id.Title, "Label"),
                new ViewPropertyBinding(Resource.Id.Description, "Description"),
                new ViewPropertyBinding(Resource.Id.Icon, "Image")
            };

            ConnectorListView connectorListView = new ConnectorListView(this, listView, Resource.Layout.TemplateMenuItem, viewModel, viewModel.PageMenu.Items, bindings, "SelectedMenuItem");
        }
    }
}

