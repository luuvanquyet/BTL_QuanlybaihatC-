using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
    class tblTacgia
    {
        Tacgia_Data objTacGia = new Tacgia_Data();

        #region khai báo đối tượng, kiểm tra hợp lệ
        public  string matacgia;
        public string tentacgia;

        public tblTacgia() { }
        public tblTacgia(string ma)
        {
            this.matacgia = ma;
        }
        public tblTacgia(string ma, string ten)
        {
            this.MATACGIA = ma;
            this.TENTACGIA = ten;
        }

        public string MATACGIA
        {
            get { return matacgia; }

            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Nhập mã tác giả !");
                else
                    matacgia = value;
            }
        }
        public string TENTACGIA
        {
            get { return tentacgia; }

            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Nhập tên tác giả !");
                else
                    tentacgia = value;
            }
        }

        #endregion

        #region hàm lấy dử liệu bảng và các phương thức xử lý
        public DataTable getTacGia()
        {
            return objTacGia.getTacGia();
        }

        public int themTacGia()
        {
            return objTacGia.themTacGia(matacgia, tentacgia);
        }
        public int xoaTacGia()
        {
            return objTacGia.xoaTacGia(matacgia);
        }
        public int capnhapTacgia()
        {
            return objTacGia.capnhatTacGia(matacgia, tentacgia);
        }
        #endregion
    }
}
