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
        public string Body { get; set; } = Constants.HomeBody;
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
