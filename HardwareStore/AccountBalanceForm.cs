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
    public partial class AccountBalanceForm : Form
    {
        private int accountID;
        public AccountBalanceForm(int accountID)
        {
            InitializeComponent();
            this.accountID = accountID;
        }

        private void AccountBalanceForm_Load(object sender, EventArgs e)
        {
            using(var db = new DataClasses1DataContext())
            {
                lblAccntBal.Text = db.accounts.Single(x => x.accountID == accountID).balance.ToString();
            }
            
        }

        private void btnPayClicked(object sender, EventArgs e)
        {
            decimal accountBal = Convert.ToDecimal(txtBoxAmount.Text);
            lblMessage.Text = "";

            if (accountBal > 0)
            {
                using (var db = new DataClasses1DataContext())
                {
                    account account = db.accounts.Single(x => x.accountID == accountID);
                    account.balance -= accountBal;
                    db.SubmitChanges();

                    txtBoxAmount.Text = "";
                    lblAccntBal.Text = account.balance.ToString();
                    lblMessage.Text = "Your payment was processed";
                }
            }
            else
            {
                lblMessage.Text = "You must enter an amount greater than 0";

            }
            

            

        }

       
    }
}
