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
    public partial class updateemployee : Form
    {
        static FileStream F;
        //static StreamWriter W;
        static StreamReader R;

        int indexRow;
        static string gender = "";

        public updateemployee()
        {
            InitializeComponent();
        }

        private void updateemployee_Load(object sender, EventArgs e)
        {
            string[] data = displaydata("dataemployee.txt");
            for (int i = 0; i < data.Length - 1; i = i + 11)
            {
                datacategory.Rows.Add(data[i], data[i + 1], data[i + 2], data[i + 3], data[i + 4], data[i + 5], data[i + 6]
                    ,data[i+7],data[i+8],data[i+9],data[i+10]);
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


        private void datacategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rbmale.Checked == true)
                gender = rbmale.Text;
            if (rbfemale.Checked == true)
                gender = rbfemale.Text;

            indexRow = e.RowIndex;
            DataGridViewRow dr = datacategory.SelectedRows[0];
            txtcode.Text = dr.Cells[0].Value.ToString();
            txtname.Text = dr.Cells[1].Value.ToString();
            txtage.Text = dr.Cells[2].Value.ToString();
            txtaddress.Text = dr.Cells[3].Value.ToString();
            gender = dr.Cells[4].Value.ToString();
            txtlasteducation.Text = dr.Cells[5].Value.ToString();
            txtbirtofday.Text = dr.Cells[6].Value.ToString();
            txtusername.Text = dr.Cells[7].Value.ToString();
            txtpw.Text = dr.Cells[8].Value.ToString();
            txtemail.Text = dr.Cells[9].Value.ToString();
            txtpath.Text = dr.Cells[10].Value.ToString();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            DialogResult result;

            string code = txtcode.Text;
            string name = txtname.Text;
            string age = txtage.Text;
            string address = txtaddress.Text;
            string jk = gender;
            string dateofbirth = txtbirtofday.Text;
            string lasteducation = txtlasteducation.Text;
            string username = txtusername.Text;
            string password = txtpw.Text;
            string email = txtemail.Text;
            string path = txtpath.Text;


            result = MessageBox.Show("Are you sure you want to update: \n" + "Code: " + code +
                "\nName: " + name + "\nAge" + age +
                "\nAddress: " + address +
                "\nGender: " + jk + "\nLast Education: " + lasteducation +
                "\nUsername: " + username + "\nPassword: " + password + "\nEmail : "+ email + "\nPath : " + path,
                "Insert new data", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                DataGridViewRow newData = datacategory.Rows[indexRow];
                newData.Cells[0].Value = txtcode.Text;
                newData.Cells[1].Value = txtname.Text;
                newData.Cells[2].Value = txtage.Text;
                newData.Cells[3].Value = txtaddress.Text;
                newData.Cells[4].Value = gender;
                newData.Cells[5].Value = txtlasteducation.Text;
                newData.Cells[6].Value = txtbirtofday.Text; 
                newData.Cells[7].Value = txtusername.Text;
                newData.Cells[8].Value = txtpw.Text;
                newData.Cells[9].Value = txtemail.Text;
                newData.Cells[10].Value = txtpath.Text;

                string sLine = "";
                datacategory.Refresh();
                int count = datacategory.Rows.Count;
                File.WriteAllText("dataemployee.txt", String.Empty);
                
                for (int r = 0; r < count; r++)
                {
                    int colCount = datacategory.Rows[r].Cells.Count;
                    for (int c = 0; c < colCount; c++)
                    {
                        sLine = sLine + datacategory.Rows[r].Cells[c].Value;
                        if (c != datacategory.Columns.Count - 1)
                        {
                            sLine = sLine + ";";
                        }
                    }
                    sLine += "\r\n";
                    
                }
                Updateemployee("dataemployee.txt", sLine);


                MessageBox.Show("Your data successfully update! :)");
            }
        }
        public void Updateemployee(string FileTxt, string data)
        {
            FileStream fs = new FileStream(FileTxt, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.Write(data);

            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            mainmenu t = new mainmenu();
            t.Show();
            this.Hide();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            txtage.Text = vScrollBar1.Value.ToString();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void datacategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
