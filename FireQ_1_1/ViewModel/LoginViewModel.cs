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
            LoginCommand = new LoginCommand(this);       
        }

        /// <summary>
        /// Login Command execute this.Login();
        /// </summary>
        public ICommand LoginCommand { get; set; }

        /// <summary>
        /// Checks input data against users table in the database.
        /// </summary>
        public void Login()
        {
            if (User.Name == "admin" & User.Password == "admin")
            {
                MainViewModel.ActiveViewModel = new HomeViewModel(MainViewModel);
            }
            else
            {
                MessageBox.Show(Properties.Resources.invalidLoginData + "\n=============================\nTry:\nUser: admin\nPassword: admin");
            }
        }
    }
}
