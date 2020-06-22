namespace DoAnThiTracNghiem_Son
{
    partial class TaoLop
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
            this.gridChuDe = new DevExpress.XtraGrid.GridControl();
            this.ChuDe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.srNienKhoa = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.srKhoi = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.srTaiKhoan = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNienKhoa = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKhoi = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbHanhDong = new DevExpress.XtraEditors.LabelControl();
            this.cmdGhi = new DevExpress.XtraEditors.SimpleButton();
            this.cmdHuy = new DevExpress.XtraEditors.SimpleButton();
            this.cmdXoa = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSua = new DevExpress.XtraEditors.SimpleButton();
            this.cmdThem = new DevExpress.XtraEditors.SimpleButton();
            this.userName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nien_khoa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.khoi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nien_khoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id_khoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id_nien_khoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id_TaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridChuDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChuDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srNienKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srKhoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridChuDe
            // 
            this.gridChuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridChuDe.Location = new System.Drawing.Point(0, 51);
            this.gridChuDe.MainView = this.ChuDe;
            this.gridChuDe.Name = "gridChuDe";
            this.gridChuDe.Size = new System.Drawing.Size(439, 280);
            this.gridChuDe.TabIndex = 9;
            this.gridChuDe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ChuDe});
            // 
            // ChuDe
            // 
            this.ChuDe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ta,
            this.khoi1,
            this.nien_khoa,
            this.lop,
            this.id,
            this.id_khoi,
            this.id_nien_khoa,
            this.id_TaiKhoan});
            this.ChuDe.GridControl = this.gridChuDe;
            this.ChuDe.Name = "ChuDe";
            this.ChuDe.OptionsBehavior.Editable = false;
            this.ChuDe.OptionsFind.AlwaysVisible = true;
            this.ChuDe.OptionsFind.FindNullPrompt = ".....";
            this.ChuDe.OptionsView.ShowGroupPanel = false;
            this.ChuDe.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.ChuDe_FocusedRowChanged);
            // 
            // ta
            // 
            this.ta.AppearanceHeader.Options.UseTextOptions = true;
            this.ta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ta.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ta.Caption = "Tài khoản";
            this.ta.FieldName = "taiKhoan.userName";
            this.ta.Name = "ta";
            this.ta.Visible = true;
            this.ta.VisibleIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.panelControl2.Controls.Add(this.srNienKhoa);
            this.panelControl2.Controls.Add(this.srKhoi);
            this.panelControl2.Controls.Add(this.srTaiKhoan);
            this.panelControl2.Controls.Add(this.textEdit4);
            this.panelControl2.Controls.Add(this.label4);
            this.panelControl2.Controls.Add(this.txtNienKhoa);
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Controls.Add(this.txtKhoi);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.txtTaiKhoan);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(439, 51);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(397, 280);
            this.panelControl2.TabIndex = 8;
            // 
            // srNienKhoa
            // 
            this.srNienKhoa.Location = new System.Drawing.Point(312, 117);
            this.srNienKhoa.Name = "srNienKhoa";
            this.srNienKhoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.srNienKhoa.Properties.DisplayMember = "nien_khoa1";
            this.srNienKhoa.Properties.ValueMember = "id";
            this.srNienKhoa.Properties.View = this.gridView2;
            this.srNienKhoa.Size = new System.Drawing.Size(18, 20);
            this.srNienKhoa.TabIndex = 10;
            this.srNienKhoa.EditValueChanged += new System.EventHandler(this.srNienKhoa_EditValueChanged);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nien_khoa1});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // srKhoi
            // 
            this.srKhoi.Location = new System.Drawing.Point(312, 74);
            this.srKhoi.Name = "srKhoi";
            this.srKhoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.srKhoi.Properties.DisplayMember = "khoi1";
            this.srKhoi.Properties.ValueMember = "id";
            this.srKhoi.Properties.View = this.gridView1;
            this.srKhoi.Size = new System.Drawing.Size(18, 20);
            this.srKhoi.TabIndex = 9;
            this.srKhoi.EditValueChanged += new System.EventHandler(this.srKhoi_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // srTaiKhoan
            // 
            this.srTaiKhoan.Location = new System.Drawing.Point(312, 35);
            this.srTaiKhoan.Name = "srTaiKhoan";
            this.srTaiKhoan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.srTaiKhoan.Properties.DisplayMember = "userName";
            this.srTaiKhoan.Properties.ValueMember = "id";
            this.srTaiKhoan.Properties.View = this.searchLookUpEdit1View;
            this.srTaiKhoan.Size = new System.Drawing.Size(18, 20);
            this.srTaiKhoan.TabIndex = 8;
            this.srTaiKhoan.EditValueChanged += new System.EventHandler(this.srTaiKhoan_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.userName});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(118, 157);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(212, 20);
            this.textEdit4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên lớp :";
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.Location = new System.Drawing.Point(118, 117);
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Properties.ReadOnly = true;
            this.txtNienKhoa.Size = new System.Drawing.Size(212, 20);
            this.txtNienKhoa.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Niên Khóa :";
            // 
            // txtKhoi
            // 
            this.txtKhoi.Location = new System.Drawing.Point(118, 74);
            this.txtKhoi.Name = "txtKhoi";
            this.txtKhoi.Properties.ReadOnly = true;
            this.txtKhoi.Size = new System.Drawing.Size(212, 20);
            this.txtKhoi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Khối :";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(118, 35);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Properties.ReadOnly = true;
            this.txtTaiKhoan.Size = new System.Drawing.Size(212, 20);
            this.txtTaiKhoan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản :";
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
            this.panelControl1.Size = new System.Drawing.Size(836, 51);
            this.panelControl1.TabIndex = 7;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageIndex = 6;
            this.simpleButton1.Location = new System.Drawing.Point(300, 9);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 22;
            this.simpleButton1.Text = "Làm mới";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbHanhDong);
            this.panel2.Controls.Add(this.cmdGhi);
            this.panel2.Controls.Add(this.cmdHuy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(455, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 47);
            this.panel2.TabIndex = 21;
            // 
            // lbHanhDong
            // 
            this.lbHanhDong.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbHanhDong.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbHanhDong.Location = new System.Drawing.Point(12, 17);
            this.lbHanhDong.Name = "lbHanhDong";
            this.lbHanhDong.Size = new System.Drawing.Size(3, 13);
            this.lbHanhDong.TabIndex = 22;
            this.lbHanhDong.Text = ".";
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
            // userName
            // 
            this.userName.Caption = "Tài khoản";
            this.userName.FieldName = "userName";
            this.userName.Name = "userName";
            this.userName.Visible = true;
            this.userName.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Khối";
            this.gridColumn1.FieldName = "khoi1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // nien_khoa1
            // 
            this.nien_khoa1.Caption = "Niên khóa";
            this.nien_khoa1.FieldName = "nien_khoa1";
            this.nien_khoa1.Name = "nien_khoa1";
            this.nien_khoa1.Visible = true;
            this.nien_khoa1.VisibleIndex = 0;
            // 
            // khoi1
            // 
            this.khoi1.AppearanceHeader.Options.UseTextOptions = true;
            this.khoi1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.khoi1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.khoi1.Caption = "Khối";
            this.khoi1.FieldName = "Khoi.khoi1";
            this.khoi1.Name = "khoi1";
            this.khoi1.Visible = true;
            this.khoi1.VisibleIndex = 1;
            // 
            // nien_khoa
            // 
            this.nien_khoa.AppearanceHeader.Options.UseTextOptions = true;
            this.nien_khoa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nien_khoa.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.nien_khoa.Caption = "Niên khóa";
            this.nien_khoa.FieldName = "Nien_khoa.nien_khoa1";
            this.nien_khoa.Name = "nien_khoa";
            this.nien_khoa.Visible = true;
            this.nien_khoa.VisibleIndex = 2;
            // 
            // lop
            // 
            this.lop.AppearanceHeader.Options.UseTextOptions = true;
            this.lop.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lop.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lop.Caption = "Lớp";
            this.lop.FieldName = "lop";
            this.lop.Name = "lop";
            this.lop.Visible = true;
            this.lop.VisibleIndex = 3;
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            // 
            // id_khoi
            // 
            this.id_khoi.Caption = "id_khoi";
            this.id_khoi.FieldName = "id_khoi";
            this.id_khoi.Name = "id_khoi";
            // 
            // id_nien_khoa
            // 
            this.id_nien_khoa.Caption = "id_nien_khoa";
            this.id_nien_khoa.FieldName = "id_nien_khoa";
            this.id_nien_khoa.Name = "id_nien_khoa";
            // 
            // id_TaiKhoan
            // 
            this.id_TaiKhoan.Caption = "id_TaiKhoan";
            this.id_TaiKhoan.FieldName = "id_TaiKhoan";
            this.id_TaiKhoan.Name = "id_TaiKhoan";
            // 
            // TaoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 331);
            this.Controls.Add(this.gridChuDe);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "TaoLop";
            this.Text = "TaoLop";
            this.Load += new System.EventHandler(this.TaoLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridChuDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChuDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srNienKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srKhoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridChuDe;
        private DevExpress.XtraGrid.Views.Grid.GridView ChuDe;
        private DevExpress.XtraGrid.Columns.GridColumn ta;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lbHanhDong;
        private DevExpress.XtraEditors.SimpleButton cmdGhi;
        private DevExpress.XtraEditors.SimpleButton cmdHuy;
        private DevExpress.XtraEditors.SimpleButton cmdXoa;
        private DevExpress.XtraEditors.SimpleButton cmdSua;
        private DevExpress.XtraEditors.SimpleButton cmdThem;
        private DevExpress.XtraEditors.TextEdit txtTaiKhoan;
        private DevExpress.XtraEditors.SearchLookUpEdit srTaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtNienKhoa;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtKhoi;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SearchLookUpEdit srKhoi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SearchLookUpEdit srNienKhoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn nien_khoa1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn userName;
        private DevExpress.XtraGrid.Columns.GridColumn khoi1;
        private DevExpress.XtraGrid.Columns.GridColumn nien_khoa;
        private DevExpress.XtraGrid.Columns.GridColumn lop;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn id_khoi;
        private DevExpress.XtraGrid.Columns.GridColumn id_nien_khoa;
        private DevExpress.XtraGrid.Columns.GridColumn id_TaiKhoan;
    }
}