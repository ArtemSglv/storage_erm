using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStorage.DataModel
{
    class  User
    {
        public string FIO { get => fio; set => fio = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public string Role { get => role; set => role = value; }
        public string Login { get => login; set => login = value; } 
        public string Passhash { get => passhash; }
        
        public User(string fio,string secondname,string lastname,string phonenumber,string role,string passhash,string login)
        {
            this.fio = fio;
            this.phonenumber = phonenumber;
            this.role = role;
        }

        public void Signin()
        {

        }

        private string fio;
        private string phonenumber;
        private string role;
        private string passhash;
        private string login;
        private string secondname;
        private string lastname;
    }
}
