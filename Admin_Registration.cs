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
using MMS.BLL;

namespace MMS
{
    public partial class Admin_Registration : Form
    {
        public Admin_Registration()
        {
            InitializeComponent();
        }

        private void Admin_Registration_Load(object sender, EventArgs e)
        {
            gbCreateAccount.Hide();
            gbRemoveAccount.Hide();
        }
        string Admin_Name;
        string EnterPasword;
        string ReEnterPas;
        int verification;
        string Keys;
        string Phone;
        
        
        void clear()
        {
            txtEnterName.Text = "";
            txtEnterPaswrd.Text = "";
            txtName.Text = "";
            txtpswrd.Text = "";
            txtreenterpasrd.Text = "";
            txtReEnterPasword.Text = "";
            txtPhone.Text = "";
            txtEnterPaswrd.BackColor = Color.White;
            txtpswrd.BackColor = Color.White;
            txtreenterpasrd.BackColor = Color.White;
            txtReEnterPasword.BackColor = Color.White;
            Admin_Name = "";
            EnterPasword = "";
            ReEnterPas = "";
            verification = 0;
            Keys = "";
            Phone = "";

        }
        public void Admin_Registration_Account()
        {
            LogInBLL Admin_Reg = new LogInBLL();
            Admin_Reg.Admin_Name = Admin_Name;
            Admin_Reg.EnterPasword = EnterPasword;
            verification = 1;
            Admin_Reg.verification = verification;
            Keys = "YES";
            Admin_Reg.Keys = Keys;
            Admin_Reg.Phone = Phone;
            Admin_Reg.Admin_Registration(Admin_Reg);
            MessageBox.Show("\t\tRegistration is Successed\t\t", "Welcome Dear");
        }

        public void Remove_Admin_Account()
        {
            LogInBLL Admin_Remove = new LogInBLL();
            Admin_Remove.Admin_Name = Admin_Name;
            Admin_Remove.EnterPasword = EnterPasword;
            Admin_Remove.verification = 0;
         
            Admin_Remove.Admin_Remove_Account(Admin_Remove);
            MessageBox.Show("\t\tAccount Removed\t\t", "Miss you Dear");
        
        }

         private void txtEnterName_TextChanged(object sender, EventArgs e)
         {
             
             try
             {
                 if (Regex.IsMatch(txtEnterName.Text, @"[a-zA-z]$"))
                 {
                     Admin_Name = txtEnterName.Text;
                 }
                 else
                 {
                     txtEnterName.Text = txtEnterName.Text.Remove(txtEnterName.Text.Length - 1);
                     MessageBox.Show("Use Only Alphabets");
                     txtEnterName.Text = "";
                 }
             }
             catch
             { }
         }

         private void txtReEnterPasword_TextChanged(object sender, EventArgs e)
         {
            
             try
             {
                 if (Regex.IsMatch(txtReEnterPasword.Text, @"[a-zA-z,0-9]$"))
                 {
                     ReEnterPas = txtReEnterPasword.Text;
                     if (EnterPasword == ReEnterPas)
                     {
                         txtEnterPaswrd.BackColor = Color.Green;
                         txtReEnterPasword.BackColor = Color.Green;
                     }
                     else
                     {
                         txtReEnterPasword.BackColor = Color.Red;
                     }
                 }
                 else
                 {
                     txtReEnterPasword.Text = txtReEnterPasword.Text.Remove(txtReEnterPasword.Text.Length - 1);
                     MessageBox.Show("Use Only Alphabets & Digits");
                     txtReEnterPasword.Text = "";
                 }
             }
             catch
             { }
         }

         private void txtPhone_TextChanged(object sender, EventArgs e)
         {
            
             try
             {
                 if (Regex.IsMatch(txtPhone.Text, @"[0-9]$"))
                 {
                     Phone = txtPhone.Text;
                 }
                 else
                 {
                     txtPhone.Text = txtPhone.Text.Remove(txtPhone.Text.Length - 1);
                     MessageBox.Show("Use Only Digits");
                     txtPhone.Text = "";
                 }
             }
             catch
             { }
         }

         private void txtName_TextChanged(object sender, EventArgs e)
         {

             try
             {
                 if (Regex.IsMatch(txtName.Text, @"[a-zA-z]$"))
                 {
                     Admin_Name = txtName.Text;
                 }
                 else
                 {
                     txtName.Text = txtName.Text.Remove(txtName.Text.Length - 1);
                     MessageBox.Show("Use Only Alphabets");
                     txtName.Text = "";
                 }
             }
             catch
             { }
         }    

         private void txtpswrd_TextChanged(object sender, EventArgs e)
         {
             try
             {
                 if (Regex.IsMatch(txtpswrd.Text, @"[a-zA-z,0-9]$"))
                 {
                     EnterPasword = txtpswrd.Text;
                 }
                 else
                 {
                     txtpswrd.Text = txtpswrd.Text.Remove(txtpswrd.Text.Length - 1);
                     MessageBox.Show("Use Only Alphabets & Digits");
                     txtpswrd.Text = "";
                 }
             }
             catch
             { }
         }

         private void txtreenterpasrd_TextChanged(object sender, EventArgs e)
         {
            
             try
             {
                 if (Regex.IsMatch(txtreenterpasrd.Text, @"[a-zA-z,0-9]$"))
                 {
                     ReEnterPas = txtreenterpasrd.Text;
                     if (EnterPasword == ReEnterPas)
                     {
                         txtEnterPaswrd.BackColor = Color.Green;
                         txtreenterpasrd.BackColor = Color.Green;
                     }
                 }
                 else
                 {
                     txtreenterpasrd.Text = txtreenterpasrd.Text.Remove(txtreenterpasrd.Text.Length - 1);
                     MessageBox.Show("Use Only Alphabets & Digits");
                     txtreenterpasrd.Text = "";
                 }
             }
             catch
             { }
         }

         private void btnCreate_Click(object sender, EventArgs e)
         {
             Admin_Registration_Account();
             clear();
         }

         private void btnRemove_Click(object sender, EventArgs e)
         {
             Remove_Admin_Account();
             clear();
         }

         private void txtEnterPaswrd_TextChanged(object sender, EventArgs e)
         {
              try
             {
                 if (Regex.IsMatch(txtEnterPaswrd.Text, @"[a-zA-z,0-9]$"))
                 {
                     EnterPasword = txtEnterPaswrd.Text;
                 }
                 else
                 {
                     txtEnterPaswrd.Text = txtEnterPaswrd.Text.Remove(txtEnterPaswrd.Text.Length - 1);
                     MessageBox.Show("Use Only Alphabets & Digits");
                     txtEnterPaswrd.Text = "";
                 }
             }
             catch
             { }
         }

         private void btnRemoveAccount_Click(object sender, EventArgs e)
         {
             gbRemoveAccount.Show();
             gbCreateAccount.Hide();
         }

         private void btnCreateAccount_Click(object sender, EventArgs e)
         {
             gbCreateAccount.Show();
             gbRemoveAccount.Hide();
         }

         private void gbRemoveAccount_Enter(object sender, EventArgs e)
         {

         }

         private void pictureBox2_Click(object sender, EventArgs e)
         {
             Close();
         }

         private void gbCreateAccount_Enter(object sender, EventArgs e)
         {

         }
       
    }
}
