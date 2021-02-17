using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BTL;

namespace BTL
{
    public partial class frmThem_Album : Form
    {
        public frmThem_Album()
        {
            InitializeComponent();
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtMaalbum.Text = "";
            txtTenalbum.Text = "";
            txtMaalbum.Focus();
        }

        private void btnDongy_Click(object sender, EventArgs e)
        {
            tblAlbum objAlbum;
            try
            {
                objAlbum = new tblAlbum(txtMaalbum.Text, txtTenalbum.Text,txtNamphathanh.Text);
            }
            catch (Exception ex)
            {
                string erro = ex.Message;
                MessageBox.Show(erro, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (erro.Contains("mã"))
                    txtMaalbum.Focus();
                else if(erro.Contains("tên"))
                    txtTenalbum.Focus();
                return;
            }
            tblAlbum objALbum = new tblAlbum(txtMaalbum.Text, txtTenalbum.Text, txtNamphathanh.Text);
            int result = objALbum.themAlbum();
            if (result == 0)
                MessageBox.Show("Thêm Album [" + txtTenalbum.Text + "] thành công!");
            else
                MessageBox.Show("Chưa thêm được Album mới!");
            this.DialogResult = DialogResult.OK;
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmThem_Album_Load(object sender, EventArgs e)
        {

        }
    }
}
