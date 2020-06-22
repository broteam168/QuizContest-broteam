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
    public partial class TaoChuDe_View :  DevExpress.XtraEditors.XtraForm
    {
        private ChudeControler obj;
        private string _Action;
        private int id_;
        public TaoChuDe_View()
        {
            obj = new ChudeControler();
            InitializeComponent();
            changeControlState(true);
        }

        private void TaoChuDe_View_Load(object sender, EventArgs e)
        {
            gridChuDe.DataSource= obj.listChude();
        }
        private void changeControlState(Boolean _State)
        {
            cmdThem.Enabled = _State;
            cmdSua.Enabled = _State;
            cmdXoa.Enabled = _State;
            gridChuDe.Enabled = _State;
            cmdGhi.Enabled = !_State;
            cmdHuy.Enabled = !_State;

            
            txtChuDe.Enabled = !_State;
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            _Action = "Add";
            txtChuDe.Text = "";
            lbHanhDong.Text = "Thao tác : Thêm mới";
            changeControlState(false);
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            _Action = "Edit";
            lbHanhDong.Text = "Thao tác : sửa";
            changeControlState(false);
        }

        private void ChuDe_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                id_ = int.Parse(ChuDe.GetFocusedRowCellValue("ID").ToString());
                txtChuDe.Text = ChuDe.GetFocusedRowCellValue("Ten_Chu_De").ToString();
            }
            catch (Exception)
            {
            }
        }

        private void cmdHuy_Click(object sender, EventArgs e)
        {
            _Action = "";
            changeControlState(true);
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (txtChuDe.Text.Trim()!="")
            {
                ChuDe cd = new ChuDe();
                cd.Ten_Chu_De = txtChuDe.Text.Trim();
                if (_Action == "Add")
                {
                    obj.add(cd);
                    MessageBox.Show("Tạo tài khoản thành công!");
                    changeControlState(true);
                    gridChuDe.DataSource = null;
                    gridChuDe.DataSource = obj.listChude();
                }
                if (_Action=="Edit")
                {
                    cd.ID = id_;
                    obj.update(cd);
                    MessageBox.Show("Sửa tên chủ đề thành công!");
                    changeControlState(true);
                    gridChuDe.DataSource = null;
                    gridChuDe.DataSource = obj.listChude();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên chủ đề.");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridChuDe.DataSource = null;
            gridChuDe.DataSource = obj.listChude();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa chủ đề?","Cảnh báo!",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                if (obj.checkExist(id_))
                {
                    obj.delete(id_);
                    gridChuDe.DataSource = null;
                    gridChuDe.DataSource = obj.listChude();
                    MessageBox.Show("Xóa chủ đề thành công!");
                }
                else
                {
                    MessageBox.Show("Đề thi đã được tạo bởi chủ đề này nên không thể xóa.");
                }
            }
        }
    }
}
