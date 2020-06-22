using DoAnThiTracNghiem_Son.Controler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThiTracNghiem_Son
{
    public partial class LichSuThi_View : DevExpress.XtraEditors.XtraForm
    {
        private LichSuThi_Controler cls;
        private int id_,machude;
        private string tk;
        public LichSuThi_View()
        {
            InitializeComponent();
            cls = new LichSuThi_Controler();
        }

        private void LichSu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                id_ = int.Parse(LichSu.GetFocusedRowCellValue("id").ToString());
                tk = LichSu.GetFocusedRowCellValue("Nguoi_Lam").ToString(); Console.WriteLine("machude"+machude);
                machude = int.Parse(LichSu.GetFocusedRowCellValue("Ma_DeThi").ToString());
                labelControl2.Text = LichSu.GetFocusedRowCellValue("Thoi_Gian").ToString();
                btXoa.Enabled = true;
            }
            catch (Exception)
            {
                
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim()!="")
            {
                gridLichSu.DataSource = null;
                gridLichSu.DataSource = cls.listBD(txtTimKiem.Text.Trim());
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (cls.checkExist(tk,machude))
            {
                DialogResult ds = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo);
                if (ds==DialogResult.Yes)
                {
                    cls.delete(id_);
                    MessageBox.Show("Xóa thành công");
                    gridLichSu.DataSource = null;
                    gridLichSu.DataSource = cls.listBD(txtTimKiem.Text.Trim());
                }
            }
            else
            {
                MessageBox.Show("Bài thi này đã nộp bài không thể xóa lịch sử.");
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
