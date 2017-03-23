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
using Android.Content.PM;
using Android.Graphics;

namespace TextFieldBigForDeaf
{
    [Activity(MainLauncher = true, Icon = "@drawable/icon",ScreenOrientation = ScreenOrientation.Landscape, Theme = "@android:style/Theme.NoTitleBar")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            FindViewById<Button>(Resource.Id.clearBn).Click += delegate
            {
                FindViewById<EditText>(Resource.Id.editText).Text = "";
            };
        }

        public override void OnBackPressed()
        {
            FinishAffinity();
        }
    }
}

