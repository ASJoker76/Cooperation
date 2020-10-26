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
    public partial class updeteitems : Form
    {
        static FileStream F;
        //static StreamWriter W;
        static StreamReader R;

        int indexRow;

        public updeteitems()
        {
            InitializeComponent();
        }

        private void updeteitems_Load(object sender, EventArgs e)
        {
            string[] data = display("items.txt");
            for (int i = 0; i < data.Length - 1; i = i + 4)
            {
                dataitem.Rows.Add(data[i], data[i + 1], data[i + 2], data[i + 3]);
            }
        }
        public string[] display(string FileTxt)
        {
            F = new FileStream(FileTxt, FileMode.Open, FileAccess.Read);
            R = new StreamReader(F);

            string line;
            line = R.ReadToEnd();
            string[] contents = line.Split(new string[] { ";", "\r\n", "\n", "" }, StringSplitOptions.None);

            R.Close();
            F.Close();

            return contents;
        }

        private void dataitem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow dr = dataitem.SelectedRows[0];
            txtcode.Text = dr.Cells[0].Value.ToString();
            txtnameitems.Text = dr.Cells[1].Value.ToString();
            txtprice.Text = dr.Cells[2].Value.ToString();
            txtstock.Text = dr.Cells[3].Value.ToString();
            
        }

        private void enter_Click(object sender, EventArgs e)
        {
            DialogResult result;

            string code = txtcode.Text;
            string nameitems = txtnameitems.Text;
            string price = txtprice.Text;
            string stock = txtstock.Text;

            result = MessageBox.Show("Are you sure you want to update items: \n" + "Code: " + code +
                "\nName Items: " + nameitems + "\nPrice" + price +
                "\nStock: " + stock,
                "Insert new data", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                DataGridViewRow newData = dataitem.Rows[indexRow];
                newData.Cells[0].Value = txtcode.Text;
                newData.Cells[1].Value = txtnameitems.Text;
                newData.Cells[2].Value = txtprice.Text;
                newData.Cells[3].Value = txtstock.Text;
                
                string sLine = "";
                dataitem.Refresh();
                int count = dataitem.Rows.Count;
                File.WriteAllText("items.txt", String.Empty);
        
                for (int r = 0; r < count; r++)
                {
                    int colCount = dataitem.Rows[r].Cells.Count;
                    for (int c = 0; c < colCount; c++)
                    {
                        sLine = sLine + dataitem.Rows[r].Cells[c].Value;
                        if (c != dataitem.Columns.Count - 1)
                        {
                            sLine = sLine + ";";
                        }
                    }
                    sLine += "\r\n";
                    
                }
                UpdateItem("items.txt", sLine);


                MessageBox.Show("Your data successfully update! :)");
            }
        }

        public void UpdateItem(string FileTxt, string data)
        {
            FileStream fs = new FileStream(FileTxt, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.Write(data);

            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            configureitems t = new configureitems();
            t.Show();
            this.Hide();
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {
            if (txtprice.Text == "")
            {
                MessageBox.Show("NOT NULL");
                txtprice.Clear();
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

        private void txtstock_TextChanged(object sender, EventArgs e)
        {
            if (txtstock.Text == "")
            {
                MessageBox.Show("NOT NULL");
                txtstock.Clear();
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
    }
}
