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
        private pDataSetTableAdapters.productsTableAdapter  Adapter;
       // private pDataSetTableAdapters.productsTableAdapter Adapter = new pDataSetTableAdapters.productsTableAdapter();
        private bool formLoading = true;
        private int mEmployeeID;
        int Lvote = 0;
        int DVote = 0;
        public Form1()
        {
            InitializeComponent();
        }
       
        public void UpdateForm()
        {
            cboProducts.ComboBox.DataSource = Adapter.GetData();
            cboProducts.ComboBox.DisplayMember = "Name";
            cboProducts.ComboBox.ValueMember = "Product Id";
            cboProducts.ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProducts.SelectedIndex = -1;
            dgvProducts.DataSource = Adapter.GetData();
            formLoading = false;
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
            //dgvProducts.DataSource   =Adapter.GetData();
            Adapter = new pDataSetTableAdapters.productsTableAdapter();
            UpdateForm();
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            txtId.Enabled = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
          
            if (radioAdd.Checked)
            {
                lblStatus.Text = "";
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
                    if (Adapter.Insert(name, price, d, location ) > 0)
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
                lblStatus.Text = "";
                string name = txtName.Text;
                DateTime d;
                string location = txtLocation.Text;
                
                //if (!int.TryParse(txtId.Text, out pId))
                //{
                //    lblStatus.Text = " Invalid Id";
                //    txtId.Focus();
                //    return;
                //}
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
                try
                { 
                  if (dgvProducts.SelectedRows.Count > 0)
                     {
                        int Id = (int)(dgvProducts.SelectedRows[0].Cells[0].Value);
                        
                        Adapter.Update(name, price, d, location, pId);
                        UpdateForm();
                     }
                    else
                    {
                        lblStatus.Text = "Click on a name to select an employee.";
                        return;
                    }
                }
                catch
                {
                    lblStatus.Text = "Error loading product information.";
                }

               

            }
            else if (radioDelete.Checked)
            {
                int pId;
                lblStatus.Text = "";
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

       
       private void Button_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAdd.Checked)
            {
                txtId.Enabled = false;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            registrationForm rG = new registrationForm ();
                         rG.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddItem frmAdd = new AddItem();
            frmAdd.ShowDialog();
            formLoading = true;
            UpdateForm();
        }

        private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!formLoading)
            {
                int selectedId = (int)cboProducts.ComboBox.SelectedValue;
                dgvProducts.DataSource = GetById(selectedId);
            }
        }
        private DataTable GetById(int Id)
        {
            DataTable table = Adapter.GetData();
            table.DefaultView.RowFilter = "[Product Id] = " + Id;
            return table;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = Adapter.GetData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";

            if (dgvProducts.SelectedRows.Count > 0)
            {
                int Id = (int)(dgvProducts.SelectedRows[0].Cells[0].Value);
                EditproductForm frmEdit = new EditproductForm();
                frmEdit.SetEmployeeID(Id);
                frmEdit.ShowDialog();
                formLoading = true;
                UpdateForm();
            }
            else
            {
                lblStatus.Text = "Click on a name to select an employee.";
                return;
            }
        }
    }
}
