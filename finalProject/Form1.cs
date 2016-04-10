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
        private pDataSetTableAdapters.productsTableAdapter Adapter = new pDataSetTableAdapters.productsTableAdapter();
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
        private DateTime FormatDate(DateTime d)
        {
            DateTime dd = DateTime.Parse(d.Month + "/" + d.Day + "/" + d.Year);

            return dd;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pDataSet.products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.pDataSet.products);
             dgvProducts.DataSource   =Adapter.GetData();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
          
            if (radioAdd.Checked)
            {
                int pId;
                double price;
                string name = txtName.Text;
                DateTime d;
                string location = txtLocation.Text;

                if (!double.TryParse(txtPrice.Text, out price) || price < 0)
                {
                    lblStatus.Text = " Invalid Price";
                    txtPrice.Focus();
                    return;
                }
                if (!int.TryParse(txtId.Text, out pId))
                {
                    lblStatus.Text = " Invalid Id";
                    txtId.Focus();
                    return;
                }
                if (name == "")
                {

                    lblStatus.Text = " Invalid product name.";
                    txtName.Focus();
                    return;
                }
                if (location == "")
                {

                    lblStatus.Text = " Invalid location";
                    txtLocation.Focus();
                    return;
                }
                if (!DateTime.TryParse(dtpExpire.Text, out d) || FormatDate(d) < FormatDate(DateTime.Now))
                {
                    lblStatus.Text = " Invalid Expiration date";
                    dtpExpire.Focus();
                    return;
                }
                    try
                {
                    if (Adapter.Insert(pId, name, price, d, location) > 0)
                    {
                        lblStatus.Text = "Succesfully Added";
                    }
                }
                catch (Exception ex)
                {
                    lblStatus.Text = " Adding Failed";
                }
            }

            else if (radioEdit.Checked)
            {
                int pId=0;
                double price;
                string name = txtName.Text;
                DateTime d;
                string location = txtLocation.Text;
                if (!int.TryParse(txtId.Text, out pId))
                {
                    lblStatus.Text = " Invalid Id";
                    txtId.Focus();
                    return;
                }
                if (!double.TryParse(txtPrice.Text, out price) || price < 0)
                {
                    lblStatus.Text = " Invalid Price";
                    txtPrice.Focus();
                    return;
                }
                if (name == "")
                {

                    lblStatus.Text = " Invalid product name.";
                    txtName.Focus();
                    return;
                }
                if (location == "")
                {

                    lblStatus.Text = " Invalid location";
                    txtLocation.Focus();
                    return;
                }
                if (!DateTime.TryParse(dtpExpire.Text, out d) || FormatDate(d) < FormatDate(DateTime.Now))
                {
                    lblStatus.Text = " Invalid Expiration date";
                    dtpExpire.Focus();
                    return;
                }

                Adapter.Update(name, price, d, location,pId);

            }
            else if (radioDelete.Checked)
            {
                int pId;
                if (!int.TryParse(txtId.Text, out pId))
                {
                    lblStatus.Text = " Invalid Id";
                    txtId.Focus();
                    return;
                }
               
                Adapter.Delete(pId);
                lblStatus.Text = "Item Deleted";
            }
            dgvProducts.DataSource = Adapter.GetData();
           // dgvProducts.DataSource = Adapter.Update((pId));
        }

       
       private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAdd.Checked)
            {
                txtId.Enabled = true;
               txtName.Enabled = true;
               txtPrice.Enabled = true;
               txtLocation.Enabled = true;
               dtpExpire.Enabled = true;
            }
            else if (radioDelete.Checked)
            {
                txtId.Enabled = true;
                txtName.Enabled = false;
                txtPrice.Enabled = false;
                txtLocation.Enabled = false;
                dtpExpire.Enabled = false;
            }
            else if (radioEdit.Checked)
            {
               
                txtId.Enabled = false;
            }
            
        }

    
    }
}
