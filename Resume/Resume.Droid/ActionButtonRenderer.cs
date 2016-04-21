using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;
using Resume;
using Resume.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace Resume.Droid
{
    class ActionButtonRenderer : ViewRenderer<ActionButton,FloatingActionButton>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ActionButton> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                //unhook
            }

            if (e.NewElement != null)
            {
                //hook
                if (Control == null)
                {
                    var fab = new FloatingActionButton(Context);
                    SetNativeControl(fab);
                    fab.Click += FabOnClick;
                    fab.SetImageResource(Resource.Drawable.codeIcon);
                }
            }
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            Element.InvokeSendClicked();
        }
    }
}