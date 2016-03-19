using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project07
{
    public partial class FrmAddEmployee : Form
    {
        public FrmAddEmployee()
        {
            InitializeComponent();
            AddStates();
            AddPhoneTypes();
            AddNumbers();
            AddDepartments();
        }

        private void FrmAddEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMenu.isChildOpen = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AddPhoneTypes()
        {
            ddPhoneType.Items.Add("Please make a selection");
            ddPhoneType.Items.Add("Home");
            ddPhoneType.Items.Add("Work");
            ddPhoneType.Items.Add("Cell");
            ddPhoneType.SelectedIndex = 0;
        }
        private void AddStates()

        {
            DDState.Items.Add("Please make a selection");
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
        private void AddNumbers()
        {
            ddDependents.Items.Add("Please make a selection");
            for(int i = 0; i <= 20; i++)
            {
                ddDependents.Items.Add(i);
            }
            ddDependents.SelectedIndex = 0;
        }

        private void AddDepartments()
        {
            ddDepartment.Items.Add("Please make a selection");
            ddDepartment.Items.Add("Administration");
            ddDepartment.Items.Add("Business");
            ddDepartment.Items.Add("Clerical");
            ddDepartment.Items.Add("Faculty");
            ddDepartment.Items.Add("Maintenance");
            ddDepartment.Items.Add("Security");
            ddDepartment.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblErrorFName.Visible = false;
            lblErrorLName.Visible = false;
            lblErrorAddress.Visible = false;
            lblErrorCity.Visible = false;
            lblErrorDependents.Visible = false;
            lblErrorDept.Visible = false;
            lblErrorGender.Visible = false;
            lblErrorPhoneNumber.Visible = false;
            lblErrorPhoneType.Visible = false;
            lblErrorSalary.Visible = false;
            lblErrorSSN.Visible = false;
            lblErrorState.Visible = false;
            lblErrorZip.Visible = false;
            
            

        }
        private bool validateTextBox(TextBox tb, Label lbl)
        {
            bool result = String.IsNullOrWhiteSpace(tb.Text);
            if (result)
            {
                lbl.Visible = true;
            }
            else
            {
                lbl.Visible = false;
            }
            return result;
        }
        private bool ValidateDDL(ComboBox DDL, Label lbl)
        {
            bool result;
            if(DDL.SelectedIndex == 0)
            {
                result = true;
                lbl.Visible = true;
            }
            else
            {
                lbl.Visible = false;
                result = false;
            }
            return result;
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            validateTextBox(tbFirstName, lblErrorFName);
        }
    }
}
