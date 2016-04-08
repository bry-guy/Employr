using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Resume.ViewModels;

//todo: implement rotate and crossfade animation
//todo: implement expand and overlay fade animation

namespace Resume.Views
{
    public partial class HomeView : ContentPage
    {
        private int imageIndex = 0;
        private bool appeared = false;
        private Command ImageFlipCommand { get; set; }

        public HomeView()
        {
            
            BindingContext = new HomeViewModel();
            InitializeComponent();

            //AnimationUtilities.InitializeAnimations(BryanImage, BryanName, BryanTitle, BryanDescription, HireButton);

            ImageFlipCommand = new Command(HandleImagePressed);
            BryanImage.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = ImageFlipCommand,
            });
        }

        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    if (!appeared)
        //    {
        //        AnimationUtilities.FeatherIn(BryanImage, BryanName, BryanTitle, BryanDescription, HireButton);
        //        appeared = true;
        //    }
            
        //}
        
        private void HandleImagePressed()
        {
           FlipImage(BryanImage, imageIndex);
        }

        //todo fadeimage: rotate 0-90, crossfade code 90-0, wrap entire page in grid, fade full code image in overlaid at 0,0 of BigGrid
        private async void FlipImage(VisualElement elem, int index) 
        {
            switch (index)
            {
                case 0:
                    await elem.RotateTo(360, 250);
                    BryanImage.Opacity = 0;
                    //todo: implement BryanImage2
                    //BryanImage2.Opacity = 1; 
                    BryanImage.Source = "http://filmgarb.com/wp-content/uploads/tv-futurama-1999_-philip_j_fry-billy_west-tops-s07e03-fry_red_jacket.jpg";
                    imageIndex++;
                    break;
                case 1:
                    //insert code preview page
                    imageIndex++;
                    break;
                case 2:
                    //insert actual embedded editor app
                    imageIndex++;
                    break;
            }
        }

    }
}
