namespace CMPG223_Group4_Project
{
    partial class EndowmentsForm
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
            this.TabControl_Endowments = new System.Windows.Forms.TabControl();
            this.Tab_Donations = new System.Windows.Forms.TabPage();
            this.GB_Maintenance_Donations = new System.Windows.Forms.GroupBox();
            this.lblDonationID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Bnt_Update_Donations = new System.Windows.Forms.Button();
            this.txtUpdateType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUpdateAmount = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GB_DonerDonations_Donations = new System.Windows.Forms.GroupBox();
            this.Bnt_Save_Donations = new System.Windows.Forms.Button();
            this.Txt_Type_Donations = new System.Windows.Forms.TextBox();
            this.LB_Type_Donations = new System.Windows.Forms.Label();
            this.Txt_Amount_Donations = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Donations = new System.Windows.Forms.DateTimePicker();
            this.LB_Date_Donations = new System.Windows.Forms.Label();
            this.LB_Amount_Donations = new System.Windows.Forms.Label();
            this.LB_DBEmail_Donations = new System.Windows.Forms.Label();
            this.LB_Email_Donations = new System.Windows.Forms.Label();
            this.LB_DBContactNumber_Donations = new System.Windows.Forms.Label();
            this.LB_ContactNumber_Donations = new System.Windows.Forms.Label();
            this.CB_DonerName_Donations = new System.Windows.Forms.ComboBox();
            this.LB_DonerName_Donations = new System.Windows.Forms.Label();
            this.GB_PastDonations_Donations = new System.Windows.Forms.GroupBox();
            this.Bnt_Close_Donations = new System.Windows.Forms.Button();
            this.DataGrid_Donations = new System.Windows.Forms.DataGridView();
            this.TabControl_Doners = new System.Windows.Forms.TabPage();
            this.lblDonorID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PciBx_Doners = new System.Windows.Forms.PictureBox();
            this.Bnt_Close_Doner = new System.Windows.Forms.Button();
            this.Bnt_Update_Doner = new System.Windows.Forms.Button();
            this.Bnt_New_Doner = new System.Windows.Forms.Button();
            this.Txt_Email_Doner = new System.Windows.Forms.TextBox();
            this.Txt_ContactNumber_Doner = new System.Windows.Forms.TextBox();
            this.Txt_FirstName_Doner = new System.Windows.Forms.TextBox();
            this.LB_Email_Doner = new System.Windows.Forms.Label();
            this.LB_ContractNumber_Doners = new System.Windows.Forms.Label();
            this.LB_FirstName_Doner = new System.Windows.Forms.Label();
            this.dataGridView_Doners = new System.Windows.Forms.DataGridView();
            this.TxtBx_Search_Doners = new System.Windows.Forms.TextBox();
            this.LB_Search_Doners = new System.Windows.Forms.Label();
            this.Bnt_Search_Doners = new System.Windows.Forms.Button();
            this.TabControl_Endowments.SuspendLayout();
            this.Tab_Donations.SuspendLayout();
            this.GB_Maintenance_Donations.SuspendLayout();
            this.GB_DonerDonations_Donations.SuspendLayout();
            this.GB_PastDonations_Donations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Donations)).BeginInit();
            this.TabControl_Doners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PciBx_Doners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Doners)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl_Endowments
            // 
            this.TabControl_Endowments.Controls.Add(this.Tab_Donations);
            this.TabControl_Endowments.Controls.Add(this.TabControl_Doners);
            this.TabControl_Endowments.Location = new System.Drawing.Point(12, 12);
            this.TabControl_Endowments.Name = "TabControl_Endowments";
            this.TabControl_Endowments.SelectedIndex = 0;
            this.TabControl_Endowments.Size = new System.Drawing.Size(940, 488);
            this.TabControl_Endowments.TabIndex = 0;
            // 
            // Tab_Donations
            // 
            this.Tab_Donations.BackColor = System.Drawing.Color.AliceBlue;
            this.Tab_Donations.Controls.Add(this.GB_Maintenance_Donations);
            this.Tab_Donations.Controls.Add(this.GB_DonerDonations_Donations);
            this.Tab_Donations.Controls.Add(this.GB_PastDonations_Donations);
            this.Tab_Donations.Location = new System.Drawing.Point(4, 22);
            this.Tab_Donations.Name = "Tab_Donations";
            this.Tab_Donations.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Donations.Size = new System.Drawing.Size(932, 462);
            this.Tab_Donations.TabIndex = 0;
            this.Tab_Donations.Text = "Donations";
            // 
            // GB_Maintenance_Donations
            // 
            this.GB_Maintenance_Donations.BackColor = System.Drawing.Color.AliceBlue;
            this.GB_Maintenance_Donations.Controls.Add(this.lblDonationID);
            this.GB_Maintenance_Donations.Controls.Add(this.label5);
            this.GB_Maintenance_Donations.Controls.Add(this.Bnt_Update_Donations);
            this.GB_Maintenance_Donations.Controls.Add(this.txtUpdateType);
            this.GB_Maintenance_Donations.Controls.Add(this.label1);
            this.GB_Maintenance_Donations.Controls.Add(this.txtUpdateAmount);
            this.GB_Maintenance_Donations.Controls.Add(this.dateTimePicker1);
            this.GB_Maintenance_Donations.Controls.Add(this.label2);
            this.GB_Maintenance_Donations.Controls.Add(this.label3);
            this.GB_Maintenance_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Maintenance_Donations.Location = new System.Drawing.Point(456, 6);
            this.GB_Maintenance_Donations.Margin = new System.Windows.Forms.Padding(2);
            this.GB_Maintenance_Donations.Name = "GB_Maintenance_Donations";
            this.GB_Maintenance_Donations.Padding = new System.Windows.Forms.Padding(2);
            this.GB_Maintenance_Donations.Size = new System.Drawing.Size(440, 260);
            this.GB_Maintenance_Donations.TabIndex = 13;
            this.GB_Maintenance_Donations.TabStop = false;
            this.GB_Maintenance_Donations.Text = "Donations Maintenance";
            // 
            // lblDonationID
            // 
            this.lblDonationID.AutoSize = true;
            this.lblDonationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonationID.Location = new System.Drawing.Point(172, 47);
            this.lblDonationID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDonationID.Name = "lblDonationID";
            this.lblDonationID.Size = new System.Drawing.Size(48, 20);
            this.lblDonationID.TabIndex = 17;
            this.lblDonationID.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Donation ID:";
            // 
            // Bnt_Update_Donations
            // 
            this.Bnt_Update_Donations.BackColor = System.Drawing.Color.Silver;
            this.Bnt_Update_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bnt_Update_Donations.Location = new System.Drawing.Point(349, 215);
            this.Bnt_Update_Donations.Margin = new System.Windows.Forms.Padding(2);
            this.Bnt_Update_Donations.Name = "Bnt_Update_Donations";
            this.Bnt_Update_Donations.Size = new System.Drawing.Size(87, 33);
            this.Bnt_Update_Donations.TabIndex = 15;
            this.Bnt_Update_Donations.Text = "Update";
            this.Bnt_Update_Donations.UseVisualStyleBackColor = false;
            this.Bnt_Update_Donations.Click += new System.EventHandler(this.Bnt_Update_Donations_Click);
            // 
            // txtUpdateType
            // 
            this.txtUpdateType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateType.Location = new System.Drawing.Point(176, 132);
            this.txtUpdateType.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateType.Name = "txtUpdateType";
            this.txtUpdateType.Size = new System.Drawing.Size(168, 23);
            this.txtUpdateType.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Type of Donation:";
            // 
            // txtUpdateAmount
            // 
            this.txtUpdateAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateAmount.Location = new System.Drawing.Point(176, 170);
            this.txtUpdateAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateAmount.Name = "txtUpdateAmount";
            this.txtUpdateAmount.Size = new System.Drawing.Size(168, 23);
            this.txtUpdateAmount.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(176, 87);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 23);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount Donated:";
            // 
            // GB_DonerDonations_Donations
            // 
            this.GB_DonerDonations_Donations.BackColor = System.Drawing.Color.AliceBlue;
            this.GB_DonerDonations_Donations.Controls.Add(this.Bnt_Save_Donations);
            this.GB_DonerDonations_Donations.Controls.Add(this.Txt_Type_Donations);
            this.GB_DonerDonations_Donations.Controls.Add(this.LB_Type_Donations);
            this.GB_DonerDonations_Donations.Controls.Add(this.Txt_Amount_Donations);
            this.GB_DonerDonations_Donations.Controls.Add(this.dateTimePicker_Donations);
            this.GB_DonerDonations_Donations.Controls.Add(this.LB_Date_Donations);
            this.GB_DonerDonations_Donations.Controls.Add(this.LB_Amount_Donations);
            this.GB_DonerDonations_Donations.Controls.Add(this.LB_DBEmail_Donations);
            this.GB_DonerDonations_Donations.Controls.Add(this.LB_Email_Donations);
            this.GB_DonerDonations_Donations.Controls.Add(this.LB_DBContactNumber_Donations);
            this.GB_DonerDonations_Donations.Controls.Add(this.LB_ContactNumber_Donations);
            this.GB_DonerDonations_Donations.Controls.Add(this.CB_DonerName_Donations);
            this.GB_DonerDonations_Donations.Controls.Add(this.LB_DonerName_Donations);
            this.GB_DonerDonations_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_DonerDonations_Donations.Location = new System.Drawing.Point(9, 6);
            this.GB_DonerDonations_Donations.Margin = new System.Windows.Forms.Padding(2);
            this.GB_DonerDonations_Donations.Name = "GB_DonerDonations_Donations";
            this.GB_DonerDonations_Donations.Padding = new System.Windows.Forms.Padding(2);
            this.GB_DonerDonations_Donations.Size = new System.Drawing.Size(440, 260);
            this.GB_DonerDonations_Donations.TabIndex = 12;
            this.GB_DonerDonations_Donations.TabStop = false;
            this.GB_DonerDonations_Donations.Text = "New Donations";
            // 
            // Bnt_Save_Donations
            // 
            this.Bnt_Save_Donations.BackColor = System.Drawing.Color.LightGreen;
            this.Bnt_Save_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bnt_Save_Donations.Location = new System.Drawing.Point(349, 208);
            this.Bnt_Save_Donations.Margin = new System.Windows.Forms.Padding(2);
            this.Bnt_Save_Donations.Name = "Bnt_Save_Donations";
            this.Bnt_Save_Donations.Size = new System.Drawing.Size(87, 34);
            this.Bnt_Save_Donations.TabIndex = 13;
            this.Bnt_Save_Donations.Text = "Save";
            this.Bnt_Save_Donations.UseVisualStyleBackColor = false;
            this.Bnt_Save_Donations.Click += new System.EventHandler(this.Bnt_Save_Donations_Click);
            // 
            // Txt_Type_Donations
            // 
            this.Txt_Type_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Type_Donations.Location = new System.Drawing.Point(177, 188);
            this.Txt_Type_Donations.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Type_Donations.Name = "Txt_Type_Donations";
            this.Txt_Type_Donations.Size = new System.Drawing.Size(168, 23);
            this.Txt_Type_Donations.TabIndex = 12;
            // 
            // LB_Type_Donations
            // 
            this.LB_Type_Donations.AutoSize = true;
            this.LB_Type_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Type_Donations.Location = new System.Drawing.Point(11, 190);
            this.LB_Type_Donations.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Type_Donations.Name = "LB_Type_Donations";
            this.LB_Type_Donations.Size = new System.Drawing.Size(134, 20);
            this.LB_Type_Donations.TabIndex = 11;
            this.LB_Type_Donations.Text = "Type of Donation:";
            // 
            // Txt_Amount_Donations
            // 
            this.Txt_Amount_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Amount_Donations.Location = new System.Drawing.Point(177, 223);
            this.Txt_Amount_Donations.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Amount_Donations.Name = "Txt_Amount_Donations";
            this.Txt_Amount_Donations.Size = new System.Drawing.Size(168, 23);
            this.Txt_Amount_Donations.TabIndex = 10;
            // 
            // dateTimePicker_Donations
            // 
            this.dateTimePicker_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Donations.Location = new System.Drawing.Point(177, 148);
            this.dateTimePicker_Donations.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_Donations.Name = "dateTimePicker_Donations";
            this.dateTimePicker_Donations.Size = new System.Drawing.Size(168, 23);
            this.dateTimePicker_Donations.TabIndex = 9;
            // 
            // LB_Date_Donations
            // 
            this.LB_Date_Donations.AutoSize = true;
            this.LB_Date_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Date_Donations.Location = new System.Drawing.Point(11, 150);
            this.LB_Date_Donations.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Date_Donations.Name = "LB_Date_Donations";
            this.LB_Date_Donations.Size = new System.Drawing.Size(48, 20);
            this.LB_Date_Donations.TabIndex = 8;
            this.LB_Date_Donations.Text = "Date:";
            // 
            // LB_Amount_Donations
            // 
            this.LB_Amount_Donations.AutoSize = true;
            this.LB_Amount_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Amount_Donations.Location = new System.Drawing.Point(11, 226);
            this.LB_Amount_Donations.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Amount_Donations.Name = "LB_Amount_Donations";
            this.LB_Amount_Donations.Size = new System.Drawing.Size(135, 20);
            this.LB_Amount_Donations.TabIndex = 6;
            this.LB_Amount_Donations.Text = "Amount Donated:";
            // 
            // LB_DBEmail_Donations
            // 
            this.LB_DBEmail_Donations.AutoSize = true;
            this.LB_DBEmail_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DBEmail_Donations.Location = new System.Drawing.Point(177, 115);
            this.LB_DBEmail_Donations.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_DBEmail_Donations.Name = "LB_DBEmail_Donations";
            this.LB_DBEmail_Donations.Size = new System.Drawing.Size(172, 20);
            this.LB_DBEmail_Donations.TabIndex = 5;
            this.LB_DBEmail_Donations.Text = "\"Will show doner email\"";
            // 
            // LB_Email_Donations
            // 
            this.LB_Email_Donations.AutoSize = true;
            this.LB_Email_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Email_Donations.Location = new System.Drawing.Point(11, 115);
            this.LB_Email_Donations.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Email_Donations.Name = "LB_Email_Donations";
            this.LB_Email_Donations.Size = new System.Drawing.Size(100, 20);
            this.LB_Email_Donations.TabIndex = 4;
            this.LB_Email_Donations.Text = "Doner Email:";
            // 
            // LB_DBContactNumber_Donations
            // 
            this.LB_DBContactNumber_Donations.AutoSize = true;
            this.LB_DBContactNumber_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DBContactNumber_Donations.Location = new System.Drawing.Point(177, 76);
            this.LB_DBContactNumber_Donations.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_DBContactNumber_Donations.Name = "LB_DBContactNumber_Donations";
            this.LB_DBContactNumber_Donations.Size = new System.Drawing.Size(223, 20);
            this.LB_DBContactNumber_Donations.TabIndex = 3;
            this.LB_DBContactNumber_Donations.Text = "\"Will show doner contact num\"";
            // 
            // LB_ContactNumber_Donations
            // 
            this.LB_ContactNumber_Donations.AutoSize = true;
            this.LB_ContactNumber_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ContactNumber_Donations.Location = new System.Drawing.Point(11, 76);
            this.LB_ContactNumber_Donations.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_ContactNumber_Donations.Name = "LB_ContactNumber_Donations";
            this.LB_ContactNumber_Donations.Size = new System.Drawing.Size(177, 20);
            this.LB_ContactNumber_Donations.TabIndex = 2;
            this.LB_ContactNumber_Donations.Text = "Doner Contact Number:";
            // 
            // CB_DonerName_Donations
            // 
            this.CB_DonerName_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_DonerName_Donations.FormattingEnabled = true;
            this.CB_DonerName_Donations.Location = new System.Drawing.Point(177, 31);
            this.CB_DonerName_Donations.Margin = new System.Windows.Forms.Padding(2);
            this.CB_DonerName_Donations.Name = "CB_DonerName_Donations";
            this.CB_DonerName_Donations.Size = new System.Drawing.Size(168, 24);
            this.CB_DonerName_Donations.TabIndex = 1;
            // 
            // LB_DonerName_Donations
            // 
            this.LB_DonerName_Donations.AutoSize = true;
            this.LB_DonerName_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DonerName_Donations.Location = new System.Drawing.Point(11, 34);
            this.LB_DonerName_Donations.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_DonerName_Donations.Name = "LB_DonerName_Donations";
            this.LB_DonerName_Donations.Size = new System.Drawing.Size(103, 20);
            this.LB_DonerName_Donations.TabIndex = 0;
            this.LB_DonerName_Donations.Text = "Doner Name:";
            // 
            // GB_PastDonations_Donations
            // 
            this.GB_PastDonations_Donations.Controls.Add(this.Bnt_Close_Donations);
            this.GB_PastDonations_Donations.Controls.Add(this.DataGrid_Donations);
            this.GB_PastDonations_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_PastDonations_Donations.Location = new System.Drawing.Point(9, 271);
            this.GB_PastDonations_Donations.Margin = new System.Windows.Forms.Padding(2);
            this.GB_PastDonations_Donations.Name = "GB_PastDonations_Donations";
            this.GB_PastDonations_Donations.Padding = new System.Windows.Forms.Padding(2);
            this.GB_PastDonations_Donations.Size = new System.Drawing.Size(887, 186);
            this.GB_PastDonations_Donations.TabIndex = 12;
            this.GB_PastDonations_Donations.TabStop = false;
            this.GB_PastDonations_Donations.Text = "Past Donations";
            // 
            // Bnt_Close_Donations
            // 
            this.Bnt_Close_Donations.BackColor = System.Drawing.Color.Red;
            this.Bnt_Close_Donations.Location = new System.Drawing.Point(751, 152);
            this.Bnt_Close_Donations.Name = "Bnt_Close_Donations";
            this.Bnt_Close_Donations.Size = new System.Drawing.Size(124, 29);
            this.Bnt_Close_Donations.TabIndex = 53;
            this.Bnt_Close_Donations.Text = "Close";
            this.Bnt_Close_Donations.UseVisualStyleBackColor = false;
            this.Bnt_Close_Donations.Click += new System.EventHandler(this.Bnt_Close_Donations_Click);
            // 
            // DataGrid_Donations
            // 
            this.DataGrid_Donations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Donations.Location = new System.Drawing.Point(5, 24);
            this.DataGrid_Donations.Name = "DataGrid_Donations";
            this.DataGrid_Donations.RowTemplate.Height = 24;
            this.DataGrid_Donations.Size = new System.Drawing.Size(870, 122);
            this.DataGrid_Donations.TabIndex = 9;
            this.DataGrid_Donations.SelectionChanged += new System.EventHandler(this.DataGrid_Donations_SelectionChanged);
            // 
            // TabControl_Doners
            // 
            this.TabControl_Doners.BackColor = System.Drawing.Color.AliceBlue;
            this.TabControl_Doners.Controls.Add(this.lblDonorID);
            this.TabControl_Doners.Controls.Add(this.label4);
            this.TabControl_Doners.Controls.Add(this.PciBx_Doners);
            this.TabControl_Doners.Controls.Add(this.Bnt_Close_Doner);
            this.TabControl_Doners.Controls.Add(this.Bnt_Update_Doner);
            this.TabControl_Doners.Controls.Add(this.Bnt_New_Doner);
            this.TabControl_Doners.Controls.Add(this.Txt_Email_Doner);
            this.TabControl_Doners.Controls.Add(this.Txt_ContactNumber_Doner);
            this.TabControl_Doners.Controls.Add(this.Txt_FirstName_Doner);
            this.TabControl_Doners.Controls.Add(this.LB_Email_Doner);
            this.TabControl_Doners.Controls.Add(this.LB_ContractNumber_Doners);
            this.TabControl_Doners.Controls.Add(this.LB_FirstName_Doner);
            this.TabControl_Doners.Controls.Add(this.dataGridView_Doners);
            this.TabControl_Doners.Controls.Add(this.TxtBx_Search_Doners);
            this.TabControl_Doners.Controls.Add(this.LB_Search_Doners);
            this.TabControl_Doners.Controls.Add(this.Bnt_Search_Doners);
            this.TabControl_Doners.Location = new System.Drawing.Point(4, 22);
            this.TabControl_Doners.Name = "TabControl_Doners";
            this.TabControl_Doners.Padding = new System.Windows.Forms.Padding(3);
            this.TabControl_Doners.Size = new System.Drawing.Size(932, 462);
            this.TabControl_Doners.TabIndex = 1;
            this.TabControl_Doners.Text = "Doners";
            // 
            // lblDonorID
            // 
            this.lblDonorID.AutoSize = true;
            this.lblDonorID.Location = new System.Drawing.Point(110, 240);
            this.lblDonorID.Name = "lblDonorID";
            this.lblDonorID.Size = new System.Drawing.Size(18, 13);
            this.lblDonorID.TabIndex = 55;
            this.lblDonorID.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Doner ID:";
            // 
            // PciBx_Doners
            // 
            this.PciBx_Doners.BackgroundImage = global::CMPG223_Group4_Project.Properties.Resources.Doners_Icon;
            this.PciBx_Doners.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PciBx_Doners.Location = new System.Drawing.Point(474, 230);
            this.PciBx_Doners.Margin = new System.Windows.Forms.Padding(2);
            this.PciBx_Doners.Name = "PciBx_Doners";
            this.PciBx_Doners.Size = new System.Drawing.Size(285, 172);
            this.PciBx_Doners.TabIndex = 53;
            this.PciBx_Doners.TabStop = false;
            // 
            // Bnt_Close_Doner
            // 
            this.Bnt_Close_Doner.BackColor = System.Drawing.Color.Red;
            this.Bnt_Close_Doner.Location = new System.Drawing.Point(764, 379);
            this.Bnt_Close_Doner.Name = "Bnt_Close_Doner";
            this.Bnt_Close_Doner.Size = new System.Drawing.Size(124, 23);
            this.Bnt_Close_Doner.TabIndex = 52;
            this.Bnt_Close_Doner.Text = "Close";
            this.Bnt_Close_Doner.UseVisualStyleBackColor = false;
            this.Bnt_Close_Doner.Click += new System.EventHandler(this.Bnt_Close_Doner_Click);
            // 
            // Bnt_Update_Doner
            // 
            this.Bnt_Update_Doner.BackColor = System.Drawing.Color.LightBlue;
            this.Bnt_Update_Doner.Location = new System.Drawing.Point(764, 269);
            this.Bnt_Update_Doner.Name = "Bnt_Update_Doner";
            this.Bnt_Update_Doner.Size = new System.Drawing.Size(124, 23);
            this.Bnt_Update_Doner.TabIndex = 50;
            this.Bnt_Update_Doner.Text = "Update";
            this.Bnt_Update_Doner.UseVisualStyleBackColor = false;
            this.Bnt_Update_Doner.Click += new System.EventHandler(this.Bnt_Update_Doner_Click);
            // 
            // Bnt_New_Doner
            // 
            this.Bnt_New_Doner.BackColor = System.Drawing.Color.LightGreen;
            this.Bnt_New_Doner.Location = new System.Drawing.Point(764, 230);
            this.Bnt_New_Doner.Name = "Bnt_New_Doner";
            this.Bnt_New_Doner.Size = new System.Drawing.Size(124, 23);
            this.Bnt_New_Doner.TabIndex = 49;
            this.Bnt_New_Doner.Text = "New";
            this.Bnt_New_Doner.UseVisualStyleBackColor = false;
            this.Bnt_New_Doner.Click += new System.EventHandler(this.Bnt_New_Doner_Click);
            // 
            // Txt_Email_Doner
            // 
            this.Txt_Email_Doner.Location = new System.Drawing.Point(113, 358);
            this.Txt_Email_Doner.Name = "Txt_Email_Doner";
            this.Txt_Email_Doner.Size = new System.Drawing.Size(234, 20);
            this.Txt_Email_Doner.TabIndex = 43;
            // 
            // Txt_ContactNumber_Doner
            // 
            this.Txt_ContactNumber_Doner.Location = new System.Drawing.Point(113, 310);
            this.Txt_ContactNumber_Doner.Name = "Txt_ContactNumber_Doner";
            this.Txt_ContactNumber_Doner.Size = new System.Drawing.Size(234, 20);
            this.Txt_ContactNumber_Doner.TabIndex = 42;
            // 
            // Txt_FirstName_Doner
            // 
            this.Txt_FirstName_Doner.Location = new System.Drawing.Point(113, 267);
            this.Txt_FirstName_Doner.Name = "Txt_FirstName_Doner";
            this.Txt_FirstName_Doner.Size = new System.Drawing.Size(234, 20);
            this.Txt_FirstName_Doner.TabIndex = 41;
            // 
            // LB_Email_Doner
            // 
            this.LB_Email_Doner.AutoSize = true;
            this.LB_Email_Doner.Location = new System.Drawing.Point(19, 358);
            this.LB_Email_Doner.Name = "LB_Email_Doner";
            this.LB_Email_Doner.Size = new System.Drawing.Size(35, 13);
            this.LB_Email_Doner.TabIndex = 35;
            this.LB_Email_Doner.Text = "Email:";
            // 
            // LB_ContractNumber_Doners
            // 
            this.LB_ContractNumber_Doners.AutoSize = true;
            this.LB_ContractNumber_Doners.Location = new System.Drawing.Point(19, 310);
            this.LB_ContractNumber_Doners.Name = "LB_ContractNumber_Doners";
            this.LB_ContractNumber_Doners.Size = new System.Drawing.Size(87, 13);
            this.LB_ContractNumber_Doners.TabIndex = 34;
            this.LB_ContractNumber_Doners.Text = "Contact Number:";
            // 
            // LB_FirstName_Doner
            // 
            this.LB_FirstName_Doner.AutoSize = true;
            this.LB_FirstName_Doner.Location = new System.Drawing.Point(19, 268);
            this.LB_FirstName_Doner.Name = "LB_FirstName_Doner";
            this.LB_FirstName_Doner.Size = new System.Drawing.Size(70, 13);
            this.LB_FirstName_Doner.TabIndex = 33;
            this.LB_FirstName_Doner.Text = "Doner Name:";
            // 
            // dataGridView_Doners
            // 
            this.dataGridView_Doners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Doners.Location = new System.Drawing.Point(18, 43);
            this.dataGridView_Doners.Name = "dataGridView_Doners";
            this.dataGridView_Doners.RowTemplate.Height = 24;
            this.dataGridView_Doners.Size = new System.Drawing.Size(870, 180);
            this.dataGridView_Doners.TabIndex = 32;
            this.dataGridView_Doners.SelectionChanged += new System.EventHandler(this.dataGridView_Doners_SelectionChanged);
            // 
            // TxtBx_Search_Doners
            // 
            this.TxtBx_Search_Doners.Location = new System.Drawing.Point(113, 15);
            this.TxtBx_Search_Doners.Name = "TxtBx_Search_Doners";
            this.TxtBx_Search_Doners.Size = new System.Drawing.Size(234, 20);
            this.TxtBx_Search_Doners.TabIndex = 29;
            this.TxtBx_Search_Doners.TextChanged += new System.EventHandler(this.TxtBx_Search_Doners_TextChanged);
            // 
            // LB_Search_Doners
            // 
            this.LB_Search_Doners.AutoSize = true;
            this.LB_Search_Doners.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Search_Doners.Location = new System.Drawing.Point(25, 12);
            this.LB_Search_Doners.Name = "LB_Search_Doners";
            this.LB_Search_Doners.Size = new System.Drawing.Size(82, 24);
            this.LB_Search_Doners.TabIndex = 28;
            this.LB_Search_Doners.Text = "Search:";
            // 
            // Bnt_Search_Doners
            // 
            this.Bnt_Search_Doners.BackgroundImage = global::CMPG223_Group4_Project.Properties.Resources.Magnifying_glass;
            this.Bnt_Search_Doners.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bnt_Search_Doners.Location = new System.Drawing.Point(764, 15);
            this.Bnt_Search_Doners.Name = "Bnt_Search_Doners";
            this.Bnt_Search_Doners.Size = new System.Drawing.Size(124, 23);
            this.Bnt_Search_Doners.TabIndex = 30;
            this.Bnt_Search_Doners.UseVisualStyleBackColor = true;
            // 
            // EndowmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 522);
            this.Controls.Add(this.TabControl_Endowments);
            this.Name = "EndowmentsForm";
            this.Text = "EndowmentsForm";
            this.TabControl_Endowments.ResumeLayout(false);
            this.Tab_Donations.ResumeLayout(false);
            this.GB_Maintenance_Donations.ResumeLayout(false);
            this.GB_Maintenance_Donations.PerformLayout();
            this.GB_DonerDonations_Donations.ResumeLayout(false);
            this.GB_DonerDonations_Donations.PerformLayout();
            this.GB_PastDonations_Donations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Donations)).EndInit();
            this.TabControl_Doners.ResumeLayout(false);
            this.TabControl_Doners.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PciBx_Doners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Doners)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl_Endowments;
        private System.Windows.Forms.TabPage Tab_Donations;
        private System.Windows.Forms.TabPage TabControl_Doners;
        private System.Windows.Forms.DataGridView DataGrid_Donations;
        private System.Windows.Forms.GroupBox GB_PastDonations_Donations;
        private System.Windows.Forms.GroupBox GB_DonerDonations_Donations;
        private System.Windows.Forms.Label LB_DBContactNumber_Donations;
        private System.Windows.Forms.Label LB_ContactNumber_Donations;
        private System.Windows.Forms.ComboBox CB_DonerName_Donations;
        private System.Windows.Forms.Label LB_DonerName_Donations;
        private System.Windows.Forms.Label LB_Date_Donations;
        private System.Windows.Forms.Label LB_Amount_Donations;
        private System.Windows.Forms.Label LB_DBEmail_Donations;
        private System.Windows.Forms.Label LB_Email_Donations;
        private System.Windows.Forms.TextBox Txt_Type_Donations;
        private System.Windows.Forms.Label LB_Type_Donations;
        private System.Windows.Forms.TextBox Txt_Amount_Donations;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Donations;
        private System.Windows.Forms.Button Bnt_Save_Donations;
        private System.Windows.Forms.GroupBox GB_Maintenance_Donations;
        private System.Windows.Forms.Button Bnt_Update_Donations;
        private System.Windows.Forms.TextBox txtUpdateType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUpdateAmount;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PciBx_Doners;
        private System.Windows.Forms.Button Bnt_Close_Doner;
        private System.Windows.Forms.Button Bnt_Update_Doner;
        private System.Windows.Forms.Button Bnt_New_Doner;
        private System.Windows.Forms.TextBox Txt_Email_Doner;
        private System.Windows.Forms.TextBox Txt_ContactNumber_Doner;
        private System.Windows.Forms.TextBox Txt_FirstName_Doner;
        private System.Windows.Forms.Label LB_Email_Doner;
        private System.Windows.Forms.Label LB_ContractNumber_Doners;
        private System.Windows.Forms.Label LB_FirstName_Doner;
        private System.Windows.Forms.DataGridView dataGridView_Doners;
        private System.Windows.Forms.Button Bnt_Search_Doners;
        private System.Windows.Forms.TextBox TxtBx_Search_Doners;
        private System.Windows.Forms.Label LB_Search_Doners;
        private System.Windows.Forms.Button Bnt_Close_Donations;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDonorID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDonationID;
    }
}