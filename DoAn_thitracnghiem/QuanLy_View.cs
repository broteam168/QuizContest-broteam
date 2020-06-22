using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace DoAnThiTracNghiem_Son
{
    public partial class QuanLy_View : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string userName;
        public QuanLy_View(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }
        private void loadForm(XtraForm frm)
        {
            try
            {
                foreach (XtraForm f in MdiChildren)
                {
                    if (f.Name == frm.Name)
                    {
                        f.Activate();
                        return;
                    }
                }
                frm.MdiParent = this;
                frm.Show();

            }
            catch (Exception)
            {

            }
        }
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            TaoDeThi frm = new TaoDeThi(userName);
            loadForm(frm);
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            KhoiTaoDeThi_View frm = new KhoiTaoDeThi_View(userName);
            loadForm(frm);
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            TraCuuBaiThi frm = new TraCuuBaiThi();
            loadForm(frm);
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThongKe_View frm = new ThongKe_View();
            loadForm(frm);
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            QuanLyTaiKhoan_View frm = new QuanLyTaiKhoan_View();
            loadForm(frm);
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            DoiMatKhau_View frm = new DoiMatKhau_View(userName);
            frm.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            LichSuThi_View frm = new LichSuThi_View();
            loadForm(frm);
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            TaoChuDe_View frm = new TaoChuDe_View();
            loadForm(frm);
        }

        private void QuanLy_View_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            GiamSat_View frm = new GiamSat_View();
            loadForm(frm);
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            TaoNienKhoa frm = new TaoNienKhoa();
            loadForm(frm);
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            TaoKhoi frm = new TaoKhoi();
            loadForm(frm);
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            TaoLop frm = new TaoLop();
            loadForm(frm);
        }

        private void QuanLy_View_Load(object sender, EventArgs e)
        {

        }
    }
}