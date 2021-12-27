﻿using Dapper;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace social_RMS
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            select_person_Data();

        }

        public void run()
        {
            SplashScreenManager.ShowForm(this, typeof(WaitFormsplach), true, true, false);

            SplashScreenManager.Default.SetWaitFormCaption("en cours d'exécution");
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(5);
            }
            SplashScreenManager.CloseForm();
            stepProgressBar1.SelectedItemIndex = -1;

        }

        private void lookUpEdit1_Properties_Click(object sender, EventArgs e)
        {

        }

        private void select_person_Data()
        {
            try
            {

                //stepProgressBar1.SelectedItemIndex = -1;
                if (Program.sql_con.State == ConnectionState.Closed) Program.sql_con.Open();





                string query = $"select id , name_fr , name_ar , cne from Person ; ";
                   personBindingSource.DataSource = Program.sql_con.Query<person>(query, commandType: CommandType.Text);




                lookUpEdit1.Properties.PopulateColumns();
                lookUpEdit1.Properties.Columns[0].Visible = false;
               




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //this.Dispose();
            }
        }

        private void select_VERSEMENT_Data()
        {
            try
            {

                //stepProgressBar1.SelectedItemIndex = -1;
                if (Program.sql_con.State == ConnectionState.Closed) Program.sql_con.Open();





                string query = $"select v.id  , v.name_  , v.price , t.total_price, t.type_ from versements v inner join versement_type t on v.id_versement = t.id  inner join  Person p on p.id = v.id_person where p.id  = {lookUpEdit1.EditValue.ToString()} ";
                versementBindingSource.DataSource = Program.sql_con.Query<versement>(query, commandType: CommandType.Text);




            





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //this.Dispose();
            }
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
           
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            run();
            if (lookUpEdit1.ItemIndex != -1)
            {
                select_VERSEMENT_Data();
                if (Program.sql_con.State == ConnectionState.Closed) Program.sql_con.Open();

                {

                    SqlCommand cmd = Program.sql_con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = " select validateterrain , validateEnregiter , validateLicence from Person where id   =  " + lookUpEdit1.EditValue.ToString() + " ";

                    DataTable table = new DataTable();
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                       


                        

                        //
                         if (int.Parse(row["validateterrain"].ToString()) == 0)
                        {
                            stepProgressBar1.SelectedItemIndex = 0;
                            stepProgressBarItem1.Options.Indicator.ActiveStateImageOptions.Image = Properties.Resources.synchronize_40px;


                        }
                         if (int.Parse(row["validateterrain"].ToString()) == 1)
                        {

                            stepProgressBar1.SelectedItemIndex = 0;
                            stepProgressBarItem1.Options.Indicator.ActiveStateImageOptions.Image = Properties.Resources.checked_40px;




                        }
                        ///
                        if (int.Parse(row["validateEnregiter"].ToString()) == 0)
                        {
                            stepProgressBar1.SelectedItemIndex = 1;
                            stepProgressBarItem2.Options.Indicator.ActiveStateImageOptions.Image = Properties.Resources.synchronize_40px;


                        }
                        if (int.Parse(row["validateEnregiter"].ToString()) == 1)
                        {

                            stepProgressBar1.SelectedItemIndex = 1;
                            stepProgressBarItem2.Options.Indicator.ActiveStateImageOptions.Image = Properties.Resources.checked_40px;


                        }
                        ////
                        if (int.Parse(row["validateLicence"].ToString()) == 0)
                        {
                            stepProgressBar1.SelectedItemIndex = 2;
                            stepProgressBarItem3.Options.Indicator.ActiveStateImageOptions.Image = Properties.Resources.synchronize_40px;


                        }
                        if (int.Parse(row["validateLicence"].ToString()) == 1)
                        {

                            stepProgressBar1.SelectedItemIndex = 2;
                            stepProgressBarItem3.Options.Indicator.ActiveStateImageOptions.Image = Properties.Resources.checked_40px;


                        }


                    }
                }

            }
        }
    }
}
