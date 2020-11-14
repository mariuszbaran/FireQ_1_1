using FireQ_1_1.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace FireQ_1_1.ViewModel
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel(BaseViewModel previousViewModel)
        {
            Console.WriteLine("Constructor: Home View Model.");
            MainViewModel = previousViewModel.MainViewModel;
            PreviousViewModel = previousViewModel;
            SettingsViewCommand = new RelayCommand(SettingsView, CanSettingsView);
            LocalizationViewCommand = new RelayCommand(LocalizationView, CanLocalizationView);
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
    }
}
