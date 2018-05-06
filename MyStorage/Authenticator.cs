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

        public static bool CheckUser(string login, string pass)
        {
            //User resUser = null;
            DB.Connect();

            List<string> list = DB.Select("select * from users where passhash='" + CalculateMD5Hash(pass) + "' and login='" + login + "';");

            if (list.Count() == 1)
            {
                var splitArr = list[0].Split(' ');
                CurrentUser.user = new User(Convert.ToInt32(splitArr[0]), splitArr[1], splitArr[2], splitArr[3], splitArr[4], splitArr[5]);
            }
            else { throw new AuthenticationException("Пользователь не найден!\r\nПроверьте логин и пароль!"); }

            return true;
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
