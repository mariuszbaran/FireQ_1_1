using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FireQ_1_1.Commands;
using System.Windows;

namespace FireQ_1_1.ViewModel.DevicesViewModel
{
    class EditDeviceViewModel : DeviceBaseViewModel
    {
        public EditDeviceViewModel(DeviceBaseViewModel previousViewModel)
        {
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
