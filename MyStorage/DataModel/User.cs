using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MyStorage.Database;

namespace MyStorage.DataModel
{
    class User 
    {
        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Middle_name { get => middle_name; set => middle_name = value; }
        public string Role { get => role; set => role = value; }
        public string Login { get => login; set => login = value; }
        public string Hashpass { get => hashpass; }
        public string Last_name { get => last_name; set => last_name = value; }

        public User(int id,string role,string name, string middle_name, string last_name, string login,string hashpass)
        {            
            this.hashpass = hashpass;
            this.login = login;
            this.id = id;
            this.name = name;
            this.middle_name = middle_name;
            this.last_name = last_name;
            this.role = role;
        }       

        public virtual void Sale()
        {

        }
        
        public virtual void Receipt()
        {

        }

        public virtual void Show()
        {

        }

        private int id;
        private string role;
        private string name;
        private string middle_name;
        private string last_name;        
        private string hashpass;
        private string login;
    }
}
