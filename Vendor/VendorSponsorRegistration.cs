using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBProject.Vendor
{
    public partial class VendorSponsorRegistration : Form
    {
        public VendorSponsorRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string vendorName = txtName.Text;
            string contactInfo = txtPhoneNumber.Text;

            if (string.IsNullOrEmpty(vendorName) || string.IsNullOrEmpty(contactInfo))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            bool isVendorAdded = AddVendor(vendorName, contactInfo);

            if (isVendorAdded)
            {
                MessageBox.Show("Vendor registered successfully.");
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to register the vendor.");
            }
        }

        private bool AddVendor(string vendorName, string contactInfo)
        {
            try
            {
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EventManagement;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Vendor (Name, ContactInfo) VALUES (@Name, @ContactInfo)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", vendorName);
                        cmd.Parameters.AddWithValue("@ContactInfo", contactInfo);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtPhoneNumber.Clear();
        }
    }
}
