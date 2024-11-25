using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


            if (string.IsNullOrWhiteSpace(username))
            {
                label7.Visible = true;
            }


            if (string.IsNullOrWhiteSpace(firstName))
            {
                label8.Visible = true;
            }


            if (string.IsNullOrWhiteSpace(lastName))
            {
                label9.Visible = true;
            }


            if (string.IsNullOrWhiteSpace(email))
            {
                label10.Visible = true;
            }


            if (string.IsNullOrWhiteSpace(password))
            {
                label11.Visible = true;
            }

        }
    }
}
