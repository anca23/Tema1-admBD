using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema1
{
    public partial class Form1 : Form,IPresentationLayer
    {
        public Form1()
        {
            InitializeComponent();
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

            if ((BoxUsername.Text!=null)&&(BoxPassword.Text!=null))
            {
                

            }
        }
    }
}
