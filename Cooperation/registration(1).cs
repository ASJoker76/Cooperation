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
    public partial class registration : Form
    {
        static FileStream F;
        static StreamWriter W;
        static StreamReader R;

        static string gender = "";

        public registration()
        {
            InitializeComponent();
        }

        private int ValidateData()
        {
            int flag = 0;
            if (txtname.Text == "")
            {
                txtname.Focus();
                errorProvider.SetError(txtname, "Please Fill In The First Name");
                flag = 1;
            }
            /*if (txtlastname.Text == "")
            {
                txtlastname.Focus();
                errorProvider1.SetError(txtlastname, "Please Fill in The Last Name");
                flag = 1;
            }*/
            int n;
            bool isnumeric = int.TryParse(txtage.Text, out n);
            if (isnumeric == false)
            {
                txtage.Focus();
                errorProvider.SetError(txtage, "Please Fill In age");
                flag = 1;
            }
            if (txtlasteducation.Text == "")
            {
                txtlasteducation.Focus();
                errorProvider.SetError(txtlasteducation, "Please Choose one Last Education");
                flag = 1;
            }
            if (gender == "")
            {
                grgender.Focus();
                errorProvider.SetError(grgender, "Please Chose one Gender");
                flag = 1;
            }
            if (txtaddress.Text == "")
            {
                txtaddress.Focus();
                errorProvider.SetError(txtaddress, "Please Fill In The Address");
                flag = 1;
            }
            if (txtbirtofday.Value > DateTime.Now)
            {
                txtbirtofday.Focus();
                errorProvider.SetError(txtbirtofday, "Please Fill The Correct Date of Birth");
                flag = 1;
            }
            if (txtusername.Text == "")
            {
                txtusername.Focus();
                errorProvider.SetError(txtusername, "Please Write Username");
                flag = 1;
            }
            if (txtpw.Text.Length < 6)
            {
                txtpw.Focus();
                errorProvider.SetError(txtpw, "Please Write Password Min 6 Character");
                flag = 1;
            }
            if (txtemail.Text == "")
            {
                txtemail.Focus();
            }
            if (txtdotcom.Text == "")
            {
                txtdotcom.Focus();
                errorProvider.SetError(txtdotcom, "Please Write Email");
                flag = 1;
            }
            return flag;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainmenu g = new mainmenu();
            g.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtlastname.Clear();
            txtaddress.Clear();
            txtusername.Clear();
            txtpw.Clear();
            txtpath.Clear();
            txtemail.Clear();
        }

        private void txtname_Validating(object sender, CancelEventArgs e)
        {
            int n;
            bool isnumeric = int.TryParse(txtname.Text, out n);

            if (!txtname.Text.All(char.IsLetter))
            {
                lberrorname.Visible = true;
                lberrorname.Text = "Cannot be character";

            }
            else
            {
                lberrorname.Visible = false;
            }
        }
        private void txtlastname_Validating(object sender, CancelEventArgs e)
        {
            int n;
            bool isnumeric = int.TryParse(txtlastname.Text, out n);

            if (!txtlastname.Text.All(char.IsLetter))
            {
                lberrorls.Visible = true;
                lberrorls.Text = "Cannot be character";

            }
            else
            {
                lberrorls.Visible = false;
            }
        }

        private void txtlasteducation_Validating(object sender, CancelEventArgs e)
        {
            if (txtlasteducation.Text == "")
            {
                lberrorlast.Visible = true;
            }
            else
            {
                lberrorlast.Visible = false;
            }
        }

        private void txtage_Validating(object sender, CancelEventArgs e)
        {
            int n;
            bool isnumeric = int.TryParse(txtage.Text, out n);

            if (isnumeric == false)
            {
                lbage.Visible = true;

            }
            else
            {
                lbage.Visible = false;
            }
            if (!txtage.Text.All(char.IsDigit))
            {
                lbage.Visible = true;
                lbage.Text = "Cannot be character";

            }
        }

        private void txtdatetime_Validating(object sender, CancelEventArgs e)
        {
            if (txtbirtofday.Value >= DateTime.Now)
            {
                txtbirtofday.Focus();
                lberrorbirt.Visible = true;
            }
            else
            {
                lberrorbirt.Visible = false;
            }
        }

        private void txtaddress_Validating(object sender, CancelEventArgs e)
        {
            if (txtaddress.Text == "")
            {
                lberroraddress.Visible = true;
            }
            else
            {
                lberroraddress.Visible = false;
            }
        }

        private void btnchoise_Click(object sender, EventArgs e)
        {
            ofdimage.Filter = "Image Files(*(.jpg,*.png,*.bmp)|*.jpg;*.png;*.bmp";
            if (ofdimage.ShowDialog() == DialogResult.OK)
            {
                pbfoto.Image = new Bitmap(ofdimage.FileName);
                txtpath.Text = ofdimage.FileName;
                pbfoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string nama, lastname, age, address, lasteducation, birtofdate, username, password, email, dotcom,path;

            nama = txtname.Text;
            lastname = txtlastname.Text;
            age = txtage.Text;
            address = txtaddress.Text;
            lasteducation = txtlasteducation.Text;
            birtofdate = txtbirtofday.Text;

            username = txtusername.Text;
            password = txtpw.Text;
            email = txtemail.Text;

            dotcom = txtdotcom.Text;

            path = txtpath.Text;

            if (rbmale.Checked == true)
                gender = rbmale.Text;
            if (rbfemale.Checked == true)
                gender = rbfemale.Text;

            if (ValidateData() == 0)
            {
                errorProvider.Clear();
                AddItem("dataemployee.txt", nama, lastname, age, address, lasteducation, birtofdate, username, password, email, dotcom,path);

                datacategory.Rows.Clear();
                datacategory.Refresh();
                string[] data = displaydata("dataemployee.txt");
                for (int i = 0; i < data.Length - 1; i = i + 11)
                {
                    datacategory.Rows.Add(data[i], data[i + 1], data[i + 2], data[i + 3], data[i + 4], data[i + 5], data[i + 6]);
                }
            }
            else
            {
                MessageBox.Show(" Data Belum semua di isi!");

            }
        }
        public void AddItem(string FileTxt, string nama, string lastname, string lasteducation, string age, string birtofdate, string address, string username, string password, string email, string dotcom,string path)
        {
            int line = check(FileTxt, nama);

            F = new FileStream("dataemployee.txt", FileMode.Append, FileAccess.Write);
            W = new StreamWriter(F);
            if (line != -1)
            {
                string code = "EP" + (line + 1);
                W.WriteLine(code + ";" +nama + " " + lastname + ";" + lasteducation + ";" + age + ";" + gender + ";" + birtofdate + ";" + address + ";" + username + ";" + password + ";" + email + "@" + dotcom +";"+path);
                MessageBox.Show(" ADD NEW EMPLOYEE SUCSSES ");

            }
            W.Flush();
            W.Close();
        }


        public int check(string FileTxt, string nama)
        {
            F = new FileStream(FileTxt, FileMode.Open, FileAccess.Read);
            R = new StreamReader(F);

            int countLine = 0;
            string line = R.ReadLine();
            try
            {
                while ((line != null))
                {
                    if (!line.Contains(nama))
                    {
                        countLine++;
                        line = R.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("The Name already exist");
                        R.Close();
                        F.Close();
                        return -1;
                    }
                }
                R.Close();
                F.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
            return countLine;


        }

        private void registration_Load(object sender, EventArgs e)
        {
            string[] data = displaydata("dataemployee.txt");
            for (int i = 0; i < data.Length - 1; i = i + 11)
            {
                datacategory.Rows.Add(data[i], data[i + 1], data[i + 2], data[i + 3], data[i + 4], data[i + 5], data[i + 6]);
            }
        }
        public string[] displaydata(string FileTxt)
        {
            F = new FileStream(FileTxt, FileMode.Open, FileAccess.Read);
            R = new StreamReader(F);

            string line;
            line = R.ReadToEnd();
            string[] contents = line.Split(new string[] { "\r\n", "\n", ";", "" }, StringSplitOptions.None);

            R.Close();
            F.Close();

            return contents;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Home l = new Home();
            l.Show();
            this.Hide();
        }

        private void txtage_TextChanged(object sender, EventArgs e)
        {
            if (txtage.Text == "0")
            {
                MessageBox.Show("NOT NULL");
                txtage.Clear();
            }
            if (txtage.Text == "-")
            {
                MessageBox.Show("NOT MINUS");
                txtage.Clear();
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            txtage.Text = vScrollBar1.Value.ToString();
        }
    }
}
