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
    public partial class ContactView : ContentPage
    {
        private bool _appeared = false;

        public ContactView()
        {
            BindingContext = new ContactViewModel();
            InitializeComponent();

            //AnimationUtilities.InitializeAnimations(ContactLabel, TwitterWhiteLogo, TwitterText, 
            //    LinkedinWhiteLogo, LinkedinText, GmailLogo, GmailText, GithubLogo, GithubText);
        }

        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    if (!_appeared)
        //    {
        //        AnimationUtilities.FeatherIn(ContactLabel, TwitterWhiteLogo, TwitterText,
        //        LinkedinWhiteLogo, LinkedinText, GmailLogo, GmailText, GithubLogo, GithubText);
        //        _appeared = true;
        //    }

        //}

        //private async void FlipImage(VisualElement elem, int index)
        //{
        //    switch (index)
        //    {
        //        case 0:
        //            await elem.RotateTo(360, 250);
        //            BryanImage.Source = "http://filmgarb.com/wp-content/uploads/tv-futurama-1999_-philip_j_fry-billy_west-tops-s07e03-fry_red_jacket.jpg";
        //            imageIndex++;
        //            break;
        //        case 1:
        //            //insert code preview page
        //            imageIndex++;
        //            break;
        //        case 2:
        //            //insert actual embedded editor app
        //            imageIndex++;
        //            break;
        //    }
        //}

        //private void AddTapToConnect(Image elem, Uri uri, Command command) //add uri paramater
        //{
        //    ConnectThroughService = new Command(HandleImagePressed);
        //    elem.GestureRecognizers.Add(new TapGestureRecognizer
        //    {
        //        Command = ConnectThroughService,
        //        CommandParameter = uri,
        //    });
        //}

    }
}
