using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThiTracNghiem_Son.Controler
{
    class QuanLyTaiKhoan_Controler
    {
        private DataTracNghiemDataContext db;
        public QuanLyTaiKhoan_Controler()
        {
            db = new DataTracNghiemDataContext(DoAnThiTracNghiem_Son.Properties.Settings.Default.connection);//QLBH.Properties.Settings.Default.connect
        }
        public List<taiKhoan> listTaiKhoan()
        {
            return db.taiKhoans.ToList();
        }
        public bool checkExist(string userName)
        {
            var d = db.taiKhoans.Where(p => p.userName.Equals(userName)).Count();
            if (d == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void instert(taiKhoan obj)
        {
            db.taiKhoans.InsertOnSubmit(obj);
            db.SubmitChanges();
        }
        public void update(taiKhoan obj)
        {
            var d = db.taiKhoans.Where(p => p.id.Equals(obj.id)).SingleOrDefault();
            if (d != null)
            {
                d.HoTen = obj.HoTen;
                d.phanQuyen = obj.phanQuyen;
                d.thongTin = obj.thongTin;
                db.SubmitChanges();
            }
        }
        public void resetPass(string userName)
        {
            var d = db.taiKhoans.Where(p => p.userName.Equals(userName)).SingleOrDefault();
            if (d != null)
            {
                d.pass = userName;
                db.SubmitChanges();
            }
        }
        public void delete(int id)
        {
            var d = db.taiKhoans.Where(p => p.id == id).FirstOrDefault();
            if (d != null)
            {
                db.taiKhoans.DeleteOnSubmit(d);
                db.SubmitChanges();
            }
        }
        public bool checkExist1(string userName)
        {
            var d1 = db.De_Hs.Where(p => p.Nguoi_Lam.Equals(userName)).Count();
            var d2 = db.BatDaus.Where(p => p.Nguoi_Lam.Equals(userName)).Count();
            if (d1 != 0 || d2 != 0)
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
