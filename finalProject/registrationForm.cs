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
    public partial class registrationForm : Form
    {
        public registrationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string userName = txtUsername.Text;
            string passWord = txtPassword.Text;
            if (userName == "")
            {

                lblStatus.Text = " Invalid user name.";
                errorProvider1.SetError(txtUsername, "Invalid Passoword.");
                return;

            }
            else if (passWord == "")
            {
                if (userName == "")
                {

                    lblStatus.Text = " Invalid password.";
                    errorProvider1.SetError(txtUsername, "Invalid Passoword.");
                    return;

                }
               
                txtUsername.Clear();
                txtPassword.Clear();
                Form1 FormOne = new Form1();
                

            }
        }
    }
}
