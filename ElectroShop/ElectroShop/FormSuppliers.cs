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
    public partial class FormSuppliers : Form
    {
        public FormSuppliers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtName.Text;
            string cmt = rtbCmt.Text;
            DataProcess dt = new DataProcess();
            dgvSupplier.DataSource = dt.AddSupplier(id, name, cmt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataProcess data = new DataProcess();
            dgvSupplier.DataSource = data.GetSupplier();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtID.ReadOnly = false;
            txtID.Text = "";
            txtName.Text = "";
            rtbCmt.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            DataProcess dp = new DataProcess();
            dgvSupplier.DataSource = dp.SearchSupplier(id);
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtName.Text;
            string cmt = rtbCmt.Text;
            DataProcess dt = new DataProcess();
            dgvSupplier.DataSource = dt.EditSupplier(id, name, cmt);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.ReadOnly = true;
            int s;
            s = dgvSupplier.CurrentRow.Index;
            txtID.Text = dgvSupplier.Rows[s].Cells[0].Value.ToString();
            txtName.Text = dgvSupplier.Rows[s].Cells[1].Value.ToString();
            rtbCmt.Text = dgvSupplier.Rows[s].Cells[2].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            DataProcess dt = new DataProcess();
            if (dt.DeleteSupplier(id) == true)
            {
                MessageBox.Show("Delete success!!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
