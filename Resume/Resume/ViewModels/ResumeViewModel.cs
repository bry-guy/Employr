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
        public string HighlightsBody1 { get; set; } = Constants.ResumeDeveloperBody;

        public string HighlightsTitle2 { get; set; } = "Engineer";
        public string HighlightsBody2 { get; set; } = Constants.ResumeEngineerBody;
    }
}
