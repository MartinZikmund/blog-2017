using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using ResourceLibraryProblem.Localization;
using ResourceLibraryProblem.Resources;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ResourceLibraryProblem.WindowsApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void LocalizationLibraryButton_OnClick(object sender, RoutedEventArgs e)
        {
            LocalizationLibraryButton.Content = ResxInLocalization.Test;
        }

        private void ResourcesLibraryButton_OnClick(object sender, RoutedEventArgs e)
        {
            ResourcesLibraryButton.Content = ResxInResources.Test;
        }
    }
}
