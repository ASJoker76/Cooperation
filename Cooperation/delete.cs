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
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            configureitems n = new configureitems();
            n.Show();
            this.Close();
        }

        private void btndeleteemployee_Click(object sender, EventArgs e)
        {
            deleteemployee k = new deleteemployee();
            k.Show();
            this.Close();
        }

        private void btndeleteitems_Click(object sender, EventArgs e)
        {
            deleteitems u = new deleteitems();
            u.Show();
            this.Hide();
        }
    }
}
