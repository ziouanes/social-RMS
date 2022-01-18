using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace social_RMS
{
    public partial class XtraReportPRINT : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportPRINT()
        {
            InitializeComponent();
        }
        public void InitData(string Type, List<personprint> personprint)
        {
            Parameters["parametertype"].Value = Type;
          

            objectDataSource1.DataSource = personprint;

        }

    }
}
