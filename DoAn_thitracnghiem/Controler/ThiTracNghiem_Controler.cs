using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThiTracNghiem_Son.Controler
{
    class ThiTracNghiem_Controler
    {
        private DataTracNghiemDataContext db;
        public ThiTracNghiem_Controler()
        {
            db = new DataTracNghiemDataContext(DoAnThiTracNghiem_Son.Properties.Settings.Default.connection);//QLBH.Properties.Settings.Default.connect
        }
        public DeThi getDeThi(int id) {
            return db.DeThis.Where(p => p.id == id).SingleOrDefault();
        }
        public List<DeThi> listDeThi() {
            return db.DeThis.Where(p => p.Trang_Thai == true).ToList();
        }
        public DateTime getDate() {
            return db.GetServerDate();
        }
        public void insertBD(BatDau obj) {
            db.BatDaus.InsertOnSubmit(obj);
            db.SubmitChanges();
        }
        public int get_id_TaiKhoan_HS(string userName) {
            try
            {
                return db.TaiKoan_Hs.Where(p => p.taiKhoan.userName.Equals(userName)).OrderByDescending(p => p.Khoi.khoi1).FirstOrDefault().id;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<CauHoi> listCauhoi(DeThi obj) {
            List<CauHoi> lst = new List<CauHoi>();
            Random rd = new Random();
            var d = db.CauHois.Where(p => p.Ma_Chu_De == obj.Ma_Chu_De && p.Cap_Do.Equals('D')).ToList();
            if (d.Count!=0)
            {
                if (d.Count>1)
                {
                    for (int i = 0; i < obj.SL_De; i++)
                    {
                    
                        int a = rd.Next(0, d.Count-1);
                        lst.Add(d.ElementAt(a));
                        d.RemoveAt(a);
                    }
                }
                else
                {
                    lst.Add(d.ElementAt(0));
                    d.RemoveAt(0);
                }
                
            }
            var tb = db.CauHois.Where(p => p.Ma_Chu_De == obj.Ma_Chu_De && p.Cap_Do.Equals('T')).ToList();
            if (tb.Count!=0)
            {
                if (tb.Count>1)
                {
                    for (int i = 0; i < obj.SL_TrungBinh; i++)
                    {
                        int a = rd.Next(0, tb.Count - 1);
                        lst.Add(tb.ElementAt(a));
                        tb.RemoveAt(a); 
                     }
                }
                else
                {
                    lst.Add(tb.ElementAt(0)); 
                    tb.RemoveAt(0);
                }
                
            }
            var k = db.CauHois.Where(p => p.Ma_Chu_De == obj.Ma_Chu_De && p.Cap_Do.Equals('K')).ToList();
            if (k.Count!=0)
            {
                if (k.Count>1)
                 {
                    for (int i = 0; i < obj.SL_Kho; i++)
                    {
                    
                        int a = rd.Next(0, k.Count - 1);
                        lst.Add(k.ElementAt(a));
                        k.RemoveAt(a);
                    }
                 }
                else
                {
                    lst.Add(k.ElementAt(0));
                    k.RemoveAt(0);
                }
                
            }
            return lst;
        }
        public List<De_H> addDe_HS(List<CauHoi> lst, string userName,int idDeThi,int id_TaiKhoan_HS)
        {
            List<De_H> lstH = new List<De_H>();
            foreach (var item in lst)
            {
                De_H obj = new De_H();
                obj.Ma_Chu_De = idDeThi;
                obj.Noi_Dung = item.Noi_Dung;
                obj.Dap_An_A = item.Dap_An_A;
                obj.Dap_An_B = item.Dap_An_B;
                obj.Dap_An_C = item.Dap_An_C;
                obj.Dap_An_D = item.Dap_An_D;
                obj.Dap_An_Dung = item.Dap_An_Dung;
                obj.Dap_An_HS = 'o';
                obj.Nguoi_Lam = userName;
                obj.Thoi_Gian = db.GetServerDate();
                obj.id_Tai_Khoan_HS = id_TaiKhoan_HS;
                lstH.Add(obj);
            }
            return lstH;
        }
        public void insertDe_Hs(List<De_H> obj) {
            db.De_Hs.InsertAllOnSubmit(obj);
            db.SubmitChanges();
        }
        public bool checkThi(int maChuDe,string userName) {
            var d = db.De_Hs.Where(p => p.Ma_Chu_De == maChuDe && p.Nguoi_Lam.Equals(userName)).Count();
            if (d==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkBD(int maChuDe, string userName)
        {
            var d = db.BatDaus.Where(p => p.Ma_DeThi == maChuDe && p.Nguoi_Lam.Equals(userName)).Count();
            if (d == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void updateBatDau(string Nguoi_Lam, int Ma_DeThi)
        {
            var d = db.BatDaus.Where(p => p.Nguoi_Lam.Equals(Nguoi_Lam) && p.Ma_DeThi == Ma_DeThi).FirstOrDefault();
            if (d!=null)
            {
                d.Nop_Bai = true;
                db.SubmitChanges();
            }
        }
    }
}
