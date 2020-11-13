using FireQ_1_1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FireQ_1_1.Commands
{
    class SaveLocalizationCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private MainViewModel mainViewModel;

        public SaveLocalizationCommand(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.localizationCode);
            MessageBox.Show(Properties.Resources.settingsSaved);
            //Go back to Home view.
            mainViewModel.ActiveViewModel = new HomeViewModel(mainViewModel);
            //Save properties permamently.
            //Properties.Settings.Default.Save();
        }
    }
}
