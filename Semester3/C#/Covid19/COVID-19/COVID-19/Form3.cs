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
    public partial class Form3 : Form
    { 
        public Form1 f1;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //emfanisi olwn twn patient
            string connectionstring = @"Data Source=..\..\..\..\WebCovid19\WebCovid19\App_Data\Covid19.db;Version=3;";
            String query = "SELECT * FROM patients";
            using (SQLiteConnection conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    richTextBox1.Text += reader.GetValue(1) + "," + reader.GetValue(3) + "," +
                        reader.GetValue(4) + "," + reader.GetValue(5) + "," + reader.GetValue(6) + "," + reader.GetValue(7) +
                         "," + reader.GetValue(8) + Environment.NewLine;
                }
                reader.Close();
                conn.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //klisimo autis tis formas(form3) kai anigma tin formas 1
            this.Close();
            f1.Show();
        }
    }
}
