using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BTL
{
    class DataConection
    {
        public SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLiNhac;Integrated Security=True");
        public DataConection() { }
        public DataSet getAllTable(string tableName)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from " + tableName, con);
            DataSet ds = new DataSet();
            da.Fill(ds, tableName);
            return ds;
        }
        public DataSet getBaiHat_home()
        {
            SqlDataAdapter da = new SqlDataAdapter("select BAIHAT.MaBaiHat,TenBaiHat,TenTheLoai,TenAlbum,NamPhatHanh,TenTacGia,TenCaSi,TenHangSanXuat,LoiBaiHat from BAIHAT inner join THELOAI on BAIHAT.MaTheLoai = THELOAI.MaTheLoai inner join ALBUM on  BAIHAT.MaAlbum = ALBUM.MaAlbum inner join TACGIA on BAIHAT.MaTacGia = TACGIA.MaTacGia inner join CASI on BAIHAT.MaCaSi = CASI.MaCaSi inner join HANGSANXUAT on BAIHAT.MaHangSanXuat = HANGSANXUAT.MaHangSanXuat", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "baihat_home");
            return ds;
        }
        public int executeNonQuery(string sql)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return 0;
            }
            catch (Exception)
            {
                return 1;
            }
        }
    }
}
