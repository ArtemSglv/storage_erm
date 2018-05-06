using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStorage.DataModel
{
    class User
    {
        public int ID { get => id; set => id = value; }
        public string FIO { get => fio; set => fio = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public string Role { get => role; set => role = value; }
        public string Login { get => login; set => login = value; }
        public string Passhash { get => passhash; }

        public User(int id, string fio, string phonenumber, string role, string passhash, string login)
        {
            this.id = id;
            this.fio = fio;
            this.phonenumber = phonenumber;
            this.role = role;
            this.passhash = passhash;
            this.login = login;
        }

        private int id;
        private string fio;
        private string phonenumber;
        private string role;
        private string passhash;
        private string login;
    }
}
