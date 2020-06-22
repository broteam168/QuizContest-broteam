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
    public partial class KhoiTaoDeThi_View : DevExpress.XtraEditors.XtraForm
    {
        private KhoiTaoDeThi_Controler cls;
        private int D, TB, K;
        private string userName;
        private int id_;
        public KhoiTaoDeThi_View(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            cls = new KhoiTaoDeThi_Controler();
            init();
        }
        public void init() {
            cbChude.Properties.DataSource = cls.listChude();
            cbChude.Properties.NullText = "Vui lòng chọn chủ đề";
            gridDeThi.DataSource = cls.listDeThi();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtTieuDe.Text.Trim()!=""&&txtThoiGian.Text.Trim()!=""&&!txtTong.Text.Equals("0"))
            {
                try
                {
                    int thoiGian = int.Parse(txtThoiGian.Text);
                    DeThi dt = new DeThi();
                    dt.Tieu_De = txtTieuDe.Text;
                    dt.Ma_Chu_De = int.Parse(cbChude.EditValue.ToString());
                    dt.SL_De = D;
                    dt.SL_TrungBinh = TB;
                    dt.SL_Kho = K;
                    dt.Thoi_Gian_Lam_Bai = thoiGian;
                    dt.Nguoi_Tao = userName;
                    dt.Ngay_Tao = DateTime.Now;
                    dt.Trang_Thai = checkBox1.Checked;
                    cls.addDethi(dt);
                    gridDeThi.DataSource = null;
                    gridDeThi.DataSource = cls.listDeThi();
                    MessageBox.Show("Tạo đề thi thành công!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể thực hiện.Có lỗi xảy ra vui lòng kiểm tra lại.");
                }
            }
            else
            {
                MessageBox.Show("Không được để trống các trường!");
            }
        }

        private void txtDe_TextChanged(object sender, EventArgs e)
        {
            try
            {
                D = int.Parse(txtDe.Text);
                if (D<=int.Parse(lbDe.Text))
                {
                    int s = D+TB+K;
                    txtTong.Text = s.ToString();
                }
                else
                {
                    MessageBox.Show("Số lượng đề dễ phải nhỏ hơn hoặc bằng tổng số lượng đề trong kho.");
                    txtDe.Text = "0";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Số lượng phải là số.");
                txtDe.Text = "0";
            }
        }

        private void txtTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TB = int.Parse(txtTB.Text);
                if (TB <= int.Parse(lbTB.Text))
                {
                    int s = D + TB + K;
                    txtTong.Text = s.ToString();
                }
                else
                {
                    MessageBox.Show("Số lượng đề trung bình phải nhỏ hơn hoặc bằng tổng số lượng đề trong kho.");
                    txtTB.Text = "0";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Số lượng phải là số.");
                txtTB.Text = "0";
            }
        }

        private void txtKho_TextChanged(object sender, EventArgs e)
        {
            try
            {
                K = int.Parse(txtKho.Text);
                if (K <= int.Parse(lbKho.Text))
                {
                    int s = D + TB + K;
                    txtTong.Text = s.ToString();
                }
                else
                {
                    MessageBox.Show("Số lượng đề khó phải nhỏ hơn hoặc bằng tổng số lượng đề trong kho.");
                    txtKho.Text = "0";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Số lượng phải là số.");
                txtKho.Text = "0";
            }
        }

        private void cbChude_EditValueChanged(object sender, EventArgs e)
        {
            txtDe.Enabled = true;
            txtTB.Enabled = true;
            txtKho.Enabled = true;
            lbDe.Text = cls.countDe(int.Parse(cbChude.EditValue.ToString()), 'D').ToString();
            lbTB.Text = cls.countDe(int.Parse(cbChude.EditValue.ToString()), 'T').ToString();
            lbKho.Text = cls.countDe(int.Parse(cbChude.EditValue.ToString()), 'K').ToString();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                id_ = int.Parse(gridView1.GetFocusedRowCellValue("id").ToString());
                bool t = bool.Parse(gridView1.GetFocusedRowCellValue("Trang_Thai").ToString());
                if (t)
                {
                    checkBox2.Checked = true;
                }
                else
                {
                    checkBox2.Checked = false;
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            cls.update(id_,checkBox2.Checked);
            MessageBox.Show("Cập nhật thành công!");
            gridDeThi.DataSource = null;
            gridDeThi.DataSource = cls.listDeThi();
        }
    }
}
