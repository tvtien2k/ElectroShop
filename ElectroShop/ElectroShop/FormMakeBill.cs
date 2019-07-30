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
    public partial class FormMakeBill : Form
    {
        private float TotalAmount = 0;
        private DataTable cart = null;
        public string CurrentAccount = null;
        public FormMakeBill()
        {
            InitializeComponent();
            dgvProduct.AutoGenerateColumns = false;
            cart = new DataTable();
            cart.Columns.Add(new DataColumn("_id", typeof(string)));
            cart.Columns.Add(new DataColumn("_name", typeof(string)));
            cart.Columns.Add(new DataColumn("_q", typeof(int)));
            cart.Columns.Add(new DataColumn("_price", typeof(float)));
            DataColumn col = new DataColumn("_total", typeof(float));
            col.Expression = "_price*_q";
            cart.Columns.Add(col);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txtProductID.Text;
            DataProcess dt = new DataProcess();
            Product p = dt.SearchProduct(id);
            if (p == null)
            {
                MessageBox.Show("Product not found");
                btnAddToBill.Enabled = false;
                btnMakeBill.Enabled = false;
            }
            else
            {
                txtNameP.Text = p.Name;
                txtPriceP.Text = p.POut.ToString();
                btnAddToBill.Enabled = true;
                btnMakeBill.Enabled = true;
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            int amount = int.Parse(txtAmount.Text);
            float total = amount * float.Parse(txtPriceP.Text);
            txtTotalP.Text = total.ToString();
        }

        private void btnAddToBill_Click(object sender, EventArgs e)
        {
            DataRow dr = cart.NewRow();
            dr[0] = txtProductID.Text;
            dr[1] = txtNameP.Text;
            dr[2] = txtAmount.Text;
            dr[3] = txtPriceP.Text;
            int q = int.Parse(txtAmount.Text);
            float total = float.Parse(txtPriceP.Text) * q;
            TotalAmount += total;
            MessageBox.Show("Total bill: " + TotalAmount.ToString());
            cart.Rows.Add(dr);
            dgvProduct.DataSource = cart;
        }
        
        private void btnMakeBill_Click(object sender, EventArgs e)
        {
            string b_id = txtBillID.Text;
            string s_id = CurrentAccount;
            string cus_name = txtNameC.Text;
            string cus_phone = txtPhoneC.Text;
            string email = txtEmailC.Text;
            string add = rtbAddC.Text;
            string cmt = rtbCmt.Text;
            DataProcess dt = new DataProcess();
            if (dt.AddBill(b_id, s_id, cus_name, cus_phone, email, add, TotalAmount, cmt, cart))
            {
                MessageBox.Show("Order Success");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMakeBill_Load(object sender, EventArgs e)
        {
            
        }

    }
}
