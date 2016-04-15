using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Resume.ViewModels
{
    public class ContactViewModel
    {
        public ICommand TapCommand { get; set; }

        public Uri TwitterUri { get; set; }
        public Uri LinkedinUri { get; set; }
        public Uri EmailUri { get; set; }
        public Uri GithubUri { get; set; }
           
        public ContactViewModel()
        {
            TapCommand = new Command(StartApplication);
            TwitterUri = new Uri("https://www.twitter.com/BJSmith91");
            LinkedinUri = new Uri("https://www.linkedin.com/in/bryan-smith-41552658?trk=hp-identity-name");
            EmailUri = new Uri("mailto:BryanJ.Smith91@gmail.com");
            GithubUri = new Uri("https://github.com/bryansmi");
        }

        private static void StartApplication(object s) 
        {
            try
            {
                Device.OpenUri((Uri)s);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

    }
}
