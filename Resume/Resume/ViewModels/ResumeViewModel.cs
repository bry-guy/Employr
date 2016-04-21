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
        public string HighlightsBlurb1A { get; set; } = Constants.ResumeDeveloperBody1;
        public string HighlightsBlurb1B { get; set; } = Constants.ResumeDeveloperBody2;
        public string HighlightsBlurb1C { get; set; } = Constants.ResumeDeveloperBody3;
        public string HighlightsBlurb1D { get; set; } = Constants.ResumeDeveloperBody4;

        public string HighlightsTitle2 { get; set; } = "Engineer";
        public string HighlightsBlurb2A { get; set; } = Constants.ResumeEngineerBody1;
        public string HighlightsBlurb2B { get; set; } = Constants.ResumeEngineerBody2;
        public string HighlightsBlurb2C { get; set; } = Constants.ResumeEngineerBody3;
        public string HighlightsBlurb2D { get; set; } = Constants.ResumeEngineerBody4;
    }
}
