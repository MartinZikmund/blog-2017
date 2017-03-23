using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace MvvmCrossBackstack.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private ICommand _goToLoginCommand = null;

        public ICommand GoToLoginCommand => _goToLoginCommand ?? (_goToLoginCommand = new MvxCommand(GoToLogin));

        private void GoToLogin()
        {
            //navigate to login
            ShowViewModel<LoginViewModel>();
        }
    }
}
