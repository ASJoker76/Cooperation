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
    public partial class mainmenu : Form
    {
        static FileStream F;
        static StreamWriter W;
        static StreamReader R;

        int indexRow;
        //static string jumlahbarang = "";
        //static string stock = "";
        public static int charge, money, qty, totalbarang;

        public mainmenu()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txttanggal.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtwaktu.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void projectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(" This Project is a cooperative application \n in such a way to make it easier \n for user to transactions and purchases");
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(" Agus Setiawan Owner");
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            Home i = new Home();
            i.Show();
            this.Hide();
        }

        
        private void button3_Click_1(object sender, EventArgs e)
        {
            configureitems c = new configureitems();
            c.Show();
            this.Hide();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cdFont.ShowDialog();
            //lbwelcome.ForeColor = cdFont.Color;
            gbTransaction.ForeColor = cdFont.Color;
            gbprofileaccont.ForeColor = cdFont.Color;
        }

        private void backgroudFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cdFont.ShowDialog();
            //lbwelcome.BackColor = cdFont.Color;
            gbTransaction.ForeColor = cdFont.Color;
            gbprofileaccont.ForeColor = cdFont.Color;

        }

        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fdfont.ShowDialog();
            gbTransaction.ForeColor = cdFont.Color;

        }

        
        private void btnoke_Click_1(object sender, EventArgs e)
        {
            //string[] data = SearchStock("items.txt", txtqty.Text);
            string code = isiCode.Text;
            string employee = lbuser.Text;
            string nameitem = isiitems.Text;
            string price1 = isiprice.Text;
            string stock2 = isistock.Text;
            string qty2 = txtqty.Text;
            string text = "";
            string newd = "";
            //int price = Convert.ToInt32(data[2]);
            int new_stock = 0;
            int quantity = Convert.ToInt32(txtqty.Text); 
            if (quantity <= Convert.ToInt32(stock2))
            {
                new_stock = Convert.ToInt32(stock2) - Convert.ToInt32(qty2);
                updateStock(new_stock);   
                    
                /*stok = stok - quantity;

                int harga = Convert.ToInt32(data[2]);
                qty = qty * harga;
                totalbarang += qty;*/
                DialogResult result=MessageBox.Show("What you can bought other items", "Information",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
               if (result == DialogResult.Yes)
               {
                    string[] content = displaydata("items.txt");
                    //datatotal.Rows.Add(new object[] {code, employee, nameitem, price1, stock2 });
                    adds("datatest.txt",code, employee, nameitem, price1, stock2,qty2);
                    
                    
                    datatotal.Rows.Clear();
                   datatotal.Refresh();
                    
                    string[] data6 = displaydata("datatest.txt");
                   for (int i = 0; i < data6.Length - 1; i = i + 6)
                    {
                        datatotal.Rows.Add(new object[] { data6[i], data6[i + 1], data6[i + 2], data6[i + 3], data6[i + 4],data6[i+5] });
                        int harga = Convert.ToInt32(data6[i+3]);
                        //totalbarang += quantity * harga;
                    }

                    
                     //File.WriteAllText("datatest.txt", String.Empty);
                }
               else
               {
                    
                    adds("datatest.txt", code, employee, nameitem, price1, stock2, qty2);

                    datatotal.Rows.Clear();
                    datatotal.Refresh();
                    
                    string[] data6 = displaydata("datatest.txt");
                    for (int i = 0; i < data6.Length - 1; i = i + 6)
                    {
                        datatotal.Rows.Add(new object[] { data6[i], data6[i + 1], data6[i + 2], data6[i + 3], data6[i + 4], data6[i + 5] });
                        int harga = Convert.ToInt32(data6[i + 3]);
                        totalbarang += quantity * harga;
                        //calculate ("datatest.txt",quantity)
                    }
                    lbtotal2.Visible = true;
                    isitotal2.Visible = true;
                    
                    
                    text += newd + "\r\n";

                    isitotal2.Text = Convert.ToString(totalbarang);
                    //totalbarang = isitotal2.Text;
                    lbmoney.Visible = true;
                    txtbayar.Visible = true;
                    btnsave.Visible = true;
                    File.WriteAllText("datatest.txt", String.Empty);
                }
            }
            else
            {
                MessageBox.Show("The Stock not enough!!, Max"+ stock2);
                txtqty.Clear();
            }

        }

        
        public void adds(string FileTxt,string code, string employee, string nameitem, string price2, string stock2,string qty2)
        {
            //int line = check(FileTxt, nameitem);

            F = new FileStream("datatest.txt", FileMode.Append, FileAccess.Write);
            W = new StreamWriter(F);
            //if (line != -1)
            //{
                //string code = "IS" + (line + 1);
                W.WriteLine(code + ";" + employee + ";" + nameitem + ";" + price2 + ";" + stock2 + ";" + qty2);
                MessageBox.Show(" SUCSSES ");
            //}
            W.Flush();
            W.Close();
        }

        public int check(string FileTxt, string code)
        {
            F = new FileStream(FileTxt, FileMode.OpenOrCreate, FileAccess.Read);
            R = new StreamReader(F);

            int countLine = 0;
            string line = R.ReadLine();
            try
            {
                while ((line != null))
                {
                    if (!line.Contains(code))
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

        private void ownerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Class \t 2SC6 \n\n Grup 7 \t Agus Setiawan \n \t Fauzi R \n \t Iqbal \n\n Faculty \t Milyun Ni'ma Shoumi S.Kom,M.Kom ");  
        }

        private void mainmenu_Load(object sender, EventArgs e)
        {
            
            this.ActiveControl = txtcari;
            string[] data = SearchEmployee("dataemployee.txt",Cglobal.username);
            for (int i = 0; i < data.Length - 1; i = i + 11)
            {
                if (data[7] == Cglobal.username)
                {
                    lbuser.Text = (data[i + 1]);
                    lbcode.Text = (data[i]);
                }
            }

            string[] data2 = displaydata("items.txt");
            for (int i = 0; i < data2.Length - 1; i = i + 4)
            {
                dataitem.Rows.Add(data2[i], data2[i + 1], data2[i + 2], data2[i + 3]);
            }

        }

        private void txtcari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btncari_Click(this, new EventArgs());
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            
            string[] data = SearchItem("items.txt", txtcari.Text);
            dataitem.Rows.Clear();
            dataitem.Refresh();
            if (data[0] == "-1")
            {
                MessageBox.Show("Sorry, Data NOT FOUND!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcari.Clear();
            }
            else
            {
                
              txtcari.Clear();
                lbnameitems.Visible = true;
                isiitems.Visible = true;
                isiitems.Text = (data[1]);
                lbprice.Visible = true;
                isiprice.Visible = true;
                isiprice.Text = (data[2]);
                lbhowmany.Visible = true;
                txtqty.Visible = true;
                btnoke.Visible = true;
                lbstock.Visible = true;
                isistock.Visible = true;
                isistock.Text = (data[3]);
            }
        }
        string[] contents;

        public string[] SearchItem(string FileTxt, string name)
        {
            F = new FileStream(FileTxt, FileMode.Open, FileAccess.Read);
            R = new StreamReader(F);

            string line;

            while ((line = R.ReadLine()) != null)
            {
                if (line.Contains(name))
                    contents = line.Split(';');
            }
            R.Close();
            F.Close();
            int check = SearchNotFound(FileTxt, name);
            if (check == 1)
                contents = new string[] { "-1" };

            return contents;
        }

        public string[] SearchEmployee(string FileTxt, string name)
        {
            F = new FileStream(FileTxt, FileMode.Open, FileAccess.Read);
            R = new StreamReader(F);

            string line;

            while ((line = R.ReadLine()) != null)
            {
                if (line.Contains(name))
                    contents = line.Split(';');
            }
            R.Close();
            F.Close();
            int check = SearchNotFound(FileTxt, name);
            if (check == 1)
                contents = new string[] { "-1" };

            return contents;
        }

        public string[] SearchStock(string FileTxt, string stock)
        {
            F = new FileStream(FileTxt, FileMode.Open, FileAccess.Read);
            R = new StreamReader(F);

            string line;

            while ((line = R.ReadLine()) != null)
            {
                if (line.Contains(stock))
                    contents = line.Split(';');
            }
            R.Close();
            F.Close();
            int check = SearchNotFound(FileTxt, stock);
            if (check == 3)
                contents = new string[] { "-1" };

            return contents;
        }

        public int SearchNotFound(string FileTxt, string name)
        {
            F = new FileStream(FileTxt, FileMode.Open, FileAccess.Read);
            R = new StreamReader(F);
            string line = R.ReadToEnd();
            if (!line.Contains(name))
                return 1;
            F.Close();
            R.Close();

            return 0;
        }

       
        public static void printStruk()
        {

            FileStream fs = new FileStream("struk.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("==========================================");
            sw.WriteLine("Tanggal Transaksi : " + DateTime.Now);
            sw.WriteLine("Total Items  : Rp." + totalbarang);
            sw.WriteLine("Nominal Uang : Rp." + money);
            sw.WriteLine("Kembalian    : Rp." + charge);
            sw.WriteLine("==========================================\n");
            sw.Close();
            fs.Close();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {

            if (totalbarang <= Convert.ToInt32(txtbayar.Text))
            {
                
                DialogResult result = MessageBox.Show("Thanks You For Coming", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    
                    //DataGridViewRow newData = dataitem.Rows[indexRow];
                    /*string[] data6 = displaydata("datatest.txt");
                    for (int i = 0; i < data6.Length - 1; i = i + 6)
                    {
                        new_stock = Convert.ToInt32(stock2) - Convert.ToInt32(qty2);
                        //int datalast = Convert.ToInt32(data6[i + 4]) - Convert.ToInt32(data6[i + 5]);
                        DataGridViewRow newData = dataitem.Rows[indexRow];
                        newData.Cells[0].Value = isiCode.Text;
                        newData.Cells[1].Value = isiitems.Text;
                        newData.Cells[2].Value = isiprice.Text;
                        newData.Cells[3].Value = datalast;
                        File.WriteAllText("datatest.txt", String.Empty);

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
                    }*/
                    lbchange.Visible = true;
                    isichange.Visible = true;
                    money = Convert.ToInt32(txtbayar.Text);
                    charge = Convert.ToInt32(txtbayar.Text) - totalbarang;
                    isichange.Text = Convert.ToString(charge);
                    mainmenu.printStruk();
                    btnnewtrans.Visible = true;
                }
            }
            else if (totalbarang >= Convert.ToInt32(txtbayar.Text))
            {
                MessageBox.Show("Your Money Not Enough");
                txtbayar.Clear();
            }
        }

        private void updateStock(int new_stock)
        {
            DataGridViewRow newData = dataitem.Rows[indexRow];
            newData.Cells[0].Value = isiCode.Text;
            newData.Cells[1].Value = isiitems.Text;
            newData.Cells[2].Value = isiprice.Text;
            newData.Cells[3].Value = new_stock.ToString();

            string sLine = "";
            dataitem.Refresh();
            int count = dataitem.Rows.Count;
            File.WriteAllText("items.txt", String.Empty);
            //FileStream fs = new FileStream("Item.txt", FileMode.Append, FileAccess.Write);
            //StreamWriter sw = new StreamWriter(fs);
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
            Cmanipulation objManipulation = new Cmanipulation();
            objManipulation.UpdateItem("items.txt", sLine);
        }

        private void btneditprofile_Click(object sender, EventArgs e)
        {
            updateemployee h = new updateemployee();
            h.Show();
            this.Hide();
        }

        private void dataitem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow dr = dataitem.SelectedRows[0];
            lbCodeItems.Visible = true;
            lbnameitems.Visible = true;
            lbprice.Visible = true;
            lbstock.Visible = true;
            isiCode.Visible = true;
            isiCode.Text = dr.Cells[0].Value.ToString();
            isiitems.Visible = true;
            isiitems.Text = dr.Cells[1].Value.ToString();
            isiprice.Visible = true;
            isiprice.Text = dr.Cells[2].Value.ToString();
            isistock.Visible = true;
            isistock.Text = dr.Cells[3].Value.ToString();
            lbhowmany.Visible = true;
            txtqty.Visible = true;
            btnoke.Visible = true;
            
        }

        private void txtqty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnoke_Click_1(this, new EventArgs());
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

        private void btnnewtrans_Click(object sender, EventArgs e)
        {
            datatotal.Rows.Clear();
            datatotal.Refresh();

            string[] data6 = displaydata("datatest.txt");
            for (int i = 0; i < data6.Length - 1; i = i + 6)
            {
                datatotal.Rows.Add(new object[] { data6[i], data6[i + 1], data6[i + 2], data6[i + 3], data6[i + 4], data6[i + 5] });
                int harga = Convert.ToInt32(data6[i + 3]);
                
            }
            lbCodeItems.Visible = false;
            isiCode.Visible = false;
            lbnameitems.Visible = false;
            isiitems.Visible = false;
            lbprice.Visible = false;
            isiprice.Visible = false;
            lbstock.Visible = false;
            isistock.Visible = false;
            lbhowmany.Visible = false;
            txtqty.Visible = false;
            btnoke.Visible = false;
            lbtotal2.Visible = false;
            isitotal2.Visible = false;
            lbmoney.Visible = false;
            txtbayar.Visible = false;
            btnsave.Visible = false;
            lbchange.Visible = false;
            isichange.Visible = false;
            btnnewtrans.Visible = false;
        }
    }
}
