using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Employr.Views
{
    public partial class CodeView : ContentPage
    {
        private Uri uri;
        public CodeView(Uri uri)
        {
            this.uri = uri;
            InitializeComponent();

            
            HtmlWebViewSource htmlSource = new HtmlWebViewSource();
            htmlSource.Html = String.Format("<html> <head> " +
                                            "<meta name='viewport'; content='width=device-width; initial-scale=0.5; user-scalable=yes;' /> </head>" +
                                            "<title></title> " +
                                            "<body style='padding:0; margin:0;'> "+
                                            "<img src='{0}' width='100%' style='padding:0; margin:0; '/> " + 
                                            "</body> </html>", uri);
            _sourceCodeWebsite.Source = htmlSource;
        }
    }
}
