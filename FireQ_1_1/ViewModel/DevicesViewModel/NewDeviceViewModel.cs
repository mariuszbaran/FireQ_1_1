using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using FireQ_1_1.Commands;

namespace FireQ_1_1.ViewModel.DevicesViewModel
{
    public class NewDeviceViewModel : DeviceBaseViewModel
    {
        public NewDeviceViewModel(DeviceBaseViewModel previousViewModel)
        {
            Console.WriteLine(App.Current.Properties["LoggedUser"]);
            MainViewModel = previousViewModel.MainViewModel;
            PreviousViewModel = previousViewModel;
            Device = previousViewModel.Device;

            SaveCommand = new RelayCommand(Save, CanSave);
            BackCommand = new RelayCommand(Back, CanBack);
            CloseCommand = new RelayCommand(Close, CanClose);
        }

        public ICommand SaveCommand { get; set; }
        public ICommand BackCommand { get; set; }
        public ICommand CloseCommand { get; set; }
        private bool CanSave(object parameter)
        {
            return true;
        }
        private void Save(object parameter)
        {
            MessageBox.Show(Properties.Resources.Saved);
        }
        private bool CanBack(object parameter)
        {
            return true;
        }
        private void Back(object parameter)
        {
            Console.WriteLine("Devices View Model - Back");
            MainViewModel.ActiveViewModel = PreviousViewModel;
        }
        private bool CanClose(object parameter)
        {
            return true;
        }
        private void Close(object parameter)
        {
            Console.WriteLine("Devices View Model - Close");
            MainViewModel.ActiveViewModel = new HomeViewModel(this);
        }
    }
}
