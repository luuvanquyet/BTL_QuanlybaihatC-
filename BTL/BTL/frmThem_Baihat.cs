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
    public partial class frmThem_Baihat : Form
    {
        public frmThem_Baihat()
        {
            InitializeComponent();
        }
        private DataTable dtTheloai;
        private DataTable dtAlbum;
        private DataTable dtTacgia;
        private DataTable dtCasi;
        private DataTable dtHangsx;
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tblBaihat objbaihat;
            try
            {
                objbaihat = new tblBaihat(txtMabaihat.Text, txtTenbaihat.Text, cboTheloai.SelectedValue.ToString(), cboAlbum.SelectedValue.ToString(),cboCasi.SelectedValue.ToString(), cboTacgia.SelectedValue.ToString(), cboHangsx.SelectedValue.ToString(), txtLoibaihat.Text);
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
            tblBaihat objBaihat = new tblBaihat(txtMabaihat.Text, txtTenbaihat.Text, cboTheloai.SelectedValue.ToString(), cboAlbum.SelectedValue.ToString(), cboCasi.SelectedValue.ToString(), cboTacgia.SelectedValue.ToString(), cboHangsx.SelectedValue.ToString(), txtLoibaihat.Text);
            int result = objBaihat.themBaiHat();
            if (result==0)
                MessageBox.Show("Thêm bài hát [" + txtTenbaihat.Text + "] thành công!");
            else
                MessageBox.Show("Chưa thêm được bài hát mới!");
            this.DialogResult = DialogResult.OK;
        }



        private void frmThem_Baihat_Load(object sender, EventArgs e)
        {
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
            cboHangsx.DataSource = dtHangsx;
            cboHangsx.DisplayMember = "TenHangSanXuat";
            cboHangsx.ValueMember = "MaHangSanXuat";

            dtTacgia = new tblTacgia().getTacGia();
            cboTacgia.DataSource = dtTacgia;
            cboTacgia.DisplayMember = "TenTacGia";
            cboTacgia.ValueMember = "MaTacGia";
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtMabaihat.Text = "";
            txtTenbaihat.Text = "";
            txtLoibaihat.Text = "";
            txtMabaihat.Focus();

            cboTheloai.SelectedIndex = 0;
            cboAlbum.SelectedIndex = 0;
            cboTacgia.SelectedIndex = 0;
            cboCasi.SelectedIndex = 0;
            cboHangsx.SelectedIndex = 0;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
