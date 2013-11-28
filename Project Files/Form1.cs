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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Translation", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Type", 100, HorizontalAlignment.Left);
            engfrom.Checked = true;
            arabicto.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.Columns.Add("Translation", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Type", 100, HorizontalAlignment.Left);
            int detect = 0;
            if (textBox1.Text=="")
            {
                label4.Text = "No Word Entered For Translation";
                ListViewItem i = new ListViewItem("No Word Entered");
                i.SubItems.Add("No Type");
                listView1.Items.Add(i);

            }

            else if (engfrom.Checked && arabicto.Checked)
            {
                OleDbConnection db = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|\\AccessFile.mdb ");
                OleDbCommand aCommand = new OleDbCommand("select English, Arabic, French, Nature from Dictionary", db);
                db.Open();
                string val = textBox1.Text;  //word to translate
                //create the datareader object to connect to table
                OleDbDataReader aReader = aCommand.ExecuteReader();

                // Now iterate through the database
                while (aReader.Read())
                {
                    if (val == aReader.GetString(0))   //the English word
                    {
                        detect = 1;
                        string str = aReader.GetString(1);
                        string nat = aReader.GetString(3);
                        //get the Arabic translation
                       ListViewItem i = new ListViewItem(str);
                       i.SubItems.Add(nat);
                       listView1.Items.Add(i);
                        
                    }
                }
                if (detect == 0)
                {
                    DialogResult result = MessageBox.Show("Word Not Found. Would You Like to Add this Word to the Dictionary?", "Edit Dictionary", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Form formdata;
                        formdata = new Form2();
                        formdata.Show();

                    }
                }

            }


            else if (engfrom.Checked && frenchto.Checked)
            {
                OleDbConnection db = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|\\AccessFile.mdb ");
                OleDbCommand aCommand = new OleDbCommand("select English, Arabic, French, Nature from Dictionary", db);
                db.Open();
                string val = textBox1.Text;  //word to translate
                //create the datareader object to connect to table
                OleDbDataReader aReader = aCommand.ExecuteReader();

                // Now iterate through the database
                while (aReader.Read())
                {
                    if (val == aReader.GetString(0))   //the English word
                    {
                        detect = 1;
                        string str = aReader.GetString(2);
                        string nat = aReader.GetString(3);
                     
                        ListViewItem i = new ListViewItem(str);
                        i.SubItems.Add(nat);
                        listView1.Items.Add(i);

                    }
                }
                if (detect == 0)
                {
                    DialogResult result = MessageBox.Show("Word Not Found. Would You Like to Add this Word to the Dictionary?", "Edit Dictionary", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Form formdata;
                        formdata = new Form2();
                        formdata.Show();

                    }
                }


            }

            else if (arabfrom.Checked && engto.Checked)
            {
                OleDbConnection db = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|\\AccessFile.mdb ");
                OleDbCommand aCommand = new OleDbCommand("select English, Arabic, French, Nature from Dictionary", db);
                db.Open();
                string val = textBox1.Text;  //word to translate
                //create the datareader object to connect to table
                OleDbDataReader aReader = aCommand.ExecuteReader();

                // Now iterate through the database
                while (aReader.Read())
                {
                    if (val == aReader.GetString(1))   //the English word
                    {
                        detect = 1;
                        string str = aReader.GetString(0);
                        string nat = aReader.GetString(3);
                     
                        ListViewItem i = new ListViewItem(str);
                        i.SubItems.Add(nat);
                        listView1.Items.Add(i);

                    }
                }
                if (detect == 0)
                {
                    DialogResult result = MessageBox.Show("Word Not Found. Would You Like to Add this Word to the Dictionary?", "Edit Dictionary", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Form formdata;
                        formdata = new Form2();
                        formdata.Show();

                    }
                }

            }

            else if (arabfrom.Checked && frenchto.Checked)
            {
                OleDbConnection db = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|\\AccessFile.mdb ");
                OleDbCommand aCommand = new OleDbCommand("select English, Arabic, French, Nature from Dictionary", db);
                db.Open();
                string val = textBox1.Text;  //word to translate
                //create the datareader object to connect to table
                OleDbDataReader aReader = aCommand.ExecuteReader();

                // Now iterate through the database
                while (aReader.Read())
                {
                    if (val == aReader.GetString(1))   //the English word
                    {
                        detect = 1;
                        string str = aReader.GetString(2);
                        string nat = aReader.GetString(3);

                        ListViewItem i = new ListViewItem(str);
                        i.SubItems.Add(nat);
                        listView1.Items.Add(i);

                    }
                }
                if (detect == 0)
                {
                    DialogResult result = MessageBox.Show("Word Not Found. Would You Like to Add this Word to the Dictionary?", "Edit Dictionary", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Form formdata;
                        formdata = new Form2();
                        formdata.Show();

                    }
                }

            }

            else if (frenchfrom.Checked && engto.Checked)
            {
                OleDbConnection db = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|\\AccessFile.mdb ");
                OleDbCommand aCommand = new OleDbCommand("select English, Arabic, French, Nature from Dictionary", db);
                db.Open();
                string val = textBox1.Text;  //word to translate
                //create the datareader object to connect to table
                OleDbDataReader aReader = aCommand.ExecuteReader();

                // Now iterate through the database
                while (aReader.Read())
                {
                    if (val == aReader.GetString(2))   //the English word
                    {
                        detect = 1;
                        string str = aReader.GetString(0);
                        string nat = aReader.GetString(3);

                        ListViewItem i = new ListViewItem(str);
                        i.SubItems.Add(nat);
                        listView1.Items.Add(i);

                    }
                }
                if (detect == 0)
                {
                    DialogResult result = MessageBox.Show("Word Not Found. Would You Like to Add this Word to the Dictionary?", "Edit Dictionary", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Form formdata;
                        formdata = new Form2();
                        formdata.Show();

                    }
                }

            }



            else
            {
                OleDbConnection db = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|\\AccessFile.mdb ");
                OleDbCommand aCommand = new OleDbCommand("select English, Arabic, French, Nature from Dictionary", db);
                db.Open();
                string val = textBox1.Text;  //word to translate
                //create the datareader object to connect to table
                OleDbDataReader aReader = aCommand.ExecuteReader();

                // Now iterate through the database
                while (aReader.Read())
                {
                    if (val == aReader.GetString(2))   //the English word
                    {
                        detect = 1;
                        string str = aReader.GetString(1);
                        string nat = aReader.GetString(3);

                        ListViewItem i = new ListViewItem(str);
                        i.SubItems.Add(nat);
                        listView1.Items.Add(i);

                    }
                }
                if (detect == 0)
                {
                    DialogResult result = MessageBox.Show("Word Not Found. Would You Like to Add this Word to the Dictionary?", "Edit Dictionary", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Form formdata;
                        formdata = new Form2();
                        formdata.Show();

                    }
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void quitbutt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void engfrom_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void engfrom_CheckedChanged_1(object sender, EventArgs e)
        {
            if (engfrom.Checked && engto.Checked)
            {
                engto.Checked = false;
                arabicto.Checked = true;
            }
        }

        private void arabfrom_CheckedChanged(object sender, EventArgs e)
        {
            if (arabfrom.Checked && arabicto.Checked)
            {
                arabicto.Checked = false;
                engto.Checked = true;
            }

        }

        private void frenchfrom_CheckedChanged(object sender, EventArgs e)
        {
            if (frenchfrom.Checked && frenchto.Checked)
            {
                frenchto.Checked = false;
                engto.Checked = true;
            }


        }

        private void engto_CheckedChanged(object sender, EventArgs e)
        {
            if (engto.Checked && engfrom.Checked)
            {
                engfrom.Checked = false;
                arabfrom.Checked = true;
            }

        }

        private void arabicto_CheckedChanged(object sender, EventArgs e)
        {
            if (arabicto.Checked && arabfrom.Checked)
            {
                arabfrom.Checked = false;
                engfrom.Checked = true;
            }
        }

        private void frenchto_CheckedChanged(object sender, EventArgs e)
        {
            if (frenchto.Checked && frenchfrom.Checked)
            {
                frenchfrom.Checked = false;
                engfrom.Checked = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                button1_Click(button1, e);
            }
        }

       
    }
} 