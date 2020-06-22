using DevExpress.XtraGrid.Views.Grid;
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
    public partial class TraCuuBaiThi : DevExpress.XtraEditors.XtraForm
    {
        private TraCuuBaiThi_Controler cls;
        public TraCuuBaiThi()
        {
            InitializeComponent();
            cls = new TraCuuBaiThi_Controler();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="" && textBox2.Text!="")
            {
                List<De_H> lst=cls.ChiTietDeThiHS(textBox1.Text.Trim(), textBox2.Text.Trim());
                if (lst.Count!=0)
                {
                    gridTraCuuBaiThi.DataSource = null;
                    gridTraCuuBaiThi.DataSource = lst;
                }
                else
                {
                    MessageBox.Show("Không có kết quả nào thỏa mãn điều kiện nhập vào.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên đề thi và chính xác tên tài khoản học sinh cần tìm kiếm");
            }
        }

        private void TraCuuBai_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            string dapAnHS = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Dap_An_HS"]);
            string dapAnDung = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Dap_An_Dung"]);
            if (dapAnHS!=dapAnDung)
            {
                e.Appearance.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Regular);
            }
            else
            {
                e.Appearance.BackColor = Color.Violet;
                e.Appearance.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
            }
        }
    }
}
