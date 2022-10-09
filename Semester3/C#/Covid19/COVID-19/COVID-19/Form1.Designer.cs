namespace COVID_19
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.insertPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertAPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAPatientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editAPatientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllPatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsPerAgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuberOfPatientsPerGenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.percentageOfPatientsPerAgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.percentageOfPatientsPerGenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertPatientToolStripMenuItem,
            this.viewAllPatientsToolStripMenuItem,
            this.deleteAPatientToolStripMenuItem,
            this.statisticsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // insertPatientToolStripMenuItem
            // 
            this.insertPatientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertAPatientToolStripMenuItem,
            this.deleteAPatientToolStripMenuItem1,
            this.editAPatientToolStripMenuItem1});
            this.insertPatientToolStripMenuItem.Name = "insertPatientToolStripMenuItem";
            this.insertPatientToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.insertPatientToolStripMenuItem.Text = "Patients";
            // 
            // insertAPatientToolStripMenuItem
            // 
            this.insertAPatientToolStripMenuItem.Name = "insertAPatientToolStripMenuItem";
            this.insertAPatientToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.insertAPatientToolStripMenuItem.Text = "Insert a patient ";
            this.insertAPatientToolStripMenuItem.Click += new System.EventHandler(this.insertAPatientToolStripMenuItem_Click);
            // 
            // deleteAPatientToolStripMenuItem1
            // 
            this.deleteAPatientToolStripMenuItem1.Name = "deleteAPatientToolStripMenuItem1";
            this.deleteAPatientToolStripMenuItem1.Size = new System.Drawing.Size(199, 26);
            this.deleteAPatientToolStripMenuItem1.Text = "Delete a patient";
            this.deleteAPatientToolStripMenuItem1.Click += new System.EventHandler(this.deleteAPatientToolStripMenuItem1_Click);
            // 
            // editAPatientToolStripMenuItem1
            // 
            this.editAPatientToolStripMenuItem1.Name = "editAPatientToolStripMenuItem1";
            this.editAPatientToolStripMenuItem1.Size = new System.Drawing.Size(199, 26);
            this.editAPatientToolStripMenuItem1.Text = "Edit a patient";
            this.editAPatientToolStripMenuItem1.Click += new System.EventHandler(this.editAPatientToolStripMenuItem1_Click);
            // 
            // viewAllPatientsToolStripMenuItem
            // 
            this.viewAllPatientsToolStripMenuItem.Name = "viewAllPatientsToolStripMenuItem";
            this.viewAllPatientsToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.viewAllPatientsToolStripMenuItem.Text = "View all patients";
            this.viewAllPatientsToolStripMenuItem.Click += new System.EventHandler(this.viewAllPatientsToolStripMenuItem_Click);
            // 
            // deleteAPatientToolStripMenuItem
            // 
            this.deleteAPatientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.emailToolStripMenuItem});
            this.deleteAPatientToolStripMenuItem.Name = "deleteAPatientToolStripMenuItem";
            this.deleteAPatientToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.deleteAPatientToolStripMenuItem.Text = "Search a patient by:";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.nameToolStripMenuItem.Text = "Name and phone";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.emailToolStripMenuItem.Text = "Name and email";
            this.emailToolStripMenuItem.Click += new System.EventHandler(this.emailToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientsPerAgeToolStripMenuItem,
            this.nuberOfPatientsPerGenderToolStripMenuItem,
            this.percentageOfPatientsPerAgeToolStripMenuItem,
            this.percentageOfPatientsPerGenderToolStripMenuItem});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // patientsPerAgeToolStripMenuItem
            // 
            this.patientsPerAgeToolStripMenuItem.Name = "patientsPerAgeToolStripMenuItem";
            this.patientsPerAgeToolStripMenuItem.Size = new System.Drawing.Size(317, 26);
            this.patientsPerAgeToolStripMenuItem.Text = "Number of patients per age";
            this.patientsPerAgeToolStripMenuItem.Click += new System.EventHandler(this.patientsPerAgeToolStripMenuItem_Click);
            // 
            // nuberOfPatientsPerGenderToolStripMenuItem
            // 
            this.nuberOfPatientsPerGenderToolStripMenuItem.Name = "nuberOfPatientsPerGenderToolStripMenuItem";
            this.nuberOfPatientsPerGenderToolStripMenuItem.Size = new System.Drawing.Size(317, 26);
            this.nuberOfPatientsPerGenderToolStripMenuItem.Text = "Nuber of patients per gender";
            this.nuberOfPatientsPerGenderToolStripMenuItem.Click += new System.EventHandler(this.nuberOfPatientsPerGenderToolStripMenuItem_Click);
            // 
            // percentageOfPatientsPerAgeToolStripMenuItem
            // 
            this.percentageOfPatientsPerAgeToolStripMenuItem.Name = "percentageOfPatientsPerAgeToolStripMenuItem";
            this.percentageOfPatientsPerAgeToolStripMenuItem.Size = new System.Drawing.Size(317, 26);
            this.percentageOfPatientsPerAgeToolStripMenuItem.Text = "Percentage of patients per age";
            this.percentageOfPatientsPerAgeToolStripMenuItem.Click += new System.EventHandler(this.percentageOfPatientsPerAgeToolStripMenuItem_Click);
            // 
            // percentageOfPatientsPerGenderToolStripMenuItem
            // 
            this.percentageOfPatientsPerGenderToolStripMenuItem.Name = "percentageOfPatientsPerGenderToolStripMenuItem";
            this.percentageOfPatientsPerGenderToolStripMenuItem.Size = new System.Drawing.Size(317, 26);
            this.percentageOfPatientsPerGenderToolStripMenuItem.Text = "Percentage of patients per gender";
            this.percentageOfPatientsPerGenderToolStripMenuItem.Click += new System.EventHandler(this.percentageOfPatientsPerGenderToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Location = new System.Drawing.Point(31, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox2.Location = new System.Drawing.Point(31, 229);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(27, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.Location = new System.Drawing.Point(31, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Location = new System.Drawing.Point(443, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(344, 370);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(27, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button2.Location = new System.Drawing.Point(31, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(31, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox3.Location = new System.Drawing.Point(303, 229);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 10;
            this.textBox3.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button3.Location = new System.Drawing.Point(303, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 32);
            this.button3.TabIndex = 11;
            this.button3.Text = "Click here";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 432);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Covid-19";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem insertPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertAPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAPatientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewAllPatientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAPatientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsPerAgeToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem nuberOfPatientsPerGenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem percentageOfPatientsPerAgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem percentageOfPatientsPerGenderToolStripMenuItem;
    }
}

