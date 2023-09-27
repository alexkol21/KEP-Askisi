namespace KEP
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txttype = new System.Windows.Forms.TextBox();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.typetxt = new System.Windows.Forms.Label();
            this.addtxt = new System.Windows.Forms.Label();
            this.phonetxt = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.searchbtn = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.exitbtn = new System.Windows.Forms.Button();
            this.viewdatabtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 90);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KEP.Properties.Resources.keppp;
            this.pictureBox2.Location = new System.Drawing.Point(880, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(330, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KEP.Properties.Resources.keppp;
            this.pictureBox1.Location = new System.Drawing.Point(25, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(471, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Αιτησεις ΚΕΠ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txttype);
            this.panel2.Controls.Add(this.txtadd);
            this.panel2.Controls.Add(this.txtphone);
            this.panel2.Controls.Add(this.txtemail);
            this.panel2.Controls.Add(this.typetxt);
            this.panel2.Controls.Add(this.addtxt);
            this.panel2.Controls.Add(this.phonetxt);
            this.panel2.Controls.Add(this.emailtxt);
            this.panel2.Controls.Add(this.txtname);
            this.panel2.Controls.Add(this.nametxt);
            this.panel2.Location = new System.Drawing.Point(2, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 448);
            this.panel2.TabIndex = 1;
            // 
            // txttype
            // 
            this.txttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttype.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txttype.Location = new System.Drawing.Point(8, 387);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(501, 40);
            this.txttype.TabIndex = 10;
            this.txttype.Text = "π.χ Βεβαιωση/Πιστοποιητικο";
            this.txttype.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txttype_MouseClick);
            // 
            // txtadd
            // 
            this.txtadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadd.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtadd.Location = new System.Drawing.Point(8, 299);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(501, 40);
            this.txtadd.TabIndex = 9;
            this.txtadd.Text = "π.χ Κολοκοτρωνη 5,Μελισσια";
            this.txtadd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtadd_MouseClick);
            // 
            // txtphone
            // 
            this.txtphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtphone.Location = new System.Drawing.Point(8, 212);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(501, 40);
            this.txtphone.TabIndex = 8;
            this.txtphone.Text = "π.χ 6977121344";
            this.txtphone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtphone_MouseClick);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtemail.Location = new System.Drawing.Point(8, 136);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(501, 40);
            this.txtemail.TabIndex = 7;
            this.txtemail.Text = "π.χ example@gmail.com";
            this.txtemail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtemail_MouseClick);
            // 
            // typetxt
            // 
            this.typetxt.AutoSize = true;
            this.typetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typetxt.Location = new System.Drawing.Point(8, 351);
            this.typetxt.Name = "typetxt";
            this.typetxt.Size = new System.Drawing.Size(266, 33);
            this.typetxt.TabIndex = 6;
            this.typetxt.Text = "Τυπος Αιτηματος:";
            // 
            // addtxt
            // 
            this.addtxt.AutoSize = true;
            this.addtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtxt.Location = new System.Drawing.Point(8, 263);
            this.addtxt.Name = "addtxt";
            this.addtxt.Size = new System.Drawing.Size(318, 33);
            this.addtxt.TabIndex = 5;
            this.addtxt.Text = "Διευθυνση Κατοικιας:";
            // 
            // phonetxt
            // 
            this.phonetxt.AutoSize = true;
            this.phonetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonetxt.Location = new System.Drawing.Point(8, 176);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(306, 33);
            this.phonetxt.TabIndex = 4;
            this.phonetxt.Text = "Αριθμος Τηλεφωνου:";
            // 
            // emailtxt
            // 
            this.emailtxt.AutoSize = true;
            this.emailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxt.Location = new System.Drawing.Point(8, 100);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(103, 33);
            this.emailtxt.TabIndex = 3;
            this.emailtxt.Text = "Email:";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtname.Location = new System.Drawing.Point(8, 57);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(501, 40);
            this.txtname.TabIndex = 2;
            this.txtname.Text = "π.χ Αλεξανδρος Κολλιας";
            this.txtname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtname_MouseClick);
            // 
            // nametxt
            // 
            this.nametxt.AutoSize = true;
            this.nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(8, 11);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(253, 33);
            this.nametxt.TabIndex = 1;
            this.nametxt.Text = "Ονοματεπωνυμο:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.searchbtn);
            this.panel3.Controls.Add(this.txtsearch);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(549, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(680, 448);
            this.panel3.TabIndex = 2;
            // 
            // searchbtn
            // 
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(357, 8);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(171, 40);
            this.searchbtn.TabIndex = 6;
            this.searchbtn.Text = "Αναζητηση";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtsearch.Location = new System.Drawing.Point(3, 8);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(348, 40);
            this.txtsearch.TabIndex = 3;
            this.txtsearch.Text = "Search";
            this.txtsearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtsearch_MouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(670, 384);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.exitbtn);
            this.panel4.Controls.Add(this.viewdatabtn);
            this.panel4.Controls.Add(this.clearbtn);
            this.panel4.Controls.Add(this.deletebtn);
            this.panel4.Controls.Add(this.btnupdate);
            this.panel4.Controls.Add(this.savebtn);
            this.panel4.Location = new System.Drawing.Point(2, 578);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1238, 90);
            this.panel4.TabIndex = 1;
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Red;
            this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(1054, 9);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(171, 71);
            this.exitbtn.TabIndex = 5;
            this.exitbtn.Text = "Εξοδος";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // viewdatabtn
            // 
            this.viewdatabtn.BackColor = System.Drawing.Color.DeepPink;
            this.viewdatabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewdatabtn.Location = new System.Drawing.Point(716, 12);
            this.viewdatabtn.Name = "viewdatabtn";
            this.viewdatabtn.Size = new System.Drawing.Size(171, 71);
            this.viewdatabtn.TabIndex = 4;
            this.viewdatabtn.Text = "Εμφανιση Δεδομενων";
            this.viewdatabtn.UseVisualStyleBackColor = false;
            this.viewdatabtn.Click += new System.EventHandler(this.viewdatabtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.MediumOrchid;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.Location = new System.Drawing.Point(539, 12);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(171, 71);
            this.clearbtn.TabIndex = 3;
            this.clearbtn.Text = "Καθαρισμος";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deletebtn.Location = new System.Drawing.Point(362, 12);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(171, 71);
            this.deletebtn.TabIndex = 2;
            this.deletebtn.Text = "Διαγραφη";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(185, 12);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(171, 71);
            this.btnupdate.TabIndex = 1;
            this.btnupdate.Text = "Ενημερωση";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.Chartreuse;
            this.savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.Location = new System.Drawing.Point(8, 12);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(171, 71);
            this.savebtn.TabIndex = 0;
            this.savebtn.Text = "Αποθηκευση";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1241, 678);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KEP Applications";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label nametxt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button savebtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label typetxt;
        private System.Windows.Forms.Label addtxt;
        private System.Windows.Forms.Label phonetxt;
        private System.Windows.Forms.Label emailtxt;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button viewdatabtn;
    }
}

