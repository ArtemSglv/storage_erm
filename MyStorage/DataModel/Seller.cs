using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStorage.DataModel
{
    class Seller : User
    {
        public Seller(string fio, string secondname, string lastname, string phonenumber, string role) 
            : base(fio, secondname, lastname, phonenumber, role)
        {
        }
    }
}
