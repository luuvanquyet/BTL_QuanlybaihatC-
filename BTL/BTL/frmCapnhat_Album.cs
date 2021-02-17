using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL;
using System.Data.SqlClient;
namespace BTL
{
    public partial class frmCapnhat_Album : Form
    {
        public frmCapnhat_Album()
        {
            InitializeComponent();
        }
        public string maalbum, tenalbum, namphath;
        private void btnThoatCapnhat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmCapnhat_Album_Load(object sender, EventArgs e)
        {

            txtMaalbum.Text = maalbum;
            txtTenalbum.Text = tenalbum;
            txtNamphathanh.Text = namphath;
            txtTenalbum.SelectAll();
            txtTenalbum.Focus();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDongy_Click(object sender, EventArgs e)
        {
            tblAlbum objAbum;
            try
            {
                objAbum = new tblAlbum(txtMaalbum.Text, txtTenalbum.Text, txtNamphathanh.Text);
            }
            catch (Exception ex)
            {
                string loi = ex.Message;
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (loi.Contains("mã"))
                    txtMaalbum.Focus();
                else if (loi.Contains("tên"))
                    txtTenalbum.Focus();
                return;
            }
            tblAlbum a = new tblAlbum(txtMaalbum.Text,txtTenalbum.Text,txtNamphathanh.Text);
            int resutl = a.capnhatalbum();
            if (resutl == 0)
                MessageBox.Show("Cập nhật thành công album [" + txtTenalbum.Text + "] với mã album là [" + txtMaalbum.Text + "]");
            else
                MessageBox.Show("That bai");

            this.DialogResult = DialogResult.OK;

        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtTenalbum.Clear(); txtTenalbum.Focus();
        }

       
    }
}
