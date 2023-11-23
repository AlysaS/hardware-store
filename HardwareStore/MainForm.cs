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
    public partial class MainForm : Form
    {
        private int accountID;
        public MainForm(int accountID)
        {
            InitializeComponent();
            this.accountID = accountID;
        }

        private void StoreItemsMenuClicked(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm(accountID);
            itemForm.TopLevel = false;
            itemForm.FormBorderStyle= FormBorderStyle.None;
            itemForm.Dock = DockStyle.Fill;
            panelMainForm.Controls.Clear();
            panelMainForm.Controls.Add(itemForm);
            itemForm.Show();
        }

        private void SignOutMenuClicked(object sender, EventArgs e)
        {

            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void AccountBalanceMenuClicked(object sender, EventArgs e)
        {
            AccountBalanceForm accountBalanceForm = new AccountBalanceForm(accountID);
            accountBalanceForm.TopLevel = false;
            accountBalanceForm.FormBorderStyle = FormBorderStyle.None;
            accountBalanceForm.Dock = DockStyle.Fill;
            panelMainForm.Controls.Clear();
            panelMainForm.Controls.Add(accountBalanceForm);
            accountBalanceForm.Show();
        }

        private void PurchasedItemMenuClicked(object sender, EventArgs e)
        {
            PastItemsForm pastItemsForm = new PastItemsForm(accountID);
            pastItemsForm.TopLevel = false;
            pastItemsForm.FormBorderStyle = FormBorderStyle.None;
            pastItemsForm.Dock = DockStyle.Fill;
            panelMainForm.Controls.Clear();
            panelMainForm.Controls.Add(pastItemsForm);
            pastItemsForm.Show();

        }
    }
}
