using Dapper;
using DevExpress.XtraEditors;
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
    public partial class versements : DevExpress.XtraEditors.XtraForm
    {
        public versements()
        {
            InitializeComponent();
            select_person_Data();
        }

            int id_versement = -1;
        public versements( int idperson)
        {
            InitializeComponent();

            select_person_Data();
            lookUpEdit1.EditValue = idperson;

            //
            try
            {
                if (Program.sql_con.State == ConnectionState.Closed) Program.sql_con.Open();

                {
                    int  validateterrain = -1;
                    int validateEnregiter  =-1;
                    int validateLicence = -1;

                    SqlCommand cmd = Program.sql_con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = " select TOP  1 validateterrain , validateEnregiter ,validateLicence  from Person    where id = " + idperson + " ";

                    DataTable table = new DataTable();
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        validateterrain = int.Parse(row["validateterrain"].ToString());
                        validateEnregiter = int.Parse(row["validateEnregiter"].ToString());
                        validateLicence = int.Parse(row["validateLicence"].ToString());



                    }
                    if(validateterrain == -1 || validateLicence  == 0)
                    {
                        lookUpEditverse.SelectedIndex = 0;
                        id_versement = 3;

                    }
                    else if(validateEnregiter == -1 || validateEnregiter == 0)
                    {
                        lookUpEditverse.SelectedIndex = 1;
                        id_versement = 4;

                    }
                    else if (validateLicence == -1 || validateLicence == 0)
                    {
                        lookUpEditverse.SelectedIndex = 2;
                        id_versement = 5;

                    }

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                //this.Dispose();
            }
        }
        private void select_person_Data()
        {
            try
            {

                //stepProgressBar1.SelectedItemIndex = -1;
                if (Program.sql_con.State == ConnectionState.Closed) Program.sql_con.Open();





                string query = $"select id , name_fr , name_ar , cne from Person ; ";
                personBindingSource.DataSource = Program.sql_con.Query<person>(query, commandType: CommandType.Text);




                //lookUpEdit1.Properties.PopulateColumns();
                //lookUpEdit1.Properties.Columns[0].Visible = false;





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

        private void versements_Load(object sender, EventArgs e)
        {
            textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            textEdit1.Properties.Mask.EditMask = "D";
            textEdit1.Properties.Mask.UseMaskAsDisplayFormat = true;
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Program.sql_con.State == ConnectionState.Closed) Program.sql_con.Open();

                {
                    int validateterrain = -1;
                    int validateEnregiter = -1;
                    int validateLicence = -1;

                    SqlCommand cmd = Program.sql_con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = " select TOP  1 validateterrain , validateEnregiter ,validateLicence  from Person    where id = " + lookUpEdit1.EditValue + " ";

                    DataTable table = new DataTable();
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        validateterrain = int.Parse(row["validateterrain"].ToString());
                        validateEnregiter = int.Parse(row["validateEnregiter"].ToString());
                        validateLicence = int.Parse(row["validateLicence"].ToString());



                    }
                     if(validateterrain == -1 || validateLicence  == 0)
                    {
                        lookUpEditverse.SelectedIndex = 0;
                        id_versement = 3;

                    }
                    else if(validateEnregiter == -1 || validateEnregiter == 0)
                    {
                        lookUpEditverse.SelectedIndex = 1;
                        id_versement = 4;

                    }
                    else if (validateLicence == -1 || validateLicence == 0)
                    {
                        lookUpEditverse.SelectedIndex = 2;
                        id_versement = 5;

                    }

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                //this.Dispose();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (lookUpEdit1.ItemIndex != -1)
            {
                string sql = "insert into versements(name_ ,price,id_person,id_versement ) values(@name_,@price,@id_person,@id_versement)";


                Program.sql_cmd = new SqlCommand(sql, Program.sql_con);
                Program.sql_cmd.Parameters.AddWithValue("@name_", comboBoxEditetat.Text);
                Program.sql_cmd.Parameters.AddWithValue("@price", textEdit1.Text);
                Program.sql_cmd.Parameters.AddWithValue("@id_person", lookUpEdit1.EditValue.ToString());
                Program.sql_cmd.Parameters.AddWithValue("@id_versement", id_versement);
               




                if (Program.sql_con.State == ConnectionState.Closed) Program.sql_con.Open();
                Program.sql_cmd.ExecuteNonQuery();
                Program.sql_con.Close();
                //   XtraMessageBox.Show("good");

                 toastNotificationsManager1.ShowNotification("3a0b28d8-ab92-457a-b81f-be625f7a36a8");
                this.Close();


            }
        }
    }
}