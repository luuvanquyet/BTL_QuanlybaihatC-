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
    public partial class frmCapnhat_Hangsx : Form
    {
        public frmCapnhat_Hangsx()
        {
            InitializeComponent();
        }

        public string manhasx, tennhasx;
   

     

        private void btnDongy_Click(object sender, EventArgs e)
        {
            tblHangsanxuat objhangsx;
            try
            {
                objhangsx = new tblHangsanxuat(txtManhasx.Text, txtTenNhasx.Text);
            }
            catch (Exception ex)
            {
                string erro = ex.Message;
                MessageBox.Show(erro,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                if (erro.Contains("mã"))
                    txtManhasx.Focus();
                else
                {
                    txtTenNhasx.Focus();
                }
                return;
            }
            tblHangsanxuat objhang = new tblHangsanxuat(txtManhasx.Text, txtTenNhasx.Text);
            int result = objhang.capnhapNhaSX();
            if (result==0)
                MessageBox.Show("Cập nhật thành công [" + txtTenNhasx.Text + "] thành công!");
            else
                MessageBox.Show("Cập nhật thất bại.Mời bạn làm lại!");
            this.DialogResult = DialogResult.OK;
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtManhasx.Text = "";
            txtTenNhasx.SelectAll();
            txtTenNhasx.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmCapnhat_Nhasx_Load(object sender, EventArgs e)
        {
            txtManhasx.Text = manhasx;
            txtTenNhasx.Text = tennhasx;
        }
    }
}
