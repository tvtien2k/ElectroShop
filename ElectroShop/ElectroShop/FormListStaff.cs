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
    public partial class FormListStaff : Form
    {
        public FormListStaff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataProcess data = new DataProcess();
            dgvStaff.DataSource = data.ShowStaff();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            DataProcess dp = new DataProcess();
            dgvStaff.DataSource = dp.SearchStaff(id);
        }
    }
}
