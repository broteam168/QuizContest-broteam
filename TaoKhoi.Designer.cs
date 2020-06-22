namespace DoAnThiTracNghiem_Son
{
    partial class TaoKhoi
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
            this.khoi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtChuDe = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbHanhDong = new DevExpress.XtraEditors.LabelControl();
            this.cmdGhi = new DevExpress.XtraEditors.SimpleButton();
            this.cmdHuy = new DevExpress.XtraEditors.SimpleButton();
            this.cmdXoa = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSua = new DevExpress.XtraEditors.SimpleButton();
            this.cmdThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridChuDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChuDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
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
            this.gridChuDe.TabIndex = 6;
            this.gridChuDe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ChuDe});
            // 
            // ChuDe
            // 
            this.ChuDe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.khoi1,
            this.id});
            this.ChuDe.GridControl = this.gridChuDe;
            this.ChuDe.Name = "ChuDe";
            this.ChuDe.OptionsBehavior.Editable = false;
            this.ChuDe.OptionsFind.AlwaysVisible = true;
            this.ChuDe.OptionsFind.FindNullPrompt = ".....";
            this.ChuDe.OptionsView.ShowGroupPanel = false;
            this.ChuDe.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.ChuDe_FocusedRowChanged);
            // 
            // khoi1
            // 
            this.khoi1.AppearanceHeader.Options.UseTextOptions = true;
            this.khoi1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.khoi1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.khoi1.Caption = "Tên khối";
            this.khoi1.FieldName = "khoi1";
            this.khoi1.Name = "khoi1";
            this.khoi1.Visible = true;
            this.khoi1.VisibleIndex = 0;
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "ID";
            this.id.Name = "id";
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.panelControl2.Controls.Add(this.txtChuDe);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(439, 51);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(397, 280);
            this.panelControl2.TabIndex = 5;
            // 
            // txtChuDe
            // 
            this.txtChuDe.Location = new System.Drawing.Point(61, 25);
            this.txtChuDe.Name = "txtChuDe";
            this.txtChuDe.Size = new System.Drawing.Size(200, 21);
            this.txtChuDe.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(28, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Khối :";
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
            this.panelControl1.TabIndex = 4;
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
            // TaoKhoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 331);
            this.Controls.Add(this.gridChuDe);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "TaoKhoi";
            this.Text = "TaoKhoi";
            this.Load += new System.EventHandler(this.TaoKhoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridChuDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChuDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridChuDe;
        private DevExpress.XtraGrid.Views.Grid.GridView ChuDe;
        private DevExpress.XtraGrid.Columns.GridColumn khoi1;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.TextBox txtChuDe;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lbHanhDong;
        private DevExpress.XtraEditors.SimpleButton cmdGhi;
        private DevExpress.XtraEditors.SimpleButton cmdHuy;
        private DevExpress.XtraEditors.SimpleButton cmdXoa;
        private DevExpress.XtraEditors.SimpleButton cmdSua;
        private DevExpress.XtraEditors.SimpleButton cmdThem;
    }
}