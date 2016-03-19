/*
Paul Adams
Project 6 Customer Entry
3/1/16
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project06CustomerEntry
{
    public partial class FrmCustomerEntry : Form
    {
        static List<ClassCustomer> customer;
        FrmAbout frmAbout = new FrmAbout();
        
        public FrmCustomerEntry()
        {
            customer = new List<ClassCustomer>();
            InitializeComponent();
            AddStates();
        }

        private void LblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void LblLastName_Click(object sender, EventArgs e)
        {

        }

        private void LblStreet_Click(object sender, EventArgs e)
        {

        }

        private void LblCity_Click(object sender, EventArgs e)
        {

        }

        private void LblState_Click(object sender, EventArgs e)
        {

        }

        private void LblZip_Click(object sender, EventArgs e)
        {

        }

        private void FrmCustomerEntry_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void DDState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AddStates()

        {
            DDState.Items.Add("Please select a State....");
            DDState.Items.Add("Alabama");
            DDState.Items.Add("Alaska");
            DDState.Items.Add("Arizona");
            DDState.Items.Add("Arkansas");
            DDState.Items.Add("California");
            DDState.Items.Add("Colorado");
            DDState.Items.Add("Connecticut");
            DDState.Items.Add("Delaware");
            DDState.Items.Add("Florida");
            DDState.Items.Add("Georgia");
            DDState.Items.Add("Hawaii");
            DDState.Items.Add("Idaho");
            DDState.Items.Add("Illinois");
            DDState.Items.Add("Indiana");
            DDState.Items.Add("Iowa");
            DDState.Items.Add("Kansas");
            DDState.Items.Add("Kentucky");
            DDState.Items.Add("Louisiana");
            DDState.Items.Add("Maine");
            DDState.Items.Add("Maryland");
            DDState.Items.Add("Massachusetts");
            DDState.Items.Add("Michigan");
            DDState.Items.Add("Minnesota");
            DDState.Items.Add("Mississippi");
            DDState.Items.Add("Missouri");
            DDState.Items.Add("Montana");
            DDState.Items.Add("Nebraska");
            DDState.Items.Add("Nevada");
            DDState.Items.Add("New Hampshire");
            DDState.Items.Add("New Jersey");
            DDState.Items.Add("New Mexico");
            DDState.Items.Add("New York");
            DDState.Items.Add("North Carolina");
            DDState.Items.Add("North Dakota");
            DDState.Items.Add("Ohio");
            DDState.Items.Add("Oklahoma");
            DDState.Items.Add("Oregon");
            DDState.Items.Add("Pennsylvania");
            DDState.Items.Add("Rhode Island");
            DDState.Items.Add("South Carolina");
            DDState.Items.Add("South Dakota");
            DDState.Items.Add("Tennessee");
            DDState.Items.Add("Texas");
            DDState.Items.Add("Utah");
            DDState.Items.Add("Vermont");
            DDState.Items.Add("Virginia");
            DDState.Items.Add("Washington");
            DDState.Items.Add("West Virginia");
            DDState.Items.Add("Wisconsin");
            DDState.Items.Add("Wyoming");
            DDState.SelectedIndex = 0;
        }

        private void LblPhone_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblErrorFName.Visible = false;
            lblErrorLName.Visible = false;
            lblErrorStreet.Visible = false;
            lblErrorState.Visible = false;
            lblErrorCity.Visible = false;
            lblErrorZip.Visible = false;
            lblErrorPhone.Visible = false;


            List<string> error = new List<string>();
            if (String.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                error.Add("First Name");
                lblErrorFName.Visible = true;
            }
            if (String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                error.Add("Last Name");
                lblErrorLName.Visible = true;
            }
            if (String.IsNullOrWhiteSpace(txtAddress.Text))
            {
                error.Add("Address");
                lblErrorStreet.Visible = true;
            }
            if (DDState.Text == "Please select a State....")
            {
                error.Add("State");
                lblErrorState.Visible = true;
            }

            if (String.IsNullOrWhiteSpace(txtCity.Text))
            {
                error.Add("City");
                lblErrorCity.Visible = true;
            }

            if (String.IsNullOrWhiteSpace(txtZip.Text))
            {
                error.Add("Zip");
                lblErrorZip.Visible = true;
            }

            if (String.IsNullOrWhiteSpace(txtPhone.Text))
            {
                error.Add("Phone #");
                lblErrorPhone.Visible = true;
            }
            
            if(error.Count > 0)
            {
                string list = "You are missing the following required items:\n\n";
                foreach(string i in error)
                {
                    list += i + "\n";
                }
                MessageBox.Show(list,"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                customer.Add(new ClassCustomer(txtFirstName.Text, txtLastName.Text, txtAddress.Text,txtCity.Text, DDState.Text, txtZip.Text, txtPhone.Text));
                MessageBox.Show("New Customer Added!");
                clear();
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtZip.Clear();
            DDState.SelectedIndex = 0;
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            frmAbout.ShowDialog();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuDisplayCustomers_Click(object sender, EventArgs e)
        {
            FrmDisplayAllCustomers frmCustomer = new FrmDisplayAllCustomers(customer);
            frmCustomer.ShowDialog();
        }

        private void menuClearCustomers_Click(object sender, EventArgs e)
        {
            customer.Clear();
        }
    }
}
