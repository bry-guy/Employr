using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Resume.Views;

//views
//todo: implement label styles
//todo: investigate moving styles to separate file
//todo: find good background images
//todo: investigate if multiple sizes are needed
//todo: update styles/colors to look good with backgrounds
//todo: create unique animations for each page

//models
//todo: cleanup calculator visuals quickly
//todo: add side scrollbar
//todo: add calculator to scrollbar
//todo: finish android app
//todo: test android app against wide range of devices
//todo: tweak/fix for iOS
//todo: test iOS app

namespace Resume
{
    public class App : Application
    {
        public App()
        {
            var tabPage = new TabbedPage {Title = "Employr", };
            var navPage = new NavigationPage(tabPage);
            tabPage.Children.Add(new HomeView());
            tabPage.Children.Add(new ResumeView());
            tabPage.Children.Add(new ContactView());
            MainPage = navPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

    }
}
