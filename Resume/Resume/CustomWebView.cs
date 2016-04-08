using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Resume
{
    public class CustomWebView : WebView
    {
        public static readonly BindableProperty UriProperty = BindableProperty.Create(
            propertyName:"Uri",
            returnType:typeof(string),
            declaringType:typeof(CustomWebView),
            defaultValue:default(string)
            );

        public string Uri
        {
            get { return (string) GetValue(UriProperty); }
            set { SetValue(UriProperty, value); }
        }
    }
}
