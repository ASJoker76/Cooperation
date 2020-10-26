using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cooperation
{
    public partial class configureitems : Form
    {
        public configureitems()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            mainmenu v = new mainmenu();
            v.Show();
            this.Hide();
        }

        private void configureitems_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            add j = new add();
            j.Show();
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            delete x = new delete();
            x.Show();
            this.Hide();
        }

        private void btnviewlish_Click(object sender, EventArgs e)
        {
            viewlist p = new viewlist();
            p.Show();
            this.Close();
        }

        private void btnupdateitems_Click(object sender, EventArgs e)
        {
            updeteitems l = new updeteitems();
            l.Show();
            this.Hide();
        }       
    }
}
