using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThiTracNghiem_Son.Controler
{
    class TaoDeThi_Controler
    {
        private DataTracNghiemDataContext db;
        public TaoDeThi_Controler()
        {
            db = new DataTracNghiemDataContext(DoAnThiTracNghiem_Son.Properties.Settings.Default.connection);//QLBH.Properties.Settings.Default.connect
        }
        public List<CauHoi> listCauhoi() {
            return db.CauHois.ToList();
        }
        public List<ChuDe> listChude()
        {
            return db.ChuDes.ToList();
        }
        public void addCauHoi(CauHoi obj)
        {
            db.CauHois.InsertOnSubmit(obj);
            db.SubmitChanges();
        }
        public void updateCauHoi(CauHoi obj)
        {
            CauHoi _obj = db.CauHois.Where(ch => ch.id == obj.id).SingleOrDefault() ;
            if (_obj!=null)
            {
                _obj.ChuDe = db.ChuDes.Single(p => p.ID == obj.Ma_Chu_De);
                _obj.Tieu_De = obj.Tieu_De;
                _obj.Noi_Dung = obj.Noi_Dung;
                _obj.Dap_An_A = obj.Dap_An_A;
                _obj.Dap_An_B = obj.Dap_An_B;
                _obj.Dap_An_C = obj.Dap_An_C;
                _obj.Dap_An_D = obj.Dap_An_D;
                _obj.Dap_An_Dung = obj.Dap_An_Dung;
                _obj.Cap_Do = obj.Cap_Do;
                db.SubmitChanges();
            }
        }
        public void delete(CauHoi obj) {
            db.CauHois.DeleteOnSubmit(obj);
            db.SubmitChanges();
        }
    }
}
