using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MMS.BLL;
using System.Text.RegularExpressions;

namespace MMS
{
    public partial class InterFaceMMS : Form
    {
        public InterFaceMMS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MbrRegistration mb = new MbrRegistration();
            mb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FiftenDaysMess Daily_Mess_Inevest_details = new FiftenDaysMess();
            Daily_Mess_Inevest_details.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Daily_Investment Daily_Invest = new Daily_Investment();
            Daily_Invest.Show();
        }
        LogInBLL lg = new LogInBLL();
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                log();
                if (LogInBLL.Check == "true")
                {
                    txtusername.Text = "";
                    txtpswrd.Text = "";
                    GBlogin.Hide();
                    btnfun1();
                    LogInBLL.Check = "False";
                }
                else if (LogInBLL.Check == "False")
                {
                    MessageBox.Show("\t\tAccount Has been blocked\t\t", "Try Again");
                    txtpswrd.Text = "";
                }
                else 
                {
                    MessageBox.Show("\t\tInvalid User Name And Password\t\t", "Try Again");
                }
            }
            catch
            {
                MessageBox.Show("\t\tPlease Provide UserName & Password\t\t");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (LogInBLL.Check == "False")
            {
                GBlogin.Show();
                Name = null;
                Paswrd = null;
                btnfun();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MamberBalanceUpdate mb = new MamberBalanceUpdate();
            mb.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MMS Balance_Details = new MMS();
            Balance_Details.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Mess_Expense_Summary MessExpense = new Mess_Expense_Summary();
            MessExpense.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(txtusername.Text, @"[a-zA-z]$"))
                {
                    Names = txtusername.Text;
                }
                else
                {
                    txtusername.Text = txtusername.Text.Remove(txtusername.Text.Length - 1);
                    MessageBox.Show("Use Only Alphabets");
                    txtusername.Text = "";
                }
            }
            catch 
            { }
        }

        string Names;
        string Paswrd;

        void log()
        {
            lg.User_Name = Names;
            lg.User_RegNo = Paswrd;
            lg.verification = 1;
            lg.Sys_LogIn(lg);
        }
        private void txtpswrd_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                if (Regex.IsMatch(txtpswrd.Text,@"[0-9]$"))
                {
                    Paswrd = txtpswrd.Text;
                }
                else 
                {
                    txtpswrd.Text = txtpswrd.Text.Remove(txtpswrd.Text.Length-1);
                    MessageBox.Show("Use Only Digits");
                    txtpswrd.Text = "";
                }
            }
            catch 
            { 
            
            }
        }
       
        void btnfun()
        {
            button1.Enabled = false;
            button4.Enabled = false;
            button2.Enabled = false;
          
            button7.Enabled = false;
            button12.Enabled = false;
            button11.Enabled = false;
            button10.Enabled = false;
        }
        void btnfun1()
        {
            button1.Enabled = true;
            button4.Enabled = true;
            button2.Enabled = true;
          
            button7.Enabled = true;
            button12.Enabled = true;
            button11.Enabled = true;
            button10.Enabled = true;
        }

        private void GBlogin_Enter(object sender, EventArgs e)
        {
           
        }

        private void InterFaceMMS_Load(object sender, EventArgs e)
        {
            btnfun();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Admin_Registration admin = new Admin_Registration();
            admin.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            About_MMS_Developer about = new About_MMS_Developer();
            about.Show();
        }
    }
}
