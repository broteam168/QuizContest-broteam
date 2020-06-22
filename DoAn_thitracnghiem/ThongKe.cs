using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThiTracNghiem_Son
{
    class ThongKe
    {
        private string _userName;

        private string _lop;

        private DateTime _THOI_GIAN_LAM;

        private System.Nullable<int> _SUM_TIME;

        private System.Nullable<int> _SUM_CAUHOI;

        private System.Nullable<int> _SUM_DUNG;


        public ThongKe()
		{
		}

        public string lop
		{
			get
			{
                return this._lop;
			}
			set
			{
                this._lop = value;
			}
		}
        public string userName
        {
            get
            {
                return this._userName;
            }
            set
            {
                this._userName = value;
            }
        }
        public DateTime THOI_GIAN_LAM
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
        public System.Nullable<int> SUM_TIME
        {
            get
            {
                return this._SUM_TIME;
            }
            set
            {
                this._SUM_TIME = value;
            }
        }
        public System.Nullable<int> SUM_CAUHOI
        {
            get
            {
                return this._SUM_CAUHOI;
            }
            set
            {
                this._SUM_CAUHOI = value;
            }
        }
        public System.Nullable<int> SUM_DUNG
        {
            get
            {
                return this._SUM_DUNG;
            }
            set
            {
                this._SUM_DUNG = value;
            }
        }
        

    }
}
