using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Messaging;

namespace Employr.ViewModels
{
    public class BioViewModel
    {
        public string Title { get; set; } = "Mobile Developer";
        public string Body { get; set; } = Constants.HomeBody;
        public string Credits { get; set; } = Constants.Credits;

        public Command HireButtonPressedCommand { get; set; }

        public BioViewModel()
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
