using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThiTracNghiem_Son.Controler
{
    class Login_controler
    {
        private DataTracNghiemDataContext db;
        public Login_controler()
        {
            db = new DataTracNghiemDataContext(DoAnThiTracNghiem_Son.Properties.Settings.Default.connection);//QLBH.Properties.Settings.Default.connect
        }
        public taiKhoan getUser(string us, string pass) {
            return db.taiKhoans.Where(p => p.userName.Equals(us) && p.pass.Equals(pass)).SingleOrDefault();
        }
    }
}
