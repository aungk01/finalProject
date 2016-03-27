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
   
    public partial class Form1 : Form
    {
        int Lvote = 0;
        int DVote = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            string userName = txtUserName.Text;
           // string confirmPassword = txtConfirmpassword.Text;
           // datas.name = userName;
          //  datas.password = password;


            if ( password == "")
            {
                lblStatus.Text = " User password can't be blank";
                txtPassword.Focus();
                return;
            }
            if (userName == "")
            {
                lblStatus.Text = " User name can't be blank";
                txtUserName.Focus();
                return;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password = txtuPassword.Text;
            string userName = txtuName.Text;
            // string confirmPassword = txtConfirmpassword.Text;
            // datas.name = userName;
            //  datas.password = password;


            if (password == "")
            {
                lblStatus.Text = " User password can't be blank";
                txtuPassword.Focus();
                return;
            }
            if (userName == "")
            {
                lblStatus.Text = " User name can't be blank";
                txtuName.Focus();
                return;
            }

        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            
            if (radioLike.Checked)
            {
                Lvote++;
                lblLIkecount.Text = (Lvote).ToString();
            }
            else if (radioDislike.Checked){
                DVote++;
                lblDislike.Text = (DVote).ToString();
            }
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.pDataSet.products);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string price = txtPrice.Text;
            string name = txtuName.Text;
            string expDate = txtExpirationdate.Text;
            string location = txtLocation.Text;
            // string confirmPassword = txtConfirmpassword.Text;
            // datas.name = userName;
            //  datas.password = password;


            if (price == "")
            {
                lblStatus.Text = " price can't be blank";
                txtuPassword.Focus();
                return;
            }
            else if (name == "")
            {
                lblStatus.Text = "name can't be blank";
                txtuName.Focus();
                return;
            }
            else if (expDate == "")
            {
                lblStatus.Text = "expiration date can't be blank";
                txtuName.Focus();
                return;
            }
            else if (location == "")
            {
                lblStatus.Text = "location can't be blank";
                txtuName.Focus();
                return;
            }
        }
    }
}
