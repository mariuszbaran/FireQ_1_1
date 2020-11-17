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
            MainViewModel = previousViewModel.MainViewModel;
            PreviousViewModel = previousViewModel;

            LoginCommand = new RelayCommand(Login, CanLogin);
            ChangeLocalizationCommand = new RelayCommand(ChangeLocalization, CanChangeLocalization);
        }

        private string userName;
        
        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                OnPropertyChanged(nameof(userName));
            }
        }
        public string Password { get; set; }

        public ICommand LoginCommand { get; set; }

        private bool CanLogin(object paramete)
        {
            return (UserName == null || UserName.Length == 0) ? false : true;
        }
        private void Login(object parameter)
        {
            Console.WriteLine("Login View Model - Login Command");
            if (Password == "admin")
            {
                User LoggedUser = new User();
                LoggedUser.Name = UserName;
                LoggedUser.AccessLevel = 2;
                App.Current.Properties["LoggedUser"] = LoggedUser;
                MainViewModel.ActiveViewModel = new HomeViewModel(this);

            }
            else
            {
                MessageBox.Show(Properties.Resources.InvalidLoginData + "\n=============================\nTry:\nUser: <Ener Your Name>\nPassword: admin");
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
