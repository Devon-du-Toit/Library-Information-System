namespace CMPG223_Group4_Project
{
    partial class StaffForm
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
            this.Bnt_Close_Staff = new System.Windows.Forms.Button();
            this.Bnt_Update_Staff = new System.Windows.Forms.Button();
            this.Bnt_New_Staff = new System.Windows.Forms.Button();
            this.Txt_UserName_Staff = new System.Windows.Forms.TextBox();
            this.Txt_ContactNumber_Staff = new System.Windows.Forms.TextBox();
            this.Txt_Email_Staff = new System.Windows.Forms.TextBox();
            this.Txt_LastName_Staff = new System.Windows.Forms.TextBox();
            this.Txt_FirstName_Staff = new System.Windows.Forms.TextBox();
            this.LB_Password_Staff = new System.Windows.Forms.Label();
            this.LB_UserName_Staff = new System.Windows.Forms.Label();
            this.LB_ContactNumber_Staff = new System.Windows.Forms.Label();
            this.LB_Email_Staff = new System.Windows.Forms.Label();
            this.LB_LastName_Staff = new System.Windows.Forms.Label();
            this.LB_FirstName_Staff = new System.Windows.Forms.Label();
            this.DataGrid_Staff = new System.Windows.Forms.DataGridView();
            this.Bnt_Search_Staff = new System.Windows.Forms.Button();
            this.TxtBx_Search_Staff = new System.Windows.Forms.TextBox();
            this.LB_Search_Staff = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.RB_Staff_Staff = new System.Windows.Forms.RadioButton();
            this.RB_Owner_Staff = new System.Windows.Forms.RadioButton();
            this.LB_Role_Staff = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Staff)).BeginInit();
            this.SuspendLayout();
            // 
            // Bnt_Close_Staff
            // 
            this.Bnt_Close_Staff.BackColor = System.Drawing.Color.Red;
            this.Bnt_Close_Staff.Location = new System.Drawing.Point(756, 377);
            this.Bnt_Close_Staff.Name = "Bnt_Close_Staff";
            this.Bnt_Close_Staff.Size = new System.Drawing.Size(124, 23);
            this.Bnt_Close_Staff.TabIndex = 47;
            this.Bnt_Close_Staff.Text = "Close";
            this.Bnt_Close_Staff.UseVisualStyleBackColor = false;
            this.Bnt_Close_Staff.Click += new System.EventHandler(this.Bnt_Close_Staff_Click);
            // 
            // Bnt_Update_Staff
            // 
            this.Bnt_Update_Staff.BackColor = System.Drawing.Color.LightBlue;
            this.Bnt_Update_Staff.Location = new System.Drawing.Point(756, 266);
            this.Bnt_Update_Staff.Name = "Bnt_Update_Staff";
            this.Bnt_Update_Staff.Size = new System.Drawing.Size(124, 23);
            this.Bnt_Update_Staff.TabIndex = 45;
            this.Bnt_Update_Staff.Text = "Update";
            this.Bnt_Update_Staff.UseVisualStyleBackColor = false;
            this.Bnt_Update_Staff.Click += new System.EventHandler(this.Bnt_Update_Staff_Click);
            // 
            // Bnt_New_Staff
            // 
            this.Bnt_New_Staff.BackColor = System.Drawing.Color.LightGreen;
            this.Bnt_New_Staff.Location = new System.Drawing.Point(756, 228);
            this.Bnt_New_Staff.Name = "Bnt_New_Staff";
            this.Bnt_New_Staff.Size = new System.Drawing.Size(124, 23);
            this.Bnt_New_Staff.TabIndex = 44;
            this.Bnt_New_Staff.Text = "New";
            this.Bnt_New_Staff.UseVisualStyleBackColor = false;
            this.Bnt_New_Staff.Click += new System.EventHandler(this.Bnt_New_Staff_Click);
            // 
            // Txt_UserName_Staff
            // 
            this.Txt_UserName_Staff.Location = new System.Drawing.Point(469, 270);
            this.Txt_UserName_Staff.Name = "Txt_UserName_Staff";
            this.Txt_UserName_Staff.Size = new System.Drawing.Size(234, 20);
            this.Txt_UserName_Staff.TabIndex = 43;
            // 
            // Txt_ContactNumber_Staff
            // 
            this.Txt_ContactNumber_Staff.Location = new System.Drawing.Point(469, 228);
            this.Txt_ContactNumber_Staff.Name = "Txt_ContactNumber_Staff";
            this.Txt_ContactNumber_Staff.Size = new System.Drawing.Size(234, 20);
            this.Txt_ContactNumber_Staff.TabIndex = 42;
            // 
            // Txt_Email_Staff
            // 
            this.Txt_Email_Staff.Location = new System.Drawing.Point(105, 318);
            this.Txt_Email_Staff.Name = "Txt_Email_Staff";
            this.Txt_Email_Staff.Size = new System.Drawing.Size(234, 20);
            this.Txt_Email_Staff.TabIndex = 41;
            // 
            // Txt_LastName_Staff
            // 
            this.Txt_LastName_Staff.Location = new System.Drawing.Point(105, 270);
            this.Txt_LastName_Staff.Name = "Txt_LastName_Staff";
            this.Txt_LastName_Staff.Size = new System.Drawing.Size(234, 20);
            this.Txt_LastName_Staff.TabIndex = 40;
            // 
            // Txt_FirstName_Staff
            // 
            this.Txt_FirstName_Staff.Location = new System.Drawing.Point(105, 227);
            this.Txt_FirstName_Staff.Name = "Txt_FirstName_Staff";
            this.Txt_FirstName_Staff.Size = new System.Drawing.Size(234, 20);
            this.Txt_FirstName_Staff.TabIndex = 39;
            // 
            // LB_Password_Staff
            // 
            this.LB_Password_Staff.AutoSize = true;
            this.LB_Password_Staff.Location = new System.Drawing.Point(360, 318);
            this.LB_Password_Staff.Name = "LB_Password_Staff";
            this.LB_Password_Staff.Size = new System.Drawing.Size(56, 13);
            this.LB_Password_Staff.TabIndex = 38;
            this.LB_Password_Staff.Text = "Password:";
            // 
            // LB_UserName_Staff
            // 
            this.LB_UserName_Staff.AutoSize = true;
            this.LB_UserName_Staff.Location = new System.Drawing.Point(360, 270);
            this.LB_UserName_Staff.Name = "LB_UserName_Staff";
            this.LB_UserName_Staff.Size = new System.Drawing.Size(63, 13);
            this.LB_UserName_Staff.TabIndex = 37;
            this.LB_UserName_Staff.Text = "User Name:";
            // 
            // LB_ContactNumber_Staff
            // 
            this.LB_ContactNumber_Staff.AutoSize = true;
            this.LB_ContactNumber_Staff.Location = new System.Drawing.Point(360, 228);
            this.LB_ContactNumber_Staff.Name = "LB_ContactNumber_Staff";
            this.LB_ContactNumber_Staff.Size = new System.Drawing.Size(87, 13);
            this.LB_ContactNumber_Staff.TabIndex = 36;
            this.LB_ContactNumber_Staff.Text = "Contact Number:";
            // 
            // LB_Email_Staff
            // 
            this.LB_Email_Staff.AutoSize = true;
            this.LB_Email_Staff.Location = new System.Drawing.Point(10, 318);
            this.LB_Email_Staff.Name = "LB_Email_Staff";
            this.LB_Email_Staff.Size = new System.Drawing.Size(35, 13);
            this.LB_Email_Staff.TabIndex = 35;
            this.LB_Email_Staff.Text = "Email:";
            // 
            // LB_LastName_Staff
            // 
            this.LB_LastName_Staff.AutoSize = true;
            this.LB_LastName_Staff.Location = new System.Drawing.Point(10, 270);
            this.LB_LastName_Staff.Name = "LB_LastName_Staff";
            this.LB_LastName_Staff.Size = new System.Drawing.Size(61, 13);
            this.LB_LastName_Staff.TabIndex = 34;
            this.LB_LastName_Staff.Text = "Last Name:";
            // 
            // LB_FirstName_Staff
            // 
            this.LB_FirstName_Staff.AutoSize = true;
            this.LB_FirstName_Staff.Location = new System.Drawing.Point(10, 228);
            this.LB_FirstName_Staff.Name = "LB_FirstName_Staff";
            this.LB_FirstName_Staff.Size = new System.Drawing.Size(60, 13);
            this.LB_FirstName_Staff.TabIndex = 33;
            this.LB_FirstName_Staff.Text = "First Name:";
            // 
            // DataGrid_Staff
            // 
            this.DataGrid_Staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Staff.Location = new System.Drawing.Point(10, 41);
            this.DataGrid_Staff.Name = "DataGrid_Staff";
            this.DataGrid_Staff.RowTemplate.Height = 24;
            this.DataGrid_Staff.Size = new System.Drawing.Size(870, 180);
            this.DataGrid_Staff.TabIndex = 32;
            this.DataGrid_Staff.SelectionChanged += new System.EventHandler(this.DataGrid_Staff_SelectionChanged);
            // 
            // Bnt_Search_Staff
            // 
            this.Bnt_Search_Staff.BackgroundImage = global::CMPG223_Group4_Project.Properties.Resources.Magnifying_glass;
            this.Bnt_Search_Staff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bnt_Search_Staff.Location = new System.Drawing.Point(754, 10);
            this.Bnt_Search_Staff.Name = "Bnt_Search_Staff";
            this.Bnt_Search_Staff.Size = new System.Drawing.Size(124, 23);
            this.Bnt_Search_Staff.TabIndex = 30;
            this.Bnt_Search_Staff.UseVisualStyleBackColor = true;
            this.Bnt_Search_Staff.Click += new System.EventHandler(this.Bnt_Search_Staff_Click);
            // 
            // TxtBx_Search_Staff
            // 
            this.TxtBx_Search_Staff.Location = new System.Drawing.Point(105, 13);
            this.TxtBx_Search_Staff.Name = "TxtBx_Search_Staff";
            this.TxtBx_Search_Staff.Size = new System.Drawing.Size(234, 20);
            this.TxtBx_Search_Staff.TabIndex = 29;
            // 
            // LB_Search_Staff
            // 
            this.LB_Search_Staff.AutoSize = true;
            this.LB_Search_Staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Search_Staff.Location = new System.Drawing.Point(16, 10);
            this.LB_Search_Staff.Name = "LB_Search_Staff";
            this.LB_Search_Staff.Size = new System.Drawing.Size(82, 24);
            this.LB_Search_Staff.TabIndex = 28;
            this.LB_Search_Staff.Text = "Search:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(469, 318);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(234, 20);
            this.txtPass.TabIndex = 48;
            // 
            // RB_Staff_Staff
            // 
            this.RB_Staff_Staff.AutoSize = true;
            this.RB_Staff_Staff.Location = new System.Drawing.Point(232, 377);
            this.RB_Staff_Staff.Name = "RB_Staff_Staff";
            this.RB_Staff_Staff.Size = new System.Drawing.Size(50, 17);
            this.RB_Staff_Staff.TabIndex = 51;
            this.RB_Staff_Staff.TabStop = true;
            this.RB_Staff_Staff.Text = "Staff:";
            this.RB_Staff_Staff.UseVisualStyleBackColor = true;
            // 
            // RB_Owner_Staff
            // 
            this.RB_Owner_Staff.AutoSize = true;
            this.RB_Owner_Staff.Location = new System.Drawing.Point(105, 377);
            this.RB_Owner_Staff.Name = "RB_Owner_Staff";
            this.RB_Owner_Staff.Size = new System.Drawing.Size(56, 17);
            this.RB_Owner_Staff.TabIndex = 50;
            this.RB_Owner_Staff.TabStop = true;
            this.RB_Owner_Staff.Text = "Owner";
            this.RB_Owner_Staff.UseVisualStyleBackColor = true;
            // 
            // LB_Role_Staff
            // 
            this.LB_Role_Staff.AutoSize = true;
            this.LB_Role_Staff.Location = new System.Drawing.Point(10, 377);
            this.LB_Role_Staff.Name = "LB_Role_Staff";
            this.LB_Role_Staff.Size = new System.Drawing.Size(32, 13);
            this.LB_Role_Staff.TabIndex = 49;
            this.LB_Role_Staff.Text = "Role:";
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(890, 410);
            this.Controls.Add(this.RB_Staff_Staff);
            this.Controls.Add(this.RB_Owner_Staff);
            this.Controls.Add(this.LB_Role_Staff);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.Bnt_Close_Staff);
            this.Controls.Add(this.Bnt_Update_Staff);
            this.Controls.Add(this.Bnt_New_Staff);
            this.Controls.Add(this.Txt_UserName_Staff);
            this.Controls.Add(this.Txt_ContactNumber_Staff);
            this.Controls.Add(this.Txt_Email_Staff);
            this.Controls.Add(this.Txt_LastName_Staff);
            this.Controls.Add(this.Txt_FirstName_Staff);
            this.Controls.Add(this.LB_Password_Staff);
            this.Controls.Add(this.LB_UserName_Staff);
            this.Controls.Add(this.LB_ContactNumber_Staff);
            this.Controls.Add(this.LB_Email_Staff);
            this.Controls.Add(this.LB_LastName_Staff);
            this.Controls.Add(this.LB_FirstName_Staff);
            this.Controls.Add(this.DataGrid_Staff);
            this.Controls.Add(this.Bnt_Search_Staff);
            this.Controls.Add(this.TxtBx_Search_Staff);
            this.Controls.Add(this.LB_Search_Staff);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Staff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Bnt_Close_Staff;
        private System.Windows.Forms.Button Bnt_Update_Staff;
        private System.Windows.Forms.Button Bnt_New_Staff;
        private System.Windows.Forms.TextBox Txt_UserName_Staff;
        private System.Windows.Forms.TextBox Txt_ContactNumber_Staff;
        private System.Windows.Forms.TextBox Txt_Email_Staff;
        private System.Windows.Forms.TextBox Txt_LastName_Staff;
        private System.Windows.Forms.TextBox Txt_FirstName_Staff;
        private System.Windows.Forms.Label LB_Password_Staff;
        private System.Windows.Forms.Label LB_UserName_Staff;
        private System.Windows.Forms.Label LB_ContactNumber_Staff;
        private System.Windows.Forms.Label LB_Email_Staff;
        private System.Windows.Forms.Label LB_LastName_Staff;
        private System.Windows.Forms.Label LB_FirstName_Staff;
        private System.Windows.Forms.DataGridView DataGrid_Staff;
        private System.Windows.Forms.Button Bnt_Search_Staff;
        private System.Windows.Forms.TextBox TxtBx_Search_Staff;
        private System.Windows.Forms.Label LB_Search_Staff;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.RadioButton RB_Staff_Staff;
        private System.Windows.Forms.RadioButton RB_Owner_Staff;
        private System.Windows.Forms.Label LB_Role_Staff;
    }
}