using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_Group4_Project
{
    public partial class EndowmentsForm : Form
    {
        public int StaffId { get; }

        public EndowmentsForm(int staffID)
        {
            InitializeComponent();

            StaffId = staffID;

            dataGridView_Doners.ReadOnly = true;
            dataGridView_Doners.AllowUserToAddRows = false;
            dataGridView_Doners.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Doners.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            DataGrid_Donations.ReadOnly = true;
            DataGrid_Donations.AllowUserToAddRows = false;
            DataGrid_Donations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGrid_Donations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LoadDonors("");
            PopulateDonorDropdown();
            LoadDonations();
        }

        private void LoadDonors(string searchString)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;
                using (var conn = new MySqlConnection(cs))
                {
                    conn.Open();
                    string sql;

                    if (string.IsNullOrWhiteSpace(searchString))
                    {
                        sql = @"
                    SELECT * FROM DONOR
                    ORDER BY Donor_ID;";
                    }
                    else
                    {
                        sql = @"
                    SELECT * FROM DONOR
                    WHERE FIRST_NAME LIKE @search
                       OR Contact_Number LIKE @search
                       OR Email LIKE @search
                    ORDER BY Donor_ID;";
                    }

                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        var dt = new DataTable();
                        da.SelectCommand.Parameters.AddWithValue("@search", $"%{searchString}%");
                        da.Fill(dt);
                        dataGridView_Doners.AutoGenerateColumns = true;
                        dataGridView_Doners.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load donors:\n\n" + ex, "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDonations()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;
                using (var conn = new MySqlConnection(cs))
                {
                    conn.Open();
                    string sql;

                    {
                        sql = @"
                    SELECT * FROM DONATION
                    ORDER BY Date DESC;";
                    }

                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        DataGrid_Donations.AutoGenerateColumns = true;
                        DataGrid_Donations.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load donations:\n\n" + ex, "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtBx_Search_Doners_TextChanged(object sender, EventArgs e)
        {
            LoadDonors(TxtBx_Search_Doners.Text);
        }

        private void PopulateDonorDropdown()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;

                using (var conn = new MySqlConnection(cs))
                {
                    conn.Open();

                    string sql = "SELECT Donor_ID, First_Name FROM DONOR ORDER BY First_Name;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        var donors = new DataTable();
                        donors.Load(reader);

                        CB_DonerName_Donations.DisplayMember = "First_Name";
                        CB_DonerName_Donations.ValueMember = "Donor_ID";
                        CB_DonerName_Donations.DataSource = donors;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load donor list:\n\n" + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdateDonor(string name, string contact, string email)
        {
            try
            {
                // Ensure a donor is selected
                if (string.IsNullOrWhiteSpace(lblDonorID.Text) || lblDonorID.Text == "N/A")
                {
                    MessageBox.Show("Please select a donor to update.", "No Selection",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Parse the donor ID from the label
                if (!int.TryParse(lblDonorID.Text, out int donorId))
                {
                    MessageBox.Show("Invalid donor ID.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string cs = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;

                using (var conn = new MySqlConnection(cs))
                {
                    conn.Open();

                    string sql = @"
                UPDATE DONOR
                SET 
                    First_Name = @name,
                    Contact_Number = @contact,
                    Email = @email
                WHERE Donor_ID = @id;
            ";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@contact", contact);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@id", donorId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Donor details updated successfully.", "Success",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDonors(TxtBx_Search_Doners.Text); // Refresh grid
                        }
                        else
                        {
                            MessageBox.Show("No donor was updated. Please check your data.", "Warning",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update donor:\n\n" + ex.Message, "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddDonor(string name, string contact, string email)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(name) ||
                    string.IsNullOrWhiteSpace(contact) ||
                    string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Please fill in all donor fields before adding.",
                                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string cs = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;

                using (var conn = new MySqlConnection(cs))
                {
                    conn.Open();

                    string sql = @"
                INSERT INTO DONOR (First_Name, Contact_Number, Email)
                VALUES (@name, @contact, @email);
            ";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@contact", contact);
                        cmd.Parameters.AddWithValue("@email", email);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("New donor added successfully!", "Success",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDonors(TxtBx_Search_Doners.Text);
                            Txt_FirstName_Doner.Clear();
                            Txt_ContactNumber_Doner.Clear();
                            Txt_Email_Doner.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add donor. Please try again.", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding donor:\n\n" + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdateDonorDetailsFromGrid()
        {
            if (dataGridView_Doners.CurrentRow == null)
            {
                lblDonorID.Text = "Select an entry to display ID";
                Txt_FirstName_Doner.Text = string.Empty;
                Txt_Email_Doner.Text = string.Empty;
                return;
            }

            var row = dataGridView_Doners.CurrentRow;

            lblDonorID.Text = row.Cells["Donor_ID"].Value?.ToString() ?? "N/A";
            Txt_FirstName_Doner.Text = row.Cells["First_Name"].Value?.ToString() ?? string.Empty;
            Txt_Email_Doner.Text = row.Cells["Email"].Value?.ToString() ?? string.Empty;
            Txt_ContactNumber_Doner.Text = row.Cells["Contact_Number"].Value?.ToString() ?? string.Empty;
        }

        private void dataGridView_Doners_SelectionChanged(object sender, EventArgs e)
        {
            UpdateDonorDetailsFromGrid();
        }

        private void Bnt_Update_Doner_Click(object sender, EventArgs e)
        {
            UpdateDonor(Txt_FirstName_Doner.Text,
                Txt_ContactNumber_Doner.Text,
                Txt_Email_Doner.Text);
        }

        private void Bnt_New_Doner_Click(object sender, EventArgs e)
        {
            
            AddDonor(Txt_FirstName_Doner.Text,
             Txt_ContactNumber_Doner.Text,
             Txt_Email_Doner.Text);

        }

        private void AddDonation(int staffId, int donorId, DateTime date, string type, decimal? amount)
        {
            try
            {
                if (staffId <= 0)
                {
                    MessageBox.Show("No staff member logged in. Please log in first.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (donorId <= 0)
                {
                    MessageBox.Show("Please select a donor.",
                                    "Missing Donor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(type))
                {
                    MessageBox.Show("Please enter the donation type.",
                                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string cs = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;
                using (var conn = new MySqlConnection(cs))
                {
                    conn.Open();

                    string sql = @"
                INSERT INTO DONATION (Staff_ID, Donor_ID, Date, Type, Amount)
                VALUES (@staffId, @donorId, @date, @type, @amount);
            ";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@staffId", staffId);
                        cmd.Parameters.AddWithValue("@donorId", donorId);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@type", type);

                        if (amount.HasValue)
                            cmd.Parameters.AddWithValue("@amount", amount.Value);
                        else
                            cmd.Parameters.AddWithValue("@amount", DBNull.Value);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Donation recorded successfully!",
                                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CB_DonerName_Donations.SelectedIndex = -1;
                            Txt_Type_Donations.Clear();
                            Txt_Amount_Donations.Clear();
                            dateTimePicker_Donations.Value = DateTime.Now;
                        }
                        else
                        {
                            MessageBox.Show("Failed to add donation.", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding donation:\n\n" + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void UpdateDonation(int donationId, string type, decimal? amount)
        {
            try
            {
                
                if (donationId <= 0)
                {
                    MessageBox.Show("Please select a valid donation to update.",
                                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(type))
                {
                    MessageBox.Show("Please enter a donation type.",
                                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string cs = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;

                using (var conn = new MySqlConnection(cs))
                {
                    conn.Open();

                    string sql = @"
                UPDATE DONATION
                SET Type = @type,
                    Amount = @amount
                WHERE Donation_ID = @id;
            ";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", donationId);
                        cmd.Parameters.AddWithValue("@type", type);

                        // C# 7.3 compatible nullable handling
                        if (amount.HasValue)
                            cmd.Parameters.AddWithValue("@amount", amount.Value);
                        else
                            cmd.Parameters.AddWithValue("@amount", DBNull.Value);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Donation updated successfully!",
                                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No donation was updated. Please check your input.",
                                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update donation:\n\n" + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Bnt_Save_Donations_Click(object sender, EventArgs e)
        {
            if (CB_DonerName_Donations.SelectedValue == null)
            {
                MessageBox.Show("Please select a donor.");
                return;
            }

            int donorId = Convert.ToInt32(CB_DonerName_Donations.SelectedValue);
            DateTime donationDate = dateTimePicker_Donations.Value;
            string type = Txt_Type_Donations.Text;
            decimal? amount = null;

            if (decimal.TryParse(Txt_Amount_Donations.Text, out decimal parsedAmount))
                amount = parsedAmount;

            AddDonation(StaffId, donorId, donationDate, type, amount);
            LoadDonations();
        }

        

        private void Bnt_Update_Donations_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(lblDonationID.Text, out int donationId) || donationId <= 0)
            {
                MessageBox.Show("Please select a valid donation from the grid.");
                return;
            }

            string type = txtUpdateType.Text;
            decimal? amount = null;

            if (decimal.TryParse(txtUpdateAmount.Text, out decimal parsedAmount))
                amount = parsedAmount;

            UpdateDonation(donationId, type, amount);
            LoadDonations();
        }

        private void DataGrid_Donations_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGrid_Donations.CurrentRow == null)
                return;

            var row = DataGrid_Donations.CurrentRow;


            lblDonationID.Text = row.Cells["Donation_ID"].Value?.ToString() ?? "0";


            txtUpdateType.Text = row.Cells["Type"].Value?.ToString() ?? string.Empty;
            txtUpdateAmount.Text = row.Cells["Amount"].Value?.ToString() ?? string.Empty;
        }

        private void CB_DonerName_Donations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_DonerName_Donations.SelectedValue == null || CB_DonerName_Donations.SelectedValue.ToString() == "")
            {
                LB_DBContactNumber_Donations.Text = "N/A";
                return;
            }

            int donorId;
            if (!int.TryParse(CB_DonerName_Donations.SelectedValue.ToString(), out donorId))
            {
                LB_DBContactNumber_Donations.Text = "N/A";
                return;
            }

            try
            {
                string cs = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;

                using (var conn = new MySqlConnection(cs))
                {
                    conn.Open();

                    string sql = "SELECT Contact_Number, Email FROM DONOR WHERE Donor_ID = @id;";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", donorId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                LB_DBContactNumber_Donations.Text = reader["Contact_Number"].ToString();
                                LB_DBEmail_Donations.Text = reader["Email"].ToString();
                            }
                            else
                            {
                                LB_DBContactNumber_Donations.Text = "N/A";
                                LB_DBEmail_Donations.Text = "N/A";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load donor contact/email:\n\n" + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
