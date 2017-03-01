using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using APOAPP.Droid.Resources;

namespace APOAPP.Droid
{
	[Activity (Label = "APOAPP.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{            
            base.OnCreate (bundle);
            //hide title bar 
           // Window.RequestFeature(WindowFeatures.NoTitle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            //setup tabs
            this.ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;            

            AddTab(Resource.Drawable.Icon, new TabSubscribed());
            AddTab(Resource.Drawable.Icon, new TabGPS());
            AddTab(Resource.Drawable.Icon, new TabSearch());
            AddTab(Resource.Drawable.Icon, new TabContact());
            AddTab(Resource.Drawable.Icon, new TabSettings());
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            outState.PutInt("tab", this.ActionBar.SelectedNavigationIndex);

            base.OnSaveInstanceState(outState);
        }

        void AddTab(/*string tabText,*/ int iconResourceId, Fragment view)
        {
            var tab = this.ActionBar.NewTab();
            //tab.SetText(tabText);
            tab.SetIcon(Resource.Drawable.Icon);

            // must set event handler before adding tab
            tab.TabSelected += delegate (object sender, ActionBar.TabEventArgs e)
            {
                var fragment = this.FragmentManager.FindFragmentById(Resource.Id.fragmentContainer);
                if (fragment != null)
                    e.FragmentTransaction.Remove(fragment);
                e.FragmentTransaction.Add(Resource.Id.fragmentContainer, view);
            };
            tab.TabUnselected += delegate (object sender, ActionBar.TabEventArgs e) {
                e.FragmentTransaction.Remove(view);
            };

            this.ActionBar.AddTab(tab);
        }
    }    
}


