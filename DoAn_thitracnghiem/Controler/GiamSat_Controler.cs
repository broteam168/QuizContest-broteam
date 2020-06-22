using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThiTracNghiem_Son.Controler
{
    class GiamSat_Controler
    {
        private DataTracNghiemDataContext db;
        public GiamSat_Controler()
        {
            db = new DataTracNghiemDataContext(DoAnThiTracNghiem_Son.Properties.Settings.Default.connection);//QLBH.Properties.Settings.Default.connect
        }
        public List<DeThi> getDanhSanhDe() {
            return db.DeThis.Where(p => p.Trang_Thai == true).ToList();
        }
        public List<BatDau> getDanhSachHS(int maDeThi) {
            return db.BatDaus.Where(p => p.Ma_DeThi == maDeThi).ToList();
        }
        public List<GiamSat> getGiamSat(int maDeThi) {
            List<GiamSat> lGS = new List<GiamSat>();
            List<BatDau> lst = getDanhSachHS(maDeThi);
            foreach (var item in lst)
            {
                GiamSat gs = new GiamSat();
                gs.Ma_DeThi = item.Ma_DeThi;
                gs.Nguoi_Lam = item.Nguoi_Lam;
                gs.THOI_GIAN_LAM = int.Parse(item.DeThi.Thoi_Gian_Lam_Bai.ToString());
                gs.THOI_GIAN_BAT_DAU = DateTime.Parse(item.Thoi_Gian.ToString());
                if (bool.Parse(item.Nop_Bai.ToString()))
                {
                    gs.Trang_Thai = "Đã nộp bài";
                }
                else
                {
                    DateTime hetthoigian = gs.THOI_GIAN_BAT_DAU.AddMinutes(gs.THOI_GIAN_LAM);
                    TimeSpan tm =  db.GetServerDate()-hetthoigian;
                    if (tm.Days*24*60+tm.Hours*60+tm.Minutes>gs.THOI_GIAN_LAM)
	                {
		                gs.Trang_Thai = "Quá thời gian làm bài. Học sinh chưa nộp bài. Cần kiểm tra lại!";
	                }
                    else
	                {
                        TimeSpan tm1 = hetthoigian- db.GetServerDate();
                        gs.Trang_Thai="Đang làm bài thi. Thời gian còn lại : "+tm1.Minutes.ToString()+ " phút";
	                }
                }
                lGS.Add(gs);
            }
            return lGS;
        }
    }
}
