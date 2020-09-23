using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MMS.SQLCon;
using MMS.BLL;

namespace MMS
{
    public partial class MMS : Form
    {   
        public MMS()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int check = 0;
        private void RegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check != 0)
            {
                 Load_User_DetailsFuncation();
            }
            check++;
        }
        void Load_Users_OnForm()
        {
            SQLConnection SQL = new SQLConnection();
            int Id = LogInBLL.Sys_Id_Of_Admin;
            DataTable DataTable = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL.GetCon();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AllUsers";
            cmd.Parameters.AddWithValue("@Sys_ID", Id);
            SqlDataAdapter adr = new SqlDataAdapter(cmd);
            adr.Fill(DataTable);
            cmbRegNo.DisplayMember = "Ur_Name";
            cmbRegNo.ValueMember = "Ur_RegNo";
            cmbRegNo.DataSource = DataTable;
            cmbRegNo.Text = "---Select---";
        }
        void Load_USERS_Balance_Deatails(int id)
        {
            //LoadUSERSDetails
            SQLConnection SQL = new SQLConnection();
            int Id = LogInBLL.Sys_Id_Of_Admin;
            DataTable DataTable = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL.GetCon();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UserPrePaid_Balance_Record";
            cmd.Parameters.AddWithValue("@SysID", Id);
            cmd.Parameters.AddWithValue("@Ur_RegNo", id);
            SqlDataAdapter adr = new SqlDataAdapter(cmd);
            adr.Fill(DataTable);
            DGV_Balance_Details.DataSource = DataTable;
        }
        void Load_User_DetailsFuncation()
        {

            int RegNo = 0;
            RegNo = Convert.ToInt32(cmbRegNo.SelectedValue);
            Load_USERS_Balance_Deatails(RegNo);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            Load_Users_OnForm();
        }
    }
}
