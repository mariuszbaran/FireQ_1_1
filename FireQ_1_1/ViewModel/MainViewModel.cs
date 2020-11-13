using FireQ_1_1.Commands;
using FireQ_1_1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FireQ_1_1.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel activeViewModel;
        public ICommand UpdateViewCommand { get; set; }

        public MainViewModel()
        {
            Console.WriteLine("Constructor - MainViewModel - argument: none");

            //ActiveViewModel = new HomeViewModel(this);
            ActiveViewModel = new LoginViewModel(this);
            UpdateViewCommand = new UpdateViewCommand(this);

            
        }

        public BaseViewModel ActiveViewModel
        {
            get { return activeViewModel; }
            set { 
                activeViewModel = value;
                OnPropertyChanged(nameof(activeViewModel));
            }
        }

        
    }
}
