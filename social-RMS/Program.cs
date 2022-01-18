using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace social_RMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Create a new object, representing the German culture. 
            CultureInfo culture = CultureInfo.CreateSpecificCulture("fr-FR");

            // The following line provides localization for the application's user interface. 
            Thread.CurrentThread.CurrentUICulture = culture;

            // The following line provides localization for data formats. 
            Thread.CurrentThread.CurrentCulture = culture;

            // Set this culture as the default culture for all threads in this application. 
            // Note: The following properties are supported in the .NET Framework 4.5+
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

       //   public static SqlConnection sql_con = new SqlConnection("Data Source=hamza;Initial Catalog=dbversement_socialRMS;Integrated Security=True;MultipleActiveResultSets = True;");

        //loubna
        public static SqlConnection sql_con = new SqlConnection(@"server =192.168.100.96;database = dbversement_socialRMS ; user id = Login1; password=7895123 ;MultipleActiveResultSets =True;");






        internal static SqlCommand sql_cmd;

        public static SqlDataReader db;

        public static SqlDataAdapter adapter;
    }
}
