using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProject
{
    public partial class PurchaseItemForm : Form
    {

        private int itemID;
        private int accountID;
        private item item;
        public PurchaseItemForm(int itemID, int accountID)
        {
            InitializeComponent();
            this.itemID = itemID;
            this.accountID = accountID;
        }

        private void PurchaseItemForm_Load(object sender, EventArgs e)
        {
            using(var db = new DataClasses1DataContext())
            {
                item = db.items.Single(x => x.itemID == itemID);
                lblItemName.Text = item.itemName;
                lblDescription.Text = item.details;
                lblPrice.Text = item.price.ToString();

            }
            
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {

            decimal totalPrice = (selectQty.Value * item.price);


            using (var db = new DataClasses1DataContext())
            {

                account account = db.accounts.Single(x => x.accountID == accountID);
                if ((account.balance ) > 600)
                {
                    lblMessage.Text = "Your balance is over $600 so you cannot purchase this item";
                }
                else
                {
                    purchase purchase = new purchase() { accountID = accountID, itemID = itemID, totalPrice = totalPrice, purchasedDate = DateTime.Now, qty = (int)selectQty.Value };
                    db.purchases.InsertOnSubmit(purchase);


                    account.balance += totalPrice;

                    db.SubmitChanges();

                    lblMessage.Text = "Your purchase was processed";
                }



            }


            selectQty.Value = selectQty.Minimum;


        }

    }
}
