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
using MMS.SQLCon;

namespace MMS
{
    public partial class MbrRegistration : Form
    {
        public MbrRegistration()
        {
            InitializeComponent();
        }
        #region  close All Funcation and Rebild All them
        public int User_RegNo = 0;
        public string User_Name = null;
        public string User_department = null;
        public string User_Phone = null;
        public string User_Year = null;
        public string User_Date = null;
        public int System_Id = LogInBLL.Sys_Id_Of_Admin;
        public int NUser_RegNo = 0;
       
        // <summary>
        //there are two function Save Data function and Insert balance Funcation..
        // </summary>
        //void insertbalance()
        //{
        //    bl.Regno = Rgno;
        //    bl.Name = Name;
        //    date = DateTime.Now.ToString();
        //    bl.Date = date;
        //    int blnce = 0;
        //    bl.Balance = blnce;
        //    bl.InsertBlance(bl);

        //}
        //making a function of user balance account creation.
        //void UserAccount()
        //{
        //    bl.Regno = Rgno;
        //    bl.Name = Name;
        //    bl.Date =DateTime.Now.ToString();
        //    bl.Balance = 0;
        //    bl.UserBalAccount(bl);
        //}  
        //void updatebalance()
        //{
        //    bl.Regno = Rgno;
        //    bl.Name = Name;
        //    bl.UpDateBalance(bl);
        //}
        //ends these functions here and these are called in update button....

     //its new work comment Making InsertFunction Of Registration Form

        public void New_MemberID(int ID)
        {
            // New Member Registration Number loading from data base
            SQLConnection hl = new SQLConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = hl.GetCon();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "NewUser_Ur_RegNo";
            cmd.Parameters.AddWithValue("@Sys_ID", ID);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                User_RegNo = Convert.ToInt32(sdr["New_MemberID"]);
            }
            lblRegNO.Text = Convert.ToString(User_RegNo);
            User_RegNo = Convert.ToInt32(lblRegNO.Text);
        }

        public void Insert_Registration_Function()
        {
            RegistrationBLL RegistrationBLL = new RegistrationBLL();
           
            RegistrationBLL.Ur_RegNo = User_RegNo;
            RegistrationBLL.Ur_Name = User_Name;
            RegistrationBLL.Ur_Department = User_department;
            RegistrationBLL.Ur_Phone = User_Phone;
            RegistrationBLL.Ur_Year = User_Year;
            RegistrationBLL.Ur_Date = DateTime.Now.ToString();
            RegistrationBLL.System_ID = System_Id;
            RegistrationBLL.InsertRegistration(RegistrationBLL);
            MessageBox.Show("\t\tData Successfully Saved\t\t", "Message");
        
        }
        public void Search_Registration_Function()
        {
            RegistrationBLL RegistrationBLL = new RegistrationBLL();
            RegistrationBLL.User_SerachRegistration(NUser_RegNo, LogInBLL.Sys_Id_Of_Admin);
            lblRegNO.Text = RegistrationBLL.Ur_RegNoS.ToString();
            txtName.Text = RegistrationBLL.Ur_NameS;
            txtDeprt.Text = RegistrationBLL.Ur_DepartmentS;
            txtMobile.Text = RegistrationBLL.Ur_PhoneS;
            cmbYear.Text = RegistrationBLL.Ur_YearS;
            User_Date = RegistrationBLL.Ur_DateS;
        }
       
        public void Update_Registration_Function()
        {
            RegistrationBLL RegistrationBLL = new RegistrationBLL();
            RegistrationBLL.Ur_RegNo = User_RegNo;
            RegistrationBLL.Ur_Name = User_Name;
            RegistrationBLL.Ur_Department = User_department;
            RegistrationBLL.Ur_Phone = User_Phone;
            RegistrationBLL.Ur_Year = User_Year;
            RegistrationBLL.System_ID = System_Id;
            RegistrationBLL.Ur_Date = DateTime.Now.ToString();
            RegistrationBLL.UpdateRegistration(RegistrationBLL);
            MessageBox.Show("\t\tData Successfully Updated\t\t", "Message");
        }
        public void Remove_Registration_Function()
        {
            RegistrationBLL RegistrationBLL = new RegistrationBLL();
            User_RegNo = Convert.ToInt32(lblRegNO.Text);
            RegistrationBLL.DeleteRegistration(User_RegNo);
            NUser_RegNo = 0;
            MessageBox.Show("\t\tData Successfully Removed\t\t", "Message");
        }
        public void Insert_User_PrePaid_Balance_Function()
        {
            MemberBalanceBLL InsertDetails = new MemberBalanceBLL();
            InsertDetails.RegNo = User_RegNo;
            InsertDetails.Sys_ID = System_Id;
            InsertDetails.Total_PerPaid_Balance = 0;
            InsertDetails.Total_NewPrePaid_Balance = 0;
            InsertDetails.Date = DateTime.Now.ToShortDateString();
            InsertDetails.Insert_PrePaid_Balance_Funcation(InsertDetails);
        }
        void clears()
        {
            lblRegNO.Text = "000";
            txtName.Text = "";
            txtDeprt.Text = "";
            txtMobile.Text = "";
            cmbYear.Text = "--Select--";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Insert_Registration_Function();
                Insert_User_PrePaid_Balance_Function();
                clears();
                New_MemberID(LogInBLL.Sys_Id_Of_Admin);
                
            }
            catch
            {
                MessageBox.Show("\t\tPlease Provide Data\t\t", "Message");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                txtSearch.Text = null;
                Search_Registration_Function();
               
            }
            catch
            {
                MessageBox.Show("\t\tPlease Provide RegNo\t\t", "Message");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Update_Registration_Function();
                NUser_RegNo = 0;
                clears();
            }
            catch
            {
                MessageBox.Show("\t\tPlease Provide RegNo\t\t", "Message");
            }
        }  
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                Remove_Registration_Function();
                clears();
            }
            catch
            {
                MessageBox.Show("\t\tPlease Provide RegNo\t\t", "Message");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(txtSearch.Text, @"[0-9]$"))
                {
                    NUser_RegNo = Convert.ToInt32(txtSearch.Text);
                }
                else
                {
                    txtSearch.Text = txtSearch.Text.Remove(txtSearch.Text.Length - 1);
                    MessageBox.Show("\t\tUse Only Digits\t\t", "Message");
                    txtSearch.Text = "";
                }
            }
            catch
            {

            }
        }
       
        private void MbrRegistration_Load(object sender, EventArgs e)
        {
            cmbYear.Text = "---Select---";
            New_MemberID(LogInBLL.Sys_Id_Of_Admin);

        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(txtName.Text, @"[a-zA-Z]$"))
                {
                    User_Name = txtName.Text;
                }
                else
                {
                    txtName.Text = txtName.Text.Remove(txtName.Text.Length - 1);
                    MessageBox.Show("\t\tUse Only Alphabets\t\t", "Message");
                    txtName.Text = "";
                    if (txtName.Text == null)
                    {
                        lblRegNO.Text = "000";
                    }
                }
            }
            catch
            { }
        }

        private void txtDeprt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(txtDeprt.Text, @"[a-zA-Z]$"))
                {
                    User_department = txtDeprt.Text;
                }
                else
                {
                    txtDeprt.Text = txtDeprt.Text.Remove(txtDeprt.Text.Length - 1);
                    MessageBox.Show("\t\tUse Only Alphabets\t\t", "Message");
                    txtDeprt.Text = "";
                }
            }
            catch
            { }
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(txtMobile.Text, @"[0-9]$"))
                {
                    User_Phone = txtMobile.Text;
                }
                else
                {
                    txtMobile.Text = txtMobile.Text.Remove(txtMobile.Text.Length - 1);
                    MessageBox.Show("\t\tUse Only Digits\t\t", "Message");
                    txtMobile.Text = "";
                }
            }
            catch
            { }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                User_Year = cmbYear.Text;
            }
            catch
            { }
        }
       

        #endregion

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                clears();
                NUser_RegNo = 0;
                New_MemberID(LogInBLL.Sys_Id_Of_Admin);
            }
            catch
            { }
        }



    }
}
