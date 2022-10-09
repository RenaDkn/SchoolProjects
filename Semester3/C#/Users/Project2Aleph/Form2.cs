using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2Aleph
{
    public partial class Form2 : Form
    {
        
        public Form2(string[] split)
        {
            
            InitializeComponent();
            label1.Text += split[0];
            label2.Text += split[1];
            label3.Text += split[2];
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
