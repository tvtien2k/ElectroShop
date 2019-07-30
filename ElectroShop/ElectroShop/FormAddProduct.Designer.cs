namespace ElectroShop
{
    partial class FormAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddProduct));
            this.btAdd = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.rtbCmt = new System.Windows.Forms.RichTextBox();
            this.btnBrower = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtImg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPIn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPOut = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdd.ImageIndex = 0;
            this.btAdd.ImageList = this.imageList1;
            this.btAdd.Location = new System.Drawing.Point(362, 389);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 27);
            this.btAdd.TabIndex = 40;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            // 
            // rtbCmt
            // 
            this.rtbCmt.Location = new System.Drawing.Point(124, 315);
            this.rtbCmt.Name = "rtbCmt";
            this.rtbCmt.Size = new System.Drawing.Size(356, 68);
            this.rtbCmt.TabIndex = 39;
            this.rtbCmt.Text = "";
            // 
            // btnBrower
            // 
            this.btnBrower.Location = new System.Drawing.Point(362, 272);
            this.btnBrower.Name = "btnBrower";
            this.btnBrower.Size = new System.Drawing.Size(75, 23);
            this.btnBrower.TabIndex = 38;
            this.btnBrower.Text = "Browser";
            this.btnBrower.UseVisualStyleBackColor = true;
            this.btnBrower.Click += new System.EventHandler(this.btnBrower_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(124, 153);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(208, 21);
            this.cbCategory.TabIndex = 37;
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(124, 111);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(208, 21);
            this.cbSupplier.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(513, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 308);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Comment";
            // 
            // txtImg
            // 
            this.txtImg.Location = new System.Drawing.Point(124, 275);
            this.txtImg.Name = "txtImg";
            this.txtImg.Size = new System.Drawing.Size(208, 20);
            this.txtImg.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Image";
            // 
            // txtPIn
            // 
            this.txtPIn.Location = new System.Drawing.Point(124, 197);
            this.txtPIn.Name = "txtPIn";
            this.txtPIn.Size = new System.Drawing.Size(208, 20);
            this.txtPIn.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Price in";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Supplier";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 20);
            this.txtName.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Name";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(124, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(208, 20);
            this.txtID.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Price out";
            // 
            // txtPOut
            // 
            this.txtPOut.Location = new System.Drawing.Point(124, 237);
            this.txtPOut.Name = "txtPOut";
            this.txtPOut.Size = new System.Drawing.Size(208, 20);
            this.txtPOut.TabIndex = 32;
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.rtbCmt);
            this.Controls.Add(this.btnBrower);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtImg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPOut);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAddProduct";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.FormAddProduct_Load);
            this.Click += new System.EventHandler(this.FormAddProduct_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.RichTextBox rtbCmt;
        private System.Windows.Forms.Button btnBrower;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtImg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPOut;
        private System.Windows.Forms.ImageList imageList1;
    }
}