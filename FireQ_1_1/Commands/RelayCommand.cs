using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FireQ_1_1.Commands
{
    public class RelayCommand : ICommand
    {
        Action<object> execute;
        Func<object, bool> canexecute;
        public RelayCommand(Action<object> exe, Func<object, bool> canexe)
        {
            execute = exe;
            canexecute = canexe;

        }
        public bool CanExecute(object parameter)
        {
            if (canexecute != null)
            {
                return canexecute(parameter);
            }
            else
            {
                return false;
            }
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
