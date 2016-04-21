using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume
{
    public static class Constants
    {
        //HomeView
        public static string HomeIntro { get; set; } =
            "Hi! I'm Bryan. I'm 25 years old with a Bachelor's Degree in Civil Engineering from the University of Michigan, and I am a Xamarin Certified Mobile Developer.  " +
            "I'm looking to work full time as a junior Mobile Developer, either remotely or based in Seattle, Washington.  " +
            "I've created Employr to demonstrate my skills, work ethic, and passion for Mobile Development.  " +
            "Outside of the professional world, I cook (sometimes poorly), and tinker on personal projects.  " +
            "Thanks for downloading Employr - if you'd like to learn more about myself or this app, please keep reading and poke around, and feel free to contact me. I hope to see you around Xamarin Evolve, 2016!" +
            @"

";

        public static string HomeBody1 { get; set; } =
            "I began coding to improve my efficiency as a Civil Engineer at my previous job, but (unsurprisingly) found myself enjoying the coding as much as the prospect of being a more productive engineer.  " +
            "As a lifelong nerd who built PCs and played video games from childhood to now, it felt natural to make the jump to software engineering full-time.  " +
            "Since leaving my previous job on April 1st, 2016, I have completed the Xamarin Certification course through Xamarin University.  " +
            "I will be continuing my programming education through Xamarin and a variety of free academic sources after Evolve.  " +
            "If you have any interest in bringing me on a project, whether it be full-time, contract, or open-source work, let me know!  " +
            @"

";

        public static string HomeBody2 { get; set; } =
            "Employr was developed in concert with my education through Xamarin University, over the course of approximately three (3) weeks.  " +
            "I will be continuing work on this app to apply the skills and knowledge I am steadily learning, and will continue to support iOS and Android.  " +
            "So if you find anything here interesting, keep an eye out for updates/expansions to the app!  " +
            @"

" +
            "I will be relocating to Seattle, Washington this coming fall and will be looking for full time work either in that area or remotely.  " +
            "I'm a hard-working, motivated, smart individual with a strong background in math, science, and engineering, and I'm excited to find a future home in the software world!" +
            @"

";
        public static string HomeSignature { get; set; } = "Bryan"
            ;

        public static string HireButtonEmailBody { get; set; } = (@"Bryan,

We enjoyed speaking with you at Xamarin Evolve 2016, and there are opportunities in our future we'd like to discuss with you. We hope to hear back from you! Thanks, 

");

        //ResumeView
        //Xamarin.Forms will not word wrap these strings - repro and post to bugzilla during/after evolve
        public static string ResumeDeveloperBody1 { get; set; } = "• Xamarin Certified";

        public static string ResumeDeveloperBody2 { get; set; } = "• Shipped an Android app, Employr, built on Xamarin.Forms";

        public static string ResumeDeveloperBody3 { get; set; } = "• In process of shipping iOS version of Employr";

        public static string ResumeDeveloperBody4 { get; set; } = "• Experienced with Xamarin.Android, Xamarin.iOS, and Xamarin.Forms";

        public static string ResumeEngineerBody1 { get; set; } = "• Bachelor's Degree in Civil and Environmental Engineering from the University of Michigan";

        public static string ResumeEngineerBody2 { get; set; } = "• Professionally employed for 1.5 years as a Civil Engineer with OHM Advisors, Inc.";

        public static string ResumeEngineerBody3 { get; set; } = "• Designed multiple infrastructure improvement projects costing from $50,000 to $1,000,000 including roads, sidewalks, and sewer improvements";

        public static string ResumeEngineerBody4 { get; set; } = "• Two year Captain of the University of Michigan Steel Bridge Team, with structural design, machining, welding, and leadership experience";
    }
}
