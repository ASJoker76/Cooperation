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
    public partial class Home : Form
    {
        static FileStream F;
        static StreamReader R;
        //int ctr;
        

        public Home()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            string line;
            Cglobal.username = txtusername.Text;
            string userpassword = txtpw.Text;
            string password = "";
            //username = "";
            //password = "";



            if (ValidateData() == 0)
            {
                errorProvider1.Clear();
                F = new FileStream("dataemployee.txt", FileMode.Open, FileAccess.Read);
                R = new StreamReader(F);
                while ((line = R.ReadLine()) != null)
                {
                    char[] delimiter = new char[] { ';' };
                    string[] contents = line.Split(delimiter);

                    if (line.Contains(Cglobal.username))
                    {
                        for (int i = 0; i < contents.Length; i++)
                        {
                            if (contents[i] == Cglobal.username)
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
                    mainmenu a = new mainmenu(); 
                    a.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("username and password not match!");
                    
                    
                       
                            MessageBox.Show("Anda udah gagal 3x");
                       
                                            
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

        private void btnregister_Click(object sender, EventArgs e)
        {
            registration z = new registration();
            z.Show();
            this.Hide();
        }

        private void txtpw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                enter_Click(this, new EventArgs());
        }

        private void txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                enter_Click(this, new EventArgs());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cvExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(5);
        }
    }
}
