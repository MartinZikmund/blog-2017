using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace NotAllTransparentAreEqual
{
    public sealed partial class RectanglesControl : UserControl
    {
        public RectanglesControl()
        {
            this.InitializeComponent();            
        }

        public static readonly DependencyProperty BlackFillColorProperty = DependencyProperty.Register(
            "BlackFillColor", typeof(Color), typeof(RectanglesControl), new PropertyMetadata(default(Color)));

        public Color BlackFillColor
        {
            get { return (Color) GetValue(BlackFillColorProperty); }
            set { SetValue(BlackFillColorProperty, value); }
        }

        public static readonly DependencyProperty WhiteFillColorProperty = DependencyProperty.Register(
            "WhiteFillColor", typeof(Color), typeof(RectanglesControl), new PropertyMetadata(default(Color)));

        public Color WhiteFillColor
        {
            get { return (Color) GetValue(WhiteFillColorProperty); }
            set { SetValue(WhiteFillColorProperty, value); }
        }

        public void Animate()
        {
            BlinkingStoryboard.Begin();
        }
    }
}
