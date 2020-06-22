using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThiTracNghiem_Son.Controler
{
    class DoiMatKhau_Controler
    {
        private DataTracNghiemDataContext db;
        public DoiMatKhau_Controler()
        {
            db = new DataTracNghiemDataContext(DoAnThiTracNghiem_Son.Properties.Settings.Default.connection);//QLBH.Properties.Settings.Default.connect
        }
        public string getMatKhau(string userName) {
            return db.taiKhoans.Where(p => p.userName.Equals(userName)).FirstOrDefault().pass;
        }
        public taiKhoan getTK(string userName)
        {
            return db.taiKhoans.Where(p => p.userName.Equals(userName)).SingleOrDefault();
        }
        public void update(taiKhoan obj) {
            var d = db.taiKhoans.Where(p => p.userName.Equals(obj.userName)).SingleOrDefault();
            if (d!=null)
            {
                d.id = obj.id;
                d.pass = obj.pass;
                db.SubmitChanges();
            }
        }
    }
}
