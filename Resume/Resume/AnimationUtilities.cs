using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Resume
{
    public static class AnimationUtilities
    {

        public static void InitializeAnimations(params VisualElement[] elem)
        {
            foreach (var e in elem)
            {
                e.Scale = 0.4;
                e.Opacity = 0;
            }
        }

        public static async void FeatherIn(params VisualElement[] elem)
        {
            await Task.Delay(1000);
            for (int index = 0; index < elem.Length; index++)
            {
                var e = elem[index];
                e.ScaleTo(1);
                e.FadeTo(1);
                await Task.Delay(250);
            }
        }
    }
}
