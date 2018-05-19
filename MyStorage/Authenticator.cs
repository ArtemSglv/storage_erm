using MyStorage.DataModel;
using MyStorage.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace MyStorage
{
    class Authenticator
    {       
        public static void Login(string login, string pass)
        {
            DB.Connect();

            string user_str = DB.SelectUser(CalculateMD5Hash(pass), login);

            if (user_str != "")
            {
                var splitArr = user_str.Split(' ');
                CurrentUser.user = new User(Convert.ToInt32(splitArr[0]), splitArr[1], splitArr[2], splitArr[3], splitArr[4], splitArr[5], splitArr[6]);
                switch(CurrentUser.user.Role)
                {
                    case "Seller": { CurrentUser.user = new Seller(CurrentUser.user); break; }
                    case "Storekeeper": { CurrentUser.user = new Storekeeper(CurrentUser.user); break; }
                    case "Manager": { CurrentUser.user = new Manager(CurrentUser.user); break; }
                }                
            }
            else { throw new AuthenticationException("Пользователь не найден!\r\nПроверьте логин и пароль!"); }
        }

        private static string CalculateMD5Hash(string input)
        {

            // step 1, calculate MD5 hash from input

            MD5 md5 = System.Security.Cryptography.MD5.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);

            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)

            {

                sb.Append(hash[i].ToString("x2"));

            }

            return sb.ToString();

        }
    }
}
