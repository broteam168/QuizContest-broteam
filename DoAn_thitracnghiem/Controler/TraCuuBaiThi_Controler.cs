using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThiTracNghiem_Son.Controler
{
    class TraCuuBaiThi_Controler
    {
        private DataTracNghiemDataContext db;
        public TraCuuBaiThi_Controler()
        {
            db = new DataTracNghiemDataContext(DoAnThiTracNghiem_Son.Properties.Settings.Default.connection);//QLBH.Properties.Settings.Default.connect
        }
        public List<De_H> ChiTietDeThiHS(string tieude,string userName){
            return db.De_Hs.Where(p => p.DeThi.Tieu_De.Contains(tieude) && p.Nguoi_Lam.Equals(userName)).ToList();
        }
    }
}
