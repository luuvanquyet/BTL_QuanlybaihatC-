using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BTL
{
    public partial class frmThongtinbaihat : Form
    {
        public delegate void SendMessage(string bh, string tl, string ab, string namph, string tencasi, string tentacgia, string tensx, string loibh);
        public SendMessage Sender;
        public frmThongtinbaihat()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);

        }
        private void GetMessage(string bh, string tl, string ab, string namph, string tencasi, string tentacgia, string tensx, string loibh)
        {
            lbTenbaihat.Text = bh;
            txtTenalbum.Text = ab;
            txtTentheloai.Text = tl;
            txtCasi.Text = tencasi;
            txtTacgia.Text = tentacgia;
            txtNamph.Text = namph;
            txtHangsx.Text = tensx;
            txtLoibaihat.Text = loibh;
            
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (txtTenalbum.Text == "MV")
            {
                string filepath = System.IO.Path.GetFullPath("D:\\VS_vidu\\Dohoamaytinh\\Winformcoban\\BaiTapLon\\BTL\\Nhac\\" + lbTenbaihat.Text + ".mp4");
                axWindowsMediaPlayer1.URL = filepath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                string filepath = System.IO.Path.GetFullPath("D:\\VS_vidu\\Dohoamaytinh\\Winformcoban\\BaiTapLon\\BTL\\Nhac\\" + lbTenbaihat.Text + ".mp3");
                axWindowsMediaPlayer1.URL = filepath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            this.Close();
        }

       
        
    }
}
