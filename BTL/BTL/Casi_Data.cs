using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
    class Casi_Data
    {
        DataConection objCon = new DataConection();

        #region hàm lấy dử liệu bảng
        public DataTable getCasi()
        {
            return objCon.getAllTable("CASI").Tables["CASI"];
        }
        public DataTable getCaSi_by_macasi(string macasi)
        {

            SqlCommand cmd = new SqlCommand("select * from CASI where MaCaSi = @macasi", objCon.con);
            cmd.Parameters.Add("@macasi", SqlDbType.NVarChar).Value = macasi;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "casi");
            return ds.Tables["casi"];
        }
        #endregion

        #region các phương thức xử lý
   
        public int themCaSi(string macasi, string tencasi)
        {
            return objCon.executeNonQuery("Insert into CASI values('" + macasi + "',N'" + tencasi +"')");
        }

        public int xoaCaSi(string macasi)
        {
            objCon.executeNonQuery("DELETE FROM BAIHAT WHERE MaCaSi ='" + macasi + "'");
            return objCon.executeNonQuery("DELETE FROM CASI WHERE MaCaSi ='" + macasi + "'");
        }

        public int capnhatCaSi(string macasi, string tencasi)
        {
            return objCon.executeNonQuery("UPDATE CASI SET TenCaSi =N'" + tencasi + "' WHERE macasi ='" + macasi + "'");
        }
        #endregion
    }
}
