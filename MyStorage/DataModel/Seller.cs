using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStorage.DataModel
{
    class Seller : User
    {
        public Seller(User u)
            : base(u.ID, u.Role, u.Name, u.Middle_name, u.Last_name, u.Login, u.Hashpass)
        {
        }
        public override void Sale()
        {

        }
        public override void Show()
        {
            
        }
    }
}
