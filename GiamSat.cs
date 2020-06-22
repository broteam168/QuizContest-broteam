using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThiTracNghiem_Son
{
    class GiamSat
    {
        private int _Ma_DeThi;
        private string _Nguoi_Lam;

        private DateTime _THOI_GIAN_BAT_DAU;

        private int _THOI_GIAN_LAM;

        private string _Trang_Thai;


        public GiamSat()
		{
		}

        public int Ma_DeThi
        {
            get
            {
                return this._Ma_DeThi;
            }
            set
            {
                this._Ma_DeThi = value;
            }
        }
        public string Nguoi_Lam
		{
			get
			{
                return this._Nguoi_Lam;
			}
			set
			{
                this._Nguoi_Lam = value;
			}
		}

        public DateTime THOI_GIAN_BAT_DAU
        {
            get
            {
                return this._THOI_GIAN_BAT_DAU;
            }
            set
            {
                this._THOI_GIAN_BAT_DAU = value;
            }
        }
        public int THOI_GIAN_LAM
        {
            get
            {
                return this._THOI_GIAN_LAM;
            }
            set
            {
                this._THOI_GIAN_LAM = value;
            }
        }
        public string Trang_Thai {
            get {
                return this._Trang_Thai;
            }
            set {
                this._Trang_Thai = value;
            }
        }
    }
}
