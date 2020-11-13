using FireQ_1_1.Commands;
using FireQ_1_1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FireQ_1_1.Model;
using System.Windows;

namespace FireQ_1_1.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        public User user;

        public User User
        {
            get { return this.user; }
            set
            {
                this.user = value;
                OnPropertyChanged(nameof(user));
            }
        }

        public LoginViewModel(MainViewModel mainViewModel)
        {
            Console.WriteLine("Constructor - LoginViewModel - argument: mainViewModel");
            User = new User();
            MainViewModel = mainViewModel;
            LoginCommand = new LoginCommand(MainViewModel,User);       
        }

        /// <summary>
        /// Login Command, veryfies input data with database users
        /// </summary>
        public ICommand LoginCommand { get; set; }

    }
}
