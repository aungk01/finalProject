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
    public partial class liquorsalesForm : Form
    {
        List<liquorSales> currentSales = new List<liquorSales>();
        public liquorsalesForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            string name = txtName.Text;
            double price;
            string type = txtType.Text;
            string year = txtYear.Text;
            string location = txtLocation.Text;
            errorProvider.Clear();

            if (name == "")
            {
                
                errorProvider.SetError(txtName, "Item name must be entered");
                return;
            }
           else if (!double.TryParse(txtPrice.Text, out price) || price < 0)
            {
                errorProvider.SetError(txtPrice, " Invalid Price");
                return;
            }
           
           else if (type == "")
            {
                errorProvider.SetError(txtType, "Item type must be entered");
                return;
                
            }
            else if(location == "")
            {
                errorProvider.SetError(txtType, "Location must be entered");
                return;

            }
            if (year == "")
            {
                lblStatus.Text = lblType.Text.Substring(0, 15) + " must be entered";
                txtName.Focus();
                return;
            }
            else {
                if (radioWhisky.Checked)
                {
                    currentSales.Add(new Whisky(name,price, type, year,location));

                }
                else
                {
                    currentSales.Add(new Wine(name,price, type, year,location));

                }

            }
            DisplayAllListBox();
            clearTextBoxes();
        }

        private void viewWhiskyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstLiquor.Items.Clear();
            foreach (liquorSales s in currentSales)
            {
                if (s is Whisky)
                {
                    lstLiquor.Items.Add(s);
                }

            }
           
        }

        private void viewWineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstLiquor.Items.Clear();
            foreach (liquorSales s in currentSales)
            {
                if (s is Wine)
                {
                    lstLiquor.Items.Add(s);
                }

            }
            
        }
        // displaying item on list box
        private void DisplayAllListBox()
        {
            lstLiquor.Items.Clear();
            foreach (liquorSales value in currentSales)
            {
                lstLiquor.Items.Add(value);
            }
        }
        // clearing the text boxes
        private void clearTextBoxes()
        {
            txtName.Clear();
            txtPrice.Clear();
            txtType.Clear();
            txtYear.Clear();
        }
        // radio button for graduate clicked
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayAllListBox();
        }

        private void radioWhisky_CheckedChanged(object sender, EventArgs e)
        {
            lblType.Text = "Whisky";
        }

        private void radioWine_CheckedChanged(object sender, EventArgs e)
        {
            lblType.Text = "Wine"; 
        }

        private void liquorsalesForm_Load(object sender, EventArgs e)
        {
            currentSales.Add(new Whisky("Glenn Morengie", 44.99, "Scott Whisky", "12-year old","Walmart"));
            currentSales.Add(new Whisky("Glenn Levit", 39.99, "Scott Whisky", "18-Year old","Cap & Cork"));
            currentSales.Add(new Wine("Barefoot ", 8.99, "White", "pinot Gregio", "Meijer"));
            currentSales.Add(new Wine("Mionetto",10.99, "Red", "Solell", "Sams"));
            DisplayAllListBox();

        }
    }
}
