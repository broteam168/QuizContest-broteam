namespace DoAnThiTracNghiem_Son
{
    partial class GiamSat_View
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
            this.components = new System.ComponentModel.Container();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cbDeThi = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Tieu_De = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Ma_DeThi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nguoi_Lam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THOI_GIAN_LAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THOI_GIAN_BAT_DAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Trang_Thai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbDeThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.cbDeThi);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(815, 46);
            this.panelControl1.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(485, 10);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Tìm kiếm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cbDeThi
            // 
            this.cbDeThi.Location = new System.Drawing.Point(29, 12);
            this.cbDeThi.Name = "cbDeThi";
            this.cbDeThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDeThi.Properties.DisplayMember = "Tieu_De";
            this.cbDeThi.Properties.ValueMember = "id";
            this.cbDeThi.Properties.View = this.searchLookUpEdit1View;
            this.cbDeThi.Size = new System.Drawing.Size(411, 20);
            this.cbDeThi.TabIndex = 0;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Tieu_De});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Tieu_De
            // 
            this.Tieu_De.Caption = "Đề thi";
            this.Tieu_De.FieldName = "Tieu_De";
            this.Tieu_De.Name = "Tieu_De";
            this.Tieu_De.Visible = true;
            this.Tieu_De.VisibleIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 46);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(815, 395);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Ma_DeThi,
            this.Nguoi_Lam,
            this.THOI_GIAN_LAM,
            this.THOI_GIAN_BAT_DAU,
            this.Trang_Thai});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "..................";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // Ma_DeThi
            // 
            this.Ma_DeThi.Caption = "Ma_DeThi";
            this.Ma_DeThi.FieldName = "Ma_DeThi";
            this.Ma_DeThi.Name = "Ma_DeThi";
            // 
            // Nguoi_Lam
            // 
            this.Nguoi_Lam.Caption = "Tài khoản";
            this.Nguoi_Lam.FieldName = "Nguoi_Lam";
            this.Nguoi_Lam.Name = "Nguoi_Lam";
            this.Nguoi_Lam.Visible = true;
            this.Nguoi_Lam.VisibleIndex = 0;
            // 
            // THOI_GIAN_LAM
            // 
            this.THOI_GIAN_LAM.Caption = "Tổng thời gian làm bài";
            this.THOI_GIAN_LAM.FieldName = "THOI_GIAN_LAM";
            this.THOI_GIAN_LAM.Name = "THOI_GIAN_LAM";
            this.THOI_GIAN_LAM.Visible = true;
            this.THOI_GIAN_LAM.VisibleIndex = 1;
            // 
            // THOI_GIAN_BAT_DAU
            // 
            this.THOI_GIAN_BAT_DAU.Caption = "Thời gian bắt đầu làm";
            this.THOI_GIAN_BAT_DAU.DisplayFormat.FormatString = "dd/mm/yyyy hh:mm:ss";
            this.THOI_GIAN_BAT_DAU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.THOI_GIAN_BAT_DAU.FieldName = "THOI_GIAN_BAT_DAU";
            this.THOI_GIAN_BAT_DAU.Name = "THOI_GIAN_BAT_DAU";
            this.THOI_GIAN_BAT_DAU.Visible = true;
            this.THOI_GIAN_BAT_DAU.VisibleIndex = 2;
            // 
            // Trang_Thai
            // 
            this.Trang_Thai.Caption = "Tình trạng";
            this.Trang_Thai.FieldName = "Trang_Thai";
            this.Trang_Thai.Name = "Trang_Thai";
            this.Trang_Thai.Visible = true;
            this.Trang_Thai.VisibleIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GiamSat_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 441);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "GiamSat_View";
            this.Text = "Giám sát";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbDeThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SearchLookUpEdit cbDeThi;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn Tieu_De;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Ma_DeThi;
        private DevExpress.XtraGrid.Columns.GridColumn Nguoi_Lam;
        private DevExpress.XtraGrid.Columns.GridColumn THOI_GIAN_LAM;
        private DevExpress.XtraGrid.Columns.GridColumn THOI_GIAN_BAT_DAU;
        private DevExpress.XtraGrid.Columns.GridColumn Trang_Thai;
        private System.Windows.Forms.Timer timer1;
    }
}