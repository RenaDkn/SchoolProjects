using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVID_19
{
    class Stats
    {
        int patYear, date;
        float countM, countW, countO, count;
        string patAge,patGender;
        string connectionstring,query;
        
        public Stats() {
            countM = 0;
            countW = 0;
            countO = 0;
            count = 0;
            connectionstring = @"Data Source=..\..\..\..\WebCovid19\WebCovid19\App_Data\Covid19.db;Version=3;";
            query = "SELECT * FROM patients";
        }
        public void PatperAge(int age)
        {//arithmos atomwn analoga tin ilikia (age)
            count = 0;
            date = DateTime.Now.Year;
            date = date - age;
            using (SQLiteConnection conn = new SQLiteConnection(connectionstring))
            {
                SQLiteCommand command = new SQLiteCommand(query, conn);
                conn.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    patAge = reader.GetValue(5).ToString();
                    string[] year = patAge.Split('/');
                    patAge = year[2];
                    patYear =Int32.Parse(patAge);
                    if (patYear == date)
                    {
                        count++;
                    }
                }
                reader.Close();
                conn.Close();
            }
            //emfanisi arithmou patient gia to age
            MessageBox.Show(count.ToString()+" κρουσματα ηλικιας "+age.ToString() );
        }
        public void PatperGender()
        {//arithmos atomwn gia kathw genos
            countM = 0;
            countW = 0;
            countO = 0;
            count = 0;
            using (SQLiteConnection conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    patGender = reader.GetString(4);
                    if (patGender == "Άνδρας")
                    {
                        countM++;
                    }
                    else if (patGender == "Γυναίκα")
                    {
                        countW++;
                    }
                    else
                    {
                        countO++;
                    }
                }
                reader.Close();
                conn.Close();
            }
            //emfanisi arithmwn patient gia kathe gender
            MessageBox.Show("Ο αριθμός των κρουσμάτων ειναι: " + countM + " άνδρες," + Environment.NewLine
                + countW + " γυναίκες," + Environment.NewLine + countO + " άλλο.");
        }
        public void PercperGender()
        {//pososta gia ola ta geni
            countM = 0;
            countW = 0;
            countO = 0;
            count = 0;
            using (SQLiteConnection conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    count++;
                    patGender = reader.GetString(4);
                    if (patGender=="Άνδρας")
                    {
                        countM++; 
                    }else if(patGender == "Γυναίκα")
                    {
                        countW++;
                    }
                    else
                    {
                        countO++;
                    }
                }
                reader.Close();
                conn.Close();
            }
            if (count != 0)
            {
                countM = countM / count * 100;
                countW = countW / count * 100;
                countO = countO / count * 100;
            } 
            //emfanisi posostwn krusmatwn gia kathe genos
            MessageBox.Show("Τα ποσοστά των κρουσματων ειναι: "+countM+"% άνδρες,"+Environment.NewLine
                +countW+"% γυναίκες,"+Environment.NewLine+countO+"% άλλο.");
        }

        public void PercPerAge(int age)
        {//pososta gia tin ilikia (age)
            count = 0;
            countO = 0;
            date = DateTime.Now.Year;
            date = date - age;
            using (SQLiteConnection conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    countO++;
                    patAge = reader.GetValue(5).ToString();
                    string[] year = patAge.Split('/');
                    patAge = year[2];
                    patYear = Int32.Parse(patAge);
                    if (patYear == date)
                    {
                        count++;
                    }
                }
                reader.Close();
                conn.Close();
            }
            if (countO != 0)
            {
                count = count / countO * 100;
            }
            //emfanisi posostou patient gia to age
            MessageBox.Show(count.ToString() + "% κρουσματα ηλικιας " + age.ToString());
        }
    }

}
