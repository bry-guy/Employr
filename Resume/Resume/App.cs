using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Resume.Views;

//todo: setup .apk download
//todo: add splash screen

//post-evolve
//todo: refactor names
//todo: iOS compat
//todo: proper tablet support
//todo: zoomable code images
//todo: built-in entry/twitter feed (or something like a facebook wall?)
//todo: add top-level master-detail menu w/ bodies of work

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
