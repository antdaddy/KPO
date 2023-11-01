using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    public class Employee
    {
        protected string _login = "ivaniv";
        public virtual string Login
        {
            get
            {
                return _login;
            }
            set
            {
                _login = value;
            }
        }

        protected string _password = "ivaniv123";
        public virtual string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        public virtual string GenerateNewPassword()
        {
            int num = 8;
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
            Random rand = new Random();
            _password = "";
            for (int i = 1; i <= num; i++)
            {
                int letter_num = rand.Next(0, letters.Length - 1);
                _password += letters[letter_num];
            }
            return _password;
            throw new System.NotImplementedException();
        }
    }
}
