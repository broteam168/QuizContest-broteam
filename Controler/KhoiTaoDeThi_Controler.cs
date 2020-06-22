using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThiTracNghiem_Son.Controler
{
    class KhoiTaoDeThi_Controler
    {
        private DataTracNghiemDataContext db;
        public KhoiTaoDeThi_Controler()
        {
            db = new DataTracNghiemDataContext(DoAnThiTracNghiem_Son.Properties.Settings.Default.connection);//QLBH.Properties.Settings.Default.connect
        }
        public List<DeThi> listDeThi() {
            return db.DeThis.ToList();
        }
        public void addDethi(DeThi obj) {
            db.DeThis.InsertOnSubmit(obj);
            db.SubmitChanges();
        }
        public List<ChuDe> listChude() {
            return db.ChuDes.ToList();
        }
        public int countDe(int maCD,char loai) {
            return db.CauHois.Where(p => p.Cap_Do.Equals(loai)).Count();
        }
        public void update(int id,bool tt) {
            var d = db.DeThis.Where(p => p.id == id).SingleOrDefault();
            if (d!=null)
            {
                d.Trang_Thai = tt;
                db.SubmitChanges();
            }
        }
    }
}
