using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1
{
    interface IBusinessLayer
    {
    }

    class UsersManage 
    {
        public bool verify_user(string usr, string pass)
        {
            int hash_pass = pass.GetHashCode();
            User ob_usr = new User(usr, hash_pass);
            return true;
        }
    }
}
