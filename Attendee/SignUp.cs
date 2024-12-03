using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBProject.Attendee
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string firstName = textBox2.Text;
            string lastName = textBox3.Text;
            string email = textBox4.Text;
            string password = textBox5.Text;

            
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;

           
            if (string.IsNullOrWhiteSpace(username))
            {
                label7.Visible = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(firstName))
            {
                label8.Visible = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                label9.Visible = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                label10.Visible = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                label11.Visible = true;
                return;
            }

            
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EventManagement;Integrated Security=True";

            // Insert data into the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Attendee (Username, FirstName, LastName, Email, Password) VALUES (@Username, @FirstName, @LastName, @Email, @Password)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password); 

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Registration failed, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
