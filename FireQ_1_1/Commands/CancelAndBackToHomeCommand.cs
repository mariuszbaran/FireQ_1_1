using FireQ_1_1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FireQ_1_1.Commands
{
    class CancelAndBackToHomeCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private MainViewModel mainViewModel;
        public CancelAndBackToHomeCommand(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            mainViewModel.ActiveViewModel = new HomeViewModel(mainViewModel);
        }
    }
}
