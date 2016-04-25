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
    public partial class AddProduct : Form
    {
        private pDataSetTableAdapters.productsTableAdapter Adapter = new pDataSetTableAdapters.productsTableAdapter();
        GrocessaryItems gItem;
        List<GrocessaryItems> grocressaryList = new List<GrocessaryItems>();

        public AddProduct()
        {
            InitializeComponent();
        }
        private DateTime FormatDate(DateTime d)
        {
            DateTime dd = DateTime.Parse(d.Month + "/" + d.Day + "/" + d.Year);

            return dd;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int pId;
            double price;
            string name = txtName.Text;
            DateTime d;
            string location = txtLocation.Text;

            if (!double.TryParse(txtPrice.Text, out price) || price < 0)
            {
                errorProvider.SetError(txtPrice, " Invalid Price");
                return;
            }
            if (!int.TryParse(txtId.Text, out pId))
            {
                errorProvider.SetError(txtId, " Invalid Id");
                return;
            }
            if (name == "")
            {
                errorProvider.SetError(txtName, " Invalid product name");
                return;
            }
            if (location == "")
            {

                lblStatus.Text = " Invalid location";
                txtLocation.Focus();
                return;
            }
            if (!DateTime.TryParse(dtpDate.Text, out d) || FormatDate(d) < FormatDate(DateTime.Now))
            {
                lblStatus.Text = " Invalid Expiration date";
                dtpDate.Focus();
                return;
            }
                gItem = new GrocessaryItems(pId, name, price, d, location);
                
            try
            {
                if (Adapter.Insert(gItem.Id, gItem.name, gItem.price, gItem.dateTime, gItem.location) > 0)
                {
                    lblStatus.Text = "Succesfully Added";
                   
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = " Adding Failed";
            }
        }


    }
   
    
}
