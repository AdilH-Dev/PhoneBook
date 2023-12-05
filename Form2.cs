

using MySql.Data.MySqlClient;
using System.Data;

namespace FinalPhoneBook
{
    public partial class Form2 : Form
    {
        private string userName;
        private int userId;
        public Form2(string userName, int userId)
        {

            InitializeComponent();
            this.userName = userName;
            this.userId = userId;


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            user_name_label2.Text = userName;
            user_id_label.Text = Convert.ToString(userId);
            LoadContacts();
        }
        private void LoadContacts()
        {

            string selectQuery = "SELECT * FROM phone_book WHERE user_id = @userId";

            try
            {
                using (MySqlConnection conn = DbConnector.GetConnection())
                {
                    conn.Open();

                    using (MySqlCommand selectCmd = new MySqlCommand(selectQuery, conn))
                    {
                        selectCmd.Parameters.AddWithValue("@userId", userId);

                        using (MySqlDataReader reader = selectCmd.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);

                            dataGridView1.DataSource = dataTable;
                            dataGridView1.ReadOnly = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving contacts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void create_button_Click(object sender, EventArgs e)
        {
            string fullName = full_name_txt.Text;
            string phoneNumber = phone_no_txt.Text;
            string emailAddress = email_txt.Text;
            string address = address_txt.Text;

            using (MySqlConnection conn = DbConnector.GetConnection())
            {
                try
                {
                    conn.Open();

                    string insertQuery = "INSERT INTO phone_book(user_id, full_name, phone_number, email_address, address) VALUES(@userId, @fullName, @phoneNumber, @emailAddress, @address)";

                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@userId", userId);
                        insertCmd.Parameters.AddWithValue("@fullName", fullName);
                        insertCmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                        insertCmd.Parameters.AddWithValue("@emailAddress", emailAddress);
                        insertCmd.Parameters.AddWithValue("@address", address);

                        int rowsAffected = insertCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            full_name_txt.Text = "";
                            phone_no_txt.Text = "";
                            email_txt.Text = "";
                            address_txt.Text = "";
                            LoadContacts();
                            MessageBox.Show("Contact created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to create contact. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating contact: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int entryId = Convert.ToInt32(selectedRow.Cells["entry_id"].Value);


                string fullName = full_name_txt.Text;
                string phoneNumber = phone_no_txt.Text;
                string emailAddress = email_txt.Text;
                string address = address_txt.Text;

                using (MySqlConnection conn = DbConnector.GetConnection())
                {
                    try
                    {
                        conn.Open();

                        string updateQuery = "UPDATE phone_book SET full_name = @fullName, phone_number = @phoneNumber, email_address = @emailAddress, address = @address WHERE entry_id = @entryId";

                        using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@entryId", entryId);
                            updateCmd.Parameters.AddWithValue("@fullName", fullName);
                            updateCmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                            updateCmd.Parameters.AddWithValue("@emailAddress", emailAddress);
                            updateCmd.Parameters.AddWithValue("@address", address);

                            int rowsAffected = updateCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                full_name_txt.Text = "";
                                phone_no_txt.Text = "";
                                email_txt.Text = "";
                                address_txt.Text = "";
                                LoadContacts();
                                MessageBox.Show("Contact updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to update contact. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating contact: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void editbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                full_name_txt.Text = Convert.ToString(selectedRow.Cells["full_name"].Value);
                phone_no_txt.Text = Convert.ToString(selectedRow.Cells["phone_number"].Value);
                email_txt.Text = Convert.ToString(selectedRow.Cells["email_address"].Value);
                address_txt.Text = Convert.ToString(selectedRow.Cells["address"].Value);


            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            full_name_txt.Text = "";
            phone_no_txt.Text = "";
            email_txt.Text = "";
            address_txt.Text = "";
            LoadContacts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            full_name_txt.Text = "";
            phone_no_txt.Text = "";
            email_txt.Text = "";
            address_txt.Text = "";
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            MessageBox.Show("Logout successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int entryId = Convert.ToInt32(selectedRow.Cells["entry_id"].Value);

                using (MySqlConnection conn = DbConnector.GetConnection())
                {
                    try
                    {
                        conn.Open();

                        // Display a confirmation dialog
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this contact?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            string deleteQuery = "DELETE FROM phone_book WHERE entry_id = @entryId";

                            using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn))
                            {
                                deleteCmd.Parameters.AddWithValue("@entryId", entryId);

                                int rowsAffected = deleteCmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    LoadContacts();
                                    MessageBox.Show("Contact deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No contact found with the specified ID. Deletion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting contact: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
