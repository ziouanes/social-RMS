using DevExpress.XtraEditors;
using DevExpress.XtraReports.Parameters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace social_RMS
{
    public partial class XtraFormprint : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public XtraFormprint()
        {
            InitializeComponent();
        }

        private void XtraFormprint_Load(object sender, EventArgs e)
        {

        }

        public void PrintInvoice(string Type  , List<personprint> personprints)
        {
            XtraReportPRINT report = new XtraReportPRINT();

            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;


           

                    report.InitData(Type,  personprints);
                    documentViewer1.DocumentSource = report;
                    report.CreateDocument();

                


            
        }
    }
}