using Dapper;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace social_RMS
{
    public partial class form_print : DevExpress.XtraEditors.XtraForm
    {
        public form_print()
        {
            InitializeComponent();
        }

        private void form_print_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (Program.sql_con.State == ConnectionState.Closed)
                Program.sql_con.Open();
            string query = $" select * from person ";
            List<personprint> persons = Program.sql_con.Query<personprint>(query, commandType: CommandType.Text).ToList();
            using (XtraFormprint frm = new XtraFormprint())
            {
                frm.PrintInvoice("GLOBAL", persons);
                frm.WindowState = FormWindowState.Maximized;
                frm.ShowDialog();

            }
        }

        private void simpleButtonverser_Click(object sender, EventArgs e)
        {

            if (Program.sql_con.State == ConnectionState.Closed)
                Program.sql_con.Open();
            string query = $" select * from person  WHERE validateterrain = 1 and validateEnregiter = 1 and validateLicence = 1 ";
            List<personprint> persons = Program.sql_con.Query<personprint>(query, commandType: CommandType.Text).ToList();
            using (XtraFormprint frm = new XtraFormprint())
            {
                frm.PrintInvoice("VERSEMENT", persons);
                frm.WindowState = FormWindowState.Maximized;
                frm.ShowDialog();

            }
        }

        private void simpleButtonnonverser_Click(object sender, EventArgs e)
        {
            if (Program.sql_con.State == ConnectionState.Closed)
                Program.sql_con.Open();
            string query = $" select * from person  WHERE validateterrain != 1 OR validateEnregiter != 1 OR validateLicence != 1 ";
            List<personprint> persons = Program.sql_con.Query<personprint>(query, commandType: CommandType.Text).ToList();
            using (XtraFormprint frm = new XtraFormprint())
            {
                frm.PrintInvoice("Non VERSEMENT", persons);
                frm.WindowState = FormWindowState.Maximized;
                frm.ShowDialog();

            }
        }
    }
}