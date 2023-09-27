using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KEP
{
    
    
    public partial class Form1 : Form
    {
        
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\KepDatabase.accdb");

        int checks = 0;
        Bitmap bitmap;
        
        public Form1()
        {
            InitializeComponent();
            viewer();
        }

        void viewer()
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from KepDatabase";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Βαση Δεδομενων ΚΕΠ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            DialogResult iQuit;

            iQuit = MessageBox.Show("Επιβεβαιωστε οτι θελετε να αποχωρησετε", "απο την βαση δεδομεων των αιτηματων", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iQuit == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Οπως επιθυμειτε");
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtemail.Clear();
            txtphone.Clear();
            txttype.Clear();
            txtadd.Clear();
            txtsearch.Text = "Search";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into KepDatabase(Ονοματεπωνυμο,email,τηλεφωνο,Διευθυνση,[Ειδος πιστοποιητικου])" +
                 "values(' " + txtname.Text + "', ' " + txtemail.Text + "', ' " + txtphone.Text + "', ' " + txtadd.Text + "', ' " + txttype.Text + "' )";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Αποθηκευτηκε", "Βαση Δεδομενων ΚΕΠ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                viewer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Βαση Δεδομενων ΚΕΠ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update KepDatabase set Ονοματεπωνυμο = ' " + txtname.Text.Trim() + "' where email =  ' " + txtemail.Text.Trim() + "' and Διευθυνση =  ' " + txtadd.Text.Trim()  + "'";
                cmd.CommandText = "update KepDatabase set Τηλεφωνο = ' "+ txtphone.Text.Trim() + "' where email = ' " + txtemail.Text.Trim() + " ' and Διευθυνση = ' " + txtadd.Text.Trim() + "'";
                cmd.CommandText = "update KepDatabase set email  = ' " + txtemail.Text.Trim() + "' where Τηλεφωνο = ' " + txtphone.Text.Trim() + " ' and Διευθυνση = ' " + txtadd.Text.Trim() + "'";
                cmd.CommandText = "update KepDatabase set Διευθυνση = ' " + txtadd.Text.Trim() + "' where email = ' " + txtemail.Text.Trim() + " ' and Ονοματεπωνυμο = ' " + txtname.Text.Trim() + "'";

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Ενημερωθηκε", "Βαση Δεδομενων ΚΕΠ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                viewer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Βαση Δεδομενων ΚΕΠ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txtname.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtemail.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtphone.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtadd.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txttype.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Βαση Δεδομενων ΚΕΠ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete * from KepDatabase where Ονοματεπωνυμο = ' " +txtname.Text.Trim() +  "'";

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Διαγραφηκε", "Βαση Δεδομενων ΚΕΠ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                viewer();   
                txtname.Clear();
                txtemail.Clear();
                txtphone.Clear();
                txttype.Clear();
                txtadd.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Βαση Δεδομενων ΚΕΠ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewdatabtn_Click(object sender, EventArgs e)
        {
           viewer();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from KepDatabase where Ονοματεπωνυμο = '" + txtsearch.Text.Trim() + "'or email =' "+txtsearch.Text.Trim() + "' or Τηλεφωνο = ' "+txtsearch.Text.Trim()+ "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                checks = Convert.ToInt32(dt.Rows.Count.ToString()); 
                dataGridView1.DataSource = dt;
                conn.Close();

                if (checks == 0)
                {
                    txtsearch.Text = "";
                    MessageBox.Show("Δεν βρεθηκε", "Βαση Δεδομενων ΚΕΠ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Βαση Δεδομενων ΚΕΠ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtsearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtsearch.Text = " ";
            txtsearch.ForeColor = Color.Black;
        }

        private void txtname_MouseClick(object sender, MouseEventArgs e)
        {
            txtname.Text = " ";
            txtname.ForeColor = Color.Black;
        }

        private void txtemail_MouseClick(object sender, MouseEventArgs e)
        {
            txtemail.Text = " ";
            txtemail.ForeColor = Color.Black;
        }

        private void txtphone_MouseClick(object sender, MouseEventArgs e)
        {
            txtphone.Text = " ";
            txtphone.ForeColor = Color.Black;
        }

        private void txtadd_MouseClick(object sender, MouseEventArgs e)
        {
            txtadd.Text = " ";
            txtadd.ForeColor = Color.Black;
        }

        private void txttype_MouseClick(object sender, MouseEventArgs e)
        {
            txttype.Text = " ";
            txttype.ForeColor = Color.Black;
        }
    }
}
