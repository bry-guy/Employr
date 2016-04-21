using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Resume.Views
{
    public partial class CodeView : ContentPage
    {
        public CodeView()
        {
            InitializeComponent();
            HtmlWebViewSource htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<html>  <body style='padding:0; margin:0;'> <img src='http://i.imgur.com/Bk2z4UB.jpg' width='100%' 
                    style='padding:0; margin:0;'/> content='width = device - width, initial - scale = .5, maximum - scale = 12.0, minimum - scale = .25, user - scalable = yes'/> 
                    </body> </html>";
            _sourceCodeWebsite.Source = htmlSource;
        }
    }
}
