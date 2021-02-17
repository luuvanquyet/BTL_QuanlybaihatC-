using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace BTL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DataTable dtBaihat_baihat;
        private DataTable dtBaihat;
        private DataTable dtAlbum;
        private DataTable dtTheloai;
        private DataTable dtHangsx;
        private DataTable dtCasi;
        private DataTable dtTacgia;
        private DataTable dtBaihat_home;
        private DataTable dtCasi_baihat;

        bool danapxong_lstBox = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            load_BaiHat_home();
            load_Album();
            load_TheLoai();
            load_Casi();
            load_TacGia();
            load_NhaSanXuat();

            load_combobox_baihat();
            load_Baihat();


            danapxong_lstBox = true;
        }
        private void STT(ListView lview)
        {
            for (int i = 1; i <= lview.Items.Count; i++)
            {
                lview.Items[i - 1].Text = i.ToString();
                lview.Items[i - 1].ImageIndex = 0;
                if (i % 2 != 0)
                    lview.Items[i - 1].BackColor = Color.LightBlue;
            }
        }
        #region Load dữ liệu
        private void load_Baihat()
        {
            dtBaihat_baihat = new tblBaihat().getBaiHat();
            foreach (DataRow i in dtBaihat_baihat.Rows)
            {
                ListViewItem list = lvBaihat.Items.Add("");
                list.SubItems.Add(i["TenBaiHat"].ToString());
                list.SubItems.Add(i["LoiBaiHat"].ToString());
                list.Tag = i["MaBaiHat"];
            }
            STT(lvBaihat);
        }
        private void load_combobox_baihat()
        {

            cboTheloai.DataSource = dtTheloai;
            cboTheloai.DisplayMember = "TenTheLoai";
            cboTheloai.ValueMember = "MaTheLoai";

            cboAlbum.DataSource = dtAlbum;
            cboAlbum.DisplayMember = "TenAlbum";
            cboAlbum.ValueMember = "MaAlbum";

            cboCasi.DataSource = dtCasi;
            cboCasi.DisplayMember = "TenCaSi";
            cboCasi.ValueMember = "MaCaSi";

            CboTacgia.DataSource = dtTacgia;
            CboTacgia.DisplayMember = "TenTacGia";
            CboTacgia.ValueMember = "MaTacGia";

            CboHangsx.DataSource = dtHangsx;
            CboHangsx.DisplayMember = "TenHangSanXuat";
            CboHangsx.ValueMember = "MaHangSanXuat";

        }

        private void load_BaiHat_home()
        {
            dtBaihat_home = new tblBaihat().getBaiHat_home();
            foreach (DataRow dr in dtBaihat_home.Rows)
            {
                ListViewItem li = lvwBaihat_home.Items.Add("");
                li.SubItems.Add(dr["TenBaiHat"].ToString());
                li.SubItems.Add(dr["TenTheLoai"].ToString());
                li.SubItems.Add(dr["TenAlbum"].ToString());
                li.SubItems.Add(dr["NamPhatHanh"].ToString());
                li.SubItems.Add(dr["TenCaSi"].ToString());
                li.SubItems.Add(dr["TenTacGia"].ToString());
                li.SubItems.Add(dr["TenHangSanXuat"].ToString());
                li.SubItems.Add(dr["LoiBaiHat"].ToString());
                li.Tag = dr["MaBaiHat"];
            }
            STT(lvwBaihat_home);
        }
        private void load_NhaSanXuat()
        {
            dtHangsx = new tblHangsanxuat().getNhaSanXuat();
            listHangsx.DataSource = dtHangsx;
            listHangsx.DisplayMember = "TenHangSanXuat";
            listHangsx.ValueMember = "MaHangSanXuat";
        }

        private void load_TacGia()
        {
            dtTacgia = new tblTacgia().getTacGia();
            listNhacsi.DataSource = dtTacgia;
            listNhacsi.DisplayMember = "TenTacGia";
            listNhacsi.ValueMember = "MaTacGia";
        }

        private void load_Casi()
        {
            dtCasi = new tblCaSi().getCaSi();
            listCasi.DataSource = dtCasi;
            listCasi.DisplayMember = "TenCaSi";
            listCasi.ValueMember = "MaCaSi";

        }
        private void load_TheLoai()
        {
            dtTheloai = new tblTheloai().getTheLoai();
            foreach (DataRow dr in dtTheloai.Rows)
            {
                ListViewItem li = lvwTheloai.Items.Add("");
                li.SubItems.Add(dr["TenTheLoai"].ToString());

                li.Tag = dr["MaTheLoai"];
            }
            STT(lvwTheloai);
        }
        private void load_Album()
        {
            dtAlbum = new tblAlbum().getAlbum();
            foreach (DataRow dr in dtAlbum.Rows)
            {
                ListViewItem li = lvwAlbum.Items.Add("");
                li.SubItems.Add(dr["TenAlbum"].ToString());
                li.SubItems.Add(dr["NamPhatHanh"].ToString());
                li.Tag = dr["MaAlbum"];
            }
            STT(lvwAlbum);
        }
        #endregion
        private void hienbaihat(DataView dv, ListView lvw)
        {
            lvw.Items.Clear();
            foreach (DataRowView dr in dv)
            {
                ListViewItem li = lvw.Items.Add("");
                li.SubItems.Add(dr["TenBaiHat"].ToString());
            }
            STT(lvw);
        }
        private void loadlai_listview()
        {
            lvwAlbum.Items.Clear();
            lvwTheloai.Items.Clear();
            lvwBaihat_Album.Items.Clear();
            lvwBaihat_home.Items.Clear();
            lvwBaihat_theloai.Items.Clear();
            lvwBaihat_Hangsx.Items.Clear();
            lvwBaihat_Tacgia.Items.Clear();
            lvwBaihat_casi.Items.Clear();
            lvwBaihat_theloai.Items.Clear();
            lvBaihat.Items.Clear();

            load_BaiHat_home();
            load_Album();
            load_TheLoai();
            load_Baihat();
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đóng ứng dụng không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }
        private void btnCapnhatcasi_Click(object sender, EventArgs e)
        {
            if (listCasi.SelectedItems.Count == 0)
                return;
            this.Visible = false;
            frmCapnhat_Casi f = new frmCapnhat_Casi();
            f.macasi = listCasi.SelectedValue.ToString();
            f.tencasi = listCasi.GetItemText(listCasi.SelectedItem);
            f.ShowDialog();
            this.Visible = true;
            load_Casi();
        }

        private void btnThemtacgia_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            frmThem_Tacgia f = new frmThem_Tacgia();
            f.ShowDialog();
            this.Visible = true;
            load_TacGia();
        }

        private void btnCapnhattacgia_Click(object sender, EventArgs e)
        {
            if (listNhacsi.SelectedItems.Count == 0)
                return;
            this.Visible = false;
            frmCapnhat_Tacgia f = new frmCapnhat_Tacgia();
            f.matacgia = listNhacsi.SelectedValue.ToString();
            f.tentacgia = listNhacsi.GetItemText(listNhacsi.SelectedItem);
            f.ShowDialog();
            this.Visible = true;
            load_TacGia();
        }

        private void btnThemhangsx_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            frmThem_Hangsx f = new frmThem_Hangsx();
            f.ShowDialog();
            this.Visible = true;
            load_NhaSanXuat();
        }

        private void btnCapnhathangsx_Click(object sender, EventArgs e)
        {
            if (listHangsx.SelectedItems.Count == 0)
                return;
            this.Visible = false;
            frmCapnhat_Hangsx f = new frmCapnhat_Hangsx();
            f.manhasx = listHangsx.SelectedValue.ToString();
            f.tennhasx = listHangsx.GetItemText(listHangsx.SelectedItem);
            f.ShowDialog();
            this.Visible = true;
            load_NhaSanXuat();
        }

        private void btnThembaihat_Click(object sender, EventArgs e)
        {
            lvBaihat.Items.Clear();
            this.Visible = false;
            frmThem_Baihat f = new frmThem_Baihat();
            f.ShowDialog();
            this.Visible = true;
            load_Baihat();
            loadlai_listview();
        }

        private void btnCapnhatbaihat_Click(object sender, EventArgs e)
        {
            if (lvBaihat.SelectedItems.Count == 0)
                return;
            this.Visible = false;
            frmCapnhat_Baihat f = new frmCapnhat_Baihat();
            f.mabaihat = lvBaihat.SelectedItems[0].Tag.ToString();
            f.tenbaihat = lvBaihat.SelectedItems[0].SubItems[1].Text;
            f.loibaihat = lvBaihat.SelectedItems[0].SubItems[2].Text;
            f.matheloai = cboTheloai.SelectedValue.ToString();
            f.matacgia = CboTacgia.SelectedValue.ToString();
            f.maalbum = cboAlbum.SelectedValue.ToString();
            f.macasi = cboCasi.SelectedValue.ToString();
            f.mahangsanxuat = CboHangsx.SelectedValue.ToString();
            f.ShowDialog();
            this.Visible = true;
            if (f.DialogResult == DialogResult.OK)
                loadlai_listview();
        }

        private void listCasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (danapxong_lstBox)
            {
                if (listCasi.SelectedItems.Count == 0)
                    return;
                dtCasi_baihat = new tblCasi_Baihat().getCasi_BaiHat_by_macasi(listCasi.SelectedValue.ToString());
                lvwBaihat_casi.Items.Clear();
                foreach (DataRow dr in dtCasi_baihat.Rows)
                {
                    DataTable dt = new tblBaihat().getBaiHat_by_mabaihat(dr["MaBaiHat"].ToString());

                    ListViewItem li = lvwBaihat_casi.Items.Add("");
                    li.SubItems.Add(dt.Rows[0]["TenBaiHat"].ToString());
                }
                STT(lvwBaihat_casi);

            }
        }

        private void listNhacsi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (danapxong_lstBox)
            {
                if (listNhacsi.SelectedItems.Count == 0)
                    return;
                dtBaihat = new tblBaihat().getBaiHat();
                DataView dvBaihat = new DataView(dtBaihat);
                dvBaihat.RowFilter = "MaTacGia = '" + listNhacsi.SelectedValue.ToString() + "'";
                hienbaihat(dvBaihat, lvwBaihat_Tacgia);
            }
        }

        private void listHangsx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (danapxong_lstBox)
            {
                if (listHangsx.SelectedItems.Count == 0)
                    return;
                dtBaihat = new tblBaihat().getBaiHat();
                DataView dvBaihat = new DataView(dtBaihat);
                dvBaihat.RowFilter = "MaHangSanXuat = '" + listHangsx.SelectedValue.ToString() + "'";
                hienbaihat(dvBaihat, lvwBaihat_Hangsx);
            }
        }

        private void lvwAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvwAlbum.SelectedItems.Count == 0)
                return;
            lvwBaihat_Album.Items.Clear();
            DataTable dt = null;
            try
            {
                dt = new tblBaihat().getBaiHat_by_album(lvwAlbum.SelectedItems[0].Tag.ToString());

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem li = lvwBaihat_Album.Items.Add("");
                    li.SubItems.Add(dr["TenBaihat"].ToString());
                    DataTable dt1 = new tblCasi_Baihat().getCasi_BaiHat_by_mabaihat(dr["MaBaiHat"].ToString());
                    string cac_casi = "";
                    foreach (DataRow r in dt1.Rows)
                    {
                        DataTable dtcasi = new tblCaSi().getCasi_by_macasi(r["MaCaSi"].ToString());
                        foreach (DataRow r1 in dtcasi.Rows)
                        {
                            cac_casi += r1["TenCaSi"].ToString() + ", ";
                        }
                    }
                    li.SubItems.Add(cac_casi + "...");
                    DataTable dtA = new tblTheloai().getTheLoai_by_ma(dr["MaTheLoai"].ToString());
                    DataRow rr = dtA.Rows[0];
                    li.SubItems.Add(rr["TenTheLoai"].ToString());
                    li.SubItems.Add(dr["LoiBaiHat"].ToString());
                    li.Tag = dr["MaBaiHat"];

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi không xác định");
                return;
            }
            STT(lvwBaihat_Album);

        }

        private void lvwBaihat_home_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            frmThongtinbaihat f = new frmThongtinbaihat();
            var item = e.Item;
            f.Sender(item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text, item.SubItems[5].Text, item.SubItems[6].Text, item.SubItems[7].Text, item.SubItems[8].Text);
            f.ShowDialog();
        }

        private void lvwTheloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwTheloai.SelectedItems.Count == 0)
                return;
            lvwBaihat_theloai.Items.Clear();
            DataTable dt;
            try
            {
                dt = new tblBaihat().getBaiHat_by_TheLoai(lvwTheloai.SelectedItems[0].Tag.ToString());

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem li = lvwBaihat_theloai.Items.Add("");
                    li.SubItems.Add(dr["TenBaihat"].ToString());
                    DataTable dt1 = new tblCasi_Baihat().getCasi_BaiHat_by_mabaihat(dr["MaBaiHat"].ToString());
                    string cac_casi = "";
                    foreach (DataRow r in dt1.Rows)
                    {
                        DataTable dtcasi = new tblCaSi().getCasi_by_macasi(r["MaCaSi"].ToString());
                        foreach (DataRow r1 in dtcasi.Rows)
                        {
                            cac_casi += r1["TenCaSi"].ToString() + ", ";
                        }
                    }
                    li.SubItems.Add(cac_casi + "...");
                    DataTable dtA = new tblTheloai().getTheLoai_by_ma(dr["MaTheLoai"].ToString());
                    DataRow rr = dtA.Rows[0];
                    li.SubItems.Add(rr["TenTheLoai"].ToString());
                    li.SubItems.Add(dr["LoiBaiHat"].ToString());
                    li.Tag = dr["MaBaiHat"];

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi không xác định");
                return;
            }
            STT(lvwBaihat_theloai);
        }

        private void tbnhienthibaihat_Click(object sender, EventArgs e)
        {
            lvBaihat.Items.Clear();
            DataTable dt = new tblBaihat().getBaiHat_cbo(cboTheloai.SelectedValue.ToString(), cboAlbum.SelectedValue.ToString(), cboCasi.SelectedValue.ToString(), CboTacgia.SelectedValue.ToString(), CboHangsx.SelectedValue.ToString());
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem li = lvBaihat.Items.Add("");
                li.SubItems.Add(dr["TenBaiHat"].ToString());
                li.SubItems.Add(dr["LoiBaiHat"].ToString());
            }
            STT(lvBaihat);
        }


        private void btnThemAlbum_Click(object sender, EventArgs e)
        {
            lvwAlbum.Items.Clear();
            this.Visible = false;
            frmThem_Album f = new frmThem_Album();
            f.ShowDialog();
            this.Visible = true;
            load_Album();
        }

        private void btnChinhsuaAlbum_Click(object sender, EventArgs e)
        {
            if (lvwAlbum.SelectedItems.Count == 0)
                return;
            this.Visible = false;
            frmCapnhat_Album f = new frmCapnhat_Album();
            f.maalbum = lvwAlbum.SelectedItems[0].Tag.ToString();
            f.tenalbum = lvwAlbum.SelectedItems[0].SubItems[1].Text;
            f.namphath = lvwAlbum.SelectedItems[0].SubItems[2].Text;
            f.ShowDialog();
            this.Visible = true;
            lvwAlbum.Items.Clear();
            load_Album();
        }

        private void btnThemtheloai_Click(object sender, EventArgs e)
        {
            lvwTheloai.Items.Clear();
            this.Visible = false;
            frmThem_Theloai f = new frmThem_Theloai();
            f.ShowDialog();
            this.Visible = true;
            load_TheLoai();
        }

        private void btnCapnhatTheloai_Click(object sender, EventArgs e)
        {
            if (lvwTheloai.SelectedItems.Count == 0)
                return;
            this.Visible = false;
            frmCapnhat_Theloai f = new frmCapnhat_Theloai();
            f.matheloai = lvwTheloai.SelectedItems[0].Tag.ToString();
            f.tentheloai = lvwTheloai.SelectedItems[0].SubItems[1].Text;
            f.ShowDialog();
            this.Visible = true;
            lvwTheloai.Items.Clear();
            load_TheLoai();
        }

        private void btnThemcasi_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            frmThem_Casi f = new frmThem_Casi();
            f.ShowDialog();
            this.Visible = true;
            load_Casi();
        }

        private void btnXoaAlbum_Click(object sender, EventArgs e)
        {
            if (lvwAlbum.SelectedItems.Count == 0)
                return;
            DialogResult tb = MessageBox.Show("Bạn có thực sự muốn xóa Album[" + lvwAlbum.SelectedItems[0].SubItems[1].ToString() + " không !", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (tb == DialogResult.Cancel)
                return;
            string maal = lvwAlbum.SelectedItems[0].Tag.ToString();
            tblAlbum dt = new tblAlbum(maal);
            int kq = dt.xoaAlbum();
            if (kq == 0)
                MessageBox.Show("Bạn đã xóa Album[" + lvwAlbum.SelectedItems[0].SubItems[1].ToString() + "] thành công!)", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            else
                MessageBox.Show("Bạn chưa xóa được Album!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            loadlai_listview();
        }

        private void btnXoatheloai_Click(object sender, EventArgs e)
        {
            if (lvwTheloai.SelectedItems.Count == 0)
                return;
            DialogResult tb = MessageBox.Show("Bạn có thực sự muốn xóa Thể loại[" + lvwTheloai.SelectedItems[0].SubItems[1].Text + "] không!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (tb == DialogResult.Cancel)
                return;
            string matl = lvwTheloai.SelectedItems[0].Tag.ToString();
            tblTheloai dt = new tblTheloai(matl);
            int kq = dt.xoaTheLoai();
            if (kq == 0)
                MessageBox.Show("Bạn đã xóa Thể Loại[" + lvwTheloai.SelectedItems[0].SubItems[1].Text + "] thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Bạn chưa xóa được thể loại!)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lvwTheloai.Items.Clear();
            loadlai_listview();
        }

        private void btnXoacasi_Click(object sender, EventArgs e)
        {
            if (listCasi.SelectedItems.Count == 0)
                return;
            DialogResult tb = MessageBox.Show("Bạn có thực sự muốn xóa Ca sĩ[" + listCasi.GetItemText(listCasi.SelectedItem) + "] không !", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (tb == DialogResult.Cancel)
                return;
            string macs = listCasi.SelectedValue.ToString();
            tblCaSi dt = new tblCaSi(macs);
            int kq = dt.xoaCasi();
            if (kq == 0)
                MessageBox.Show("Bạn đã xóa thành công ca sĩ [" + listCasi.GetItemText(listCasi.SelectedItem) + "] thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            else
                MessageBox.Show("Chưa xóa được!");

            load_Casi();
        }

        private void btnXoaTacgia_Click(object sender, EventArgs e)
        {
            if (listNhacsi.SelectedItems.Count == 0)
                return;
            DialogResult tb = MessageBox.Show("Bạn có thực sự muốn xóa Tác giả[" + listNhacsi.GetItemText(listNhacsi.SelectedItem) + "] không !", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (tb == DialogResult.Cancel)
                return;
            string matg = listNhacsi.SelectedValue.ToString();
            tblTacgia dt = new tblTacgia(matg);
            int kq = dt.xoaTacGia();
            if (kq == 0)
                MessageBox.Show("Bạn đã xóa thành công tác giả[" + listNhacsi.GetItemText(listNhacsi.SelectedItem) + "] thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Chưa xóa được!");
            load_TacGia();
        }

        private void btnXoaHangsx_Click(object sender, EventArgs e)
        {
            if (listHangsx.SelectedItems.Count == 0)
                return;
            DialogResult tb = MessageBox.Show("Bạn có muốn xóa Hãng sản xuất[" + listHangsx.GetItemText(listHangsx.SelectedItem) + "] không!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (tb == DialogResult.Cancel)
                return;
            string masx = listHangsx.SelectedValue.ToString();
            tblHangsanxuat dt = new tblHangsanxuat(masx);
            int kq = dt.xoaNhaSX();
            if (kq == 0)
                MessageBox.Show("Bạn đã xóa thành công Hãng sản xuất[" + listHangsx.GetItemText(listHangsx.SelectedItem) + "] thành công!", "Thông báo");
            else
                MessageBox.Show("Bạn chưa xóa được hãng sản xuất!");
            load_NhaSanXuat();
        }

        private void btnXoabaihat_Click(object sender, EventArgs e)
        {
            if (lvBaihat.SelectedItems.Count == 0)
                return;
            DialogResult tb = MessageBox.Show("Bạn có muốn xóa bài hát [" + lvBaihat.SelectedItems[0].SubItems[1].Text + "] không!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (tb == DialogResult.Cancel)
                return;
            string mabh = lvBaihat.SelectedItems[0].Tag.ToString();
            tblBaihat dt = new tblBaihat(mabh);
            int kq = dt.xoaBaiHat();
            if (kq == 0)
                MessageBox.Show("Bạn đã xóa thành công bài hát[" + lvBaihat.SelectedItems[0].SubItems[1].Text + "] không !", "Thông báo");
            else
                MessageBox.Show("Bạn chưa xóa được bài hát!");
            loadlai_listview();
            lvBaihat.Items.Clear();
            load_Baihat();
        }
        private DataTable dt_baihat_timkiem;
        private void btnTracuu_Click(object sender, EventArgs e)
        {
            lvwKetquaTimkiem.Items.Clear();
            if (cboTimkiem.Text == "Tên Thể loại")
            {
                dt_baihat_timkiem = new tblBaihat().getBaiHat_by_Tentheloai(txtTimkiem.Text);
            }
            else if (cboTimkiem.Text == "Tên Bài hát")
            {
                dt_baihat_timkiem = new tblBaihat().getBaiHat_by_Tenbaihat(txtTimkiem.Text);
            }
            else if (cboTimkiem.Text == "Tên Album")
            {
                dt_baihat_timkiem = new tblBaihat().getBaiHat_by_Tenalbum(txtTimkiem.Text);
            }
            else if (cboTimkiem.Text == "Tên Tác giả")
            {
                dt_baihat_timkiem = new tblBaihat().getBaiHat_by_TenTacgia(txtTimkiem.Text);
            }
            else if (cboTimkiem.Text == "Tên Ca sĩ")
            {
                dt_baihat_timkiem = new tblBaihat().getBaiHat_by_TenCasi(txtTimkiem.Text);
            }
            else if (cboTimkiem.Text == "Tên Hãng sản xuất")
            {
                dt_baihat_timkiem = new tblBaihat().getBaiHat_by_Tenhangsanxuat(txtTimkiem.Text);
            }
            else if (cboTimkiem.Text == "Lời bài hát")
            {
                dt_baihat_timkiem = new tblBaihat().getBaiHat_by_Loibaihat(txtTimkiem.Text);
            }
            else
            {
                MessageBox.Show("Mời bạn chọn phương thức tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (DataRow i in dt_baihat_timkiem.Rows)
            {
                ListViewItem list = lvwKetquaTimkiem.Items.Add("");
                list.SubItems.Add(i["TenBaiHat"].ToString());
                list.SubItems.Add(i["TenTheLoai"].ToString());
                list.SubItems.Add(i["TenAlbum"].ToString());
                list.SubItems.Add(i["TenCaSi"].ToString());
                list.SubItems.Add(i["TenTacGia"].ToString());
                list.SubItems.Add(i["TenHangSanXuat"].ToString());
                list.SubItems.Add(i["LoiBaiHat"].ToString());
                list.Tag = i["MaBaiHat"];
            }
            STT(lvwKetquaTimkiem);
        }


        public string filename;
        private void lvwKetquaTimkiem_ItemSelectionchanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var item = e.Item;
            string str = item.SubItems[1].Text;
            filename = str;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string filepath = System.IO.Path.GetFullPath("D:\\VS_vidu\\Dohoamaytinh\\Winformcoban\\BaiTapLon\\BTL\\Nhac\\" + filename + ".mp3");
            axWindowsMediaPlayer1.URL = filepath;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

     
  
    }
}
