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
    public partial class listemployee : Form
    {
        static FileStream F;
        //static StreamWriter W;
        static StreamReader R;
        string[] contents;

        public listemployee()
        {
            InitializeComponent();
        }

        private void listemployee_Load(object sender, EventArgs e)
        {

            string[] data = displaydata("dataemployee.txt");
            for (int i = 0; i < data.Length - 1; i = i + 11)
            {
                datapersonal.Rows.Add(data[i], data[i + 1], data[i + 2], data[i + 3], data[i + 4], data[i + 5], data[i + 6]);
                dataaccount.Rows.Add(data[i], data[i + 1], data[i + 7], data[i + 8], data[i + 9],data[i+10]);
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

        private void btnback_Click(object sender, EventArgs e)
        {
            viewlist j = new viewlist();
            j.Show();
            this.Close();
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            string[] data = Searchemployee("dataemployee.txt", txtcari.Text);
            datapersonal.Rows.Clear();
            dataaccount.Rows.Clear();
            datapersonal.Refresh();
            dataaccount.Refresh();
            if (data[0] == "-1")
            {
                MessageBox.Show("Sorry, Data NOT FOUND!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcari.Clear();
            }
            else
            {
                datapersonal.Visible = true;
                dataaccount.Visible = true;
                for (int i = 0; i < data.Length - 1; i = i + 11)
                {
                    datapersonal.Rows.Add(data[i], data[i + 1], data[i + 2], data[i + 3], data[i + 4], data[i + 5], data[i + 6]);
                    dataaccount.Rows.Add(data[i], data[i + 1], data[i + 7], data[i + 8], data[i + 9]);
                }

            }
        }

        public string[] Searchemployee(string FileTxt, string name)
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
