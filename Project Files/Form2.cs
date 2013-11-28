using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsApplication4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void submitbut_Click(object sender, EventArgs e)
        {
            if ((engbox.Text == "") || (arabbox.Text == "") || (frenchbox.Text == "")||(naturebox.Text==""))
            {
                MessageBox.Show("One or more fields are empty. Please make sure all text fields are full.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                OleDbConnection db = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\AccessFile.mdb ");
                OleDbCommand aCommand = new OleDbCommand("select English, Arabic, French, Nature from Dictionary", db);

                OleDbCommand cmd = new OleDbCommand();

                cmd.CommandText = "insert into Dictionary(English, Arabic, French, Nature) values('" + this.engbox.Text + "','" + this.arabbox.Text + "','" + this.frenchbox.Text + "','" + this.naturebox.Text + "');";


                cmd.Connection = db;
                db.Open();
                int temp = cmd.ExecuteNonQuery();
                if (temp > 0)
                {
                    MessageBox.Show("Record Successfully Added","Success",MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Record Failed to Add", "Error",MessageBoxButtons.OK);
                }
                db.Close();

            }
        }
    }
}