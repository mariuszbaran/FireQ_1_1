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
        public LoginViewModel(BaseViewModel previousViewModel)
        {
            Console.WriteLine("Constructor: Login View Model");
            User = new User();
            MainViewModel = previousViewModel.MainViewModel;
            PreviousViewModel = previousViewModel;
            LoginCommand = new RelayCommand(Login, CanLogin);
            ChangeLocalizationCommand = new RelayCommand(ChangeLocalization, CanChangeLocalization);
        }

        private User user;

        public User User
        {
            get { return user; }
            set
            {
                user = value;
                OnPropertyChanged(nameof(user));
            }
        }

        public ICommand LoginCommand { get; set; }

        private bool CanLogin(object paramete)
        {
            return (User.Name == null || User.Name.Length == 0) ? false : true;
            //return true;
        }
        private void Login(object parameter)
        {
            Console.WriteLine("Login View Model - Login Command");
            if (User.Name == "admin" & User.Password == "admin")
            {
                MainViewModel.ActiveViewModel = new HomeViewModel(this);
            }
            else
            {
                MessageBox.Show(Properties.Resources.invalidLoginData + "\n=============================\nTry:\nUser: admin\nPassword: admin");
            }
        }

        public ICommand ChangeLocalizationCommand { get; set; }
        private bool CanChangeLocalization(object parameter)
        {
            return true;
        }
        private void ChangeLocalization(object parameter)
        {
            Console.WriteLine("Login View Model - Change Localization Command");
            MainViewModel.ActiveViewModel = new LocalizationViewModel(this);
        }
    }
}
