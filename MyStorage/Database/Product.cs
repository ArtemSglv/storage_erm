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
        public int count;
        public double price;
        public Product(int id,string name,int count,double price,string about)
        {
            this.id = id;
            Name = name;
            this.count = count;
            this.price = price;
            About = about;
        }
    }
}
