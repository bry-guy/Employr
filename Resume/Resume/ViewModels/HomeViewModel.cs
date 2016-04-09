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
        public string Description { get; set; } =
            @"Hi! I'm Bryan. I'm 25 years old with a Bachelor's Degree in Civil Engineering from the University of Michigan, and I am a " +
            "Xamarin Certified Mobile Developer. I'm looking to work full time as a Mobile Developer starting as soon as possible, either remotely or based in Seattle, Washington. " +
            "\n\nI've created Employr to help demonstrate my skills, work ethic, and passion for Mobile Development. Outside of the professional world, I cook (sometimes poorly) and tinker on personal projects " +
            "(one of which you're looking at right now!). Thanks for downloading Employr, and I hope to see you around Xamarin Evolve, 2016!"
                .Replace("\n", Environment.NewLine);

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
                emailMessenger.SendEmail("BryanJ.Smith91@gmail.com", "Future Developer Opportunities", 
                    @"Bryan,

We enjoyed speaking with you at Xamarin Evolve 2016, and there are opportunities in our future we'd like to discuss with you. We hope to hear back from you! Thanks, 

");
            }
        }
        
    }
}
