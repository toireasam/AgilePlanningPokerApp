using Android.App;
using Android.OS;
using Android.Widget;
using Android.Content;

namespace AgilePlanningPoker.Droid
{
    [Activity(Label = "AgilePlanningPoker", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Main);

			var gridview = FindViewById<GridView> (Resource.Id.gridview);
			gridview.Adapter = new ImageAdapter (this);

			gridview.ItemClick += gridview_ItemClick;

		}

		void gridview_ItemClick(object sender, AdapterView.ItemClickEventArgs args) {

			//StartActivity(typeof(Activity2));
			var activity2 = new Intent (this, typeof(Activity2));
			//activity2.PutExtra ("MyData", "Data from Activity1");
			activity2.PutExtra("ImagePosition",args.Position);
			StartActivity (activity2);
		
			}			
		}			
 }

