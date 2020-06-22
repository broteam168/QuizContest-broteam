using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThiTracNghiem_Son.Controler
{
    class LichSuThi_Controler
    {
        private DataTracNghiemDataContext db;
        public LichSuThi_Controler()
        {
            db = new DataTracNghiemDataContext(DoAnThiTracNghiem_Son.Properties.Settings.Default.connection);//QLBH.Properties.Settings.Default.connect
        }
        public List<BatDau> listBD(string userName) {
            return db.BatDaus.Where(p => p.Nguoi_Lam.Equals(userName)).ToList();
        }
        public void delete(int id) {
            var d = db.BatDaus.Where(p => p.id == id).SingleOrDefault();
            db.BatDaus.DeleteOnSubmit(d);
            db.SubmitChanges();
        }
        public bool checkExist(string userName,int made) {
            var d = db.De_Hs.Where(p => p.Ma_Chu_De.Equals(made) && p.Nguoi_Lam.Equals(userName)).Count();
            Console.WriteLine("made"+made+" tai khoa"+userName);
            if (d!=0)
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
