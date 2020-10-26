using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Cooperation
{
    public partial class deleteemployee : Form
    {
        static FileStream F;
        static StreamReader R;
        
        public deleteemployee()
        {
            InitializeComponent();
        }

        int indexRow;
        string code, nameemployee, age, address,gender, lasteducation, birtofdate, username, password, email,path;
       
        private void enter_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (this.datacategory.SelectedRows.Count > 0)
            {
                result = MessageBox.Show("Are you sure you want to delete: \n" + "Code: " + code +
                "\nName Employee: " + nameemployee + "\nAge" + age +
                "\nAddress: " + address +
                "\nGender: " + gender + "\nLast Education: " + lasteducation +
                "\nBirt Of Date: " + birtofdate + "\nusername: " + username+
                "\npassword: " + password + "\nemail: " + email + "\nPath : " + path,
                "Insert new data", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    datacategory.Rows.RemoveAt(this.datacategory.SelectedRows[0].Index);

                    string sLine = "";
                    datacategory.Refresh();
                    int count = datacategory.Rows.Count;
                    File.WriteAllText("dataemployee.txt", String.Empty);
                    //FileStream fs = new FileStream("Item.txt", FileMode.Append, FileAccess.Write);
                    //StreamWriter sw = new StreamWriter(fs);
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
                        //sw.Write(sLine);
                        //sw.WriteLine("");

                        //sLine = "";
                    }
                    Updateemployee("dataemployee.txt", sLine);


                    MessageBox.Show("Your data successfully deleted! :)");
                }
            }
            else
                MessageBox.Show("You must select one row!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        
        private void deleteemployee_Load(object sender, EventArgs e)
        {
            string[] data = displaydata("dataemployee.txt");
            for (int i = 0; i < data.Length - 1; i = i + 11)
            {
                datacategory.Rows.Add(data[i], data[i + 1], data[i + 2], data[i + 3], data[i + 4], data[i + 5], data[i + 6],
                    data[i+7],data[i+8],data[i+9],data[i+10]);
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
            indexRow = e.RowIndex;
            DataGridViewRow dr = datacategory.SelectedRows[0];
            code = dr.Cells[0].Value.ToString();
            nameemployee = dr.Cells[1].Value.ToString();
            age = dr.Cells[2].Value.ToString();
            address = dr.Cells[3].Value.ToString();
            gender = dr.Cells[4].Value.ToString();
            lasteducation = dr.Cells[5].Value.ToString();
            birtofdate = dr.Cells[6].Value.ToString();
            username = dr.Cells[7].Value.ToString();
            password = dr.Cells[8].Value.ToString();
            email = dr.Cells[9].Value.ToString();
            path = dr.Cells[10].Value.ToString();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            delete o = new delete();
            o.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            configureitems cg = new configureitems();
            cg.Show();
            this.Hide();
        }
    }
}
