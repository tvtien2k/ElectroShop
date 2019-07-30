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
    public partial class FormListBill : Form
    {
        public FormListBill()
        {
            InitializeComponent();
        }

        private void FormListBill_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataProcess data = new DataProcess();
            dgvListBill.DataSource = data.ShowBill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            DataProcess dp = new DataProcess();
            dgvListBill.DataSource = dp.SearchBill(id);
            dgvDetailsBill.DataSource = dp.SearchDetailedBill(id);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            DataProcess dt = new DataProcess();
            if (dt.DeleteBill(id) == true)
            {
                MessageBox.Show("Delete success!!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void dgvListBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int b;
            b = dgvListBill.CurrentRow.Index;
            txtID.Text = dgvListBill.Rows[b].Cells[0].Value.ToString();
        }
    }
}
