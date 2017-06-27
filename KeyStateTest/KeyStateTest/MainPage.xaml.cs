using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace KeyStateTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly DispatcherTimer _timer = new DispatcherTimer();

        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            UpdateKeyState();
            Window.Current.CoreWindow.KeyDown += KeyEventHandler;
            Window.Current.CoreWindow.KeyUp += KeyEventHandler;
            _timer.Interval = TimeSpan.FromMilliseconds(300);
            _timer.Tick += Tick;
            _timer.Start();
        }

        private void Tick(object sender, object e)
        {
            UpdateKeyState();
        }

        private void KeyEventHandler(CoreWindow sender, KeyEventArgs args)
        {
            UpdateKeyState();
        }

        private void UpdateKeyState()
        {
            CtrlStateTextBlock.Text = Window.Current.CoreWindow.GetKeyState(VirtualKey.Control).ToString();
            AStateTextBlock.Text = Window.Current.CoreWindow.GetKeyState(VirtualKey.A).ToString();
            CapsLockStateTextBlock.Text = Window.Current.CoreWindow.GetKeyState(VirtualKey.CapitalLock).ToString();
        }
    }
}
