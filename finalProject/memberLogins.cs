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
    public partial class memberLogins : Form
    {
       
        customerDataSetTableAdapters.CustomerTableAdapter loginAdapter = new customerDataSetTableAdapters.CustomerTableAdapter();
        List<Logins> login = new List<Logins>();
        Logins click;
        public memberLogins()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            
            int passWord= 0;

            if (txtUserName.Text == "" || !rEmail.IsMatch(txtUserName.Text.Trim()))
            {

                errorProvider.SetError( txtUserName,"Invalid user name");
                return;
               
                
            }
            if (!int.TryParse(txtPassword.Text, out passWord))
            {
                errorProvider.SetError(txtPassword, "Invalid password");
                return;
                
               
                
            }

            click = new Logins(txtUserName.Text, passWord);

            try
            {
                if (loginAdapter.Search(loginAdapter.GetData(),click.Username,click.passWord) > 0)
                {
                    lblStatus.Text = "Succesfully Loogged In";
                    //LoginTable lTable = new LoginTable();
                    //lTable.Show();
                    Form1 F1 = new Form1();
                    F1.Show();

                }
                else if (loginAdapter.SearchUsername(loginAdapter.GetData(), click.Username) > 0)
                {
                    lblStatus.Text = "Invalid password";
                }
                else
                {
                    lblStatus.Text = "Invalid credentials";
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = " Login Failed";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
