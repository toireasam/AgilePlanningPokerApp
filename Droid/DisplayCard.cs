
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Threading.Tasks;

namespace AgilePlanningPoker.Droid
{
	[Activity (Label = "DisplayCard")]			
	public class DisplayCard : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.Layout2);

			// Create your application here
			//string text = Intent.GetStringExtra ("MyData") ?? "Data not available";
			string whatINeed = Intent.GetStringExtra ("ImagePosition" ?? "");
			int position = 0;
			int whatINeed2 = Intent.GetIntExtra ("ImagePosition", position);



			TextView text = FindViewById<TextView> (Resource.Id.textView1);
			//text.Text = whatINeed;

			ImageAdapter imageAdapter = new ImageAdapter (this);
			ImageView imageView = FindViewById<ImageView>(Resource.Id.imageView1);
			imageView.SetImageResource (imageAdapter.thumbIds [whatINeed2]);

			TaskScheduler uiContext = TaskScheduler.FromCurrentSynchronizationContext();
			Console.WriteLine("timer started");
			Task.Delay(5000).ContinueWith((task) =>
				{
					//Do UI stuff
					text.Text = "!!";
					Console.WriteLine("timer stopped");
					imageView.SetImageResource (imageAdapter.thumbIds [10]);
				} , uiContext);

			TaskScheduler uiContext2 = TaskScheduler.FromCurrentSynchronizationContext();
			Console.WriteLine("timer started");
			Task.Delay(10000).ContinueWith((task) =>
				{
					//Do UI stuff
					text.Text = "!!";
					Console.WriteLine("timer stopped");
					imageView.SetImageResource (imageAdapter.thumbIds [whatINeed2]);
				} , uiContext);					
		}




	}

}
