using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStorage.DataModel
{
    class Product
    {
        public int id;
        public string Name="";        
        public string About="";        
        public Product(int id,string name,string about)
        {
            this.id = id;
            Name = name;
            About = about;
        }
    }
}
