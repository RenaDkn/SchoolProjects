using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCovid19
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Stats obj;
        protected void Page_Load(object sender, EventArgs e)
        {
            obj = new Stats();
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            if (TextBox2.Text !="")
            {
                
                obj.PatperAge(Int32.Parse(TextBox2.Text));
                TextBox1.Text = obj.returnn;
            }
            else
            {
                TextBox1.Text = "Παρακαλώ σημπληρώστε το πεδίο: type here:";
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {

                obj.PercperGender();
                TextBox1.Text = obj.returnn;

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = null;
            TextBox2.Text = null;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text !="")
            {

                obj.PercPerAge(Int32.Parse(TextBox2.Text));
                TextBox1.Text = obj.returnn;
            }
            else
            {
                TextBox1.Text = "Παρακαλώ σημπληρώστε το πεδίο: type here:";
            }
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            obj.PatperGender();
            TextBox1.Text = obj.returnn;
        }
    }
}