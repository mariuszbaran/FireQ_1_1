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
        public ICommand Save { get; set; }
        public ICommand Close { get; set; }

        public SettingsViewModel(MainViewModel mainViewModel)
        {
            Console.WriteLine("Constructor - SettingsViewModel - argument: mainViewModel");

            MainViewModel = mainViewModel;
            Save = new SaveSettingsCommand();
            Close = new CancelAndBackToHomeCommand(MainViewModel);

        }
    }
}
