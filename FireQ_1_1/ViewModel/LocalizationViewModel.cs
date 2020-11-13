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
            get { return this.selectedItem; } 
            set 
            { 
                this.selectedItem = value;
                OnPropertyChanged(nameof(selectedItem));
            } 
        }
        public List<string> List { get; set; }

        public LocalizationViewModel(MainViewModel mainViewModel)
        {
            Console.WriteLine("Constructor - LocalizationViewModel - argument: mainViewModel");

            MainViewModel = mainViewModel;
            List = new List<string>();
            List.Add("pl-PL");
            List.Add("en");
            SelectedItem = Properties.Settings.Default.localizationCode;
            SaveCommand = new SaveCommand(this);
            CloseCommand = new CloseCommand(this);
        }

        public ICommand SaveCommand { get; set; }

        public override void Save()
        {
            Properties.Settings.Default.localizationCode = SelectedItem;
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.localizationCode);
            MessageBox.Show(Properties.Resources.settingsSaved);
            //Go back to Home view.
            MainViewModel.ActiveViewModel = new HomeViewModel(MainViewModel);
            //Save properties permamently.
            //Properties.Settings.Default.Save();
        }
        public ICommand CloseCommand { get; set; }

        public override void Close()
        {
            MainViewModel.ActiveViewModel = new HomeViewModel(MainViewModel);
        }
    }
}
