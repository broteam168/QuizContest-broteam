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
    public partial class TaoKhoi : DevExpress.XtraEditors.XtraForm
    {
        private  Khoi_Controler obj;
        private string _Action;
        private int id_;
        public TaoKhoi()
        {
            obj = new Khoi_Controler();
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

         private void TaoKhoi_Load(object sender, EventArgs e)
         {
             gridChuDe.DataSource = obj.listKhoi();
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
                 txtChuDe.Text = ChuDe.GetFocusedRowCellValue("khoi1").ToString();
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
                 Khoi k = new Khoi();
                 k.khoi1 = txtChuDe.Text.Trim();
                 if (_Action == "Add")
                 {
                     obj.add(k);
                     MessageBox.Show("Tạo khối thành công!");
                     changeControlState(true);
                     gridChuDe.DataSource = null;
                     gridChuDe.DataSource = obj.listKhoi();
                 }
                 if (_Action == "Edit")
                 {
                     k.id= id_;
                     obj.update(k);
                     MessageBox.Show("Sửa tên khối thành công!");
                     changeControlState(true);
                     gridChuDe.DataSource = null;
                     gridChuDe.DataSource = obj.listKhoi();
                 }
             }
             else
             {
                 MessageBox.Show("Vui lòng nhập tên khối");
             }
         }

         private void simpleButton1_Click(object sender, EventArgs e)
         {

             gridChuDe.DataSource = null;
             gridChuDe.DataSource = obj.listKhoi();
         }

         private void cmdXoa_Click(object sender, EventArgs e)
         {
             if (MessageBox.Show("Bạn có chắc chắn muốn xóa khối?", "Cảnh báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
             {
                 if (obj.checkExist(id_))
                 {
                     obj.delete(id_);
                     gridChuDe.DataSource = null;
                     gridChuDe.DataSource = obj.listKhoi();
                     MessageBox.Show("Xóa chủ khối thành công!");
                 }
                 else
                 {
                     MessageBox.Show("khối đã sc sử dụng nên không thể xóa.");
                 }
             }
         }
    }
}
