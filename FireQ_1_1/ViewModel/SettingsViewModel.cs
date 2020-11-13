﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using FireQ_1_1.Commands;

namespace FireQ_1_1.ViewModel
{
    public class SettingsViewModel : BaseViewModel
    {
        public SettingsViewModel(MainViewModel mainViewModel)
        {
            Console.WriteLine("Constructor - SettingsViewModel - argument: mainViewModel");

            MainViewModel = mainViewModel;
            SaveCommand = new SaveCommand(this);
            CloseCommand = new CloseCommand(this);

        }
        public ICommand SaveCommand { get; set; }

        public override void Save()
        {

        }
        public ICommand CloseCommand { get; set; }

        public override void Close()
        {
            MainViewModel.ActiveViewModel = new HomeViewModel(MainViewModel);
        }
    }
}
