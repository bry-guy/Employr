using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.ViewModels;
using Xamarin.Forms;


//todo: refactor name
//todo: move logic for button to viewmodel using events

namespace Resume.Views
{
    public partial class ResumeView : ContentPage
    {

        public bool appeared = false;

        public ResumeView()
        {
            BindingContext = new ResumeViewModel();
            InitializeComponent();

            AnimationUtilities.InitializeAnimations(HighlightsTitle1, HighlightsBlurb1, HighlightsTitle2, HighlightsBlurb2);
        }

        public void HandleResumeClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CustomWebView());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (!appeared)
            {
                AnimationUtilities.FeatherIn(HighlightsTitle1, HighlightsBlurb1, HighlightsTitle2, HighlightsBlurb2);
                appeared = true;
            }

        }
    }
}
