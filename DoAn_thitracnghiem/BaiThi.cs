using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace DoAnThiTracNghiem_Son
{
    public partial class BaiThi : DevExpress.XtraReports.UI.XtraReport
    {
        public BaiThi()
        {
            InitializeComponent();
        }
        public BaiThi(int sumCH,int TLD)
        {
            InitializeComponent();
            xrLabel5.Text = sumCH.ToString();
            xrLabel6.Text = TLD.ToString();
        }
    }
}
