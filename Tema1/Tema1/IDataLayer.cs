using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tema1
{
    interface IDataLayer
    {
    }

    class UsersContainer : IDataLayer
    {
        public File f;
    }

    class User : IDataLayer
    {
        public string username;
        public int password;
        public bool permission;
        public User(string us, int pass)
        {
            if ((us == null) || (pass == 0))
            {
                Exception ex = new Exception("Campurile username sau password nu pot fi goale!");
            }
            username = us;
            password = pass;
            permission = true;
        }

        public verifica_user();


    }
}
