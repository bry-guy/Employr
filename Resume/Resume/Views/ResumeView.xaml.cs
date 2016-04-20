using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.ViewModels;
using Xamarin.Forms;

namespace Resume.Views
{
    public partial class ResumeView : ContentPage, IIntroAnimation
    {

        private bool _appeared = false;

        public ResumeView()
        {
            BindingContext = new ResumeViewModel();
            InitializeComponent();

            AnimationUtilities.InitializeAppear(HighlightsTitle1, HighlightsBlurb1, HighlightsTitle2, HighlightsBlurb2);
        }

        public void HandleResumeButtonPressed(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CustomWebView());
        }

        public void HandleCodeSwitchPressed(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CodeView());
        }

        public void RunIntroAnimations()
        {
            if (!_appeared)
            {
                AnimationUtilities.FeatherIn(HighlightsTitle1, HighlightsBlurb1, HighlightsTitle2, HighlightsBlurb2);
                _appeared = true;
            }
        }
    }
}
