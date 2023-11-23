using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void bttn_login_Click(object sender, EventArgs e)
        {

            using (var db = new DataClasses1DataContext()) {
                var account = db.accounts.FirstOrDefault(x => x.userName.Equals(txtUsername.Text.Trim()) && x.password.Equals(txtPassword.Text.Trim()));
                
                if (account != null)
                {
                    MainForm mainForm = new MainForm(account.accountID);
                    this.Hide();
                    mainForm.ShowDialog();
                    this.Close();
                    
                }
                else
                {
                    lblError.Text = "You entered an invalid username or password";
                    txtUsername.Text = "";
                    txtPassword.Text = "";

                }
            }

        }

    }
}
