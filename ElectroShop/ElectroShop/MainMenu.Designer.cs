namespace ElectroShop
{
    partial class MainMenu
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
            System.Windows.Forms.ToolStripMenuItem staffsToolStripMenuItem;
            this.addStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listStaffsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categorysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MakeBillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            staffsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // staffsToolStripMenuItem
            // 
            staffsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStaffToolStripMenuItem,
            this.listStaffsToolStripMenuItem});
            staffsToolStripMenuItem.Name = "staffsToolStripMenuItem";
            staffsToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            staffsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            staffsToolStripMenuItem.Text = "Staffs";
            // 
            // addStaffToolStripMenuItem
            // 
            this.addStaffToolStripMenuItem.Enabled = false;
            this.addStaffToolStripMenuItem.Name = "addStaffToolStripMenuItem";
            this.addStaffToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addStaffToolStripMenuItem.Text = "Add staff";
            this.addStaffToolStripMenuItem.Click += new System.EventHandler(this.addStaffToolStripMenuItem_Click);
            // 
            // listStaffsToolStripMenuItem
            // 
            this.listStaffsToolStripMenuItem.Enabled = false;
            this.listStaffsToolStripMenuItem.Name = "listStaffsToolStripMenuItem";
            this.listStaffsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listStaffsToolStripMenuItem.Text = "List staffs";
            this.listStaffsToolStripMenuItem.Click += new System.EventHandler(this.listStaffsToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.productToolStripMenuItem,
            this.billsToolStripMenuItem,
            staffsToolStripMenuItem,
            this.statisticsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suppliersToolStripMenuItem,
            this.categorysToolStripMenuItem,
            this.addNewProductsToolStripMenuItem,
            this.listOfProductsToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productToolStripMenuItem.Text = "Products";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.Enabled = false;
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.suppliersToolStripMenuItem.Text = "Suppliers";
            this.suppliersToolStripMenuItem.Click += new System.EventHandler(this.suppliersToolStripMenuItem_Click);
            // 
            // categorysToolStripMenuItem
            // 
            this.categorysToolStripMenuItem.Enabled = false;
            this.categorysToolStripMenuItem.Name = "categorysToolStripMenuItem";
            this.categorysToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categorysToolStripMenuItem.Text = "Categorys";
            this.categorysToolStripMenuItem.Click += new System.EventHandler(this.categorysToolStripMenuItem_Click);
            // 
            // addNewProductsToolStripMenuItem
            // 
            this.addNewProductsToolStripMenuItem.Enabled = false;
            this.addNewProductsToolStripMenuItem.Name = "addNewProductsToolStripMenuItem";
            this.addNewProductsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewProductsToolStripMenuItem.Text = "Add product";
            this.addNewProductsToolStripMenuItem.Click += new System.EventHandler(this.addNewProductsToolStripMenuItem_Click);
            // 
            // listOfProductsToolStripMenuItem
            // 
            this.listOfProductsToolStripMenuItem.Enabled = false;
            this.listOfProductsToolStripMenuItem.Name = "listOfProductsToolStripMenuItem";
            this.listOfProductsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listOfProductsToolStripMenuItem.Text = "List products";
            this.listOfProductsToolStripMenuItem.Click += new System.EventHandler(this.listOfProductsToolStripMenuItem_Click);
            // 
            // billsToolStripMenuItem
            // 
            this.billsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MakeBillsToolStripMenuItem,
            this.listBillsToolStripMenuItem});
            this.billsToolStripMenuItem.Name = "billsToolStripMenuItem";
            this.billsToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.billsToolStripMenuItem.Text = "Bills";
            this.billsToolStripMenuItem.Click += new System.EventHandler(this.billsToolStripMenuItem_Click);
            // 
            // MakeBillsToolStripMenuItem
            // 
            this.MakeBillsToolStripMenuItem.Enabled = false;
            this.MakeBillsToolStripMenuItem.Name = "MakeBillsToolStripMenuItem";
            this.MakeBillsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.MakeBillsToolStripMenuItem.Text = "Make bill";
            this.MakeBillsToolStripMenuItem.Click += new System.EventHandler(this.listOfBillsToolStripMenuItem_Click);
            // 
            // listBillsToolStripMenuItem
            // 
            this.listBillsToolStripMenuItem.Enabled = false;
            this.listBillsToolStripMenuItem.Name = "listBillsToolStripMenuItem";
            this.listBillsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listBillsToolStripMenuItem.Text = "List bills";
            this.listBillsToolStripMenuItem.Click += new System.EventHandler(this.listBillsToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerEmailToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.statisticsToolStripMenuItem.Text = "Other";
            // 
            // customerEmailToolStripMenuItem
            // 
            this.customerEmailToolStripMenuItem.Enabled = false;
            this.customerEmailToolStripMenuItem.Name = "customerEmailToolStripMenuItem";
            this.customerEmailToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customerEmailToolStripMenuItem.Text = "Customer email";
            this.customerEmailToolStripMenuItem.Click += new System.EventHandler(this.customerEmailToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Enabled = false;
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 518);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "ElectroShop";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categorysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MakeBillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listStaffsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
    }
}

