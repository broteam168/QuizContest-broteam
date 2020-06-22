namespace DoAnThiTracNghiem_Son
{
    partial class LichSuThi_View
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
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridLichSu = new DevExpress.XtraGrid.GridControl();
            this.LichSu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Tieu_De = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nguoi_Lam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Thoi_Gian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ma_DeThi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLichSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btXoa);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.txtTimKiem);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(673, 45);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // btXoa
            // 
            this.btXoa.Enabled = false;
            this.btXoa.Location = new System.Drawing.Point(416, 12);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 4;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(556, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(4, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = ".";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tài khoản :";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(313, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Tìm kiếm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(83, 12);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(193, 21);
            this.txtTimKiem.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridLichSu);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 45);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(673, 380);
            this.panelControl2.TabIndex = 1;
            // 
            // gridLichSu
            // 
            this.gridLichSu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLichSu.Location = new System.Drawing.Point(2, 2);
            this.gridLichSu.MainView = this.LichSu;
            this.gridLichSu.Name = "gridLichSu";
            this.gridLichSu.Size = new System.Drawing.Size(669, 376);
            this.gridLichSu.TabIndex = 0;
            this.gridLichSu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.LichSu});
            // 
            // LichSu
            // 
            this.LichSu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Tieu_De,
            this.Nguoi_Lam,
            this.Thoi_Gian,
            this.id,
            this.Ma_DeThi});
            this.LichSu.GridControl = this.gridLichSu;
            this.LichSu.Name = "LichSu";
            this.LichSu.OptionsBehavior.Editable = false;
            this.LichSu.OptionsFind.AlwaysVisible = true;
            this.LichSu.OptionsFind.FindNullPrompt = ".........";
            this.LichSu.OptionsView.ShowGroupPanel = false;
            this.LichSu.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.LichSu_FocusedRowChanged);
            // 
            // Tieu_De
            // 
            this.Tieu_De.AppearanceHeader.Options.UseTextOptions = true;
            this.Tieu_De.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Tieu_De.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Tieu_De.Caption = "Đề thi";
            this.Tieu_De.FieldName = "DeThi.Tieu_De";
            this.Tieu_De.Name = "Tieu_De";
            this.Tieu_De.Visible = true;
            this.Tieu_De.VisibleIndex = 0;
            // 
            // Nguoi_Lam
            // 
            this.Nguoi_Lam.AppearanceHeader.Options.UseTextOptions = true;
            this.Nguoi_Lam.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Nguoi_Lam.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Nguoi_Lam.Caption = "Tài khoản";
            this.Nguoi_Lam.FieldName = "Nguoi_Lam";
            this.Nguoi_Lam.Name = "Nguoi_Lam";
            this.Nguoi_Lam.Visible = true;
            this.Nguoi_Lam.VisibleIndex = 1;
            // 
            // Thoi_Gian
            // 
            this.Thoi_Gian.AppearanceHeader.Options.UseTextOptions = true;
            this.Thoi_Gian.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Thoi_Gian.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Thoi_Gian.Caption = "Thời gian bắt đầu làm bài";
            this.Thoi_Gian.FieldName = "Thoi_Gian";
            this.Thoi_Gian.Name = "Thoi_Gian";
            this.Thoi_Gian.Visible = true;
            this.Thoi_Gian.VisibleIndex = 2;
            // 
            // id
            // 
            this.id.Caption = "gridColumn1";
            this.id.FieldName = "id";
            this.id.Name = "id";
            // 
            // Ma_DeThi
            // 
            this.Ma_DeThi.Caption = "Ma_DeThi";
            this.Ma_DeThi.FieldName = "Ma_DeThi";
            this.Ma_DeThi.Name = "Ma_DeThi";
            // 
            // LichSuThi_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 425);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "LichSuThi_View";
            this.Text = "Lịch sử thi";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLichSu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LichSu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridLichSu;
        private DevExpress.XtraGrid.Views.Grid.GridView LichSu;
        private DevExpress.XtraGrid.Columns.GridColumn Tieu_De;
        private DevExpress.XtraGrid.Columns.GridColumn Nguoi_Lam;
        private DevExpress.XtraGrid.Columns.GridColumn Thoi_Gian;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraGrid.Columns.GridColumn Ma_DeThi;
    }
}