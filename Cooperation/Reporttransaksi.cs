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
    public partial class Reporttransaksi : Form
    {
        static FileStream F;
        //static StreamWriter W;
        static StreamReader R;

        public Reporttransaksi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            configureitems y = new configureitems();
            y.Show();
            this.Close();
        }

        private void Reporttransaksi_Load(object sender, EventArgs e)
        {
            
            string[] data = display("struk.txt");
            for (int i = 0; i < data.Length - 1; i = i + 5)
            {
                reportdagang.Rows.Add(data[i], data[i + 1], data[i + 2], data[i + 3],data[i+4]);
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
