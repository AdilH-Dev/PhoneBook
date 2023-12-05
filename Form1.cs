using MySql.Data.MySqlClient;

namespace FinalPhoneBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        /*    password_txt.PasswordChar = '*';*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            using (MySqlConnection conn = DbConnector.GetConnection())
            {
                try
                {
                    conn.Open();
                   /* MessageBox.Show("Database connection successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error connecting to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            string user_name = user_name_txt.Text;
            string password = password_txt.Text;

            // Validate username and password
            if (string.IsNullOrEmpty(user_name))
            {
                user_name_error_label.Text = "User Name is required.";
                return;
            }
            else
            {
                user_name_error_label.Text = "";
            }

            if (string.IsNullOrEmpty(password))
            {
                password_error_label.Text = "Password is required";
                return;
            }
            else
            {
                password_error_label.Text = "";
            }

            // Insert into the database
            using (MySqlConnection conn = DbConnector.GetConnection())
            {
                try
                {
                    conn.Open();

                    // Check if the username already exists
                    string checkQuery = $"SELECT COUNT(*) FROM users WHERE UserName = '{user_name}'";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        int userCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (userCount > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string insertQuery = $"INSERT INTO users (username, password) VALUES ('{user_name}', '{password}')";

                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                    {
                        int rowsAffected = insertCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            user_name_txt.Text = "";
                            password_txt.Text = "";
                            MessageBox.Show("Your registration was successful. Please proceed to log in.", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error registering user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string user_name = user_name_txt.Text;
            string password = password_txt.Text;

            if (string.IsNullOrEmpty(user_name))
            {
                user_name_error_label.Text = "User Name is required.";
                return;
            }
            else
            {
                user_name_error_label.Text = "";
            }

            if (string.IsNullOrEmpty(password))
            {
                password_error_label.Text = "Password is required";
                return;
            }
            else
            {
                password_error_label.Text = "";
            }

            using (MySqlConnection conn = DbConnector.GetConnection())
            {
                try
                {
                    conn.Open();

                    string loginQuery = $"SELECT user_id FROM users WHERE UserName = '{user_name}' AND Password = '{password}'";

                    using (MySqlCommand loginCmd = new MySqlCommand(loginQuery, conn))
                    {
                        object result = loginCmd.ExecuteScalar();

                        if (result != null) // Check if a record is found
                        {
                            int userId = Convert.ToInt32(result);

                            user_name_txt.Text = "";
                            password_txt.Text = "";
                            Form2 form2 = new Form2(user_name, userId);
                            form2.Show();
                            this.Hide();
                            MessageBox.Show($"Welcome {user_name}! Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

    }
    public static class DbConnector
    {
        private static string server = "localhost";
        private static string database = "phone_book_db";
        private static string username = "root";
        private static string password = "1122";

        public static MySqlConnection GetConnection()
        {
            string constring = $"Server={server};Database={database};Uid={username};Pwd={password};";
            MySqlConnection conn = new MySqlConnection(constring);
            return conn;
        }
    }
}