using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;
using MvvmCross.Core.ViewModels;
using MvvmCross.WindowsUWP.Views;
using MvvmCrossBackstack.Core.PresentationHints;

namespace MvvmCrossBackstack
{
    public class CustomViewPresenter : MvxWindowsViewPresenter
    {
        private readonly Frame _frame = null;

        public CustomViewPresenter(IMvxWindowsFrame rootFrame) : base(rootFrame)
        {
            _frame = (Frame)rootFrame.UnderlyingControl;
            _frame.Navigated += Frame_Navigated;
        }

        public override void ChangePresentation(MvxPresentationHint hint)
        {
            switch (hint)
            {
                case ClearBackstackHint _:
                    {
                        HandleClearBackstackHint();
                        break;
                    }
                case PopBackstackHint _:
                    {
                        HandlePopBackstackHint();
                        break;
                    }
            }
            base.ChangePresentation(hint);
        }
        
        private void Frame_Navigated(object sender, Windows.UI.Xaml.Navigation.NavigationEventArgs e)
        {
            UpdateBackButtonVisibility();
        }

        private void HandleClearBackstackHint()
        {
            _frame.BackStack.Clear();
            UpdateBackButtonVisibility();
        }

        private void HandlePopBackstackHint()
        {
            if (_frame.CanGoBack)
            {
                _frame.BackStack.RemoveAt(_frame.BackStackDepth - 1);
                UpdateBackButtonVisibility();
            }
        }

        private void UpdateBackButtonVisibility()
        {
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
                _frame.CanGoBack ? AppViewBackButtonVisibility.Visible :
                    AppViewBackButtonVisibility.Collapsed;
        }    
    }
}
