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
        private String selectedItem;
        public String SelectedItem
        { 
            get { return this.selectedItem; } 
            set 
            { 
                this.selectedItem = value;
                OnPropertyChanged(nameof(selectedItem));
                Properties.Settings.Default.localizationCode = SelectedItem; // do poprawy bo nie tak powinno działać
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
            //SelectedItem = Properties.Settings.Default.localizationCode;
            Save = new SaveLocalizationCommand(mainViewModel);
            Close = new CancelAndBackToHomeCommand(mainViewModel);
        }

        public ICommand Save { get; set; }
        public ICommand Close { get; set; }
    }
}
