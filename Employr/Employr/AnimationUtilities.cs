using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Employr
{
    public static class AnimationUtilities
    {

        public static void InitializeAppear(params VisualElement[] elem)
        {
            foreach (var e in elem)
            {
                e.Scale = 0.4;
                e.Opacity = 0;
            }
        }

        public static void IniitializeRollIn(VisualElement e)
        {
            e.TranslationX = -800;
            e.Scale = 1.5;
        }

        public static async void FeatherIn(params VisualElement[] elem)
        {
            await Task.Delay(750);
            for (int index = 0; index < elem.Length; index++)
            {
                var e = elem[index];
                e.ScaleTo(1);
                e.FadeTo(1);
                await Task.Delay(250);
            }
        }

        public static void RollIn(VisualElement e)
        {
            e.ScaleTo(1, 1500, Easing.CubicInOut);
            e.RotateTo(360,1500, Easing.CubicInOut);
            e.TranslateTo(0,0,1500, Easing.CubicInOut);
        }
    }
}
