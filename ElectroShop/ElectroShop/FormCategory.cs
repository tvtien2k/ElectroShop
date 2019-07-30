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
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtName.Text;
            string cmt = rtbCmt.Text;
            DataProcess dt = new DataProcess();
            dgvCategory.DataSource = dt.AddCategory(id, name, cmt);
        }

        private void bntShow_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataProcess data = new DataProcess();
            dgvCategory.DataSource = data.GetCategory();
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {

        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.ReadOnly = true;
            int c;
            c = dgvCategory.CurrentRow.Index;
            txtID.Text = dgvCategory.Rows[c].Cells[0].Value.ToString();
            txtName.Text = dgvCategory.Rows[c].Cells[1].Value.ToString();
            rtbCmt.Text = dgvCategory.Rows[c].Cells[2].Value.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtID.ReadOnly = false;
            txtID.Text = "";
            txtName.Text = "";
            rtbCmt.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtName.Text;
            string cmt = rtbCmt.Text;
            DataProcess dt = new DataProcess();
            dgvCategory.DataSource = dt.EditCategory(id, name, cmt);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            DataProcess dp = new DataProcess();
            dgvCategory.DataSource = dp.SearchCategory(id);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            DataProcess dt = new DataProcess();
            if (dt.DeleteCategory(id) == true)
            {
                MessageBox.Show("Delete success!!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
