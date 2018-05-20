using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStorage.DataModel
{
    class Store
    {
        public List<Product> products;
        public string name;
        public int id;
        public Store(int id,string name)
        {
            this.id = id;
            this.name = name;
            products = new List<Product>();
        }
        public Store()
        {
            id = int.MinValue;
            name = string.Empty;
            products = new List<Product>();
        }
    }
}
