using DoAnThiTracNghiem_Son.Controler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThiTracNghiem_Son
{
    public partial class DoiMatKhau_View : Form
    {
        private string userName;
        private DoiMatKhau_Controler cls;
        public DoiMatKhau_View(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            cls = new DoiMatKhau_Controler();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtMKCu.Text.Trim()!=""&&txtMKMoi.Text.Trim()!=""&&txtMKMoi2.Text.Trim()!="")
            {
                string mk = cls.getMatKhau(userName);
                if (mk.Equals(txtMKCu.Text.Trim()))
                {
                    if (txtMKMoi.Text.Trim().Equals(txtMKMoi2.Text.Trim()))
                    {
                        taiKhoan tk = cls.getTK(userName);
                        tk.pass = txtMKMoi.Text.Trim();
                        cls.update(tk);
                        MessageBox.Show("Cập nhật mật khẩu thành công!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("2 Mật khẩu mới không giống nhau!");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác!");
                }
            }
        }
    }
}
