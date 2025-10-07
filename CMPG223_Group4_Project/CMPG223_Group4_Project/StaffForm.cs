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


namespace CMPG223_Group4_Project
{
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        private void LoadStaff()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;
                using (var conn = new MySqlConnection(cs))
                {
                    conn.Open();
                    const string sql = @"
                        SELECT * FROM
                       library_staff";
                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        DataGrid_Staff.AutoGenerateColumns = true;
                        DataGrid_Staff.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load textbooks:\n\n" + ex, "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private enum SaveMode { Insert, Update }

        private string GetSelectedRole()
        {
            if (RB_Staff_Staff.Checked) return "STAFF";
            if (RB_Owner_Staff.Checked) return "ADMIN";
            return null;
        }

        private int? GetSelectedRowId()
        {
            var row = DataGrid_Staff.CurrentRow;
            if (row == null) return null;
            return int.TryParse(row.Cells["Staff_ID"]?.Value?.ToString(), out var id) ? id : (int?)null;
        }

        private bool ValidateForm(bool forInsert)
        {
            if (string.IsNullOrWhiteSpace(Txt_FirstName_Staff.Text)) { MessageBox.Show("First name is required."); return false; }
            if (string.IsNullOrWhiteSpace(Txt_LastName_Staff.Text)) { MessageBox.Show("Last name is required."); return false; }
            if (string.IsNullOrWhiteSpace(Txt_Email_Staff.Text)) { MessageBox.Show("Email is required."); return false; }
            if (string.IsNullOrWhiteSpace(Txt_UserName_Staff.Text)) { MessageBox.Show("Username is required."); return false; }
            if (string.IsNullOrWhiteSpace(GetSelectedRole())) { MessageBox.Show("Please select a role."); return false; }
            if (forInsert && string.IsNullOrWhiteSpace(txtPass.Text)) { MessageBox.Show("Password is required for a new user."); return false; }
            return true;
        }

        private void SaveStaff(SaveMode mode)
        {
            bool forInsert = mode == SaveMode.Insert;
            if (!ValidateForm(forInsert)) return;

            // read values from UI
            string firstName = Txt_FirstName_Staff.Text.Trim();
            string lastName = Txt_LastName_Staff.Text.Trim();
            string email = Txt_Email_Staff.Text.Trim();
            string contactNumber = Txt_ContactNumber_Staff.Text.Trim();
            string username = Txt_UserName_Staff.Text.Trim();
            string password = txtPass.Text; 
            string role = GetSelectedRole();

            int? staffId = null;
            if (!forInsert)
            {
                staffId = GetSelectedRowId();
                if (!staffId.HasValue)
                {
                    MessageBox.Show("Select a staff member in the grid to update.");
                    return;
                }
            }

            try
            {
                string cs = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;
                using (var conn = new MySqlConnection(cs))
                {
                    conn.Open();

                    if (forInsert)
                    {
                        const string insertSql = @"
                    INSERT INTO library_staff
                        (First_Name, Last_Name, Email, Contact_Number, Username, Password, Role)
                    VALUES
                        (@first, @last, @email, @contact, @user, @pwd, @role);";

                        using (var cmd = new MySqlCommand(insertSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@first", firstName);
                            cmd.Parameters.AddWithValue("@last", lastName);
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@contact", contactNumber);
                            cmd.Parameters.AddWithValue("@user", username);
                            cmd.Parameters.AddWithValue("@pwd", password); 
                            cmd.Parameters.AddWithValue("@role", role);

                            cmd.ExecuteNonQuery();
                            staffId = (int)cmd.LastInsertedId;
                        }

                        MessageBox.Show("New staff member added.");
                    }
                    else
                    {
                        const string sqlNoPwd = @"
                    UPDATE library_staff
                       SET First_Name     = @first,
                           Last_Name      = @last,
                           Email          = @email,
                           Contact_Number = @contact,
                           Username       = @user,
                           Role           = @role
                     WHERE Staff_ID       = @id;";

                        const string sqlWithPwd = @"
                    UPDATE library_staff
                       SET First_Name     = @first,
                           Last_Name      = @last,
                           Email          = @email,
                           Contact_Number = @contact,
                           Username       = @user,
                           Password       = @pwd,
                           Role           = @role
                     WHERE Staff_ID       = @id;";

                        string sql = string.IsNullOrWhiteSpace(password) ? sqlNoPwd : sqlWithPwd;

                        using (var cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@first", firstName);
                            cmd.Parameters.AddWithValue("@last", lastName);
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@contact", contactNumber);
                            cmd.Parameters.AddWithValue("@user", username);
                            cmd.Parameters.AddWithValue("@role", role);
                            cmd.Parameters.AddWithValue("@id", staffId.Value);

                            if (!string.IsNullOrWhiteSpace(password))
                                cmd.Parameters.AddWithValue("@pwd", password);

                            int rows = cmd.ExecuteNonQuery();
                            if (rows == 0)
                                MessageBox.Show("No rows were updated (check Staff_ID).");
                            else
                                MessageBox.Show("Staff member updated.");
                        }
                    }
                }

                // refresh grid, reselect saved row, clear password box for safety
                LoadStaff();
                //  if (staffId.HasValue) ReselectCurrentRowById(staffId.Value);
                txtPass.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void StaffForm_Load(object sender, EventArgs e)
        {
            LoadStaff();
        }

        private void DataGrid_Staff_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGrid_Staff.CurrentRow != null && DataGrid_Staff.CurrentRow.Index >= 0)
            {
                DataGridViewRow row = DataGrid_Staff.CurrentRow;


                Txt_FirstName_Staff.Text = row.Cells["First_Name"].Value?.ToString() ?? "";
                Txt_LastName_Staff.Text = row.Cells["Last_Name"].Value?.ToString() ?? "";
                Txt_Email_Staff.Text = row.Cells["Email"].Value?.ToString() ?? "";
                Txt_ContactNumber_Staff.Text = row.Cells["Contact_Number"].Value?.ToString() ?? "";
                Txt_UserName_Staff.Text = row.Cells["Username"].Value?.ToString() ?? "";
                txtPass.Text = row.Cells["Password"].Value?.ToString() ?? "";

                string role = row.Cells["Role"].Value?.ToString()?.Trim();

                // Assign to correct radio button
                if (string.Equals(role, "STAFF", StringComparison.OrdinalIgnoreCase))
                {
                    RB_Staff_Staff.Checked = true;
                    RB_Owner_Staff.Checked = false;
                }
                else if (string.Equals(role, "ADMIN", StringComparison.OrdinalIgnoreCase))
                {
                    RB_Staff_Staff.Checked = false;
                    RB_Owner_Staff.Checked = true;
                }
                else
                {
                    // neither matches — clear both
                    RB_Staff_Staff.Checked = false;
                    RB_Owner_Staff.Checked = false;
                }
            }
        }

        private void Bnt_New_Staff_Click(object sender, EventArgs e)
        {
            SaveStaff(SaveMode.Insert);
        }

        private void Bnt_Update_Staff_Click(object sender, EventArgs e)
        {
            SaveStaff(SaveMode.Update);
        }

        private void Bnt_Close_Staff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bnt_Search_Staff_Click(object sender, EventArgs e)
        {
            string term = TxtBx_Search_Staff.Text.Trim();

            // Show all if empty
            if (string.IsNullOrEmpty(term))
            {
                LoadStaff();
                return;
            }

            try
            {
                string cs = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;
                using (var conn = new MySqlConnection(cs))
                {
                    conn.Open();

                    const string sql = @"
                SELECT Staff_ID, First_Name, Last_Name, Email, Contact_Number, Username, Password, Role
                FROM library_staff
                WHERE CAST(Staff_ID AS CHAR)        LIKE @q
                   OR First_Name                    LIKE @q
                   OR Last_Name                     LIKE @q
                   OR Email                         LIKE @q
                   OR CAST(Contact_Number AS CHAR)  LIKE @q
                   OR Username                      LIKE @q
                   OR Role                          LIKE @q
                ORDER BY Last_Name, First_Name;";

                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@q", "%" + term + "%");
                        var dt = new DataTable();
                        da.Fill(dt);
                        DataGrid_Staff.AutoGenerateColumns = true;
                        DataGrid_Staff.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed:\n" + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
