using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using FireQ_1_1.Commands;

namespace FireQ_1_1.ViewModel
{
    public class SettingsViewModel : BaseViewModel
    {
        public SettingsViewModel(BaseViewModel previousViewModel)
        {
            Console.WriteLine("Constructor: Settings View Model.");
            MainViewModel = previousViewModel.MainViewModel;
            PreviousViewModel = previousViewModel;
            SaveCommand = new RelayCommand(Save,CanSave);
            CloseCommand = new RelayCommand(Close,CanClose);
        }
        public ICommand SaveCommand { get; set; }
        private bool CanSave(object parameter)
        {
            return true;
        }
        private void Save(object parameter)
        {
            Console.WriteLine("Settings View Model - Save Command");
            MessageBox.Show(Properties.Resources.settingsSaved);
        }

        public ICommand CloseCommand { get; set; }
        private bool CanClose(object parameter)
        {
            return true;
        }
        private void Close(object parameter)
        {
            Console.WriteLine("Settings View Model - Close Command");
            MainViewModel.ActiveViewModel = PreviousViewModel;
        }
    }
}
