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
    public partial class ThiTracNghiem_VIEW : Form
    {
        private ThiTracNghiem_Controler cls;
        private DeThi dt;
        private DateTime thoiGianThi;
        private List<De_H> lst;
        private int sl = 0, cauHienTai=0,id_TaiKhoan_HS;
        private string userName;
        public ThiTracNghiem_VIEW(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            lbTaiKhoan.Text = userName;
            cls = new ThiTracNghiem_Controler();
            init();
            id_TaiKhoan_HS = cls.get_id_TaiKhoan_HS(userName);
        }
        public void init() {
            cbChuDe.Properties.DataSource = cls.listDeThi();
            cbChuDe.Properties.NullText = "Vui lòng chọn đề thi"; 
            disable();
            
        }
        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            int id = int.Parse(cbChuDe.EditValue.ToString());
            dt = cls.getDeThi(id);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cls.checkBD(int.Parse(cbChuDe.EditValue.ToString()), userName))
                {
                    BatDau bd = new BatDau();
                    bd.Nguoi_Lam = userName;
                    bd.Thoi_Gian = cls.getDate(); 
                    bd.Ma_DeThi = int.Parse(cbChuDe.EditValue.ToString());
                    bd.Nop_Bai = false;
                    cls.insertBD(bd);
                    if (cls.checkThi(int.Parse(cbChuDe.EditValue.ToString()), userName))
                    {
                        enable();
                        lst = cls.addDe_HS(cls.listCauhoi(dt), userName, int.Parse(cbChuDe.EditValue.ToString()), id_TaiKhoan_HS);
                        docDe(sl);
                        lbSumTime.Text = dt.Thoi_Gian_Lam_Bai.ToString() + " phút";
                        int sum = int.Parse(dt.SL_De.ToString())+int.Parse(dt.SL_TrungBinh.ToString())+int.Parse(dt.SL_Kho.ToString());
                        lbSumCauHoi.Text = sum.ToString();
                        int time = int.Parse(dt.Thoi_Gian_Lam_Bai.ToString());
                        int gio = time / 60; 
                        int phut=time%60;
                        int giay=phut/60;
                        thoiGianThi = new DateTime(2000, 1, 1, gio,phut ,giay, 0);
                        lbThoiGian.Text =thoiGianThi.Hour.ToString()+" : " +thoiGianThi.Minute.ToString() + " : " + thoiGianThi.Second.ToString();
                        timer1.Enabled=true;
                        simpleButton2.Enabled = true;
                        cbChuDe.Enabled = false;
                        simpleButton1.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Bạn không được làm đề thi này. Vui lòng liên hệ với quản trị");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn không được làm đề thi này. Vui lòng liên hệ với quản trị");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể bắt đầu bài thi. Bạn vui lòng kiểm tra lại.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan dt = new TimeSpan(0, 0, 1);
            thoiGianThi = thoiGianThi.Subtract(dt);
            lbThoiGian.Text = thoiGianThi.Hour.ToString()+" : " +thoiGianThi.Minute.ToString() + " : " + thoiGianThi.Second.ToString();
            if (thoiGianThi.Minute == 0 && thoiGianThi.Second == 0)
            {
                try
                {
                    disable();
                    cls.insertDe_Hs(lst);
                    MessageBox.Show("Thời gian làm bài đã hết. Thành tích đạt được : " + KiemTraKetQua() + "/" + lst.Count + " câu đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    if (MessageBox.Show("Nộp bài không thành công, vui lòng kiểm tra lại kết nối", "Cảnh báo", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                    {
                        nopbai();
                    }
                }
            }
        }
        public void disable() {
            timer1.Enabled = false;
            rbA.Enabled = false;
            rbB.Enabled = false;
            rbC.Enabled = false;
            rbD.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            simpleButton2.Enabled = false;
        }
        public void enable()
        {
            timer1.Enabled = true;
            rbA.Enabled = true;
            rbB.Enabled = true;
            rbC.Enabled = true;
            rbD.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            simpleButton2.Enabled = true;
        }
        private void docDe(int i) {
            int a = i + 1;
            lbCauHoiSo.Text = "Nội dung câu hỏi số " + a; 
            cauHienTai = i;
            txtNoiDungCauHoi.Text = lst.ElementAt(i).Noi_Dung.ToString();
            txtDapAnA.Text = lst.ElementAt(i).Dap_An_A.ToString();
            txtDapAnB.Text = lst.ElementAt(i).Dap_An_B.ToString();
            txtDapAnC.Text = lst.ElementAt(i).Dap_An_C.ToString();
            txtDapAnD.Text = lst.ElementAt(i).Dap_An_D.ToString();
            BatTrangThairadioButton(char.Parse(lst[cauHienTai].Dap_An_HS.ToString()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sl<lst.Count-1)
            {
                sl++;
                docDe(sl);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sl>0)
            {
                sl--;
                docDe(sl);
            }
        }
        private void BatTrangThairadioButton(int co)
        {
            if (co == 1)
                rbA.Checked = true;
            else if (co == 2)
                rbB.Checked = true;
            else if (co == 3)
                rbC.Checked = true;
            else if (co == 4)
                rbD.Checked = true;
            else
            {
                rbA.Checked = false;
                rbB.Checked = false;
                rbC.Checked = false;
                rbD.Checked = false;
            }
        }
        private void LuuCauTraLoi()
        {
            if (KTTraLoi() == 1)
            {
                if (rbA.Checked == true)
                    lst[cauHienTai].Dap_An_HS = 'A';
                if (rbB.Checked == true)
                    lst[cauHienTai].Dap_An_HS = 'B';
                if (rbC.Checked == true)
                    lst[cauHienTai].Dap_An_HS = 'C';
                if (rbD.Checked == true)
                    lst[cauHienTai].Dap_An_HS = 'D';
            }
            else
                lst[cauHienTai].Dap_An_HS = 'o';
            DanhsachCauDaTraLoi();
        }
        private int KTTraLoi()
        {
            if (rbA.Checked == true || rbB.Checked == true || rbC.Checked == true || rbD.Checked == true)
                return 1;
            return 0;
        }

        private void rbA_CheckedChanged(object sender, EventArgs e)
        {
            LuuCauTraLoi();
        }

        private void rbB_CheckedChanged(object sender, EventArgs e)
        {
            LuuCauTraLoi();
        }

        private void rbC_CheckedChanged(object sender, EventArgs e)
        {
            LuuCauTraLoi();
        }

        private void rbD_CheckedChanged(object sender, EventArgs e)
        {
            LuuCauTraLoi();
        }
        private void BatTrangThairadioButton(char co)
        {
            if (co == 'A')
                rbA.Checked = true;
            else if (co == 'B')
                rbB.Checked = true;
            else if (co == 'C')
                rbC.Checked = true;
            else if (co == 'D')
                rbD.Checked = true;
            else
            {
                rbA.Checked = false;
                rbB.Checked = false;
                rbC.Checked = false;
                rbD.Checked = false;
            }
        }
        public void DanhsachCauDaTraLoi() {
            lbSumTraLoi.Text = "";
            int tr = 0;
            for (int i = 1; i <= lst.Count; i++)
            {
                if (lst[i-1].Dap_An_HS!='o')
                {
                    if (lbSumTraLoi.Text=="")
                    {
                        lbSumTraLoi.Text =  i.ToString();
                    }
                    else
                    {
                        lbSumTraLoi.Text = lbSumTraLoi.Text + "," + i;
                    }
                    tr++;
                }
            }
            lbSumTrl.Text = tr.ToString();
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn kết thúc bài thi?", "xác thực", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    nopbai();
                
                }
            }
            catch (Exception)
            {
                if (MessageBox.Show("Nộp bài không thành công, vui lòng kiểm tra lại kết nối","Cảnh báo",MessageBoxButtons.RetryCancel)==DialogResult.Retry)
                {
                    nopbai();
                }
            }
        }
        public void nopbai() {
            try
            {
                disable();
                cls.insertDe_Hs(lst);
                cls.updateBatDau(userName,int.Parse(cbChuDe.EditValue.ToString()));
                timer1.Enabled = false;
                MessageBox.Show("Nộp bài thành công! Thành tích đạt được : " + KiemTraKetQua() + "/" + lst.Count + " câu đúng", "Thông báo");
            }
            catch (Exception)
            {
                if (MessageBox.Show("Nộp bài không thành công, vui lòng kiểm tra lại kết nối", "Cảnh báo", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    nopbai();
                }
            }
        }
        public int KiemTraKetQua() {
            int kq = 0;
            foreach (var item in lst)
            {
                if (item.Dap_An_Dung==item.Dap_An_HS)
                {
                    kq++;
                }
            }
            return kq;
        }

        private void lbTaiKhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DoiMatKhau_View frm = new DoiMatKhau_View(userName);
            frm.ShowDialog();
        }

        private void ThiTracNghiem_VIEW_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có chắc chắn muốn tắt phần mềm không?","Cảnh báo",MessageBoxButtons.YesNo);
            if (dl==DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                try
                {
                    CloseReason closeReason = e.CloseReason;
                    if (closeReason == CloseReason.UserClosing)
                    {
                        e.Cancel = true;
                    }
                    base.OnFormClosing(e);
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
