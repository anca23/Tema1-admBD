using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BusinessLayer;

namespace DataLayer
{

            class User 
        {
            public string username;
            public int hash_password;
            public bool permission;
            public User(string us, int pass)
            {
                if ((us == null) || (pass == 0))
                {
                    Exception ex = new Exception("Campurile username sau password nu pot fi goale!");
                }
                username = us;
                hash_password= pass;
                permission = true;
            }

            public void verifica_user()
            {
 
            }

        }
    

    
}
