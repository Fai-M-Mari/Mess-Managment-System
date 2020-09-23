using MMS.SQLCon;
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
using MMS.BLL;
using System.Text.RegularExpressions;

namespace MMS
{
    public partial class MamberBalanceUpdate : Form
    {
        public MamberBalanceUpdate()
        {
            InitializeComponent();
        }
        SQLConnection SQL = new SQLConnection();
        void Load_User_Total_BalanceOFPrePaided( int id_)
        {
            int Id = LogInBLL.Sys_Id_Of_Admin;
            int RegNo = Convert.ToInt32(id_);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL.GetCon();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Total_Balance_Of_UserPrePaid";
            cmd.Parameters.AddWithValue("@SysID", Id);
            cmd.Parameters.AddWithValue("@Ur_RegNo", RegNo);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            { 
                MemberBalanceBLL.BalanceS = Convert.ToDouble(rdr["Total_Balance"]);
            }
            txtBalance.Text = MemberBalanceBLL.BalanceS.ToString();
        }
        void Load_Users_OnForm()
        {
            int Id =  LogInBLL.Sys_Id_Of_Admin;
            DataTable DataTable = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL.GetCon();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AllUsers";
            cmd.Parameters.AddWithValue("@Sys_ID", Id);
            SqlDataAdapter adr = new SqlDataAdapter(cmd);
            adr.Fill(DataTable);
            cmbRegno.DisplayMember = "Ur_Name";
            cmbRegno.ValueMember = "Ur_RegNo";
            cmbRegno.DataSource = DataTable;
            cmbRegno.Text = "---Select---";
        }

        void Load_USERS_Balance_Deatails(int id)
        { 
            //LoadUSERSDetails
            int Id =  LogInBLL.Sys_Id_Of_Admin;
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

        private void MamberBalanceUpdate_Load(object sender, EventArgs e)
        {
            // Function Called On load Form
            Load_Users_OnForm();
        }

        #region Variables
        double Total_Prepaid_Balance;
        double New_PrePaid_Balance;
        double Update_PrePaid_Balance;
        #endregion

        void NewFuncation()
        {
            cmbRegno.Text = "---Select---";
            txtBalance.Text = "";
            txtNewBalance.Text = "";
            Total_Prepaid_Balance = 0;
            New_PrePaid_Balance = 0;
            Update_PrePaid_Balance = 0;
            int i = 0;
            Load_USERS_Balance_Deatails(i);

        }
        void Insert_User_PrePaid_Balance()
        {
            MemberBalanceBLL InsertDetails = new MemberBalanceBLL();
            Update_PrePaid_Balance = Total_Prepaid_Balance + New_PrePaid_Balance;
            InsertDetails.RegNo = RegNo;
            InsertDetails.Sys_ID = LogInBLL.Sys_Id_Of_Admin;
            InsertDetails.Total_PerPaid_Balance = Update_PrePaid_Balance;
            InsertDetails.Total_NewPrePaid_Balance = New_PrePaid_Balance;
            InsertDetails.Date = DateTime.Now.ToShortDateString();
            InsertDetails.Insert_PrePaid_Balance_Funcation(InsertDetails);
            MessageBox.Show("\t\t Data Successfully Saved \t\t","Data Saved");
        }

       
      
        void Delete_Balance(int ID,int RegNo)
        {
            MemberBalanceBLL D_Balance = new MemberBalanceBLL();
            D_Balance.Sys_ID = LogInBLL.Sys_Id_Of_Admin;
            D_Balance.RegNo = RegNo;
            D_Balance.UPrePaid_ID = ID;
            D_Balance.Delete_User_Balance(D_Balance);
        }
        void DeleteDataFunction()
        {
            int countDeleteRow = 0;
            foreach (DataGridViewRow row in DGV_Balance_Details.Rows)
            {
                //here We Checking either a Box Checked or Not.....
                DataGridViewCheckBoxCell cb = (DataGridViewCheckBoxCell)row.Cells["cbcheck"];
                if (Convert.ToBoolean(cb.Value) == true)
                    countDeleteRow++;
            }
            if (countDeleteRow >=0)
            {
                foreach (DataGridViewRow row in DGV_Balance_Details.Rows)
                {
                    DataGridViewCheckBoxCell cb = (DataGridViewCheckBoxCell)row.Cells["cbcheck"];
                    if (Convert.ToBoolean(cb.Value) == true)
                    {
                        //Here We Check row by Row Checked Member Registration Numbers..
                        int RegNo = Convert.ToInt32(row.Cells[2].Value.ToString());
                        int Id = Convert.ToInt32(row.Cells[1].Value.ToString());
                        Delete_Balance(Id, RegNo);
                    }
                }
            }
            else
            {
                MessageBox.Show("\tPlease check User Balance Record\t", "Messege!");
            }
            MessageBox.Show("\t\t Data Successfully Deleted \t\t", "Data Deleted");
           

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               Insert_User_PrePaid_Balance();
                NewFuncation();
            }
            catch 
            {
                MessageBox.Show("\t\tPlease Provide Information\t\t","Message");
            }
        }
        private void txtBalance_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(txtBalance.Text, @"[0-9]$"))
                {
                   
                    Total_Prepaid_Balance=Convert.ToDouble(txtBalance.Text);
                }
                else
                {
                    txtBalance.Text = txtBalance.Text.Remove(txtBalance.Text.Length - 1);
                    MessageBox.Show("\t\tUse Only Digits\t\t", "\tDigits Only");
                }
            }
            catch 
            { 
            }
        }
        private void txtNewBalance_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(txtNewBalance.Text, @"[0-9]$"))
                {
                    New_PrePaid_Balance = Convert.ToDouble(txtNewBalance.Text);
                }
                else {
                    txtNewBalance.Text = txtNewBalance.Text.Remove(txtNewBalance.Text.Length-1);
                    MessageBox.Show("\t\tUse Only Digits\t\t","\tDigits Only");
                }
            }
            catch { }
        }
        int RegNo = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteDataFunction();
                NewFuncation();
            }
            catch
            {
                MessageBox.Show("\t\tPlease Provide Information\t\t", "Message");
            }
        }
      
        int check = 0;
        void Load_User_DetailsFuncation()
        {
                RegNo = Convert.ToInt32(cmbRegno.SelectedValue);
                Load_User_Total_BalanceOFPrePaided(RegNo);
                Load_USERS_Balance_Deatails(RegNo);
        }
        private void cmbRegno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check != 0)
            {
                Load_User_DetailsFuncation();
            }
            check++;
        }
        ////this function will change into delete funcation by Id No and Ur_RegNo and SysID
        //void Remove_User_PrePaid_Balance()
        //{
        //    MemberBalanceBLL InsertDetails = new MemberBalanceBLL();
        //    InsertDetails.RegNo = RegNo;
        //    InsertDetails.Sys_ID =  LogInBLL.Sys_Id_Of_Admin;
        //    InsertDetails.Total_PerPaid_Balance = Update_PrePaid_Balance;
        //    InsertDetails.Total_NewPrePaid_Balance = New_PrePaid_Balance;
        //    InsertDetails.Date = DateTime.Now.ToShortDateString();
        //    InsertDetails.Insert_PrePaid_Balance_Funcation(InsertDetails);
        //    MessageBox.Show("\t\tData Successfully Savedt\t", "Data Saved");
        //}
    }
}
