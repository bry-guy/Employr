using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Resume.ViewModels;
using Resume;

namespace Resume.Views
{
    public partial class HomeView : ContentPage, IIntroAnimation
    {
        private int imageIndex = 0;
        private bool appeared = false;
        private bool showCode = false;

        public HomeView()
        {
            
            BindingContext = new HomeViewModel();
            InitializeComponent();

            AnimationUtilities.InitializeAppear(_nameLabel, _introductionLabel, _bodyLabel, _hireButton);
            AnimationUtilities.IniitializeRollIn(_bryanImage);

            _scrollView.SetBinding(View.MarginProperty, new Binding("Height", source: _nameStack, converter: new ThicknessConverter(),
                converterParameter: 1, mode: BindingMode.OneWay));

            _descriptionStack.SetBinding(View.MarginProperty, new Binding("Height", source: _backgroundImage, converter: new ThicknessConverter(),
                converterParameter: 1, mode: BindingMode.OneWay));
            _descriptionStack.SetBinding(Xamarin.Forms.Layout.PaddingProperty, new Binding("Height", source: _backgroundImage, converter: new ThicknessConverter(),
                converterParameter: 3, mode: BindingMode.OneWay));
            _nameStack.SetBinding(HeightRequestProperty, new Binding("Height", source: _codeViewFAB));
            
        }

        private void OnScrolled(object sender, ScrolledEventArgs e)
        {
            
            //scale FAB 
            var imageHeight = _backgroundImage.Height; 
            var startY = _codeViewFAB.Y;
            double imageMotion;

            imageMotion = Math.Max(-e.ScrollY*(startY/imageHeight), -startY);
            _codeViewFAB.TranslationY = imageMotion;

            if (startY == 0)
            {
                _codeViewFAB.Scale = 1;
            }
            else
            {
                var progressImage = -imageMotion / startY;
                _codeViewFAB.Scale = 1 - .2 * progressImage;
            }

            //scale and fade _nameStack
            var stackTravelDistance = _nameStack.Y;
            var fadeOffset = _codeViewFAB.Height/(2*stackTravelDistance);
            double stackMotion;

            stackMotion = Math.Max(-e.ScrollY, -stackTravelDistance);
            _nameStack.TranslationY = stackMotion;

            if (stackMotion == 0)
            {
                _nameStack.BackgroundColor = Color.FromHex("#A5A5A5");
                _bryanImage.Opacity = 1;
                return;
            } 

            var progressStack = Math.Max(1 + fadeOffset + (stackMotion / stackTravelDistance) / 2, .5);
            var color = _nameStack.BackgroundColor;
            Color newColor = new Color(color.R, color.G, color.B, progressStack);
            _nameStack.BackgroundColor = newColor;

            //fade out _bryanImage
            _bryanImage.Opacity = 1+(stackMotion/stackTravelDistance)*2;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            OnScrolled(this, new ScrolledEventArgs(0,0));
            _scrollView.ScrollToAsync(0, 0, false);
        }

        private void HandleCodeViewButtonPressed(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CodeView());
        }
        
        public async void RunIntroAnimations()
        {
            if (!appeared)
            {
                AnimationUtilities.FeatherIn(_nameLabel, _introductionLabel, _bodyLabel, _hireButton);
                await Task.Delay(1000);
                AnimationUtilities.RollIn(_bryanImage);
                appeared = true;
            }
        }
    }
}
