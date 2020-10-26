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
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        
        private void btnadditems_Click(object sender, EventArgs e)
        {
            additems p = new additems();
            p.Show();
            this.Close();
        }

        private void btnaddemployee_Click(object sender, EventArgs e)
        {
            registration k = new registration();
            k.Show();
            this.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            configureitems n = new configureitems();
            n.Show();
            this.Close();
        }
    }
}
