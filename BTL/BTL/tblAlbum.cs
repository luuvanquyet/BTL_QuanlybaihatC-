using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
    class tblAlbum
    {
        Album_Data objAlbum = new Album_Data();

        private string maalbum;
        private string tenalbum;
        private string Namphathanh;

        public tblAlbum(string ma, string ten, string namphathanh)
        {
            this.MAALBUM = ma;
            this.TENALBUM = ten;
            this.NAMPHATHANH = namphathanh;
        }
        public tblAlbum() { }
        public tblAlbum(string ma)
        {
            this.maalbum = ma;
        }

        public string MAALBUM
        {
            get
            {
                return maalbum;
            }
            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Nhập mã album !");
                else
                    maalbum = value;
            }
        }

        public string TENALBUM
        {
            get
            {
                return tenalbum;
            }
            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Nhập tên album !");
                else
                    tenalbum = value;
            }
        }

        public string NAMPHATHANH
        {
            get
            {
                return Namphathanh;
            }
            set
            {

                if (value.Trim().Equals(""))
                    throw new Exception("Nhập năm phát hành album!");
                else
                    Namphathanh = value;
            }
        }


        #region các hàm lấy dử liệu bảng album và các phương thức xử lý
        public DataTable getAlbum()
        {
            return objAlbum.getAlbum();
        }
        public DataTable getAlbum_by_ma(string maalbum)
        {
            return objAlbum.getAlbum();
        }
        public int themAlbum()
        {
            return objAlbum.themAlbum(maalbum, tenalbum, Namphathanh);
        }
        public int xoaAlbum()
        {
            return objAlbum.xoaAlbum(maalbum);
        }
        public int capnhatalbum()
        {
            return objAlbum.capnhatAlbum(maalbum, tenalbum, Namphathanh);
        }
        public int xoaBaiHat_by_Album()
        {
            return objAlbum.xoaBaiHatKhoiAlBum(maalbum);
        }
        #endregion
    }
}
