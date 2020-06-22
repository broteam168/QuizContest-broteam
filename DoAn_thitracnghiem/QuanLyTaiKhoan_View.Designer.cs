namespace DoAnThiTracNghiem_Son
{
    partial class QuanLyTaiKhoan_View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbHanhDong = new DevExpress.XtraEditors.LabelControl();
            this.cmdGhi = new DevExpress.XtraEditors.SimpleButton();
            this.cmdHuy = new DevExpress.XtraEditors.SimpleButton();
            this.cmdXoa = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSua = new DevExpress.XtraEditors.SimpleButton();
            this.cmdThem = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtThongTin = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbNhom = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btMK = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gridTaiKhoan = new DevExpress.XtraGrid.GridControl();
            this.TaiKhoan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phanQuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thongTin = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.panel2);
            this.panelControl1.Controls.Add(this.cmdXoa);
            this.panelControl1.Controls.Add(this.cmdSua);
            this.panelControl1.Controls.Add(this.cmdThem);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(819, 47);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageIndex = 6;
            this.simpleButton1.Location = new System.Drawing.Point(300, 9);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 22;
            this.simpleButton1.Text = "Làm mới";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbHanhDong);
            this.panel2.Controls.Add(this.cmdGhi);
            this.panel2.Controls.Add(this.cmdHuy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(438, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 43);
            this.panel2.TabIndex = 21;
            // 
            // lbHanhDong
            // 
            this.lbHanhDong.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbHanhDong.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbHanhDong.Location = new System.Drawing.Point(12, 17);
            this.lbHanhDong.Name = "lbHanhDong";
            this.lbHanhDong.Size = new System.Drawing.Size(82, 13);
            this.lbHanhDong.TabIndex = 22;
            this.lbHanhDong.Text = "labelControl12";
            // 
            // cmdGhi
            // 
            this.cmdGhi.ImageIndex = 4;
            this.cmdGhi.Location = new System.Drawing.Point(192, 7);
            this.cmdGhi.Name = "cmdGhi";
            this.cmdGhi.Size = new System.Drawing.Size(75, 23);
            this.cmdGhi.TabIndex = 14;
            this.cmdGhi.Text = "Ghi";
            this.cmdGhi.Click += new System.EventHandler(this.cmdGhi_Click);
            // 
            // cmdHuy
            // 
            this.cmdHuy.ImageIndex = 5;
            this.cmdHuy.Location = new System.Drawing.Point(292, 7);
            this.cmdHuy.Name = "cmdHuy";
            this.cmdHuy.Size = new System.Drawing.Size(75, 23);
            this.cmdHuy.TabIndex = 15;
            this.cmdHuy.Text = "Hủy";
            this.cmdHuy.Click += new System.EventHandler(this.cmdHuy_Click);
            // 
            // cmdXoa
            // 
            this.cmdXoa.Enabled = false;
            this.cmdXoa.ImageIndex = 2;
            this.cmdXoa.Location = new System.Drawing.Point(203, 9);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(75, 23);
            this.cmdXoa.TabIndex = 20;
            this.cmdXoa.Text = "Xóa";
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // cmdSua
            // 
            this.cmdSua.Enabled = false;
            this.cmdSua.ImageIndex = 3;
            this.cmdSua.Location = new System.Drawing.Point(107, 9);
            this.cmdSua.Name = "cmdSua";
            this.cmdSua.Size = new System.Drawing.Size(75, 23);
            this.cmdSua.TabIndex = 19;
            this.cmdSua.Text = "Sửa";
            this.cmdSua.Click += new System.EventHandler(this.cmdSua_Click);
            // 
            // cmdThem
            // 
            this.cmdThem.Enabled = false;
            this.cmdThem.ImageIndex = 0;
            this.cmdThem.Location = new System.Drawing.Point(12, 9);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(75, 23);
            this.cmdThem.TabIndex = 18;
            this.cmdThem.Text = "Thêm mới";
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtThongTin);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.cbNhom);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.btMK);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.txtTaiKhoan);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.txtHoten);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(438, 47);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(381, 384);
            this.panelControl2.TabIndex = 1;
            // 
            // txtThongTin
            // 
            this.txtThongTin.Location = new System.Drawing.Point(133, 204);
            this.txtThongTin.Multiline = true;
            this.txtThongTin.Name = "txtThongTin";
            this.txtThongTin.Size = new System.Drawing.Size(210, 138);
            this.txtThongTin.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(31, 207);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Thông tin :";
            // 
            // cbNhom
            // 
            this.cbNhom.FormattingEnabled = true;
            this.cbNhom.Items.AddRange(new object[] {
            "Giáo viên",
            "Học Sinh"});
            this.cbNhom.Location = new System.Drawing.Point(133, 162);
            this.cbNhom.Name = "cbNhom";
            this.cbNhom.Size = new System.Drawing.Size(210, 21);
            this.cbNhom.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(31, 165);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(91, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Nhóm người dùng :";
            // 
            // btMK
            // 
            this.btMK.Location = new System.Drawing.Point(133, 115);
            this.btMK.Name = "btMK";
            this.btMK.Size = new System.Drawing.Size(98, 23);
            this.btMK.TabIndex = 5;
            this.btMK.Text = "Tạo lại mật khẩu";
            this.btMK.Click += new System.EventHandler(this.btMK_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(31, 120);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Mật khẩu :";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(133, 73);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(210, 21);
            this.txtTaiKhoan.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(31, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tài khoản :";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(133, 27);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(210, 21);
            this.txtHoten.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(31, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Họ tên :";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gridTaiKhoan);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 47);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(438, 384);
            this.panelControl3.TabIndex = 2;
            // 
            // gridTaiKhoan
            // 
            this.gridTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTaiKhoan.Location = new System.Drawing.Point(2, 2);
            this.gridTaiKhoan.MainView = this.TaiKhoan;
            this.gridTaiKhoan.Name = "gridTaiKhoan";
            this.gridTaiKhoan.Size = new System.Drawing.Size(434, 380);
            this.gridTaiKhoan.TabIndex = 0;
            this.gridTaiKhoan.UseEmbeddedNavigator = true;
            this.gridTaiKhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.TaiKhoan});
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.HoTen,
            this.userName,
            this.pass,
            this.phanQuyen,
            this.thongTin});
            this.TaiKhoan.GridControl = this.gridTaiKhoan;
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.OptionsBehavior.Editable = false;
            this.TaiKhoan.OptionsFind.AlwaysVisible = true;
            this.TaiKhoan.OptionsFind.FindNullPrompt = ".............";
            this.TaiKhoan.OptionsView.ShowGroupPanel = false;
            this.TaiKhoan.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.TaiKhoan_FocusedRowChanged);
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            // 
            // HoTen
            // 
            this.HoTen.AppearanceHeader.Options.UseTextOptions = true;
            this.HoTen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.HoTen.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.HoTen.Caption = "Họ tên";
            this.HoTen.FieldName = "HoTen";
            this.HoTen.Name = "HoTen";
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 0;
            // 
            // userName
            // 
            this.userName.AppearanceHeader.Options.UseTextOptions = true;
            this.userName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.userName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.userName.Caption = "Tài khoản";
            this.userName.FieldName = "userName";
            this.userName.Name = "userName";
            this.userName.Visible = true;
            this.userName.VisibleIndex = 1;
            // 
            // pass
            // 
            this.pass.Caption = "pass";
            this.pass.FieldName = "pass";
            this.pass.Name = "pass";
            // 
            // phanQuyen
            // 
            this.phanQuyen.Caption = "phanQuyen";
            this.phanQuyen.FieldName = "phanQuyen";
            this.phanQuyen.Name = "phanQuyen";
            // 
            // thongTin
            // 
            this.thongTin.Caption = "thongTin";
            this.thongTin.FieldName = "thongTin";
            this.thongTin.Name = "thongTin";
            // 
            // QuanLyTaiKhoan_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 431);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "QuanLyTaiKhoan_View";
            this.Text = "Quản lý tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gridTaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView TaiKhoan;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lbHanhDong;
        private DevExpress.XtraEditors.SimpleButton cmdGhi;
        private DevExpress.XtraEditors.SimpleButton cmdHuy;
        private DevExpress.XtraEditors.SimpleButton cmdXoa;
        private DevExpress.XtraEditors.SimpleButton cmdSua;
        private DevExpress.XtraEditors.SimpleButton cmdThem;
        private DevExpress.XtraEditors.SimpleButton btMK;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtHoten;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cbNhom;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtThongTin;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn userName;
        private DevExpress.XtraGrid.Columns.GridColumn pass;
        private DevExpress.XtraGrid.Columns.GridColumn phanQuyen;
        private DevExpress.XtraGrid.Columns.GridColumn thongTin;
    }
}