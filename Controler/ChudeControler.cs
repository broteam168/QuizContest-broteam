using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThiTracNghiem_Son.Controler
{
    class ChudeControler
    {
        private DataTracNghiemDataContext db;
        public ChudeControler()
        {
            db = new DataTracNghiemDataContext(DoAnThiTracNghiem_Son.Properties.Settings.Default.connection);//QLBH.Properties.Settings.Default.connect
        }
        public List<ChuDe> listChude() {
            return db.ChuDes.ToList();
        }
        public void add(ChuDe obj)
        {
            db.ChuDes.InsertOnSubmit(obj);
            db.SubmitChanges();
        }
        public void update(ChuDe obj) {
            var d = db.ChuDes.Where(p => p.ID == obj.ID).FirstOrDefault();
            if (d!=null)
            {
                d.ID = obj.ID;
                d.Ten_Chu_De = obj.Ten_Chu_De;
                db.SubmitChanges();
            }
        }
        public void delete(int id) {
            var d = db.ChuDes.Where(p => p.ID == id).FirstOrDefault();
            if (d!=null)
            {
                db.ChuDes.DeleteOnSubmit(d);
                db.SubmitChanges();
            }
        }
        public bool checkExist(int id) {
            var d = db.DeThis.Where(p => p.Ma_Chu_De == id).Count();
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
