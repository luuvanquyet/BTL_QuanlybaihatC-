using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
    class tblBaihat
    {
        Baihat_Data objBaiHat = new Baihat_Data();

        #region khai báo đối tượng BaiHat và kiểm tra hợp lệ

        private string mabaihat;
        private string tenbaihat;
        private string matheloai;
        private string maalbum;
        private string macasi;
        private string matacgia;
        private string mahangsanxuat;
        private string loibaihat;

        public tblBaihat() { }

        public tblBaihat(string ma, string ten, string matl, string maal, string macs, string matg, string masx, string loi)
        {
            this.MABAIHAT = ma;
            this.TENBAIHAT = ten;
            this.matheloai = matl;
            this.maalbum = maal;
            this.macasi = macs;
            this.matacgia = matg;
            this.mahangsanxuat = masx;
            this.LOIBAIHAT = loi;
        }

        public tblBaihat(string ma)
        {
            this.mabaihat = ma;
        }

        public string MABAIHAT
        {
            get 
            {
                return mabaihat;
            }
            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Nhập mã bài hát !");
                else
                    mabaihat = value;
            }
        }

        public string TENBAIHAT
        {
            get 
            {
                return tenbaihat;
            }
            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Nhập tên bài hát !");
                else
                    tenbaihat = value;
            }
        }
        public string LOIBAIHAT
        {
            get
            { 
                return loibaihat; 
            }
            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Chưa nhập lời cho bài hát !");
                else
                    loibaihat = value;
            }
        }
        #endregion

    

        #region các phương thức xử lý
        public int themBaiHat()
        {
            return objBaiHat.themBaiHat(mabaihat, tenbaihat, matheloai, maalbum, macasi, matacgia, mahangsanxuat, loibaihat);
        }
        public int xoaBaiHat()
        {
            return objBaiHat.xoaBaiHat(mabaihat);
        }
        public int capnhatBaiHat()
        {
            return objBaiHat.capnhatBaiHat(mabaihat, tenbaihat, matheloai, maalbum, macasi, matacgia, mahangsanxuat, loibaihat);
        }
        #endregion

        #region các hàm lấy dử liệu bài hát (table)


        public DataTable getBaiHat()
        {
            return objBaiHat.getBaiHat();
        }

        public DataTable getBaiHat_home()
        {
            return objBaiHat.getBaiHat_Home();
        }


        public DataTable getBaiHat_by_album(string maalbum)
        {
            return objBaiHat.getBaiHat_by_Album(maalbum);
        }

        public DataTable getBaiHat_by_TheLoai(string matheloai)
        {
            return objBaiHat.getBaiHat_by_TheLoai(matheloai);
        }
        public DataTable getBaiHat_by_mabaihat(string mabaihat)
        {
            return objBaiHat.getBaiHat_by_mabaihat(mabaihat);
        }


        public DataTable getBaiHat_cbo(string matheloai, string maalbum, string macasi, string matacgia, string mahangsanxuat)
        {
            return objBaiHat.getBaiHat_by_cbo(matheloai, maalbum, macasi, matacgia, mahangsanxuat);
        }

        public DataTable getBaiHat_cbo(string matheloai, string maalbum)
        {
            return objBaiHat.getBaiHat_by_cbo(matheloai, maalbum);
        }
        public DataTable getBaiHat_by_Tenbaihat(string tenbh)
        {
            return objBaiHat.getBaihat_by_tenbaihat(tenbh);
        }
        public DataTable getBaiHat_by_Tentheloai(string tentheloai)
        {
            return objBaiHat.getBaihat_by_tentheloai(tentheloai);
        }
        public DataTable getBaiHat_by_Tenalbum(string tenalbum)
        {
            return objBaiHat.getBaihat_by_tenalbum(tenalbum);
        }
        public DataTable getBaiHat_by_TenCasi(string tencasi)
        {
            return objBaiHat.getBaihat_by_tencasi(tencasi);
        }
        public DataTable getBaiHat_by_TenTacgia(string tentacgia)
        {
            return objBaiHat.getBaihat_by_tentacgia(tentacgia);
        }
        public DataTable getBaiHat_by_Tenhangsanxuat(string tenhangsx)
        {
            return objBaiHat.getBaihat_by_tenhangsanxuat(tenhangsx);
        }
        public DataTable getBaiHat_by_Loibaihat(string loibaihat)
        {
            return objBaiHat.getBaihat_by_loibaihat(loibaihat);
        }
        #endregion
    }
}
