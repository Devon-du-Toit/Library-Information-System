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
            this.CB_DBSubjects_TextBooks = new System.Windows.Forms.ComboBox();
            this.LB_TextBook_ID_Textbook = new System.Windows.Forms.Label();
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
            this.Bnt_Search_TextBook = new System.Windows.Forms.Button();
            this.TxtBx_Search_TextBook = new System.Windows.Forms.TextBox();
            this.LB_Search_TextBook = new System.Windows.Forms.Label();
            this.Tab_Subjects = new System.Windows.Forms.TabPage();
            this.LB_Subject_ID_Subjects = new System.Windows.Forms.Label();
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
            this.LB_Authros_ID_Authors = new System.Windows.Forms.Label();
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
            this.dataGridView_Authors = new System.Windows.Forms.DataGridView();
            this.Txt_Search_Author = new System.Windows.Forms.TextBox();
            this.LB_Search_Authors = new System.Windows.Forms.Label();
            this.Bnt_Clear_Author = new System.Windows.Forms.Button();
            this.Bnt_Search_Author = new System.Windows.Forms.Button();
            this.TabControl_Library.SuspendLayout();
            this.Tab_TxtBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Textbook)).BeginInit();
            this.Tab_Subjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Subjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Subject)).BeginInit();
            this.Tab_Authors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_Author)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Authors)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl_Library
            // 
            this.TabControl_Library.Controls.Add(this.Tab_TxtBooks);
            this.TabControl_Library.Controls.Add(this.Tab_Subjects);
            this.TabControl_Library.Controls.Add(this.Tab_Authors);
            this.TabControl_Library.Location = new System.Drawing.Point(12, 12);
            this.TabControl_Library.Name = "TabControl_Library";
            this.TabControl_Library.SelectedIndex = 0;
            this.TabControl_Library.Size = new System.Drawing.Size(890, 426);
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
            this.Tab_TxtBooks.Controls.Add(this.Bnt_Search_TextBook);
            this.Tab_TxtBooks.Controls.Add(this.TxtBx_Search_TextBook);
            this.Tab_TxtBooks.Controls.Add(this.LB_Search_TextBook);
            this.Tab_TxtBooks.Location = new System.Drawing.Point(4, 22);
            this.Tab_TxtBooks.Name = "Tab_TxtBooks";
            this.Tab_TxtBooks.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_TxtBooks.Size = new System.Drawing.Size(882, 400);
            this.Tab_TxtBooks.TabIndex = 1;
            this.Tab_TxtBooks.Text = "Textbooks";
            // 
            // CB_DBSubjects_TextBooks
            // 
            this.CB_DBSubjects_TextBooks.FormattingEnabled = true;
            this.CB_DBSubjects_TextBooks.Location = new System.Drawing.Point(465, 264);
            this.CB_DBSubjects_TextBooks.Margin = new System.Windows.Forms.Padding(2);
            this.CB_DBSubjects_TextBooks.Name = "CB_DBSubjects_TextBooks";
            this.CB_DBSubjects_TextBooks.Size = new System.Drawing.Size(234, 21);
            this.CB_DBSubjects_TextBooks.TabIndex = 29;
            // 
            // LB_TextBook_ID_Textbook
            // 
            this.LB_TextBook_ID_Textbook.AutoSize = true;
            this.LB_TextBook_ID_Textbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TextBook_ID_Textbook.Location = new System.Drawing.Point(98, 222);
            this.LB_TextBook_ID_Textbook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_TextBook_ID_Textbook.Name = "LB_TextBook_ID_Textbook";
            this.LB_TextBook_ID_Textbook.Size = new System.Drawing.Size(156, 17);
            this.LB_TextBook_ID_Textbook.TabIndex = 28;
            this.LB_TextBook_ID_Textbook.Text = "\"ID to be generated\"";
            // 
            // dateTimePicker_Year_Textbook
            // 
            this.dateTimePicker_Year_Textbook.Location = new System.Drawing.Point(465, 312);
            this.dateTimePicker_Year_Textbook.Name = "dateTimePicker_Year_Textbook";
            this.dateTimePicker_Year_Textbook.Size = new System.Drawing.Size(234, 20);
            this.dateTimePicker_Year_Textbook.TabIndex = 27;
            // 
            // Bnt_Close_Textbook
            // 
            this.Bnt_Close_Textbook.BackColor = System.Drawing.Color.Red;
            this.Bnt_Close_Textbook.Location = new System.Drawing.Point(752, 371);
            this.Bnt_Close_Textbook.Name = "Bnt_Close_Textbook";
            this.Bnt_Close_Textbook.Size = new System.Drawing.Size(124, 23);
            this.Bnt_Close_Textbook.TabIndex = 26;
            this.Bnt_Close_Textbook.Text = "Close";
            this.Bnt_Close_Textbook.UseVisualStyleBackColor = false;
            // 
            // Bnt_Delete_Textbook
            // 
            this.Bnt_Delete_Textbook.BackColor = System.Drawing.Color.Silver;
            this.Bnt_Delete_Textbook.Location = new System.Drawing.Point(752, 305);
            this.Bnt_Delete_Textbook.Name = "Bnt_Delete_Textbook";
            this.Bnt_Delete_Textbook.Size = new System.Drawing.Size(124, 23);
            this.Bnt_Delete_Textbook.TabIndex = 25;
            this.Bnt_Delete_Textbook.Text = "Delete";
            this.Bnt_Delete_Textbook.UseVisualStyleBackColor = false;
            // 
            // Bnt_Update_Textbook
            // 
            this.Bnt_Update_Textbook.BackColor = System.Drawing.Color.LightBlue;
            this.Bnt_Update_Textbook.Location = new System.Drawing.Point(752, 261);
            this.Bnt_Update_Textbook.Name = "Bnt_Update_Textbook";
            this.Bnt_Update_Textbook.Size = new System.Drawing.Size(124, 23);
            this.Bnt_Update_Textbook.TabIndex = 24;
            this.Bnt_Update_Textbook.Text = "Update";
            this.Bnt_Update_Textbook.UseVisualStyleBackColor = false;
            // 
            // Bnt_New_Textbook
            // 
            this.Bnt_New_Textbook.BackColor = System.Drawing.Color.LightGreen;
            this.Bnt_New_Textbook.Location = new System.Drawing.Point(752, 222);
            this.Bnt_New_Textbook.Name = "Bnt_New_Textbook";
            this.Bnt_New_Textbook.Size = new System.Drawing.Size(124, 23);
            this.Bnt_New_Textbook.TabIndex = 22;
            this.Bnt_New_Textbook.Text = "New";
            this.Bnt_New_Textbook.UseVisualStyleBackColor = false;
            // 
            // Txt_Qty_Textbook
            // 
            this.Txt_Qty_Textbook.Location = new System.Drawing.Point(465, 351);
            this.Txt_Qty_Textbook.Name = "Txt_Qty_Textbook";
            this.Txt_Qty_Textbook.Size = new System.Drawing.Size(234, 20);
            this.Txt_Qty_Textbook.TabIndex = 21;
            // 
            // Txt_Title_Textbook
            // 
            this.Txt_Title_Textbook.Location = new System.Drawing.Point(465, 222);
            this.Txt_Title_Textbook.Name = "Txt_Title_Textbook";
            this.Txt_Title_Textbook.Size = new System.Drawing.Size(234, 20);
            this.Txt_Title_Textbook.TabIndex = 18;
            // 
            // RB_NotAvailable_Textbook
            // 
            this.RB_NotAvailable_Textbook.AutoSize = true;
            this.RB_NotAvailable_Textbook.Location = new System.Drawing.Point(229, 357);
            this.RB_NotAvailable_Textbook.Name = "RB_NotAvailable_Textbook";
            this.RB_NotAvailable_Textbook.Size = new System.Drawing.Size(88, 17);
            this.RB_NotAvailable_Textbook.TabIndex = 17;
            this.RB_NotAvailable_Textbook.TabStop = true;
            this.RB_NotAvailable_Textbook.Text = "Not Available";
            this.RB_NotAvailable_Textbook.UseVisualStyleBackColor = true;
            // 
            // RB_available_Textbook
            // 
            this.RB_available_Textbook.AutoSize = true;
            this.RB_available_Textbook.Location = new System.Drawing.Point(101, 357);
            this.RB_available_Textbook.Name = "RB_available_Textbook";
            this.RB_available_Textbook.Size = new System.Drawing.Size(68, 17);
            this.RB_available_Textbook.TabIndex = 16;
            this.RB_available_Textbook.TabStop = true;
            this.RB_available_Textbook.Text = "Available";
            this.RB_available_Textbook.UseVisualStyleBackColor = true;
            // 
            // Txt_ISBN_Textbook
            // 
            this.Txt_ISBN_Textbook.Location = new System.Drawing.Point(101, 312);
            this.Txt_ISBN_Textbook.Name = "Txt_ISBN_Textbook";
            this.Txt_ISBN_Textbook.Size = new System.Drawing.Size(234, 20);
            this.Txt_ISBN_Textbook.TabIndex = 15;
            // 
            // Txt_Author_Textbook
            // 
            this.Txt_Author_Textbook.Location = new System.Drawing.Point(101, 264);
            this.Txt_Author_Textbook.Name = "Txt_Author_Textbook";
            this.Txt_Author_Textbook.Size = new System.Drawing.Size(234, 20);
            this.Txt_Author_Textbook.TabIndex = 14;
            // 
            // LB_Edition_Textbook
            // 
            this.LB_Edition_Textbook.AutoSize = true;
            this.LB_Edition_Textbook.Location = new System.Drawing.Point(356, 357);
            this.LB_Edition_Textbook.Name = "LB_Edition_Textbook";
            this.LB_Edition_Textbook.Size = new System.Drawing.Size(42, 13);
            this.LB_Edition_Textbook.TabIndex = 12;
            this.LB_Edition_Textbook.Text = "Edition:";
            // 
            // LB_PHYear
            // 
            this.LB_PHYear.AutoSize = true;
            this.LB_PHYear.Location = new System.Drawing.Point(356, 312);
            this.LB_PHYear.Name = "LB_PHYear";
            this.LB_PHYear.Size = new System.Drawing.Size(84, 13);
            this.LB_PHYear.TabIndex = 11;
            this.LB_PHYear.Text = "Published_Year:";
            // 
            // LB_Subject
            // 
            this.LB_Subject.AutoSize = true;
            this.LB_Subject.Location = new System.Drawing.Point(356, 264);
            this.LB_Subject.Name = "LB_Subject";
            this.LB_Subject.Size = new System.Drawing.Size(46, 13);
            this.LB_Subject.TabIndex = 10;
            this.LB_Subject.Text = "Subject:";
            // 
            // LB_Title
            // 
            this.LB_Title.AutoSize = true;
            this.LB_Title.Location = new System.Drawing.Point(356, 222);
            this.LB_Title.Name = "LB_Title";
            this.LB_Title.Size = new System.Drawing.Size(30, 13);
            this.LB_Title.TabIndex = 9;
            this.LB_Title.Text = "Title:";
            // 
            // LB_Status_Textbook
            // 
            this.LB_Status_Textbook.AutoSize = true;
            this.LB_Status_Textbook.Location = new System.Drawing.Point(7, 357);
            this.LB_Status_Textbook.Name = "LB_Status_Textbook";
            this.LB_Status_Textbook.Size = new System.Drawing.Size(40, 13);
            this.LB_Status_Textbook.TabIndex = 8;
            this.LB_Status_Textbook.Text = "Status:";
            // 
            // LB_ISBN_Textbook
            // 
            this.LB_ISBN_Textbook.AutoSize = true;
            this.LB_ISBN_Textbook.Location = new System.Drawing.Point(7, 312);
            this.LB_ISBN_Textbook.Name = "LB_ISBN_Textbook";
            this.LB_ISBN_Textbook.Size = new System.Drawing.Size(35, 13);
            this.LB_ISBN_Textbook.TabIndex = 7;
            this.LB_ISBN_Textbook.Text = "ISBN:";
            // 
            // LB_Author_Textbook
            // 
            this.LB_Author_Textbook.AutoSize = true;
            this.LB_Author_Textbook.Location = new System.Drawing.Point(7, 264);
            this.LB_Author_Textbook.Name = "LB_Author_Textbook";
            this.LB_Author_Textbook.Size = new System.Drawing.Size(41, 13);
            this.LB_Author_Textbook.TabIndex = 6;
            this.LB_Author_Textbook.Text = "Author:";
            // 
            // LB_Textbook_ID
            // 
            this.LB_Textbook_ID.AutoSize = true;
            this.LB_Textbook_ID.Location = new System.Drawing.Point(7, 222);
            this.LB_Textbook_ID.Name = "LB_Textbook_ID";
            this.LB_Textbook_ID.Size = new System.Drawing.Size(73, 13);
            this.LB_Textbook_ID.TabIndex = 5;
            this.LB_Textbook_ID.Text = "TextBook_ID:";
            // 
            // DataGrid_Textbook
            // 
            this.DataGrid_Textbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Textbook.Location = new System.Drawing.Point(6, 35);
            this.DataGrid_Textbook.Name = "DataGrid_Textbook";
            this.DataGrid_Textbook.RowHeadersWidth = 51;
            this.DataGrid_Textbook.RowTemplate.Height = 24;
            this.DataGrid_Textbook.Size = new System.Drawing.Size(870, 180);
            this.DataGrid_Textbook.TabIndex = 4;
            // 
            // Bnt_Search_TextBook
            // 
            this.Bnt_Search_TextBook.BackgroundImage = global::CMPG223_Group4_Project.Properties.Resources.Magnifying_glass;
            this.Bnt_Search_TextBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bnt_Search_TextBook.Location = new System.Drawing.Point(599, 6);
            this.Bnt_Search_TextBook.Name = "Bnt_Search_TextBook";
            this.Bnt_Search_TextBook.Size = new System.Drawing.Size(124, 23);
            this.Bnt_Search_TextBook.TabIndex = 2;
            this.Bnt_Search_TextBook.UseVisualStyleBackColor = true;
            // 
            // TxtBx_Search_TextBook
            // 
            this.TxtBx_Search_TextBook.Location = new System.Drawing.Point(101, 7);
            this.TxtBx_Search_TextBook.Name = "TxtBx_Search_TextBook";
            this.TxtBx_Search_TextBook.Size = new System.Drawing.Size(234, 20);
            this.TxtBx_Search_TextBook.TabIndex = 1;
            // 
            // LB_Search_TextBook
            // 
            this.LB_Search_TextBook.AutoSize = true;
            this.LB_Search_TextBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Search_TextBook.Location = new System.Drawing.Point(13, 4);
            this.LB_Search_TextBook.Name = "LB_Search_TextBook";
            this.LB_Search_TextBook.Size = new System.Drawing.Size(82, 24);
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
            this.Tab_Subjects.Location = new System.Drawing.Point(4, 22);
            this.Tab_Subjects.Name = "Tab_Subjects";
            this.Tab_Subjects.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Subjects.Size = new System.Drawing.Size(882, 400);
            this.Tab_Subjects.TabIndex = 2;
            this.Tab_Subjects.Text = "Subjects";
            // 
            // LB_Subject_ID_Subjects
            // 
            this.LB_Subject_ID_Subjects.AutoSize = true;
            this.LB_Subject_ID_Subjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Subject_ID_Subjects.Location = new System.Drawing.Point(98, 223);
            this.LB_Subject_ID_Subjects.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Subject_ID_Subjects.Name = "LB_Subject_ID_Subjects";
            this.LB_Subject_ID_Subjects.Size = new System.Drawing.Size(156, 17);
            this.LB_Subject_ID_Subjects.TabIndex = 43;
            this.LB_Subject_ID_Subjects.Text = "\"ID to be generated\"";
            // 
            // PicBox_Subjects
            // 
            this.PicBox_Subjects.BackgroundImage = global::CMPG223_Group4_Project.Properties.Resources.Subject_Icon;
            this.PicBox_Subjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBox_Subjects.Location = new System.Drawing.Point(350, 223);
            this.PicBox_Subjects.Name = "PicBox_Subjects";
            this.PicBox_Subjects.Size = new System.Drawing.Size(396, 171);
            this.PicBox_Subjects.TabIndex = 42;
            this.PicBox_Subjects.TabStop = false;
            // 
            // Bnt_Close_Subject
            // 
            this.Bnt_Close_Subject.BackColor = System.Drawing.Color.Red;
            this.Bnt_Close_Subject.Location = new System.Drawing.Point(752, 372);
            this.Bnt_Close_Subject.Name = "Bnt_Close_Subject";
            this.Bnt_Close_Subject.Size = new System.Drawing.Size(124, 23);
            this.Bnt_Close_Subject.TabIndex = 41;
            this.Bnt_Close_Subject.Text = "Close";
            this.Bnt_Close_Subject.UseVisualStyleBackColor = false;
            // 
            // Bnt_Delete_Subject
            // 
            this.Bnt_Delete_Subject.BackColor = System.Drawing.Color.Silver;
            this.Bnt_Delete_Subject.Location = new System.Drawing.Point(752, 306);
            this.Bnt_Delete_Subject.Name = "Bnt_Delete_Subject";
            this.Bnt_Delete_Subject.Size = new System.Drawing.Size(124, 23);
            this.Bnt_Delete_Subject.TabIndex = 40;
            this.Bnt_Delete_Subject.Text = "Delete";
            this.Bnt_Delete_Subject.UseVisualStyleBackColor = false;
            // 
            // Bnt_Update_Subject
            // 
            this.Bnt_Update_Subject.BackColor = System.Drawing.Color.LightBlue;
            this.Bnt_Update_Subject.Location = new System.Drawing.Point(752, 262);
            this.Bnt_Update_Subject.Name = "Bnt_Update_Subject";
            this.Bnt_Update_Subject.Size = new System.Drawing.Size(124, 23);
            this.Bnt_Update_Subject.TabIndex = 39;
            this.Bnt_Update_Subject.Text = "Update";
            this.Bnt_Update_Subject.UseVisualStyleBackColor = false;
            // 
            // Bnt_New_Subject
            // 
            this.Bnt_New_Subject.BackColor = System.Drawing.Color.LightGreen;
            this.Bnt_New_Subject.Location = new System.Drawing.Point(752, 223);
            this.Bnt_New_Subject.Name = "Bnt_New_Subject";
            this.Bnt_New_Subject.Size = new System.Drawing.Size(124, 23);
            this.Bnt_New_Subject.TabIndex = 38;
            this.Bnt_New_Subject.Text = "New";
            this.Bnt_New_Subject.UseVisualStyleBackColor = false;
            // 
            // Txt_Description_Subject
            // 
            this.Txt_Description_Subject.Location = new System.Drawing.Point(101, 313);
            this.Txt_Description_Subject.Name = "Txt_Description_Subject";
            this.Txt_Description_Subject.Size = new System.Drawing.Size(234, 20);
            this.Txt_Description_Subject.TabIndex = 37;
            // 
            // Txt_Name_Subject
            // 
            this.Txt_Name_Subject.Location = new System.Drawing.Point(101, 265);
            this.Txt_Name_Subject.Name = "Txt_Name_Subject";
            this.Txt_Name_Subject.Size = new System.Drawing.Size(234, 20);
            this.Txt_Name_Subject.TabIndex = 36;
            // 
            // LB_Description_Subject
            // 
            this.LB_Description_Subject.AutoSize = true;
            this.LB_Description_Subject.Location = new System.Drawing.Point(7, 313);
            this.LB_Description_Subject.Name = "LB_Description_Subject";
            this.LB_Description_Subject.Size = new System.Drawing.Size(60, 13);
            this.LB_Description_Subject.TabIndex = 34;
            this.LB_Description_Subject.Text = "Description";
            // 
            // LB_Name_Subject
            // 
            this.LB_Name_Subject.AutoSize = true;
            this.LB_Name_Subject.Location = new System.Drawing.Point(7, 265);
            this.LB_Name_Subject.Name = "LB_Name_Subject";
            this.LB_Name_Subject.Size = new System.Drawing.Size(38, 13);
            this.LB_Name_Subject.TabIndex = 33;
            this.LB_Name_Subject.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Subject_ID:";
            // 
            // DataGrid_Subject
            // 
            this.DataGrid_Subject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Subject.Location = new System.Drawing.Point(6, 36);
            this.DataGrid_Subject.Name = "DataGrid_Subject";
            this.DataGrid_Subject.RowHeadersWidth = 51;
            this.DataGrid_Subject.RowTemplate.Height = 24;
            this.DataGrid_Subject.Size = new System.Drawing.Size(870, 180);
            this.DataGrid_Subject.TabIndex = 31;
            // 
            // Txt_Search_Subject
            // 
            this.Txt_Search_Subject.Location = new System.Drawing.Point(101, 8);
            this.Txt_Search_Subject.Name = "Txt_Search_Subject";
            this.Txt_Search_Subject.Size = new System.Drawing.Size(234, 20);
            this.Txt_Search_Subject.TabIndex = 28;
            // 
            // LB_Search_Subject
            // 
            this.LB_Search_Subject.AutoSize = true;
            this.LB_Search_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Search_Subject.Location = new System.Drawing.Point(13, 5);
            this.LB_Search_Subject.Name = "LB_Search_Subject";
            this.LB_Search_Subject.Size = new System.Drawing.Size(82, 24);
            this.LB_Search_Subject.TabIndex = 27;
            this.LB_Search_Subject.Text = "Search:";
            // 
            // Bnt_Clear_Subject
            // 
            this.Bnt_Clear_Subject.BackgroundImage = global::CMPG223_Group4_Project.Properties.Resources.Clear_Icon;
            this.Bnt_Clear_Subject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bnt_Clear_Subject.Location = new System.Drawing.Point(752, 7);
            this.Bnt_Clear_Subject.Name = "Bnt_Clear_Subject";
            this.Bnt_Clear_Subject.Size = new System.Drawing.Size(124, 23);
            this.Bnt_Clear_Subject.TabIndex = 30;
            this.Bnt_Clear_Subject.UseVisualStyleBackColor = true;
            // 
            // Bnt_Search_Subject
            // 
            this.Bnt_Search_Subject.BackgroundImage = global::CMPG223_Group4_Project.Properties.Resources.Magnifying_glass;
            this.Bnt_Search_Subject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bnt_Search_Subject.Location = new System.Drawing.Point(599, 7);
            this.Bnt_Search_Subject.Name = "Bnt_Search_Subject";
            this.Bnt_Search_Subject.Size = new System.Drawing.Size(124, 23);
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
            this.Tab_Authors.Controls.Add(this.dataGridView_Authors);
            this.Tab_Authors.Controls.Add(this.Txt_Search_Author);
            this.Tab_Authors.Controls.Add(this.LB_Search_Authors);
            this.Tab_Authors.Controls.Add(this.Bnt_Clear_Author);
            this.Tab_Authors.Controls.Add(this.Bnt_Search_Author);
            this.Tab_Authors.Location = new System.Drawing.Point(4, 22);
            this.Tab_Authors.Name = "Tab_Authors";
            this.Tab_Authors.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Authors.Size = new System.Drawing.Size(882, 400);
            this.Tab_Authors.TabIndex = 3;
            this.Tab_Authors.Text = "Authors";
            // 
            // LB_Authros_ID_Authors
            // 
            this.LB_Authros_ID_Authors.AutoSize = true;
            this.LB_Authros_ID_Authors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Authros_ID_Authors.Location = new System.Drawing.Point(98, 223);
            this.LB_Authros_ID_Authors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Authros_ID_Authors.Name = "LB_Authros_ID_Authors";
            this.LB_Authros_ID_Authors.Size = new System.Drawing.Size(225, 17);
            this.LB_Authros_ID_Authors.TabIndex = 58;
            this.LB_Authros_ID_Authors.Text = "\"Select an entry to display ID\"";
            // 
            // PicBx_Author
            // 
            this.PicBx_Author.BackgroundImage = global::CMPG223_Group4_Project.Properties.Resources.Author_Icon;
            this.PicBx_Author.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBx_Author.Location = new System.Drawing.Point(354, 223);
            this.PicBx_Author.Name = "PicBx_Author";
            this.PicBx_Author.Size = new System.Drawing.Size(392, 171);
            this.PicBx_Author.TabIndex = 57;
            this.PicBx_Author.TabStop = false;
            // 
            // Bnt_Close_Author
            // 
            this.Bnt_Close_Author.BackColor = System.Drawing.Color.Red;
            this.Bnt_Close_Author.Location = new System.Drawing.Point(752, 372);
            this.Bnt_Close_Author.Name = "Bnt_Close_Author";
            this.Bnt_Close_Author.Size = new System.Drawing.Size(124, 23);
            this.Bnt_Close_Author.TabIndex = 56;
            this.Bnt_Close_Author.Text = "Close";
            this.Bnt_Close_Author.UseVisualStyleBackColor = false;
            // 
            // Bnt_Delete_Author
            // 
            this.Bnt_Delete_Author.BackColor = System.Drawing.Color.Silver;
            this.Bnt_Delete_Author.Location = new System.Drawing.Point(752, 306);
            this.Bnt_Delete_Author.Name = "Bnt_Delete_Author";
            this.Bnt_Delete_Author.Size = new System.Drawing.Size(124, 23);
            this.Bnt_Delete_Author.TabIndex = 55;
            this.Bnt_Delete_Author.Text = "Delete";
            this.Bnt_Delete_Author.UseVisualStyleBackColor = false;
            // 
            // Bnt_Update_Author
            // 
            this.Bnt_Update_Author.BackColor = System.Drawing.Color.LightBlue;
            this.Bnt_Update_Author.Location = new System.Drawing.Point(752, 262);
            this.Bnt_Update_Author.Name = "Bnt_Update_Author";
            this.Bnt_Update_Author.Size = new System.Drawing.Size(124, 23);
            this.Bnt_Update_Author.TabIndex = 54;
            this.Bnt_Update_Author.Text = "Update";
            this.Bnt_Update_Author.UseVisualStyleBackColor = false;
            // 
            // Bnt_New_Authors
            // 
            this.Bnt_New_Authors.BackColor = System.Drawing.Color.LightGreen;
            this.Bnt_New_Authors.Location = new System.Drawing.Point(752, 223);
            this.Bnt_New_Authors.Name = "Bnt_New_Authors";
            this.Bnt_New_Authors.Size = new System.Drawing.Size(124, 23);
            this.Bnt_New_Authors.TabIndex = 53;
            this.Bnt_New_Authors.Text = "New";
            this.Bnt_New_Authors.UseVisualStyleBackColor = false;
            // 
            // Txt_LastName_Author
            // 
            this.Txt_LastName_Author.Location = new System.Drawing.Point(101, 313);
            this.Txt_LastName_Author.Name = "Txt_LastName_Author";
            this.Txt_LastName_Author.Size = new System.Drawing.Size(234, 20);
            this.Txt_LastName_Author.TabIndex = 52;
            // 
            // Txt_FirstName_Author
            // 
            this.Txt_FirstName_Author.Location = new System.Drawing.Point(101, 265);
            this.Txt_FirstName_Author.Name = "Txt_FirstName_Author";
            this.Txt_FirstName_Author.Size = new System.Drawing.Size(234, 20);
            this.Txt_FirstName_Author.TabIndex = 51;
            // 
            // LB_LastName_Authors
            // 
            this.LB_LastName_Authors.AutoSize = true;
            this.LB_LastName_Authors.Location = new System.Drawing.Point(7, 313);
            this.LB_LastName_Authors.Name = "LB_LastName_Authors";
            this.LB_LastName_Authors.Size = new System.Drawing.Size(61, 13);
            this.LB_LastName_Authors.TabIndex = 49;
            this.LB_LastName_Authors.Text = "Last Name:";
            // 
            // LB_FirstName_Authors
            // 
            this.LB_FirstName_Authors.AutoSize = true;
            this.LB_FirstName_Authors.Location = new System.Drawing.Point(7, 265);
            this.LB_FirstName_Authors.Name = "LB_FirstName_Authors";
            this.LB_FirstName_Authors.Size = new System.Drawing.Size(60, 13);
            this.LB_FirstName_Authors.TabIndex = 48;
            this.LB_FirstName_Authors.Text = "First Name:";
            // 
            // LB_Author_ID_Authors
            // 
            this.LB_Author_ID_Authors.AutoSize = true;
            this.LB_Author_ID_Authors.Location = new System.Drawing.Point(7, 223);
            this.LB_Author_ID_Authors.Name = "LB_Author_ID_Authors";
            this.LB_Author_ID_Authors.Size = new System.Drawing.Size(58, 13);
            this.LB_Author_ID_Authors.TabIndex = 47;
            this.LB_Author_ID_Authors.Text = "Author_ID:";
            // 
            // dataGridView_Authors
            // 
            this.dataGridView_Authors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Authors.Location = new System.Drawing.Point(6, 36);
            this.dataGridView_Authors.Name = "dataGridView_Authors";
            this.dataGridView_Authors.RowHeadersWidth = 51;
            this.dataGridView_Authors.RowTemplate.Height = 24;
            this.dataGridView_Authors.Size = new System.Drawing.Size(870, 180);
            this.dataGridView_Authors.TabIndex = 46;
            // 
            // Txt_Search_Author
            // 
            this.Txt_Search_Author.Location = new System.Drawing.Point(101, 8);
            this.Txt_Search_Author.Name = "Txt_Search_Author";
            this.Txt_Search_Author.Size = new System.Drawing.Size(234, 20);
            this.Txt_Search_Author.TabIndex = 43;
            // 
            // LB_Search_Authors
            // 
            this.LB_Search_Authors.AutoSize = true;
            this.LB_Search_Authors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Search_Authors.Location = new System.Drawing.Point(13, 5);
            this.LB_Search_Authors.Name = "LB_Search_Authors";
            this.LB_Search_Authors.Size = new System.Drawing.Size(82, 24);
            this.LB_Search_Authors.TabIndex = 42;
            this.LB_Search_Authors.Text = "Search:";
            // 
            // Bnt_Clear_Author
            // 
            this.Bnt_Clear_Author.BackgroundImage = global::CMPG223_Group4_Project.Properties.Resources.Clear_Icon;
            this.Bnt_Clear_Author.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bnt_Clear_Author.Location = new System.Drawing.Point(752, 7);
            this.Bnt_Clear_Author.Name = "Bnt_Clear_Author";
            this.Bnt_Clear_Author.Size = new System.Drawing.Size(124, 23);
            this.Bnt_Clear_Author.TabIndex = 45;
            this.Bnt_Clear_Author.UseVisualStyleBackColor = true;
            // 
            // Bnt_Search_Author
            // 
            this.Bnt_Search_Author.BackgroundImage = global::CMPG223_Group4_Project.Properties.Resources.Magnifying_glass;
            this.Bnt_Search_Author.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bnt_Search_Author.Location = new System.Drawing.Point(599, 7);
            this.Bnt_Search_Author.Name = "Bnt_Search_Author";
            this.Bnt_Search_Author.Size = new System.Drawing.Size(124, 23);
            this.Bnt_Search_Author.TabIndex = 44;
            this.Bnt_Search_Author.UseVisualStyleBackColor = true;
            // 
            // LibraryMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 459);
            this.Controls.Add(this.TabControl_Library);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Authors)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView_Authors;
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