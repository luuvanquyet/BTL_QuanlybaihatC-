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

namespace BTL
{
    public partial class frmCapnhat_Theloai : Form
    {
        public frmCapnhat_Theloai()
        {
            InitializeComponent();
        }
        public string matheloai, tentheloai;
        private void btnDongy_Click(object sender, EventArgs e)
        {
            tblTheloai objtheloai;
            try
            {
                objtheloai = new tblTheloai(txtMatheloai.Text, txtTentheloai.Text);
            }
            catch (Exception ex)
            {
                string erro = ex.Message;
                MessageBox.Show(erro, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (erro.Contains("mã"))
                    txtMatheloai.Focus();
                else
                    txtTentheloai.Focus();
                return;
            }
            tblTheloai objTheloai = new tblTheloai(txtMatheloai.Text, txtTentheloai.Text);
            int result = objTheloai.capnhatTheLoai();
            if (result==0)
            {
                MessageBox.Show("Cập nhật thành công [" + txtTentheloai.Text + "]!");
            }
            else
                MessageBox.Show("Cập nhật thất bại");
            this.DialogResult = DialogResult.OK;
        }

        private void frmCapnhat_Theloai_Load(object sender, EventArgs e)
        {
            txtMatheloai.Text = matheloai;
            txtTentheloai.Text = tentheloai;
            txtTentheloai.SelectAll();
            txtTentheloai.Focus();
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtMatheloai.Text = "";
            txtTentheloai.SelectAll();
            txtTentheloai.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
