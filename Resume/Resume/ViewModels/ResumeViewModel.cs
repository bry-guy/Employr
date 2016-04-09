using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Resume.ViewModels
{
    public class ResumeViewModel
    {
        public string HighlightsTitle1 { get; set; } = "Mobile Developer";
        public string HighlightsBlurb1 { get; set; } = @"
 •2022 testing this bullet
 •2022 testing this bullet as well
 •2022 lets also test this one";

        public string HighlightsTitle2 { get; set; } = "Engineer";
        public string HighlightsBlurb2 { get; set; } = @"

 •2022 testing more bullets
 •2022 continuing the test
 •2022 hello i am computer";
    }
}
