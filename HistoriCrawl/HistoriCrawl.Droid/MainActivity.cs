using Android.App;
using Android.OS;
using Android.Widget; 
using HistoriCrawl.Portable;

namespace HistoriCrawl.Droid
{
	[Activity(Label = "HistoriCrawl", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.Main);

			// Get a handle on the list
			var markerList = FindViewById<ListView>(Resource.Id.markerListView);

			// Set the list adapter
//			markerList.Adapter = new ArrayAdapter<Marker>(this, Android.Resource.Layout.SimpleListItem1, MarkerData.Markers);
			markerList.Adapter = new MarkerAdapter(this, MarkerData.Markers);

			markerList.ItemClick +=   OnItemClick;
		}

		void OnItemClick(object sender, AdapterView.ItemClickEventArgs e)
		{
			var marker = MarkerData.Markers[e.Position];

			var dialog = new AlertDialog.Builder(this);
			dialog.SetMessage(marker.Title);
			dialog.SetNeutralButton("OK", delegate { });
			dialog.Show();
		}
	}
}


/* using System;

//using Android.App;
//using Android.Content;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;
//using Android.OS;

namespace HistoriCrawl.Droid
{
	[Activity (Label = "HistoriCrawl.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};
		}
	}
}
*/

