using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;
using HistoriCrawl.Portable;

namespace HistoriCrawl.Droid
{
	public class MarkerAdapter : BaseAdapter<Marker>
	{
		Activity context;
		List<Marker> markers;

		public MarkerAdapter(Activity context, List<Marker> markers)
		{
			this.context = context;
			this.markers = markers;
		}

		public override Marker this[int position]
		{
			get
			{
				return markers[position];
			}
		}

		public override int Count
		{
			get
			{
				return markers.Count;
			}
		}

		public override long GetItemId(int position)
		{
			return position;
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			var view = context.LayoutInflater.Inflate(Resource.Layout.MarkerRow, parent, false);

			var number = view.FindViewById<TextView>(Resource.Id.numberTextView);
			var title = view.FindViewById<TextView >(Resource.Id.titleTextView);
			var location = view.FindViewById<TextView >(Resource.Id.locationTextView);

			number.Text = markers[position].Number.ToString();;
			title.Text = markers[position].Title;
			location.Text = markers[position].Location;

			return view;
		}
	}
}