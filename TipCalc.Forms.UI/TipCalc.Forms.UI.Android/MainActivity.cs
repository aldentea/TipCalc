using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using MvvmCross.Forms.Platforms.Android.Core;
using MvvmCross.Forms.Platforms.Android.Views;

using TipCalc.Core;
//using TipCalc.Forms.UI;

namespace TipCalc.Forms.UI.Droid
{
	[Activity(Label = "TipCalc.Forms.Droid", Theme = "@style/MainTheme", MainLauncher = true,
	ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
	LaunchMode = LaunchMode.SingleTask)]

	public class MainActivity : MvxFormsAppCompatActivity<MvxFormsAndroidSetup<App, FormsApp>, App, FormsApp>
	{

		protected override void OnCreate(Bundle savedInstanceState)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;
			base.OnCreate(savedInstanceState);
			//Xamarin.Essentials.Platform.Init(this, savedInstanceState);
			//SetContentView(Resource.Layout.activity_main);

			//Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
			//SetSupportActionBar(toolbar);

			//FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
			//fab.Click += FabOnClick;
		}

	}
}