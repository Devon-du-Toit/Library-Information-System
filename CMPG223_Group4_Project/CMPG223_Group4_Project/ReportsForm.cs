using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using System.Configuration;
using System.IO;
//using System.Text;

namespace CMPG223_Group4_Project
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ExportDataGridViewReportsToCSV()
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "CSV files (*.csv)|*.csv";
                    sfd.FileName = "ReportsExport.csv";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        StringBuilder sb = new StringBuilder();

                        // Write headers
                        for (int i = 0; i < dataGridView_Reports.Columns.Count; i++)
                        {
                            sb.Append(dataGridView_Reports.Columns[i].HeaderText);
                            if (i < dataGridView_Reports.Columns.Count - 1)
                                sb.Append(",");
                        }
                        sb.AppendLine();

                        // Write rows
                        foreach (DataGridViewRow row in dataGridView_Reports.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                for (int i = 0; i < dataGridView_Reports.Columns.Count; i++)
                                {
                                    var cellValue = row.Cells[i].Value?.ToString() ?? "";
                                    // Escape commas or quotes
                                    if (cellValue.Contains(",") || cellValue.Contains("\""))
                                        cellValue = $"\"{cellValue.Replace("\"", "\"\"")}\"";

                                    sb.Append(cellValue);
                                    if (i < dataGridView_Reports.Columns.Count - 1)
                                        sb.Append(",");
                                }
                                sb.AppendLine();
                            }
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                        MessageBox.Show("Data exported successfully to:\n" + sfd.FileName,
                                        "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to export data:\n" + ex.Message,
                                "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadReportData(string tableName)
        {
            try
            {
                // Validate table name to prevent SQL injection
                if (string.IsNullOrWhiteSpace(tableName))
                {
                    MessageBox.Show("Table name cannot be empty.", "Input Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Optional: basic validation to ensure only letters, numbers, and underscores
                if (!System.Text.RegularExpressions.Regex.IsMatch(tableName, @"^[a-zA-Z0-9_]+$"))
                {
                    MessageBox.Show("Invalid table name format.", "Security Warning",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string cs = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;

                using (var conn = new MySqlConnection(cs))
                {
                    conn.Open();

                    // Use string interpolation safely (table name validated above)
                    string sql = $"SELECT * FROM {tableName}";

                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        dataGridView_Reports.AutoGenerateColumns = true;
                        dataGridView_Reports.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data:\n\n" + ex.Message, "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void borrowBooksReport()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;
                using (var conn = new MySqlConnection(cs))
                {
                    conn.Open();
                    const string sql = @"
                SELECT DISTINCT
                    t.TextBook_ID,
                    s.Subject_Name      AS SubjectName,
                    CONCAT(a.Author_Name, ' ', a.Author_LastName) AS AuthorName,
                    t.Title,
                    t.ISBN
                FROM library_db.borrow_books AS bb
                JOIN library_db.textbook     AS t ON t.TextBook_ID = bb.Textbook_ID
                JOIN library_db.subject      AS s ON s.Subject_ID   = t.Subject_ID
                JOIN library_db.author       AS a ON a.Author_ID    = t.Author_ID
                ORDER BY t.Title;";
                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        dataGridView_Reports.AutoGenerateColumns = true;
                        dataGridView_Reports.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load textbooks:\n\n" + ex, "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBorrowerFilter()
        {
            string cs = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;
            using (var conn = new MySqlConnection(cs))
            using (var cmd = new MySqlCommand(@"
        SELECT 
            Borrower_ID,
            CONCAT(First_Name, ' ', Last_Name) AS FullName
        FROM library_db.borrower
        ORDER BY Last_Name, First_Name;", conn))
            using (var da = new MySqlDataAdapter(cmd))
            {
                var dt = new DataTable();
                da.Fill(dt);

                // Insert "All" option at top
                var all = dt.NewRow();
                all["Borrower_ID"] = DBNull.Value;
                all["FullName"] = "— All Borrowers —";
                dt.Rows.InsertAt(all, 0);

                CB_Borrower_Reports.DataSource = dt;
                CB_Borrower_Reports.DisplayMember = "FullName";
                CB_Borrower_Reports.ValueMember = "Borrower_ID";
                CB_Borrower_Reports.SelectedIndex = 0;
            }
        }

        private void LoadTextbookFilter()
        {
            string cs = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;
            using (var conn = new MySqlConnection(cs))
            using (var cmd = new MySqlCommand(@"
        SELECT 
            TextBook_ID,
            Title
        FROM library_db.textbook
        ORDER BY Title;", conn))
            using (var da = new MySqlDataAdapter(cmd))
            {
                var dt = new DataTable();
                da.Fill(dt);

                // Insert "All" option at top
                var all = dt.NewRow();
                all["TextBook_ID"] = DBNull.Value;
                all["Title"] = "— All Textbooks —";
                dt.Rows.InsertAt(all, 0);

                CB_TextBookTitle_Reports.DataSource = dt;
                CB_TextBookTitle_Reports.DisplayMember = "Title";
                CB_TextBookTitle_Reports.ValueMember = "TextBook_ID";
                CB_TextBookTitle_Reports.SelectedIndex = 0;
            }
        }


        private void borrowReport(
            int? borrowerId = null,
            int? textbookId = null,
            DateTime? dateFrom = null,
            DateTime? dateTo = null)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;
                using (var conn = new MySqlConnection(cs))
                {
                    conn.Open();

                    string sql = @"
                        SELECT
                            br.Borrower_ID    AS BorrowerID,
                            br.First_Name     AS FirstName,
                            br.Last_Name      AS LastName,
                            br.Email,
                            br.Contact_Number AS ContactNumber,
                            b.Borrow_ID       AS BorrowID,
                            b.Date_Out,
                            b.Date_Due,
                            b.Date_In,
                            t.TextBook_ID,
                            t.Title           AS TextbookTitle
                        FROM library_db.borrow       AS b
                        JOIN library_db.borrower     AS br ON br.Borrower_ID = b.Borrower_ID
                        JOIN library_db.borrow_books AS bb ON bb.Borrow_ID   = b.Borrow_ID
                        JOIN library_db.textbook     AS t  ON t.TextBook_ID  = bb.TextBook_ID
                        WHERE 1 = 1
                          AND (@BorrowerId IS NULL OR br.Borrower_ID = @BorrowerId)
                          AND (@TextbookId IS NULL OR t.TextBook_ID  = @TextbookId)
                          AND (@DateFrom   IS NULL OR DATE(b.Date_Out) >= DATE(@DateFrom))
                          AND (@DateTo     IS NULL OR DATE(b.Date_Out) <= DATE(@DateTo))
                        ORDER BY b.Date_Out DESC, br.Last_Name, t.Title;";

                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        
                        da.SelectCommand.Parameters.Add("@BorrowerId", MySqlDbType.Int32).Value =
                             (object)borrowerId ?? DBNull.Value;

                        da.SelectCommand.Parameters.Add("@TextbookId", MySqlDbType.Int32).Value =
                            (object)textbookId ?? DBNull.Value;

                        da.SelectCommand.Parameters.Add("@DateFrom", MySqlDbType.Date).Value =
                            (object)(dateFrom?.Date ?? (object)DBNull.Value);

                        da.SelectCommand.Parameters.Add("@DateTo", MySqlDbType.Date).Value =
                            (object)(dateTo?.Date ?? (object)DBNull.Value);


                        var dt = new DataTable();
                        da.Fill(dt);
                        dataGridView_Reports.AutoGenerateColumns = true;
                        dataGridView_Reports.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load borrowers report:\n\n" + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ReportsForm_Load(object sender, EventArgs e)
        {

        }

        private void RB_LibaryStaff_Reports_CheckedChanged(object sender, EventArgs e)
        {
            LoadReportData("library_staff");
        }

        private void RB_Authors_Reports_CheckedChanged(object sender, EventArgs e)
        {
            LoadReportData("author");
        }

        private void RB_Textbooks_Reports_CheckedChanged(object sender, EventArgs e)
        {
            LoadReportData("textbook");
            
        }

        private void RB_Subjects_Reports_CheckedChanged(object sender, EventArgs e)
        {
            LoadReportData("subject");
        }

        private void RB_Doners_Reports_CheckedChanged(object sender, EventArgs e)
        {
            
             LoadReportData("donor");
        }

        private void RB_Dontions_Reports_CheckedChanged(object sender, EventArgs e)
        {
            
             LoadReportData("donation");
        }

        private void RB_BorrowedBook_Reports_CheckedChanged(object sender, EventArgs e)
        {

            borrowBooksReport();

        }

        private void RB_Borrowers_Reports_CheckedChanged(object sender, EventArgs e)
        {
            LoadBorrowerFilter();
            LoadTextbookFilter();
            borrowReport();
        }

        private void Bnt_Export_Reports_Click(object sender, EventArgs e)
        {
            ExportDataGridViewReportsToCSV();
        }

        private void Bnt_Close_Reports_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CB_Borrower_Reports_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CB_TextBookTitle_Reports_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Bnt_Apply_Reports_Click(object sender, EventArgs e)
        {
            int? borrowerId = null;
            int? textbookId = null;
            DateTime? dateFrom = null;
            DateTime? dateTo = null;

            
            if (CB_Borrower_Reports.SelectedValue != null &&
                CB_Borrower_Reports.SelectedValue != DBNull.Value)
            {
                borrowerId = Convert.ToInt32(CB_Borrower_Reports.SelectedValue);
            }

            
            if (CB_TextBookTitle_Reports.SelectedValue != null &&
                CB_TextBookTitle_Reports.SelectedValue != DBNull.Value)
            {
                textbookId = Convert.ToInt32(CB_TextBookTitle_Reports.SelectedValue);
            }

            
            dateFrom = dateTimePicker_From_Reports.Value.Date;
            dateTo = dateTimePicker_To_Reports.Value.Date;

          
            if (dateFrom > dateTo)
            {
                MessageBox.Show("Date From cannot be after Date To.", "Invalid Dates",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            borrowReport(borrowerId, textbookId, dateFrom, dateTo);
        }


        private void GB_Filters_Reports_Enter(object sender, EventArgs e)
        {
            LoadBorrowerFilter();
            LoadTextbookFilter();
        }

        private void Bnt_Clear_Reports_Click(object sender, EventArgs e)
        {
            if (CB_Borrower_Reports.DataSource != null) CB_Borrower_Reports.SelectedIndex = 0;
            if (CB_TextBookTitle_Reports.DataSource != null) CB_TextBookTitle_Reports.SelectedIndex = 0;


            dateTimePicker_From_Reports.Value = DateTime.Today;
            dateTimePicker_To_Reports.Value = DateTime.Today;


            borrowReport();
        }

        private void Bnt_Print_Reports_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Printer not found. Please check your printer connection or install a printer before continuing.",
            "Printer Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
);

        }
    }
}
