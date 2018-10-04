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

namespace _99Bugs
{
    [Activity(Label = "SecondActivity1")]
    public class SecondActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.secondActivity);
            
            var bugCountLabel = FindViewById<TextView>(Resource.Id.secondActivityOutputLabel);
            var patchButton = FindViewById<Button>(Resource.Id.PatchItAroundButton);
            var bugsRemoved = Intent.GetIntExtra("number", 0);
            var totalBugs = Intent.GetIntExtra("totalBugs1",99);
            var newTotalBugs = totalBugs - bugsRemoved;

            bugCountLabel.Text = newTotalBugs.ToString();

            patchButton.Click += (sender, e) =>
            {
                var firstPage = new Intent(this, typeof(MainActivity));
                firstPage.PutExtra("totalBugs", newTotalBugs);
                StartActivity(firstPage);
            };




            // Create your application here
        }
    }
}