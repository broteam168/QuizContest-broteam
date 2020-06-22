using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThiTracNghiem_Son.Controler
{
    class Lop_controler
    {
         private DataTracNghiemDataContext db;
         public Lop_controler()
        {
            db = new DataTracNghiemDataContext(DoAnThiTracNghiem_Son.Properties.Settings.Default.connection);//QLBH.Properties.Settings.Default.connect
        }
         public List<taiKhoan> listTaiKhoan()
         {
             return db.taiKhoans.ToList();
         }
         public List<Khoi> listKhoi()
         {
             return db.Khois.ToList();
         }
         public List<Nien_khoa> listNienKhoa()
         {
             return db.Nien_khoas.ToList();
         }
        public List<TaiKoan_H> listTaiKhoan_H() {
            return db.TaiKoan_Hs.ToList();
        }
        public void add(TaiKoan_H obj)
        {
            db.TaiKoan_Hs.InsertOnSubmit(obj);
            db.SubmitChanges();
        }
        public void update(TaiKoan_H obj) {
            var d = db.TaiKoan_Hs.Where(p => p.id == obj.id).FirstOrDefault();
            if (d!=null)
            {
                d.id = obj.id;
                d.Khoi = db.Khois.Single(p => p.id == obj.id_khoi);
                d.Nien_khoa = db.Nien_khoas.Single(p => p.id == obj.id_nien_khoa);
                d.lop = obj.lop;
                db.SubmitChanges();
            }
        }
        public void delete(int id) {
            /*var d = db..Where(p => p.id == id).FirstOrDefault();
            if (d!=null)
            {
                db.TaiKoan_Hs.DeleteOnSubmit(d);
                db.SubmitChanges();
            }*/
        }
        public bool checkExistKhoi(int idUser,int idKhoi) {
           var d = db.TaiKoan_Hs.Where(p => p.id_TaiKhoan == idUser && p.id_khoi==idKhoi).Count();
            if (d>0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool checkExistNienKhoa(int idUser, int idNienKhoa)
        {
            var d = db.TaiKoan_Hs.Where(p => p.id_TaiKhoan == idUser && p.id_nien_khoa == idNienKhoa).Count();
            if (d > 0)
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
