using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidPageNavigation
{
    [Activity(Label = "AndroidPageNavigation", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button bt;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);
            Button btnProfil = FindViewById<Button>(Resource.Id.button1);

            btnProfil.Click += delegate
            {
                StartActivity(typeof(Activity1));
            };
        }
    }
}

