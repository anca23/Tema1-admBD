using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using PresentationLayer;

namespace BusinessLayer
{

    class LoginManage
    {
        public void login(string username, string password, string file_path)
        {
            User usr = new User(username, password.GetHashCode());
            usr.login(file_path);
        }

        public void show_message(string mesaj)
        {
            Form1 ob =new Form1();
            ob.show_message(mesaj);
        }
    }
    
        //public bool verify_user(string usr, string pass)
        //{
        //    int hash_pass = pass.GetHashCode();
        //   // User ob_usr = new User(usr, hash_pass);
        //    return true;
        //}
    
}
