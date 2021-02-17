using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
    class tblHangsanxuat
    {
        Hangsanxuat_Data objNhaSanXUat = new Hangsanxuat_Data();

        #region khai báo đối tượng , kiểm tra hợp lệ
        private string mahangsanxuat;
        private string tenhangsanxuat;
        public tblHangsanxuat() { }
        public tblHangsanxuat(string ma)
        {
            this.mahangsanxuat = ma;
        }
        public tblHangsanxuat(string ma, string ten)
        {
            this.MAHANGSANXUAT = ma;
            this.TENHANGSANXUAT = ten;
        }

        public string MAHANGSANXUAT
        {
            get { return this.mahangsanxuat; }

            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Nhập mã hãng sản xuất !");
                else
                    mahangsanxuat= value;
            }
        }
        public string TENHANGSANXUAT
        {
            get { return tenhangsanxuat; }

            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Nhập tên hãng sản xuất !");
                else
                    tenhangsanxuat = value;
            }
        }
        #endregion

        #region lấy bảng dử liệu và các phươnng thức xử lý
        public DataTable getNhaSanXuat()
        {
            return objNhaSanXUat.getNhaSanXuat();
        }

        public int themNhaSX()
        {
            return objNhaSanXUat.themNhaSX(mahangsanxuat, tenhangsanxuat);
        }
        public int xoaNhaSX()
        {
            return objNhaSanXUat.xoaNhaSanXuat(mahangsanxuat);
        }
        public int capnhapNhaSX()
        {
            return objNhaSanXUat.capnhatNhaSX(mahangsanxuat, tenhangsanxuat);
        }
        #endregion
    }
}
