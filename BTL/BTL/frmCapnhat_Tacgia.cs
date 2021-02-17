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
    public partial class frmCapnhat_Tacgia : Form
    {
        public frmCapnhat_Tacgia()
        {
            InitializeComponent();
        }
        public string matacgia, tentacgia;
        private void frmCapnhat_Tacgia_Load(object sender, EventArgs e)
        {
            txtMatacgia.Text=matacgia;
            txtTentacgia.Text = tentacgia;
            txtMatacgia.SelectAll();
            txtMatacgia.Focus();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            tblTacgia objtacgia;
            try
            {
                objtacgia = new tblTacgia(txtMatacgia.Text,txtTentacgia.Text);
            }
            catch (Exception ex)
            {
                string erro = ex.Message;
                MessageBox.Show(erro, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (erro.Contains("mã"))
                    txtMatacgia.Focus();
                else
                    txtTentacgia.Focus();
                return;
            }
            tblTacgia objTacgia = new tblTacgia(txtMatacgia.Text,txtTentacgia.Text);
            int result = objTacgia.capnhapTacgia();
            if (result==0)
                MessageBox.Show("Cập nhật Tác giả[" + txtTentacgia.Text + "] thành công!");
            else
                MessageBox.Show("Cập nhật thất bại.Mời bạn cập nhật lại!");
            this.DialogResult = DialogResult.OK;
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtMatacgia.Text = "";
            txtTentacgia.SelectAll();
            txtTentacgia.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

     


    }
}
