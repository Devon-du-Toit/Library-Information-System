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

            // textbook grid setup
            DataGrid_Subject.ReadOnly = true;
            DataGrid_Subject.AllowUserToAddRows = false;
            DataGrid_Subject.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGrid_Subject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // author grid setup
            dataGridView_Authors.ReadOnly = true;
            dataGridView_Authors.AllowUserToAddRows = false;
            dataGridView_Authors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Authors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void TabControl_Library_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl_Library.SelectedTab == Tab_TxtBooks) LoadTextbooks();
            else if (TabControl_Library.SelectedTab == Tab_Subjects) LoadSubjects();
            else if (TabControl_Library.SelectedTab == Tab_Authors) LoadAuthors();
        }

        private void LoadTextbooks()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;
                using (var conn = new MySqlConnection(cs))
                {
                    conn.Open();
                    const string sql = @"
                        SELECT
                            t.TextBook_ID,
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
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load textbooks:\n\n" + ex, "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load subjects:\n\n" + ex, "Database Error",
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
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load authors:\n\n" + ex, "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
