using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStorage.DataModel
{
    class Client
    {
        public int ID { get => id; set => id = value; }
        public string Cl_type { get => cl_type; set => cl_type = value; }
        public string Name { get => name; set => name = value; }
        public string Middle_name { get => middle_name; set => middle_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }        

        public Client(int id,string cl_type,string name,string middle_name,string last_name)
        {
            this.id = id;
            this.cl_type = cl_type;
            this.name = name;
            this.middle_name = middle_name;
            this.last_name = last_name;
        }
        public Client()
        {
            this.id = int.MinValue;
            this.cl_type = string.Empty;
            this.name = string.Empty;
            this.middle_name = string.Empty;
            this.last_name = string.Empty;
        }
        public Client(Client cl)
        {
            this.id = cl.ID;
            this.cl_type = cl.Cl_type;
            this.name = cl.Name;
            this.middle_name = cl.Middle_name;
            this.last_name = cl.Last_name;
        }

        private int id;
        private string cl_type;
        private string name;
        private string middle_name;
        private string last_name;
    }
}
