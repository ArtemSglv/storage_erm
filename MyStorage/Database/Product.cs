using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStorage.DataModel
{
    class Product
    {
        private int id;
        private string name;
        private string about;
        private int count;
        private double price;
        public Product(int id,string name,string about,int count, double price)
        {
            this.id = id;
            this.name = name;
            this.about = about;
            this.count = count;
            this.price = price;
        }
        public Product(Product pr)
        {
            id = pr.id;
            name = pr.name;
            about = pr.about;
            count = pr.count;
            price = pr.price;
        }

        public double Price { get => price; set => price = value; }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string About { get => about; set => about = value; }
        public int Count {
            get => count;
            set => count = value; }
    }
}
