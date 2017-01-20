using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AccentColorChangeHandling
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        /// <summary>
        /// UI settings instance
        /// Keep reference so that the events are properly delivered
        /// </summary>
        private readonly UISettings _uiSettings = new UISettings();

        public MainPage()
        {
            this.InitializeComponent();
            _uiSettings.ColorValuesChanged += ColorValuesChanged;
        }

        public ObservableCollection<ChangeLogItem> ChangeLog { get; } =
            new ObservableCollection<ChangeLogItem>();

        private void ColorValuesChanged(UISettings sender, object args)
        {
            var accentColor = sender.GetColorValue(UIColorType.Accent);
            var backgroundColor = sender.GetColorValue(UIColorType.Background);
            var darkMode = backgroundColor == Colors.Black;
            //OR
            //Color accentColor = (Color)Resources["SystemAccentColor"];
            ChangeLog.Insert(0, new ChangeLogItem(accentColor, darkMode, DateTimeOffset.Now));

            //Example - update title bar
            UpdateTitleBar(accentColor);
        }

        private static void UpdateTitleBar(Color accentColor)
        {
            var titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.BackgroundColor = accentColor;
            titleBar.ButtonBackgroundColor = accentColor;
            titleBar.InactiveBackgroundColor = accentColor;
            titleBar.ButtonInactiveBackgroundColor = accentColor;

            //do not forget Mobile :-) !
            if (Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar"))
            {
                var statusBar = StatusBar.GetForCurrentView();
                statusBar.BackgroundColor = accentColor;
            }
        }
    }
}
