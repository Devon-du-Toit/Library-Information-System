namespace CMPG223_Group4_Project
{
    partial class LibraryMaintenanceForm
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
            this.TabControl_Library = new System.Windows.Forms.TabControl();
            this.Tab_TxtBooks = new System.Windows.Forms.TabPage();
            this.dateTimePicker_Year_Textbook = new System.Windows.Forms.DateTimePicker();
            this.Bnt_Close_Textbook = new System.Windows.Forms.Button();
            this.Bnt_Delete_Textbook = new System.Windows.Forms.Button();
            this.Bnt_Update_Textbook = new System.Windows.Forms.Button();
            this.Bnt_New_Textbook = new System.Windows.Forms.Button();
            this.Txt_Qty_Textbook = new System.Windows.Forms.TextBox();
            this.Txt_Title_Textbook = new System.Windows.Forms.TextBox();
            this.RB_NotAvailable_Textbook = new System.Windows.Forms.RadioButton();
            this.RB_available_Textbook = new System.Windows.Forms.RadioButton();
            this.Txt_ISBN_Textbook = new System.Windows.Forms.TextBox();
            this.Txt_Author_Textbook = new System.Windows.Forms.TextBox();
            this.LB_Edition_Textbook = new System.Windows.Forms.Label();
            this.LB_PHYear = new System.Windows.Forms.Label();
            this.LB_Subject = new System.Windows.Forms.Label();
            this.LB_Title = new System.Windows.Forms.Label();
            this.LB_Status_Textbook = new System.Windows.Forms.Label();
            this.LB_ISBN_Textbook = new System.Windows.Forms.Label();
            this.LB_Author_Textbook = new System.Windows.Forms.Label();
            this.LB_Textbook_ID = new System.Windows.Forms.Label();
            this.DataGrid_Textbook = new System.Windows.Forms.DataGridView();
            this.Bnt_Clear_TextBook = new System.Windows.Forms.Button();
            this.Bnt_Search_TextBook = new System.Windows.Forms.Button();
            this.TxtBx_Search_TextBook = new System.Windows.Forms.TextBox();
            this.LB_Search_TextBook = new System.Windows.Forms.Label();
            this.Tab_Subjects = new System.Windows.Forms.TabPage();
            this.PicBox_Subjects = new System.Windows.Forms.PictureBox();
            this.Bnt_Close_Subject = new System.Windows.Forms.Button();
            this.Bnt_Delete_Subject = new System.Windows.Forms.Button();
            this.Bnt_Update_Subject = new System.Windows.Forms.Button();
            this.Bnt_New_Subject = new System.Windows.Forms.Button();
            this.Txt_Description_Subject = new System.Windows.Forms.TextBox();
            this.Txt_Name_Subject = new System.Windows.Forms.TextBox();
            this.LB_Description_Subject = new System.Windows.Forms.Label();
            this.LB_Name_Subject = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DataGrid_Subject = new System.Windows.Forms.DataGridView();
            this.Txt_Search_Subject = new System.Windows.Forms.TextBox();
            this.LB_Search_Subject = new System.Windows.Forms.Label();
            this.Bnt_Clear_Subject = new System.Windows.Forms.Button();
            this.Bnt_Search_Subject = new System.Windows.Forms.Button();
            this.Tab_Authors = new System.Windows.Forms.TabPage();
            this.PicBx_Author = new System.Windows.Forms.PictureBox();
            this.Bnt_Close_Author = new System.Windows.Forms.Button();
            this.Bnt_Delete_Author = new System.Windows.Forms.Button();
            this.Bnt_Update_Author = new System.Windows.Forms.Button();
            this.Bnt_New_Authors = new System.Windows.Forms.Button();
            this.Txt_LastName_Author = new System.Windows.Forms.TextBox();
            this.Txt_FirstName_Author = new System.Windows.Forms.TextBox();
            this.LB_LastName_Authors = new System.Windows.Forms.Label();
            this.LB_FirstName_Authors = new System.Windows.Forms.Label();
            this.LB_Author_ID_Authors = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Txt_Search_Author = new System.Windows.Forms.TextBox();
            this.LB_Search_Authors = new System.Windows.Forms.Label();
            this.Bnt_Clear_Author = new System.Windows.Forms.Button();
            this.Bnt_Search_Author = new System.Windows.Forms.Button();
            this.LB_TextBook_ID_Textbook = new System.Windows.Forms.Label();
            this.CB_DBSubjects_TextBooks = new System.Windows.Forms.ComboBox();
            this.LB_Subject_ID_Subjects = new System.Windows.Forms.Label();
            this.LB_Authros_ID_Authors = new System.Windows.Forms.Label();
            this.TabControl_Library.SuspendLayout();
            this.Tab_TxtBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Textbook)).BeginInit();
            this.Tab_Subjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Subjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Subject)).BeginInit();
            this.Tab_Authors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_Author)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl_Library
            // 
            this.TabControl_Library.Controls.Add(this.Tab_TxtBooks);
            this.TabControl_Library.Controls.Add(this.Tab_Subjects);
            this.TabControl_Library.Controls.Add(this.Tab_Authors);
            this.TabControl_Library.Location = new System.Drawing.Point(16, 15);
            this.TabControl_Library.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl_Library.Name = "TabControl_Library";
            this.TabControl_Library.SelectedIndex = 0;
            this.TabControl_Library.Size = new System.Drawing.Size(1187, 524);
            this.TabControl_Library.TabIndex = 0;
            // 
            // Tab_TxtBooks
            // 
            this.Tab_TxtBooks.BackColor = System.Drawing.Color.PeachPuff;
            this.Tab_TxtBooks.Controls.Add(this.CB_DBSubjects_TextBooks);
            this.Tab_TxtBooks.Controls.Add(this.LB_TextBook_ID_Textbook);
            this.Tab_TxtBooks.Controls.Add(this.dateTimePicker_Year_Textbook);
            this.Tab_TxtBooks.Controls.Add(this.Bnt_Close_Textbook);
            this.Tab_TxtBooks.Controls.Add(this.Bnt_Delete_Textbook);
            this.Tab_TxtBooks.Controls.Add(this.Bnt_Update_Textbook);
            this.Tab_TxtBooks.Controls.Add(this.Bnt_New_Textbook);
            this.Tab_TxtBooks.Controls.Add(this.Txt_Qty_Textbook);
            this.Tab_TxtBooks.Controls.Add(this.Txt_Title_Textbook);
            this.Tab_TxtBooks.Controls.Add(this.RB_NotAvailable_Textbook);
            this.Tab_TxtBooks.Controls.Add(this.RB_available_Textbook);
            this.Tab_TxtBooks.Controls.Add(this.Txt_ISBN_Textbook);
            this.Tab_TxtBooks.Controls.Add(this.Txt_Author_Textbook);
            this.Tab_TxtBooks.Controls.Add(this.LB_Edition_Textbook);
            this.Tab_TxtBooks.Controls.Add(this.LB_PHYear);
            this.Tab_TxtBooks.Controls.Add(this.LB_Subject);
            this.Tab_TxtBooks.Controls.Add(this.LB_Title);
            this.Tab_TxtBooks.Controls.Add(this.LB_Status_Textbook);
            this.Tab_TxtBooks.Controls.Add(this.LB_ISBN_Textbook);
            this.Tab_TxtBooks.Controls.Add(this.LB_Author_Textbook);
            this.Tab_TxtBooks.Controls.Add(this.LB_Textbook_ID);
            this.Tab_TxtBooks.Controls.Add(this.DataGrid_Textbook);
            this.Tab_TxtBooks.Controls.Add(this.Bnt_Clear_TextBook);
            this.Tab_TxtBooks.Controls.Add(this.Bnt_Search_TextBook);
            this.Tab_TxtBooks.Controls.Add(this.TxtBx_Search_TextBook);
            this.Tab_TxtBooks.Controls.Add(this.LB_Search_TextBook);
            this.Tab_TxtBooks.Location = new System.Drawing.Point(4, 25);
            this.Tab_TxtBooks.Margin = new System.Windows.Forms.Padding(4);
            this.Tab_TxtBooks.Name = "Tab_TxtBooks";
            this.Tab_TxtBooks.Padding = new System.Windows.Forms.Padding(4);
            this.Tab_TxtBooks.Size = new System.Drawing.Size(1179, 495);
            this.Tab_TxtBooks.TabIndex = 1;
            this.Tab_TxtBooks.Text = "Textbooks";
            // 
            // dateTimePicker_Year_Textbook
            // 
            this.dateTimePicker_Year_Textbook.Location = new System.Drawing.Point(620, 384);
            this.dateTimePicker_Year_Textbook.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_Year_Textbook.Name = "dateTimePicker_Year_Textbook";
            this.dateTimePicker_Year_Textbook.Size = new System.Drawing.Size(311, 22);
            this.dateTimePicker_Year_Textbook.TabIndex = 27;
            // 
            // Bnt_Close_Textbook
            // 
            this.Bnt_Close_Textbook.BackColor = System.Drawing.Color.Red;
            this.Bnt_Close_Textbook.Location = new System.Drawing.Point(1003, 457);
            this.Bnt_Close_Textbook.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_Close_Textbook.Name = "Bnt_Close_Textbook";
            this.Bnt_Close_Textbook.Size = new System.Drawing.Size(165, 28);
            this.Bnt_Close_Textbook.TabIndex = 26;
            this.Bnt_Close_Textbook.Text = "Close";
            this.Bnt_Close_Textbook.UseVisualStyleBackColor = false;
            // 
            // Bnt_Delete_Textbook
            // 
            this.Bnt_Delete_Textbook.BackColor = System.Drawing.Color.Silver;
            this.Bnt_Delete_Textbook.Location = new System.Drawing.Point(1003, 375);
            this.Bnt_Delete_Textbook.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_Delete_Textbook.Name = "Bnt_Delete_Textbook";
            this.Bnt_Delete_Textbook.Size = new System.Drawing.Size(165, 28);
            this.Bnt_Delete_Textbook.TabIndex = 25;
            this.Bnt_Delete_Textbook.Text = "Delete";
            this.Bnt_Delete_Textbook.UseVisualStyleBackColor = false;
            // 
            // Bnt_Update_Textbook
            // 
            this.Bnt_Update_Textbook.BackColor = System.Drawing.Color.LightBlue;
            this.Bnt_Update_Textbook.Location = new System.Drawing.Point(1003, 321);
            this.Bnt_Update_Textbook.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_Update_Textbook.Name = "Bnt_Update_Textbook";
            this.Bnt_Update_Textbook.Size = new System.Drawing.Size(165, 28);
            this.Bnt_Update_Textbook.TabIndex = 24;
            this.Bnt_Update_Textbook.Text = "Update";
            this.Bnt_Update_Textbook.UseVisualStyleBackColor = false;
            // 
            // Bnt_New_Textbook
            // 
            this.Bnt_New_Textbook.BackColor = System.Drawing.Color.LightGreen;
            this.Bnt_New_Textbook.Location = new System.Drawing.Point(1003, 273);
            this.Bnt_New_Textbook.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_New_Textbook.Name = "Bnt_New_Textbook";
            this.Bnt_New_Textbook.Size = new System.Drawing.Size(165, 28);
            this.Bnt_New_Textbook.TabIndex = 22;
            this.Bnt_New_Textbook.Text = "New";
            this.Bnt_New_Textbook.UseVisualStyleBackColor = false;
            // 
            // Txt_Qty_Textbook
            // 
            this.Txt_Qty_Textbook.Location = new System.Drawing.Point(620, 432);
            this.Txt_Qty_Textbook.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Qty_Textbook.Name = "Txt_Qty_Textbook";
            this.Txt_Qty_Textbook.Size = new System.Drawing.Size(311, 22);
            this.Txt_Qty_Textbook.TabIndex = 21;
            // 
            // Txt_Title_Textbook
            // 
            this.Txt_Title_Textbook.Location = new System.Drawing.Point(620, 273);
            this.Txt_Title_Textbook.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Title_Textbook.Name = "Txt_Title_Textbook";
            this.Txt_Title_Textbook.Size = new System.Drawing.Size(311, 22);
            this.Txt_Title_Textbook.TabIndex = 18;
            // 
            // RB_NotAvailable_Textbook
            // 
            this.RB_NotAvailable_Textbook.AutoSize = true;
            this.RB_NotAvailable_Textbook.Location = new System.Drawing.Point(305, 439);
            this.RB_NotAvailable_Textbook.Margin = new System.Windows.Forms.Padding(4);
            this.RB_NotAvailable_Textbook.Name = "RB_NotAvailable_Textbook";
            this.RB_NotAvailable_Textbook.Size = new System.Drawing.Size(109, 20);
            this.RB_NotAvailable_Textbook.TabIndex = 17;
            this.RB_NotAvailable_Textbook.TabStop = true;
            this.RB_NotAvailable_Textbook.Text = "Not Available";
            this.RB_NotAvailable_Textbook.UseVisualStyleBackColor = true;
            // 
            // RB_available_Textbook
            // 
            this.RB_available_Textbook.AutoSize = true;
            this.RB_available_Textbook.Location = new System.Drawing.Point(135, 439);
            this.RB_available_Textbook.Margin = new System.Windows.Forms.Padding(4);
            this.RB_available_Textbook.Name = "RB_available_Textbook";
            this.RB_available_Textbook.Size = new System.Drawing.Size(85, 20);
            this.RB_available_Textbook.TabIndex = 16;
            this.RB_available_Textbook.TabStop = true;
            this.RB_available_Textbook.Text = "Available";
            this.RB_available_Textbook.UseVisualStyleBackColor = true;
            // 
            // Txt_ISBN_Textbook
            // 
            this.Txt_ISBN_Textbook.Location = new System.Drawing.Point(135, 384);
            this.Txt_ISBN_Textbook.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_ISBN_Textbook.Name = "Txt_ISBN_Textbook";
            this.Txt_ISBN_Textbook.Size = new System.Drawing.Size(311, 22);
            this.Txt_ISBN_Textbook.TabIndex = 15;
            // 
            // Txt_Author_Textbook
            // 
            this.Txt_Author_Textbook.Location = new System.Drawing.Point(135, 325);
            this.Txt_Author_Textbook.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Author_Textbook.Name = "Txt_Author_Textbook";
            this.Txt_Author_Textbook.Size = new System.Drawing.Size(311, 22);
            this.Txt_Author_Textbook.TabIndex = 14;
            // 
            // LB_Edition_Textbook
            // 
            this.LB_Edition_Textbook.AutoSize = true;
            this.LB_Edition_Textbook.Location = new System.Drawing.Point(475, 439);
            this.LB_Edition_Textbook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Edition_Textbook.Name = "LB_Edition_Textbook";
            this.LB_Edition_Textbook.Size = new System.Drawing.Size(51, 16);
            this.LB_Edition_Textbook.TabIndex = 12;
            this.LB_Edition_Textbook.Text = "Edition:";
            // 
            // LB_PHYear
            // 
            this.LB_PHYear.AutoSize = true;
            this.LB_PHYear.Location = new System.Drawing.Point(475, 384);
            this.LB_PHYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_PHYear.Name = "LB_PHYear";
            this.LB_PHYear.Size = new System.Drawing.Size(106, 16);
            this.LB_PHYear.TabIndex = 11;
            this.LB_PHYear.Text = "Published_Year:";
            // 
            // LB_Subject
            // 
            this.LB_Subject.AutoSize = true;
            this.LB_Subject.Location = new System.Drawing.Point(475, 325);
            this.LB_Subject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Subject.Name = "LB_Subject";
            this.LB_Subject.Size = new System.Drawing.Size(55, 16);
            this.LB_Subject.TabIndex = 10;
            this.LB_Subject.Text = "Subject:";
            // 
            // LB_Title
            // 
            this.LB_Title.AutoSize = true;
            this.LB_Title.Location = new System.Drawing.Point(475, 273);
            this.LB_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Title.Name = "LB_Title";
            this.LB_Title.Size = new System.Drawing.Size(36, 16);
            this.LB_Title.TabIndex = 9;
            this.LB_Title.Text = "Title:";
            // 
            // LB_Status_Textbook
            // 
            this.LB_Status_Textbook.AutoSize = true;
            this.LB_Status_Textbook.Location = new System.Drawing.Point(9, 439);
            this.LB_Status_Textbook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Status_Textbook.Name = "LB_Status_Textbook";
            this.LB_Status_Textbook.Size = new System.Drawing.Size(47, 16);
            this.LB_Status_Textbook.TabIndex = 8;
            this.LB_Status_Textbook.Text = "Status:";
            // 
            // LB_ISBN_Textbook
            // 
            this.LB_ISBN_Textbook.AutoSize = true;
            this.LB_ISBN_Textbook.Location = new System.Drawing.Point(9, 384);
            this.LB_ISBN_Textbook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_ISBN_Textbook.Name = "LB_ISBN_Textbook";
            this.LB_ISBN_Textbook.Size = new System.Drawing.Size(41, 16);
            this.LB_ISBN_Textbook.TabIndex = 7;
            this.LB_ISBN_Textbook.Text = "ISBN:";
            // 
            // LB_Author_Textbook
            // 
            this.LB_Author_Textbook.AutoSize = true;
            this.LB_Author_Textbook.Location = new System.Drawing.Point(9, 325);
            this.LB_Author_Textbook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Author_Textbook.Name = "LB_Author_Textbook";
            this.LB_Author_Textbook.Size = new System.Drawing.Size(48, 16);
            this.LB_Author_Textbook.TabIndex = 6;
            this.LB_Author_Textbook.Text = "Author:";
            // 
            // LB_Textbook_ID
            // 
            this.LB_Textbook_ID.AutoSize = true;
            this.LB_Textbook_ID.Location = new System.Drawing.Point(9, 273);
            this.LB_Textbook_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Textbook_ID.Name = "LB_Textbook_ID";
            this.LB_Textbook_ID.Size = new System.Drawing.Size(88, 16);
            this.LB_Textbook_ID.TabIndex = 5;
            this.LB_Textbook_ID.Text = "TextBook_ID:";
            // 
            // DataGrid_Textbook
            // 
            this.DataGrid_Textbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Textbook.Location = new System.Drawing.Point(8, 43);
            this.DataGrid_Textbook.Margin = new System.Windows.Forms.Padding(4);
            this.DataGrid_Textbook.Name = "DataGrid_Textbook";
            this.DataGrid_Textbook.RowHeadersWidth = 51;
            this.DataGrid_Textbook.RowTemplate.Height = 24;
            this.DataGrid_Textbook.Size = new System.Drawing.Size(1160, 222);
            this.DataGrid_Textbook.TabIndex = 4;
            // 
            // Bnt_Clear_TextBook
            // 
            this.Bnt_Clear_TextBook.BackgroundImage = global::CMPG223_Group4_Project.Properties.Resources.Clear_Icon;
            this.Bnt_Clear_TextBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bnt_Clear_TextBook.Location = new System.Drawing.Point(1003, 7);
            this.Bnt_Clear_TextBook.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_Clear_TextBook.Name = "Bnt_Clear_TextBook";
            this.Bnt_Clear_TextBook.Size = new System.Drawing.Size(165, 28);
            this.Bnt_Clear_TextBook.TabIndex = 3;
            this.Bnt_Clear_TextBook.UseVisualStyleBackColor = true;
            // 
            // Bnt_Search_TextBook
            // 
            this.Bnt_Search_TextBook.BackgroundImage = global::CMPG223_Group4_Project.Properties.Resources.Magnifying_glass;
            this.Bnt_Search_TextBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bnt_Search_TextBook.Location = new System.Drawing.Point(799, 7);
            this.Bnt_Search_TextBook.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_Search_TextBook.Name = "Bnt_Search_TextBook";
            this.Bnt_Search_TextBook.Size = new System.Drawing.Size(165, 28);
            this.Bnt_Search_TextBook.TabIndex = 2;
            this.Bnt_Search_TextBook.UseVisualStyleBackColor = true;
            // 
            // TxtBx_Search_TextBook
            // 
            this.TxtBx_Search_TextBook.Location = new System.Drawing.Point(135, 9);
            this.TxtBx_Search_TextBook.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBx_Search_TextBook.Name = "TxtBx_Search_TextBook";
            this.TxtBx_Search_TextBook.Size = new System.Drawing.Size(311, 22);
            this.TxtBx_Search_TextBook.TabIndex = 1;
            // 
            // LB_Search_TextBook
            // 
            this.LB_Search_TextBook.AutoSize = true;
            this.LB_Search_TextBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Search_TextBook.Location = new System.Drawing.Point(17, 5);
            this.LB_Search_TextBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Search_TextBook.Name = "LB_Search_TextBook";
            this.LB_Search_TextBook.Size = new System.Drawing.Size(102, 29);
            this.LB_Search_TextBook.TabIndex = 0;
            this.LB_Search_TextBook.Text = "Search:";
            // 
            // Tab_Subjects
            // 
            this.Tab_Subjects.BackColor = System.Drawing.Color.PeachPuff;
            this.Tab_Subjects.Controls.Add(this.LB_Subject_ID_Subjects);
            this.Tab_Subjects.Controls.Add(this.PicBox_Subjects);
            this.Tab_Subjects.Controls.Add(this.Bnt_Close_Subject);
            this.Tab_Subjects.Controls.Add(this.Bnt_Delete_Subject);
            this.Tab_Subjects.Controls.Add(this.Bnt_Update_Subject);
            this.Tab_Subjects.Controls.Add(this.Bnt_New_Subject);
            this.Tab_Subjects.Controls.Add(this.Txt_Description_Subject);
            this.Tab_Subjects.Controls.Add(this.Txt_Name_Subject);
            this.Tab_Subjects.Controls.Add(this.LB_Description_Subject);
            this.Tab_Subjects.Controls.Add(this.LB_Name_Subject);
            this.Tab_Subjects.Controls.Add(this.label4);
            this.Tab_Subjects.Controls.Add(this.DataGrid_Subject);
            this.Tab_Subjects.Controls.Add(this.Txt_Search_Subject);
            this.Tab_Subjects.Controls.Add(this.LB_Search_Subject);
            this.Tab_Subjects.Controls.Add(this.Bnt_Clear_Subject);
            this.Tab_Subjects.Controls.Add(this.Bnt_Search_Subject);
            this.Tab_Subjects.Location = new System.Drawing.Point(4, 25);
            this.Tab_Subjects.Margin = new System.Windows.Forms.Padding(4);
            this.Tab_Subjects.Name = "Tab_Subjects";
            this.Tab_Subjects.Padding = new System.Windows.Forms.Padding(4);
            this.Tab_Subjects.Size = new System.Drawing.Size(1179, 495);
            this.Tab_Subjects.TabIndex = 2;
            this.Tab_Subjects.Text = "Subjects";
            // 
            // PicBox_Subjects
            // 
            this.PicBox_Subjects.BackgroundImage = global::CMPG223_Group4_Project.Properties.Resources.Subject_Icon;
            this.PicBox_Subjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBox_Subjects.Location = new System.Drawing.Point(467, 274);
            this.PicBox_Subjects.Margin = new System.Windows.Forms.Padding(4);
            this.PicBox_Subjects.Name = "PicBox_Subjects";
            this.PicBox_Subjects.Size = new System.Drawing.Size(528, 210);
            this.PicBox_Subjects.TabIndex = 42;
            this.PicBox_Subjects.TabStop = false;
            // 
            // Bnt_Close_Subject
            // 
            this.Bnt_Close_Subject.BackColor = System.Drawing.Color.Red;
            this.Bnt_Close_Subject.Location = new System.Drawing.Point(1003, 458);
            this.Bnt_Close_Subject.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_Close_Subject.Name = "Bnt_Close_Subject";
            this.Bnt_Close_Subject.Size = new System.Drawing.Size(165, 28);
            this.Bnt_Close_Subject.TabIndex = 41;
            this.Bnt_Close_Subject.Text = "Close";
            this.Bnt_Close_Subject.UseVisualStyleBackColor = false;
            // 
            // Bnt_Delete_Subject
            // 
            this.Bnt_Delete_Subject.BackColor = System.Drawing.Color.Silver;
            this.Bnt_Delete_Subject.Location = new System.Drawing.Point(1003, 377);
            this.Bnt_Delete_Subject.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_Delete_Subject.Name = "Bnt_Delete_Subject";
            this.Bnt_Delete_Subject.Size = new System.Drawing.Size(165, 28);
            this.Bnt_Delete_Subject.TabIndex = 40;
            this.Bnt_Delete_Subject.Text = "Delete";
            this.Bnt_Delete_Subject.UseVisualStyleBackColor = false;
            // 
            // Bnt_Update_Subject
            // 
            this.Bnt_Update_Subject.BackColor = System.Drawing.Color.LightBlue;
            this.Bnt_Update_Subject.Location = new System.Drawing.Point(1003, 322);
            this.Bnt_Update_Subject.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_Update_Subject.Name = "Bnt_Update_Subject";
            this.Bnt_Update_Subject.Size = new System.Drawing.Size(165, 28);
            this.Bnt_Update_Subject.TabIndex = 39;
            this.Bnt_Update_Subject.Text = "Update";
            this.Bnt_Update_Subject.UseVisualStyleBackColor = false;
            // 
            // Bnt_New_Subject
            // 
            this.Bnt_New_Subject.BackColor = System.Drawing.Color.LightGreen;
            this.Bnt_New_Subject.Location = new System.Drawing.Point(1003, 274);
            this.Bnt_New_Subject.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_New_Subject.Name = "Bnt_New_Subject";
            this.Bnt_New_Subject.Size = new System.Drawing.Size(165, 28);
            this.Bnt_New_Subject.TabIndex = 38;
            this.Bnt_New_Subject.Text = "New";
            this.Bnt_New_Subject.UseVisualStyleBackColor = false;
            // 
            // Txt_Description_Subject
            // 
            this.Txt_Description_Subject.Location = new System.Drawing.Point(135, 385);
            this.Txt_Description_Subject.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Description_Subject.Name = "Txt_Description_Subject";
            this.Txt_Description_Subject.Size = new System.Drawing.Size(311, 22);
            this.Txt_Description_Subject.TabIndex = 37;
            // 
            // Txt_Name_Subject
            // 
            this.Txt_Name_Subject.Location = new System.Drawing.Point(135, 326);
            this.Txt_Name_Subject.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Name_Subject.Name = "Txt_Name_Subject";
            this.Txt_Name_Subject.Size = new System.Drawing.Size(311, 22);
            this.Txt_Name_Subject.TabIndex = 36;
            // 
            // LB_Description_Subject
            // 
            this.LB_Description_Subject.AutoSize = true;
            this.LB_Description_Subject.Location = new System.Drawing.Point(9, 385);
            this.LB_Description_Subject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Description_Subject.Name = "LB_Description_Subject";
            this.LB_Description_Subject.Size = new System.Drawing.Size(75, 16);
            this.LB_Description_Subject.TabIndex = 34;
            this.LB_Description_Subject.Text = "Description";
            // 
            // LB_Name_Subject
            // 
            this.LB_Name_Subject.AutoSize = true;
            this.LB_Name_Subject.Location = new System.Drawing.Point(9, 326);
            this.LB_Name_Subject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Name_Subject.Name = "LB_Name_Subject";
            this.LB_Name_Subject.Size = new System.Drawing.Size(47, 16);
            this.LB_Name_Subject.TabIndex = 33;
            this.LB_Name_Subject.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 274);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Subject_ID:";
            // 
            // DataGrid_Subject
            // 
            this.DataGrid_Subject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Subject.Location = new System.Drawing.Point(8, 44);
            this.DataGrid_Subject.Margin = new System.Windows.Forms.Padding(4);
            this.DataGrid_Subject.Name = "DataGrid_Subject";
            this.DataGrid_Subject.RowHeadersWidth = 51;
            this.DataGrid_Subject.RowTemplate.Height = 24;
            this.DataGrid_Subject.Size = new System.Drawing.Size(1160, 222);
            this.DataGrid_Subject.TabIndex = 31;
            // 
            // Txt_Search_Subject
            // 
            this.Txt_Search_Subject.Location = new System.Drawing.Point(135, 10);
            this.Txt_Search_Subject.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Search_Subject.Name = "Txt_Search_Subject";
            this.Txt_Search_Subject.Size = new System.Drawing.Size(311, 22);
            this.Txt_Search_Subject.TabIndex = 28;
            // 
            // LB_Search_Subject
            // 
            this.LB_Search_Subject.AutoSize = true;
            this.LB_Search_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Search_Subject.Location = new System.Drawing.Point(17, 6);
            this.LB_Search_Subject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Search_Subject.Name = "LB_Search_Subject";
            this.LB_Search_Subject.Size = new System.Drawing.Size(102, 29);
            this.LB_Search_Subject.TabIndex = 27;
            this.LB_Search_Subject.Text = "Search:";
            // 
            // Bnt_Clear_Subject
            // 
            this.Bnt_Clear_Subject.BackgroundImage = global::CMPG223_Group4_Project.Properties.Resources.Clear_Icon;
            this.Bnt_Clear_Subject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bnt_Clear_Subject.Location = new System.Drawing.Point(1003, 9);
            this.Bnt_Clear_Subject.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_Clear_Subject.Name = "Bnt_Clear_Subject";
            this.Bnt_Clear_Subject.Size = new System.Drawing.Size(165, 28);
            this.Bnt_Clear_Subject.TabIndex = 30;
            this.Bnt_Clear_Subject.UseVisualStyleBackColor = true;
            // 
            // Bnt_Search_Subject
            // 
            this.Bnt_Search_Subject.BackgroundImage = global::CMPG223_Group4_Project.Properties.Resources.Magnifying_glass;
            this.Bnt_Search_Subject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bnt_Search_Subject.Location = new System.Drawing.Point(799, 9);
            this.Bnt_Search_Subject.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_Search_Subject.Name = "Bnt_Search_Subject";
            this.Bnt_Search_Subject.Size = new System.Drawing.Size(165, 28);
            this.Bnt_Search_Subject.TabIndex = 29;
            this.Bnt_Search_Subject.UseVisualStyleBackColor = true;
            // 
            // Tab_Authors
            // 
            this.Tab_Authors.BackColor = System.Drawing.Color.PeachPuff;
            this.Tab_Authors.Controls.Add(this.LB_Authros_ID_Authors);
            this.Tab_Authors.Controls.Add(this.PicBx_Author);
            this.Tab_Authors.Controls.Add(this.Bnt_Close_Author);
            this.Tab_Authors.Controls.Add(this.Bnt_Delete_Author);
            this.Tab_Authors.Controls.Add(this.Bnt_Update_Author);
            this.Tab_Authors.Controls.Add(this.Bnt_New_Authors);
            this.Tab_Authors.Controls.Add(this.Txt_LastName_Author);
            this.Tab_Authors.Controls.Add(this.Txt_FirstName_Author);
            this.Tab_Authors.Controls.Add(this.LB_LastName_Authors);
            this.Tab_Authors.Controls.Add(this.LB_FirstName_Authors);
            this.Tab_Authors.Controls.Add(this.LB_Author_ID_Authors);
            this.Tab_Authors.Controls.Add(this.dataGridView1);
            this.Tab_Authors.Controls.Add(this.Txt_Search_Author);
            this.Tab_Authors.Controls.Add(this.LB_Search_Authors);
            this.Tab_Authors.Controls.Add(this.Bnt_Clear_Author);
            this.Tab_Authors.Controls.Add(this.Bnt_Search_Author);
            this.Tab_Authors.Location = new System.Drawing.Point(4, 25);
            this.Tab_Authors.Margin = new System.Windows.Forms.Padding(4);
            this.Tab_Authors.Name = "Tab_Authors";
            this.Tab_Authors.Padding = new System.Windows.Forms.Padding(4);
            this.Tab_Authors.Size = new System.Drawing.Size(1179, 495);
            this.Tab_Authors.TabIndex = 3;
            this.Tab_Authors.Text = "Authors";
            // 
            // PicBx_Author
            // 
            this.PicBx_Author.BackgroundImage = global::CMPG223_Group4_Project.Properties.Resources.Author_Icon;
            this.PicBx_Author.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBx_Author.Location = new System.Drawing.Point(472, 274);
            this.PicBx_Author.Margin = new System.Windows.Forms.Padding(4);
            this.PicBx_Author.Name = "PicBx_Author";
            this.PicBx_Author.Size = new System.Drawing.Size(523, 210);
            this.PicBx_Author.TabIndex = 57;
            this.PicBx_Author.TabStop = false;
            // 
            // Bnt_Close_Author
            // 
            this.Bnt_Close_Author.BackColor = System.Drawing.Color.Red;
            this.Bnt_Close_Author.Location = new System.Drawing.Point(1003, 458);
            this.Bnt_Close_Author.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_Close_Author.Name = "Bnt_Close_Author";
            this.Bnt_Close_Author.Size = new System.Drawing.Size(165, 28);
            this.Bnt_Close_Author.TabIndex = 56;
            this.Bnt_Close_Author.Text = "Close";
            this.Bnt_Close_Author.UseVisualStyleBackColor = false;
            // 
            // Bnt_Delete_Author
            // 
            this.Bnt_Delete_Author.BackColor = System.Drawing.Color.Silver;
            this.Bnt_Delete_Author.Location = new System.Drawing.Point(1003, 377);
            this.Bnt_Delete_Author.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_Delete_Author.Name = "Bnt_Delete_Author";
            this.Bnt_Delete_Author.Size = new System.Drawing.Size(165, 28);
            this.Bnt_Delete_Author.TabIndex = 55;
            this.Bnt_Delete_Author.Text = "Delete";
            this.Bnt_Delete_Author.UseVisualStyleBackColor = false;
            // 
            // Bnt_Update_Author
            // 
            this.Bnt_Update_Author.BackColor = System.Drawing.Color.LightBlue;
            this.Bnt_Update_Author.Location = new System.Drawing.Point(1003, 322);
            this.Bnt_Update_Author.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_Update_Author.Name = "Bnt_Update_Author";
            this.Bnt_Update_Author.Size = new System.Drawing.Size(165, 28);
            this.Bnt_Update_Author.TabIndex = 54;
            this.Bnt_Update_Author.Text = "Update";
            this.Bnt_Update_Author.UseVisualStyleBackColor = false;
            // 
            // Bnt_New_Authors
            // 
            this.Bnt_New_Authors.BackColor = System.Drawing.Color.LightGreen;
            this.Bnt_New_Authors.Location = new System.Drawing.Point(1003, 274);
            this.Bnt_New_Authors.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_New_Authors.Name = "Bnt_New_Authors";
            this.Bnt_New_Authors.Size = new System.Drawing.Size(165, 28);
            this.Bnt_New_Authors.TabIndex = 53;
            this.Bnt_New_Authors.Text = "New";
            this.Bnt_New_Authors.UseVisualStyleBackColor = false;
            // 
            // Txt_LastName_Author
            // 
            this.Txt_LastName_Author.Location = new System.Drawing.Point(135, 385);
            this.Txt_LastName_Author.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_LastName_Author.Name = "Txt_LastName_Author";
            this.Txt_LastName_Author.Size = new System.Drawing.Size(311, 22);
            this.Txt_LastName_Author.TabIndex = 52;
            // 
            // Txt_FirstName_Author
            // 
            this.Txt_FirstName_Author.Location = new System.Drawing.Point(135, 326);
            this.Txt_FirstName_Author.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_FirstName_Author.Name = "Txt_FirstName_Author";
            this.Txt_FirstName_Author.Size = new System.Drawing.Size(311, 22);
            this.Txt_FirstName_Author.TabIndex = 51;
            // 
            // LB_LastName_Authors
            // 
            this.LB_LastName_Authors.AutoSize = true;
            this.LB_LastName_Authors.Location = new System.Drawing.Point(9, 385);
            this.LB_LastName_Authors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_LastName_Authors.Name = "LB_LastName_Authors";
            this.LB_LastName_Authors.Size = new System.Drawing.Size(75, 16);
            this.LB_LastName_Authors.TabIndex = 49;
            this.LB_LastName_Authors.Text = "Last Name:";
            // 
            // LB_FirstName_Authors
            // 
            this.LB_FirstName_Authors.AutoSize = true;
            this.LB_FirstName_Authors.Location = new System.Drawing.Point(9, 326);
            this.LB_FirstName_Authors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_FirstName_Authors.Name = "LB_FirstName_Authors";
            this.LB_FirstName_Authors.Size = new System.Drawing.Size(75, 16);
            this.LB_FirstName_Authors.TabIndex = 48;
            this.LB_FirstName_Authors.Text = "First Name:";
            // 
            // LB_Author_ID_Authors
            // 
            this.LB_Author_ID_Authors.AutoSize = true;
            this.LB_Author_ID_Authors.Location = new System.Drawing.Point(9, 274);
            this.LB_Author_ID_Authors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Author_ID_Authors.Name = "LB_Author_ID_Authors";
            this.LB_Author_ID_Authors.Size = new System.Drawing.Size(68, 16);
            this.LB_Author_ID_Authors.TabIndex = 47;
            this.LB_Author_ID_Authors.Text = "Author_ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 44);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 222);
            this.dataGridView1.TabIndex = 46;
            // 
            // Txt_Search_Author
            // 
            this.Txt_Search_Author.Location = new System.Drawing.Point(135, 10);
            this.Txt_Search_Author.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Search_Author.Name = "Txt_Search_Author";
            this.Txt_Search_Author.Size = new System.Drawing.Size(311, 22);
            this.Txt_Search_Author.TabIndex = 43;
            // 
            // LB_Search_Authors
            // 
            this.LB_Search_Authors.AutoSize = true;
            this.LB_Search_Authors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Search_Authors.Location = new System.Drawing.Point(17, 6);
            this.LB_Search_Authors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Search_Authors.Name = "LB_Search_Authors";
            this.LB_Search_Authors.Size = new System.Drawing.Size(102, 29);
            this.LB_Search_Authors.TabIndex = 42;
            this.LB_Search_Authors.Text = "Search:";
            // 
            // Bnt_Clear_Author
            // 
            this.Bnt_Clear_Author.BackgroundImage = global::CMPG223_Group4_Project.Properties.Resources.Clear_Icon;
            this.Bnt_Clear_Author.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bnt_Clear_Author.Location = new System.Drawing.Point(1003, 9);
            this.Bnt_Clear_Author.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_Clear_Author.Name = "Bnt_Clear_Author";
            this.Bnt_Clear_Author.Size = new System.Drawing.Size(165, 28);
            this.Bnt_Clear_Author.TabIndex = 45;
            this.Bnt_Clear_Author.UseVisualStyleBackColor = true;
            // 
            // Bnt_Search_Author
            // 
            this.Bnt_Search_Author.BackgroundImage = global::CMPG223_Group4_Project.Properties.Resources.Magnifying_glass;
            this.Bnt_Search_Author.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bnt_Search_Author.Location = new System.Drawing.Point(799, 9);
            this.Bnt_Search_Author.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_Search_Author.Name = "Bnt_Search_Author";
            this.Bnt_Search_Author.Size = new System.Drawing.Size(165, 28);
            this.Bnt_Search_Author.TabIndex = 44;
            this.Bnt_Search_Author.UseVisualStyleBackColor = true;
            // 
            // LB_TextBook_ID_Textbook
            // 
            this.LB_TextBook_ID_Textbook.AutoSize = true;
            this.LB_TextBook_ID_Textbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TextBook_ID_Textbook.Location = new System.Drawing.Point(131, 273);
            this.LB_TextBook_ID_Textbook.Name = "LB_TextBook_ID_Textbook";
            this.LB_TextBook_ID_Textbook.Size = new System.Drawing.Size(179, 20);
            this.LB_TextBook_ID_Textbook.TabIndex = 28;
            this.LB_TextBook_ID_Textbook.Text = "\"ID to be generated\"";
            // 
            // CB_DBSubjects_TextBooks
            // 
            this.CB_DBSubjects_TextBooks.FormattingEnabled = true;
            this.CB_DBSubjects_TextBooks.Location = new System.Drawing.Point(620, 325);
            this.CB_DBSubjects_TextBooks.Name = "CB_DBSubjects_TextBooks";
            this.CB_DBSubjects_TextBooks.Size = new System.Drawing.Size(311, 24);
            this.CB_DBSubjects_TextBooks.TabIndex = 29;
            // 
            // LB_Subject_ID_Subjects
            // 
            this.LB_Subject_ID_Subjects.AutoSize = true;
            this.LB_Subject_ID_Subjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Subject_ID_Subjects.Location = new System.Drawing.Point(131, 274);
            this.LB_Subject_ID_Subjects.Name = "LB_Subject_ID_Subjects";
            this.LB_Subject_ID_Subjects.Size = new System.Drawing.Size(179, 20);
            this.LB_Subject_ID_Subjects.TabIndex = 43;
            this.LB_Subject_ID_Subjects.Text = "\"ID to be generated\"";
            // 
            // LB_Authros_ID_Authors
            // 
            this.LB_Authros_ID_Authors.AutoSize = true;
            this.LB_Authros_ID_Authors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Authros_ID_Authors.Location = new System.Drawing.Point(131, 274);
            this.LB_Authros_ID_Authors.Name = "LB_Authros_ID_Authors";
            this.LB_Authros_ID_Authors.Size = new System.Drawing.Size(179, 20);
            this.LB_Authros_ID_Authors.TabIndex = 58;
            this.LB_Authros_ID_Authors.Text = "\"ID to be generated\"";
            // 
            // LibraryMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 565);
            this.Controls.Add(this.TabControl_Library);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LibraryMaintenanceForm";
            this.Text = "LibraryMaintenanceForm";
            this.TabControl_Library.ResumeLayout(false);
            this.Tab_TxtBooks.ResumeLayout(false);
            this.Tab_TxtBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Textbook)).EndInit();
            this.Tab_Subjects.ResumeLayout(false);
            this.Tab_Subjects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Subjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Subject)).EndInit();
            this.Tab_Authors.ResumeLayout(false);
            this.Tab_Authors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_Author)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl_Library;
        private System.Windows.Forms.TabPage Tab_TxtBooks;
        private System.Windows.Forms.TabPage Tab_Subjects;
        private System.Windows.Forms.TabPage Tab_Authors;
        private System.Windows.Forms.TextBox Txt_ISBN_Textbook;
        private System.Windows.Forms.TextBox Txt_Author_Textbook;
        private System.Windows.Forms.Label LB_Edition_Textbook;
        private System.Windows.Forms.Label LB_PHYear;
        private System.Windows.Forms.Label LB_Subject;
        private System.Windows.Forms.Label LB_Title;
        private System.Windows.Forms.Label LB_Status_Textbook;
        private System.Windows.Forms.Label LB_ISBN_Textbook;
        private System.Windows.Forms.Label LB_Author_Textbook;
        private System.Windows.Forms.Label LB_Textbook_ID;
        private System.Windows.Forms.DataGridView DataGrid_Textbook;
        private System.Windows.Forms.Button Bnt_Clear_TextBook;
        private System.Windows.Forms.Button Bnt_Search_TextBook;
        private System.Windows.Forms.TextBox TxtBx_Search_TextBook;
        private System.Windows.Forms.Label LB_Search_TextBook;
        private System.Windows.Forms.RadioButton RB_NotAvailable_Textbook;
        private System.Windows.Forms.RadioButton RB_available_Textbook;
        private System.Windows.Forms.TextBox Txt_Qty_Textbook;
        private System.Windows.Forms.TextBox Txt_Title_Textbook;
        private System.Windows.Forms.Button Bnt_Close_Textbook;
        private System.Windows.Forms.Button Bnt_Delete_Textbook;
        private System.Windows.Forms.Button Bnt_Update_Textbook;
        private System.Windows.Forms.Button Bnt_New_Textbook;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Year_Textbook;
        private System.Windows.Forms.PictureBox PicBox_Subjects;
        private System.Windows.Forms.Button Bnt_Close_Subject;
        private System.Windows.Forms.Button Bnt_Delete_Subject;
        private System.Windows.Forms.Button Bnt_Update_Subject;
        private System.Windows.Forms.Button Bnt_New_Subject;
        private System.Windows.Forms.TextBox Txt_Description_Subject;
        private System.Windows.Forms.TextBox Txt_Name_Subject;
        private System.Windows.Forms.Label LB_Description_Subject;
        private System.Windows.Forms.Label LB_Name_Subject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DataGrid_Subject;
        private System.Windows.Forms.Button Bnt_Clear_Subject;
        private System.Windows.Forms.Button Bnt_Search_Subject;
        private System.Windows.Forms.TextBox Txt_Search_Subject;
        private System.Windows.Forms.Label LB_Search_Subject;
        private System.Windows.Forms.Button Bnt_Close_Author;
        private System.Windows.Forms.Button Bnt_Delete_Author;
        private System.Windows.Forms.Button Bnt_Update_Author;
        private System.Windows.Forms.Button Bnt_New_Authors;
        private System.Windows.Forms.TextBox Txt_LastName_Author;
        private System.Windows.Forms.TextBox Txt_FirstName_Author;
        private System.Windows.Forms.Label LB_LastName_Authors;
        private System.Windows.Forms.Label LB_FirstName_Authors;
        private System.Windows.Forms.Label LB_Author_ID_Authors;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Bnt_Clear_Author;
        private System.Windows.Forms.Button Bnt_Search_Author;
        private System.Windows.Forms.TextBox Txt_Search_Author;
        private System.Windows.Forms.Label LB_Search_Authors;
        private System.Windows.Forms.PictureBox PicBx_Author;
        private System.Windows.Forms.ComboBox CB_DBSubjects_TextBooks;
        private System.Windows.Forms.Label LB_TextBook_ID_Textbook;
        private System.Windows.Forms.Label LB_Subject_ID_Subjects;
        private System.Windows.Forms.Label LB_Authros_ID_Authors;
    }
}