using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.ViewModels;
using Xamarin.Forms;


//todo: sketch out/overhaul page layout, refactor name
//todo: create todo list

namespace Resume.Views
{
    public partial class ResumeView : ContentPage
    {
        public ResumeView()
        {
            BindingContext = new ResumeViewModel();
            InitializeComponent();
        }

        public void HandleResumeClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CustomWebView());
        }
    }
}
