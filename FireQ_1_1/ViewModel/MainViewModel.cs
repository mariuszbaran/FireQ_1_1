using FireQ_1_1.Commands;
using FireQ_1_1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using FireQ_1_1.Model;

namespace FireQ_1_1.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel activeViewModel;
        public BaseViewModel ActiveViewModel
        {
            get { return activeViewModel; }
            set
            {
                activeViewModel = value;
                OnPropertyChanged(nameof(activeViewModel));
            }
        }

        public MainViewModel()
        {
            //
            //LoadDefaultUser();
            Console.WriteLine("Constructor: Main View Model.");
            MainViewModel = this;
            //ActiveViewModel = new HomeViewModel(this);
            ActiveViewModel = new LoginViewModel(this);
        }

        //
        private void LoadDefaultUser()
        {
          
        }
    }
}
