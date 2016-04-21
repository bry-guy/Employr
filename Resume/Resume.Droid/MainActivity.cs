using System;
using System.ComponentModel;
using System.Net;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Provider;
using ImageCircle.Forms.Plugin.Droid;
using Resume;
using Resume.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(FlatButton), typeof(ButtonRenderer))]
[assembly: ExportRenderer(typeof(ActionButton), typeof(ActionButtonRenderer))]
[assembly: ExportRenderer(typeof(Xamarin.Forms.ScrollView), typeof(MyScrollViewRenderer))]
[assembly: ExportRenderer(typeof(Xamarin.Forms.Label), typeof(MyLabelRenderer))]
[assembly: ExportRenderer(typeof(CustomWebView), typeof(CustomWebViewRenderer))]
[assembly: ResolutionGroupName("Employr")]

namespace Resume.Droid
{
    [Activity(Label = "Resume", HardwareAccelerated = true, Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
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

    public class MyLabelRenderer : LabelRenderer
    {
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if(e.PropertyName == Label.LineBreakModeProperty.PropertyName)
                Control.SetMaxLines(1000);
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            Control.SetMaxLines(1000);
        }
    }

    public class MyScrollViewRenderer : ScrollViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                OverScrollMode = OverScrollMode.Never;
            }
        }
    }
}

