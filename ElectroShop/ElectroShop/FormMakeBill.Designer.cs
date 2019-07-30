namespace ElectroShop
{
    partial class FormMakeBill
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMakeBill));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddToBill = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTotalP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPriceP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbCmt = new System.Windows.Forms.RichTextBox();
            this.rtbAddC = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmailC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhoneC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNameC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMakeBill = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddToBill);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtTotalP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPriceP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNameP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtProductID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(476, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search product";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAddToBill
            // 
            this.btnAddToBill.Enabled = false;
            this.btnAddToBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddToBill.ImageIndex = 0;
            this.btnAddToBill.ImageList = this.imageList1;
            this.btnAddToBill.Location = new System.Drawing.Point(123, 226);
            this.btnAddToBill.Name = "btnAddToBill";
            this.btnAddToBill.Size = new System.Drawing.Size(96, 23);
            this.btnAddToBill.TabIndex = 5;
            this.btnAddToBill.Text = "Add to bill";
            this.btnAddToBill.UseVisualStyleBackColor = true;
            this.btnAddToBill.Click += new System.EventHandler(this.btnAddToBill_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.ImageIndex = 1;
            this.btnSearch.ImageList = this.imageList1;
            this.btnSearch.Location = new System.Drawing.Point(211, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTotalP
            // 
            this.txtTotalP.Location = new System.Drawing.Point(83, 180);
            this.txtTotalP.Name = "txtTotalP";
            this.txtTotalP.ReadOnly = true;
            this.txtTotalP.Size = new System.Drawing.Size(115, 20);
            this.txtTotalP.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total";
            // 
            // txtPriceP
            // 
            this.txtPriceP.Location = new System.Drawing.Point(83, 134);
            this.txtPriceP.Name = "txtPriceP";
            this.txtPriceP.ReadOnly = true;
            this.txtPriceP.Size = new System.Drawing.Size(115, 20);
            this.txtPriceP.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Price";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(219, 152);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(67, 20);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount";
            // 
            // txtNameP
            // 
            this.txtNameP.Location = new System.Drawing.Point(83, 78);
            this.txtNameP.Name = "txtNameP";
            this.txtNameP.ReadOnly = true;
            this.txtNameP.Size = new System.Drawing.Size(176, 20);
            this.txtNameP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(83, 25);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(115, 20);
            this.txtProductID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbCmt);
            this.groupBox2.Controls.Add(this.rtbAddC);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtEmailC);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtPhoneC);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtNameC);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtBillID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 258);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bill information";
            // 
            // rtbCmt
            // 
            this.rtbCmt.Location = new System.Drawing.Point(282, 158);
            this.rtbCmt.Name = "rtbCmt";
            this.rtbCmt.Size = new System.Drawing.Size(158, 81);
            this.rtbCmt.TabIndex = 4;
            this.rtbCmt.Text = "";
            // 
            // rtbAddC
            // 
            this.rtbAddC.Location = new System.Drawing.Point(282, 47);
            this.rtbAddC.Name = "rtbAddC";
            this.rtbAddC.Size = new System.Drawing.Size(158, 81);
            this.rtbAddC.TabIndex = 3;
            this.rtbAddC.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(335, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Comment";
            this.label11.Click += new System.EventHandler(this.label7_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(313, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Customer address";
            this.label10.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtEmailC
            // 
            this.txtEmailC.Location = new System.Drawing.Point(114, 201);
            this.txtEmailC.Name = "txtEmailC";
            this.txtEmailC.Size = new System.Drawing.Size(131, 20);
            this.txtEmailC.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Email customer";
            this.label9.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtPhoneC
            // 
            this.txtPhoneC.Location = new System.Drawing.Point(114, 149);
            this.txtPhoneC.Name = "txtPhoneC";
            this.txtPhoneC.Size = new System.Drawing.Size(131, 20);
            this.txtPhoneC.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Customer phone";
            this.label8.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtNameC
            // 
            this.txtNameC.Location = new System.Drawing.Point(114, 97);
            this.txtNameC.Name = "txtNameC";
            this.txtNameC.Size = new System.Drawing.Size(131, 20);
            this.txtNameC.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Customer name";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtBillID
            // 
            this.txtBillID.Location = new System.Drawing.Point(114, 41);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.Size = new System.Drawing.Size(131, 20);
            this.txtBillID.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bill ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvProduct);
            this.groupBox3.Location = new System.Drawing.Point(12, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(662, 162);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List products";
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvProduct.Location = new System.Drawing.Point(7, 19);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(645, 143);
            this.dgvProduct.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "_id";
            this.Column1.HeaderText = "Product ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "_name";
            this.Column2.HeaderText = "Product name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "_q";
            this.Column3.HeaderText = "Amount";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "_price";
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "_total";
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // btnMakeBill
            // 
            this.btnMakeBill.Enabled = false;
            this.btnMakeBill.Location = new System.Drawing.Point(695, 309);
            this.btnMakeBill.Name = "btnMakeBill";
            this.btnMakeBill.Size = new System.Drawing.Size(75, 23);
            this.btnMakeBill.TabIndex = 2;
            this.btnMakeBill.Text = "Make bill";
            this.btnMakeBill.UseVisualStyleBackColor = true;
            this.btnMakeBill.Click += new System.EventHandler(this.btnMakeBill_Click);
            // 
            // btnExit
            // 
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.ImageIndex = 1;
            this.btnExit.Location = new System.Drawing.Point(695, 389);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "search.PNG");
            // 
            // FormMakeBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMakeBill);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormMakeBill";
            this.Text = "Make Bill";
            this.Load += new System.EventHandler(this.FormMakeBill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnMakeBill;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddToBill;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTotalP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPriceP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmailC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhoneC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNameC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBillID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbCmt;
        private System.Windows.Forms.RichTextBox rtbAddC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ImageList imageList1;
    }
}