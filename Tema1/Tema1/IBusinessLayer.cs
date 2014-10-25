using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{

    class LoginManage
    {
        public void login(string username, string password)
        {
            User usr = new User(username, password.GetHashCode());
            usr.verifica_user();
        }
    }
    
        //public bool verify_user(string usr, string pass)
        //{
        //    int hash_pass = pass.GetHashCode();
        //   // User ob_usr = new User(usr, hash_pass);
        //    return true;
        //}
    
}
