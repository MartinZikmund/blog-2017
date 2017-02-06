using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using UWPSettingsPerformance.Services;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPSettingsPerformance
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private const int Repeats = 100000;

        private readonly Func<bool> _defaultSettingValueBuilder = () => false;

        private SettingsService _settingsService = new SettingsService();

        public MainPage()
        {
            this.InitializeComponent();
        }

        public async void RunBenchmark()
        {
            LoadingArea.Visibility = Visibility.Visible;
            ApplicationData.Current.LocalSettings.Values["test"] = true;
            Stopwatch noCacheStopwatch = new Stopwatch();
            Stopwatch cachedStopwatch = new Stopwatch();
            await Task.Run(() =>
            {
                //noncached test
                noCacheStopwatch.Start();
                for (int i = 0; i < Repeats; i++)
                {
                    PerformReadWithoutCache();
                }
                noCacheStopwatch.Stop();                

                //cached test
                _cachedValue = null;
                cachedStopwatch.Start();
                for (int i = 0; i < Repeats; i++)
                {
                    PerformReadWithCache();
                }                
                cachedStopwatch.Stop();                
            });
            NoCachingResult.Text = $"{noCacheStopwatch.Elapsed.TotalMilliseconds} ms";
            CachingResult.Text = $"{cachedStopwatch.Elapsed.TotalMilliseconds} ms";
            LoadingArea.Visibility = Visibility.Collapsed;
        }

        private bool? _cachedValue = null;

        private bool PerformReadWithoutCache()
        {
            return (bool)ApplicationData.Current.LocalSettings.Values["test"];
        }

        private bool PerformReadWithCache()
        {
            return _settingsService.GetSetting("test", _defaultSettingValueBuilder);

            //if (_cachedValue == null)
            //{
            //    _cachedValue = (bool)ApplicationData.Current.LocalSettings.Values["test"];
            //}
            //return _cachedValue.Value;
        }
    }
}
