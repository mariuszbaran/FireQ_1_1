using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireQ_1_1.Model
{
    public class User
    {
        private string name;
        public string Name
        {
            get { return name; }
            set 
            { 
                name = value;
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
            }
        }
        
        /*Access Level
         * 0 - super admin - maintenance 
         * 1 - admin - Customer level
         * 2 - super user - Can add, edit, delete.
         * 3 - user - Can add.
         */
        public int AccessLevel { get; set; }

    }
}
