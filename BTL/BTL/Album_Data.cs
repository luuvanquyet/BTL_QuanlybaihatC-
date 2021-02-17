using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
    class Album_Data
    {
        DataConection objCon = new DataConection();
        public Album_Data() { }

        #region hàm lấy bảng album

        public DataTable getAlbum()
        {
            return objCon.getAllTable("ALBUM").Tables["ALBUM"];
        }

        public DataTable getAlbum_by_ma(string maalbum)
        {
            SqlCommand cmd = new SqlCommand("select * from ALBUM where MaAlbum = @ma", objCon.con);
            cmd.Parameters.Add("@ma", SqlDbType.NVarChar).Value = maalbum;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds, "album");
            return ds.Tables["album"];
        }
        #endregion

        #region các phương thức xử lý
        public int themAlbum(string maalbum, string tenalbum, string namphathanh)
        {
            return objCon.executeNonQuery("Insert into ALBUM values('" + maalbum + "',N'" + tenalbum + "','" + namphathanh + "')");
        }

        public int xoaAlbum(string maalbum)
        {
            objCon.executeNonQuery("DELETE FROM BAIHAT WHERE MaAlbum ='" + maalbum + "'");
            return objCon.executeNonQuery("DELETE FROM ALBUM WHERE MaAlbum ='" + maalbum + "'");
        }

        public int capnhatAlbum(string maalbum, string tenalbum, string namphathanh)
        {
            return objCon.executeNonQuery("UPDATE ALBUM SET TenAlbum =N'" + tenalbum + "', NamPhatHanh = '" + namphathanh + "' WHERE MaAlbum ='" + maalbum + "'");
        }
        public int xoaBaiHatKhoiAlBum(string maalbum)
        {
            return objCon.executeNonQuery("DELETE FROM BAIHAT WHERE MaAlbum ='" + maalbum + "'");
        }
        #endregion
    }
}
