using DBProject.Admin;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBProject.Vendor
{
    public partial class VendorLogin : Form
    {
        public VendorLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string vendorEmail = txtEmail.Text;
            string vendorContactInfo = txtContactInfo.Text; // Contact info used as password

            if (string.IsNullOrEmpty(vendorEmail) || string.IsNullOrEmpty(vendorContactInfo))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            bool isLoggedIn = VendorLoginCheck(vendorEmail, vendorContactInfo);

            if (isLoggedIn)
            {
                MessageBox.Show("Login successful.");
                this.Hide();

                ServiceSponsorshipBidding serviceSponsorship= new ServiceSponsorshipBidding();
                serviceSponsorship.Show();
            }
            else
            {
                MessageBox.Show("Invalid email or contact info.");
            }
        }

        private bool VendorLoginCheck(string email, string contactInfo)
        {
            try
            {
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EventManagement;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT VendorId FROM Vendor WHERE Email = @Email AND ContactInfo = @ContactInfo";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@ContactInfo", contactInfo);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int vendorId = reader.GetInt32(0);
                            UserSession.UserId = vendorId;
                            return true;
                        }
                    }
                }
                return false;
            }
            catch
            {
                MessageBox.Show("An error occurred while logging in.");
                return false;
            }
        }
    }
}
