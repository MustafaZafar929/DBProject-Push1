using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject.Attendee
{
    public partial class Registration : Form
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EventManagement;Integrated Security=True";
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

           if(string.IsNullOrEmpty(email))
           {
                label4.Visible = true;
           }


            if (string.IsNullOrEmpty(password))
            {
                label5.Visible = true;
                
            }

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM attendee where email = @email AND password = @password";

                    using (SqlCommand cmd = new SqlCommand(query , connection))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);

                        int result = (int)cmd.ExecuteScalar();

                        if(result > 0)
                        {
                            MessageBox.Show("Login successful !");
                            this.Close();
                        }

                        else
                        {
                            MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }

                catch(Exception ex)
                {
                    MessageBox.Show($"An error occured : {ex.Message}");
                }

            }
        }
    }
}
