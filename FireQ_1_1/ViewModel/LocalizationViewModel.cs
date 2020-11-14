using FireQ_1_1.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FireQ_1_1.ViewModel
{
    class LocalizationViewModel : BaseViewModel
    {
        private string selectedItem;
        public string SelectedItem
        { 
            get { return selectedItem; } 
            set 
            { 
                selectedItem = value;
                OnPropertyChanged(nameof(selectedItem));
            } 
        }

        public Dictionary<string,string> List { get; set; }

        public LocalizationViewModel(BaseViewModel previousViewModel)
        {
            Console.WriteLine("Constructor: Localization View Model");

            MainViewModel = previousViewModel.MainViewModel;
            PreviousViewModel = previousViewModel;
            List = new Dictionary<string, string>();
            List.Add("pl-PL", "PL");
            List.Add("en", "EN");
            SelectedItem = Properties.Settings.Default.localizationCode;
            SaveCommand = new RelayCommand(Save, CanSave);
            CloseCommand = new RelayCommand(Close, CanClose);
        }

        public ICommand SaveCommand { get; set; }
        private bool CanSave(object parameter)
        {
            return true;
        }
        private void Save(object parameter)
        {
            Console.WriteLine("Localizatin View Model - Save Command");
            Properties.Settings.Default.localizationCode = SelectedItem;
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.localizationCode);
            MessageBox.Show(Properties.Resources.settingsSaved);
            //Go back.
            MainViewModel.ActiveViewModel = PreviousViewModel;
            //Save properties permamently.
            //Properties.Settings.Default.Save();
        }
        public ICommand CloseCommand { get; set; }
        private bool CanClose(object parameter)
        {
            return true;
        }
        private void Close(object parameter)
        {
            Console.WriteLine("Localization View Model - Close Command");
            MainViewModel.ActiveViewModel = PreviousViewModel;
        }
    }
}
