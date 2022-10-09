using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectalephs1
{
    public partial class Form1 : Form
    {
        List<Users> listauser = new List<Users>();
        

        public Form1()
        { 
            InitializeComponent();
            listauser.Add(new Users("rena", "12345", "cat"));
            listauser.Add(new Users("tolis", "asdfg", "parot"));
            listauser.Add(new Users("evri", "qwert", "dog"));
            listauser.Add(new Users("dony", "1q2w3e", "duck"));
            listauser.Add(new Users("mina", "zxcvb", "bunny"));
            
    }
       
       

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Users obj in listauser){
                
                if (textBox1.Text.Equals(obj.username) && textBox2.Text.Equals(obj.password))
                {
                    Form2 f2 = new Form2(obj);
                    f2.Show();
                    textBox1.Clear();
                    textBox2.Clear();
                    f2.x = this;
                    this.Hide();
                    return;
                }
                
            }
            MessageBox.Show("Wrong username or/& password");
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
