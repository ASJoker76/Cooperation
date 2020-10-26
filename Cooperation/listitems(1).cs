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
    public partial class listitems : Form
    {
        static FileStream F;
        //static StreamWriter W;
        static StreamReader R;
        string[] contents;

        public listitems()
        {
            InitializeComponent();
        }

        private void listitems_Load(object sender, EventArgs e)
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

        private void btnback_Click(object sender, EventArgs e)
        {
            viewlist k = new viewlist();
            k.Show();
            this.Hide();
        }

        private void btnfind_Click(object sender, EventArgs e)
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
                dataitem.Visible = true;
                for(int i = 0; i < data.Length - 1; i = i + 4)
                {
                    dataitem.Rows.Add(data[i], data[i+1], data[i+2], data[i+3]);
                }
                
            }
        }
        
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

        
    }
}
