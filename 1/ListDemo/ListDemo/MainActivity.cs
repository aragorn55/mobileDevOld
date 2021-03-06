using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace ListDemo
{
	[Activity (Label = "ListDemo", MainLauncher = true)]
	public class MainActivity : Activity
	{
		List<string> ViewNames = new List<string> ();

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			ViewNames.Add ("View One");
			ViewNames.Add ("View Two");
			ViewNames.Add ("View Three");


			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			ListView lstViews = FindViewById<ListView> (Resource.Id.lstViews);

			ArrayAdapter ListAdapter = new ArrayAdapter (this, Android.Resource.Layout.SimpleListItem1, ViewNames);
			lstViews.Adapter = ListAdapter;


			lstViews.ItemClick += delegate(object sender, AdapterView.ItemClickEventArgs e) {
				switch(e.Position){
					case 0:
					{
						StartActivity(typeof(One));
						break;
					}
					case 1:
					{
						StartActivity(typeof(Two));
						break;
					}
					case 2:
					{
						StartActivity(typeof(Three));
						break;
					}
				}
			};

		}
	}
}


