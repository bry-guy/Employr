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
        public string Description { get; set; } = "Lorem ipsum dolor sit amet, atqui voluptatum pro no, dignissim persequeris ei sit. Nihil dicant commune cum an, postulant necessitatibus ea eum. Vis probo efficiantur an. Eu sea mucius virtute oportere. " +
            "@Iriure deserunt consetetur ut mea.Dicant mentitum conclusionemque ad sea, alii equidem vix id.Per quando ubique dictas ne, prima movet ceteros ne ius.Ad veritus rationibus ius, mea id nihil legendos urbanitas, " +
            "@et duo antiopam salutatus. Vocent facilisis efficiantur eos te, an quaestio consectetuer comprehensam qui, vis nihil dicam homero ex.Eos ea cetero patrioque signiferumque, facer audiam et mel.";
        public string Title { get; set; } = "Mobile App Developer";

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
