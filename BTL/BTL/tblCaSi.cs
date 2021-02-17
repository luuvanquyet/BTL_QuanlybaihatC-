using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
    class tblCaSi
    {
        Casi_Data objCaSi = new Casi_Data();

        #region khai báo đối tượng , kiểm tra hợp lệ
        private string macasi;
        private string tencasi;


        public tblCaSi() { }
        public tblCaSi(string ma, string ten)
        {
            this.MACASI = ma;
            this.TENCASI = ten;
        }

        public tblCaSi(string macasi)
        {
            this.macasi = macasi;
        }
        public string MACASI
        {
            get { return macasi; }

            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Nhập mã ca sĩ !");
                else
                    macasi = value;
            }
        }

        public string TENCASI
        {
            get { return tencasi; }

            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Nhập tên ca sĩ !");
                else
                    tencasi = value;
            }
        }

        #endregion

        #region hàm lấy bảng dử liệu và các phương thức xử lý
        public DataTable getCaSi()
        {
            return objCaSi.getCasi();
        }
        public DataTable getCasi_by_macasi(string macasi)
        {
            return objCaSi.getCaSi_by_macasi(macasi);
        }
        public int themCaSi()
        {
            return objCaSi.themCaSi(macasi, tencasi);
        }
        public int xoaCasi()
        {
            return objCaSi.xoaCaSi(macasi);
        }
        public int capnhapCaSi()
        {

            return objCaSi.capnhatCaSi(macasi, tencasi);
        }
        #endregion
    }
}
