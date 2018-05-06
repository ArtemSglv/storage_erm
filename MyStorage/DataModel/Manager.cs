using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStorage.DataModel
{
    class Manager : User
    {
        public Manager(string fio, string secondname, string lastname, string phonenumber, string role,string ) 
            : base(fio, secondname, lastname, phonenumber, role)
        {
        }
    }
}
