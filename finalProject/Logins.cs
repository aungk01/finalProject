using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    
    class Logins
    {
        private string _username;
        private int _passWord;
        public Logins(string userName, int passWord)
        {
            _username = userName;
            _passWord = passWord;
        }
        public string Username
        {

            get { return this._username; }
            set { _username = value; }
        }
        public int passWord
        {
            get { return this._passWord; }
            set { _passWord = value; }
        }
    }  
}
