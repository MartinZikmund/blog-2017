using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.Platform.Platform;
using MvvmCross.WindowsUWP.Platform;
using MvvmCross.WindowsUWP.Views;
using MvvmCrossBackstack.Core.PresentationHints;

namespace MvvmCrossBackstack
{
    public class Setup : MvxWindowsSetup
    {
        public Setup(Frame rootFrame) : base(rootFrame)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override IMvxWindowsViewPresenter CreateViewPresenter(IMvxWindowsFrame rootFrame)
        {
            var viewPresenter = base.CreateViewPresenter(rootFrame);
            var backStackHandler = new BackStackHintHandler(rootFrame);
            viewPresenter.AddPresentationHintHandler<ClearBackstackHint>(backStackHandler.HandleClearBackstackHint);
            viewPresenter.AddPresentationHintHandler<PopBackstackHint>(backStackHandler.HandlePopBackstackHint);
            return viewPresenter;
        }
    }
}