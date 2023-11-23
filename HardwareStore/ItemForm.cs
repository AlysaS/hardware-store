using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SemesterProject
{
    public partial class ItemForm : Form
    {

        private int accountID;
        public ItemForm(int accountID)
        {
            InitializeComponent();
            this.accountID = accountID;
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            using (var db = new DataClasses1DataContext())
            {
                listViewItems.View = View.Details;

                // Clear existing items and columns
                listViewItems.Items.Clear();
                listViewItems.Columns.Clear();

                // Add columns to the ListView
                listViewItems.Columns.Add("Item Name", 100);
                listViewItems.Columns.Add("Price", 50);
                listViewItems.Columns.Add("Details", 250);

                db.items.ToList().ForEach(item =>
                {
                    ListViewItem listViewItem = new ListViewItem(item.itemName);
                    listViewItem.SubItems.Add(item.price.ToString());
                    listViewItem.SubItems.Add(item.details.ToString());

                    listViewItems.Items.Add(listViewItem);

                });


            }
        }

        private void listViewItems_ItemActivate(object sender, EventArgs e)
        {
            var listItem = listViewItems.SelectedItems[0];



            using (var db = new DataClasses1DataContext())
            {
                var item = db.items.First(x => x.itemName == listItem.SubItems[0].Text);



                PurchaseItemForm purchaseItemForm = new PurchaseItemForm(item.itemID, accountID);
                purchaseItemForm.ShowDialog();
            }


        }


    }
}
