namespace SemesterProject
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.storeItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yourAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMainForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storeItemsToolStripMenuItem,
            this.purchaseItemToolStripMenuItem,
            this.yourAccountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // storeItemsToolStripMenuItem
            // 
            this.storeItemsToolStripMenuItem.Name = "storeItemsToolStripMenuItem";
            this.storeItemsToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.storeItemsToolStripMenuItem.Text = "Items for Sale";
            this.storeItemsToolStripMenuItem.Click += new System.EventHandler(this.StoreItemsMenuClicked);
            // 
            // purchaseItemToolStripMenuItem
            // 
            this.purchaseItemToolStripMenuItem.Name = "purchaseItemToolStripMenuItem";
            this.purchaseItemToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.purchaseItemToolStripMenuItem.Text = "Purchased Item";
            this.purchaseItemToolStripMenuItem.Click += new System.EventHandler(this.PurchasedItemMenuClicked);
            // 
            // yourAccountToolStripMenuItem
            // 
            this.yourAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountBalanceToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.yourAccountToolStripMenuItem.Name = "yourAccountToolStripMenuItem";
            this.yourAccountToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.yourAccountToolStripMenuItem.Text = "Your Account";
            // 
            // accountBalanceToolStripMenuItem
            // 
            this.accountBalanceToolStripMenuItem.Name = "accountBalanceToolStripMenuItem";
            this.accountBalanceToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.accountBalanceToolStripMenuItem.Text = "Account Balance";
            this.accountBalanceToolStripMenuItem.Click += new System.EventHandler(this.AccountBalanceMenuClicked);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.SignOutMenuClicked);
            // 
            // panelMainForm
            // 
            this.panelMainForm.Controls.Add(this.label1);
            this.panelMainForm.Location = new System.Drawing.Point(0, 31);
            this.panelMainForm.Name = "panelMainForm";
            this.panelMainForm.Size = new System.Drawing.Size(800, 419);
            this.panelMainForm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMainForm);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Store";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMainForm.ResumeLayout(false);
            this.panelMainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem storeItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yourAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Panel panelMainForm;
        private System.Windows.Forms.Label label1;
    }
}