using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStorage.DataModel
{
    class Storekeeper : User
    {
        public Storekeeper(User u)
            : base(u.ID, u.Role, u.Name, u.Middle_name, u.Last_name, u.Login, u.Hashpass)
        {
        }
    }
}
