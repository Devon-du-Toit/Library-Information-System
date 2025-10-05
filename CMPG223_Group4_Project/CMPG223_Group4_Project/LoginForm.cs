using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySqlConnector;

namespace CMPG223_Group4_Project
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_BNT_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Missing info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string cs = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;

                using (var conn = new MySqlConnection(cs))
                {
                    conn.Open();

                    const string sql = @"
                SELECT Staff_ID, First_Name, Last_Name, Role
                FROM LIBRARY_STAFF
                WHERE Username = @u AND Password = @p
                LIMIT 1;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", password);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int staffId = reader.GetInt32("Staff_ID");
                                string firstName = reader.GetString("First_Name");
                                string lastName = reader.GetString("Last_Name");
                                string role = reader.GetString("Role");

                                // Go to next form
                                this.Hide();
                                using (var newForm = new MainMenu(staffId, role, firstName))
                                {
                                    newForm.ShowDialog();
                                }
                                this.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.",
                                                "Login failed",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
