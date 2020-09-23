using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MMS.BLL;
using MMS.DAL;
using MMS.SQLCon;

namespace MMS
{
    public partial class Daily_Investment : Form
    {
        public Daily_Investment()
        {
            InitializeComponent();
        }

        private void Daily_Investment_Load(object sender, EventArgs e)
        {
           // LbRegNo.Text = LogInBLL.ReGno.ToString();
            LbRegNo.Text = LogInBLL.Sys_Id_Of_Admin.ToString();
            loadAllUsers();
        }
        //Data Gird Veiw Function Load Members From DataBase
        void loadAllUsers()
        {
            SQLConnection hl = new SQLConnection();
            int Id = LogInBLL.Sys_Id_Of_Admin;
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = hl.GetCon();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AllUsers";
            cmd.Parameters.AddWithValue("@Sys_ID", Id);
            SqlDataAdapter adr = new SqlDataAdapter(cmd);
            adr.Fill(dt);
            DGVShowMembers.DataSource = dt; 
        }
        //Local varibales
        int Check = 0;
        int Total_Members;
        int DINV_ID = 0;
        double TotalAmountInvest;
        double TotalSharePerMember;
        void SharePerMemberFunction()
        {
            try
            {
                if (Regex.IsMatch(txtTotal_Members.Text, @"[0-9]$"))
                {
                    Total_Members = Convert.ToInt32(txtTotal_Members.Text);
                }
                else
                {
                    txtTotal_Members.Text = txtTotal_Members.Text.Remove(txtTotal_Members.Text.Length - 1);
                    MessageBox.Show("Use only Digits");
                    txtTotal_Members.Text = "";
                }
            }
            catch
            {
            }
            if (txtTotal_Members.Text != "")
            {
                TotalSharePerMember = TotalAmountInvest / Total_Members;
                LbPerMemberAmount.Text = Convert.ToString(TotalSharePerMember);  
            }
        }
 
        private void txtTotal_Members_TextChanged(object sender, EventArgs e)
        {
            SharePerMemberFunction();
        }

        private void txtTotal_Amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(txtTotal_Amount.Text, @"[0-9]$"))
                {
                    TotalAmountInvest = Convert.ToDouble(txtTotal_Amount.Text);
                }
                else
                {
                    txtTotal_Amount.Text = txtTotal_Amount.Text.Remove(txtTotal_Amount.Text.Length - 1);
                    MessageBox.Show("Use only Digits");
                    txtTotal_Amount.Text = "";
                }
            }
            catch 
            { 
            }
           
        }
        #region These Four Functions Are Used In Save Button for Performering Special Operation
        void LoadDailyINvestMent_ID()
        {
            SQLConnection hl = new SQLConnection();
            SqlCommand cmd = new SqlCommand("select max(DINV_ID) as newTranID from Daily_Investment", hl.GetCon());
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DINV_ID = Convert.ToInt32(dt.Rows[0]["newTranID"].ToString());
            }
        }
        void insert_Daily_Investment()
        {
            MMSDailyBLL Insert_Daily_Invest = new MMSDailyBLL();
            Insert_Daily_Invest.User_Regno = 0;
            Insert_Daily_Invest.Inv_Total_Amount = TotalAmountInvest;
            Insert_Daily_Invest.Total_Members = Total_Members;
            Insert_Daily_Invest.Inv_SharePerMember = TotalSharePerMember;
            Insert_Daily_Invest.Inv_Discription = txtDiscreption.Text;
            Insert_Daily_Invest.Date = DateTime.Now.ToString();
            Insert_Daily_Invest.SysID = LogInBLL.Sys_Id_Of_Admin;
            Insert_Daily_Invest.Identity = 1;
            Insert_Daily_Invest.Insert_Daily_Investments(Insert_Daily_Invest);
        }
        void Insert_Mess_Balance(int ID)
        {
            //this is Expense Balance Of Mess Function
            MMSDailyBLL InsertInMess = new MMSDailyBLL();
            InsertInMess.Mess_Exp_Ur_RegNo = ID;
            InsertInMess.DINV_ID = DINV_ID;
            InsertInMess.Mess_Exp_SharePerMemberAmount = Convert.ToDouble(LbPerMemberAmount.Text);
            InsertInMess.Date = DateTime.Now.ToString();
            InsertInMess.SysID = LogInBLL.Sys_Id_Of_Admin;
            InsertInMess.Identity = 1;
            InsertInMess.Insert_Mess_Expense_Balance(InsertInMess);
        }
        void Clear_Function()
        {
            txtTotal_Amount.Text = "";
            txtDiscreption.Text = "";
            txtTotal_Members.Text = "";
            LbPerMemberAmount.Text = "0000";
            loadAllUsers();
            Check = 0;
            DINV_ID = 0;
            Total_Members = 0;
           // TotalAmountInvest = 0;
            TotalSharePerMember = 0;
        }
        #endregion

        void SaveDataFunction()
        {
            int countMembers = 0;
            foreach (DataGridViewRow row in DGVShowMembers.Rows)
            {
                //here We Checking either a Box Checked or Not.....
                DataGridViewCheckBoxCell cb = (DataGridViewCheckBoxCell)row.Cells["cbcheck"];
                if (Convert.ToBoolean(cb.Value) == true)
                    countMembers++;
            }

            try
            {
                if (Check == 0)
                {
                    if (countMembers == Convert.ToInt32(txtTotal_Members.Text))
                    {
                        insert_Daily_Investment();
                        LoadDailyINvestMent_ID();//Loading DailyInvestment_ID No
                        Check++;
                    }
                    else
                    {
                        MessageBox.Show("\tPlease check Same Number of Members as you mentioned\t", "Messege!");
                    }
                }
            }
            catch 
            { 
            }
          

            if (Convert.ToInt32(txtTotal_Members.Text) == countMembers)
            {
                foreach (DataGridViewRow row in DGVShowMembers.Rows)
                {
                    DataGridViewCheckBoxCell cb = (DataGridViewCheckBoxCell)row.Cells["cbcheck"];
                    if (Convert.ToBoolean(cb.Value) == true)
                    {
                        //Here We Check row by Row Checked Member Registration Numbers..
                        // String name = row.Cells[2].Value.ToString();
                        int ID = Convert.ToInt32(row.Cells[1].Value.ToString());
                        Insert_Mess_Balance(ID);//in this Funcation Inserting every member Share by Its Registration No OneByOne
                    }
                }
                MessageBox.Show("\t\t Mess Successfully Saved \t\t", "Info Message");
                Clear_Function();
            }
        }

        private void btnSave_Data_Click(object sender, EventArgs e)
        {
            SaveDataFunction();
        }

        private void DGVShowMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
