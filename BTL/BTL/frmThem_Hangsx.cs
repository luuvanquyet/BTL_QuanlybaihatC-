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
    public partial class frmThem_Hangsx : Form
    {
        public frmThem_Hangsx()
        {
            InitializeComponent();
        }

        private void btnDongy_Click(object sender, EventArgs e)
        {
            tblHangsanxuat objhangsx;
            try 
            {
                objhangsx = new tblHangsanxuat(txtMahangsx.Text, txtTenhangsx.Text);
            }
            catch (Exception ex) 
            {
                string erro = ex.Message;
                MessageBox.Show(erro, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (erro.Contains("mã"))
                    txtMahangsx.Focus();
                else
                    txtTenhangsx.Focus();
                return;
            }
            tblHangsanxuat objHangsx = new tblHangsanxuat(txtMahangsx.Text, txtTenhangsx.Text);
            int result = objHangsx.themNhaSX();
            if (result==0)
                MessageBox.Show("Thêm nhà sản xuất [" + txtTenhangsx.Text + "] thành công !");
            else
                MessageBox.Show("Chưa thêm được nhà sản xuất mới!");
            this.DialogResult = DialogResult.OK;

        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtMahangsx.Text = "";
            txtTenhangsx.Text = "";
            txtMahangsx.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
