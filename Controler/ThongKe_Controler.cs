using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThiTracNghiem_Son.Controler
{
    class ThongKe_Controler
    {
        private DataTracNghiemDataContext db;
        public ThongKe_Controler()
        {
            db = new DataTracNghiemDataContext(DoAnThiTracNghiem_Son.Properties.Settings.Default.connection);//QLBH.Properties.Settings.Default.connect
        }
        public List<DeThi> getDeThi() {
            return db.DeThis.ToList();
        }
        public List<ThongKe> listThongKe(int maDeThi) {
            List<ThongKe> lst = new List<ThongKe>();
            var d = from p in db.De_Hs where p.Ma_Chu_De == maDeThi group p by p.Nguoi_Lam;
            foreach (var item in d)
            {
                ThongKe obj = new ThongKe();
                obj.userName = item.First().Nguoi_Lam;
                obj.lop = item.First().TaiKoan_H.lop;
                obj.SUM_TIME = int.Parse(item.First().DeThi.Thoi_Gian_Lam_Bai.ToString());
                obj.THOI_GIAN_LAM = DateTime.Parse(item.First().Thoi_Gian.ToString());
                int s = int.Parse(item.First().DeThi.SL_De.ToString())+int.Parse(item.First().DeThi.SL_TrungBinh.ToString())+int.Parse(item.First().DeThi.SL_Kho.ToString());
                obj.SUM_CAUHOI = s;
                var d1 = db.De_Hs.Where(p => p.Ma_Chu_De == maDeThi && p.Nguoi_Lam == item.First().Nguoi_Lam).ToList();
                int i = 0;
                foreach (var item1 in d1)
                {
                    if (item1.Dap_An_HS.Equals(item1.Dap_An_Dung))
                    {
                        i++;
                    }
                }
                obj.SUM_DUNG = i;
                lst.Add(obj);
            }
            return lst;
        }
        public List<De_H> deThiHS(string userName,int maDe) {
            return db.De_Hs.Where(p => p.Nguoi_Lam.Equals(userName) && p.Ma_Chu_De == maDe).ToList();
        }
    }
}
