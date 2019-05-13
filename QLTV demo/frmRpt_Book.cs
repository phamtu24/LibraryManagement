using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

using CrystalDecisions.CrystalReports.Engine;

namespace QLTV_demo
{
    public partial class frmRpt_Book : Form
    {
        public frmRpt_Book()
        {
            InitializeComponent();
            LoadReport();
        }
        private void LoadReport()
        {          
            ReportDocument rpt = new ReportDocument();           
            rpt.Load(@"..\..\rptBook.rpt");
            rpt.SetDataSource(frmSearch_Book.dttb);
            rptViewer.ReportSource = rpt;       
        }
    }
}
