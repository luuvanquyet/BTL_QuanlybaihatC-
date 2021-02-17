using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
    class tblCasi_Baihat
    {
        Casi_Baihat_Data objCasi_baihat = new Casi_Baihat_Data();

        #region lấy dử liệu
        public DataTable getCasi_BaiHat_by_mabaihat(string mabaihat)
        {
            return objCasi_baihat.getCasi_BaiHat_by_mabaihat(mabaihat);
        }

        public DataTable getCasi_BaiHat_by_macasi(string macasi)
        {
            return objCasi_baihat.getCasi_BaiHat_by_macasi(macasi);
        }
        #endregion
    }
}
