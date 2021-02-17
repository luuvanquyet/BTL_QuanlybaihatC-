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
    public partial class frmCapnhat_Baihat : Form
    {
        public frmCapnhat_Baihat()
        {
            InitializeComponent();
        }

        private DataTable dtTheloai;
        private DataTable dtAlbum;
        private DataTable dtTacgia;
        private DataTable dtCasi;
        private DataTable dtHangsx;
        public string mabaihat, tenbaihat, loibaihat,matheloai,maalbum,matacgia,macasi,mahangsanxuat;
        private void frmCapnhat_Baihat_Load(object sender, EventArgs e)
        {
            txtMabaihat.Text = mabaihat;
            txtTenbaihat.Text = tenbaihat;
            txtLoibaihat.Text = loibaihat;
            txtTenbaihat.SelectAll();
            txtTenbaihat.Focus();
            dtTheloai = new tblTheloai().getTheLoai();
            cboTheloai.DataSource = dtTheloai;
            cboTheloai.DisplayMember = "TenTheLoai";
            cboTheloai.ValueMember = "MaTheLoai";

            dtAlbum = new tblAlbum().getAlbum();
            cboAlbum.DataSource = dtAlbum;
            cboAlbum.DisplayMember = "TenAlbum";
            cboAlbum.ValueMember = "MaAlbum";

            dtCasi = new tblCaSi().getCaSi();
            cboCasi.DataSource = dtCasi;
            cboCasi.DisplayMember = "TenCaSi";
            cboCasi.ValueMember = "MaCaSi";

            dtHangsx = new tblHangsanxuat().getNhaSanXuat();
            cbohangsx.DataSource = dtHangsx;
            cbohangsx.DisplayMember = "TenHangSanXuat";
            cbohangsx.ValueMember = "MaHangSanXuat";

            dtTacgia = new tblTacgia().getTacGia();
            cboTacgia.DataSource = dtTacgia;
            cboTacgia.DisplayMember = "TenTacGia";
            cboTacgia.ValueMember = "MaTacGia";

            cboTheloai.SelectedValue = matheloai;
            cboCasi.SelectedValue = macasi;
            cboTacgia.SelectedValue = matacgia;
            cboAlbum.SelectedValue = maalbum;
            cbohangsx.SelectedValue = mahangsanxuat;
        }

        private void btnDongy_Click(object sender, EventArgs e)
        {
            tblBaihat objbaihat;
            try
            {
                objbaihat = new tblBaihat(txtMabaihat.Text, txtTenbaihat.Text, cboTheloai.SelectedValue.ToString(), cboAlbum.SelectedValue.ToString(),cboCasi.SelectedValue.ToString(),cboTacgia.SelectedValue.ToString(),cbohangsx.SelectedValue.ToString(), txtLoibaihat.Text);
            }
            catch (Exception ex)
            {
                string erro = ex.Message;
                MessageBox.Show(erro, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (erro.Contains("mã"))
                    txtMabaihat.Focus();
                else if (erro.Contains("tên"))
                    txtTenbaihat.Focus();
                else
                    txtLoibaihat.Text = "Chưa có lời cho bài hát !";
                return;
            }
                tblBaihat objBaiHat = new tblBaihat(txtMabaihat.Text, txtTenbaihat.Text, cboTheloai.SelectedValue.ToString(), cboAlbum.SelectedValue.ToString(), cboCasi.SelectedValue.ToString(), cboTacgia.SelectedValue.ToString(),cbohangsx.SelectedValue.ToString(),txtLoibaihat.Text);
                int result = objBaiHat.capnhatBaiHat();
                if (result==0)
                    MessageBox.Show("Cập nhật thành công bài hát [" + txtTenbaihat.Text + "]");
                else
                    MessageBox.Show("Cập nhật thất bại");
                this.DialogResult = DialogResult.OK;
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtMabaihat.Text = "";
            txtTenbaihat.SelectAll();
            txtTenbaihat.Focus();
            cboAlbum.SelectedIndex = 0;
            cboCasi.SelectedIndex = 0;
            cbohangsx.SelectedIndex = 0;
            cboTacgia.SelectedIndex = 0;
            cboTheloai.SelectedIndex = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
