using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Resume.Views;

//models
//todo: high-res code pics
//todo: re-do resume and PDF
//todo: refactor names
//todo: setup .apk download
//todo: finalize images (leave hosted on imgur? size differences?)
//todo: finish android app
//todo: test android app against wide range of devices
//todo: setup .apk download
//todo: prevent rotation on iOS
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
            tabPage.PropertyChanged += TabPageOnPropertyChanged;
            tabPage.Children.Add(new HomeView());
            tabPage.Children.Add(new ResumeView());
            tabPage.Children.Add(new ContactView());
            MainPage = navPage;
        }

        private void TabPageOnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var tabPage = (TabbedPage)sender;

            if (e.PropertyName.Equals("CurrentPage"))
            {
                var myPage = (IIntroAnimation) tabPage.CurrentPage;
                myPage.RunIntroAnimations();
            }

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
