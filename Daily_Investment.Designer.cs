namespace MMS
{
    partial class Daily_Investment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Daily_Investment));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiscreption = new System.Windows.Forms.TextBox();
            this.txtTotal_Amount = new System.Windows.Forms.TextBox();
            this.txtTotal_Members = new System.Windows.Forms.TextBox();
            this.LbRegNo = new System.Windows.Forms.Label();
            this.LbPerMemberAmount = new System.Windows.Forms.Label();
            this.btnSave_Data = new System.Windows.Forms.Button();
            this.gbShowMembers = new System.Windows.Forms.GroupBox();
            this.DGVShowMembers = new System.Windows.Forms.DataGridView();
            this.Ur_RegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ur_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbcheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbShowMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowMembers)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN_ID                :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Amount              :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Members           :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Per Member Amount  :";
            // 
            // txtDiscreption
            // 
            this.txtDiscreption.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtDiscreption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscreption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiscreption.Location = new System.Drawing.Point(3, 21);
            this.txtDiscreption.Multiline = true;
            this.txtDiscreption.Name = "txtDiscreption";
            this.txtDiscreption.Size = new System.Drawing.Size(487, 95);
            this.txtDiscreption.TabIndex = 3;
            // 
            // txtTotal_Amount
            // 
            this.txtTotal_Amount.Location = new System.Drawing.Point(342, 88);
            this.txtTotal_Amount.Name = "txtTotal_Amount";
            this.txtTotal_Amount.Size = new System.Drawing.Size(197, 20);
            this.txtTotal_Amount.TabIndex = 6;
            this.txtTotal_Amount.TextChanged += new System.EventHandler(this.txtTotal_Amount_TextChanged);
            // 
            // txtTotal_Members
            // 
            this.txtTotal_Members.Location = new System.Drawing.Point(342, 121);
            this.txtTotal_Members.Name = "txtTotal_Members";
            this.txtTotal_Members.Size = new System.Drawing.Size(197, 20);
            this.txtTotal_Members.TabIndex = 7;
            this.txtTotal_Members.TextChanged += new System.EventHandler(this.txtTotal_Members_TextChanged);
            // 
            // LbRegNo
            // 
            this.LbRegNo.AutoSize = true;
            this.LbRegNo.BackColor = System.Drawing.Color.Transparent;
            this.LbRegNo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.LbRegNo.Location = new System.Drawing.Point(417, 49);
            this.LbRegNo.Name = "LbRegNo";
            this.LbRegNo.Size = new System.Drawing.Size(43, 24);
            this.LbRegNo.TabIndex = 8;
            this.LbRegNo.Text = "000";
            // 
            // LbPerMemberAmount
            // 
            this.LbPerMemberAmount.AutoSize = true;
            this.LbPerMemberAmount.BackColor = System.Drawing.Color.Transparent;
            this.LbPerMemberAmount.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPerMemberAmount.Location = new System.Drawing.Point(417, 147);
            this.LbPerMemberAmount.Name = "LbPerMemberAmount";
            this.LbPerMemberAmount.Size = new System.Drawing.Size(43, 24);
            this.LbPerMemberAmount.TabIndex = 9;
            this.LbPerMemberAmount.Text = "000";
            // 
            // btnSave_Data
            // 
            this.btnSave_Data.BackColor = System.Drawing.Color.Transparent;
            this.btnSave_Data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave_Data.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnSave_Data.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnSave_Data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave_Data.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSave_Data.Location = new System.Drawing.Point(146, 455);
            this.btnSave_Data.Name = "btnSave_Data";
            this.btnSave_Data.Size = new System.Drawing.Size(240, 39);
            this.btnSave_Data.TabIndex = 5;
            this.btnSave_Data.Text = "Save  ";
            this.btnSave_Data.UseVisualStyleBackColor = false;
            this.btnSave_Data.Click += new System.EventHandler(this.btnSave_Data_Click);
            // 
            // gbShowMembers
            // 
            this.gbShowMembers.BackColor = System.Drawing.Color.Transparent;
            this.gbShowMembers.Controls.Add(this.DGVShowMembers);
            this.gbShowMembers.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbShowMembers.Location = new System.Drawing.Point(46, 303);
            this.gbShowMembers.Name = "gbShowMembers";
            this.gbShowMembers.Size = new System.Drawing.Size(493, 142);
            this.gbShowMembers.TabIndex = 12;
            this.gbShowMembers.TabStop = false;
            this.gbShowMembers.Text = "Selected_Members";
            // 
            // DGVShowMembers
            // 
            this.DGVShowMembers.AllowUserToAddRows = false;
            this.DGVShowMembers.AllowUserToResizeColumns = false;
            this.DGVShowMembers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGVShowMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVShowMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVShowMembers.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DGVShowMembers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVShowMembers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVShowMembers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGVShowMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVShowMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ur_RegNo,
            this.Ur_Name,
            this.cbcheck});
            this.DGVShowMembers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVShowMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVShowMembers.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGVShowMembers.Location = new System.Drawing.Point(3, 21);
            this.DGVShowMembers.Name = "DGVShowMembers";
            this.DGVShowMembers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGVShowMembers.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVShowMembers.Size = new System.Drawing.Size(487, 118);
            this.DGVShowMembers.StandardTab = true;
            this.DGVShowMembers.TabIndex = 4;
            this.DGVShowMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVShowMembers_CellContentClick);
            // 
            // Ur_RegNo
            // 
            this.Ur_RegNo.DataPropertyName = "Ur_RegNo";
            this.Ur_RegNo.HeaderText = "User_RegNo";
            this.Ur_RegNo.Name = "Ur_RegNo";
            // 
            // Ur_Name
            // 
            this.Ur_Name.DataPropertyName = "Ur_Name";
            this.Ur_Name.HeaderText = "Name";
            this.Ur_Name.Name = "Ur_Name";
            // 
            // cbcheck
            // 
            this.cbcheck.HeaderText = "Select";
            this.cbcheck.Name = "cbcheck";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtDiscreption);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(46, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 119);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Discription";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "^^^___Daily__Investment___^^^\r\n";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::MMS.Properties.Resources.Untitled;
            this.pictureBox2.Location = new System.Drawing.Point(546, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Daily_Investment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::MMS.Properties.Resources.window_vista_wallpaper_11738394;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 506);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbShowMembers);
            this.Controls.Add(this.btnSave_Data);
            this.Controls.Add(this.LbPerMemberAmount);
            this.Controls.Add(this.LbRegNo);
            this.Controls.Add(this.txtTotal_Members);
            this.Controls.Add(this.txtTotal_Amount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Daily_Investment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Daily_Investment_Load);
            this.gbShowMembers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowMembers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiscreption;
        private System.Windows.Forms.TextBox txtTotal_Amount;
        private System.Windows.Forms.TextBox txtTotal_Members;
        private System.Windows.Forms.Label LbRegNo;
        private System.Windows.Forms.Label LbPerMemberAmount;
        private System.Windows.Forms.Button btnSave_Data;
        private System.Windows.Forms.GroupBox gbShowMembers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGVShowMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ur_RegNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ur_Name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cbcheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}