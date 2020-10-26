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

        string code, nameitems, price, stock,qty2;
        int indexRow;
        //static string jumlahbarang = "";
        //static string stock = "";
        public static int charge, money, qty, totalbarang;
        public static string nameemployee;

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
            if (txtqty.Text == "")
            {
                errorProvider1.SetError(txtqty, "Plase Enter Quantity");
            }
            else
            {
                errorProvider1.Clear();
                string code = isiCode.Text;
                string employee = lbuser.Text;
                string nameitem = isiitems.Text;
                string price1 = isiprice.Text;
                string stock2 = isistock.Text;
                string qty2 = txtqty.Text;

                //int price = Convert.ToInt32(data[2]);
                int new_stock = 0;
                int quantity = Convert.ToInt32(txtqty.Text);
                if (quantity <= Convert.ToInt32(stock2))
                {
                    new_stock = Convert.ToInt32(stock2) - Convert.ToInt32(qty2);
                    updateStock(new_stock);

                    DialogResult result = MessageBox.Show("What you can bought other items", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                      
                            int harga = Convert.ToInt32(isiprice.Text);
                            totalbarang += quantity * harga;

                     
                        adds("datatest.txt", code, employee, nameitem, price1, stock2, qty2);

                   
                        datatotal.Rows.Clear();
                        datatotal.Refresh();

                        string[] data6 = displaydata("datatest.txt");
                        for (int i = 0; i < data6.Length - 1; i = i + 6)
                        {
                            datatotal.Rows.Add(new object[] { data6[i], data6[i + 1], data6[i + 2], data6[i + 3], data6[i + 4], data6[i + 5] });
                            
                            
                        }
                        lbtotal2.Visible = true;
                        isitotal2.Visible = true;


                        
                        isitotal2.Text = Convert.ToString(totalbarang);
                   
                        lbmoney.Visible = true;
                        txtbayar.Visible = true;
                        btnsave.Visible = true;
                        txtqty.Clear();
                        
                    }
                    
                }
                else
                {
                    MessageBox.Show("The Stock not enough!!, Max" + stock2);
                    txtqty.Clear();
                }

            }
            isitotal2.Text = Convert.ToString(totalbarang);
            lbmoney.Visible = true;
            txtbayar.Visible = true;
            btnsave.Visible = true;
            btndel.Visible = true;

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
            if (data[0] == "-1")
            {
                MessageBox.Show("Sorry, Data NOT FOUND!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcari.Clear();
            }
            else
            {
                
                txtcari.Clear();
                
                lbCodeItems.Visible = true;
                lbnameitems.Visible = true;
                lbprice.Visible = true;
                lbstock.Visible = true;
                isiCode.Visible = true;
                isiCode.Text = (data[0]);
                isiitems.Visible = true;
                isiitems.Text = (data[1]);
                isiprice.Visible = true;
                isiprice.Text = (data[2]);
                isistock.Visible = true;
                isistock.Text = (data[3]);
                lbhowmany.Visible = true;
                txtqty.Visible = true;
                btnoke.Visible = true;
                lbtotal2.Visible = true;
                isitotal2.Visible = true;
                

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
            sw.WriteLine(DateTime.Now + ";" +nameemployee+";"+ totalbarang + ";" + money + ";" + charge);
            sw.Close();
            fs.Close();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            
            if (txtbayar.Text == "")
            {
                errorProvider1.SetError(txtqty, "Plase Enter Your Money");
            }
            else
            {
                errorProvider1.Clear();
                if (totalbarang <= Convert.ToInt32(txtbayar.Text))
                {

                    DialogResult result = MessageBox.Show("Thanks You For Coming", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {


                        lbchange.Visible = true;
                        isichange.Visible = true;
                        money = Convert.ToInt32(txtbayar.Text);
                        charge = Convert.ToInt32(txtbayar.Text) - totalbarang;
                        isichange.Text = Convert.ToString(charge);
                        txtbayar.Clear();
                        nameemployee = lbuser.Text;
                        mainmenu.printStruk();
                        btnnewtrans.Visible = true;
                        File.WriteAllText("datatest.txt", String.Empty);
                    }
                }
                else if (totalbarang >= Convert.ToInt32(txtbayar.Text))
                {
                    MessageBox.Show("Your Money Not Enough");
                    txtbayar.Clear();
                }
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
            Cmanipulation objManipulation = new Cmanipulation();
            objManipulation.UpdateItem("items.txt", sLine);
            
        }

        private void updatestock(int new_stock)
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
            lbtotal2.Visible = true;
            isitotal2.Visible = true;
            
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
            txtqty.Clear();
            txtbayar.Clear();
            isitotal2.Text = "0";
            totalbarang = 0;



        }

        private void txtbayar_Validating(object sender, CancelEventArgs e)
        { 
            int n;
            bool isnumeric = int.TryParse(txtbayar.Text, out n);
            if (isnumeric == false)
            {
                MessageBox.Show("Only Numeric");
                errorProvider1.SetError(txtbayar, "Only Numeric");
                txtbayar.Clear();
            }
            else
            {
                errorProvider1.Clear();
            }
            if (!txtbayar.Text.All(char.IsDigit))
            {
                MessageBox.Show("Cannot be character");
                errorProvider1.SetError(txtbayar, "Cannot be character");
                txtbayar.Clear();
            }
            else
            {
                errorProvider1.Clear();
            }
   
        }

        private void txtqty_Validating(object sender, CancelEventArgs e)
        {
            int n;
            bool isnumeric = int.TryParse(txtqty.Text, out n);
            if (isnumeric == false)
            {
                MessageBox.Show("Only Numeric");
                errorProvider1.SetError(txtqty, "Only Numeric");
                txtqty.Clear();
            }
            else
            {
                errorProvider1.Clear();
            }
            if (!txtqty.Text.All(char.IsDigit))
            {
                MessageBox.Show("Cannot be character");
                errorProvider1.SetError(txtqty, "Cannot be character");
                txtqty.Clear();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void datatotal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow dr = datatotal.SelectedRows[0];
            code = dr.Cells[0].Value.ToString();
            nameemployee = dr.Cells[1].Value.ToString();
            nameitems = dr.Cells[2].Value.ToString();
            price = dr.Cells[3].Value.ToString();
            stock = dr.Cells[4].Value.ToString();
            qty2 = dr.Cells[5].Value.ToString();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (this.datatotal.SelectedRows.Count > 0)
            {
                result = MessageBox.Show("Are you sure you want to delete:",
                "Insert new data", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

                int new_stock = 0;
                

                if (result == DialogResult.OK)
                {
                    
                    new_stock = Convert.ToInt32(stock);
                    updatestock(new_stock);

                    datatotal.Rows.RemoveAt(this.datatotal.SelectedRows[0].Index);

                    string sLine = "";
                    datatotal.Refresh();
                    dataitem.Refresh();
                    int count = datatotal.Rows.Count;
                    File.WriteAllText("datatest.txt", String.Empty);

                    for (int r = 0; r < count; r++)
                    {
                        int colCount = datatotal.Rows[r].Cells.Count;
                        for (int c = 0; c < colCount; c++)
                        {
                            sLine = sLine + datatotal.Rows[r].Cells[c].Value;
                            if (c != datatotal.Columns.Count - 1)
                            {
                                sLine = sLine + ";";
                            }
                        }
                        sLine += "\r\n";
                        
                    }
                    Cmanipulation k = new Cmanipulation();
                    k.UpdateItem("datatest.txt", sLine);


                    MessageBox.Show("Your data successfully deleted! :)");
                    totalbarang -= Convert.ToInt32(price) * Convert.ToInt32(qty2);
                    isitotal2.Text = Convert.ToString(totalbarang);
                }
            }
            else
                MessageBox.Show("You must select one row!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

       
    }
}
