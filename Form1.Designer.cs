namespace DoAnThiTracNghiem_Son
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.btConfig = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageSlider1
            // 
            this.imageSlider1.CurrentImageIndex = 0;
            this.imageSlider1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images"))));
            this.imageSlider1.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch;
            this.imageSlider1.Location = new System.Drawing.Point(0, 0);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(438, 249);
            this.imageSlider1.TabIndex = 1;
            this.imageSlider1.Text = "imageSlider1";
            this.imageSlider1.UseDisabledStatePainter = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.labelControl1.Location = new System.Drawing.Point(88, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(259, 27);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Đăng nhập thi trắc nghiệm";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.labelControl2.Location = new System.Drawing.Point(60, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(111, 27);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tài khoản :";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(180, 69);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(190, 26);
            this.textEdit1.TabIndex = 4;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(180, 116);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Properties.PasswordChar = '*';
            this.textEdit2.Size = new System.Drawing.Size(190, 26);
            this.textEdit2.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.labelControl3.Location = new System.Drawing.Point(60, 114);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(105, 27);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Mật khẩu :";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageIndex = 0;
            this.simpleButton1.ImageList = this.imageCollection1;
            this.simpleButton1.Location = new System.Drawing.Point(180, 164);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(126, 50);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Đăng nhập";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "User Computer.png");
            // 
            // btConfig
            // 
            this.btConfig.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btConfig.Location = new System.Drawing.Point(0, 232);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(21, 17);
            this.btConfig.TabIndex = 8;
            this.btConfig.Text = "..";
            this.btConfig.Click += new System.EventHandler(this.btConfig_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 249);
            this.Controls.Add(this.btConfig);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.imageSlider1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.SimpleButton btConfig;

    }
}

