using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;


namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void show_message(string mesaj)
        {
            MessageBox.Show(mesaj);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BoxUsername.Text == null)
            {
                MessageBox.Show("Nu ati completat campul username", "Eroare");
            }

            if (BoxPassword.Text == null)
            {
                MessageBox.Show("Nu ati completat campul password", "Eroare");
            }

            if (boxUserFile.Text == null)
            {
                MessageBox.Show("Nu ati selectat un fisier xml sursa pentru useri", "Eroare");
            }

            if ((BoxUsername.Text!=null)&&(BoxPassword.Text!=null)&&(boxUserFile.Text!=null))
            {

                LoginManage ob_log = new LoginManage();
                ob_log.login(BoxUsername.Text, BoxPassword.Text, boxUserFile.Text);

            }
        }

        OpenFileDialog ofd=new OpenFileDialog();

        private void button4_Click(object sender, EventArgs e)
        {
            ofd.Filter = "XML|*.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                boxUserFile.Text = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form sign_up = new Form();
            sign_up.Show();

            TextBox BoxUsr = new TextBox();
            BoxUsr.Parent = sign_up;
            BoxUsr.PointToScreen(new Point(30,30));
            BoxUsr.Show();
            

            Button b = new Button();
            b.Parent = sign_up;
            b.Name = "button_nou";
            b.Text = "ok";

            //TextBox 
           

            
           // sign_up.La
            
        }

       
     
    }
}
