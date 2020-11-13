using FireQ_1_1.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace FireQ_1_1.ViewModel
{
    public class HomeViewModel : BaseViewModel
    {
        public ICommand UpdateViewCommand { get; set; }
        public HomeViewModel(MainViewModel mainViewModel)
        {
            Console.WriteLine("Constructor - HomeViewModel - argument: mainViewModel");

            MainViewModel = mainViewModel;
            UpdateViewCommand = new UpdateViewCommand(MainViewModel);

            
        }

    }
}
