using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FireQ_1_1.Model;
using FireQ_1_1.Commands;

namespace FireQ_1_1.ViewModel.DevicesViewModel
{
    public class DeviceViewModel : DeviceBaseViewModel
    {
        private string searchText;
        public string SearchText
        {
            get { return searchText; }
            set { searchText = value; OnPropertyChanged(nameof(searchText)); }
        }

        public DeviceViewModel(BaseViewModel previousViewModel)
        {
            MainViewModel = previousViewModel.MainViewModel;
            PreviousViewModel = previousViewModel;

            SearchCommand = new RelayCommand(Search, CanSearch);
            NewDeviceCommand = new RelayCommand(NewDevice, CanNewDevice);
            EditCommand = new RelayCommand(Edit, CanEdit);
            DeleteCommand = new RelayCommand(Delete, CanDelete);
            BackCommand = new RelayCommand(Back, CanBack);
            CloseCommand = new RelayCommand(Close, CanClose);
        }

        public ICommand SearchCommand { get; set; }
        public ICommand NewDeviceCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand BackCommand { get; set; }
        public ICommand CloseCommand { get; set; }

        private bool CanSearch(object parameter)
        {
            return (SearchText == null || SearchText.Length == 0) ? false : true;
        }
        private void Search(object parameter)
        {
            Console.WriteLine("Devices View Model - Search");
        }
        private bool CanNewDevice(object parameter)
        {
            return true;
        }
        private void NewDevice(object parameter)
        {
            Console.WriteLine("Devices View Model - New");
            MainViewModel.ActiveViewModel = new NewDeviceViewModel(this);
        }
        private bool CanEdit(object parameter)
        {
            return true;// Device == null ? false : true;
        }
        private void Edit(object parameter)
        {
            Console.WriteLine("Devices View Model - Edit");
            MainViewModel.ActiveViewModel = new EditDeviceViewModel(this);
        }
        private bool CanDelete(object parameter)
        {
            return true;
            /*
            if (Device != null)
            {
                return (User.AccessLevel <= 2) ? true : false;
            }
            else
            {
                return false;
            }
            */
        }
        private void Delete(object parameter)
        {
            Console.WriteLine("Devices View Model - Delete");
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
