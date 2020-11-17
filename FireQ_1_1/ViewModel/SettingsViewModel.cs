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
        private bool darkMode;
        public bool DarkMode
        {
            get { return darkMode; }
            set
            {
                darkMode = value;
                OnPropertyChanged(nameof(darkMode));
            }
        }

        //Data Base path - text field
        private string databasePath;
        public string DatabasePath
        {
            get { return databasePath; }
            set
            {
                databasePath = value;
                OnPropertyChanged(nameof(databasePath));
            }
        }
        //Localization - combobox
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

        //Dictinary for displaying localization codes
        public Dictionary<string, string> List { get; set; }

        //Constructor
        public SettingsViewModel(BaseViewModel previousViewModel)
        {
            Console.WriteLine("Constructor: Settings View Model.");
            MainViewModel = previousViewModel.MainViewModel;
            PreviousViewModel = previousViewModel;

            DarkMode = Properties.Settings.Default.DarkModeEnebled;
            DatabasePath = Properties.Settings.Default.DatabasePath;
            List = new Dictionary<string, string>();
            List.Add("pl-PL", "PL");
            List.Add("en", "EN");
            SelectedItem = Properties.Settings.Default.LocalizationCode;
            
            //ICommands
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

            //Save Color Mode
            Properties.Settings.Default.DarkModeEnebled = DarkMode;
            if (DarkMode)
            {
                Properties.Settings.Default.ColorMode = Properties.Settings.Default.DarkMode;
            }
            else
            {
                Properties.Settings.Default.ColorMode = Properties.Settings.Default.LightMode;
            }
            

            //Save Database path
            Properties.Settings.Default.DatabasePath = DatabasePath;

            //Save localization settings
            Properties.Settings.Default.LocalizationCode = SelectedItem;
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.LocalizationCode);

            MessageBox.Show(Properties.Resources.SettingsSaved);
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
