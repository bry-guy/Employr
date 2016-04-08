using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ImageCircle.Forms.Plugin.Droid;
using Resume;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(FlatButton), typeof(ButtonRenderer))]

namespace Resume.Droid
{
    [Activity(Label = "Resume", HardwareAccelerated = true, Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            FormsAppCompatActivity.ToolbarResource = Resource.Layout.toolbar;
            FormsAppCompatActivity.TabLayoutResource = Resource.Layout.tabs;

            base.OnCreate(bundle);
            Forms.Init(this, bundle);
            ImageCircleRenderer.Init();
            LoadApplication(new App());
        }
    }
}

