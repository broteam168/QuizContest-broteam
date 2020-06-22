using DevExpress.XtraGrid.Views.Grid;
using DoAnThiTracNghiem_Son.Controler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace DoAnThiTracNghiem_Son
{
    public partial class ThongKe_View : DevExpress.XtraEditors.XtraForm
    {
        private ThongKe_Controler cls;
        private int SumCH, TLD;
        private string hocsinhThi;
        public ThongKe_View()
        {
            InitializeComponent();
            cls = new ThongKe_Controler();
            init();
        }
        public void init() {
            cbDeThi.Properties.NullText = "Vui lòng chọn đề thi";
            cbDeThi.Properties.DataSource = cls.getDeThi();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                gridThongKe.DataSource = null;
                gridThongKe.DataSource = cls.listThongKe(int.Parse(cbDeThi.EditValue.ToString()));
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra bạn vui lòng kiểm tra lại.");
            }
        }

        private void ThongKe_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            int dung = int.Parse(View.GetRowCellDisplayText(e.RowHandle, View.Columns["SUM_DUNG"]).ToString());
            int sumCH = int.Parse(View.GetRowCellDisplayText(e.RowHandle, View.Columns["SUM_CAUHOI"]).ToString());
            if (dung==0)
            {
                e.Appearance.BackColor = Color.DarkGray;
                e.Appearance.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
            }
            else
            {
                if (((sumCH / dung)) > 2) //+ (sumCH % dung)
                {
                    e.Appearance.BackColor = Color.DarkGray;
                    e.Appearance.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                }
                else
                {
                    e.Appearance.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Regular);
                }
            }
        }

        private void export2Excel(GridView g, string duongDan)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 15;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].Caption;
            }
            for (int i = 0; i < g.RowCount; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Columns[j] != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.GetRowCellValue(i, g.Columns[j]);
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan);
            obj.ActiveWorkbook.Saved = true;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (ThongKe.RowCount != 0)
            {
                saveFileDialog1.Filter = "Excel (2010) (.xlsx)|*.xlsx|Excel (2003)(.xls)|*.xls";
                if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveFileDialog1.FileName;
                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            DialogResult result = MessageBox.Show("File đã tồn tại,bạn có muốn ghi đè file không?", "xác thực", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                this.Cursor = Cursors.WaitCursor;
                                export2Excel(ThongKe, exportFilePath);
                                MessageBox.Show("Xuất file thành công!");
                                this.Cursor = Cursors.Default;
                            }
                        }
                        catch
                        {
                            String msg = "Không thể save file. Bạn vui lòng kiểm tra lại" + Environment.NewLine + Environment.NewLine + "Đường dẫn: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        this.Cursor = Cursors.WaitCursor;
                        export2Excel(ThongKe, exportFilePath);
                        MessageBox.Show("Xuất file thành công!");
                        this.Cursor = Cursors.Default;
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất file excel");
            }
        }

        private void ThongKe_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!ThongKe.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
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
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, ThongKe); })); //Tăng kích thước nếu Text vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1)); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, ThongKe); }));
            }
        }
        bool cal(Int32 _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
        }

        private void ThongKe_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                hocsinhThi = ThongKe.GetFocusedRowCellValue("userName").ToString();
                SumCH = int.Parse(ThongKe.GetFocusedRowCellValue("SUM_CAUHOI").ToString());
                TLD = int.Parse(ThongKe.GetFocusedRowCellValue("SUM_DUNG").ToString()); 
            }
            catch (Exception)
            {
                
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            List<De_H> dhs = cls.deThiHS(hocsinhThi, int.Parse(cbDeThi.EditValue.ToString()));
            if (dhs.Count!=0)
            {
                BaiThi bt = new BaiThi(SumCH, TLD);
                bt.DataSource = dhs;
                bt.ShowPreviewDialog();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xem");
            }
        }
    }
}
