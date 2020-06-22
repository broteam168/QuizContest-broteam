namespace DoAnThiTracNghiem_Son
{
    partial class KhoiTaoDeThi_View
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbChude = new DevExpress.XtraEditors.LookUpEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbKho = new System.Windows.Forms.Label();
            this.lbTB = new System.Windows.Forms.Label();
            this.lbDe = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.txtKho = new System.Windows.Forms.TextBox();
            this.txtTB = new System.Windows.Forms.TextBox();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtThoiGian = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridDeThi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Tieu_De = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ma_Chu_De = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SL_De = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SL_TrungBinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SL_Kho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Thoi_Gian_Lam_Bai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nguoi_Tao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ngay_Tao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Trang_Thai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbChude.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDeThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(35, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Chủ đề :";
            // 
            // cbChude
            // 
            this.cbChude.Location = new System.Drawing.Point(127, 59);
            this.cbChude.Name = "cbChude";
            this.cbChude.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbChude.Properties.DisplayMember = "Ten_Chu_De";
            this.cbChude.Properties.ValueMember = "ID";
            this.cbChude.Size = new System.Drawing.Size(290, 20);
            this.cbChude.TabIndex = 1;
            this.cbChude.EditValueChanged += new System.EventHandler(this.cbChude_EditValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbKho);
            this.groupBox1.Controls.Add(this.lbTB);
            this.groupBox1.Controls.Add(this.lbDe);
            this.groupBox1.Controls.Add(this.txtTong);
            this.groupBox1.Controls.Add(this.txtKho);
            this.groupBox1.Controls.Add(this.txtTB);
            this.groupBox1.Controls.Add(this.txtDe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Số lượng câu hỏi";
            // 
            // lbKho
            // 
            this.lbKho.AutoSize = true;
            this.lbKho.Location = new System.Drawing.Point(273, 64);
            this.lbKho.Name = "lbKho";
            this.lbKho.Size = new System.Drawing.Size(11, 13);
            this.lbKho.TabIndex = 9;
            this.lbKho.Text = ".";
            // 
            // lbTB
            // 
            this.lbTB.AutoSize = true;
            this.lbTB.Location = new System.Drawing.Point(190, 65);
            this.lbTB.Name = "lbTB";
            this.lbTB.Size = new System.Drawing.Size(11, 13);
            this.lbTB.TabIndex = 8;
            this.lbTB.Text = ".";
            // 
            // lbDe
            // 
            this.lbDe.AutoSize = true;
            this.lbDe.Location = new System.Drawing.Point(111, 65);
            this.lbDe.Name = "lbDe";
            this.lbDe.Size = new System.Drawing.Size(11, 13);
            this.lbDe.TabIndex = 7;
            this.lbDe.Text = ".";
            // 
            // txtTong
            // 
            this.txtTong.Enabled = false;
            this.txtTong.Location = new System.Drawing.Point(325, 40);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(57, 21);
            this.txtTong.TabIndex = 6;
            this.txtTong.Text = "0";
            // 
            // txtKho
            // 
            this.txtKho.Enabled = false;
            this.txtKho.Location = new System.Drawing.Point(250, 41);
            this.txtKho.Name = "txtKho";
            this.txtKho.Size = new System.Drawing.Size(57, 21);
            this.txtKho.TabIndex = 5;
            this.txtKho.Text = "0";
            this.txtKho.TextChanged += new System.EventHandler(this.txtKho_TextChanged);
            // 
            // txtTB
            // 
            this.txtTB.Enabled = false;
            this.txtTB.Location = new System.Drawing.Point(170, 41);
            this.txtTB.Name = "txtTB";
            this.txtTB.Size = new System.Drawing.Size(57, 21);
            this.txtTB.TabIndex = 4;
            this.txtTB.Text = "0";
            this.txtTB.TextChanged += new System.EventHandler(this.txtTB_TextChanged);
            // 
            // txtDe
            // 
            this.txtDe.Enabled = false;
            this.txtDe.Location = new System.Drawing.Point(91, 42);
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(57, 21);
            this.txtDe.TabIndex = 3;
            this.txtDe.Text = "0";
            this.txtDe.TextChanged += new System.EventHandler(this.txtDe_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khó";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trung bình";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dễ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(35, 200);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Thời gian làm bài :";
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.Location = new System.Drawing.Point(127, 197);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.Size = new System.Drawing.Size(100, 21);
            this.txtThoiGian.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(233, 200);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "(phút)";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(126, 235);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(101, 39);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Tạo";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtTieuDe);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.checkBox1);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.cbChude);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtThoiGian);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(874, 295);
            this.panelControl1.TabIndex = 7;
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Location = new System.Drawing.Point(127, 16);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(290, 21);
            this.txtTieuDe.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(35, 24);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Tiêu đề :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(305, 201);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Kích hoạt";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 295);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(874, 185);
            this.panelControl2.TabIndex = 8;
            // 
            // gridDeThi
            // 
            this.gridDeThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDeThi.Location = new System.Drawing.Point(2, 2);
            this.gridDeThi.MainView = this.gridView1;
            this.gridDeThi.Name = "gridDeThi";
            this.gridDeThi.Size = new System.Drawing.Size(816, 177);
            this.gridDeThi.TabIndex = 0;
            this.gridDeThi.UseEmbeddedNavigator = true;
            this.gridDeThi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Tieu_De,
            this.Ma_Chu_De,
            this.SL_De,
            this.SL_TrungBinh,
            this.SL_Kho,
            this.Thoi_Gian_Lam_Bai,
            this.Nguoi_Tao,
            this.Ngay_Tao,
            this.Trang_Thai});
            this.gridView1.GridControl = this.gridDeThi;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // Tieu_De
            // 
            this.Tieu_De.Caption = "Tiêu đề";
            this.Tieu_De.FieldName = "Tieu_De";
            this.Tieu_De.Name = "Tieu_De";
            this.Tieu_De.Visible = true;
            this.Tieu_De.VisibleIndex = 0;
            // 
            // Ma_Chu_De
            // 
            this.Ma_Chu_De.Caption = "Chủ đề";
            this.Ma_Chu_De.FieldName = "ChuDe.Ten_Chu_De";
            this.Ma_Chu_De.Name = "Ma_Chu_De";
            this.Ma_Chu_De.Visible = true;
            this.Ma_Chu_De.VisibleIndex = 1;
            // 
            // SL_De
            // 
            this.SL_De.Caption = "Số lượng câu dễ";
            this.SL_De.FieldName = "SL_De";
            this.SL_De.Name = "SL_De";
            this.SL_De.Visible = true;
            this.SL_De.VisibleIndex = 2;
            // 
            // SL_TrungBinh
            // 
            this.SL_TrungBinh.Caption = "Số lượng câu trung bình";
            this.SL_TrungBinh.FieldName = "SL_TrungBinh";
            this.SL_TrungBinh.Name = "SL_TrungBinh";
            this.SL_TrungBinh.Visible = true;
            this.SL_TrungBinh.VisibleIndex = 3;
            // 
            // SL_Kho
            // 
            this.SL_Kho.Caption = "Số lượng câu khó";
            this.SL_Kho.FieldName = "SL_Kho";
            this.SL_Kho.Name = "SL_Kho";
            this.SL_Kho.Visible = true;
            this.SL_Kho.VisibleIndex = 4;
            // 
            // Thoi_Gian_Lam_Bai
            // 
            this.Thoi_Gian_Lam_Bai.Caption = "Thời gian làm bài (phút)";
            this.Thoi_Gian_Lam_Bai.FieldName = "Thoi_Gian_Lam_Bai";
            this.Thoi_Gian_Lam_Bai.Name = "Thoi_Gian_Lam_Bai";
            this.Thoi_Gian_Lam_Bai.Visible = true;
            this.Thoi_Gian_Lam_Bai.VisibleIndex = 5;
            // 
            // Nguoi_Tao
            // 
            this.Nguoi_Tao.Caption = "Người tạo";
            this.Nguoi_Tao.FieldName = "Nguoi_Tao";
            this.Nguoi_Tao.Name = "Nguoi_Tao";
            this.Nguoi_Tao.Visible = true;
            this.Nguoi_Tao.VisibleIndex = 6;
            // 
            // Ngay_Tao
            // 
            this.Ngay_Tao.Caption = "Ngày tạo";
            this.Ngay_Tao.FieldName = "Ngay_Tao";
            this.Ngay_Tao.Name = "Ngay_Tao";
            this.Ngay_Tao.Visible = true;
            this.Ngay_Tao.VisibleIndex = 7;
            // 
            // Trang_Thai
            // 
            this.Trang_Thai.Caption = "Trang_Thai";
            this.Trang_Thai.FieldName = "Trang_Thai";
            this.Trang_Thai.Name = "Trang_Thai";
            this.Trang_Thai.Visible = true;
            this.Trang_Thai.VisibleIndex = 8;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.simpleButton2);
            this.panelControl3.Controls.Add(this.checkBox2);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(822, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(50, 181);
            this.panelControl3.TabIndex = 1;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.gridDeThi);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(2, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(820, 181);
            this.panelControl4.TabIndex = 2;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(16, 6);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(4, 26);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(41, 32);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "CN";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // KhoiTaoDeThi_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 480);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "KhoiTaoDeThi_View";
            this.Text = "Khởi tạo đề thi";
            ((System.ComponentModel.ISupportInitialize)(this.cbChude.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDeThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit cbChude;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.TextBox txtKho;
        private System.Windows.Forms.TextBox txtTB;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtThoiGian;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridDeThi;
        private System.Windows.Forms.CheckBox checkBox1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtTieuDe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Tieu_De;
        private DevExpress.XtraGrid.Columns.GridColumn Ma_Chu_De;
        private DevExpress.XtraGrid.Columns.GridColumn SL_De;
        private DevExpress.XtraGrid.Columns.GridColumn SL_TrungBinh;
        private DevExpress.XtraGrid.Columns.GridColumn SL_Kho;
        private DevExpress.XtraGrid.Columns.GridColumn Thoi_Gian_Lam_Bai;
        private DevExpress.XtraGrid.Columns.GridColumn Nguoi_Tao;
        private DevExpress.XtraGrid.Columns.GridColumn Ngay_Tao;
        private DevExpress.XtraGrid.Columns.GridColumn Trang_Thai;
        private System.Windows.Forms.Label lbKho;
        private System.Windows.Forms.Label lbTB;
        private System.Windows.Forms.Label lbDe;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.CheckBox checkBox2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}