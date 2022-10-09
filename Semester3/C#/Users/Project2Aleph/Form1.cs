using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2Aleph
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Name box is empty!");
            }
            else if ( String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Age box is empty!");
            }
            else if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Grade box is empty!");
            }
            else 
            {
                StreamWriter sw = new StreamWriter("text.txt", true);
                sw.WriteLine(textBox1.Text + "." + textBox2.Text + "." + textBox3.Text);           
                sw.Close();
                Students student = new Students();
                student.name = textBox1.Text;
                student.age = textBox2.Text;
                student.grade = textBox3.Text;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("text.txt");
            String line = sr.ReadLine();

            StringBuilder sb = new StringBuilder();
            while (line != null)
            {
                sb.Append(line);
                sb.Append(Environment.NewLine);
                line = sr.ReadLine();
            }
            sr.Close();
            MessageBox.Show(sb.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {//search by name
            int flag = 0;
            StreamReader sr = new StreamReader("text.txt");
            string line = sr.ReadLine();
            while (line != null)
            {
                line = line.ToString();
                string[] split = line.Split('.');
                if (split[0] == textBox4.Text)
                {
                    Form2 f2 = new Form2 (split);
                    f2.Show();
                    flag = 1;
                    break;
                }
                else
                {
                    line = sr.ReadLine();

                }
            }
            if (flag == 0)
            {
                MessageBox.Show("Student didn't found");
            }
            textBox4.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
