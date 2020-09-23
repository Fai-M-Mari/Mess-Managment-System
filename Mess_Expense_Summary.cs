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
using MMS.SQLCon;
using MMS.BLL;

namespace MMS
{
    public partial class Mess_Expense_Summary : Form
    {
        public Mess_Expense_Summary()
        {
            InitializeComponent();
        }

        private void Mess_Expense_Summary_Load(object sender, EventArgs e)
        {
            Load_Users_OnForm();
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
        void Load_USERS_Balance_Deatails(int RegNo)
        {
            //LoadUSERSDetails
            SQLConnection SQL = new SQLConnection();
            int Id = LogInBLL.Sys_Id_Of_Admin;
            DataTable DataTable = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL.GetCon();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "select_balance";
            cmd.Parameters.AddWithValue("@Sys_ID", Id);
            cmd.Parameters.AddWithValue("@RegNo", RegNo);
            SqlDataAdapter adr = new SqlDataAdapter(cmd);
            adr.Fill(DataTable);
            DGV_MessExpense_summary.DataSource = DataTable;
        }
        int RegNo = 0;
        void Load_User_DetailsFuncation()
        {

            RegNo = Convert.ToInt32(cmbRegNo.SelectedValue);
            Load_USERS_Balance_Deatails(RegNo);
        }
        private void cmbRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_User_DetailsFuncation();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        } 
    }
}
