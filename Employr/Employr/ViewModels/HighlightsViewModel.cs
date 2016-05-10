using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Employr.ViewModels
{
    public class HighlightsViewModel
    {
        public string Title1 { get; set; } = "Mobile Developer";
        public string Body1 { get; set; } = Constants.HighlightsDeveloperBody;

        public string Title2 { get; set; } = "Engineer";
        public string Body2 { get; set; } = Constants.HighlightsEngineerBody;
    }
}
