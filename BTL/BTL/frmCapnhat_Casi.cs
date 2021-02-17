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
    public partial class frmCapnhat_Casi : Form
    {
        public frmCapnhat_Casi()
        {
            InitializeComponent();
        }
        public string macasi, tencasi;


        private void frmCapnhat_Casi_Load(object sender, EventArgs e)
        {
            txtMacasi.Text = macasi;
            txtTenCasi.Text = tencasi;
        }

        private void btnDongy_Click(object sender, EventArgs e)
        {
    
            tblCaSi objcasi;
            try
            {
                objcasi = new tblCaSi(txtMacasi.Text, txtTenCasi.Text);
            }
            catch(Exception ex)
            {
                string erro = ex.Message;
                MessageBox.Show(erro, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (erro.Contains("mã"))
                    txtMacasi.Focus();
                else
                    txtTenCasi.Focus();
                return;
            }
            tblCaSi objCasi = new tblCaSi(txtMacasi.Text,txtTenCasi.Text);
            int result = objCasi.capnhapCaSi();
            if (result==0)
                MessageBox.Show("Cập nhật ca sĩ [" + txtTenCasi.Text + "] thành công!");
            else
                MessageBox.Show("Cập nhật thất bại");
            this.DialogResult = DialogResult.OK;
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtMacasi.Text = "";
            txtTenCasi.SelectAll();
            txtTenCasi.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
