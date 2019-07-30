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
    public partial class FormAddStaff : Form
    {
        public FormAddStaff()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            string name = txtName.Text;
            string power = cbPower.Text;
            string sex = cbSex.Text;
            string add = txtAdd.Text;
            string phone = txtPhone.Text;
            DateTime birthday = DateTime.Parse(dtpBirthday.Text);
            string cmt = rtbCmt.Text;
            DataProcess dt = new DataProcess();
            dgvStaff.DataSource = dt.AddStaff( user,  pass,  name, power,  sex,  add,  phone,  birthday,  cmt);
        }
    }
}
