using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FireQ_1_1
{
    public class AppInit
    {
        public string ConfigPath { get; set; }
        public void Init()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.localizationCode);
        }
    }
}
