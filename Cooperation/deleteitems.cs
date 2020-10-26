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
    public partial class deleteitems : Form
    {
        int indexRow;
        string code, nameitems, price, stock;

        static FileStream F;
        //static StreamWriter W;
        static StreamReader R;

        public deleteitems()
        {
            InitializeComponent();
        }

        private void dataitem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow dr = dataitem.SelectedRows[0];
            code = dr.Cells[0].Value.ToString();
            nameitems = dr.Cells[1].Value.ToString();
            price = dr.Cells[2].Value.ToString();
            stock = dr.Cells[3].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (this.dataitem.SelectedRows.Count > 0)
            {
                result = MessageBox.Show("Are you sure you want to delete: \n" + "Code: " + code +
                "\nName Items: " + nameitems + "\nPrice" + price +
                "\nStock: " + stock,
                "Insert new data", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    dataitem.Rows.RemoveAt(this.dataitem.SelectedRows[0].Index);

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
                        //sw.Write(sLine);
                        //sw.WriteLine("");

                        //sLine = "";
                    }
                    Updateitems("items.txt", sLine);


                    MessageBox.Show("Your data successfully deleted! :)");
                }
            }
            else
                MessageBox.Show("You must select one row!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void Updateitems(string FileTxt, string data)
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
            delete t = new delete();
            t.Show();
            this.Hide();
        }

        private void deleteitems_Load(object sender, EventArgs e)
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


    }
}
