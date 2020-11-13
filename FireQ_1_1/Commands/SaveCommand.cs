using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FireQ_1_1.ViewModel;

namespace FireQ_1_1.Commands
{
    public class SaveCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private BaseViewModel ActiveViewModel { get; set; } 

        public SaveCommand(BaseViewModel activeViewModel)
        {
            this.ActiveViewModel = activeViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.ActiveViewModel.Save();
        }
    }
}
