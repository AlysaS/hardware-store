using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;

namespace SemesterProject
{
    
    public partial class PastItemsForm : Form
    {
        private int accountID;

        public PastItemsForm(int accountID)
        {
            InitializeComponent();
            this.accountID = accountID;
        }

        private void btnSearchClicked(object sender, EventArgs e)
        {

            using (var db = new DataClasses1DataContext())
            {
                lblMessage.Text = "";
                listViewPurchases.Items.Clear();

                RadioButton selectedRadioButton = searchOptionsgroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

                
                var items = db.purchases.Where(x=> x.accountID == accountID);

                if (selectedRadioButton != null)
                {
                    if (selectedRadioButton == date_rb)
                    {
                        try
                        {
                            DateTime minDate = dateTimePickerFrom.Value.Date;
                            DateTime maxDate = dateTimePickerTo.Value.Date;

                            items = items.Where(x => x.purchasedDate >= minDate && x.purchasedDate <= maxDate);

                        }
                        catch
                        {
                            lblMessage.Text = "You must enter a valid date range";
                            return;
                        }

                    }
                    else if (selectedRadioButton == price_rb)
                    {
                        try
                        {
                            int minPrice = Convert.ToInt32(txtBoxMinPrice.Text);
                            int maxPrice = Convert.ToInt32(txtBoxMaxPrice.Text);

                            items = items.Where(x => x.totalPrice >= minPrice && x.totalPrice <= maxPrice);

                        }
                        catch
                        {
                            lblMessage.Text = "You must enter a valid price range";
                            return;
                        }

                    }
                    else
                    {
                        items = db.purchases.Where(x => x.accountID == accountID);
                    }
                }

                
               items.ToList().ForEach(item =>
                {
                    ListViewItem listViewPurchase = new ListViewItem(item.item.itemName);
                    listViewPurchase.SubItems.Add(item.qty.ToString());
                    listViewPurchase.SubItems.Add(item.totalPrice.ToString());
                    listViewPurchase.SubItems.Add(item.purchasedDate.ToString());

                    listViewPurchases.Items.Add(listViewPurchase);

                });


            }

        }

        private void PastItemsForm_Load(object sender, EventArgs e)
        {
            listViewPurchases.View = View.Details;

            listViewPurchases.Items.Clear();
            listViewPurchases.Columns.Clear();

            listViewPurchases.Columns.Add("Item Name", 100);
            listViewPurchases.Columns.Add("Qty", 50);
            listViewPurchases.Columns.Add("Total Price", 50);
            listViewPurchases.Columns.Add("Purchase Date", 250);
        }

      
    }
}
