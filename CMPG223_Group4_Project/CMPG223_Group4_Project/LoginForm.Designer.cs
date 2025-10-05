namespace CMPG223_Group4_Project
{
    partial class Login_Form
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
            this.Login_LB_Username = new System.Windows.Forms.Label();
            this.Login_LB_Password = new System.Windows.Forms.Label();
            this.Login_BNT = new System.Windows.Forms.Button();
            this.TxtBx_Username = new System.Windows.Forms.TextBox();
            this.TxtBx_Password = new System.Windows.Forms.TextBox();
            this.Login_RB_Admin = new System.Windows.Forms.RadioButton();
            this.Login_RB_Staff = new System.Windows.Forms.RadioButton();
            this.Login_PicBx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Login_PicBx)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_LB_Username
            // 
            this.Login_LB_Username.AutoSize = true;
            this.Login_LB_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_LB_Username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Login_LB_Username.Location = new System.Drawing.Point(126, 377);
            this.Login_LB_Username.Name = "Login_LB_Username";
            this.Login_LB_Username.Size = new System.Drawing.Size(102, 24);
            this.Login_LB_Username.TabIndex = 0;
            this.Login_LB_Username.Text = "Username:";
            // 
            // Login_LB_Password
            // 
            this.Login_LB_Password.AutoSize = true;
            this.Login_LB_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_LB_Password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Login_LB_Password.Location = new System.Drawing.Point(126, 418);
            this.Login_LB_Password.Name = "Login_LB_Password";
            this.Login_LB_Password.Size = new System.Drawing.Size(97, 24);
            this.Login_LB_Password.TabIndex = 1;
            this.Login_LB_Password.Text = "Password:";
            // 
            // Login_BNT
            // 
            this.Login_BNT.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Login_BNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_BNT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Login_BNT.Location = new System.Drawing.Point(466, 449);
            this.Login_BNT.Name = "Login_BNT";
            this.Login_BNT.Size = new System.Drawing.Size(132, 37);
            this.Login_BNT.TabIndex = 4;
            this.Login_BNT.Text = "Login";
            this.Login_BNT.UseVisualStyleBackColor = false;
            this.Login_BNT.Click += new System.EventHandler(this.Login_BNT_Click);
            // 
            // TxtBx_Username
            // 
            this.TxtBx_Username.Location = new System.Drawing.Point(234, 380);
            this.TxtBx_Username.Name = "TxtBx_Username";
            this.TxtBx_Username.Size = new System.Drawing.Size(200, 20);
            this.TxtBx_Username.TabIndex = 5;
            // 
            // TxtBx_Password
            // 
            this.TxtBx_Password.Location = new System.Drawing.Point(234, 423);
            this.TxtBx_Password.Name = "TxtBx_Password";
            this.TxtBx_Password.Size = new System.Drawing.Size(200, 20);
            this.TxtBx_Password.TabIndex = 6;
            // 
            // Login_RB_Admin
            // 
            this.Login_RB_Admin.AutoSize = true;
            this.Login_RB_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_RB_Admin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Login_RB_Admin.Location = new System.Drawing.Point(234, 469);
            this.Login_RB_Admin.Name = "Login_RB_Admin";
            this.Login_RB_Admin.Size = new System.Drawing.Size(88, 28);
            this.Login_RB_Admin.TabIndex = 7;
            this.Login_RB_Admin.TabStop = true;
            this.Login_RB_Admin.Text = "Admin";
            this.Login_RB_Admin.UseVisualStyleBackColor = true;
            // 
            // Login_RB_Staff
            // 
            this.Login_RB_Staff.AutoSize = true;
            this.Login_RB_Staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_RB_Staff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Login_RB_Staff.Location = new System.Drawing.Point(367, 469);
            this.Login_RB_Staff.Name = "Login_RB_Staff";
            this.Login_RB_Staff.Size = new System.Drawing.Size(67, 28);
            this.Login_RB_Staff.TabIndex = 8;
            this.Login_RB_Staff.TabStop = true;
            this.Login_RB_Staff.Text = "Staff";
            this.Login_RB_Staff.UseVisualStyleBackColor = true;
            // 
            // Login_PicBx
            // 
            this.Login_PicBx.BackgroundImage = global::CMPG223_Group4_Project.Properties.Resources.Logo;
            this.Login_PicBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login_PicBx.Location = new System.Drawing.Point(12, 12);
            this.Login_PicBx.Name = "Login_PicBx";
            this.Login_PicBx.Size = new System.Drawing.Size(586, 362);
            this.Login_PicBx.TabIndex = 2;
            this.Login_PicBx.TabStop = false;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(610, 517);
            this.Controls.Add(this.Login_RB_Staff);
            this.Controls.Add(this.Login_RB_Admin);
            this.Controls.Add(this.TxtBx_Password);
            this.Controls.Add(this.TxtBx_Username);
            this.Controls.Add(this.Login_BNT);
            this.Controls.Add(this.Login_PicBx);
            this.Controls.Add(this.Login_LB_Password);
            this.Controls.Add(this.Login_LB_Username);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.Login_PicBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login_LB_Username;
        private System.Windows.Forms.Label Login_LB_Password;
        private System.Windows.Forms.PictureBox Login_PicBx;
        private System.Windows.Forms.Button Login_BNT;
        private System.Windows.Forms.TextBox TxtBx_Username;
        private System.Windows.Forms.TextBox TxtBx_Password;
        private System.Windows.Forms.RadioButton Login_RB_Admin;
        private System.Windows.Forms.RadioButton Login_RB_Staff;
    }
}

