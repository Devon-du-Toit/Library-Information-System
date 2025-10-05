namespace CMPG223_Group4_Project
{
    partial class ReadersForm
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
            this.TabControll_Readers = new System.Windows.Forms.TabControl();
            this.Tab_Borrowers = new System.Windows.Forms.TabPage();
            this.PicBx_Readers = new System.Windows.Forms.PictureBox();
            this.Bnt_Close_Borrowers = new System.Windows.Forms.Button();
            this.Bnt_Delete_Borrowers = new System.Windows.Forms.Button();
            this.Bnt_Update_Borrowers = new System.Windows.Forms.Button();
            this.Bnt_New_Borrowers = new System.Windows.Forms.Button();
            this.Txt_ContactNumber_Borrowers = new System.Windows.Forms.TextBox();
            this.Txt_Email_Borrowers = new System.Windows.Forms.TextBox();
            this.Txt_LastName_Borrowers = new System.Windows.Forms.TextBox();
            this.Txt_FirstName_Borrowers = new System.Windows.Forms.TextBox();
            this.LB_ContactNumber_Borrowers = new System.Windows.Forms.Label();
            this.LB_Email_Borrowers = new System.Windows.Forms.Label();
            this.LB_LastName_Borrowers = new System.Windows.Forms.Label();
            this.LB_FirstName_Borrowers = new System.Windows.Forms.Label();
            this.DataGrid_Borrowers = new System.Windows.Forms.DataGridView();
            this.Bnt_Clear_Borrowers = new System.Windows.Forms.Button();
            this.Bnt_Search_Borrowers = new System.Windows.Forms.Button();
            this.TxtBx_Search_Borrowers = new System.Windows.Forms.TextBox();
            this.LB_Search_Borrowers = new System.Windows.Forms.Label();
            this.TabControl_BorrwedBooks = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Bnt_Close_Borrowed = new System.Windows.Forms.Button();
            this.Bnt_Return_Borrowed = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.LB_RetunedDate_Borrowed = new System.Windows.Forms.Label();
            this.Bnt_RefreshReturn_Borrowed = new System.Windows.Forms.Button();
            this.dataGridView_ReturnSelection = new System.Windows.Forms.DataGridView();
            this.GB_BookOut = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_Duedate_Borrowed = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Bookout_Borrowed = new System.Windows.Forms.DateTimePicker();
            this.LB_DBISBN_Borrowed = new System.Windows.Forms.Label();
            this.CB_TextBookName_Borrowed = new System.Windows.Forms.ComboBox();
            this.Bnt_Clear_Donations = new System.Windows.Forms.Button();
            this.Bnt_Save_Donations = new System.Windows.Forms.Button();
            this.LB_DueDate_Borrowed = new System.Windows.Forms.Label();
            this.LB_DateOut_Borrowed = new System.Windows.Forms.Label();
            this.LB_ISBN_Borrowed = new System.Windows.Forms.Label();
            this.LB_TextbookName_Borrowed = new System.Windows.Forms.Label();
            this.GB_TextBookStatus_Borrowed = new System.Windows.Forms.GroupBox();
            this.DataGrid_Borrowed = new System.Windows.Forms.DataGridView();
            this.Bnt_Refresh_Borrowed = new System.Windows.Forms.Button();
            this.LB_BorrowerName_Borrowed = new System.Windows.Forms.Label();
            this.CB_NameLastName_Borrowed = new System.Windows.Forms.ComboBox();
            this.CB_ReturnTextbook_Borrowed = new System.Windows.Forms.ComboBox();
            this.LB_ReturnTextbookName_Borrowed = new System.Windows.Forms.Label();
            this.TabControll_Readers.SuspendLayout();
            this.Tab_Borrowers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_Readers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Borrowers)).BeginInit();
            this.TabControl_BorrwedBooks.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReturnSelection)).BeginInit();
            this.GB_BookOut.SuspendLayout();
            this.GB_TextBookStatus_Borrowed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Borrowed)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControll_Readers
            // 
            this.TabControll_Readers.Controls.Add(this.Tab_Borrowers);
            this.TabControll_Readers.Controls.Add(this.TabControl_BorrwedBooks);
            this.TabControll_Readers.Location = new System.Drawing.Point(12, 12);
            this.TabControll_Readers.Name = "TabControll_Readers";
            this.TabControll_Readers.SelectedIndex = 0;
            this.TabControll_Readers.Size = new System.Drawing.Size(1239, 550);
            this.TabControll_Readers.TabIndex = 0;
            // 
            // Tab_Borrowers
            // 
            this.Tab_Borrowers.BackColor = System.Drawing.Color.PeachPuff;
            this.Tab_Borrowers.Controls.Add(this.PicBx_Readers);
            this.Tab_Borrowers.Controls.Add(this.Bnt_Close_Borrowers);
            this.Tab_Borrowers.Controls.Add(this.Bnt_Delete_Borrowers);
            this.Tab_Borrowers.Controls.Add(this.Bnt_Update_Borrowers);
            this.Tab_Borrowers.Controls.Add(this.Bnt_New_Borrowers);
            this.Tab_Borrowers.Controls.Add(this.Txt_ContactNumber_Borrowers);
            this.Tab_Borrowers.Controls.Add(this.Txt_Email_Borrowers);
            this.Tab_Borrowers.Controls.Add(this.Txt_LastName_Borrowers);
            this.Tab_Borrowers.Controls.Add(this.Txt_FirstName_Borrowers);
            this.Tab_Borrowers.Controls.Add(this.LB_ContactNumber_Borrowers);
            this.Tab_Borrowers.Controls.Add(this.LB_Email_Borrowers);
            this.Tab_Borrowers.Controls.Add(this.LB_LastName_Borrowers);
            this.Tab_Borrowers.Controls.Add(this.LB_FirstName_Borrowers);
            this.Tab_Borrowers.Controls.Add(this.DataGrid_Borrowers);
            this.Tab_Borrowers.Controls.Add(this.Bnt_Clear_Borrowers);
            this.Tab_Borrowers.Controls.Add(this.Bnt_Search_Borrowers);
            this.Tab_Borrowers.Controls.Add(this.TxtBx_Search_Borrowers);
            this.Tab_Borrowers.Controls.Add(this.LB_Search_Borrowers);
            this.Tab_Borrowers.Location = new System.Drawing.Point(4, 25);
            this.Tab_Borrowers.Name = "Tab_Borrowers";
            this.Tab_Borrowers.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Borrowers.Size = new System.Drawing.Size(1231, 521);
            this.Tab_Borrowers.TabIndex = 0;
            this.Tab_Borrowers.Text = "Students - Borrowers";
            // 
            // PicBx_Readers
            // 
            this.PicBx_Readers.BackgroundImage = global::CMPG223_Group4_Project.Properties.Resources.Readers_Icon;
            this.PicBx_Readers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBx_Readers.Location = new System.Drawing.Point(552, 287);
            this.PicBx_Readers.Name = "PicBx_Readers";
            this.PicBx_Readers.Size = new System.Drawing.Size(448, 213);
            this.PicBx_Readers.TabIndex = 69;
            this.PicBx_Readers.TabStop = false;
            // 
            // Bnt_Close_Borrowers
            // 
            this.Bnt_Close_Borrowers.BackColor = System.Drawing.Color.Red;
            this.Bnt_Close_Borrowers.Location = new System.Drawing.Point(1030, 472);
            this.Bnt_Close_Borrowers.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_Close_Borrowers.Name = "Bnt_Close_Borrowers";
            this.Bnt_Close_Borrowers.Size = new System.Drawing.Size(165, 28);
            this.Bnt_Close_Borrowers.TabIndex = 68;
            this.Bnt_Close_Borrowers.Text = "Close";
            this.Bnt_Close_Borrowers.UseVisualStyleBackColor = false;
            // 
            // Bnt_Delete_Borrowers
            // 
            this.Bnt_Delete_Borrowers.BackColor = System.Drawing.Color.Silver;
            this.Bnt_Delete_Borrowers.Location = new System.Drawing.Point(1030, 390);
            this.Bnt_Delete_Borrowers.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_Delete_Borrowers.Name = "Bnt_Delete_Borrowers";
            this.Bnt_Delete_Borrowers.Size = new System.Drawing.Size(165, 28);
            this.Bnt_Delete_Borrowers.TabIndex = 67;
            this.Bnt_Delete_Borrowers.Text = "Delete";
            this.Bnt_Delete_Borrowers.UseVisualStyleBackColor = false;
            // 
            // Bnt_Update_Borrowers
            // 
            this.Bnt_Update_Borrowers.BackColor = System.Drawing.Color.LightBlue;
            this.Bnt_Update_Borrowers.Location = new System.Drawing.Point(1030, 336);
            this.Bnt_Update_Borrowers.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_Update_Borrowers.Name = "Bnt_Update_Borrowers";
            this.Bnt_Update_Borrowers.Size = new System.Drawing.Size(165, 28);
            this.Bnt_Update_Borrowers.TabIndex = 66;
            this.Bnt_Update_Borrowers.Text = "Update";
            this.Bnt_Update_Borrowers.UseVisualStyleBackColor = false;
            // 
            // Bnt_New_Borrowers
            // 
            this.Bnt_New_Borrowers.BackColor = System.Drawing.Color.LightGreen;
            this.Bnt_New_Borrowers.Location = new System.Drawing.Point(1030, 288);
            this.Bnt_New_Borrowers.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_New_Borrowers.Name = "Bnt_New_Borrowers";
            this.Bnt_New_Borrowers.Size = new System.Drawing.Size(165, 28);
            this.Bnt_New_Borrowers.TabIndex = 65;
            this.Bnt_New_Borrowers.Text = "New";
            this.Bnt_New_Borrowers.UseVisualStyleBackColor = false;
            // 
            // Txt_ContactNumber_Borrowers
            // 
            this.Txt_ContactNumber_Borrowers.Location = new System.Drawing.Point(162, 456);
            this.Txt_ContactNumber_Borrowers.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_ContactNumber_Borrowers.Name = "Txt_ContactNumber_Borrowers";
            this.Txt_ContactNumber_Borrowers.Size = new System.Drawing.Size(311, 22);
            this.Txt_ContactNumber_Borrowers.TabIndex = 63;
            // 
            // Txt_Email_Borrowers
            // 
            this.Txt_Email_Borrowers.Location = new System.Drawing.Point(162, 399);
            this.Txt_Email_Borrowers.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Email_Borrowers.Name = "Txt_Email_Borrowers";
            this.Txt_Email_Borrowers.Size = new System.Drawing.Size(311, 22);
            this.Txt_Email_Borrowers.TabIndex = 62;
            // 
            // Txt_LastName_Borrowers
            // 
            this.Txt_LastName_Borrowers.Location = new System.Drawing.Point(162, 340);
            this.Txt_LastName_Borrowers.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_LastName_Borrowers.Name = "Txt_LastName_Borrowers";
            this.Txt_LastName_Borrowers.Size = new System.Drawing.Size(311, 22);
            this.Txt_LastName_Borrowers.TabIndex = 61;
            // 
            // Txt_FirstName_Borrowers
            // 
            this.Txt_FirstName_Borrowers.Location = new System.Drawing.Point(162, 287);
            this.Txt_FirstName_Borrowers.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_FirstName_Borrowers.Name = "Txt_FirstName_Borrowers";
            this.Txt_FirstName_Borrowers.Size = new System.Drawing.Size(311, 22);
            this.Txt_FirstName_Borrowers.TabIndex = 60;
            // 
            // LB_ContactNumber_Borrowers
            // 
            this.LB_ContactNumber_Borrowers.AutoSize = true;
            this.LB_ContactNumber_Borrowers.Location = new System.Drawing.Point(36, 459);
            this.LB_ContactNumber_Borrowers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_ContactNumber_Borrowers.Name = "LB_ContactNumber_Borrowers";
            this.LB_ContactNumber_Borrowers.Size = new System.Drawing.Size(106, 16);
            this.LB_ContactNumber_Borrowers.TabIndex = 57;
            this.LB_ContactNumber_Borrowers.Text = "Contact Number:";
            // 
            // LB_Email_Borrowers
            // 
            this.LB_Email_Borrowers.AutoSize = true;
            this.LB_Email_Borrowers.Location = new System.Drawing.Point(36, 399);
            this.LB_Email_Borrowers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Email_Borrowers.Name = "LB_Email_Borrowers";
            this.LB_Email_Borrowers.Size = new System.Drawing.Size(44, 16);
            this.LB_Email_Borrowers.TabIndex = 56;
            this.LB_Email_Borrowers.Text = "Email:";
            // 
            // LB_LastName_Borrowers
            // 
            this.LB_LastName_Borrowers.AutoSize = true;
            this.LB_LastName_Borrowers.Location = new System.Drawing.Point(36, 340);
            this.LB_LastName_Borrowers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_LastName_Borrowers.Name = "LB_LastName_Borrowers";
            this.LB_LastName_Borrowers.Size = new System.Drawing.Size(75, 16);
            this.LB_LastName_Borrowers.TabIndex = 55;
            this.LB_LastName_Borrowers.Text = "Last Name:";
            // 
            // LB_FirstName_Borrowers
            // 
            this.LB_FirstName_Borrowers.AutoSize = true;
            this.LB_FirstName_Borrowers.Location = new System.Drawing.Point(36, 288);
            this.LB_FirstName_Borrowers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_FirstName_Borrowers.Name = "LB_FirstName_Borrowers";
            this.LB_FirstName_Borrowers.Size = new System.Drawing.Size(75, 16);
            this.LB_FirstName_Borrowers.TabIndex = 54;
            this.LB_FirstName_Borrowers.Text = "First Name:";
            // 
            // DataGrid_Borrowers
            // 
            this.DataGrid_Borrowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Borrowers.Location = new System.Drawing.Point(35, 58);
            this.DataGrid_Borrowers.Margin = new System.Windows.Forms.Padding(4);
            this.DataGrid_Borrowers.Name = "DataGrid_Borrowers";
            this.DataGrid_Borrowers.RowHeadersWidth = 51;
            this.DataGrid_Borrowers.RowTemplate.Height = 24;
            this.DataGrid_Borrowers.Size = new System.Drawing.Size(1160, 222);
            this.DataGrid_Borrowers.TabIndex = 53;
            // 
            // Bnt_Clear_Borrowers
            // 
            this.Bnt_Clear_Borrowers.BackgroundImage = global::CMPG223_Group4_Project.Properties.Resources.Clear_Icon;
            this.Bnt_Clear_Borrowers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bnt_Clear_Borrowers.Location = new System.Drawing.Point(1030, 22);
            this.Bnt_Clear_Borrowers.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_Clear_Borrowers.Name = "Bnt_Clear_Borrowers";
            this.Bnt_Clear_Borrowers.Size = new System.Drawing.Size(165, 28);
            this.Bnt_Clear_Borrowers.TabIndex = 52;
            this.Bnt_Clear_Borrowers.UseVisualStyleBackColor = true;
            // 
            // Bnt_Search_Borrowers
            // 
            this.Bnt_Search_Borrowers.BackgroundImage = global::CMPG223_Group4_Project.Properties.Resources.Magnifying_glass;
            this.Bnt_Search_Borrowers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bnt_Search_Borrowers.Location = new System.Drawing.Point(826, 22);
            this.Bnt_Search_Borrowers.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_Search_Borrowers.Name = "Bnt_Search_Borrowers";
            this.Bnt_Search_Borrowers.Size = new System.Drawing.Size(165, 28);
            this.Bnt_Search_Borrowers.TabIndex = 51;
            this.Bnt_Search_Borrowers.UseVisualStyleBackColor = true;
            // 
            // TxtBx_Search_Borrowers
            // 
            this.TxtBx_Search_Borrowers.Location = new System.Drawing.Point(162, 24);
            this.TxtBx_Search_Borrowers.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBx_Search_Borrowers.Name = "TxtBx_Search_Borrowers";
            this.TxtBx_Search_Borrowers.Size = new System.Drawing.Size(311, 22);
            this.TxtBx_Search_Borrowers.TabIndex = 50;
            // 
            // LB_Search_Borrowers
            // 
            this.LB_Search_Borrowers.AutoSize = true;
            this.LB_Search_Borrowers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Search_Borrowers.Location = new System.Drawing.Point(44, 20);
            this.LB_Search_Borrowers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Search_Borrowers.Name = "LB_Search_Borrowers";
            this.LB_Search_Borrowers.Size = new System.Drawing.Size(102, 29);
            this.LB_Search_Borrowers.TabIndex = 49;
            this.LB_Search_Borrowers.Text = "Search:";
            // 
            // TabControl_BorrwedBooks
            // 
            this.TabControl_BorrwedBooks.BackColor = System.Drawing.Color.PeachPuff;
            this.TabControl_BorrwedBooks.Controls.Add(this.groupBox3);
            this.TabControl_BorrwedBooks.Controls.Add(this.GB_BookOut);
            this.TabControl_BorrwedBooks.Controls.Add(this.GB_TextBookStatus_Borrowed);
            this.TabControl_BorrwedBooks.Location = new System.Drawing.Point(4, 25);
            this.TabControl_BorrwedBooks.Name = "TabControl_BorrwedBooks";
            this.TabControl_BorrwedBooks.Padding = new System.Windows.Forms.Padding(3);
            this.TabControl_BorrwedBooks.Size = new System.Drawing.Size(1231, 521);
            this.TabControl_BorrwedBooks.TabIndex = 1;
            this.TabControl_BorrwedBooks.Text = "Borrowed - Books";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CB_ReturnTextbook_Borrowed);
            this.groupBox3.Controls.Add(this.Bnt_Close_Borrowed);
            this.groupBox3.Controls.Add(this.LB_ReturnTextbookName_Borrowed);
            this.groupBox3.Controls.Add(this.Bnt_Return_Borrowed);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.LB_RetunedDate_Borrowed);
            this.groupBox3.Controls.Add(this.Bnt_RefreshReturn_Borrowed);
            this.groupBox3.Controls.Add(this.dataGridView_ReturnSelection);
            this.groupBox3.Location = new System.Drawing.Point(626, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(599, 316);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Return Textbook";
            // 
            // Bnt_Close_Borrowed
            // 
            this.Bnt_Close_Borrowed.BackColor = System.Drawing.Color.Red;
            this.Bnt_Close_Borrowed.Location = new System.Drawing.Point(427, 281);
            this.Bnt_Close_Borrowed.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_Close_Borrowed.Name = "Bnt_Close_Borrowed";
            this.Bnt_Close_Borrowed.Size = new System.Drawing.Size(165, 28);
            this.Bnt_Close_Borrowed.TabIndex = 53;
            this.Bnt_Close_Borrowed.Text = "Close";
            this.Bnt_Close_Borrowed.UseVisualStyleBackColor = false;
            // 
            // Bnt_Return_Borrowed
            // 
            this.Bnt_Return_Borrowed.BackColor = System.Drawing.Color.Beige;
            this.Bnt_Return_Borrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bnt_Return_Borrowed.Location = new System.Drawing.Point(9, 281);
            this.Bnt_Return_Borrowed.Name = "Bnt_Return_Borrowed";
            this.Bnt_Return_Borrowed.Size = new System.Drawing.Size(116, 26);
            this.Bnt_Return_Borrowed.TabIndex = 21;
            this.Bnt_Return_Borrowed.Text = "Update";
            this.Bnt_Return_Borrowed.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(221, 224);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 23;
            // 
            // LB_RetunedDate_Borrowed
            // 
            this.LB_RetunedDate_Borrowed.AutoSize = true;
            this.LB_RetunedDate_Borrowed.Location = new System.Drawing.Point(6, 224);
            this.LB_RetunedDate_Borrowed.Name = "LB_RetunedDate_Borrowed";
            this.LB_RetunedDate_Borrowed.Size = new System.Drawing.Size(81, 16);
            this.LB_RetunedDate_Borrowed.TabIndex = 21;
            this.LB_RetunedDate_Borrowed.Text = "Date Return:";
            // 
            // Bnt_RefreshReturn_Borrowed
            // 
            this.Bnt_RefreshReturn_Borrowed.BackgroundImage = global::CMPG223_Group4_Project.Properties.Resources.Refresh_Icon;
            this.Bnt_RefreshReturn_Borrowed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bnt_RefreshReturn_Borrowed.Location = new System.Drawing.Point(473, 17);
            this.Bnt_RefreshReturn_Borrowed.Name = "Bnt_RefreshReturn_Borrowed";
            this.Bnt_RefreshReturn_Borrowed.Size = new System.Drawing.Size(119, 36);
            this.Bnt_RefreshReturn_Borrowed.TabIndex = 14;
            this.Bnt_RefreshReturn_Borrowed.UseVisualStyleBackColor = true;
            // 
            // dataGridView_ReturnSelection
            // 
            this.dataGridView_ReturnSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ReturnSelection.Location = new System.Drawing.Point(7, 60);
            this.dataGridView_ReturnSelection.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_ReturnSelection.Name = "dataGridView_ReturnSelection";
            this.dataGridView_ReturnSelection.RowHeadersWidth = 51;
            this.dataGridView_ReturnSelection.RowTemplate.Height = 24;
            this.dataGridView_ReturnSelection.Size = new System.Drawing.Size(585, 95);
            this.dataGridView_ReturnSelection.TabIndex = 13;
            // 
            // GB_BookOut
            // 
            this.GB_BookOut.Controls.Add(this.dateTimePicker_Duedate_Borrowed);
            this.GB_BookOut.Controls.Add(this.dateTimePicker_Bookout_Borrowed);
            this.GB_BookOut.Controls.Add(this.LB_DBISBN_Borrowed);
            this.GB_BookOut.Controls.Add(this.CB_TextBookName_Borrowed);
            this.GB_BookOut.Controls.Add(this.CB_NameLastName_Borrowed);
            this.GB_BookOut.Controls.Add(this.Bnt_Clear_Donations);
            this.GB_BookOut.Controls.Add(this.Bnt_Save_Donations);
            this.GB_BookOut.Controls.Add(this.LB_DueDate_Borrowed);
            this.GB_BookOut.Controls.Add(this.LB_DateOut_Borrowed);
            this.GB_BookOut.Controls.Add(this.LB_ISBN_Borrowed);
            this.GB_BookOut.Controls.Add(this.LB_TextbookName_Borrowed);
            this.GB_BookOut.Controls.Add(this.LB_BorrowerName_Borrowed);
            this.GB_BookOut.Location = new System.Drawing.Point(6, 199);
            this.GB_BookOut.Name = "GB_BookOut";
            this.GB_BookOut.Size = new System.Drawing.Size(599, 316);
            this.GB_BookOut.TabIndex = 2;
            this.GB_BookOut.TabStop = false;
            this.GB_BookOut.Text = "Book Textbook Out";
            // 
            // dateTimePicker_Duedate_Borrowed
            // 
            this.dateTimePicker_Duedate_Borrowed.Location = new System.Drawing.Point(239, 195);
            this.dateTimePicker_Duedate_Borrowed.Name = "dateTimePicker_Duedate_Borrowed";
            this.dateTimePicker_Duedate_Borrowed.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_Duedate_Borrowed.TabIndex = 20;
            // 
            // dateTimePicker_Bookout_Borrowed
            // 
            this.dateTimePicker_Bookout_Borrowed.Location = new System.Drawing.Point(239, 153);
            this.dateTimePicker_Bookout_Borrowed.Name = "dateTimePicker_Bookout_Borrowed";
            this.dateTimePicker_Bookout_Borrowed.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_Bookout_Borrowed.TabIndex = 19;
            // 
            // LB_DBISBN_Borrowed
            // 
            this.LB_DBISBN_Borrowed.AutoSize = true;
            this.LB_DBISBN_Borrowed.Location = new System.Drawing.Point(236, 118);
            this.LB_DBISBN_Borrowed.Name = "LB_DBISBN_Borrowed";
            this.LB_DBISBN_Borrowed.Size = new System.Drawing.Size(155, 16);
            this.LB_DBISBN_Borrowed.TabIndex = 18;
            this.LB_DBISBN_Borrowed.Text = "\"Will show ISBN number\"";
            // 
            // CB_TextBookName_Borrowed
            // 
            this.CB_TextBookName_Borrowed.FormattingEnabled = true;
            this.CB_TextBookName_Borrowed.Location = new System.Drawing.Point(239, 70);
            this.CB_TextBookName_Borrowed.Name = "CB_TextBookName_Borrowed";
            this.CB_TextBookName_Borrowed.Size = new System.Drawing.Size(225, 24);
            this.CB_TextBookName_Borrowed.TabIndex = 17;
            // 
            // Bnt_Clear_Donations
            // 
            this.Bnt_Clear_Donations.BackColor = System.Drawing.Color.Beige;
            this.Bnt_Clear_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bnt_Clear_Donations.Location = new System.Drawing.Point(477, 240);
            this.Bnt_Clear_Donations.Name = "Bnt_Clear_Donations";
            this.Bnt_Clear_Donations.Size = new System.Drawing.Size(116, 26);
            this.Bnt_Clear_Donations.TabIndex = 15;
            this.Bnt_Clear_Donations.Text = "Clear";
            this.Bnt_Clear_Donations.UseVisualStyleBackColor = false;
            // 
            // Bnt_Save_Donations
            // 
            this.Bnt_Save_Donations.BackColor = System.Drawing.Color.LightGreen;
            this.Bnt_Save_Donations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bnt_Save_Donations.Location = new System.Drawing.Point(477, 284);
            this.Bnt_Save_Donations.Name = "Bnt_Save_Donations";
            this.Bnt_Save_Donations.Size = new System.Drawing.Size(116, 26);
            this.Bnt_Save_Donations.TabIndex = 14;
            this.Bnt_Save_Donations.Text = "Save";
            this.Bnt_Save_Donations.UseVisualStyleBackColor = false;
            // 
            // LB_DueDate_Borrowed
            // 
            this.LB_DueDate_Borrowed.AutoSize = true;
            this.LB_DueDate_Borrowed.Location = new System.Drawing.Point(17, 201);
            this.LB_DueDate_Borrowed.Name = "LB_DueDate_Borrowed";
            this.LB_DueDate_Borrowed.Size = new System.Drawing.Size(67, 16);
            this.LB_DueDate_Borrowed.TabIndex = 4;
            this.LB_DueDate_Borrowed.Text = "Due Date:";
            // 
            // LB_DateOut_Borrowed
            // 
            this.LB_DateOut_Borrowed.AutoSize = true;
            this.LB_DateOut_Borrowed.Location = new System.Drawing.Point(17, 160);
            this.LB_DateOut_Borrowed.Name = "LB_DateOut_Borrowed";
            this.LB_DateOut_Borrowed.Size = new System.Drawing.Size(113, 16);
            this.LB_DateOut_Borrowed.TabIndex = 3;
            this.LB_DateOut_Borrowed.Text = "Date Booked Out:";
            // 
            // LB_ISBN_Borrowed
            // 
            this.LB_ISBN_Borrowed.AutoSize = true;
            this.LB_ISBN_Borrowed.Location = new System.Drawing.Point(17, 118);
            this.LB_ISBN_Borrowed.Name = "LB_ISBN_Borrowed";
            this.LB_ISBN_Borrowed.Size = new System.Drawing.Size(41, 16);
            this.LB_ISBN_Borrowed.TabIndex = 2;
            this.LB_ISBN_Borrowed.Text = "ISBN:";
            // 
            // LB_TextbookName_Borrowed
            // 
            this.LB_TextbookName_Borrowed.AutoSize = true;
            this.LB_TextbookName_Borrowed.Location = new System.Drawing.Point(17, 78);
            this.LB_TextbookName_Borrowed.Name = "LB_TextbookName_Borrowed";
            this.LB_TextbookName_Borrowed.Size = new System.Drawing.Size(107, 16);
            this.LB_TextbookName_Borrowed.TabIndex = 1;
            this.LB_TextbookName_Borrowed.Text = "Textbook Name:";
            // 
            // GB_TextBookStatus_Borrowed
            // 
            this.GB_TextBookStatus_Borrowed.Controls.Add(this.DataGrid_Borrowed);
            this.GB_TextBookStatus_Borrowed.Controls.Add(this.Bnt_Refresh_Borrowed);
            this.GB_TextBookStatus_Borrowed.Location = new System.Drawing.Point(6, 6);
            this.GB_TextBookStatus_Borrowed.Name = "GB_TextBookStatus_Borrowed";
            this.GB_TextBookStatus_Borrowed.Size = new System.Drawing.Size(1219, 173);
            this.GB_TextBookStatus_Borrowed.TabIndex = 1;
            this.GB_TextBookStatus_Borrowed.TabStop = false;
            this.GB_TextBookStatus_Borrowed.Text = "Textbook Status";
            // 
            // DataGrid_Borrowed
            // 
            this.DataGrid_Borrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Borrowed.Location = new System.Drawing.Point(7, 62);
            this.DataGrid_Borrowed.Margin = new System.Windows.Forms.Padding(4);
            this.DataGrid_Borrowed.Name = "DataGrid_Borrowed";
            this.DataGrid_Borrowed.RowHeadersWidth = 51;
            this.DataGrid_Borrowed.RowTemplate.Height = 24;
            this.DataGrid_Borrowed.Size = new System.Drawing.Size(1205, 95);
            this.DataGrid_Borrowed.TabIndex = 11;
            // 
            // Bnt_Refresh_Borrowed
            // 
            this.Bnt_Refresh_Borrowed.BackgroundImage = global::CMPG223_Group4_Project.Properties.Resources.Refresh_Icon;
            this.Bnt_Refresh_Borrowed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bnt_Refresh_Borrowed.Location = new System.Drawing.Point(1094, 19);
            this.Bnt_Refresh_Borrowed.Name = "Bnt_Refresh_Borrowed";
            this.Bnt_Refresh_Borrowed.Size = new System.Drawing.Size(119, 36);
            this.Bnt_Refresh_Borrowed.TabIndex = 12;
            this.Bnt_Refresh_Borrowed.UseVisualStyleBackColor = true;
            // 
            // LB_BorrowerName_Borrowed
            // 
            this.LB_BorrowerName_Borrowed.AutoSize = true;
            this.LB_BorrowerName_Borrowed.Location = new System.Drawing.Point(17, 35);
            this.LB_BorrowerName_Borrowed.Name = "LB_BorrowerName_Borrowed";
            this.LB_BorrowerName_Borrowed.Size = new System.Drawing.Size(198, 16);
            this.LB_BorrowerName_Borrowed.TabIndex = 0;
            this.LB_BorrowerName_Borrowed.Text = "Borrower Name and Last Name:";
            // 
            // CB_NameLastName_Borrowed
            // 
            this.CB_NameLastName_Borrowed.FormattingEnabled = true;
            this.CB_NameLastName_Borrowed.Location = new System.Drawing.Point(239, 27);
            this.CB_NameLastName_Borrowed.Name = "CB_NameLastName_Borrowed";
            this.CB_NameLastName_Borrowed.Size = new System.Drawing.Size(225, 24);
            this.CB_NameLastName_Borrowed.TabIndex = 16;
            // 
            // CB_ReturnTextbook_Borrowed
            // 
            this.CB_ReturnTextbook_Borrowed.FormattingEnabled = true;
            this.CB_ReturnTextbook_Borrowed.Location = new System.Drawing.Point(221, 169);
            this.CB_ReturnTextbook_Borrowed.Name = "CB_ReturnTextbook_Borrowed";
            this.CB_ReturnTextbook_Borrowed.Size = new System.Drawing.Size(225, 24);
            this.CB_ReturnTextbook_Borrowed.TabIndex = 22;
            // 
            // LB_ReturnTextbookName_Borrowed
            // 
            this.LB_ReturnTextbookName_Borrowed.AutoSize = true;
            this.LB_ReturnTextbookName_Borrowed.Location = new System.Drawing.Point(6, 177);
            this.LB_ReturnTextbookName_Borrowed.Name = "LB_ReturnTextbookName_Borrowed";
            this.LB_ReturnTextbookName_Borrowed.Size = new System.Drawing.Size(198, 16);
            this.LB_ReturnTextbookName_Borrowed.TabIndex = 21;
            this.LB_ReturnTextbookName_Borrowed.Text = "Borrower Name and Last Name:";
            // 
            // ReadersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 574);
            this.Controls.Add(this.TabControll_Readers);
            this.Name = "ReadersForm";
            this.Text = "ReadersForm";
            this.TabControll_Readers.ResumeLayout(false);
            this.Tab_Borrowers.ResumeLayout(false);
            this.Tab_Borrowers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_Readers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Borrowers)).EndInit();
            this.TabControl_BorrwedBooks.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReturnSelection)).EndInit();
            this.GB_BookOut.ResumeLayout(false);
            this.GB_BookOut.PerformLayout();
            this.GB_TextBookStatus_Borrowed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Borrowed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControll_Readers;
        private System.Windows.Forms.TabPage Tab_Borrowers;
        private System.Windows.Forms.PictureBox PicBx_Readers;
        private System.Windows.Forms.Button Bnt_Close_Borrowers;
        private System.Windows.Forms.Button Bnt_Delete_Borrowers;
        private System.Windows.Forms.Button Bnt_Update_Borrowers;
        private System.Windows.Forms.Button Bnt_New_Borrowers;
        private System.Windows.Forms.TextBox Txt_ContactNumber_Borrowers;
        private System.Windows.Forms.TextBox Txt_Email_Borrowers;
        private System.Windows.Forms.TextBox Txt_LastName_Borrowers;
        private System.Windows.Forms.TextBox Txt_FirstName_Borrowers;
        private System.Windows.Forms.Label LB_ContactNumber_Borrowers;
        private System.Windows.Forms.Label LB_Email_Borrowers;
        private System.Windows.Forms.Label LB_LastName_Borrowers;
        private System.Windows.Forms.Label LB_FirstName_Borrowers;
        private System.Windows.Forms.DataGridView DataGrid_Borrowers;
        private System.Windows.Forms.Button Bnt_Clear_Borrowers;
        private System.Windows.Forms.Button Bnt_Search_Borrowers;
        private System.Windows.Forms.TextBox TxtBx_Search_Borrowers;
        private System.Windows.Forms.Label LB_Search_Borrowers;
        private System.Windows.Forms.TabPage TabControl_BorrwedBooks;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox GB_BookOut;
        private System.Windows.Forms.GroupBox GB_TextBookStatus_Borrowed;
        private System.Windows.Forms.DataGridView DataGrid_Borrowed;
        private System.Windows.Forms.Button Bnt_Refresh_Borrowed;
        private System.Windows.Forms.Label LB_DueDate_Borrowed;
        private System.Windows.Forms.Label LB_DateOut_Borrowed;
        private System.Windows.Forms.Label LB_ISBN_Borrowed;
        private System.Windows.Forms.Label LB_TextbookName_Borrowed;
        private System.Windows.Forms.Button Bnt_Save_Donations;
        private System.Windows.Forms.Button Bnt_Clear_Donations;
        private System.Windows.Forms.Label LB_DBISBN_Borrowed;
        private System.Windows.Forms.ComboBox CB_TextBookName_Borrowed;
        private System.Windows.Forms.Button Bnt_RefreshReturn_Borrowed;
        private System.Windows.Forms.DataGridView dataGridView_ReturnSelection;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Duedate_Borrowed;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Bookout_Borrowed;
        private System.Windows.Forms.Button Bnt_Return_Borrowed;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label LB_RetunedDate_Borrowed;
        private System.Windows.Forms.Button Bnt_Close_Borrowed;
        private System.Windows.Forms.ComboBox CB_ReturnTextbook_Borrowed;
        private System.Windows.Forms.Label LB_ReturnTextbookName_Borrowed;
        private System.Windows.Forms.ComboBox CB_NameLastName_Borrowed;
        private System.Windows.Forms.Label LB_BorrowerName_Borrowed;
    }
}