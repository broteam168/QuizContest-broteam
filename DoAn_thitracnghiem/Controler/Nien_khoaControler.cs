using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThiTracNghiem_Son.Controler
{
    class Nien_khoaControler
    {
         private DataTracNghiemDataContext db;
         public Nien_khoaControler()
        {
            db = new DataTracNghiemDataContext(DoAnThiTracNghiem_Son.Properties.Settings.Default.connection);//QLBH.Properties.Settings.Default.connect
        }
        public List<Nien_khoa> listNien_khoa() {
            return db.Nien_khoas.ToList();
        }
        public void add(Nien_khoa obj)
        {
            db.Nien_khoas.InsertOnSubmit(obj);
            db.SubmitChanges();
        }
        public void update(Nien_khoa obj) {
            var d = db.Nien_khoas.Where(p => p.id == obj.id).FirstOrDefault();
            if (d!=null)
            {
                d.id = obj.id;
                d.nien_khoa1 = obj.nien_khoa1;
                db.SubmitChanges();
            }
        }
        public void delete(int id) {
            var d = db.Nien_khoas.Where(p => p.id == id).FirstOrDefault();
            if (d!=null)
            {
                db.Nien_khoas.DeleteOnSubmit(d);
                db.SubmitChanges();
            }
        }
        public bool checkExist(int id) {
            var d = db.TaiKoan_Hs.Where(p => p.id_nien_khoa == id).Count();
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
