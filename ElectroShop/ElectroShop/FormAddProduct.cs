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
    public partial class FormAddProduct : Form
    {
        public FormAddProduct()
        {
            InitializeComponent();
        }

        private void FormAddProduct_Load(object sender, EventArgs e)
        {

        }

        private void FormAddProduct_Click(object sender, EventArgs e)
        {
            DataProcess dt = new DataProcess();
            List<Supplier> list = dt.ListSuppliers();
            cbSupplier.DataSource = list;
            cbSupplier.DisplayMember = "Name";
            cbSupplier.ValueMember = "ID";
            cbSupplier.SelectedIndex = 0;

            //DataProcess dt = new DataProcess();
            List<Category> list1 = dt.ListCategorys();
            cbCategory.DataSource = list1;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "ID";
            cbCategory.SelectedIndex = 0;
        }

        private void btnBrower_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "File ảnh (*.jpg)|*.jpg| Ảnh khác (*.png)|*.png| Chọn tất (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtImg.Text = openFileDialog1.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtName.Text;
            string supplier = (cbSupplier.SelectedItem as Supplier).ID;
            string category = (cbCategory.SelectedItem as Category).ID;
            float p_in = float.Parse(txtPIn.Text);
            float p_out = float.Parse(txtPOut.Text);
            string img = System.IO.Path.GetFileName(openFileDialog1.FileName);
            string cmt = rtbCmt.Text;
            DataProcess dt = new DataProcess();
            if (dt.AddProduct(id, name, supplier, category, p_in, p_out, img, cmt) == true)
            {
                string path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                System.IO.File.Copy(openFileDialog1.FileName, path + "\\image\\" + img);
                MessageBox.Show("Add successful product");
                LoadData();
            }
            else
            {
                MessageBox.Show("Error!!!!");
            }
        }

        private void LoadData()
        {
            
        }
    }
}
