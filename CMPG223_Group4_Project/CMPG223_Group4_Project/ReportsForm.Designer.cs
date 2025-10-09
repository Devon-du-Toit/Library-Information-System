namespace CMPG223_Group4_Project
{
    partial class ReportsForm
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
            this.GB_Reports_Reports = new System.Windows.Forms.GroupBox();
            this.RB_BorrowedBook_Reports = new System.Windows.Forms.RadioButton();
            this.RB_Borrowers_Reports = new System.Windows.Forms.RadioButton();
            this.RB_Textbooks_Reports = new System.Windows.Forms.RadioButton();
            this.RB_LibaryStaff_Reports = new System.Windows.Forms.RadioButton();
            this.RB_Dontions_Reports = new System.Windows.Forms.RadioButton();
            this.RB_Doners_Reports = new System.Windows.Forms.RadioButton();
            this.RB_Authors_Reports = new System.Windows.Forms.RadioButton();
            this.RB_Subjects_Reports = new System.Windows.Forms.RadioButton();
            this.GB_Filters_Reports = new System.Windows.Forms.GroupBox();
            this.CB_TextBookTitle_Reports = new System.Windows.Forms.ComboBox();
            this.CB_Borrower_Reports = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_To_Reports = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_From_Reports = new System.Windows.Forms.DateTimePicker();
            this.LB_TextBookTitle_Reports = new System.Windows.Forms.Label();
            this.LB_Borrower_Reports = new System.Windows.Forms.Label();
            this.LB_DateTo_Report = new System.Windows.Forms.Label();
            this.LB_DateFrom_Reports = new System.Windows.Forms.Label();
            this.Bnt_Clear_Reports = new System.Windows.Forms.Button();
            this.Bnt_Apply_Reports = new System.Windows.Forms.Button();
            this.GB_Preview_Reports = new System.Windows.Forms.GroupBox();
            this.dataGridView_Reports = new System.Windows.Forms.DataGridView();
            this.Bnt_Print_Reports = new System.Windows.Forms.Button();
            this.Bnt_Export_Reports = new System.Windows.Forms.Button();
            this.Bnt_Close_Reports = new System.Windows.Forms.Button();
            this.GB_Reports_Reports.SuspendLayout();
            this.GB_Filters_Reports.SuspendLayout();
            this.GB_Preview_Reports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Reports)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_Reports_Reports
            // 
            this.GB_Reports_Reports.Controls.Add(this.RB_BorrowedBook_Reports);
            this.GB_Reports_Reports.Controls.Add(this.RB_Borrowers_Reports);
            this.GB_Reports_Reports.Controls.Add(this.RB_Textbooks_Reports);
            this.GB_Reports_Reports.Controls.Add(this.RB_LibaryStaff_Reports);
            this.GB_Reports_Reports.Controls.Add(this.RB_Dontions_Reports);
            this.GB_Reports_Reports.Controls.Add(this.RB_Doners_Reports);
            this.GB_Reports_Reports.Controls.Add(this.RB_Authors_Reports);
            this.GB_Reports_Reports.Controls.Add(this.RB_Subjects_Reports);
            this.GB_Reports_Reports.Location = new System.Drawing.Point(9, 10);
            this.GB_Reports_Reports.Margin = new System.Windows.Forms.Padding(2);
            this.GB_Reports_Reports.Name = "GB_Reports_Reports";
            this.GB_Reports_Reports.Padding = new System.Windows.Forms.Padding(2);
            this.GB_Reports_Reports.Size = new System.Drawing.Size(185, 362);
            this.GB_Reports_Reports.TabIndex = 0;
            this.GB_Reports_Reports.TabStop = false;
            this.GB_Reports_Reports.Text = "Available Reports";
            // 
            // RB_BorrowedBook_Reports
            // 
            this.RB_BorrowedBook_Reports.AutoSize = true;
            this.RB_BorrowedBook_Reports.Location = new System.Drawing.Point(4, 17);
            this.RB_BorrowedBook_Reports.Margin = new System.Windows.Forms.Padding(2);
            this.RB_BorrowedBook_Reports.Name = "RB_BorrowedBook_Reports";
            this.RB_BorrowedBook_Reports.Size = new System.Drawing.Size(138, 17);
            this.RB_BorrowedBook_Reports.TabIndex = 36;
            this.RB_BorrowedBook_Reports.TabStop = true;
            this.RB_BorrowedBook_Reports.Text = "Borrowed Books Report";
            this.RB_BorrowedBook_Reports.UseVisualStyleBackColor = true;
            this.RB_BorrowedBook_Reports.CheckedChanged += new System.EventHandler(this.RB_BorrowedBook_Reports_CheckedChanged);
            // 
            // RB_Borrowers_Reports
            // 
            this.RB_Borrowers_Reports.AutoSize = true;
            this.RB_Borrowers_Reports.Location = new System.Drawing.Point(4, 47);
            this.RB_Borrowers_Reports.Margin = new System.Windows.Forms.Padding(2);
            this.RB_Borrowers_Reports.Name = "RB_Borrowers_Reports";
            this.RB_Borrowers_Reports.Size = new System.Drawing.Size(107, 17);
            this.RB_Borrowers_Reports.TabIndex = 35;
            this.RB_Borrowers_Reports.TabStop = true;
            this.RB_Borrowers_Reports.Text = "Borrowers Report";
            this.RB_Borrowers_Reports.UseVisualStyleBackColor = true;
            this.RB_Borrowers_Reports.CheckedChanged += new System.EventHandler(this.RB_Borrowers_Reports_CheckedChanged);
            // 
            // RB_Textbooks_Reports
            // 
            this.RB_Textbooks_Reports.AutoSize = true;
            this.RB_Textbooks_Reports.Location = new System.Drawing.Point(4, 212);
            this.RB_Textbooks_Reports.Margin = new System.Windows.Forms.Padding(2);
            this.RB_Textbooks_Reports.Name = "RB_Textbooks_Reports";
            this.RB_Textbooks_Reports.Size = new System.Drawing.Size(110, 17);
            this.RB_Textbooks_Reports.TabIndex = 34;
            this.RB_Textbooks_Reports.TabStop = true;
            this.RB_Textbooks_Reports.Text = "Textbooks Report";
            this.RB_Textbooks_Reports.UseVisualStyleBackColor = true;
            this.RB_Textbooks_Reports.CheckedChanged += new System.EventHandler(this.RB_Textbooks_Reports_CheckedChanged);
            // 
            // RB_LibaryStaff_Reports
            // 
            this.RB_LibaryStaff_Reports.AutoSize = true;
            this.RB_LibaryStaff_Reports.Location = new System.Drawing.Point(4, 144);
            this.RB_LibaryStaff_Reports.Margin = new System.Windows.Forms.Padding(2);
            this.RB_LibaryStaff_Reports.Name = "RB_LibaryStaff_Reports";
            this.RB_LibaryStaff_Reports.Size = new System.Drawing.Size(82, 17);
            this.RB_LibaryStaff_Reports.TabIndex = 33;
            this.RB_LibaryStaff_Reports.TabStop = true;
            this.RB_LibaryStaff_Reports.Text = "Staff Report";
            this.RB_LibaryStaff_Reports.UseVisualStyleBackColor = true;
            this.RB_LibaryStaff_Reports.CheckedChanged += new System.EventHandler(this.RB_LibaryStaff_Reports_CheckedChanged);
            // 
            // RB_Dontions_Reports
            // 
            this.RB_Dontions_Reports.AutoSize = true;
            this.RB_Dontions_Reports.Location = new System.Drawing.Point(4, 80);
            this.RB_Dontions_Reports.Margin = new System.Windows.Forms.Padding(2);
            this.RB_Dontions_Reports.Name = "RB_Dontions_Reports";
            this.RB_Dontions_Reports.Size = new System.Drawing.Size(108, 17);
            this.RB_Dontions_Reports.TabIndex = 32;
            this.RB_Dontions_Reports.TabStop = true;
            this.RB_Dontions_Reports.Text = "Donations Report";
            this.RB_Dontions_Reports.UseVisualStyleBackColor = true;
            this.RB_Dontions_Reports.CheckedChanged += new System.EventHandler(this.RB_Dontions_Reports_CheckedChanged);
            // 
            // RB_Doners_Reports
            // 
            this.RB_Doners_Reports.AutoSize = true;
            this.RB_Doners_Reports.Location = new System.Drawing.Point(4, 112);
            this.RB_Doners_Reports.Margin = new System.Windows.Forms.Padding(2);
            this.RB_Doners_Reports.Name = "RB_Doners_Reports";
            this.RB_Doners_Reports.Size = new System.Drawing.Size(94, 17);
            this.RB_Doners_Reports.TabIndex = 31;
            this.RB_Doners_Reports.TabStop = true;
            this.RB_Doners_Reports.Text = "Donors Report";
            this.RB_Doners_Reports.UseVisualStyleBackColor = true;
            this.RB_Doners_Reports.CheckedChanged += new System.EventHandler(this.RB_Doners_Reports_CheckedChanged);
            // 
            // RB_Authors_Reports
            // 
            this.RB_Authors_Reports.AutoSize = true;
            this.RB_Authors_Reports.Location = new System.Drawing.Point(4, 178);
            this.RB_Authors_Reports.Margin = new System.Windows.Forms.Padding(2);
            this.RB_Authors_Reports.Name = "RB_Authors_Reports";
            this.RB_Authors_Reports.Size = new System.Drawing.Size(144, 17);
            this.RB_Authors_Reports.TabIndex = 30;
            this.RB_Authors_Reports.TabStop = true;
            this.RB_Authors_Reports.Text = "Textbook Authors Report";
            this.RB_Authors_Reports.UseVisualStyleBackColor = true;
            this.RB_Authors_Reports.CheckedChanged += new System.EventHandler(this.RB_Authors_Reports_CheckedChanged);
            // 
            // RB_Subjects_Reports
            // 
            this.RB_Subjects_Reports.AutoSize = true;
            this.RB_Subjects_Reports.Location = new System.Drawing.Point(4, 249);
            this.RB_Subjects_Reports.Margin = new System.Windows.Forms.Padding(2);
            this.RB_Subjects_Reports.Name = "RB_Subjects_Reports";
            this.RB_Subjects_Reports.Size = new System.Drawing.Size(149, 17);
            this.RB_Subjects_Reports.TabIndex = 29;
            this.RB_Subjects_Reports.TabStop = true;
            this.RB_Subjects_Reports.Text = "Textbook Subjects Report";
            this.RB_Subjects_Reports.UseVisualStyleBackColor = true;
            this.RB_Subjects_Reports.CheckedChanged += new System.EventHandler(this.RB_Subjects_Reports_CheckedChanged);
            // 
            // GB_Filters_Reports
            // 
            this.GB_Filters_Reports.Controls.Add(this.CB_TextBookTitle_Reports);
            this.GB_Filters_Reports.Controls.Add(this.CB_Borrower_Reports);
            this.GB_Filters_Reports.Controls.Add(this.dateTimePicker_To_Reports);
            this.GB_Filters_Reports.Controls.Add(this.dateTimePicker_From_Reports);
            this.GB_Filters_Reports.Controls.Add(this.LB_TextBookTitle_Reports);
            this.GB_Filters_Reports.Controls.Add(this.LB_Borrower_Reports);
            this.GB_Filters_Reports.Controls.Add(this.LB_DateTo_Report);
            this.GB_Filters_Reports.Controls.Add(this.LB_DateFrom_Reports);
            this.GB_Filters_Reports.Controls.Add(this.Bnt_Clear_Reports);
            this.GB_Filters_Reports.Controls.Add(this.Bnt_Apply_Reports);
            this.GB_Filters_Reports.Location = new System.Drawing.Point(206, 10);
            this.GB_Filters_Reports.Margin = new System.Windows.Forms.Padding(2);
            this.GB_Filters_Reports.Name = "GB_Filters_Reports";
            this.GB_Filters_Reports.Padding = new System.Windows.Forms.Padding(2);
            this.GB_Filters_Reports.Size = new System.Drawing.Size(516, 182);
            this.GB_Filters_Reports.TabIndex = 1;
            this.GB_Filters_Reports.TabStop = false;
            this.GB_Filters_Reports.Text = "Filters";
            this.GB_Filters_Reports.Enter += new System.EventHandler(this.GB_Filters_Reports_Enter);
            // 
            // CB_TextBookTitle_Reports
            // 
            this.CB_TextBookTitle_Reports.FormattingEnabled = true;
            this.CB_TextBookTitle_Reports.Location = new System.Drawing.Point(104, 107);
            this.CB_TextBookTitle_Reports.Margin = new System.Windows.Forms.Padding(2);
            this.CB_TextBookTitle_Reports.Name = "CB_TextBookTitle_Reports";
            this.CB_TextBookTitle_Reports.Size = new System.Drawing.Size(153, 21);
            this.CB_TextBookTitle_Reports.TabIndex = 36;
            this.CB_TextBookTitle_Reports.SelectedIndexChanged += new System.EventHandler(this.CB_TextBookTitle_Reports_SelectedIndexChanged);
            // 
            // CB_Borrower_Reports
            // 
            this.CB_Borrower_Reports.FormattingEnabled = true;
            this.CB_Borrower_Reports.Location = new System.Drawing.Point(104, 65);
            this.CB_Borrower_Reports.Margin = new System.Windows.Forms.Padding(2);
            this.CB_Borrower_Reports.Name = "CB_Borrower_Reports";
            this.CB_Borrower_Reports.Size = new System.Drawing.Size(153, 21);
            this.CB_Borrower_Reports.TabIndex = 35;
            this.CB_Borrower_Reports.SelectedIndexChanged += new System.EventHandler(this.CB_Borrower_Reports_SelectedIndexChanged);
            // 
            // dateTimePicker_To_Reports
            // 
            this.dateTimePicker_To_Reports.Location = new System.Drawing.Point(304, 26);
            this.dateTimePicker_To_Reports.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_To_Reports.Name = "dateTimePicker_To_Reports";
            this.dateTimePicker_To_Reports.Size = new System.Drawing.Size(177, 20);
            this.dateTimePicker_To_Reports.TabIndex = 34;
            // 
            // dateTimePicker_From_Reports
            // 
            this.dateTimePicker_From_Reports.Location = new System.Drawing.Point(74, 25);
            this.dateTimePicker_From_Reports.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_From_Reports.Name = "dateTimePicker_From_Reports";
            this.dateTimePicker_From_Reports.Size = new System.Drawing.Size(177, 20);
            this.dateTimePicker_From_Reports.TabIndex = 33;
            // 
            // LB_TextBookTitle_Reports
            // 
            this.LB_TextBookTitle_Reports.AutoSize = true;
            this.LB_TextBookTitle_Reports.Location = new System.Drawing.Point(15, 114);
            this.LB_TextBookTitle_Reports.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_TextBookTitle_Reports.Name = "LB_TextBookTitle_Reports";
            this.LB_TextBookTitle_Reports.Size = new System.Drawing.Size(78, 13);
            this.LB_TextBookTitle_Reports.TabIndex = 32;
            this.LB_TextBookTitle_Reports.Text = "Textbook Title:";
            // 
            // LB_Borrower_Reports
            // 
            this.LB_Borrower_Reports.AutoSize = true;
            this.LB_Borrower_Reports.Location = new System.Drawing.Point(15, 72);
            this.LB_Borrower_Reports.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Borrower_Reports.Name = "LB_Borrower_Reports";
            this.LB_Borrower_Reports.Size = new System.Drawing.Size(92, 13);
            this.LB_Borrower_Reports.TabIndex = 31;
            this.LB_Borrower_Reports.Text = "Student Borrower:";
            // 
            // LB_DateTo_Report
            // 
            this.LB_DateTo_Report.AutoSize = true;
            this.LB_DateTo_Report.Location = new System.Drawing.Point(255, 30);
            this.LB_DateTo_Report.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_DateTo_Report.Name = "LB_DateTo_Report";
            this.LB_DateTo_Report.Size = new System.Drawing.Size(49, 13);
            this.LB_DateTo_Report.TabIndex = 30;
            this.LB_DateTo_Report.Text = "Date To:";
            // 
            // LB_DateFrom_Reports
            // 
            this.LB_DateFrom_Reports.AutoSize = true;
            this.LB_DateFrom_Reports.Location = new System.Drawing.Point(15, 32);
            this.LB_DateFrom_Reports.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_DateFrom_Reports.Name = "LB_DateFrom_Reports";
            this.LB_DateFrom_Reports.Size = new System.Drawing.Size(59, 13);
            this.LB_DateFrom_Reports.TabIndex = 29;
            this.LB_DateFrom_Reports.Text = "Date From:";
            // 
            // Bnt_Clear_Reports
            // 
            this.Bnt_Clear_Reports.BackColor = System.Drawing.Color.LightGray;
            this.Bnt_Clear_Reports.Location = new System.Drawing.Point(257, 152);
            this.Bnt_Clear_Reports.Name = "Bnt_Clear_Reports";
            this.Bnt_Clear_Reports.Size = new System.Drawing.Size(124, 23);
            this.Bnt_Clear_Reports.TabIndex = 28;
            this.Bnt_Clear_Reports.Text = "Clear";
            this.Bnt_Clear_Reports.UseVisualStyleBackColor = false;
            this.Bnt_Clear_Reports.Click += new System.EventHandler(this.Bnt_Clear_Reports_Click);
            // 
            // Bnt_Apply_Reports
            // 
            this.Bnt_Apply_Reports.BackColor = System.Drawing.Color.LawnGreen;
            this.Bnt_Apply_Reports.Location = new System.Drawing.Point(387, 152);
            this.Bnt_Apply_Reports.Name = "Bnt_Apply_Reports";
            this.Bnt_Apply_Reports.Size = new System.Drawing.Size(124, 23);
            this.Bnt_Apply_Reports.TabIndex = 27;
            this.Bnt_Apply_Reports.Text = "Apply";
            this.Bnt_Apply_Reports.UseVisualStyleBackColor = false;
            this.Bnt_Apply_Reports.Click += new System.EventHandler(this.Bnt_Apply_Reports_Click);
            // 
            // GB_Preview_Reports
            // 
            this.GB_Preview_Reports.Controls.Add(this.dataGridView_Reports);
            this.GB_Preview_Reports.Location = new System.Drawing.Point(206, 197);
            this.GB_Preview_Reports.Margin = new System.Windows.Forms.Padding(2);
            this.GB_Preview_Reports.Name = "GB_Preview_Reports";
            this.GB_Preview_Reports.Padding = new System.Windows.Forms.Padding(2);
            this.GB_Preview_Reports.Size = new System.Drawing.Size(516, 146);
            this.GB_Preview_Reports.TabIndex = 2;
            this.GB_Preview_Reports.TabStop = false;
            this.GB_Preview_Reports.Text = "Preview";
            // 
            // dataGridView_Reports
            // 
            this.dataGridView_Reports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Reports.Location = new System.Drawing.Point(18, 17);
            this.dataGridView_Reports.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Reports.Name = "dataGridView_Reports";
            this.dataGridView_Reports.RowHeadersWidth = 51;
            this.dataGridView_Reports.RowTemplate.Height = 24;
            this.dataGridView_Reports.Size = new System.Drawing.Size(484, 115);
            this.dataGridView_Reports.TabIndex = 0;
            // 
            // Bnt_Print_Reports
            // 
            this.Bnt_Print_Reports.BackColor = System.Drawing.Color.Lavender;
            this.Bnt_Print_Reports.Location = new System.Drawing.Point(483, 349);
            this.Bnt_Print_Reports.Name = "Bnt_Print_Reports";
            this.Bnt_Print_Reports.Size = new System.Drawing.Size(124, 23);
            this.Bnt_Print_Reports.TabIndex = 26;
            this.Bnt_Print_Reports.Text = "Print";
            this.Bnt_Print_Reports.UseVisualStyleBackColor = false;
            this.Bnt_Print_Reports.Click += new System.EventHandler(this.Bnt_Print_Reports_Click);
            // 
            // Bnt_Export_Reports
            // 
            this.Bnt_Export_Reports.BackColor = System.Drawing.Color.Lavender;
            this.Bnt_Export_Reports.Location = new System.Drawing.Point(353, 349);
            this.Bnt_Export_Reports.Name = "Bnt_Export_Reports";
            this.Bnt_Export_Reports.Size = new System.Drawing.Size(124, 23);
            this.Bnt_Export_Reports.TabIndex = 27;
            this.Bnt_Export_Reports.Text = "Export Data";
            this.Bnt_Export_Reports.UseVisualStyleBackColor = false;
            this.Bnt_Export_Reports.Click += new System.EventHandler(this.Bnt_Export_Reports_Click);
            // 
            // Bnt_Close_Reports
            // 
            this.Bnt_Close_Reports.BackColor = System.Drawing.Color.Red;
            this.Bnt_Close_Reports.Location = new System.Drawing.Point(642, 349);
            this.Bnt_Close_Reports.Name = "Bnt_Close_Reports";
            this.Bnt_Close_Reports.Size = new System.Drawing.Size(80, 23);
            this.Bnt_Close_Reports.TabIndex = 53;
            this.Bnt_Close_Reports.Text = "Close";
            this.Bnt_Close_Reports.UseVisualStyleBackColor = false;
            this.Bnt_Close_Reports.Click += new System.EventHandler(this.Bnt_Close_Reports_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(731, 382);
            this.Controls.Add(this.Bnt_Close_Reports);
            this.Controls.Add(this.Bnt_Export_Reports);
            this.Controls.Add(this.Bnt_Print_Reports);
            this.Controls.Add(this.GB_Preview_Reports);
            this.Controls.Add(this.GB_Filters_Reports);
            this.Controls.Add(this.GB_Reports_Reports);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.GB_Reports_Reports.ResumeLayout(false);
            this.GB_Reports_Reports.PerformLayout();
            this.GB_Filters_Reports.ResumeLayout(false);
            this.GB_Filters_Reports.PerformLayout();
            this.GB_Preview_Reports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Reports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Reports_Reports;
        private System.Windows.Forms.GroupBox GB_Filters_Reports;
        private System.Windows.Forms.GroupBox GB_Preview_Reports;
        private System.Windows.Forms.RadioButton RB_Textbooks_Reports;
        private System.Windows.Forms.RadioButton RB_LibaryStaff_Reports;
        private System.Windows.Forms.RadioButton RB_Dontions_Reports;
        private System.Windows.Forms.RadioButton RB_Doners_Reports;
        private System.Windows.Forms.RadioButton RB_Authors_Reports;
        private System.Windows.Forms.RadioButton RB_Subjects_Reports;
        private System.Windows.Forms.Label LB_TextBookTitle_Reports;
        private System.Windows.Forms.Label LB_Borrower_Reports;
        private System.Windows.Forms.Label LB_DateTo_Report;
        private System.Windows.Forms.Label LB_DateFrom_Reports;
        private System.Windows.Forms.Button Bnt_Clear_Reports;
        private System.Windows.Forms.Button Bnt_Apply_Reports;
        private System.Windows.Forms.DataGridView dataGridView_Reports;
        private System.Windows.Forms.Button Bnt_Print_Reports;
        private System.Windows.Forms.Button Bnt_Export_Reports;
        private System.Windows.Forms.RadioButton RB_Borrowers_Reports;
        private System.Windows.Forms.RadioButton RB_BorrowedBook_Reports;
        private System.Windows.Forms.ComboBox CB_TextBookTitle_Reports;
        private System.Windows.Forms.ComboBox CB_Borrower_Reports;
        private System.Windows.Forms.DateTimePicker dateTimePicker_To_Reports;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From_Reports;
        private System.Windows.Forms.Button Bnt_Close_Reports;
    }
}