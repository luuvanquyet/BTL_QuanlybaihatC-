using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
    class tblTheloai
    {
        Theloai_Data objTheLoai = new Theloai_Data();
       
        private string matheloai;
        private string tentheloai;

        public tblTheloai() { }
        public tblTheloai(string ma, string ten)
        {
            this.MATHELOAI = ma;
            this.TENTHELOAI = ten;
        }

        public tblTheloai(string ma)
        {

            this.matheloai = ma;
        }

        public string MATHELOAI
        {
            get { return matheloai; }

            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Nhập mã thể loại !");
                else
                    matheloai = value;
            }
        }

        public string TENTHELOAI
        {
            get { return tentheloai; }

            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Nhập tên thể loại !");
                else
                    tentheloai = value;
            }
        }

        #region các hàm lấy dử liệu bảng
        public DataTable getTheLoai()
        {
            return objTheLoai.getTheLoai();
        }
        public DataTable getTheLoai_by_ma(string matheloai)
        {
            return objTheLoai.getTheLoai_by_ma(matheloai);
        }
        public DataTable getTheLoai_by_mabaihat(string mabaihat)
        {
            return objTheLoai.getTheLoai_by_mabaihat(mabaihat);
        }
        #endregion

        #region các phương thức xử lý
        public int themTheLoai()
        {
            return objTheLoai.themTheLoai(matheloai, tentheloai);
        }
        public int xoaTheLoai()
        {
            return objTheLoai.xoaTheLoai(matheloai);
        }
        public int capnhatTheLoai()
        {
            return objTheLoai.capnhatTheLoai(matheloai, tentheloai);
        }
        #endregion
    }
}
