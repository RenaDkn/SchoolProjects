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
    public partial class Form1 : Form
    {
        public string flag1,stat;
        public int flag,f;
        Stats object1;
        public string connectionstring;
        public Form1()
        {//constructor
            InitializeComponent();
            label1.Text = "Name:";
            //dimiourgia combobox
            comboBox1.Items.Add("Name");
            comboBox1.Items.Add("Email");
            comboBox1.Items.Add("Phone");
            comboBox1.Items.Add("Gender");
            comboBox1.Items.Add("Birth");
            comboBox1.Items.Add("Address");
            comboBox1.Items.Add("Diseases");
            object1 = new Stats();
            connectionstring = @"Data Source=..\..\..\..\WebCovid19\WebCovid19\App_Data\Covid19.db;Version=3;";
            f = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                richTextBox1.Clear();
            }

        }
        //start of menustrip(click)
        private void insertAPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {//insert a patient (form2 open)
            Form2 f2 = new Form2();
            f2.Show();
            f2.f1 = this;
            this.Hide();
        }
        private void deleteAPatientToolStripMenuItem1_Click(object sender, EventArgs e)
        {//delete a patient
            flag1 = "delete";
            label1.Visible = true;
            label1.Text = "Name:";
            textBox1.Visible = true;
            label3.Visible = true;
            label3.Text = "Type tha name of the patient you want to delete";
            button2.Text = "Delete";
            button2.Visible = true;
        }
        private void editAPatientToolStripMenuItem1_Click(object sender, EventArgs e)
        {//edit a patient
            flag1 = "edit";
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            comboBox1.Visible = true;
            button2.Visible = true;
            label1.Text = "Type tha name of the patient you want to edit:";
            label2.Text = "Edit into:";
            label3.Visible = true;
            label3.Text = "Choose what u want to edit:";
            button2.Text = "Edit";

        }
        private void viewAllPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {//view all patients

            Form3 f3 = new Form3();
            f3.f1 = this;
            f3.Show();
            this.Hide();
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {//search patients by name and phone
            label1.Visible = true;
            label2.Visible = true;
            label2.Text = "Phone";
            textBox1.Visible = true;
            textBox2.Visible = true;
            button1.Visible = true;

        }
        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {//search patients by name and email
            label1.Visible = true;
            label2.Visible = true;
            label2.Text = "Email";
            textBox1.Visible = true;
            textBox2.Visible = true;
            button1.Visible = true;
        }
        private void patientsPerAgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            button3.Visible = true;
            stat = "num";
        }
        private void nuberOfPatientsPerGenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object1.PatperGender();
        }
        private void percentageOfPatientsPerAgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            button3.Visible = true;
            stat = "perc";
        }

        private void percentageOfPatientsPerGenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object1.PercperGender();
        }
        //end of menustrip(click)
        private void button1_Click(object sender, EventArgs e)
        {//search button
            int i;
            flag = 1;
            String query = "SELECT * FROM patients";
            using (SQLiteConnection conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (label2.Text == "Phone")//search name and phone
                    {
                        i = 3;
                    }
                    else
                    {//search name and email
                        i = 2;
                    }
                    if (textBox1.Text == reader.GetValue(1).ToString() && textBox2.Text == reader.GetValue(i).ToString())
                    {//elegxos ama uparxei patient me auto to name kaiphone h email adistixa
                        richTextBox1.Text = "NAME:" + reader.GetValue(1) + Environment.NewLine + "EMAIL:" + reader.GetValue(2) + Environment.NewLine + "PHONE" +
                       reader.GetValue(3) + Environment.NewLine + "GENDER:" + reader.GetValue(4) + Environment.NewLine + "BIRTH:" + reader.GetValue(5) + Environment.NewLine
                       + "ADDRESS:" + reader.GetValue(6) + Environment.NewLine + "DISEASES:" + reader.GetValue(7) + Environment.NewLine;
                        label1.Visible = false;
                        label2.Visible = false;
                        label2.Text = "Phone";
                        textBox1.Visible = false;
                        textBox2.Visible = false;
                        button1.Visible = false;
                        flag = 0;
                    }

                }
                reader.Close();
                conn.Close();
                if (flag == 1)
                {
                    richTextBox1.Text = " Ο ασθενης δεν βρέθηκε,προσπαθηστε ξανα!";
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {//delete or edit button
            if (flag1 == "delete")
            {//delete
                f = 1;
                if (textBox1.Text !="")
                {

                    SQLiteConnection conne = new SQLiteConnection(connectionstring);
                    string query = "SELECT * FROM patients";
                    SQLiteCommand cmd = new SQLiteCommand(query,conne);
                    conne.Open();
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (textBox1.Text == reader.GetString(1))//elegxos ama uparxei patient stin vasi me auto to name
                        {
                            f = 0;
                            break;
                        }
                        else
                        {
                            f = 1;
                        }
                    }
                    reader.Close();
                    conne.Close();
                    if (f == 0)
                    {//diagrafi patient
                        using (SQLiteConnection conn = new SQLiteConnection(connectionstring))
                        {
                            SQLiteCommand command = new SQLiteCommand(conn);
                            conn.Open();
                            command.CommandText = "DELETE FROM patients WHERE name =@t1";
                            command.Parameters.AddWithValue("@t1", textBox1.Text);
                            command.ExecuteNonQuery();
                            conn.Close();
                            label1.Visible = false;
                            textBox1.Visible = false;
                            label3.Visible = false;
                            button2.Visible = false;
                            MessageBox.Show("Η διαγραφή ασθενή έγινε επιτυχώς!");
                        }
                    }
                    else
                    {//ean den uparxei asthenis me auto to onoma
                        MessageBox.Show("Η διαγραφή ασθενή δεν πραγματοποιηθηκε επιτυχώς διοτι δεν υπαρχει ασθενης με αυτο το ονομα!");
                    }
                }
                else
                {//ean to textbox einai keno
                    MessageBox.Show("ΠΛΗΚΡΟΛΟΓΙΣΤΕ ΤΟ ΟΝΟΜΑ ΤΟΥ ΧΡΗΣΤΗ ΠΟΥ ΘΕΛΕΤΕ ΝΑ ΔΙΑΓΡΑΨΕΤΕ!");
                }
            }
            else //edit
            {
                if (textBox1.Text !="")
                {//elegxos ean to pedio einai keno
                    string q2;
                    string edit = comboBox1.GetItemText(comboBox1.SelectedItem).ToString(); //timi combobox
                    if (edit != null)
                    {//vazoume to analogo query analoga me tin epilogi tou xristi sto combobox
                        if (edit == "Name")
                        {
                            q2 = "UPDATE patients SET name = @value WHERE name =@t1";
                        }
                        else if (edit == "Email")
                        {
                            q2 = "UPDATE patients SET email = @value WHERE name =@t1";

                        }
                        else if (edit == "Phone")
                        {
                            q2 = "UPDATE patients SET phone = @value WHERE name =@t1";
                        }
                        else if (edit == "Gender")
                        {
                            q2 = "UPDATE patients SET gender = @value WHERE name =@t1";
                        }
                        else if (edit == "Birth")
                        {
                            q2 = "UPDATE patients SET birth = @value WHERE name =@t1";
                        }
                        else if (edit == "Address")
                        {
                            q2 = "UPDATE patients SET address = @value WHERE name =@t1";
                        }
                        else
                        {
                            q2 = "UPDATE patients SET diseases = @value WHERE name =@t1";
                        }
                        using (SQLiteConnection conne = new SQLiteConnection(connectionstring))
                        {
                            conne.Open();
                            string query = "SELECT * FROM patients";
                            SQLiteCommand cmd = new SQLiteCommand(query, conne);
                            SQLiteDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {

                                if (textBox1.Text == reader.GetString(1))//elegxos ama uparxei patient me auto to name
                                {
                                    f = 0;
                                    break;
                                }
                                else
                                {
                                    f = 1;
                                }

                            }
                            reader.Close();
                            conne.Close();
                        }
                        if (f == 0)
                        {//edit patient
                            using (SQLiteConnection conn = new SQLiteConnection(connectionstring))
                            {
                                SQLiteCommand command = new SQLiteCommand(q2, conn);
                                command.Parameters.AddWithValue("@t1", textBox1.Text);
                                command.Parameters.AddWithValue("@value", textBox2.Text);
                                conn.Open();
                                command.ExecuteNonQuery();
                                conn.Close();
                                MessageBox.Show("Η επεξεργασία ασθενη εγινε επιτυχως!");
                                label1.Visible = false;
                                label2.Visible = false;
                                textBox1.Visible = false;
                                textBox2.Visible = false;
                                comboBox1.Visible = false;
                                button2.Visible = false;
                                label3.Visible = false;

                            }

                        }
                        else
                        {//ean den uparxei asthenis me auto to onoma
                            MessageBox.Show("Η επεξεργασία ασθενή δεν πραγματοποιηθηκε επιτυχώς διοτι δεν υπαρχει ασθενης με αυτο το ονομα!");
                        }
                    }
                    else
                    {//ean o xristis den exei epilejei kati apo to combobox
                        MessageBox.Show("ΕΠΙΛΕΞΤΕ ΤΙ ΘΕΛΕΤΕ ΝΑ ΑΛΛΑΞΕΤΕ ΑΠΟ ΤΙΣ ΕΠΙΛΟΓΕΣ!");
                    }
                }
                else
                {//ean to textbox einai keno
                    MessageBox.Show("ΠΛΗΚΡΟΛΟΓΙΣΤΕ ΤΟ ΟΝΟΜΑ ΤΟΥ ΧΡΗΣΤΗ ΠΟΥ ΘΕΛΕΤΕ ΝΑ ΕΠΕΞΕΡΓΑΣΤΕΙΤΕ!");
                }
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {//search stats button("click here")
            if (textBox3.Text != null)
            {//elegxos an to textbox einai keno
                if (stat == "num")
                {//elegxos gia to pia sinartisi na kalestei
                    //arithmos patient analoga tin ilikia
                    object1.PatperAge(Int32.Parse(textBox3.Text));
                }
                else
                { //pososto patient analoga tin ilikia
                    object1.PercPerAge(Int32.Parse(textBox3.Text));
                }
                textBox3.Visible = false;
                textBox3.Clear();
                button3.Visible = false;
            }
            else
            {//emfanisi minimatos ean to textbox einai keno
                MessageBox.Show("Γράψε την ηλικία που θελεις να ψαξεις τα στατιστικά!");
            }
        }
       
    }
}
