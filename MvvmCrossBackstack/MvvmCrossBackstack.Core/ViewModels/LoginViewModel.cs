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
    public class LoginViewModel : MvxViewModel
    {
        private ICommand _goToUserAreaCommand = null;

        public ICommand GoToUserAreaCommand => _goToUserAreaCommand ?? (_goToUserAreaCommand = new MvxCommand(GoToUserArea));

        private void GoToUserArea()
        {
            //navigate to user area
            ShowViewModel<UserDashboardViewModel>();
            //pop the back stack to remove the login page from back stack
            ChangePresentation(new PopBackstackHint());
        }
    }
}