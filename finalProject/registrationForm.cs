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
        customerDataSetTableAdapters.CustomerTableAdapter loginAdapter = new customerDataSetTableAdapters.CustomerTableAdapter();
        List<Logins> login = new List<Logins>();
        Logins click;
        public registrationForm()
        {
            InitializeComponent();
        }

       

        private void btnRegister_Click(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            string uName = txtUsername.Text;
            int pWord;
            errorProvider1.Clear();
            if (uName == "" || !rEmail.IsMatch(uName.Trim()))
            {


                errorProvider1.SetError(txtUsername, " Invalid username");
                return;
            }

            if (!int.TryParse(txtPassword.Text, out pWord))
            {

                errorProvider1.SetError(txtPassword, " Invalid password");
                return;
            }

            click = new Logins(uName, pWord);

            try
            {
                loginAdapter.Insert( click.Username,click.passWord);
                lblStatus.Text = "New login added";
                LoginTable lTable = new LoginTable();
                lTable.Show();
            }
            catch
            {
                lblStatus.Text = "Error creating new login";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
