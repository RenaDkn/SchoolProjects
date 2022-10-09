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

namespace Ergasia2Atomiki
{
    
    public partial class Form1 : Form
    {
        SolidBrush sb;
        Graphics g;
        Pen p;
        bool freestyle, mDown, circle,line,rect,ellipse;
        int fsX1, fsY1,count;
        string but,shape;
        string timestamp;

        public Form1()
        {
            InitializeComponent();   
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //arxikopoihsh timwn
            g = panel1.CreateGraphics();
            p = new Pen(Color.Black);
            sb = new SolidBrush(Color.Black);
            panel1.BackColor = Color.White;
            shape = null;  
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //otan patame to click tou pontikiou panw sto panel
            mDown = true;
            fsX1 = e.X;
            fsY1 = e.Y;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        { //otan metakinume ton kersora panw sto panw panw sto panel
            if (freestyle && mDown)
            {
                //elefthero sxedio me to pen panw sto panel (exontas patimeno to click)
                g.DrawLine(p, fsX1, fsY1, e.X, e.Y);
                g.FillEllipse(sb,fsX1-p.Width/2,fsY1-p.Width/2,p.Width,p.Width); //wste na min uparxoun kena otan exoume megalo width sto pencil otan zwgrafizoume
                fsX1 = e.X;
                fsY1 = e.Y;
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            //otan "afinoume" to patimeno click tou podikiou (sikonume to  daxtilo mas apo to aristero click)
            if (line && mDown)
            {
                //efthia grammh
                freestyle = false;
                g.DrawLine(p, e.X, e.Y, fsX1, fsY1); //zwgrafizoume tin grammh apo to simio pou patame to click mexri pou to afinume(x,y)
                line = false;
                shape = "line";
                timestamp = DateTime.Now.ToString();
            }
            else if (ellipse && mDown)
            {
                //ellipsi
                g.DrawEllipse(p, fsX1,fsY1,e.X-fsX1,e.Y-fsY1); //zwgrafizouem tin ellipsi
                ellipse = false;
                shape = "ellipse";
                timestamp = DateTime.Now.ToString();
            }
            else if (circle && mDown)
            {
                //kiklos
                g.DrawEllipse(p,fsX1,fsY1,e.X- fsX1 , e.X- fsX1 ); //zwgrafizoume ton kiklo (to ipsos me ton paxos prepei na einai isa wste na dimiourgithei kikloskoxi ellipsi)
                circle = false;
                shape = "circle";
                timestamp = DateTime.Now.ToString();
            }
            else if (rect && mDown)
            {
                //orthogonio parallilogrammo
                freestyle = false;
                /*auti h if elegxei apo pia meria pros pia "travame" to click  wste na dimiourgisoume to orthogonio parallilogrammo wste na valoume tis katalliles sidetagmenes*/
                if (e.X > fsX1 &&e.Y>fsY1)
                {
                    g.DrawRectangle(p, fsX1, fsY1, e.X - fsX1, e.Y - fsY1);
                }
                else if(e.X<fsX1 && e.Y > fsY1)
                {
                    g.DrawRectangle(p, e.X, fsY1, fsX1-e.X, e.Y- fsY1);
                }else if (e.X<fsX1 && e.Y<fsY1)
                {
                    g.DrawRectangle(p, e.X, e.Y, fsX1- e.X,  fsY1- e.Y);
                }
                else
                {
                    g.DrawRectangle(p, fsX1, e.Y,  e.X- fsX1, fsY1 - e.Y);
                }
                shape = "rectangle";
                timestamp = DateTime.Now.ToString();
                rect = false;
            }
            mDown = false;
            string connectionstring = "Data Source=Ergasia2Atomiki.db;Version=3;";
            String insert = "INSERT INTO Paint(Shapes,Time)Values(@shape,@timestamp)";
            if(shape!= null)
            {//perasma sximatos sto arxio
                using (SQLiteConnection conn = new SQLiteConnection(connectionstring))
                {


                    SQLiteCommand command = new SQLiteCommand(insert, conn);
                    conn.Open();
                        command.Parameters.AddWithValue("@shape", shape);
                        command.Parameters.AddWithValue("@timestamp", timestamp);
                        command.ExecuteNonQuery(); 
                   conn.Close();
                }
            }
            shape = null;
        }

        //change color
        private void showAllColorsToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            //allagi xromatos 
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                p.Color = colorDialog1.Color;
                sb.Color = p.Color;
            }       
        }
        //Choose type
        private void freestyleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //otan clickaroume apo to menu to elefthero sxedio
            freestyle = true;
        }
        //Choose shape
        private void circleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //otan clickaroume apo to menu ton kiklo
            circle = true;
            freestyle = false;
            
        }
        private void lineSegmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //otan clickaroume apo to menu tin efthia grammi
            line = true;
            freestyle = false;
        }
        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //otan clickaroume apo to menu to orthogonio parallilogrammo
            rect = true;
            freestyle = false;
        }
        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //otan clickaroume apo to menu tin ellipsi
            ellipse = true;
            freestyle = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //epilogi radio button anamesa se molivi kai gomma
            if (radioButton1.Checked)
            {//pencil
                label2.Text = "Pencil tip thickness";
                p.Color = Color.Black;
                sb.Color = p.Color;
                p.Width = hScrollBar1.Value;
                freestyle = true;
            }
            else
            {
                //eraser
                label2.Text = "Eraser thickness";
                p.Color = Color.White;
                sb.Color = p.Color;
            }
        }

        //Choose thickness of pencil
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //allagi megethous pen kai gommas meso scroll bar
            p.Width = hScrollBar1.Value;
        }
        //Ready made designs
        private void button1_Click(object sender, EventArgs e)
        {
            //otan o xristis pataei to koubi na dimiourgithei to etimo sxedio: house
            timer1.Enabled = true;
            timer1.Start();
            but = "house";
            count = 0;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //otan o xristis pataei to koubi na dimiourgithei to etimo sxedio: emoji
            timer1.Enabled = true;
            timer1.Start();
            but = "emoji";
            count = 0;      
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //otan o xristis pataei to koubi na dimiourgithei to etimo kimeno: hello
            timer1.Enabled = true;
            timer1.Start();
            but = "hello";
            count = 0;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //otan o xristis pataei to koubi na dimiourgithei to etimo kimeno: unipi
            timer1.Enabled = true;
            timer1.Start();
            but = "unipi";
            count = 0;
        }  
        private void timer1_Tick(object sender, EventArgs e)
        {
            // me to tick tou timer
            count++;
            Font font = new Font("Arial", 16);
            p.Width = 1;
            if (but == "house")
            {//dimiourgia etimou sxediou : house
                if (count == 1)
                {
                    g.DrawRectangle(p, panel1.Width / 2, panel1.Height / 2, 100, 100);
                }
                else if (count == 2)
                {
                    g.DrawLine(p, panel1.Width / 2, panel1.Height / 2, panel1.Width / 2 + 50, panel1.Height / 2 - 50);
                }
                else if (count == 3)
                {
                    g.DrawLine(p, panel1.Width / 2 + 50, panel1.Height / 2 - 50, panel1.Width / 2 + 100, panel1.Height / 2);
                    timer1.Enabled = false;
                }
            }
            else if (but == "emoji")
            {//dimiourgia etimou sxediou : emoji
                if (count == 1)
                {
                    sb.Color = Color.Yellow;
                    g.FillEllipse(sb, panel1.Width / 2, panel1.Height / 2, 100, 100);

                }
                else if (count == 2)
                {
                    sb.Color = Color.Black;
                    g.FillEllipse(sb, panel1.Width / 2 + 20, panel1.Height / 2 + 20, 20, 20);

                }
                else if (count == 3)
                {
                    g.FillEllipse(sb, panel1.Width / 2 + 60, panel1.Height / 2 + 20, 20, 20);
                }
                else if (count == 4)
                {
                    g.DrawLine(p, panel1.Width / 2 + 35, panel1.Height / 2 + 70, panel1.Width / 2 + 65, panel1.Height / 2 + 70);
                    timer1.Enabled = false;
                }
            }
            else if (but == "hello")
            {//dimiourgia etimou keimenou : hello
                switch (count)
                {
                    case 1:
                        sb.Color = Color.Red;
                        g.DrawString("H", font, sb, panel1.Width / 2, panel1.Height / 2);
                        break;
                    case 2:
                        sb.Color = Color.Aqua;
                        g.DrawString("E", font, sb, panel1.Width / 2 + 20, panel1.Height / 2);
                        break;
                    case 3:
                        sb.Color = Color.DarkSeaGreen;
                        g.DrawString("L", font, sb, panel1.Width / 2 + 40, panel1.Height / 2);
                        break;
                    case 4:
                        sb.Color = Color.BlueViolet;
                        g.DrawString("L", font, sb, panel1.Width / 2 + 60, panel1.Height / 2);
                        break;
                    case 5:
                        sb.Color = Color.Yellow;
                        g.DrawString("O", font, sb, panel1.Width / 2 + 80, panel1.Height / 2);
                        break;
                    case 6:
                        sb.Color = Color.Green;
                        g.DrawString("U", font, sb, panel1.Width / 2, panel1.Height / 2 + 30);
                        break;
                    case 7:
                        sb.Color = Color.Coral;
                        g.DrawString("S", font, sb, panel1.Width / 2 + 20, panel1.Height / 2 + 30);
                        break;
                    case 8:
                        sb.Color = Color.Brown;
                        g.DrawString("E", font, sb, panel1.Width / 2 + 40, panel1.Height / 2 + 30);
                        break;
                    case 9:
                        sb.Color = Color.DeepPink;
                        g.DrawString("R", font, sb, panel1.Width / 2 + 60, panel1.Height / 2 + 30);
                        break;
                    case 10:
                        sb.Color = Color.DeepSkyBlue;
                        g.DrawString("!", font, sb, panel1.Width / 2 + 80, panel1.Height / 2 + 30);
                        timer1.Enabled = false;
                        break;
                }
            }
            else
            {//dimiourgia etimou sxediou : unipi
                switch (count)
                {
                    case 1:
                        sb.Color = Color.DarkRed;
                        g.DrawString("U", font, sb, panel1.Width / 2, panel1.Height / 2);
                        break;
                    case 2:
                        sb.Color = Color.Crimson;
                        g.DrawString("N", font, sb, panel1.Width / 2 + 20, panel1.Height / 2);
                        break;
                    case 3:
                        sb.Color = Color.Red;
                        g.DrawString("I", font, sb, panel1.Width / 2 + 40, panel1.Height / 2);
                        break;
                    case 4:
                        sb.Color = Color.OrangeRed;
                        g.DrawString("P", font, sb, panel1.Width / 2 + 50, panel1.Height / 2);
                        break;
                    case 5:
                        sb.Color = Color.LightCoral;
                        g.DrawString("I", font, sb, panel1.Width / 2 + 70, panel1.Height / 2);
                        break;
                }
            }
            if (!timer1.Enabled)
            {
                p.Width = hScrollBar1.Value;
            }
        }     
        //Delete
        private void everythingToolStripMenuItem_Click(object sender, EventArgs e)
        {//diagrafi oti exoume zwgrafisi sto panel
            panel1.Invalidate();
        }
    }
}
