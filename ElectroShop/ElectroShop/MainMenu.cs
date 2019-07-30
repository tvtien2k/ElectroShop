using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectroShop
{
    public partial class MainMenu : Form
    {
        private Staff Current_Account = null;

        private FormHome fHome = null;

        private FormSuppliers fSuppliers = null;
        private FormCategory fCategory = null;
        private FormAddProduct fAddProduct = null;
        private FormListProducts fListProducts = null;
        private FormAddStaff fAddStaff = null;
        private FormListStaff fListStaff = null;
        private FormMakeBill fMakeBill = null;
        private FormListBill fListBill = null;
        private FormListMail fListMail = null;
        private FormReport fReport = null;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fSuppliers == null)
            {
                fSuppliers = new FormSuppliers();
            }
            fSuppliers.MdiParent = this;
            fSuppliers.Show();
            fSuppliers.Activate();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            FormLogin lg = new FormLogin();
            lg.ShowDialog();
            this.Current_Account = lg.Account;
            if (Current_Account.Power.Equals("admin"))
            {
                suppliersToolStripMenuItem.Enabled = true;
                categorysToolStripMenuItem.Enabled = true;
                addNewProductsToolStripMenuItem.Enabled = true;
                listOfProductsToolStripMenuItem.Enabled = true;

                MakeBillsToolStripMenuItem.Enabled = true;
                listBillsToolStripMenuItem.Enabled = true;

                addStaffToolStripMenuItem.Enabled = true;
                listStaffsToolStripMenuItem.Enabled = true;

                customerEmailToolStripMenuItem.Enabled = true;
                reportToolStripMenuItem.Enabled = true;
            }
            if (Current_Account.Power.Equals("Sales staff"))
            {
                MakeBillsToolStripMenuItem.Enabled = true;
                listBillsToolStripMenuItem.Enabled = true;

                reportToolStripMenuItem.Enabled = true;
            }
            if (Current_Account.Power.Equals("Warehouse staff"))
            {
                suppliersToolStripMenuItem.Enabled = true;
                categorysToolStripMenuItem.Enabled = true;
                addNewProductsToolStripMenuItem.Enabled = true;
                listOfProductsToolStripMenuItem.Enabled = true;  
            }

            //Load FormHome
            if (fHome == null)
            {
                fHome = new FormHome();
            }
            fHome.Current_acc = this.Current_Account.User;
            fHome.MdiParent = this;
            fHome.Show();
            fHome.Activate();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void billsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categorysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fCategory == null)
            {
                fCategory = new FormCategory();
            }
            fCategory.MdiParent = this;
            fCategory.Show();
            fCategory.Activate();
        }

        private void addNewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fAddProduct == null)
            {
                fAddProduct = new FormAddProduct();
            }
            fAddProduct.MdiParent = this;
            fAddProduct.Show();
            fAddProduct.Activate();
        }

        private void listOfProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fListProducts == null)
            {
                fListProducts = new FormListProducts();
            }
            fListProducts.MdiParent = this;
            fListProducts.Show();
            fListProducts.Activate();
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fAddStaff == null)
            {
                fAddStaff = new FormAddStaff();
            }
            fAddStaff.MdiParent = this;
            fAddStaff.Show();
            fAddStaff.Activate();
        }

        private void listStaffsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fListStaff == null)
            {
                fListStaff = new FormListStaff();
            }
            fListStaff.MdiParent = this;
            fListStaff.Show();
            fListStaff.Activate();
        }

        private void addNewBillToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listOfBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fMakeBill == null)
            {
                fMakeBill = new FormMakeBill();
            }
            fMakeBill.CurrentAccount = this.Current_Account.User;
            fMakeBill.MdiParent = this;
            fMakeBill.Show();
            fMakeBill.Activate();
        }

        private void listBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fListBill == null)
            {
                fListBill = new FormListBill();
            }
            fListBill.MdiParent = this;
            fListBill.Show();
            fListBill.Activate();
        }

        private void customerEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fListMail == null)
            {
                fListMail = new FormListMail();
            }
            fListMail.MdiParent = this;
            fListMail.Show();
            fListMail.Activate();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fReport == null)
            {
                fReport = new FormReport();
            }
            fReport.MdiParent = this;
            fReport.Show();
            fReport.Activate();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fHome == null)
            {
                fHome = new FormHome();
            }
            fHome.MdiParent = this;
            fHome.Show();
            fHome.Activate();
        }
    }
}
