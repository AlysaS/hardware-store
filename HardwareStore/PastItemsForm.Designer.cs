namespace SemesterProject
{
    partial class PastItemsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxMinPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxMaxPrice = new System.Windows.Forms.TextBox();
            this.listViewPurchases = new System.Windows.Forms.ListView();
            this.lblMessage = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.allItems_rb = new System.Windows.Forms.RadioButton();
            this.date_rb = new System.Windows.Forms.RadioButton();
            this.price_rb = new System.Windows.Forms.RadioButton();
            this.searchOptionsgroupBox = new System.Windows.Forms.GroupBox();
            this.searchOptionsgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(125, 83);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(247, 22);
            this.dateTimePickerFrom.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(673, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 28);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearchClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price: ";
            // 
            // txtBoxMinPrice
            // 
            this.txtBoxMinPrice.Location = new System.Drawing.Point(514, 82);
            this.txtBoxMinPrice.Name = "txtBoxMinPrice";
            this.txtBoxMinPrice.Size = new System.Drawing.Size(87, 22);
            this.txtBoxMinPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(458, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Min: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(458, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Max: ";
            // 
            // txtBoxMaxPrice
            // 
            this.txtBoxMaxPrice.Location = new System.Drawing.Point(514, 110);
            this.txtBoxMaxPrice.Name = "txtBoxMaxPrice";
            this.txtBoxMaxPrice.Size = new System.Drawing.Size(87, 22);
            this.txtBoxMaxPrice.TabIndex = 5;
            // 
            // listViewPurchases
            // 
            this.listViewPurchases.HideSelection = false;
            this.listViewPurchases.Location = new System.Drawing.Point(16, 153);
            this.listViewPurchases.MultiSelect = false;
            this.listViewPurchases.Name = "listViewPurchases";
            this.listViewPurchases.Size = new System.Drawing.Size(784, 310);
            this.listViewPurchases.TabIndex = 6;
            this.listViewPurchases.UseCompatibleStateImageBehavior = false;
            this.listViewPurchases.View = System.Windows.Forms.View.Details;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(257, 312);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 23);
            this.lblMessage.TabIndex = 7;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(125, 111);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(247, 22);
            this.dateTimePickerTo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "To:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "From:";
            // 
            // allItems_rb
            // 
            this.allItems_rb.AutoSize = true;
            this.allItems_rb.Checked = true;
            this.allItems_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allItems_rb.Location = new System.Drawing.Point(105, 21);
            this.allItems_rb.Name = "allItems_rb";
            this.allItems_rb.Size = new System.Drawing.Size(95, 24);
            this.allItems_rb.TabIndex = 9;
            this.allItems_rb.TabStop = true;
            this.allItems_rb.Text = "All Items";
            this.allItems_rb.UseVisualStyleBackColor = true;
            // 
            // date_rb
            // 
            this.date_rb.AutoSize = true;
            this.date_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_rb.Location = new System.Drawing.Point(224, 21);
            this.date_rb.Name = "date_rb";
            this.date_rb.Size = new System.Drawing.Size(119, 24);
            this.date_rb.TabIndex = 10;
            this.date_rb.Text = "Date Range";
            this.date_rb.UseVisualStyleBackColor = true;
            // 
            // price_rb
            // 
            this.price_rb.AutoSize = true;
            this.price_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_rb.Location = new System.Drawing.Point(367, 21);
            this.price_rb.Name = "price_rb";
            this.price_rb.Size = new System.Drawing.Size(122, 24);
            this.price_rb.TabIndex = 11;
            this.price_rb.Text = "Price Range";
            this.price_rb.UseVisualStyleBackColor = true;
            // 
            // searchOptionsgroupBox
            // 
            this.searchOptionsgroupBox.Controls.Add(this.allItems_rb);
            this.searchOptionsgroupBox.Controls.Add(this.date_rb);
            this.searchOptionsgroupBox.Controls.Add(this.price_rb);
            this.searchOptionsgroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchOptionsgroupBox.Location = new System.Drawing.Point(146, 12);
            this.searchOptionsgroupBox.Name = "searchOptionsgroupBox";
            this.searchOptionsgroupBox.Size = new System.Drawing.Size(531, 51);
            this.searchOptionsgroupBox.TabIndex = 13;
            this.searchOptionsgroupBox.TabStop = false;
            this.searchOptionsgroupBox.Text = "Search By:";
            // 
            // PastItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 501);
            this.Controls.Add(this.searchOptionsgroupBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.listViewPurchases);
            this.Controls.Add(this.txtBoxMaxPrice);
            this.Controls.Add(this.txtBoxMinPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Name = "PastItemsForm";
            this.Text = "Past Purchases";
            this.Load += new System.EventHandler(this.PastItemsForm_Load);
            this.searchOptionsgroupBox.ResumeLayout(false);
            this.searchOptionsgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxMinPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxMaxPrice;
        private System.Windows.Forms.ListView listViewPurchases;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton allItems_rb;
        private System.Windows.Forms.RadioButton date_rb;
        private System.Windows.Forms.RadioButton price_rb;
        private System.Windows.Forms.GroupBox searchOptionsgroupBox;
    }
}