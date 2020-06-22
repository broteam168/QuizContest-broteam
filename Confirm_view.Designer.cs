namespace DoAnThiTracNghiem_Son
{
    partial class Confirm_view
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
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtDB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtServer = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btcheckConnection = new DevExpress.XtraEditors.SimpleButton();
            this.cmdThoat = new DevExpress.XtraEditors.SimpleButton();
            this.cmdGhi = new DevExpress.XtraEditors.SimpleButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(83, 107);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.PasswordChar = '*';
            this.txtPass.Properties.UseSystemPasswordChar = true;
            this.txtPass.Size = new System.Drawing.Size(230, 20);
            this.txtPass.TabIndex = 36;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(27, 14);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 13);
            this.labelControl5.TabIndex = 29;
            this.labelControl5.Text = "Server:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(83, 73);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(230, 20);
            this.txtUser.TabIndex = 35;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(27, 77);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(26, 13);
            this.labelControl6.TabIndex = 30;
            this.labelControl6.Text = "User:";
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(83, 42);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(230, 20);
            this.txtDB.TabIndex = 34;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(27, 110);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(50, 13);
            this.labelControl7.TabIndex = 31;
            this.labelControl7.Text = "Password:";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(83, 10);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(230, 20);
            this.txtServer.TabIndex = 33;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(27, 46);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(17, 13);
            this.labelControl8.TabIndex = 32;
            this.labelControl8.Text = "DB:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btcheckConnection);
            this.panelControl1.Controls.Add(this.cmdThoat);
            this.panelControl1.Controls.Add(this.cmdGhi);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 138);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(358, 40);
            this.panelControl1.TabIndex = 28;
            // 
            // btcheckConnection
            // 
            this.btcheckConnection.Location = new System.Drawing.Point(33, 9);
            this.btcheckConnection.Name = "btcheckConnection";
            this.btcheckConnection.Size = new System.Drawing.Size(99, 23);
            this.btcheckConnection.TabIndex = 2;
            this.btcheckConnection.Text = "Kiểm tra kết nối";
            this.btcheckConnection.Click += new System.EventHandler(this.btcheckConnection_Click);
            // 
            // cmdThoat
            // 
            this.cmdThoat.Location = new System.Drawing.Point(268, 9);
            this.cmdThoat.Name = "cmdThoat";
            this.cmdThoat.Size = new System.Drawing.Size(86, 23);
            this.cmdThoat.TabIndex = 1;
            this.cmdThoat.Text = "Thoát";
            this.cmdThoat.Click += new System.EventHandler(this.cmdThoat_Click);
            // 
            // cmdGhi
            // 
            this.cmdGhi.Location = new System.Drawing.Point(156, 9);
            this.cmdGhi.Name = "cmdGhi";
            this.cmdGhi.Size = new System.Drawing.Size(90, 23);
            this.cmdGhi.TabIndex = 0;
            this.cmdGhi.Text = "Ghi";
            this.cmdGhi.Click += new System.EventHandler(this.cmdGhi_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Confirm_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 178);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.panelControl1);
            this.Name = "Confirm_view";
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtDB;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtServer;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btcheckConnection;
        private DevExpress.XtraEditors.SimpleButton cmdThoat;
        private DevExpress.XtraEditors.SimpleButton cmdGhi;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}