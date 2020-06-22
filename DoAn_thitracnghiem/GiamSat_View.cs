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
    public partial class GiamSat_View : DevExpress.XtraEditors.XtraForm
    {
        private GiamSat_Controler cls;
        private int madt;
        public GiamSat_View()
        {
            InitializeComponent();
            cls = new GiamSat_Controler();
            init();
        }
        public void init() {
            cbDeThi.Properties.NullText = "Vui lòng chọn đề thi";
            cbDeThi.Properties.DataSource = cls.getDanhSanhDe();
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (!gridView1.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
            {
                if (e.Info.IsRowIndicator) //Nếu là dòng Indicator
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1; //Không hiển thị hình
                        e.Info.DisplayText = (e.RowHandle + 1).ToString(); //Số thứ tự tăng dần
                    }
                    SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); //Lấy kích thước của vùng hiển thị Text
                    Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gridView1); })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gridView1); }));
            }
        }
        bool cal(Int32 _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            madt = int.Parse(cbDeThi.EditValue.ToString());
            gridControl1.DataSource = null;
            gridControl1.DataSource = cls.getGiamSat(madt);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gridView1.RowCount!=0)
            {
                gridControl1.DataSource = null;
                gridControl1.DataSource = cls.getGiamSat(madt);
            }
        }
    }
}
