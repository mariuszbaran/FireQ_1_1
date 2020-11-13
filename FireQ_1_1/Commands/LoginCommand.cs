using FireQ_1_1.Model;
using FireQ_1_1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FireQ_1_1.Commands
{
    /// <summary>
    /// Login command - executed when in Login View and pressed login button
    /// </summary>
    public class LoginCommand : ICommand
    {
        
        public event EventHandler CanExecuteChanged;
        
        public LoginViewModel LoginViewModel { get; set; }
        public User User { get; set; }

        public LoginCommand(LoginViewModel loginViewModel)
        {
            LoginViewModel = loginViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            LoginViewModel.Login();
        }
    }
}
