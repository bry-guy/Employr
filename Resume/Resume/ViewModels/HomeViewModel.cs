using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Plugin.Messaging;

namespace Resume.ViewModels
{
    public class HomeViewModel
    {
        public string Introduction { get; set; } = Constants.HomeIntro;
        public string Body { get; set; } = Constants.HomeBody1;
        public string Body2 { get; set; } = Constants.HomeBody2;
        public string Signature { get; set; } = Constants.HomeSignature;

        public string Title { get; set; } = "Mobile Developer";

        public Command HireButtonPressedCommand { get; set; }

        public HomeViewModel()
        {
            HireButtonPressedCommand = new Command(HandleHireButtonPressed);
        }
        
        private void HandleHireButtonPressed()
        {
            var emailMessenger = CrossMessaging.Current.EmailMessenger;
            if (emailMessenger.CanSendEmail)
            {
                emailMessenger.SendEmail("BryanJ.Smith91@gmail.com", "Future Developer Opportunities", Constants.HireButtonEmailBody);
            }
        }
        
    }
}
