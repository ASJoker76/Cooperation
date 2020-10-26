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
    public partial class additems : Form
    {
        static FileStream F;
        static StreamWriter W;
        static StreamReader R;

        public additems()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            string nameitems, price, stock;

            nameitems = txtnameitems.Text;
            price = txtprice.Text;
            stock = txtstock.Text;

            if (ValidateData() == 0)
            {
                errorProvider1.Clear();
                AddItems("items.txt",nameitems, price, stock);

                dataitem.Rows.Clear();
                dataitem.Refresh();
                string[] data = display("items.txt");
                for (int i = 0; i < data.Length - 1; i = i + 4)
                {
                    dataitem.Rows.Add(data[i], data[i + 1], data[i + 2], data[i + 3]);
                }
            }
            else
            {
                MessageBox.Show(" Data Belum semua di isi!");
            }
        }

        public void AddItems(string FileTxt, string nameitems, string price, string stock)
        {
            int line = check(FileTxt, nameitems);

            F = new FileStream("items.txt", FileMode.Append, FileAccess.Write);
            W = new StreamWriter(F);
            if (line != -1)
            {
                string code = "IT" + (line + 1);
                W.WriteLine(code + ";" +nameitems + ";" + price + ";" + stock);
                MessageBox.Show(" NEW ITEMS SUCSSES ADD ");

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
                        MessageBox.Show("The Name already exist");
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

        private int ValidateData()
        {
            int flag = 0;
            if (txtnameitems.Text == "")
            {
                txtnameitems.Focus();
                errorProvider1.SetError(txtnameitems, "Please Fill In The Name Items");
                flag = 1;
            }
            int n;
            bool isnumeric = int.TryParse(txtprice.Text, out n);
            if (isnumeric == false)
            {
                txtprice.Focus();
                errorProvider1.SetError(txtprice, "Please Fill In The Price Items");
                flag = 1;
            }
            if (isnumeric == false)
            {
                txtstock.Focus();
                errorProvider1.SetError(txtstock, "Please Fill In The Stock Items");
                flag = 1;
            }
            /*if (dateTimePicker1.Value <= DateTime.Now)
            {
                dateTimePicker1.Focus();
                errorProvider1.SetError(dateTimePicker1, "Please Fill The Correct Date of Applying");
                flag = 1;
            }*/
            return flag;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            txtnameitems.Clear();
            txtprice.Clear();
            txtstock.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            configureitems h = new configureitems();
            h.Show();
            this.Hide();
        }

        private void txtnameitems_Validating(object sender, CancelEventArgs e)
        {
            int n;
            bool isnumeric = int.TryParse(txtnameitems.Text, out n);

            if (!txtnameitems.Text.All(char.IsLetter))
            {
                lberrornameitems.Visible = true;
                lberrornameitems.Text = "Cannot be character";

            }
            else
            {
                lberrornameitems.Visible = false;
            }   
        }

  

        private void txtprice_Validating(object sender, CancelEventArgs e)
        {
            int n;
            bool isnumeric = int.TryParse(txtprice.Text, out n);
            if (isnumeric == false)
            {
                lberrorprice.Visible = true;
                
            }
            else
            {
                lberrorprice.Visible = false;
            }
            if (!txtprice.Text.All(char.IsDigit))
            {
                lberrorprice.Visible = true;
                lberrorprice.Text = "Cannot be character";
                
            }
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {
            if (txtprice.Text == "")
            {
                lberrorprice.Visible = true;
                txtprice.Focus();
            }
            if (txtprice.Text == "0")
            {
                MessageBox.Show("NOT NULL");
                txtprice.Clear();
            }
            if (txtprice.Text == "-")
            {
                MessageBox.Show("NOT MINUS");
                txtprice.Clear();
            }
        }

        private void txtstock_Validating(object sender, CancelEventArgs e)
        {
            int n;
            bool isnumeric = int.TryParse(txtstock.Text, out n);

            if (isnumeric == false)
            {
                lberrorstock.Visible = true;

            }
            else
            {
                lberrorstock.Visible = false;
            }
            if (!txtstock.Text.All(char.IsDigit))
            {
                lberrorstock.Visible = true;
                lberrorstock.Text = "Cannot be character";

            }
        }

        private void txtnameitems_TextChanged(object sender, EventArgs e)
        {
            if (txtnameitems.Text == "")
            {
                lberrornameitems.Visible = true;
                txtnameitems.Focus();
            }
        }

        private void txtstock_TextChanged(object sender, EventArgs e)
        {
            if (txtstock.Text == "")
            {
                lberrorstock.Visible = true;
                txtprice.Focus();
            }
            if (txtstock.Text == "0")
            {
                MessageBox.Show("NOT NULL");
                txtstock.Clear();
            }
            if (txtstock.Text == "-")
            {
                MessageBox.Show("NOT MINUS");
                txtstock.Clear();
            }
        }

        private void additems_Load(object sender, EventArgs e)
        {
            string[] data = display("items.txt");
            for (int i = 0; i < data.Length - 1; i = i + 4)
            {
                dataitem.Rows.Add(data[i], data[i+1], data[i+2], data[i+3]);
            }
        }
        public string[] display(string FileTxt)
        {
            F = new FileStream(FileTxt, FileMode.Open, FileAccess.Read);
            R = new StreamReader(F);

            string line;
            line = R.ReadToEnd();
            string[] contents = line.Split(new string[] { ";", "\r\n","\n", "" }, StringSplitOptions.None);

            R.Close();
            F.Close();

            return contents;
        }
    }
}
