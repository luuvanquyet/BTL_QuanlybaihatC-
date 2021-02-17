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
    public partial class frmThem_Casi : Form
    {
        public frmThem_Casi()
        {
            InitializeComponent();
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtMacasi.Text = "";
            txtTencasi.Text = "";
            txtMacasi.Focus();
        }

        private void btnDongy_Click(object sender, EventArgs e)
        {
            tblCaSi objcasi;
            try
            {
                objcasi = new tblCaSi(txtMacasi.Text, txtTencasi.Text);
            }
            catch (Exception ex)
            {
                string erro = ex.Message;
                MessageBox.Show(erro, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (erro.Contains("mã"))
                    txtMacasi.Focus();
                else
                    txtTencasi.Focus();
                return;
            }
            tblCaSi objCasi = new tblCaSi(txtMacasi.Text, txtTencasi.Text);
            int result = objCasi.themCaSi();
            if (result==0)
                MessageBox.Show("Thêm ca sĩ [" + txtTencasi.Text + "] thành công !");
            else
                MessageBox.Show("Chưa thêm được ca sĩ mới!");
            this.DialogResult = DialogResult.OK;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
