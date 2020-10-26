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
    public partial class viewlist : Form
    {
        public viewlist()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            configureitems n = new configureitems();
            n.Show();
            this.Close();
        }

        private void btnlistemployee_Click(object sender, EventArgs e)
        {
            listemployee k = new listemployee();
            k.Show();
            this.Close();
        }

        private void btnlistitems_Click(object sender, EventArgs e)
        {
            listitems y = new listitems();
            y.Show();
            this.Close();
        }
    }
}
