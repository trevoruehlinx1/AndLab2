using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Content;

namespace _99Bugs
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var oneDownButton = FindViewById<Button>(Resource.Id.takeOneDownButton);
            var twoDownButton = FindViewById<Button>(Resource.Id.takeTwoDownButton);
            var countMessageLabel = FindViewById<TextView>(Resource.Id.firstActivityOutputLabel);

            var newTotalBugs = Intent.GetIntExtra("totalBugs", 0);

            if (newTotalBugs > 0)
                countMessageLabel.Text = newTotalBugs.ToString() + " bugs in your code!";


            oneDownButton.Click += (sender, e) =>
            {
                var second = new Intent(this, typeof(SecondActivity));
                second.PutExtra("number", 1);
                if(newTotalBugs > 0)
                    second.PutExtra("totalBugs1", newTotalBugs);
                StartActivity(second);
            };
            twoDownButton.Click += (sender, e) =>
            {
                var second = new Intent(this, typeof(SecondActivity));
                second.PutExtra("number", 2);
                if(newTotalBugs > 0)
                    second.PutExtra("totalBugs1", newTotalBugs);
                StartActivity(second);
            };
        }
    }
}