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
            "Xamarin Certified Mobile Developer. I'm looking to workto help demonstrate my skills, w full time as a Mobile Developer starting as soon as possible, either remotely or based in Seattle, Washington. " +
            "\n\nI've created Employr ork ethic, and passion for Mobile Development. Outside of the professional world, I cook (sometimes poorly) and tinker on personal projects " +
            "(one of which you're looking at right now!). Thanks for downloading Employr, and I hope to see you around Xamarin Evolve, 2016!" +
            "Lorem ipsum dolor sit amet, eu eos hinc modus phaedrum, in tincidunt constituam has. Sea ex tractatos patrioque reformidans. Vix eu perfecto aliquando. Meis delicata ut vim. Vis audire delicata referrentur et, consul adipiscing dissentias mea ex." +
            "Te cibo inani has, mel assum dolore insolens an.Amet alterum epicurei no sit, eius integre bonorum in vim.Est erat ipsum quaestio id.Ut sumo tractatos qui, aeque pertinacia no duo, eu omnium probatus phaedrum pro." +
            "Diceret pertinacia sit no. Vix omittam copiosae no, ex eum erant decore aliquip.Eam atqui causae vidisse no.Ad sed iriure praesent reprehendunt, ei ignota convenire vis, ei nam eruditi sapientem. Altera omnium ex has, soluta saperet corpora vix ut.Timeam discere cu usu, sit falli fastidii ut." +
            "Luptatum explicari temporibus in cum.Cum solet dolores constituto ne, ad ius alia assueverit. Ut falli bonorum ius, harum nihil gloriatur sit an.Exerci melius sed an. Quo ea facer congue, mei mundi atomorum et, ei nec omnis placerat reprimique.Usu impetus salutandi expetendis eu.Id qui assum simul scripta, at viris option mei, eius atqui dicant qui ut."
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
