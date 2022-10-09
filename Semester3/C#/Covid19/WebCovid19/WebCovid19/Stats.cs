using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;

namespace WebCovid19
{

    public class Stats
    {
        public string returnn;
        int patYear, count, date;
        float countM, countW, countO;
        string patAge, patGender;
        string connectionstring ;
        String query;
        public Stats()
        {
            countM = 0;
            countW = 0;
            countO = 0;
            count = 0;
            connectionstring = @"Data Source=|DataDirectory|Covid19.db;Version=3;";
            query = "SELECT * FROM patients";
        }
        public void PatperGender()
        {//arithmos atomwn giakathe genos
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
           returnn="Ο αριθμός των κρουσμάτων ειναι: " + countM + " άνδρες," + Environment.NewLine
                + countW + " γυναίκες," + Environment.NewLine + countO + " άλλο.";
        }
        public void PatperAge(int age)
        {//arithmos atomwn gia to age
            count = 0;
            date = DateTime.Now.Year;
            date = date - age;
            using (SQLiteConnection conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
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
            returnn = count.ToString() + " κρουσματα ηλικιας " + age.ToString();
        }
        public void PercperGender()
        {//pososto atomwn gia kathe genos
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
            if (count != 0)
            {
                countM = countM / count * 100;
                countW = countW / count * 100;
                countO = countO / count * 100;
            }
            returnn ="Τα ποσοστά των κρουσματων ειναι: " + countM+ "% άνδρες," + Environment.NewLine
                + countW + "% γυναίκες," + Environment.NewLine + countO + "% άλλο.";
        }
        public void PercPerAge(int age)
        {//pososto atomwn gia to age
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
                countO = count / countO * 100;

            }
            returnn = countO.ToString() + "% κρουσματα ηλικιας " + age.ToString();

        }
    }

}
