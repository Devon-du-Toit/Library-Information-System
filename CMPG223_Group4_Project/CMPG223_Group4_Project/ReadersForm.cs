using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace CMPG223_Group4_Project
{
    public partial class ReadersForm : Form
    {
        private readonly List<ComboItem> _borrowerOptions = new List<ComboItem>();
        private readonly List<TextbookOption> _textbookOptions = new List<TextbookOption>();
        private readonly List<ReturnOption> _returnOptions = new List<ReturnOption>();

        private DataTable _borrowersTable = new DataTable();
        private DataTable _borrowedStatusTable = new DataTable();
        private DataTable _outstandingTable = new DataTable();
        private int? _currentStaffId;

        public ReadersForm()
        {
            InitializeComponent();

            Load += ReadersForm_Load;

            // Borrowers tab events
            DataGrid_Borrowers.SelectionChanged += DataGrid_Borrowers_SelectionChanged;
            Bnt_New_Borrowers.Click += Bnt_New_Borrowers_Click;
            Bnt_Update_Borrowers.Click += Bnt_Update_Borrowers_Click;
            Bnt_Delete_Borrowers.Click += Bnt_Delete_Borrowers_Click;
            Bnt_Clear_Borrowers.Click += Bnt_Clear_Borrowers_Click;
            Bnt_Search_Borrowers.Click += Bnt_Search_Borrowers_Click;
            Bnt_Close_Borrowers.Click += (_, __) => Close();

            // Borrowed tab events
            CB_NameLastName_Borrowed.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_TextBookName_Borrowed.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_ReturnTextbook_Borrowed.DropDownStyle = ComboBoxStyle.DropDownList;

            Bnt_Refresh_Borrowed.Click += (_, __) =>
            {
                LoadBorrowedStatus();
                LoadOutstandingBorrows();
                LoadAvailableTextbooks();
            };
            Bnt_Clear_Donations.Click += (_, __) => ClearBookOutInputs();
            Bnt_Save_Donations.Click += Bnt_SaveBorrow_Click;
            CB_TextBookName_Borrowed.SelectedIndexChanged += CB_TextBookName_Borrowed_SelectedIndexChanged;
            Bnt_RefreshReturn_Borrowed.Click += (_, __) => LoadOutstandingBorrows();
            Bnt_Return_Borrowed.Click += Bnt_Return_Borrowed_Click;
            Bnt_Close_Borrowed.Click += (_, __) => Close();
            dataGridView_ReturnSelection.SelectionChanged += DataGridView_ReturnSelection_SelectionChanged;
        }

        public ReadersForm(int staffId) : this()
        {
            _currentStaffId = staffId;
        }

        private string ConnectionString =>
            ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;

        private void ReadersForm_Load(object sender, EventArgs e)
        {
            dateTimePicker_Bookout_Borrowed.Value = DateTime.Today;
            dateTimePicker_Duedate_Borrowed.Value = DateTime.Today.AddDays(14);
            dateTimePicker2.Value = DateTime.Today;

            LoadBorrowers();
            LoadBorrowedStatus();
            LoadAvailableTextbooks();
            LoadOutstandingBorrows();
        }

        #region Borrowers tab

        private enum SaveMode
        {
            Insert,
            Update
        }

        private void LoadBorrowers()
        {
            try
            {
                using (var conn = new MySqlConnection(ConnectionString))
                using (var da = new MySqlDataAdapter(@"
                        SELECT Borrower_ID,
                               First_Name,
                               Last_Name,
                               Email,
                               Contact_Number
                        FROM borrower
                        ORDER BY Last_Name, First_Name;", conn))
                {
                    var table = new DataTable();
                    da.Fill(table);
                    _borrowersTable = table;
                    DataGrid_Borrowers.AutoGenerateColumns = true;
                    DataGrid_Borrowers.DataSource = _borrowersTable;
                    DataGrid_Borrowers.ClearSelection();
                    BindBorrowerCombo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load borrowers:\n\n" + ex.Message,
                                "Database error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void BindBorrowerCombo()
        {
            _borrowerOptions.Clear();
            foreach (DataRow row in _borrowersTable.Rows)
            {
                if (row["Borrower_ID"] == DBNull.Value) continue;

                int id = Convert.ToInt32(row["Borrower_ID"]);
                string first = row["First_Name"]?.ToString() ?? string.Empty;
                string last = row["Last_Name"]?.ToString() ?? string.Empty;

                _borrowerOptions.Add(new ComboItem
                {
                    Id = id,
                    Display = (first + " " + last).Trim()
                });
            }

            CB_NameLastName_Borrowed.DataSource = null;
            CB_NameLastName_Borrowed.DisplayMember = nameof(ComboItem.Display);
            CB_NameLastName_Borrowed.ValueMember = nameof(ComboItem.Id);
            CB_NameLastName_Borrowed.DataSource = _borrowerOptions;
            CB_NameLastName_Borrowed.SelectedIndex = -1;
        }

        private void DataGrid_Borrowers_SelectionChanged(object sender, EventArgs e)
        {
            PopulateBorrowerFieldsFromSelection();
        }

        private void PopulateBorrowerFieldsFromSelection()
        {
            if (DataGrid_Borrowers.CurrentRow == null) return;

            var row = DataGrid_Borrowers.CurrentRow;
            Txt_FirstName_Borrowers.Text = row.Cells["First_Name"]?.Value?.ToString() ?? string.Empty;
            Txt_LastName_Borrowers.Text = row.Cells["Last_Name"]?.Value?.ToString() ?? string.Empty;
            Txt_Email_Borrowers.Text = row.Cells["Email"]?.Value?.ToString() ?? string.Empty;
            Txt_ContactNumber_Borrowers.Text = row.Cells["Contact_Number"]?.Value?.ToString() ?? string.Empty;
        }

        private void Bnt_Clear_Borrowers_Click(object sender, EventArgs e)
        {
            LoadBorrowers();
            ClearBorrowerInputs();
        }

        private void ClearBorrowerInputs()
        {
            Txt_FirstName_Borrowers.Clear();
            Txt_LastName_Borrowers.Clear();
            Txt_Email_Borrowers.Clear();
            Txt_ContactNumber_Borrowers.Clear();
            TxtBx_Search_Borrowers.Clear();
            DataGrid_Borrowers.ClearSelection();
            DataGrid_Borrowers.CurrentCell = null;
        }

        private void Bnt_Search_Borrowers_Click(object sender, EventArgs e)
        {
            SearchBorrowers(TxtBx_Search_Borrowers.Text.Trim());
        }

        private void SearchBorrowers(string term)
        {
            if (string.IsNullOrWhiteSpace(term))
            {
                LoadBorrowers();
                return;
            }

            try
            {
                using (var conn = new MySqlConnection(ConnectionString))
                using (var da = new MySqlDataAdapter(@"
                        SELECT Borrower_ID,
                               First_Name,
                               Last_Name,
                               Email,
                               Contact_Number
                        FROM borrower
                        WHERE CAST(Borrower_ID AS CHAR)        LIKE @q
                           OR First_Name                        LIKE @q
                           OR Last_Name                         LIKE @q
                           OR Email                             LIKE @q
                           OR CAST(Contact_Number AS CHAR)      LIKE @q
                        ORDER BY Last_Name, First_Name;", conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@q", "%" + term + "%");
                    var table = new DataTable();
                    da.Fill(table);
                    _borrowersTable = table;
                    DataGrid_Borrowers.AutoGenerateColumns = true;
                    DataGrid_Borrowers.DataSource = _borrowersTable;
                    DataGrid_Borrowers.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed:\n\n" + ex.Message,
                                "Database error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void Bnt_New_Borrowers_Click(object sender, EventArgs e)
        {
            SaveBorrower(SaveMode.Insert);
        }

        private void Bnt_Update_Borrowers_Click(object sender, EventArgs e)
        {
            SaveBorrower(SaveMode.Update);
        }

        private void Bnt_Delete_Borrowers_Click(object sender, EventArgs e)
        {
            DeleteBorrower();
        }

        private void SaveBorrower(SaveMode mode)
        {
            bool inserting = mode == SaveMode.Insert;
            if (!TryReadBorrowerInputs(out var firstName, out var lastName,
                                       out var email, out var contact))
            {
                return;
            }

            int? borrowerId = null;
            if (!inserting)
            {
                borrowerId = GetSelectedBorrowerId();
                if (borrowerId == null)
                {
                    MessageBox.Show("Select a borrower in the list first.",
                                    "No selection",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }
            }

            try
            {
                int? savedId = borrowerId;
                using (var conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();

                    if (inserting)
                    {
                        const string insertSql = @"
                            INSERT INTO borrower (First_Name, Last_Name, Email, Contact_Number)
                            VALUES (@first, @last, @mail, @contact);";

                        using (var cmd = new MySqlCommand(insertSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@first", firstName);
                            cmd.Parameters.AddWithValue("@last", lastName);
                            cmd.Parameters.AddWithValue("@mail", email);
                            cmd.Parameters.AddWithValue("@contact", contact);
                            cmd.ExecuteNonQuery();
                            savedId = (int?)cmd.LastInsertedId;
                        }

                        MessageBox.Show("Borrower created successfully.",
                                        "Saved",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        const string updateSql = @"
                            UPDATE borrower
                               SET First_Name = @first,
                                   Last_Name = @last,
                                   Email = @mail,
                                   Contact_Number = @contact
                             WHERE Borrower_ID = @id;";

                        using (var cmd = new MySqlCommand(updateSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@first", firstName);
                            cmd.Parameters.AddWithValue("@last", lastName);
                            cmd.Parameters.AddWithValue("@mail", email);
                            cmd.Parameters.AddWithValue("@contact", contact);
                            cmd.Parameters.AddWithValue("@id", borrowerId);
                            int rows = cmd.ExecuteNonQuery();
                            if (rows == 0)
                            {
                                MessageBox.Show("No records were updated. Try reloading the list.",
                                                "Update",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        MessageBox.Show("Borrower updated successfully.",
                                        "Saved",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                }

                LoadBorrowers();
                ReselectBorrower(savedId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed:\n\n" + ex.Message,
                                "Database error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private bool TryReadBorrowerInputs(out string firstName, out string lastName,
                                           out string email, out string contact)
        {
            firstName = Txt_FirstName_Borrowers.Text.Trim();
            lastName = Txt_LastName_Borrowers.Text.Trim();
            email = Txt_Email_Borrowers.Text.Trim();
            contact = Txt_ContactNumber_Borrowers.Text.Trim();

            if (string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("First name is required.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Last name is required.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email is required.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(contact))
            {
                MessageBox.Show("Contact number is required.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!long.TryParse(contact, out _) || contact.Length < 7 || contact.Length > 15)
            {
                MessageBox.Show("Contact number should contain digits only (7-15 digits).",
                                "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private int? GetSelectedBorrowerId()
        {
            if (DataGrid_Borrowers.CurrentRow == null) return null;

            var value = DataGrid_Borrowers.CurrentRow.Cells["Borrower_ID"]?.Value;
            if (value == null) return null;
            return int.TryParse(value.ToString(), out var id) ? id : (int?)null;
        }

        private void ReselectBorrower(int? borrowerId)
        {
            if (!borrowerId.HasValue)
            {
                ClearBorrowerInputs();
                return;
            }

            foreach (DataGridViewRow row in DataGrid_Borrowers.Rows)
            {
                if (row.Cells["Borrower_ID"]?.Value?.ToString() == borrowerId.Value.ToString())
                {
                    row.Selected = true;
                    DataGrid_Borrowers.CurrentCell = row.Cells["First_Name"];
                    PopulateBorrowerFieldsFromSelection();
                    return;
                }
            }
        }

        private void DeleteBorrower()
        {
            var borrowerId = GetSelectedBorrowerId();
            if (!borrowerId.HasValue)
            {
                MessageBox.Show("Select a borrower to delete from the list.",
                                "No selection",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this borrower?",
                                          "Confirm delete",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var conn = new MySqlConnection(ConnectionString))
                using (var cmd = new MySqlCommand("DELETE FROM borrower WHERE Borrower_ID = @id;", conn))
                {
                    cmd.Parameters.AddWithValue("@id", borrowerId.Value);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                LoadBorrowers();
                ClearBorrowerInputs();
            }
            catch (MySqlException sqlEx) when (sqlEx.Number == 1451)
            {
                MessageBox.Show("Cannot delete the borrower while they have outstanding borrow records.",
                                "Delete blocked",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed:\n\n" + ex.Message,
                                "Database error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Borrowed tab

        private void LoadAvailableTextbooks()
        {
            try
            {
                using (var conn = new MySqlConnection(ConnectionString))
                using (var da = new MySqlDataAdapter(@"
                        SELECT TextBook_ID,
                               Title,
                               ISBN
                        FROM textbook
                        WHERE Status = TRUE
                        ORDER BY Title;", conn))
                {
                    var table = new DataTable();
                    da.Fill(table);

                    _textbookOptions.Clear();
                    foreach (DataRow row in table.Rows)
                    {
                        if (row["TextBook_ID"] == DBNull.Value) continue;
                        _textbookOptions.Add(new TextbookOption
                        {
                            Id = Convert.ToInt32(row["TextBook_ID"]),
                            Display = row["Title"]?.ToString() ?? string.Empty,
                            ISBN = row["ISBN"]?.ToString() ?? string.Empty
                        });
                    }

                    CB_TextBookName_Borrowed.DataSource = null;
                    CB_TextBookName_Borrowed.DisplayMember = nameof(TextbookOption.Display);
                    CB_TextBookName_Borrowed.ValueMember = nameof(TextbookOption.Id);
                    CB_TextBookName_Borrowed.DataSource = _textbookOptions;
                    CB_TextBookName_Borrowed.SelectedIndex = -1;
                    LB_DBISBN_Borrowed.Text = "\"Will show ISBN number\"";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load textbooks:\n\n" + ex.Message,
                                "Database error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void CB_TextBookName_Borrowed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_TextBookName_Borrowed.SelectedItem is TextbookOption option)
            {
                LB_DBISBN_Borrowed.Text = option.ISBN;
            }
            else
            {
                LB_DBISBN_Borrowed.Text = "\"Will show ISBN number\"";
            }
        }

        private void ClearBookOutInputs()
        {
            CB_NameLastName_Borrowed.SelectedIndex = -1;
            CB_TextBookName_Borrowed.SelectedIndex = -1;
            LB_DBISBN_Borrowed.Text = "\"Will show ISBN number\"";
            dateTimePicker_Bookout_Borrowed.Value = DateTime.Today;
            dateTimePicker_Duedate_Borrowed.Value = DateTime.Today.AddDays(14);
        }

        private void Bnt_SaveBorrow_Click(object sender, EventArgs e)
        {
            if (!_currentStaffId.HasValue || _currentStaffId.Value <= 0)
            {
                MessageBox.Show("Staff information is missing. Please reopen this form from the main menu after logging in.",
                                "Missing staff",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (!(CB_NameLastName_Borrowed.SelectedItem is ComboItem borrower))
            {
                MessageBox.Show("Select a borrower.",
                                "Validation",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (!(CB_TextBookName_Borrowed.SelectedItem is TextbookOption textbook))
            {
                MessageBox.Show("Select a textbook.",
                                "Validation",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            var dateOut = dateTimePicker_Bookout_Borrowed.Value.Date;
            var dueDate = dateTimePicker_Duedate_Borrowed.Value.Date;

            if (dueDate < dateOut)
            {
                MessageBox.Show("Due date cannot be before the book-out date.",
                                "Validation",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (var tx = conn.BeginTransaction())
                    {
                        int borrowId;

                        using (var insertBorrow = new MySqlCommand(@"
                                INSERT INTO borrow (Staff_ID, Borrower_ID, Date_Out, Date_Due)
                                VALUES (@staff, @borrower, @out, @due);", conn, tx))
                        {
                            insertBorrow.Parameters.AddWithValue("@staff", _currentStaffId.Value);
                            insertBorrow.Parameters.AddWithValue("@borrower", borrower.Id);
                            insertBorrow.Parameters.AddWithValue("@out", dateOut);
                            insertBorrow.Parameters.AddWithValue("@due", dueDate);
                            insertBorrow.ExecuteNonQuery();
                            borrowId = (int)insertBorrow.LastInsertedId;
                        }

                        using (var link = new MySqlCommand(@"
                                INSERT INTO borrow_books (Borrow_ID, Textbook_ID)
                                VALUES (@borrow, @textbook);", conn, tx))
                        {
                            link.Parameters.AddWithValue("@borrow", borrowId);
                            link.Parameters.AddWithValue("@textbook", textbook.Id);
                            link.ExecuteNonQuery();
                        }

                        using (var updateTextbook = new MySqlCommand(@"
                                UPDATE textbook
                                   SET Status = FALSE
                                 WHERE TextBook_ID = @id;", conn, tx))
                        {
                            updateTextbook.Parameters.AddWithValue("@id", textbook.Id);
                            updateTextbook.ExecuteNonQuery();
                        }

                        tx.Commit();
                    }
                }

                MessageBox.Show("Textbook booked out successfully.",
                                "Borrow saved",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                ClearBookOutInputs();
                LoadBorrowedStatus();
                LoadAvailableTextbooks();
                LoadOutstandingBorrows();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save borrow:\n\n" + ex.Message,
                                "Database error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void LoadBorrowedStatus()
        {
            try
            {
                using (var conn = new MySqlConnection(ConnectionString))
                using (var da = new MySqlDataAdapter(@"
                        SELECT b.Borrow_ID,
                               CONCAT(br.First_Name, ' ', br.Last_Name) AS Borrower,
                               tb.Title AS Textbook,
                               tb.ISBN,
                               b.Date_Out,
                               b.Date_Due,
                               b.Date_In
                        FROM borrow b
                        JOIN borrower br      ON b.Borrower_ID = br.Borrower_ID
                        JOIN borrow_books bb  ON b.Borrow_ID = bb.Borrow_ID
                        JOIN textbook tb      ON bb.Textbook_ID = tb.TextBook_ID
                        ORDER BY b.Date_Out DESC;", conn))
                {
                    var table = new DataTable();
                    da.Fill(table);
                    _borrowedStatusTable = table;
                    DataGrid_Borrowed.AutoGenerateColumns = true;
                    DataGrid_Borrowed.DataSource = _borrowedStatusTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load borrowed status:\n\n" + ex.Message,
                                "Database error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void LoadOutstandingBorrows()
        {
            try
            {
                using (var conn = new MySqlConnection(ConnectionString))
                using (var da = new MySqlDataAdapter(@"
                        SELECT b.Borrow_ID,
                               bb.Textbook_ID,
                               CONCAT(br.First_Name, ' ', br.Last_Name) AS Borrower,
                               tb.Title AS Textbook,
                               tb.ISBN,
                               b.Date_Out,
                               b.Date_Due
                        FROM borrow b
                        JOIN borrower br      ON b.Borrower_ID = br.Borrower_ID
                        JOIN borrow_books bb  ON b.Borrow_ID = bb.Borrow_ID
                        JOIN textbook tb      ON bb.Textbook_ID = tb.TextBook_ID
                        WHERE b.Date_In IS NULL
                        ORDER BY b.Date_Out;", conn))
                {
                    var table = new DataTable();
                    da.Fill(table);
                    _outstandingTable = table;
                    dataGridView_ReturnSelection.AutoGenerateColumns = true;
                    dataGridView_ReturnSelection.DataSource = _outstandingTable;

                    _returnOptions.Clear();
                    foreach (DataRow row in _outstandingTable.Rows)
                    {
                        if (row["Borrow_ID"] == DBNull.Value || row["Textbook_ID"] == DBNull.Value)
                            continue;

                        _returnOptions.Add(new ReturnOption
                        {
                            BorrowId = Convert.ToInt32(row["Borrow_ID"]),
                            TextbookId = Convert.ToInt32(row["Textbook_ID"]),
                            Borrower = row["Borrower"]?.ToString() ?? string.Empty,
                            Textbook = row["Textbook"]?.ToString() ?? string.Empty,
                            ISBN = row["ISBN"]?.ToString() ?? string.Empty,
                            DateOut = Convert.ToDateTime(row["Date_Out"]),
                            DateDue = Convert.ToDateTime(row["Date_Due"])
                        });
                    }

                    CB_ReturnTextbook_Borrowed.DataSource = null;
                    CB_ReturnTextbook_Borrowed.DisplayMember = nameof(ReturnOption.Display);
                    CB_ReturnTextbook_Borrowed.ValueMember = nameof(ReturnOption.ComboKey);
                    CB_ReturnTextbook_Borrowed.DataSource = _returnOptions;
                    CB_ReturnTextbook_Borrowed.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load outstanding borrows:\n\n" + ex.Message,
                                "Database error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void DataGridView_ReturnSelection_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_ReturnSelection.CurrentRow?.DataBoundItem is DataRowView rowView)
            {
                var borrowId = Convert.ToInt32(rowView["Borrow_ID"]);
                var textbookId = Convert.ToInt32(rowView["Textbook_ID"]);
                var key = $"{borrowId}|{textbookId}";

                var index = _returnOptions.FindIndex(o => o.ComboKey == key);
                if (index >= 0 && index < CB_ReturnTextbook_Borrowed.Items.Count)
                {
                    CB_ReturnTextbook_Borrowed.SelectedIndex = index;
                }
            }
        }

        private void Bnt_Return_Borrowed_Click(object sender, EventArgs e)
        {
            if (!(CB_ReturnTextbook_Borrowed.SelectedItem is ReturnOption option))
            {
                MessageBox.Show("Select a borrowed textbook to return.",
                                "Validation",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            var returnDate = dateTimePicker2.Value.Date;
            if (returnDate < option.DateOut.Date)
            {
                MessageBox.Show("Return date cannot be before the book-out date.",
                                "Validation",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (var tx = conn.BeginTransaction())
                    {
                        using (var updateBorrow = new MySqlCommand(@"
                                UPDATE borrow
                                   SET Date_In = @returned
                                 WHERE Borrow_ID = @id
                                   AND Date_In IS NULL;", conn, tx))
                        {
                            updateBorrow.Parameters.AddWithValue("@returned", returnDate);
                            updateBorrow.Parameters.AddWithValue("@id", option.BorrowId);
                            int rows = updateBorrow.ExecuteNonQuery();

                            if (rows == 0)
                            {
                                tx.Rollback();
                                MessageBox.Show("Borrow record already closed or missing.",
                                                "Return",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
                                LoadBorrowedStatus();
                                LoadOutstandingBorrows();
                                return;
                            }
                        }

                        using (var updateTextbook = new MySqlCommand(@"
                                UPDATE textbook
                                   SET Status = TRUE
                                 WHERE TextBook_ID = @id;", conn, tx))
                        {
                            updateTextbook.Parameters.AddWithValue("@id", option.TextbookId);
                            updateTextbook.ExecuteNonQuery();
                        }

                        tx.Commit();
                    }
                }

                MessageBox.Show("Textbook returned successfully.",
                                "Return saved",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                LoadBorrowedStatus();
                LoadAvailableTextbooks();
                LoadOutstandingBorrows();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to return textbook:\n\n" + ex.Message,
                                "Database error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Helper classes

        private class ComboItem
        {
            public int Id { get; set; }
            public string Display { get; set; }
        }

        private class TextbookOption : ComboItem
        {
            public string ISBN { get; set; }
        }

        private class ReturnOption
        {
            public int BorrowId { get; set; }
            public int TextbookId { get; set; }
            public string Borrower { get; set; }
            public string Textbook { get; set; }
            public string ISBN { get; set; }
            public DateTime DateOut { get; set; }
            public DateTime DateDue { get; set; }
            public string Display => $"{Borrower} - {Textbook}";
            public string ComboKey => $"{BorrowId}|{TextbookId}";
        }

        #endregion
    }
}
