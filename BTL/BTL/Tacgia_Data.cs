using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
    class Tacgia_Data
    {
        DataConection objCon = new DataConection();
        #region các hàm lấy bảng, lấy hết bảng, lấy theo điều kiện
        public DataTable getTacGia()
        {
            return objCon.getAllTable("TACGIA").Tables["TACGIA"];
        }
        #endregion

        #region các phương thức xử lý thêm xóa sữa (sql)

        public int themTacGia(string matacgia, string tentacgia)
        {
            return objCon.executeNonQuery("Insert into TACGIA values('" + matacgia + "',N'" + tentacgia + "')");
        }

        public int xoaTacGia(string matacgia)
        {
            objCon.executeNonQuery("DELETE FROM BAIHAT WHERE MaTacGia ='" + matacgia + "'");
            return objCon.executeNonQuery("DELETE FROM TACGIA WHERE MaTacGia ='" + matacgia + "'");
        }

        public int capnhatTacGia(string matacgia, string tentacgia)
        {
            return objCon.executeNonQuery("UPDATE TACGIA SET TenTacGia =N'" + tentacgia + "' WHERE MaTacGia ='" + matacgia + "'");
        }
        #endregion
    }
}
