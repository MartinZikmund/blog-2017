using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using MvvmCrossBackstack.Core.PresentationHints;

namespace MvvmCrossBackstack.Core.ViewModels
{
    public class UserDashboardViewModel : MvxViewModel
    {
        private ICommand _goHomeCommand = null;
        private ICommand _showMoreCommand = null;
        private int _pageOrder = 0;

        public ICommand GoHomeCommand => _goHomeCommand ?? (_goHomeCommand = new MvxCommand(GoHome));

        public ICommand ShowMoreCommand => _showMoreCommand ?? (_showMoreCommand = new MvxCommand(ShowMore));

        public int PageOrder
        {
            get { return _pageOrder; }
            private set { SetProperty(ref _pageOrder, value); }
        }

        public void Init(int pageOrder = 0)
        {
            PageOrder = pageOrder;
        }

        private void GoHome()
        {
            //navigate to main page
            ShowViewModel<MainViewModel>();
            //clear the whole back stack
            ChangePresentation(new ClearBackstackHint());
        }

        private void ShowMore()
        {
            ShowViewModel<UserDashboardViewModel>(new
            {
                pageOrder = PageOrder + 1
            });
        }
    }
}
