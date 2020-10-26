using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Cooperation
{
    public partial class login : Form
    {
        static FileStream F;
        static StreamReader R;
        //int ctr;
        //string password = "";

        public login()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            string line;
            string username = txtusername.Text;
            string userpassword = txtpw.Text;
            string password = "";

            if (ValidateData() == 0)
            {
                errorProvider1.Clear();
                F = new FileStream("dataemployee.txt", FileMode.Open, FileAccess.Read);
                R = new StreamReader(F);
                while ((line = R.ReadLine()) != null)
                {
                    char[] delimiter = new char[] { ';' };
                    string[] contents = line.Split(delimiter);

                    if (line.Contains(username))
                    {
                        for (int i = 0; i < contents.Length; i++)
                        {
                            if (contents[i] == username)
                            {
                                password = contents[i + 1];

                            }
                        }

                    }
                }
                R.Close();
                F.Close();
                if (userpassword == password)
                {
                    configureitems a = new configureitems();
                    a.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("username and password not match!");
                    txtusername.Clear();
                    txtpw.Clear();
                }
            }
            else
            {
                MessageBox.Show(" Data Belum semua di isi!");
            }
        }
        private int ValidateData()
        {
            int flag = 0;
            if (txtusername.Text == "")
            {
                txtusername.Focus();
                errorProvider1.SetError(txtusername, "Please Fill In Username");
                flag = 1;
            }
            if (txtpw.Text == "")
            {
                txtpw.Focus();
                errorProvider1.SetError(txtpw, "Please Fill In Password");
                flag = 1;
            }
            return flag;
        }

        private void txtpw_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Enter_Click(this, new EventArgs());
        }

        private void txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Enter_Click(this, new EventArgs());
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            mainmenu g = new mainmenu();
            g.Show();
            this.Close();
        }
        
    }
}
