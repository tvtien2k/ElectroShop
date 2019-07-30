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
    public partial class FormLogin : Form
    {
        public Staff Account = null;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
        
        private void bntLogin_Click(object sender, EventArgs e)
        {
            string u = txtUser.Text;
            string p = txtPass.Text;
            DataProcess dt = new DataProcess();
            Staff temp = dt.CheckLogin(u, p);
            if (temp != null)
            {
                this.Account = temp;
                MessageBox.Show(this, "Logged in successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show(this, "Login failed", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
