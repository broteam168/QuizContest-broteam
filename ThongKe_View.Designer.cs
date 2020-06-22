namespace DoAnThiTracNghiem_Son
{
    partial class ThongKe_View
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
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cbDeThi = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Tieu_De = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridThongKe = new DevExpress.XtraGrid.GridControl();
            this.ThongKe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.userName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SUM_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THOI_GIAN_LAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SUM_CAUHOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SUM_DUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbDeThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton3);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.cbDeThi);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(771, 46);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(691, 10);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "In bài thi";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(588, 10);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Xuất Excel";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
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
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridThongKe);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 46);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(771, 386);
            this.panelControl2.TabIndex = 1;
            // 
            // gridThongKe
            // 
            this.gridThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridThongKe.Location = new System.Drawing.Point(2, 2);
            this.gridThongKe.MainView = this.ThongKe;
            this.gridThongKe.Name = "gridThongKe";
            this.gridThongKe.Size = new System.Drawing.Size(767, 382);
            this.gridThongKe.TabIndex = 0;
            this.gridThongKe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ThongKe});
            // 
            // ThongKe
            // 
            this.ThongKe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.userName,
            this.lop,
            this.SUM_TIME,
            this.THOI_GIAN_LAM,
            this.SUM_CAUHOI,
            this.SUM_DUNG});
            this.ThongKe.GridControl = this.gridThongKe;
            this.ThongKe.Name = "ThongKe";
            this.ThongKe.OptionsBehavior.Editable = false;
            this.ThongKe.OptionsView.ShowGroupPanel = false;
            this.ThongKe.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.ThongKe_CustomDrawRowIndicator);
            this.ThongKe.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.ThongKe_RowCellStyle);
            this.ThongKe.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.ThongKe_FocusedRowChanged);
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
            this.userName.VisibleIndex = 0;
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
            this.lop.VisibleIndex = 1;
            // 
            // SUM_TIME
            // 
            this.SUM_TIME.AppearanceHeader.Options.UseTextOptions = true;
            this.SUM_TIME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SUM_TIME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SUM_TIME.Caption = "Tổng thời gian thi (phút)";
            this.SUM_TIME.FieldName = "SUM_TIME";
            this.SUM_TIME.Name = "SUM_TIME";
            this.SUM_TIME.Visible = true;
            this.SUM_TIME.VisibleIndex = 2;
            // 
            // THOI_GIAN_LAM
            // 
            this.THOI_GIAN_LAM.AppearanceHeader.Options.UseTextOptions = true;
            this.THOI_GIAN_LAM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.THOI_GIAN_LAM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.THOI_GIAN_LAM.Caption = "Thời gian bắt đầu làm bài";
            this.THOI_GIAN_LAM.FieldName = "THOI_GIAN_LAM";
            this.THOI_GIAN_LAM.Name = "THOI_GIAN_LAM";
            this.THOI_GIAN_LAM.UnboundExpression = "M/d/yyyy hh:mm:ss tt";
            this.THOI_GIAN_LAM.Visible = true;
            this.THOI_GIAN_LAM.VisibleIndex = 3;
            // 
            // SUM_CAUHOI
            // 
            this.SUM_CAUHOI.AppearanceHeader.Options.UseTextOptions = true;
            this.SUM_CAUHOI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SUM_CAUHOI.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SUM_CAUHOI.Caption = "Tổng số câu hỏi";
            this.SUM_CAUHOI.FieldName = "SUM_CAUHOI";
            this.SUM_CAUHOI.Name = "SUM_CAUHOI";
            this.SUM_CAUHOI.Visible = true;
            this.SUM_CAUHOI.VisibleIndex = 4;
            // 
            // SUM_DUNG
            // 
            this.SUM_DUNG.AppearanceHeader.Options.UseTextOptions = true;
            this.SUM_DUNG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SUM_DUNG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SUM_DUNG.Caption = "Tổng số câu trả lời đúng";
            this.SUM_DUNG.FieldName = "SUM_DUNG";
            this.SUM_DUNG.Name = "SUM_DUNG";
            this.SUM_DUNG.Visible = true;
            this.SUM_DUNG.VisibleIndex = 5;
            // 
            // ThongKe_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 432);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "ThongKe_View";
            this.Text = "Thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbDeThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SearchLookUpEdit cbDeThi;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn Tieu_De;
        private DevExpress.XtraGrid.GridControl gridThongKe;
        private DevExpress.XtraGrid.Views.Grid.GridView ThongKe;
        private DevExpress.XtraGrid.Columns.GridColumn userName;
        private DevExpress.XtraGrid.Columns.GridColumn SUM_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn THOI_GIAN_LAM;
        private DevExpress.XtraGrid.Columns.GridColumn SUM_CAUHOI;
        private DevExpress.XtraGrid.Columns.GridColumn SUM_DUNG;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraGrid.Columns.GridColumn lop;
    }
}