using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Employr.Views;

//iOS
//fix splashscreen on each device
//fix colors
//fix images
//fix scrolling
//fix fab

//post-evolve
//todo: reconcile OnScrolled functions, investigate AnimationUtilities function
//todo: better organize colors
//todo: proper tablet support
//todo: zoomable code images
//todo: built-in entry/twitter feed (or something like a facebook wall?)
//todo: add top-level master-detail menu w/ bodies of work

namespace Employr
{
    public class App : Application
    {
        public App()
        {
            var tabPage = new TabbedPage {Title = "Employr", };
            var navPage = new NavigationPage(tabPage);
            tabPage.PropertyChanged += TabPageOnPropertyChanged;
            tabPage.Children.Add(new BioView());
            tabPage.Children.Add(new HighlightsView());
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
