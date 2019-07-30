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
    public partial class FormListProducts : Form
    {
        private Boolean addFlag = true;
        public FormListProducts()
        {
            InitializeComponent();
        }

        private void bntShow_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataProcess data = new DataProcess();
            dgvListProduct.DataSource = data.ShowProducts();
        }

        private void FormListProducts_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            DataProcess dp = new DataProcess();
            dgvListProduct.DataSource = dp.SearchP(id);
            dgvProductDetails.DataSource = dp.SearchDetailedProduct(id);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            DataProcess dt = new DataProcess();
            if (dt.DeleteProduct(id) == true)
            {
                MessageBox.Show("Delete success!!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void dgvListProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.ReadOnly = true;
            txtName.ReadOnly = true;
            int p;
            p = dgvListProduct.CurrentRow.Index;
            txtID.Text = dgvListProduct.Rows[p].Cells[0].Value.ToString();
            txtName.Text = dgvListProduct.Rows[p].Cells[1].Value.ToString();
            txtPIn.Text = dgvListProduct.Rows[p].Cells[2].Value.ToString();
            txtPOut.Text = dgvListProduct.Rows[p].Cells[3].Value.ToString();
            rtbCmt.Text = dgvListProduct.Rows[p].Cells[4].Value.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
            txtID.ReadOnly = false;
            txtName.ReadOnly = false;
            txtID.Text = "";
            txtName.Text = "";
            txtPIn.Text = "";
            txtPOut.Text = "";
            rtbCmt.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (addFlag)
            {
                SetEditable(false);
                btnEdit.Text = "Save";
            }
            else
            {
                string id = txtID.Text;
                string p_in = txtPIn.Text;
                string p_out = txtPOut.Text;
                string cmt = rtbCmt.Text;
                DataProcess dt = new DataProcess();
                dgvListProduct.DataSource = dt.EditProduct(id, p_in, p_out, cmt);
                btnEdit.Text = "Edit";
                
            }
            addFlag = !addFlag;
            
        }

        private void SetEditable(bool v)
        {
            txtName.ReadOnly = v;
            txtPIn.ReadOnly = v;
            txtPOut.ReadOnly = v;
            rtbCmt.ReadOnly = v;
        }

        private void dgvProductDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
