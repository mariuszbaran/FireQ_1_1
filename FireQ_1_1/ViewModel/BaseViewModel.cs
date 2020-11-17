using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FireQ_1_1.Model;

namespace FireQ_1_1.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public MainViewModel MainViewModel { get; set; }
        public BaseViewModel PreviousViewModel { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
