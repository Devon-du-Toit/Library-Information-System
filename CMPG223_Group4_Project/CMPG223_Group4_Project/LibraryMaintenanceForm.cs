using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace CMPG223_Group4_Project
{
    public enum LibraryTab { Textbooks, Subjects, Authors }

    public partial class LibraryMaintenanceForm : Form
    {
        public LibraryMaintenanceForm()
        {
            InitializeComponent();

            LoadTextbookLookups();

            // initial load for whichever tab is selected at startup
            this.Load += (s, e) =>
            {
                if (TabControl_Library.SelectedTab == Tab_TxtBooks) LoadTextbooks();
                else if (TabControl_Library.SelectedTab == Tab_Subjects) LoadSubjects();
                else if (TabControl_Library.SelectedTab == Tab_Authors) LoadAuthors();
            };

            // reload when switching tabs
            TabControl_Library.SelectedIndexChanged += TabControl_Library_SelectedIndexChanged;

            // textbook grid setup
            DataGrid_Textbook.ReadOnly = true;
            DataGrid_Textbook.AllowUserToAddRows = false;
            DataGrid_Textbook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGrid_Textbook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // subject grid setup
            DataGrid_Subject.ReadOnly = true;
            DataGrid_Subject.AllowUserToAddRows = false;
            DataGrid_Subject.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGrid_Subject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // author grid setup
            dataGridView_Authors.ReadOnly = true;
            dataGridView_Authors.AllowUserToAddRows = false;
            dataGridView_Authors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Authors.MultiSelect = false;
            dataGridView_Authors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Authors.SelectionChanged += dataGridView_Authors_SelectionChanged;

            DataGrid_Textbook.SelectionChanged += DataGrid_Textbook_SelectionChanged;

            DataGrid_Subject.SelectionChanged += DataGrid_Subject_SelectionChanged;


        }

        public LibraryMaintenanceForm(LibraryTab tabToSelect) : this()
        {
            switch (tabToSelect)
            {
                case LibraryTab.Textbooks: TabControl_Library.SelectedTab = Tab_TxtBooks; break;
                case LibraryTab.Subjects: TabControl_Library.SelectedTab = Tab_Subjects; break;
                case LibraryTab.Authors: TabControl_Library.SelectedTab = Tab_Authors; break;
            }
        }

        private void UpdateSubjectDetailsFromGrid()
        {
            if (DataGrid_Subject.CurrentRow == null)
            {
                LB_Subject_ID_Subjects.Text = "\"ID to be generated\"";
                Txt_Name_Subject.Text = string.Empty;
                Txt_Description_Subject.Text = string.Empty;
                return;
            }

            var row = DataGrid_Subject.CurrentRow;
            LB_Subject_ID_Subjects.Text = row.Cells["Subject_ID"]?.Value?.ToString() ?? "N/A";
            Txt_Name_Subject.Text = row.Cells["Subject_Name"]?.Value?.ToString() ?? string.Empty;
            Txt_Description_Subject.Text = row.Cells["Subject_Description"]?.Value?.ToString() ?? string.Empty;
        }

        private void DataGrid_Subject_SelectionChanged(object sender, EventArgs e)
        {
            UpdateSubjectDetailsFromGrid();
        }


        private enum SaveMode { Insert, Update }

        private string ConnString => ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;

        private int? GetSelectedId(DataGridView grid, string idColumn)
        {
            var row = grid?.CurrentRow;
            if (row == null) return null;
            return int.TryParse(row.Cells[idColumn]?.Value?.ToString(), out var id) ? id : (int?)null;
        }

        private bool ValidateAuthor(bool forInsert)
        {
            if (string.IsNullOrWhiteSpace(Txt_FirstName_Author.Text)) { MessageBox.Show("First name required."); return false; }
            if (string.IsNullOrWhiteSpace(Txt_LastName_Author.Text)) { MessageBox.Show("Last name required."); return false; }
            return true;
        }

        private void TabControl_Library_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl_Library.SelectedTab == Tab_TxtBooks)
            {
                LoadTextbookLookups();   // ensure combos are populated
                LoadTextbooks();
            }
            else if (TabControl_Library.SelectedTab == Tab_Subjects) LoadSubjects();
            else if (TabControl_Library.SelectedTab == Tab_Authors) LoadAuthors();
        }

        private void SaveAuthor(SaveMode mode)
        {
            bool forInsert = mode == SaveMode.Insert;
            if (!ValidateAuthor(forInsert)) return;

            string first = Txt_FirstName_Author.Text.Trim();
            string last = Txt_LastName_Author.Text.Trim();
            int? authorId = null;

            if (!forInsert)
            {
                authorId = GetSelectedId(dataGridView_Authors, "Author_ID");
                if (!authorId.HasValue) { MessageBox.Show("Select an author to update."); return; }
            }

            try
            {
                using (var conn = new MySqlConnection(ConnString))
                {
                    conn.Open();
                    if (forInsert)
                    {
                        const string sql = @"INSERT INTO AUTHOR (Author_Name, Author_LastName)
                                     VALUES (@first, @last);";
                        using (var cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@first", first);
                            cmd.Parameters.AddWithValue("@last", last);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Author added.");
                    }
                    else
                    {
                        const string sql = @"UPDATE AUTHOR
                                        SET Author_Name=@first, Author_LastName=@last
                                      WHERE Author_ID=@id;";
                        using (var cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@first", first);
                            cmd.Parameters.AddWithValue("@last", last);
                            cmd.Parameters.AddWithValue("@id", authorId.Value);
                            var rows = cmd.ExecuteNonQuery();
                            MessageBox.Show(rows == 0 ? "No author updated." : "Author updated.");
                        }
                    }
                }
                LoadAuthors();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save author failed:\n" + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchAuthors(string term)
        {
            if (string.IsNullOrWhiteSpace(term)) { LoadAuthors(); return; }

            try
            {
                using (var conn = new MySqlConnection(ConnString))
                {
                    conn.Open();
                    const string sql = @"
                SELECT a.Author_ID,
                       a.Author_Name     AS FirstName,
                       a.Author_LastName AS LastName
                  FROM AUTHOR a
                 WHERE CAST(a.Author_ID AS CHAR) LIKE @q
                    OR a.Author_Name              LIKE @q
                    OR a.Author_LastName          LIKE @q
                 ORDER BY a.Author_LastName, a.Author_Name;";
                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@q", "%" + term + "%");
                        var dt = new DataTable();
                        da.Fill(dt);
                        dataGridView_Authors.AutoGenerateColumns = true;
                        dataGridView_Authors.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search authors failed:\n" + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTextbooks()
        {
            try
            {
                using (var conn = new MySqlConnection(ConnString))
                {
                    conn.Open();
                    const string sql = @"
                SELECT
                    t.TextBook_ID,
                    t.Subject_ID,                          -- hidden for mapping
                    t.Author_ID,                           -- hidden for mapping
                    s.Subject_Name AS Subject,
                    CONCAT(a.Author_Name, ' ', a.Author_LastName) AS Author,
                    t.Title, t.ISBN, t.Edition,
                    t.Publish_Year AS PublishYear,
                    t.Status
                FROM TEXTBOOK t
                INNER JOIN SUBJECT s ON t.Subject_ID = s.Subject_ID
                INNER JOIN AUTHOR  a ON t.Author_ID  = a.Author_ID
                ORDER BY t.Title;";
                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        DataGrid_Textbook.AutoGenerateColumns = true;
                        DataGrid_Textbook.DataSource = dt;
                        // hide the ID columns (do this after DataSource is set)
                        if (DataGrid_Textbook.Columns.Contains("Subject_ID"))
                            DataGrid_Textbook.Columns["Subject_ID"].Visible = false;
                        if (DataGrid_Textbook.Columns.Contains("Author_ID"))
                            DataGrid_Textbook.Columns["Author_ID"].Visible = false;
                        if (DataGrid_Textbook.Rows.Count > 0)
                        {
                            DataGrid_Textbook.Rows[0].Selected = true;
                            LB_TextBook_ID_Textbook.Text = DataGrid_Textbook.Rows[0].Cells["TextBook_ID"]?.Value?.ToString() ?? "N/A";
                        }
                        else
                        {
                            LB_TextBook_ID_Textbook.Text = "\"ID to be generated\"";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load textbooks:\n\n" + ex, "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateTextbook(bool forInsert)
        {
            if (CB_DBSubjects_TextBooks.SelectedValue == null) { MessageBox.Show("Select a subject."); return false; }
            if (string.IsNullOrWhiteSpace(Txt_Title_Textbook.Text)) { MessageBox.Show("Title required."); return false; }
            if (string.IsNullOrWhiteSpace(Txt_ISBN_Textbook.Text)) { MessageBox.Show("ISBN required."); return false; }
            if (string.IsNullOrWhiteSpace(Txt_Qty_Textbook.Text)) { MessageBox.Show("Edition required."); return false; }
            if (string.IsNullOrWhiteSpace(Cmb_Author_Textbook.Text)) { MessageBox.Show("Author name required."); return false; }

            var status = GetStatusFromRadios();
            if (status == null) { MessageBox.Show("Select status (Available / Not Available)."); return false; }

            return true;
        }


        private void SaveTextbook(SaveMode mode)
        {
            bool forInsert = mode == SaveMode.Insert;
            if (!ValidateTextbook(forInsert)) return;

            int subjectId = Convert.ToInt32(CB_DBSubjects_TextBooks.SelectedValue);
            string title = Txt_Title_Textbook.Text.Trim();
            string isbn = Txt_ISBN_Textbook.Text.Trim();
            string edition = Txt_Qty_Textbook.Text.Trim();
            int publishYr = dateTimePicker_Year_Textbook.Value.Year;

            bool status = GetStatusFromRadios().Value;

            int? textBookId = null;
            if (!forInsert)
            {
                textBookId = GetSelectedId(DataGrid_Textbook, "TextBook_ID");
                if (!textBookId.HasValue) { MessageBox.Show("Select a textbook to update."); return; }
            }

            try
            {
                using (var conn = new MySqlConnection(ConnString))
                {
                    conn.Open();

                    if (forInsert)
                    {
                        const string sql = @"
                    INSERT INTO TEXTBOOK
                        (Subject_ID, Author_ID, Title, ISBN, Edition, Publish_Year, Status)
                    VALUES
                        (@sid, @aid, @title, @isbn, @edition, @year, @status);";
                        using (var cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@sid", subjectId);
                            int authorId = ResolveAuthorIdByName(conn, Cmb_Author_Textbook.Text.Trim());
                            cmd.Parameters.AddWithValue("@aid", authorId);
                            cmd.Parameters.AddWithValue("@title", title);
                            cmd.Parameters.AddWithValue("@isbn", isbn);
                            cmd.Parameters.AddWithValue("@edition", edition);
                            cmd.Parameters.AddWithValue("@year", publishYr);
                            cmd.Parameters.AddWithValue("@status", status);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Textbook added.");
                    }
                    else
                    {
                        const string sql = @"
                    UPDATE TEXTBOOK
                       SET Subject_ID=@sid, Author_ID=@aid, Title=@title,
                           ISBN=@isbn, Edition=@edition, Publish_Year=@year, Status=@status
                     WHERE TextBook_ID=@id;";
                        using (var cmd = new MySqlCommand(sql, conn))
                        {
                            int authorId = ResolveAuthorIdByName(conn, Cmb_Author_Textbook.Text.Trim());
                            cmd.Parameters.AddWithValue("@sid", subjectId);
                            cmd.Parameters.AddWithValue("@aid", authorId);
                            cmd.Parameters.AddWithValue("@title", title);
                            cmd.Parameters.AddWithValue("@isbn", isbn);
                            cmd.Parameters.AddWithValue("@edition", edition);
                            cmd.Parameters.AddWithValue("@year", publishYr);
                            cmd.Parameters.AddWithValue("@status", status);
                            cmd.Parameters.AddWithValue("@id", textBookId.Value);
                            var rows = cmd.ExecuteNonQuery();
                            MessageBox.Show(rows == 0 ? "No textbook updated." : "Textbook updated.");
                        }
                    }
                }
                LoadTextbooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save textbook failed:\n" + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ResolveAuthorIdByName(MySqlConnection conn, string authorFullName)
        {
            if (string.IsNullOrWhiteSpace(authorFullName))
                throw new Exception("Author name cannot be empty.");

            // Split "First Last" into parts
            var parts = authorFullName.Trim().Split(new[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);
            string first = parts.Length >= 1 ? parts[0] : "";
            string last = parts.Length == 2 ? parts[1] : "";

            // Try to find an existing author
            using (var cmd = new MySqlCommand(
                "SELECT Author_ID FROM AUTHOR WHERE Author_Name=@first AND Author_LastName=@last LIMIT 1;", conn))
            {
                cmd.Parameters.AddWithValue("@first", first);
                cmd.Parameters.AddWithValue("@last", last);
                var result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                    return Convert.ToInt32(result);
            }

            // Not found → create new author
            using (var cmd = new MySqlCommand(
                "INSERT INTO AUTHOR(Author_Name, Author_LastName) VALUES(@first, @last); SELECT LAST_INSERT_ID();", conn))
            {
                cmd.Parameters.AddWithValue("@first", first);
                cmd.Parameters.AddWithValue("@last", last);
                var id = cmd.ExecuteScalar();
                return Convert.ToInt32(id);
            }
        }

        private void SearchTextbooks(string term)
        {
            if (string.IsNullOrWhiteSpace(term)) { LoadTextbooks(); return; }

            bool? statusFilter = null;
            var t = term.Trim().ToLowerInvariant();
            if (t == "available" || t == "true" || t == "1") statusFilter = true;
            else if (t == "not available" || t == "false" || t == "0") statusFilter = false;

            try
            {
                using (var conn = new MySqlConnection(ConnString))
                {
                    conn.Open();

                    string sqlLike = @"
                SELECT
                    t.TextBook_ID, t.Subject_ID, t.Author_ID,
                    s.Subject_Name AS Subject,
                    CONCAT(a.Author_Name, ' ', a.Author_LastName) AS Author,
                    t.Title, t.ISBN, t.Edition,
                    t.Publish_Year AS PublishYear,
                    t.Status
                FROM TEXTBOOK t
                INNER JOIN SUBJECT s ON t.Subject_ID = s.Subject_ID
                INNER JOIN AUTHOR  a ON t.Author_ID  = a.Author_ID
                WHERE (CAST(t.TextBook_ID AS CHAR) LIKE @q
                    OR s.Subject_Name LIKE @q
                    OR a.Author_Name LIKE @q
                    OR a.Author_LastName LIKE @q
                    OR t.Title LIKE @q
                    OR t.ISBN  LIKE @q
                    OR t.Edition LIKE @q
                    OR CAST(t.Publish_Year AS CHAR) LIKE @q)";

                    if (statusFilter.HasValue)
                        sqlLike += " OR t.Status = @status";

                    sqlLike += " ORDER BY t.Title;";

                    using (var da = new MySqlDataAdapter(sqlLike, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@q", "%" + term + "%");
                        if (statusFilter.HasValue)
                            da.SelectCommand.Parameters.AddWithValue("@status", statusFilter.Value);

                        var dt = new DataTable();
                        da.Fill(dt);
                        DataGrid_Textbook.AutoGenerateColumns = true;
                        DataGrid_Textbook.DataSource = dt;
                        if (DataGrid_Textbook.Columns.Contains("Subject_ID"))
                            DataGrid_Textbook.Columns["Subject_ID"].Visible = false;
                        if (DataGrid_Textbook.Columns.Contains("Author_ID"))
                            DataGrid_Textbook.Columns["Author_ID"].Visible = false;
                        if (DataGrid_Textbook.Rows.Count > 0)
                        {
                            DataGrid_Textbook.Rows[0].Selected = true;
                            LB_TextBook_ID_Textbook.Text = DataGrid_Textbook.Rows[0].Cells["TextBook_ID"]?.Value?.ToString() ?? "N/A";
                        }
                        else
                        {
                            LB_TextBook_ID_Textbook.Text = "\"ID to be generated\"";
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search textbooks failed:\n" + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DataGrid_Textbook_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGrid_Textbook.CurrentRow == null)
            {
                LB_TextBook_ID_Textbook.Text = "\"ID to be generated\"";
                return;
            }

            var row = DataGrid_Textbook.CurrentRow;
            LB_TextBook_ID_Textbook.Text = row.Cells["TextBook_ID"]?.Value?.ToString() ?? "N/A";

            if (int.TryParse(row.Cells["Subject_ID"]?.Value?.ToString(), out var sid))
                CB_DBSubjects_TextBooks.SelectedValue = sid;

            Cmb_Author_Textbook.Text = row.Cells["Author"]?.Value?.ToString() ?? string.Empty;

            Txt_Title_Textbook.Text = row.Cells["Title"]?.Value?.ToString() ?? "";
            Txt_ISBN_Textbook.Text = row.Cells["ISBN"]?.Value?.ToString() ?? "";
            Txt_Qty_Textbook.Text = row.Cells["Edition"]?.Value?.ToString() ?? "";

            dateTimePicker_Year_Textbook.Value = new DateTime(
                int.TryParse(row.Cells["PublishYear"]?.Value?.ToString(), out var yr)
                    ? Math.Max(1900, Math.Min(yr, 2100))
                    : DateTime.Now.Year,
                1, 1);

            SetRadiosFromStatus(row.Cells["Status"]?.Value);
        }



        private void LoadTextbookLookups()
        {
            using (var conn = new MySqlConnection(ConnString))
            {
                conn.Open();

                // Subjects -> CB_DBSubjects_TextBooks (ComboBox)
                using (var da = new MySqlDataAdapter(
                    "SELECT Subject_ID, Subject_Name FROM SUBJECT ORDER BY Subject_Name;", conn))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    CB_DBSubjects_TextBooks.DisplayMember = "Subject_Name";
                    CB_DBSubjects_TextBooks.ValueMember = "Subject_ID";
                    CB_DBSubjects_TextBooks.DataSource = dt;
                }
            }
        }



        private void LoadSubjects()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;
                using (var conn = new MySqlConnection(cs))
                {
                    conn.Open();
                    const string sql = @"
                        SELECT Subject_ID, Subject_Name, Subject_Description
                        FROM SUBJECT
                        ORDER BY Subject_Name;";
                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        DataGrid_Subject.AutoGenerateColumns = true;
                        DataGrid_Subject.DataSource = dt;

                        if (DataGrid_Subject.Rows.Count > 0)
                        {
                            DataGrid_Subject.Rows[0].Selected = true;
                            UpdateSubjectDetailsFromGrid();
                        }
                        else
                        {
                            // Clear fields if nothing to show
                            LB_Subject_ID_Subjects.Text = "\"ID to be generated\"";
                            Txt_Name_Subject.Text = "";
                            Txt_Description_Subject.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load subjects:\n\n" + ex, "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateSubject(bool forInsert)
        {
            if (string.IsNullOrWhiteSpace(Txt_Name_Subject.Text)) { MessageBox.Show("Subject name required."); return false; }
            return true;
        }

        private void SaveSubject(SaveMode mode)
        {
            bool forInsert = mode == SaveMode.Insert;
            if (!ValidateSubject(forInsert)) return;

            string name = Txt_Name_Subject.Text.Trim();
            string desc = Txt_Description_Subject.Text.Trim();
            int? subjectId = null;

            if (!forInsert)
            {
                subjectId = GetSelectedId(DataGrid_Subject, "Subject_ID");
                if (!subjectId.HasValue) { MessageBox.Show("Select a subject to update."); return; }
            }

            try
            {
                using (var conn = new MySqlConnection(ConnString))
                {
                    conn.Open();
                    if (forInsert)
                    {
                        const string sql = @"INSERT INTO SUBJECT (Subject_Name, Subject_Description)
                                     VALUES (@name, @desc);";
                        using (var cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@desc", desc);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Subject added.");
                    }
                    else
                    {
                        const string sql = @"UPDATE SUBJECT
                                        SET Subject_Name=@name, Subject_Description=@desc
                                      WHERE Subject_ID=@id;";
                        using (var cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@desc", desc);
                            cmd.Parameters.AddWithValue("@id", subjectId.Value);
                            var rows = cmd.ExecuteNonQuery();
                            MessageBox.Show(rows == 0 ? "No subject updated." : "Subject updated.");
                        }
                    }
                }
                LoadSubjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save subject failed:\n" + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchSubjects(string term)
        {
            if (string.IsNullOrWhiteSpace(term)) { LoadSubjects(); return; }

            try
            {
                using (var conn = new MySqlConnection(ConnString))
                {
                    conn.Open();
                    const string sql = @"
                SELECT Subject_ID, Subject_Name, Subject_Description
                  FROM SUBJECT
                 WHERE CAST(Subject_ID AS CHAR) LIKE @q
                    OR Subject_Name            LIKE @q
                    OR Subject_Description     LIKE @q
                 ORDER BY Subject_Name;";
                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@q", "%" + term + "%");
                        var dt = new DataTable();
                        da.Fill(dt);
                        DataGrid_Subject.AutoGenerateColumns = true;
                        DataGrid_Subject.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search subjects failed:\n" + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAuthors()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;
                using (var conn = new MySqlConnection(cs))
                {
                    conn.Open();

                    const string sql = @"
                        SELECT
                            a.Author_ID,
                            a.Author_Name     AS FirstName,
                            a.Author_LastName AS LastName
                        FROM AUTHOR a
                        ORDER BY a.Author_LastName, a.Author_Name;";

                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        dataGridView_Authors.AutoGenerateColumns = true;
                        dataGridView_Authors.DataSource = dt;

                        if (dataGridView_Authors.Rows.Count > 0)
                        {
                            dataGridView_Authors.Rows[0].Selected = true;
                            UpdateAuthorDetailsFromGrid();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load authors:\n\n" + ex, "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateAuthorDetailsFromGrid()
        {
            if (dataGridView_Authors.CurrentRow == null)
            {
                LB_Authros_ID_Authors.Text = "Select an entry to display ID";
                Txt_FirstName_Author.Text = string.Empty;
                Txt_LastName_Author.Text = string.Empty;
                return;
            }

            var row = dataGridView_Authors.CurrentRow;

            LB_Authros_ID_Authors.Text = row.Cells["Author_ID"].Value?.ToString() ?? "N/A";
            Txt_FirstName_Author.Text = row.Cells["FirstName"].Value?.ToString() ?? string.Empty;
            Txt_LastName_Author.Text = row.Cells["LastName"].Value?.ToString() ?? string.Empty;
        }

        private bool? GetStatusFromRadios()
        {
            if (RB_available_Textbook.Checked) return true;   // Available = true
            if (RB_NotAvailable_Textbook.Checked) return false;  // Not Available = false
            return null; // nothing selected
        }

        private void SetRadiosFromStatus(object statusCellValue)
        {
            // Safely coerce DB cell to bool
            bool isAvailable = false;
            if (statusCellValue != null && statusCellValue != DBNull.Value)
            {
                // Try bool, then int 0/1, then string ("true"/"false", "1"/"0")
                if (statusCellValue is bool b) isAvailable = b;
                else if (int.TryParse(statusCellValue.ToString(), out var i)) isAvailable = (i != 0);
                else if (bool.TryParse(statusCellValue.ToString(), out var pb)) isAvailable = pb;
            }

            RB_available_Textbook.Checked = isAvailable;
            RB_NotAvailable_Textbook.Checked = !isAvailable;
        }


        private void dataGridView_Authors_SelectionChanged(object sender, EventArgs e)
        {
            UpdateAuthorDetailsFromGrid();
        }

        private void Bnt_Search_Author_Click(object sender, EventArgs e)
        {
            SearchAuthors(Txt_Search_Author.Text.Trim());
        }

        private void Bnt_New_Authors_Click(object sender, EventArgs e)
        {
            SaveAuthor(SaveMode.Insert);
        }

        private void Bnt_Update_Author_Click(object sender, EventArgs e)
        {
            SaveAuthor(SaveMode.Update);
        }

        private void Bnt_Close_Author_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bnt_New_Subject_Click(object sender, EventArgs e)
        {
            SaveSubject(SaveMode.Insert);
        }

        private void Bnt_Update_Subject_Click(object sender, EventArgs e)
        {
            SaveSubject(SaveMode.Update);
        }

        private void Bnt_Search_Subject_Click(object sender, EventArgs e)
        {
            SearchSubjects(Txt_Search_Subject.Text.Trim());
        }

        private void Bnt_Close_Subject_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bnt_New_Textbook_Click(object sender, EventArgs e)
        {
            SaveTextbook(SaveMode.Insert);
        }

        private void Bnt_Update_Textbook_Click(object sender, EventArgs e)
        {
            SaveTextbook(SaveMode.Update);
        }

        private void Bnt_Search_TextBook_Click(object sender, EventArgs e)
        {
            SearchTextbooks(TxtBx_Search_TextBook.Text.Trim());
        }


        private void Bnt_Close_Textbook_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
