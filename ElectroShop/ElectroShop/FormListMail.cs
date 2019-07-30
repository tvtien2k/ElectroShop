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
    public partial class FormListMail : Form
    {
        public FormListMail()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataProcess data = new DataProcess();
            dgvListMail.DataSource = data.ShowMail();
        }
    }
}
