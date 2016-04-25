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
    public partial class AddItem : Form
    {
        private pDataSetTableAdapters.productsTableAdapter Adapter = new pDataSetTableAdapters.productsTableAdapter();
        GrocessaryItems gItem;
        public AddItem()
        {
            InitializeComponent();
        }

        private void btbAdd_Click(object sender, EventArgs e)
        {
            
            double price;
            string name = txtName.Text;
            DateTime d;
            string location = txtLocation.Text;
            errorProvider.Clear();

            if (!double.TryParse(txtPrice.Text, out price) || price < 0)
            {
                errorProvider.SetError(txtPrice, " Invalid Price");
                return;
            }
           
            if (name == "")
            {

                errorProvider.SetError(txtName, " Invalid product name");
                return;
                
            }
            if (location == "")
            {

                errorProvider.SetError(txtLocation, " Invalid location");
                return;
            }
            if (!DateTime.TryParse(dtpExpiration.Text, out d) || FormatDate(d) < FormatDate(DateTime.Now))
            {
                errorProvider.SetError(dtpExpiration, " Invalid Date");
                return;
            }

            gItem = new GrocessaryItems(name, price,d,location);
            try
            {
                if (Adapter.Insert(gItem.name,gItem.price, gItem.dateTime, gItem.location) > 0)
                {
                    lblStatus.Text = "Succesfully Added";
                    //Form1 F1 = new Form1();
                    //F1.Show();
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = " Adding Failed";
            }
        
    }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private DateTime FormatDate(DateTime d)
        {
            DateTime dd = DateTime.Parse(d.Month + "/" + d.Day + "/" + d.Year);

            return dd;
        }
    }
}
