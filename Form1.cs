using DBProject.Attendee;
using DBProject.Vendor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DBProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //Registration registration = new Registration();
            //registration.Show();

            //EventSearchForm eventSearchForm = new EventSearchForm();
            //eventSearchForm.Show();

            //EventDashboardForm eventDashboardForm = new EventDashboardForm();
            //eventDashboardForm.Show();

            ContractAndPaymentTrackingForm f1 = new ContractAndPaymentTrackingForm();
            f1.Show();
            this.Hide();
            
        }
    }
}
