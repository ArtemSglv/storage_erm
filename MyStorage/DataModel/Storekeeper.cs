using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStorage.DataModel
{
    class Storekeeper : User
    {
        public Storekeeper(int id, string fio, string phonenumber, string role,string passhash,string login) 
            : base(id, fio, phonenumber, role,passhash,login)
        {
        }
    }
}
