using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
    class Hangsanxuat_Data
    {
        DataConection objCon = new DataConection();

        #region hàm lấy bảng NHASANXUAT

        public DataTable getNhaSanXuat()
        {
            return objCon.getAllTable("HANGSANXUAT").Tables["HANGSANXUAT"];
        }
        #endregion

        #region các phương thức xử lý

        public int themNhaSX(string manhasx, string tennhasx)
        {
            return objCon.executeNonQuery("Insert into HANGSANXUAT values('" + manhasx + "',N'" + tennhasx + "')");
        }

        public int xoaNhaSanXuat(string manhasx)
        {
            objCon.executeNonQuery("DELETE FROM BAIHAT WHERE MaHangSanXuat ='" + manhasx + "'");
            return objCon.executeNonQuery("DELETE FROM HANGSANXUAT WHERE MaHangSanXuat ='" + manhasx + "'");
        }

        public int capnhatNhaSX(string manhasx, string tennhasx)
        {
            return objCon.executeNonQuery("UPDATE HANGSANXUAT SET TenHangSanXuat =N'" + tennhasx + "' WHERE MaHangSanXuat ='" + manhasx + "'");
        }
        #endregion
    }
}
