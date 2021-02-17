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
namespace BTL
{
    public partial class frmThem_Theloai : Form
    {
        public frmThem_Theloai()
        {
            InitializeComponent();
        }
        private void btnDongy_Click(object sender, EventArgs e)
        {
            tblTheloai objTheLoai;
            try
            {
                objTheLoai = new tblTheloai(txtMatheloai.Text, txtTentheloai.Text);
            }
            catch (Exception ex)
            {
                string loi = ex.Message;
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (loi.Contains("mã"))
                    txtMatheloai.Focus();
                else if (loi.Contains("tên"))
                    txtTentheloai.Focus();

                return;
            }
            tblTheloai tl = new tblTheloai(txtMatheloai.Text, txtTentheloai.Text);
            int resutl = tl.themTheLoai();
            if (resutl == 0)
                MessageBox.Show("Thêm thành công thể loại [" + txtTentheloai.Text + "] với mã thể loại là [" + txtMatheloai.Text + "]");
            else
                MessageBox.Show("That bai");
            this.DialogResult = DialogResult.OK;
           
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtMatheloai.Text = "";
            txtTentheloai.Text = "";
            txtMatheloai.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
