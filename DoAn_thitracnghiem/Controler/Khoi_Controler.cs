using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThiTracNghiem_Son.Controler
{
    class Khoi_Controler
    {
         private DataTracNghiemDataContext db;
         public Khoi_Controler()
        {
            db = new DataTracNghiemDataContext(DoAnThiTracNghiem_Son.Properties.Settings.Default.connection);//QLBH.Properties.Settings.Default.connect
        }
        public List<Khoi> listKhoi() {
            return db.Khois.ToList();
        }
        public void add(Khoi obj)
        {
            db.Khois.InsertOnSubmit(obj);
            db.SubmitChanges();
        }
        public void update(Khoi obj) {
            var d = db.Khois.Where(p => p.id == obj.id).FirstOrDefault();
            if (d!=null)
            {
                d.id = obj.id;
                d.khoi1 = obj.khoi1;
                db.SubmitChanges();
            }
        }
        public void delete(int id) {
            var d = db.Khois.Where(p => p.id == id).FirstOrDefault();
            if (d!=null)
            {
                db.Khois.DeleteOnSubmit(d);
                db.SubmitChanges();
            }
        }
        public bool checkExist(int id) {
            var d = db.TaiKoan_Hs.Where(p => p.id_khoi == id).Count();
            if (d>0)
            {
                return false;
            }
            else
            {
                return true;
            }
        
        }
    }
}
