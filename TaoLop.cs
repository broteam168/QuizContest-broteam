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
    public partial class TaoLop : DevExpress.XtraEditors.XtraForm
    {
        private Lop_controler cls;
        private string _Action="";
        private int idTK=0, idKhoi = 0, idNienKhoa = 0,id_;
        public TaoLop()
        {
            cls = new Lop_controler();
            InitializeComponent();
            changeControlState(true);
        }

        private void TaoLop_Load(object sender, EventArgs e)
        {
            gridChuDe.DataSource = null;
            gridChuDe.DataSource = cls.listTaiKhoan_H();
            srTaiKhoan.Properties.DataSource = cls.listTaiKhoan();
            srKhoi.Properties.DataSource = cls.listKhoi();
            srNienKhoa.Properties.DataSource = cls.listNienKhoa();
        }
        private void changeControlState(Boolean _State)
        {
            cmdThem.Enabled = _State;
            cmdSua.Enabled = _State;
            cmdXoa.Enabled = _State;
            gridChuDe.Enabled = _State;
            cmdGhi.Enabled = !_State;
            cmdHuy.Enabled = !_State;


            textEdit4.Enabled = !_State;
            txtTaiKhoan.Enabled = !_State;
            txtKhoi.Enabled = !_State;
            txtNienKhoa.Enabled = !_State;
            srNienKhoa.Enabled = !_State;
            srKhoi.Enabled = !_State;
            srTaiKhoan.Enabled = !_State;
            if (!_Action.Equals("Edit"))
            {
                idTK = 0; idKhoi = 0; idNienKhoa = 0;
            }
            
        }
        private void srTaiKhoan_EditValueChanged(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = srTaiKhoan.Text;
            idTK = int.Parse(srTaiKhoan.EditValue.ToString());
        }

        private void srKhoi_EditValueChanged(object sender, EventArgs e)
        {
            txtKhoi.Text = srKhoi.Text;
            idKhoi = int.Parse(srKhoi.EditValue.ToString());
        }

        private void srNienKhoa_EditValueChanged(object sender, EventArgs e)
        {
            txtNienKhoa.Text = srNienKhoa.Text;
            idNienKhoa = int.Parse(srNienKhoa.EditValue.ToString());
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            _Action = "Add";
            textEdit4.Text = "";
            txtTaiKhoan.Text = "";
            txtKhoi.Text = "";
            txtNienKhoa.Text = "";
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
                txtTaiKhoan.Text = ChuDe.GetFocusedRowCellValue("taiKhoan.userName").ToString();
                txtKhoi.Text = ChuDe.GetFocusedRowCellValue("Khoi.khoi1").ToString();
                txtNienKhoa.Text = ChuDe.GetFocusedRowCellValue("Nien_khoa.nien_khoa1").ToString();
                textEdit4.Text = ChuDe.GetFocusedRowCellValue("lop").ToString();
                idTK = int.Parse(ChuDe.GetFocusedRowCellValue("id_TaiKhoan").ToString());
                idKhoi = int.Parse(ChuDe.GetFocusedRowCellValue("id_khoi").ToString());
                idNienKhoa = int.Parse(ChuDe.GetFocusedRowCellValue("id_nien_khoa").ToString());
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
            if (idTK!=0&& idKhoi != 0&& idNienKhoa != 0 &&textEdit4.Text.Trim()!="")
            {
                if (cls.checkExistKhoi(idTK,idKhoi))
                {
                    if (true)
                    {
                        TaiKoan_H nk = new TaiKoan_H();
                        nk.id_TaiKhoan = idTK;
                        nk.id_khoi = idKhoi;
                        nk.id_nien_khoa = idNienKhoa;
                        nk.lop = textEdit4.Text.Trim();
                        if (_Action == "Add")
                        {
                            cls.add(nk);
                            MessageBox.Show("Tạo lớp cho tài khoản thành công!");
                            changeControlState(true);
                            gridChuDe.DataSource = null;
                            gridChuDe.DataSource = cls.listTaiKhoan_H();
                        }
                        if (_Action == "Edit")
                        {
                            nk.id = id_;
                            cls.update(nk);
                            MessageBox.Show("Sửa lớp cho tài khoản thành công!");
                            changeControlState(true);
                            gridChuDe.DataSource = null;
                            gridChuDe.DataSource = cls.listTaiKhoan_H();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm. Tài khoản đã tồn tại trong niên khóa " + txtNienKhoa.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Không thể thêm. Tài khoản đã tồn tại trong khối "+txtKhoi.Text);
                }
            }
            else
            {
                MessageBox.Show("Các trường không được để trống.");
            }
        }
    }
}
