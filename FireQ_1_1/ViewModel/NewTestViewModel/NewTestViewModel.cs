using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireQ_1_1.Commands;
using System.Windows.Input;

namespace FireQ_1_1.ViewModel
{
    public class NewTestViewModel : BaseViewModel
    {
        public NewTestViewModel(BaseViewModel previousViewModel)
        {
            MainViewModel = previousViewModel.MainViewModel;
            PreviousViewModel = previousViewModel;

            BackCommand = new RelayCommand(Back, CanBack);
            CloseCommand = new RelayCommand(Close, CanClose);
        }

        public ICommand BackCommand { get; set; }
        public ICommand CloseCommand { get; set; }

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
