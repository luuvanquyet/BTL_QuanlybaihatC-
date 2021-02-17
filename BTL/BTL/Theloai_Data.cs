using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
    class Theloai_Data
    {
        DataConection objCon = new DataConection();
        #region các hàm lấy table, lấy hết table và lấy theo điều kiện
        public DataTable getTheLoai()
        {
            return objCon.getAllTable("THELOAI").Tables["THELOAI"];
        }


        public DataTable getTheLoai_by_ma(string matheloai)
        {
            SqlCommand cmd = new SqlCommand("select * from THELOAI where MaTheLoai = @ma", objCon.con);
            cmd.Parameters.Add("@ma", SqlDbType.NVarChar).Value = matheloai;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds, "theloai");
            return ds.Tables["theloai"];
        }


        public DataTable getTheLoai_by_mabaihat(string mabaihat)
        {
            SqlCommand cmd = new SqlCommand("select * from THELOAI where MaBaiHat = @ma", objCon.con);
            cmd.Parameters.Add("@ma", SqlDbType.NVarChar).Value = mabaihat;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds, "theloai");
            return ds.Tables["theloai"];
        }
        #endregion

        #region các phương thức xử lý (câu sql) thêm xóa sửa


        public int themTheLoai(string matheloai, string tentheloai)
        {
            return objCon.executeNonQuery("Insert into THELOAI values('" + matheloai + "',N'" + tentheloai + "')");
        }


        public int xoaTheLoai(string matheloai)
        {
            objCon.executeNonQuery("DELETE FROM BAIHAT WHERE MaTheLoai ='" + matheloai + "'");
            return objCon.executeNonQuery("DELETE FROM THELOAI WHERE MaTheLoai =N'" + matheloai + "'");
        }

        public int capnhatTheLoai(string matheloai, string tentheloai)
        {
            return objCon.executeNonQuery("UPDATE THELOAI SET TenTheLoai =N'" + tentheloai + "' WHERE MaTheLoai ='" + matheloai + "'");
        }
        #endregion
    }
}
