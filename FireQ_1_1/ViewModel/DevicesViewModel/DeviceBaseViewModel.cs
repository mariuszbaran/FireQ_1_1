using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireQ_1_1.Model;

namespace FireQ_1_1.ViewModel.DevicesViewModel
{
    public class DeviceBaseViewModel : BaseViewModel
    {
        private Device device;
        public Device Device
        {
            get { return device; }
            set
            {
                device = value;
                OnPropertyChanged(nameof(device));
            }
        }
    }
}
