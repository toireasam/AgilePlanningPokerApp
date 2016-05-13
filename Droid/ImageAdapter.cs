
using Android.Content;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace AgilePlanningPoker.Droid
{
	public class ImageAdapter : BaseAdapter
	{
		private readonly Context context;

		public ImageAdapter (Context c)
		{
			context = c;
		}

		public override int Count
		{
			get { return thumbIds.Length; }
		}

		public override Object GetItem(int position)
		{
			return null;
		}

		public override long GetItemId(int position)
		{
			return 0;
		}

		// create a new ImageView for each item referenced by the Adapter
		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			ImageView imageView;

			if (convertView == null)
			{
				// if it's not recycled, initialize some attributes
				imageView = new ImageView(context);
				imageView.LayoutParameters = new AbsListView.LayoutParams(85, 85);
				imageView.SetScaleType(ImageView.ScaleType.CenterCrop);
				imageView.SetPadding(8, 8, 8, 8);
			}
			else
			{
				imageView = (ImageView) convertView;
			}

			imageView.SetImageResource(thumbIds[position]);
			return imageView;
		}

		// references to our images
		public int[] thumbIds = {
			Resource.Drawable.card_0, Resource.Drawable.card_1,
			Resource.Drawable.card_2, Resource.Drawable.card_3,
			Resource.Drawable.card_8, Resource.Drawable.card_13,
			Resource.Drawable.card_20, Resource.Drawable.card_100,
			Resource.Drawable.card_coffee, Resource.Drawable.card_questionmark,
			Resource.Drawable.blankcard
		};
	}
}
	

