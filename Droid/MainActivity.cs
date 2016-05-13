using Android.App;
using Android.OS;
using Android.Widget;
using Android.Content;

namespace AgilePlanningPoker.Droid
{
	[Activity(Label = "AgilePlanningPoker", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Main);

			var gridview = FindViewById<GridView> (Resource.Id.gridView1);
			gridview.Adapter = new ImageAdapter (this);

			gridview.ItemClick += gridview_ItemClick;

		}

		void gridview_ItemClick(object sender, AdapterView.ItemClickEventArgs args) {

			var displayCardActivity = new Intent (this, typeof(DisplayCard));
			displayCardActivity.PutExtra("ImagePosition",args.Position);
			StartActivity (displayCardActivity);

		}			
	}			
}


