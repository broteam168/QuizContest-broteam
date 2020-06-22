namespace DoAnThiTracNghiem_Son
{
    partial class TraCuuBaiThi
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridTraCuuBaiThi = new DevExpress.XtraGrid.GridControl();
            this.TraCuuBai = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Ten_Chu_De = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Noi_Dung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Dap_An_A = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Dap_An_B = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Dap_An_C = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Dap_An_D = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Dap_An_HS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Dap_An_Dung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Thoi_Gian = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTraCuuBaiThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraCuuBai)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.textBox2);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.textBox1);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 57);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(590, 17);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Tìm kiếm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(339, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 21);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tài khoản :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đề Thi :";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridTraCuuBaiThi);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 57);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(800, 390);
            this.panelControl2.TabIndex = 1;
            // 
            // gridTraCuuBaiThi
            // 
            this.gridTraCuuBaiThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTraCuuBaiThi.Location = new System.Drawing.Point(2, 2);
            this.gridTraCuuBaiThi.MainView = this.TraCuuBai;
            this.gridTraCuuBaiThi.Name = "gridTraCuuBaiThi";
            this.gridTraCuuBaiThi.Size = new System.Drawing.Size(796, 386);
            this.gridTraCuuBaiThi.TabIndex = 0;
            this.gridTraCuuBaiThi.UseEmbeddedNavigator = true;
            this.gridTraCuuBaiThi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.TraCuuBai});
            // 
            // TraCuuBai
            // 
            this.TraCuuBai.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Ten_Chu_De,
            this.Noi_Dung,
            this.Dap_An_A,
            this.Dap_An_B,
            this.Dap_An_C,
            this.Dap_An_D,
            this.Dap_An_HS,
            this.Dap_An_Dung,
            this.Thoi_Gian});
            this.TraCuuBai.GridControl = this.gridTraCuuBaiThi;
            this.TraCuuBai.Name = "TraCuuBai";
            this.TraCuuBai.OptionsBehavior.Editable = false;
            this.TraCuuBai.OptionsView.ShowGroupPanel = false;
            this.TraCuuBai.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.TraCuuBai_RowCellStyle);
            // 
            // Ten_Chu_De
            // 
            this.Ten_Chu_De.AppearanceHeader.Options.UseTextOptions = true;
            this.Ten_Chu_De.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Ten_Chu_De.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Ten_Chu_De.Caption = "Đề thi";
            this.Ten_Chu_De.FieldName = "DeThi.Tieu_De";
            this.Ten_Chu_De.Name = "Ten_Chu_De";
            this.Ten_Chu_De.Visible = true;
            this.Ten_Chu_De.VisibleIndex = 0;
            // 
            // Noi_Dung
            // 
            this.Noi_Dung.AppearanceHeader.Options.UseTextOptions = true;
            this.Noi_Dung.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Noi_Dung.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Noi_Dung.Caption = "Nội dung câu  hỏi";
            this.Noi_Dung.FieldName = "Noi_Dung";
            this.Noi_Dung.Name = "Noi_Dung";
            this.Noi_Dung.Visible = true;
            this.Noi_Dung.VisibleIndex = 1;
            // 
            // Dap_An_A
            // 
            this.Dap_An_A.AppearanceHeader.Options.UseTextOptions = true;
            this.Dap_An_A.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Dap_An_A.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Dap_An_A.Caption = "Đáp an A";
            this.Dap_An_A.FieldName = "Dap_An_A";
            this.Dap_An_A.Name = "Dap_An_A";
            this.Dap_An_A.Visible = true;
            this.Dap_An_A.VisibleIndex = 2;
            // 
            // Dap_An_B
            // 
            this.Dap_An_B.AppearanceHeader.Options.UseTextOptions = true;
            this.Dap_An_B.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Dap_An_B.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Dap_An_B.Caption = "Đáp an B";
            this.Dap_An_B.FieldName = "Dap_An_B";
            this.Dap_An_B.Name = "Dap_An_B";
            this.Dap_An_B.Visible = true;
            this.Dap_An_B.VisibleIndex = 3;
            // 
            // Dap_An_C
            // 
            this.Dap_An_C.AppearanceHeader.Options.UseTextOptions = true;
            this.Dap_An_C.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Dap_An_C.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Dap_An_C.Caption = "Đáp an C";
            this.Dap_An_C.FieldName = "Dap_An_C";
            this.Dap_An_C.Name = "Dap_An_C";
            this.Dap_An_C.Visible = true;
            this.Dap_An_C.VisibleIndex = 4;
            // 
            // Dap_An_D
            // 
            this.Dap_An_D.AppearanceHeader.Options.UseTextOptions = true;
            this.Dap_An_D.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Dap_An_D.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Dap_An_D.Caption = "Đáp án D";
            this.Dap_An_D.FieldName = "Dap_An_D";
            this.Dap_An_D.Name = "Dap_An_D";
            this.Dap_An_D.Visible = true;
            this.Dap_An_D.VisibleIndex = 5;
            // 
            // Dap_An_HS
            // 
            this.Dap_An_HS.Caption = "Học Sinh trả lời";
            this.Dap_An_HS.FieldName = "Dap_An_HS";
            this.Dap_An_HS.Name = "Dap_An_HS";
            this.Dap_An_HS.Visible = true;
            this.Dap_An_HS.VisibleIndex = 6;
            // 
            // Dap_An_Dung
            // 
            this.Dap_An_Dung.AppearanceHeader.Options.UseTextOptions = true;
            this.Dap_An_Dung.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Dap_An_Dung.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Dap_An_Dung.Caption = "Đáp án";
            this.Dap_An_Dung.FieldName = "Dap_An_Dung";
            this.Dap_An_Dung.Name = "Dap_An_Dung";
            this.Dap_An_Dung.Visible = true;
            this.Dap_An_Dung.VisibleIndex = 7;
            // 
            // Thoi_Gian
            // 
            this.Thoi_Gian.Caption = "Thoi_Gian";
            this.Thoi_Gian.FieldName = "Thoi_Gian";
            this.Thoi_Gian.Name = "Thoi_Gian";
            // 
            // TraCuuBaiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "TraCuuBaiThi";
            this.Text = "Tra cứu bài thi";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTraCuuBaiThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraCuuBai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraGrid.GridControl gridTraCuuBaiThi;
        private DevExpress.XtraGrid.Views.Grid.GridView TraCuuBai;
        private DevExpress.XtraGrid.Columns.GridColumn Ten_Chu_De;
        private DevExpress.XtraGrid.Columns.GridColumn Noi_Dung;
        private DevExpress.XtraGrid.Columns.GridColumn Dap_An_A;
        private DevExpress.XtraGrid.Columns.GridColumn Dap_An_B;
        private DevExpress.XtraGrid.Columns.GridColumn Dap_An_C;
        private DevExpress.XtraGrid.Columns.GridColumn Dap_An_D;
        private DevExpress.XtraGrid.Columns.GridColumn Dap_An_HS;
        private DevExpress.XtraGrid.Columns.GridColumn Dap_An_Dung;
        private DevExpress.XtraGrid.Columns.GridColumn Thoi_Gian;
    }
}