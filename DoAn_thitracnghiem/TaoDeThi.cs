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
    public partial class TaoDeThi : DevExpress.XtraEditors.XtraForm
    {
        private string _Action;
        private TaoDeThi_Controler cls;
        private string UserName;
        private int id;
        public TaoDeThi(string userName)
        {
            InitializeComponent();
            this.UserName = userName;
            cls = new TaoDeThi_Controler();
            initTable();
        }
        private void initTable()
        {

            this.Cursor = Cursors.WaitCursor;
            changeControlState(true);
            gridDeThi.DataSource = cls.listCauhoi();
            cbChude.Properties.DataSource = cls.listChude();
            cbChude.Properties.NullText = "Vui lòng chọn chủ đề";
            this.Cursor = Cursors.Default;
        }
        private void changeControlState(Boolean _State)
        {
            cmdThem.Enabled = _State;
            cmdSua.Enabled = _State;
            cmdXoa.Enabled = _State;
            cmdGhi.Enabled = !_State;
            cmdHuy.Enabled = !_State;

            cbChude.Enabled = !_State;
            txtTieuDe.Enabled = !_State;
            txtNoiDung.Enabled = !_State;
            txtA.Enabled = !_State;
            txtB.Enabled = !_State;
            txtC.Enabled = !_State;
            txtD.Enabled = !_State;
            rA.Enabled = !_State;
            rB.Enabled = !_State;
            rC.Enabled = !_State;
            rD.Enabled = !_State;
            cbCapDo.Enabled = !_State;
        }

        private void cmdHuy_Click(object sender, EventArgs e)
        {
            _Action = "";
            changeControlState(true);
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            _Action = "Add";
            txtTieuDe.Text = "";
            txtNoiDung.Text = "";
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            rA.Checked = true;
            cbCapDo.SelectedItem = 0;
            lbHanhDong.Text = "Thao tác : Thêm mới";
            changeControlState(false);
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            _Action = "Edit";
            lbHanhDong.Text = "Thao tác : sửa";
            changeControlState(false);
        }

        private void DeThi_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                id = int.Parse(DeThi.GetFocusedRowCellValue("id").ToString());
                cbChude.EditValue = DeThi.GetFocusedRowCellValue("Ma_Chu_De").ToString();
                 txtTieuDe.Text= DeThi.GetFocusedRowCellValue("Tieu_De").ToString();
                 txtNoiDung.Text = DeThi.GetFocusedRowCellValue("Noi_Dung").ToString();
                 txtA.Text = DeThi.GetFocusedRowCellValue("Dap_An_A").ToString();
                 txtB.Text = DeThi.GetFocusedRowCellValue("Dap_An_B").ToString();
                 txtC.Text = DeThi.GetFocusedRowCellValue("Dap_An_C").ToString();
                 txtD.Text = DeThi.GetFocusedRowCellValue("Dap_An_D").ToString();
                 char tl = char.Parse(DeThi.GetFocusedRowCellValue("Dap_An_Dung").ToString());
                 if (tl=='A')
                 {
                     rA.Checked = true;
                 }
                 else
                 {
                     if (tl=='B')
                     {
                         rB.Checked = true;
                     }
                     else
                     {
                         if (tl == 'C')
                         {
                             rC.Checked = true;
                         }
                         else
                         {
                             rD.Checked = true;
                         }
                     }
                 }
                 char cd = char.Parse(DeThi.GetFocusedRowCellValue("Cap_Do").ToString());
                 if (cd=='D')
                 {
                     cbCapDo.SelectedItem = "Dễ";
                 }
                 else
                 {
                     if (cd=='T')
                     {
                         cbCapDo.SelectedItem = "Trung bình";
                     }
                     else
                     {
                         cbCapDo.SelectedItem = "Khó";
                     }
                 }
            }
            catch (Exception)
            {
            }
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (txtTieuDe.Text.Trim() != "" && txtNoiDung.Text.Trim() != "" && txtA.Text.Trim() != "" && txtB.Text.Trim() != "")
            {
                CauHoi obj = new CauHoi();
                obj.Tieu_De = txtTieuDe.Text.Trim();
                obj.Noi_Dung = txtNoiDung.Text.Trim();
                obj.Dap_An_A = txtA.Text.Trim();
                obj.Dap_An_B = txtB.Text.Trim();
                obj.Dap_An_C = txtC.Text.Trim();
                obj.Dap_An_D = txtD.Text.Trim();
                if (rA.Checked)
                {
                    obj.Dap_An_Dung = 'A';
                }
                else
                {
                    if (rB.Checked)
                    {
                        obj.Dap_An_Dung = 'B';
                    }
                    else
                    {
                        if (rC.Checked)
                        {
                            obj.Dap_An_Dung = 'C';
                        }
                        else
                        {
                            obj.Dap_An_Dung = 'D';
                        }
                    }
                }
                obj.Ma_Chu_De = int.Parse(cbChude.EditValue.ToString());
                if (cbCapDo.SelectedItem=="Dễ")
                {
                    obj.Cap_Do='D';
                }
                else
                {
                    if (cbCapDo.SelectedItem=="Trung bình")
                    {
                        obj.Cap_Do='T';
                    }
                    else
                    {
                        obj.Cap_Do = 'K';
                    }
                }
                if (_Action == "Add")
                {
                    obj.Nguoi_Tao = UserName;
                    cls.addCauHoi(obj);
                    MessageBox.Show("Thêm câu hỏi thành công!");
                    gridDeThi.DataSource = null;
                    gridDeThi.DataSource = cls.listCauhoi();
                    changeControlState(true);
                }
                if (_Action == "Edit")
                {
                    obj.id = id;
                    obj.Nguoi_Sua = UserName;
                    cls.updateCauHoi(obj);
                    MessageBox.Show("Sửa câu hỏi thành công!");
                    gridDeThi.DataSource = null;
                    gridDeThi.DataSource = cls.listCauhoi();
                    changeControlState(true);
                }
            }
            else
            {
                MessageBox.Show("Các trường không được để trống!");
            }
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
