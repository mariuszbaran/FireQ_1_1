using FireQ_1_1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FireQ_1_1.Commands
{
    public class UpdateViewCommand : ICommand

    {
        private MainViewModel mainViewModel;

        public UpdateViewCommand(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter.ToString() == "Home")
            {
                mainViewModel.ActiveViewModel = new HomeViewModel(mainViewModel);
            }
            else if (parameter.ToString() == "Settings")
            {
                mainViewModel.ActiveViewModel = new SettingsViewModel(mainViewModel);
            }

            else if (parameter.ToString() == "Login")
            {
                mainViewModel.ActiveViewModel = new LoginViewModel(mainViewModel);
            }

            if(parameter.ToString() == "Localization")
            {
                mainViewModel.ActiveViewModel = new LocalizationViewModel(mainViewModel);
            }
        }
    }
}
