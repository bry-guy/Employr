using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.ViewModels;
using Xamarin.Forms;

namespace Resume.Views
{
    public partial class ContactView : ContentPage, IIntroAnimation
    {
        private bool _appeared = false;

        public ContactView()
        {
            BindingContext = new ContactViewModel();
            InitializeComponent();

            AnimationUtilities.InitializeAppear(TwitterWhiteLogo, TwitterText, 
                LinkedinWhiteLogo, LinkedinText, GmailLogo, GmailText, GithubLogo, GithubText);
        }

        public void HandleCodeSwitchPressed(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CodeView());
        }

        public void RunIntroAnimations()
        {
            if (!_appeared)
            {
                AnimationUtilities.FeatherIn(TwitterWhiteLogo, TwitterText,
                LinkedinWhiteLogo, LinkedinText, GmailLogo, GmailText, GithubLogo, GithubText);
                _appeared = true;
            }
        }
    }
}
