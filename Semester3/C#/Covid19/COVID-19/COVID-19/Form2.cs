using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVID_19
{
    public partial class Form2 : Form 
    {
        public Form1 f1;
        string timestamp;
        bool save;
        public Form2()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            save = false;
            if (textBox1.Text!="" && textBox2.Text!="" && textBox3.Text!="" && maskedTextBox1.Text!="" &&textBox6.Text!="")
            {//elegxos ama ta pedia einai kena
                Patient pat = new Patient();
                //perasma timwn sto object tis klasis Patient
                pat.name = textBox1.Text;
                pat.email = textBox2.Text;
                pat.phone = textBox3.Text;
                if (radioButton1.Checked)
                {
                    pat.gender ="Άνδρας";

                }
                else if (radioButton2.Checked)
                {
                    pat.gender = "Γυναίκα";
                }
                else
                {
                    pat.gender = "Άλλο";
                }
                
                pat.birth = maskedTextBox1.Text;
                pat.address = textBox6.Text;
                pat.diseases = richTextBox1.Text;
                timestamp = DateTime.Now.ToString();
                string connectionstring = @"Data Source=..\..\..\..\WebCovid19\WebCovid19\App_Data\Covid19.db;Version=3;";
                String insert = "INSERT INTO patients (name,email,phone,gender,birth,address,diseases,time)Values(@name,@email,@phone,@gender,@birth,@address,@diseases,@timestamp)";
                using (SQLiteConnection conn = new SQLiteConnection(connectionstring))
                {
                    SQLiteCommand command = new SQLiteCommand(insert, conn);
                    conn.Open();
                    //perasma timwn stin vasi
                    command.Parameters.AddWithValue("@name", pat.name);
                    command.Parameters.AddWithValue("@email", pat.email);
                    command.Parameters.AddWithValue("@phone", pat.phone);
                    command.Parameters.AddWithValue("@gender", pat.gender);
                    command.Parameters.AddWithValue("@birth", pat.birth);
                    command.Parameters.AddWithValue("@address", pat.address);
                    command.Parameters.AddWithValue("@diseases", pat.diseases);
                    command.Parameters.AddWithValue("@timestamp", timestamp);
                    command.ExecuteNonQuery();
                    conn.Close();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    maskedTextBox1.Clear();
                    textBox6.Clear();
                    richTextBox1.Clear();
                    
                }

            }
            else
            {//minima ean ta pedia einai kena
                MessageBox.Show("Παρακαλουμε συμπληρωστε ολα τα υποχρεωτικα πεδία");
                
            }     
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //klisimo autis tis formas(form2) kai anigma tin formas 1
            this.Close();
            f1.Show();
        }

        
    }
}
