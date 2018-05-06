using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStorage.DataModel
{
    class Seller : User
    {
        public Seller(int id, string fio, string phonenumber, string role,string passhash,string login) 
            : base(id, fio, phonenumber, role,passhash,login)
        {
        }
    }
}
