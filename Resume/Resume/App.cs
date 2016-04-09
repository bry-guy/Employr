using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Resume.Views;

//views
//todo: investigate moving styles to separate file
//todo: update background image to adjust for dpi
//todo: create unique animations for each page

//models
//todo: prevent rotation on iOS and Android
//todo: add side scrollbar
//todo: add calculator to scrollbar
//todo: finish android app
//todo: test android app against wide range of devices
//todo: cleanup calculator visuals quickly
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
