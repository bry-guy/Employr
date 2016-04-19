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

        private bool _appeared = false;

        public ResumeView()
        {
            BindingContext = new ResumeViewModel();
            InitializeComponent();

            AnimationUtilities.InitializeAppear(HighlightsTitle1, HighlightsBlurb1, HighlightsTitle2, HighlightsBlurb2);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (!_appeared)
            {
                AnimationUtilities.FeatherIn(HighlightsTitle1, HighlightsBlurb1, HighlightsTitle2, HighlightsBlurb2);
                _appeared = true;
            }

        }

        public void HandleResumeButtonPressed(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CustomWebView());
        }

        public void HandleCodeSwitchPressed(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CodeView());
        }
    }
}
