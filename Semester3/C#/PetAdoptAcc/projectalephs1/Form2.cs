using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectalephs1
{
    public partial class Form2 : Form
    {
        public Form1 x = null;
        public String password;
        public Form2(Users obj)
        {
            
            InitializeComponent();
            password = obj.password;
            label2.Text = obj.username;
            label4.Text = obj.katikidio;
            
            if (obj.katikidio == "cat")
            {
                BackColor = Color.MediumVioletRed;

            }else if (obj.katikidio == "parot")
            {
                BackColor = Color.Coral;
            }
            else if (obj.katikidio == "dog")
            {
                BackColor = Color.DarkSalmon;
            }
            else if (obj.katikidio == "duck")
            {
                BackColor = Color.PeachPuff;
            }
            else
            {
                BackColor = Color.Salmon;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //exit buttom
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            x.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = password;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "*****";
        }
    }
}
