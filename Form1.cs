using DoAnThiTracNghiem_Son.Controler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThiTracNghiem_Son
{
    public partial class Form1 : Form
    {
        Login_controler cls;
        public Form1()
        {
            InitializeComponent();
            textEdit1.Focus();
            cls = new Login_controler();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text.Trim()!=""&&textEdit2.Text.Trim()!="")
            {
                Console.WriteLine(EncodeMD5(textEdit2.Text.Trim()));
                taiKhoan tk = cls.getUser(textEdit1.Text.Trim(), EncodeMD5(textEdit2.Text.Trim()));
                if (tk==null)
                {
                    MessageBox.Show("Đăng nhập không thành công!");
                }
                else
                {
                    if (tk.phanQuyen==1)
                    {
                        QuanLy_View ql = new QuanLy_View(tk.userName);
                        ql.Show();
                        this.Hide();
                    }
                    else
                    {
                        ThiTracNghiem_VIEW thi = new ThiTracNghiem_VIEW(tk.userName);
                        thi.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu");
                if (textEdit1.Text.Trim()=="")
                {
                    textEdit1.Focus();
                }
                else
                {
                    textEdit2.Focus();
                }
            }
        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            Confirm_view frm = new Confirm_view();
            frm.ShowDialog();
        }
        private string EncodeMD5(string pass)
        {

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] bs = System.Text.Encoding.UTF8.GetBytes(pass);

            bs = md5.ComputeHash(bs);

            System.Text.StringBuilder s = new System.Text.StringBuilder();

            foreach (byte b in bs)
            {

                s.Append(b.ToString("x1").ToLower());

            }

            pass = s.ToString();

            return pass;

        }
    }
}
