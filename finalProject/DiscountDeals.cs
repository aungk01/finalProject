using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject
{
    public partial class DiscountDeals : Form
    {
        public DiscountDeals()
        {
            InitializeComponent();
        }

        private void memberLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberLogins mLogin = new memberLogins();

            mLogin.Show();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registrationForm rForm = new registrationForm();
            rForm.Show();
        }
    }
}
 