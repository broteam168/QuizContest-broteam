namespace DoAnThiTracNghiem_Son
{
    partial class DoiMatKhau_View
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
            this.txtMKCu = new System.Windows.Forms.TextBox();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMKMoi2 = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(40, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mật khẩu cũ :";
            // 
            // txtMKCu
            // 
            this.txtMKCu.Location = new System.Drawing.Point(157, 29);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.PasswordChar = '*';
            this.txtMKCu.Size = new System.Drawing.Size(157, 20);
            this.txtMKCu.TabIndex = 1;
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Location = new System.Drawing.Point(157, 75);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.PasswordChar = '*';
            this.txtMKMoi.Size = new System.Drawing.Size(157, 20);
            this.txtMKMoi.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(40, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mật khẩu mới :";
            // 
            // txtMKMoi2
            // 
            this.txtMKMoi2.Location = new System.Drawing.Point(157, 120);
            this.txtMKMoi2.Name = "txtMKMoi2";
            this.txtMKMoi2.PasswordChar = '*';
            this.txtMKMoi2.Size = new System.Drawing.Size(157, 20);
            this.txtMKMoi2.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(40, 123);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(111, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Nhập lại mật khẩu mới :";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(157, 155);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(84, 26);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Cập nhật";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // DoiMatKhau_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 195);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtMKMoi2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtMKMoi);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtMKCu);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "DoiMatKhau_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtMKCu;
        private System.Windows.Forms.TextBox txtMKMoi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtMKMoi2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}