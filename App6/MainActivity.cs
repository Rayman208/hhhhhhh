using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using System.Collections.Generic;
namespace App6
{
    [Activity(Label = "App6", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 0;
        List<string> people=new List<string>();

        Button btnClick;
        TextView tvCounter;
        ListView lvPeople;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            btnClick = (Button)FindViewById(Resource.Id.buttonClick);
            tvCounter = (TextView)FindViewById(Resource.Id.textViewCounter);

            btnClick.Click += BtnClick_Click;

            people.AddRange(new string[] { "Алёша","Алина","Никита" });
            lvPeople = (ListView)FindViewById(Resource.Id.listViewPeople);

            ArrayAdapter<string> lvPeopleAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, people);

            lvPeople.Adapter = lvPeopleAdapter;


        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            count++;
            tvCounter.Text = String.Format("Нажали {0} раз",count);
        }
    }
}

