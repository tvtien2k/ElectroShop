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
    public partial class FormHome : Form
    {
        public string Current_acc = null;
        private FormMakeBill fMakeBill = null;
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            this.Text = "Welcome account : " + Current_acc;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataProcess data = new DataProcess();
            dgvListProduct.DataSource = data.ShowProducts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fMakeBill == null)
            {
                fMakeBill = new FormMakeBill();
            }
            fMakeBill.CurrentAccount = this.Current_acc;
            fMakeBill.Show();
            fMakeBill.Activate();
        }

    }
}
