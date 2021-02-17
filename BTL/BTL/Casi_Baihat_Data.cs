using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
    class Casi_Baihat_Data
    {
        DataConection objCon = new DataConection();

        // khởi tạo
        public Casi_Baihat_Data() { }

        #region các hàm lấy dử liệu bảng
        public DataTable getCasi_BaiHat_by_mabaihat(string mabaihat)
        {

            SqlCommand cmd = new SqlCommand("select * from CASI_BAIHAT where MaBaiHat = @mabaihat", objCon.con);
            cmd.Parameters.Add("@mabaihat", SqlDbType.NVarChar).Value = mabaihat;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "Casi_baihat");
            return ds.Tables["Casi_baihat"];
        }


        public DataTable getCasi_BaiHat_by_macasi(string macasi)
        {

            SqlCommand cmd = new SqlCommand("select * from CASI_BAIHAT where MaCaSi = @macasi", objCon.con);
            cmd.Parameters.Add("@macasi", SqlDbType.NVarChar).Value = macasi;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "Casi_baihat");
            return ds.Tables["Casi_baihat"];

        }
        #endregion
    }
}
