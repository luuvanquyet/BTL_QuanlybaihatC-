using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
    class Baihat_Data
    {
        DataConection objCon = new DataConection();

        #region các hàm lấy dử liệu table

        public DataTable getBaiHat()
        {
            return objCon.getAllTable("BAIHAT").Tables["BAIHAT"];
        }

        public DataTable getBaiHat_Home()
        {
            return objCon.getBaiHat_home().Tables["baihat_home"];
        }

        public DataTable getBaiHat_by_Album(string maalbum)
        {

            SqlCommand cmd = new SqlCommand("select * from BAIHAT where MaAlbum=@maalbum", objCon.con);
            cmd.Parameters.Add("@maalbum", SqlDbType.NVarChar).Value = maalbum;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "chitietbaihat");

            return ds.Tables["chitietbaihat"];
        }
        public DataTable getBaiHat_by_mabaihat(string mabaihat)
        {
            SqlCommand cmd = new SqlCommand("select * from BAIHAT where MaBaiHat=@mabaihat", objCon.con);
            cmd.Parameters.Add("@mabaihat", SqlDbType.NVarChar).Value = mabaihat;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "baihat");

            return ds.Tables["baihat"];
        }

        public DataTable getBaiHat_by_TheLoai(string matheloai)
        {
            SqlCommand cmd = new SqlCommand("select * from BAIHAT where MaTheLoai=@matheloai", objCon.con);
            cmd.Parameters.Add("@matheloai", SqlDbType.NVarChar).Value = matheloai;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "chitietbaihat");


            return ds.Tables["chitietbaihat"];
        }
        public DataTable getBaiHat_by_cbo(string matheloai, string maalbum, string macasi, string matacgia, string mahangsanxuat)
        {

            SqlCommand cmd = new SqlCommand("select * from BAIHAT where MaTheLoai=@matheloai and MaAlbum=@maalbum and MaCaSi=@macasi and MaTacGia=@matacgia and MaHangSanXuat=@mahangsanxuat", objCon.con);
            cmd.Parameters.Add("@matheloai", SqlDbType.NVarChar).Value = matheloai;
            cmd.Parameters.Add("@maalbum", SqlDbType.NVarChar).Value = maalbum;
            cmd.Parameters.Add("@macasi", SqlDbType.NVarChar).Value = macasi;
            cmd.Parameters.Add("@matacgia", SqlDbType.NVarChar).Value = matacgia;
            cmd.Parameters.Add("@mahangsanxuat", SqlDbType.NVarChar).Value = mahangsanxuat;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "baihat_cbo");
            return ds.Tables["baihat_cbo"];
        }
        public DataTable getBaiHat_by_cbo(string matheloai, string maalbum)
        {

            SqlCommand cmd = new SqlCommand("select * from BAIHAT where MaTheLoai=@matheloai and MaAlbum=@maalbum", objCon.con);
            cmd.Parameters.Add("@matheloai", SqlDbType.NVarChar).Value = matheloai;
            cmd.Parameters.Add("@maalbum", SqlDbType.NVarChar).Value = maalbum;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "baihat_cbo");

            return ds.Tables["baihat_cbo"];
        }
        public DataTable getBaihat_by_tenbaihat(string tenbh)
        {
            SqlCommand cmd = new SqlCommand("select BAIHAT.MaBaiHat,TenBaiHat,TenTheLoai,TenAlbum,TenTacGia,TenCaSi,TenHangSanXuat,LoiBaiHat from BAIHAT inner join THELOAI on BAIHAT.MaTheLoai = THELOAI.MaTheLoai inner join ALBUM on  BAIHAT.MaAlbum = ALBUM.MaAlbum inner join TACGIA on BAIHAT.MaTacGia = TACGIA.MaTacGia inner join CASI on BAIHAT.MaCaSi = CASI.MaCaSi inner join HANGSANXUAT on BAIHAT.MaHangSanXuat = HANGSANXUAT.MaHangSanXuat where TenBaiHat like N'%"+tenbh+"%'",objCon.con);    
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "baihat_by_tenbh");
            return ds.Tables["baihat_by_tenbh"];
        }
        public DataTable getBaihat_by_tentheloai(string tentheloai)
        {
            SqlCommand cmd = new SqlCommand("select BAIHAT.MaBaiHat,TenBaiHat,TenTheLoai,TenAlbum,TenTacGia,TenCaSi,TenHangSanXuat,LoiBaiHat from BAIHAT inner join THELOAI on BAIHAT.MaTheLoai = THELOAI.MaTheLoai inner join ALBUM on  BAIHAT.MaAlbum = ALBUM.MaAlbum inner join TACGIA on BAIHAT.MaTacGia = TACGIA.MaTacGia inner join CASI on BAIHAT.MaCaSi = CASI.MaCaSi inner join HANGSANXUAT on BAIHAT.MaHangSanXuat = HANGSANXUAT.MaHangSanXuat where TenTheLoai like N'%"+tentheloai+"%'",objCon.con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "baihat_by_tentheloai");
            return ds.Tables["baihat_by_tentheloai"];
        }
        public DataTable getBaihat_by_tenalbum(string tenalbum)
        {
            SqlCommand cmd = new SqlCommand("select BAIHAT.MaBaiHat,TenBaiHat,TenTheLoai,TenAlbum,TenTacGia,TenCaSi,TenHangSanXuat,LoiBaiHat from BAIHAT inner join THELOAI on BAIHAT.MaTheLoai = THELOAI.MaTheLoai inner join ALBUM on  BAIHAT.MaAlbum = ALBUM.MaAlbum inner join TACGIA on BAIHAT.MaTacGia = TACGIA.MaTacGia inner join CASI on BAIHAT.MaCaSi = CASI.MaCaSi inner join HANGSANXUAT on BAIHAT.MaHangSanXuat = HANGSANXUAT.MaHangSanXuat where TenAlbum like N'%"+tenalbum+"%'",objCon.con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "baihat_by_tenalbum");
            return ds.Tables["baihat_by_tenalbum"];
        }
        public DataTable getBaihat_by_tencasi(string tencasi)
        {
            SqlCommand cmd = new SqlCommand("select BAIHAT.MaBaiHat,TenBaiHat,TenTheLoai,TenAlbum,TenTacGia,TenCaSi,TenHangSanXuat,LoiBaiHat from BAIHAT inner join THELOAI on BAIHAT.MaTheLoai = THELOAI.MaTheLoai inner join ALBUM on  BAIHAT.MaAlbum = ALBUM.MaAlbum inner join TACGIA on BAIHAT.MaTacGia = TACGIA.MaTacGia inner join CASI on BAIHAT.MaCaSi = CASI.MaCaSi inner join HANGSANXUAT on BAIHAT.MaHangSanXuat = HANGSANXUAT.MaHangSanXuat where TenCaSi like N'%"+tencasi+"%'",objCon.con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "baihat_by_tencasi");
            return ds.Tables["baihat_by_tencasi"];
        }
        public DataTable getBaihat_by_tentacgia(string tentacgia)
        {
            SqlCommand cmd = new SqlCommand("select BAIHAT.MaBaiHat,TenBaiHat,TenTheLoai,TenAlbum,TenTacGia,TenCaSi,TenHangSanXuat,LoiBaiHat from BAIHAT inner join THELOAI on BAIHAT.MaTheLoai = THELOAI.MaTheLoai inner join ALBUM on  BAIHAT.MaAlbum = ALBUM.MaAlbum inner join TACGIA on BAIHAT.MaTacGia = TACGIA.MaTacGia inner join CASI on BAIHAT.MaCaSi = CASI.MaCaSi inner join HANGSANXUAT on BAIHAT.MaHangSanXuat = HANGSANXUAT.MaHangSanXuat where TenTacGia like N'%"+tentacgia+"%'",objCon.con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "baihat_by_tentacgia");
            return ds.Tables["baihat_by_tentacgia"];
        }
        public DataTable getBaihat_by_tenhangsanxuat(string tenhangsanxuat)
        {
            SqlCommand cmd = new SqlCommand("select BAIHAT.MaBaiHat,TenBaiHat,TenTheLoai,TenAlbum,TenTacGia,TenCaSi,TenHangSanXuat,LoiBaiHat from BAIHAT inner join THELOAI on BAIHAT.MaTheLoai = THELOAI.MaTheLoai inner join ALBUM on  BAIHAT.MaAlbum = ALBUM.MaAlbum inner join TACGIA on BAIHAT.MaTacGia = TACGIA.MaTacGia inner join CASI on BAIHAT.MaCaSi = CASI.MaCaSi inner join HANGSANXUAT on BAIHAT.MaHangSanXuat = HANGSANXUAT.MaHangSanXuat where TenHangSanXuat like N'%"+tenhangsanxuat+"%'",objCon.con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "baihat_by_tenhangsanxuat");
            return ds.Tables["baihat_by_tenhangsanxuat"];
        }
        public DataTable getBaihat_by_loibaihat(string loibaihat)
        {
            SqlCommand cmd = new SqlCommand("select BAIHAT.MaBaiHat,TenBaiHat,TenTheLoai,TenAlbum,TenTacGia,TenCaSi,TenHangSanXuat,LoiBaiHat from BAIHAT inner join THELOAI on BAIHAT.MaTheLoai = THELOAI.MaTheLoai inner join ALBUM on  BAIHAT.MaAlbum = ALBUM.MaAlbum inner join TACGIA on BAIHAT.MaTacGia = TACGIA.MaTacGia inner join CASI on BAIHAT.MaCaSi = CASI.MaCaSi inner join HANGSANXUAT on BAIHAT.MaHangSanXuat = HANGSANXUAT.MaHangSanXuat where LoiBaiHat like N'%"+loibaihat+"%'",objCon.con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "baihat_by_loibaihat");
            return ds.Tables["baihat_by_loibaihat"];
        }
        #endregion

        #region các phương thức xử lý


        public int themBaiHat(string mabaihat, string tenbaihat, string matheloai, string maalbum, string macasi, string matacgia, string manhasanxuat, string loibaihat)
        {
            objCon.executeNonQuery("Insert into BAIHAT values('" + mabaihat + "',N'" + tenbaihat + "','" + matheloai + "','" + maalbum + "','" + macasi + "','" + matacgia + "','" + manhasanxuat + "',N'" + loibaihat + "')");
            return objCon.executeNonQuery("Insert into CASI_BAIHAT values(N'" + macasi + "',N'" + mabaihat + "')");

        }

        public int xoaBaiHat(string mabaihat)
        {
            objCon.executeNonQuery("DELETE FROM CASI_BAIHAT WHERE MaBaiHat ='" + mabaihat + "'");
            return objCon.executeNonQuery("DELETE FROM BAIHAT WHERE MaBaiHat ='" + mabaihat + "'");
        }


        public int capnhatBaiHat(string mabaihat, string tenbaihat, string matheloai, string maalbum, string macasi, string matacgia, string mahangsanxuat, string loibaihat)
        {
            return objCon.executeNonQuery("UPDATE BAIHAT SET TenBaiHat =N'" + tenbaihat + "',MaTheLoai = '" + matheloai + "',MaAlbum = '" + maalbum + "',MaCaSi = '" + macasi + "',MaTacGia = '" + matacgia + "',MaHangSanXuat = '" + mahangsanxuat + "',LoiBaiHat = N'" + loibaihat + "' WHERE MaBaiHat ='" + mabaihat + "'");
        }
        #endregion
    }
}
