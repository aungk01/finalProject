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
    public partial class EditproductForm : Form
    {
        private pDataSetTableAdapters.productsTableAdapter Adapter;
        private int mProductID;
        GrocessaryItems gItem;
        public EditproductForm()
        {
            InitializeComponent();
        }
        public void SetEmployeeID(int pId)
        {
            mProductID = pId;
        }
        private DateTime FormatDate(DateTime d)
        {
            DateTime dd = DateTime.Parse(d.Month + "/" + d.Day + "/" + d.Year);

            return dd;
        }
        private void EditproductForm_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            Adapter = new pDataSetTableAdapters.productsTableAdapter();
            try
            {
                pDataSet.productsDataTable table;
                table = Adapter.GetData();
                pDataSet.productsRow row;
                row = table.FindByProduct_Id(mProductID);
                txtName.Text = row.Name;
                txtPrice.Text = row.Price.ToString();
                lblExpirationdate.Text = row.Expiration_date.ToShortDateString();
                txtLocation.Text = row.Store;
            }
            catch
            {
                lblStatus.Text = "Error loading employee information.";
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            string name = txtName.Text;
            double rate;
            string location = txtLocation.Text;
            DateTime d;
           
            if (name == "")
            {
                errorProvider.SetError(txtName, "Invalid product name.");
                return;

            }
           

            if (!double.TryParse(txtPrice.Text, out rate) || rate < 0)
            {
                errorProvider.SetError(txtPrice, "Invalid price.");
                return;
            }
            if (!DateTime.TryParse(lblExpirationdate.Text, out d) || FormatDate(d) < FormatDate(DateTime.Now))
            {
               
                errorProvider.SetError(txtPrice, "Invalid date.");
                return;
                
            }
            if (location == "")
            {

                errorProvider.SetError(txtPrice, "Invalid location.");
                return;

            }

            gItem = new GrocessaryItems(name,rate, d,location);

            try
            {
                Adapter.Update(gItem.name,gItem.price,gItem.dateTime,gItem.location,mProductID);
                lblStatus.Text = "Product Updated";
            }
            catch
            {
                lblStatus.Text = "Error updating product.";
            }

        }
    }
}
