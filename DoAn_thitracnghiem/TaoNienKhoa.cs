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
    public partial class TaoNienKhoa : DevExpress.XtraEditors.XtraForm
    {
        private Nien_khoaControler obj;
        private string _Action;
        private int id_;
        public TaoNienKhoa()
        {
            obj = new Nien_khoaControler();
            InitializeComponent();
            changeControlState(true);
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

        private void TaoNienKhoa_Load(object sender, EventArgs e)
        {
            gridChuDe.DataSource = obj.listNien_khoa();
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
                id_ = int.Parse(ChuDe.GetFocusedRowCellValue("id").ToString());
                txtChuDe.Text = ChuDe.GetFocusedRowCellValue("nien_khoa").ToString();
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
            if (txtChuDe.Text.Trim() != "")
            {
              Nien_khoa nk=new Nien_khoa();
               nk.nien_khoa1 = txtChuDe.Text.Trim();
                if (_Action == "Add")
                {
                    obj.add(nk);
                    MessageBox.Show("Tạo niên khóa thành công!");
                    changeControlState(true);
                    gridChuDe.DataSource = null;
                    gridChuDe.DataSource = obj.listNien_khoa();
                }
                if (_Action == "Edit")
                {
                    nk.id = id_;
                    obj.update(nk);
                    MessageBox.Show("Sửa tên niên khóa thành công!");
                    changeControlState(true);
                    gridChuDe.DataSource = null;
                    gridChuDe.DataSource = obj.listNien_khoa();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên niên khóa.");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridChuDe.DataSource = null;
            gridChuDe.DataSource = obj.listNien_khoa();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa niên khóa?", "Cảnh báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (obj.checkExist(id_))
                {
                    obj.delete(id_);
                    gridChuDe.DataSource = null;
                    gridChuDe.DataSource = obj.listNien_khoa();
                    MessageBox.Show("Xóa niên khóa thành công!");
                }
                else
                {
                    MessageBox.Show("niên khóa đã được sử dụng nên ko nên không thể xóa.");
                }
            }
        }
    }
}
