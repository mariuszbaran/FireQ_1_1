using FireQ_1_1.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using FireQ_1_1.ViewModel.DevicesViewModel;
using FireQ_1_1.Model;

namespace FireQ_1_1.ViewModel
{
    public class HomeViewModel : BaseViewModel
    {
        public User LoggedUser { get; }
        public HomeViewModel(BaseViewModel previousViewModel)
        {
            Console.WriteLine("Constructor: Home View Model.");
            MainViewModel = previousViewModel.MainViewModel;
            //Clean previous VM reference when back in HOME view - not required any longer.
            PreviousViewModel = null;
            LoggedUser = (User)App.Current.Properties["LoggedUser"];

            SettingsViewCommand = new RelayCommand(SettingsView, CanSettingsView);
            LocalizationViewCommand = new RelayCommand(LocalizationView, CanLocalizationView);
            NewTestViewCommand = new RelayCommand(NewTestView, CanNewTestView);
            DevicesViewCommand = new RelayCommand(DeviceView, CanDeviceView);
        }

        public ICommand SettingsViewCommand { get; set; }
        private bool CanSettingsView(object parameter)
        {
            return true;
        }
        private void SettingsView(object parameter)
        {
            Console.WriteLine("Home View Model - Settings View Command");
            MainViewModel.ActiveViewModel = new SettingsViewModel(this);
        }

        public ICommand LocalizationViewCommand { get; set; }
        private bool CanLocalizationView(object parameter)
        {
            return true;
        }
        private void LocalizationView(object parameter)
        {
            Console.WriteLine("Home View Model - Localization View Command");
            MainViewModel.ActiveViewModel = new LocalizationViewModel(this);
        }

        public ICommand NewTestViewCommand { get; set; }
        private bool CanNewTestView(object parameter)
        {
            return true;
        }
        private void NewTestView(object parameter)
        {
            Console.WriteLine("Home View Model - New Test View Command");
            MainViewModel.ActiveViewModel = new NewTestViewModel(this);
        }

        public ICommand DevicesViewCommand { get; set; }
        private bool CanDeviceView(object parameter)
        {
            return true;
        }
        private void DeviceView(object parameter)
        {
            Console.WriteLine("Home View Model - Devices View Command");
            MainViewModel.ActiveViewModel = new DeviceViewModel(this);
        }

    }
}
