using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BTL
{
    public partial class frmThem_Tacgia : Form
    {
        public frmThem_Tacgia()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tblTacgia objtacgia;
            try
            {
                objtacgia = new tblTacgia(txtMatacgia.Text, txtTentacgia.Text);
            }catch(Exception ex)
            {
                string erro = ex.Message;
                MessageBox.Show(erro, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (erro.Contains("mã"))
                    txtMatacgia.Focus();
                else
                    txtTentacgia.Focus();
                return;
            }
            tblTacgia objTacgia = new tblTacgia(txtMatacgia.Text, txtTentacgia.Text);
            int result = objTacgia.themTacGia();
            if (result == 0)
                MessageBox.Show("Thêm tác giả [" + txtTentacgia.Text + "] thành công!");
            else
                MessageBox.Show("Chưa thêm được tác giả!");
            this.DialogResult = DialogResult.OK;
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtMatacgia.Text = "";
            txtTentacgia.Text = "";
            txtMatacgia.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmThem_Tacgia_Load(object sender, EventArgs e)
        {

        }
    }
}
