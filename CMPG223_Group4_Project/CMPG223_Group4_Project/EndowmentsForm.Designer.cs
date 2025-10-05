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
            this.DataGrid_Textbook = new System.Windows.Forms.DataGridView();
            this.TabControl_Doners = new System.Windows.Forms.TabPage();
            this.GB_PastDonations_Donations = new System.Windows.Forms.GroupBox();
            this.GB_DonerDonations_Donations = new System.Windows.Forms.GroupBox();
            this.LB_DonerName_Donations = new System.Windows.Forms.Label();
            this.CB_DonerName_Donations = new System.Windows.Forms.ComboBox();
            this.LB_ContactNumber_Donations = new System.Windows.Forms.Label();
            this.LB_DBContactNumber_Donations = new System.Windows.Forms.Label();
            this.LB_Email_Donations = new System.Windows.Forms.Label();
            this.LB_DBEmail_Donations = new System.Windows.Forms.Label();
            this.LB_Amount_Donations = new System.Windows.Forms.Label();
            this.LB_Date_Donations = new System.Windows.Forms.Label();
            this.dateTimePicker_Donations = new System.Windows.Forms.DateTimePicker();
            this.Txt_Amount_Donations = new System.Windows.Forms.TextBox();
            this.LB_Type_Donations = new System.Windows.Forms.Label();
            this.Txt_Type_Donations = new System.Windows.Forms.TextBox();
            this.Bnt_Save_Donations = new System.Windows.Forms.Button();
            this.Bnt_Clear_Donations = new System.Windows.Forms.Button();
            this.LB_DonationID_Donations = new System.Windows.Forms.Label();
            this.CB_DonationID_Donations = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Bnt_Delete_Donations = new System.Windows.Forms.Button();
            this.Bnt_Update_Donations = new System.Windows.Forms.Button();
            this.GB_Maintenance_Donations = new System.Windows.Forms.GroupBox();
            this.dataGrid_SelectedIDDonations_Donations = new System.Windows.Forms.DataGridView();
            this.Bnt_Close_Doner = new System.Windows.Forms.Button();
            this.Bnt_Delete_Doner = new System.Windows.Forms.Button();
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
            this.Bnt_Refresh_Donations = new System.Windows.Forms.Button();
            this.PciBx_Doners = new System.Windows.Forms.PictureBox();
            this.Bnt_Clear_Doners = new System.Windows.Forms.Button();
            this.Bnt_Search_Doners = new System.Windows.Forms.Button();
            this.Bnt_Close_Donations = new System.Windows.Forms.Button();
            this.TabControl_Endowments.SuspendLayout();
            this.Tab_Donations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Textbook)).BeginInit();
            this.TabControl_Doners.SuspendLayout();
            this.GB_PastDonations_Donations.SuspendLayout();
            this.GB_DonerDonations_Donations.SuspendLayout();
            this.GB_Maintenance_Donations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_SelectedIDDonations_Donations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Doners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PciBx_Doners)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl_Endowments
            // 
            this.TabControl_Endowments.Controls.Add(this.Tab_Donations);
            this.TabControl_Endowments.Controls.Add(this.TabControl_Doners);
            this.TabControl_Endowments.Location = new System.Drawing.Point(16, 15);
            this.TabControl_Endowments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabControl_Endowments.Name = "TabControl_Endowments";
            this.TabControl_Endowments.SelectedIndex = 0;
            this.TabControl_Endowments.Size = new System.Drawing.Size(1254, 553);
            this.TabControl_Endowments.TabIndex = 0;
            // 
            // Tab_Donations
            // 
            this.Tab_Donations.BackColor = System.Drawing.Color.AliceBlue;
            this.Tab_Donations.Controls.Add(this.GB_Maintenance_Donations);
            this.Tab_Donations.Controls.Add(this.GB_DonerDonations_Donations);
            this.Tab_Donations.Controls.Add(this.GB_PastDonations_Donations);
            this.Tab_Donations.Location = new System.Drawing.Point(4, 25);
            this.Tab_Donations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tab_Donations.Name = "Tab_Donations";
            this.Tab_Donations.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tab_Donations.Size = new System.Drawing.Size(1246, 524);
            this.Tab_Donations.TabIndex = 0;
            this.Tab_Donations.Text = "Donations";
            // 
            // DataGrid_Textbook
            // 
            this.DataGrid_Textbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Textbook.Location = new System.Drawing.Point(7, 29);
            this.DataGrid_Textbook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGrid_Textbook.Name = "DataGrid_Textbook";
            this.DataGrid_Textbook.RowTemplate.Height = 24;
            this.DataGrid_Textbook.Size = new System.Drawing.Size(1160, 104);
            this.DataGrid_Textbook.TabIndex = 9;
            // 
            // TabControl_Doners
            // 
            this.TabControl_Doners.BackColor = System.Drawing.Color.AliceBlue;
            this.TabControl_Doners.Controls.Add(this.PciBx_Doners);
            this.TabControl_Doners.Controls.Add(this.Bnt_Close_Doner);
            this.TabControl_Doners.Controls.Add(this.Bnt_Delete_Doner);
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
            this.TabControl_Doners.Controls.Add(this.Bnt_Clear_Doners);
            this.TabControl_Doners.Controls.Add(this.Bnt_Search_Doners);
            this.TabControl_Doners.Location = new System.Drawing.Point(4, 25);
            this.TabControl_Doners.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabControl_Doners.Name = "TabControl_Doners";
            this.TabControl_Doners.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabControl_Doners.Size = new System.Drawing.Size(1209, 510);
            this.TabControl_Doners.TabIndex = 1;
            this.TabControl_Doners.Text = "Doners";
            // 
            // GB_PastDonations_Donations
            // 
            this.GB_PastDonations_Donations.Controls.Add(this.Bnt_Close_Donations);
            this.GB_PastDonations_Donations.Controls.Add(this.DataGrid_Textbook);
            this.GB_PastDonations_Donations.Controls.Add(this.Bnt_Refresh_Donations);
            this.GB_PastDonations_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_PastDonations_Donations.Location = new System.Drawing.Point(12, 333);
            this.GB_PastDonations_Donations.Name = "GB_PastDonations_Donations";
            this.GB_PastDonations_Donations.Size = new System.Drawing.Size(1183, 184);
            this.GB_PastDonations_Donations.TabIndex = 12;
            this.GB_PastDonations_Donations.TabStop = false;
            this.GB_PastDonations_Donations.Text = "Past Donations";
            // 
            // GB_DonerDonations_Donations
            // 
            this.GB_DonerDonations_Donations.BackColor = System.Drawing.Color.AliceBlue;
            this.GB_DonerDonations_Donations.Controls.Add(this.Bnt_Clear_Donations);
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
            this.GB_DonerDonations_Donations.Location = new System.Drawing.Point(12, 7);
            this.GB_DonerDonations_Donations.Name = "GB_DonerDonations_Donations";
            this.GB_DonerDonations_Donations.Size = new System.Drawing.Size(587, 320);
            this.GB_DonerDonations_Donations.TabIndex = 12;
            this.GB_DonerDonations_Donations.TabStop = false;
            this.GB_DonerDonations_Donations.Text = "New Donations";
            // 
            // LB_DonerName_Donations
            // 
            this.LB_DonerName_Donations.AutoSize = true;
            this.LB_DonerName_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DonerName_Donations.Location = new System.Drawing.Point(15, 42);
            this.LB_DonerName_Donations.Name = "LB_DonerName_Donations";
            this.LB_DonerName_Donations.Size = new System.Drawing.Size(103, 20);
            this.LB_DonerName_Donations.TabIndex = 0;
            this.LB_DonerName_Donations.Text = "Doner Name:";
            // 
            // CB_DonerName_Donations
            // 
            this.CB_DonerName_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_DonerName_Donations.FormattingEnabled = true;
            this.CB_DonerName_Donations.Location = new System.Drawing.Point(236, 38);
            this.CB_DonerName_Donations.Name = "CB_DonerName_Donations";
            this.CB_DonerName_Donations.Size = new System.Drawing.Size(223, 24);
            this.CB_DonerName_Donations.TabIndex = 1;
            // 
            // LB_ContactNumber_Donations
            // 
            this.LB_ContactNumber_Donations.AutoSize = true;
            this.LB_ContactNumber_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ContactNumber_Donations.Location = new System.Drawing.Point(15, 94);
            this.LB_ContactNumber_Donations.Name = "LB_ContactNumber_Donations";
            this.LB_ContactNumber_Donations.Size = new System.Drawing.Size(177, 20);
            this.LB_ContactNumber_Donations.TabIndex = 2;
            this.LB_ContactNumber_Donations.Text = "Doner Contact Number:";
            // 
            // LB_DBContactNumber_Donations
            // 
            this.LB_DBContactNumber_Donations.AutoSize = true;
            this.LB_DBContactNumber_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DBContactNumber_Donations.Location = new System.Drawing.Point(236, 94);
            this.LB_DBContactNumber_Donations.Name = "LB_DBContactNumber_Donations";
            this.LB_DBContactNumber_Donations.Size = new System.Drawing.Size(223, 20);
            this.LB_DBContactNumber_Donations.TabIndex = 3;
            this.LB_DBContactNumber_Donations.Text = "\"Will show doner contact num\"";
            // 
            // LB_Email_Donations
            // 
            this.LB_Email_Donations.AutoSize = true;
            this.LB_Email_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Email_Donations.Location = new System.Drawing.Point(15, 142);
            this.LB_Email_Donations.Name = "LB_Email_Donations";
            this.LB_Email_Donations.Size = new System.Drawing.Size(100, 20);
            this.LB_Email_Donations.TabIndex = 4;
            this.LB_Email_Donations.Text = "Doner Email:";
            // 
            // LB_DBEmail_Donations
            // 
            this.LB_DBEmail_Donations.AutoSize = true;
            this.LB_DBEmail_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DBEmail_Donations.Location = new System.Drawing.Point(236, 142);
            this.LB_DBEmail_Donations.Name = "LB_DBEmail_Donations";
            this.LB_DBEmail_Donations.Size = new System.Drawing.Size(172, 20);
            this.LB_DBEmail_Donations.TabIndex = 5;
            this.LB_DBEmail_Donations.Text = "\"Will show doner email\"";
            // 
            // LB_Amount_Donations
            // 
            this.LB_Amount_Donations.AutoSize = true;
            this.LB_Amount_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Amount_Donations.Location = new System.Drawing.Point(15, 278);
            this.LB_Amount_Donations.Name = "LB_Amount_Donations";
            this.LB_Amount_Donations.Size = new System.Drawing.Size(135, 20);
            this.LB_Amount_Donations.TabIndex = 6;
            this.LB_Amount_Donations.Text = "Amount Donated:";
            // 
            // LB_Date_Donations
            // 
            this.LB_Date_Donations.AutoSize = true;
            this.LB_Date_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Date_Donations.Location = new System.Drawing.Point(15, 185);
            this.LB_Date_Donations.Name = "LB_Date_Donations";
            this.LB_Date_Donations.Size = new System.Drawing.Size(48, 20);
            this.LB_Date_Donations.TabIndex = 8;
            this.LB_Date_Donations.Text = "Date:";
            // 
            // dateTimePicker_Donations
            // 
            this.dateTimePicker_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Donations.Location = new System.Drawing.Point(236, 182);
            this.dateTimePicker_Donations.Name = "dateTimePicker_Donations";
            this.dateTimePicker_Donations.Size = new System.Drawing.Size(223, 23);
            this.dateTimePicker_Donations.TabIndex = 9;
            // 
            // Txt_Amount_Donations
            // 
            this.Txt_Amount_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Amount_Donations.Location = new System.Drawing.Point(236, 275);
            this.Txt_Amount_Donations.Name = "Txt_Amount_Donations";
            this.Txt_Amount_Donations.Size = new System.Drawing.Size(223, 23);
            this.Txt_Amount_Donations.TabIndex = 10;
            // 
            // LB_Type_Donations
            // 
            this.LB_Type_Donations.AutoSize = true;
            this.LB_Type_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Type_Donations.Location = new System.Drawing.Point(15, 234);
            this.LB_Type_Donations.Name = "LB_Type_Donations";
            this.LB_Type_Donations.Size = new System.Drawing.Size(134, 20);
            this.LB_Type_Donations.TabIndex = 11;
            this.LB_Type_Donations.Text = "Type of Donation:";
            // 
            // Txt_Type_Donations
            // 
            this.Txt_Type_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Type_Donations.Location = new System.Drawing.Point(236, 231);
            this.Txt_Type_Donations.Name = "Txt_Type_Donations";
            this.Txt_Type_Donations.Size = new System.Drawing.Size(223, 23);
            this.Txt_Type_Donations.TabIndex = 12;
            // 
            // Bnt_Save_Donations
            // 
            this.Bnt_Save_Donations.BackColor = System.Drawing.Color.LightGreen;
            this.Bnt_Save_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bnt_Save_Donations.Location = new System.Drawing.Point(465, 256);
            this.Bnt_Save_Donations.Name = "Bnt_Save_Donations";
            this.Bnt_Save_Donations.Size = new System.Drawing.Size(116, 42);
            this.Bnt_Save_Donations.TabIndex = 13;
            this.Bnt_Save_Donations.Text = "Save";
            this.Bnt_Save_Donations.UseVisualStyleBackColor = false;
            // 
            // Bnt_Clear_Donations
            // 
            this.Bnt_Clear_Donations.BackColor = System.Drawing.Color.Beige;
            this.Bnt_Clear_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bnt_Clear_Donations.Location = new System.Drawing.Point(465, 209);
            this.Bnt_Clear_Donations.Name = "Bnt_Clear_Donations";
            this.Bnt_Clear_Donations.Size = new System.Drawing.Size(116, 39);
            this.Bnt_Clear_Donations.TabIndex = 14;
            this.Bnt_Clear_Donations.Text = "Clear";
            this.Bnt_Clear_Donations.UseVisualStyleBackColor = false;
            // 
            // LB_DonationID_Donations
            // 
            this.LB_DonationID_Donations.AutoSize = true;
            this.LB_DonationID_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DonationID_Donations.Location = new System.Drawing.Point(15, 42);
            this.LB_DonationID_Donations.Name = "LB_DonationID_Donations";
            this.LB_DonationID_Donations.Size = new System.Drawing.Size(104, 20);
            this.LB_DonationID_Donations.TabIndex = 0;
            this.LB_DonationID_Donations.Text = "Donation_ID:";
            // 
            // CB_DonationID_Donations
            // 
            this.CB_DonationID_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_DonationID_Donations.FormattingEnabled = true;
            this.CB_DonationID_Donations.Location = new System.Drawing.Point(236, 38);
            this.CB_DonationID_Donations.Name = "CB_DonationID_Donations";
            this.CB_DonationID_Donations.Size = new System.Drawing.Size(223, 24);
            this.CB_DonationID_Donations.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount Donated:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(227, 172);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(223, 23);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(227, 274);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(223, 23);
            this.textBox2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Type of Donation:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(227, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 23);
            this.textBox1.TabIndex = 12;
            // 
            // Bnt_Delete_Donations
            // 
            this.Bnt_Delete_Donations.BackColor = System.Drawing.Color.Salmon;
            this.Bnt_Delete_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bnt_Delete_Donations.Location = new System.Drawing.Point(465, 209);
            this.Bnt_Delete_Donations.Name = "Bnt_Delete_Donations";
            this.Bnt_Delete_Donations.Size = new System.Drawing.Size(116, 45);
            this.Bnt_Delete_Donations.TabIndex = 15;
            this.Bnt_Delete_Donations.Text = "Delete";
            this.Bnt_Delete_Donations.UseVisualStyleBackColor = false;
            // 
            // Bnt_Update_Donations
            // 
            this.Bnt_Update_Donations.BackColor = System.Drawing.Color.Silver;
            this.Bnt_Update_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bnt_Update_Donations.Location = new System.Drawing.Point(465, 265);
            this.Bnt_Update_Donations.Name = "Bnt_Update_Donations";
            this.Bnt_Update_Donations.Size = new System.Drawing.Size(116, 41);
            this.Bnt_Update_Donations.TabIndex = 15;
            this.Bnt_Update_Donations.Text = "Update";
            this.Bnt_Update_Donations.UseVisualStyleBackColor = false;
            // 
            // GB_Maintenance_Donations
            // 
            this.GB_Maintenance_Donations.BackColor = System.Drawing.Color.AliceBlue;
            this.GB_Maintenance_Donations.Controls.Add(this.dataGrid_SelectedIDDonations_Donations);
            this.GB_Maintenance_Donations.Controls.Add(this.Bnt_Update_Donations);
            this.GB_Maintenance_Donations.Controls.Add(this.Bnt_Delete_Donations);
            this.GB_Maintenance_Donations.Controls.Add(this.textBox1);
            this.GB_Maintenance_Donations.Controls.Add(this.label1);
            this.GB_Maintenance_Donations.Controls.Add(this.textBox2);
            this.GB_Maintenance_Donations.Controls.Add(this.dateTimePicker1);
            this.GB_Maintenance_Donations.Controls.Add(this.label2);
            this.GB_Maintenance_Donations.Controls.Add(this.label3);
            this.GB_Maintenance_Donations.Controls.Add(this.CB_DonationID_Donations);
            this.GB_Maintenance_Donations.Controls.Add(this.LB_DonationID_Donations);
            this.GB_Maintenance_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Maintenance_Donations.Location = new System.Drawing.Point(608, 7);
            this.GB_Maintenance_Donations.Name = "GB_Maintenance_Donations";
            this.GB_Maintenance_Donations.Size = new System.Drawing.Size(587, 320);
            this.GB_Maintenance_Donations.TabIndex = 13;
            this.GB_Maintenance_Donations.TabStop = false;
            this.GB_Maintenance_Donations.Text = "Donations Maintenance";
            // 
            // dataGrid_SelectedIDDonations_Donations
            // 
            this.dataGrid_SelectedIDDonations_Donations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_SelectedIDDonations_Donations.Location = new System.Drawing.Point(19, 80);
            this.dataGrid_SelectedIDDonations_Donations.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid_SelectedIDDonations_Donations.Name = "dataGrid_SelectedIDDonations_Donations";
            this.dataGrid_SelectedIDDonations_Donations.RowTemplate.Height = 24;
            this.dataGrid_SelectedIDDonations_Donations.Size = new System.Drawing.Size(552, 82);
            this.dataGrid_SelectedIDDonations_Donations.TabIndex = 11;
            // 
            // Bnt_Close_Doner
            // 
            this.Bnt_Close_Doner.BackColor = System.Drawing.Color.Red;
            this.Bnt_Close_Doner.Location = new System.Drawing.Point(1019, 467);
            this.Bnt_Close_Doner.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_Close_Doner.Name = "Bnt_Close_Doner";
            this.Bnt_Close_Doner.Size = new System.Drawing.Size(165, 28);
            this.Bnt_Close_Doner.TabIndex = 52;
            this.Bnt_Close_Doner.Text = "Close";
            this.Bnt_Close_Doner.UseVisualStyleBackColor = false;
            // 
            // Bnt_Delete_Doner
            // 
            this.Bnt_Delete_Doner.BackColor = System.Drawing.Color.Silver;
            this.Bnt_Delete_Doner.Location = new System.Drawing.Point(1019, 385);
            this.Bnt_Delete_Doner.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_Delete_Doner.Name = "Bnt_Delete_Doner";
            this.Bnt_Delete_Doner.Size = new System.Drawing.Size(165, 28);
            this.Bnt_Delete_Doner.TabIndex = 51;
            this.Bnt_Delete_Doner.Text = "Delete";
            this.Bnt_Delete_Doner.UseVisualStyleBackColor = false;
            // 
            // Bnt_Update_Doner
            // 
            this.Bnt_Update_Doner.BackColor = System.Drawing.Color.LightBlue;
            this.Bnt_Update_Doner.Location = new System.Drawing.Point(1019, 331);
            this.Bnt_Update_Doner.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_Update_Doner.Name = "Bnt_Update_Doner";
            this.Bnt_Update_Doner.Size = new System.Drawing.Size(165, 28);
            this.Bnt_Update_Doner.TabIndex = 50;
            this.Bnt_Update_Doner.Text = "Update";
            this.Bnt_Update_Doner.UseVisualStyleBackColor = false;
            // 
            // Bnt_New_Doner
            // 
            this.Bnt_New_Doner.BackColor = System.Drawing.Color.LightGreen;
            this.Bnt_New_Doner.Location = new System.Drawing.Point(1019, 283);
            this.Bnt_New_Doner.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_New_Doner.Name = "Bnt_New_Doner";
            this.Bnt_New_Doner.Size = new System.Drawing.Size(165, 28);
            this.Bnt_New_Doner.TabIndex = 49;
            this.Bnt_New_Doner.Text = "New";
            this.Bnt_New_Doner.UseVisualStyleBackColor = false;
            // 
            // Txt_Email_Doner
            // 
            this.Txt_Email_Doner.Location = new System.Drawing.Point(151, 394);
            this.Txt_Email_Doner.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Email_Doner.Name = "Txt_Email_Doner";
            this.Txt_Email_Doner.Size = new System.Drawing.Size(311, 22);
            this.Txt_Email_Doner.TabIndex = 43;
            // 
            // Txt_ContactNumber_Doner
            // 
            this.Txt_ContactNumber_Doner.Location = new System.Drawing.Point(151, 335);
            this.Txt_ContactNumber_Doner.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_ContactNumber_Doner.Name = "Txt_ContactNumber_Doner";
            this.Txt_ContactNumber_Doner.Size = new System.Drawing.Size(311, 22);
            this.Txt_ContactNumber_Doner.TabIndex = 42;
            // 
            // Txt_FirstName_Doner
            // 
            this.Txt_FirstName_Doner.Location = new System.Drawing.Point(151, 282);
            this.Txt_FirstName_Doner.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_FirstName_Doner.Name = "Txt_FirstName_Doner";
            this.Txt_FirstName_Doner.Size = new System.Drawing.Size(311, 22);
            this.Txt_FirstName_Doner.TabIndex = 41;
            // 
            // LB_Email_Doner
            // 
            this.LB_Email_Doner.AutoSize = true;
            this.LB_Email_Doner.Location = new System.Drawing.Point(25, 394);
            this.LB_Email_Doner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Email_Doner.Name = "LB_Email_Doner";
            this.LB_Email_Doner.Size = new System.Drawing.Size(44, 16);
            this.LB_Email_Doner.TabIndex = 35;
            this.LB_Email_Doner.Text = "Email:";
            // 
            // LB_ContractNumber_Doners
            // 
            this.LB_ContractNumber_Doners.AutoSize = true;
            this.LB_ContractNumber_Doners.Location = new System.Drawing.Point(25, 335);
            this.LB_ContractNumber_Doners.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_ContractNumber_Doners.Name = "LB_ContractNumber_Doners";
            this.LB_ContractNumber_Doners.Size = new System.Drawing.Size(106, 16);
            this.LB_ContractNumber_Doners.TabIndex = 34;
            this.LB_ContractNumber_Doners.Text = "Contact Number:";
            // 
            // LB_FirstName_Doner
            // 
            this.LB_FirstName_Doner.AutoSize = true;
            this.LB_FirstName_Doner.Location = new System.Drawing.Point(25, 283);
            this.LB_FirstName_Doner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_FirstName_Doner.Name = "LB_FirstName_Doner";
            this.LB_FirstName_Doner.Size = new System.Drawing.Size(87, 16);
            this.LB_FirstName_Doner.TabIndex = 33;
            this.LB_FirstName_Doner.Text = "Doner Name:";
            // 
            // dataGridView_Doners
            // 
            this.dataGridView_Doners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Doners.Location = new System.Drawing.Point(24, 53);
            this.dataGridView_Doners.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Doners.Name = "dataGridView_Doners";
            this.dataGridView_Doners.RowTemplate.Height = 24;
            this.dataGridView_Doners.Size = new System.Drawing.Size(1160, 222);
            this.dataGridView_Doners.TabIndex = 32;
            // 
            // TxtBx_Search_Doners
            // 
            this.TxtBx_Search_Doners.Location = new System.Drawing.Point(151, 19);
            this.TxtBx_Search_Doners.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBx_Search_Doners.Name = "TxtBx_Search_Doners";
            this.TxtBx_Search_Doners.Size = new System.Drawing.Size(311, 22);
            this.TxtBx_Search_Doners.TabIndex = 29;
            // 
            // LB_Search_Doners
            // 
            this.LB_Search_Doners.AutoSize = true;
            this.LB_Search_Doners.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Search_Doners.Location = new System.Drawing.Point(33, 15);
            this.LB_Search_Doners.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Search_Doners.Name = "LB_Search_Doners";
            this.LB_Search_Doners.Size = new System.Drawing.Size(82, 24);
            this.LB_Search_Doners.TabIndex = 28;
            this.LB_Search_Doners.Text = "Search:";
            // 
            // Bnt_Refresh_Donations
            // 
            this.Bnt_Refresh_Donations.BackgroundImage = global::CMPG223_Group4_Project.Properties.Resources.Refresh_Icon;
            this.Bnt_Refresh_Donations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bnt_Refresh_Donations.Location = new System.Drawing.Point(7, 140);
            this.Bnt_Refresh_Donations.Name = "Bnt_Refresh_Donations";
            this.Bnt_Refresh_Donations.Size = new System.Drawing.Size(119, 36);
            this.Bnt_Refresh_Donations.TabIndex = 10;
            this.Bnt_Refresh_Donations.UseVisualStyleBackColor = true;
            // 
            // PciBx_Doners
            // 
            this.PciBx_Doners.BackgroundImage = global::CMPG223_Group4_Project.Properties.Resources.Doners_Icon;
            this.PciBx_Doners.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PciBx_Doners.Location = new System.Drawing.Point(632, 283);
            this.PciBx_Doners.Name = "PciBx_Doners";
            this.PciBx_Doners.Size = new System.Drawing.Size(380, 212);
            this.PciBx_Doners.TabIndex = 53;
            this.PciBx_Doners.TabStop = false;
            // 
            // Bnt_Clear_Doners
            // 
            this.Bnt_Clear_Doners.BackgroundImage = global::CMPG223_Group4_Project.Properties.Resources.Clear_Icon;
            this.Bnt_Clear_Doners.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bnt_Clear_Doners.Location = new System.Drawing.Point(1019, 17);
            this.Bnt_Clear_Doners.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_Clear_Doners.Name = "Bnt_Clear_Doners";
            this.Bnt_Clear_Doners.Size = new System.Drawing.Size(165, 28);
            this.Bnt_Clear_Doners.TabIndex = 31;
            this.Bnt_Clear_Doners.UseVisualStyleBackColor = true;
            // 
            // Bnt_Search_Doners
            // 
            this.Bnt_Search_Doners.BackgroundImage = global::CMPG223_Group4_Project.Properties.Resources.Magnifying_glass;
            this.Bnt_Search_Doners.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bnt_Search_Doners.Location = new System.Drawing.Point(815, 17);
            this.Bnt_Search_Doners.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_Search_Doners.Name = "Bnt_Search_Doners";
            this.Bnt_Search_Doners.Size = new System.Drawing.Size(165, 28);
            this.Bnt_Search_Doners.TabIndex = 30;
            this.Bnt_Search_Doners.UseVisualStyleBackColor = true;
            // 
            // Bnt_Close_Donations
            // 
            this.Bnt_Close_Donations.BackColor = System.Drawing.Color.Red;
            this.Bnt_Close_Donations.Location = new System.Drawing.Point(1002, 141);
            this.Bnt_Close_Donations.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_Close_Donations.Name = "Bnt_Close_Donations";
            this.Bnt_Close_Donations.Size = new System.Drawing.Size(165, 36);
            this.Bnt_Close_Donations.TabIndex = 53;
            this.Bnt_Close_Donations.Text = "Close";
            this.Bnt_Close_Donations.UseVisualStyleBackColor = false;
            // 
            // EndowmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 581);
            this.Controls.Add(this.TabControl_Endowments);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EndowmentsForm";
            this.Text = "EndowmentsForm";
            this.TabControl_Endowments.ResumeLayout(false);
            this.Tab_Donations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Textbook)).EndInit();
            this.TabControl_Doners.ResumeLayout(false);
            this.TabControl_Doners.PerformLayout();
            this.GB_PastDonations_Donations.ResumeLayout(false);
            this.GB_DonerDonations_Donations.ResumeLayout(false);
            this.GB_DonerDonations_Donations.PerformLayout();
            this.GB_Maintenance_Donations.ResumeLayout(false);
            this.GB_Maintenance_Donations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_SelectedIDDonations_Donations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Doners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PciBx_Doners)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl_Endowments;
        private System.Windows.Forms.TabPage Tab_Donations;
        private System.Windows.Forms.TabPage TabControl_Doners;
        private System.Windows.Forms.DataGridView DataGrid_Textbook;
        private System.Windows.Forms.Button Bnt_Refresh_Donations;
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
        private System.Windows.Forms.Button Bnt_Clear_Donations;
        private System.Windows.Forms.Button Bnt_Save_Donations;
        private System.Windows.Forms.GroupBox GB_Maintenance_Donations;
        private System.Windows.Forms.Button Bnt_Update_Donations;
        private System.Windows.Forms.Button Bnt_Delete_Donations;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_DonationID_Donations;
        private System.Windows.Forms.Label LB_DonationID_Donations;
        private System.Windows.Forms.DataGridView dataGrid_SelectedIDDonations_Donations;
        private System.Windows.Forms.PictureBox PciBx_Doners;
        private System.Windows.Forms.Button Bnt_Close_Doner;
        private System.Windows.Forms.Button Bnt_Delete_Doner;
        private System.Windows.Forms.Button Bnt_Update_Doner;
        private System.Windows.Forms.Button Bnt_New_Doner;
        private System.Windows.Forms.TextBox Txt_Email_Doner;
        private System.Windows.Forms.TextBox Txt_ContactNumber_Doner;
        private System.Windows.Forms.TextBox Txt_FirstName_Doner;
        private System.Windows.Forms.Label LB_Email_Doner;
        private System.Windows.Forms.Label LB_ContractNumber_Doners;
        private System.Windows.Forms.Label LB_FirstName_Doner;
        private System.Windows.Forms.DataGridView dataGridView_Doners;
        private System.Windows.Forms.Button Bnt_Clear_Doners;
        private System.Windows.Forms.Button Bnt_Search_Doners;
        private System.Windows.Forms.TextBox TxtBx_Search_Doners;
        private System.Windows.Forms.Label LB_Search_Doners;
        private System.Windows.Forms.Button Bnt_Close_Donations;
    }
}