using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Resume.Views;

//models
//todo: setup website and make business cards
//todo: enable zoom in webview
//todo: hide strings away in files
//todo: cleanup XAML and code files
//todo: finalize images (leave hosted on imgur? size differences?)
//todo: finish android app
//todo: test android app against wide range of devices
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
