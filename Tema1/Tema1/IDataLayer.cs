using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BusinessLayer;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace DataLayer
{

           public class User 
        {
            public string username{get; set;}
            public int hash_password{get; set;}
            public bool permission { get; set; }

            public User()
            {
                username = "username";
                hash_password = 0;
                permission = false;
            }

            public User(string us, int pass)
            {
                if ((us == null) || (pass == 0))
                {
                    Exception ex = new Exception("Campurile username sau password nu pot fi goale!");
                }
                username = us;
                hash_password= pass;
                permission = false;
            }

            public void login(string path)
            {

                XmlSerializer xs = new XmlSerializer(typeof(User));
                User ob_usr;
                using (StreamReader sr = new StreamReader(path))
                {
                    while ((ob_usr = (User)xs.Deserialize(sr)) != null)
                    {
                        if ((ob_usr.username == this.username) && (ob_usr.hash_password == this.hash_password) &&
                            (ob_usr.permission == this.permission))
                        {
                            LoginManage ob_log = new LoginManage();
                            ob_log.show_message("Logarea s-a efectuat cu succes!");
                        }
                    }
 
                }
 
            }

        }

            class XmlUsersManage
            {

               //public File f;

            }
    

    
}
