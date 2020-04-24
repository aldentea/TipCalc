using System;

using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Views;

using TipCalc.Core;

namespace TipCalc.Droid
{
	[Application]
	public class MainApplication : MvxAndroidApplication<MvxAndroidSetup<App>, App>
	{
		public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
			: base(javaReference, transfer)
		{ }

	}
}