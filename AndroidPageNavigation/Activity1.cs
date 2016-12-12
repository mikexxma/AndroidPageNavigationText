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

namespace AndroidPageNavigation
{
    [Activity(Label = "Activity1")]
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout1);
            Button btnBack = FindViewById<Button>(Resource.Id.button1);
            btnBack.Click += delegate
            {
                StartActivity(typeof(MainActivity));
            };

            Button bt2 = FindViewById<Button>(Resource.Id.button2);
            TextView tv1 = FindViewById<TextView>(Resource.Id.textView1);
            bt2.Click += delegate
            {
                tv1.Text = "Hello";
            };
            // Create your application here
        }
    }
}