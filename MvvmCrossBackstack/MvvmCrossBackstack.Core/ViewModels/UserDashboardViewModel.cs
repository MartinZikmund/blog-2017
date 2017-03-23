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

        public ICommand GoHomeCommand => _goHomeCommand ?? (_goHomeCommand = new MvxCommand(GoHome));

        private void GoHome()
        {
            //navigate to main page
            ShowViewModel<MainViewModel>();
            //clear the whole back stack
            ChangePresentation(new ClearBackstackHint());
        }
    }
}
