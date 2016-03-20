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
            
        }

        private void FrmAddEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMenu.isChildOpen = false;
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
            lblErrorGender.Visible = false;

           if( this.ValidateChildren())
            {
                if(rbMale.Checked || rbFemale.Checked)
                {
                    string selectedGender;
                    if(rbFemale.Checked)
                    {
                        selectedGender = "Female";
                    }
                    else
                    {
                        selectedGender = "Male";
                    }
                    
                    MessageBox.Show("Adding Employee");
                    var emp = new EmployeeClass(tbFirstName.Text, tbLastName.Text, tbAddress.Text, tbCity.Text, DDState.Text, tbZipCode.Text, tbPhone.Text,
                        ddPhoneType.Text, dpDOB.Text, selectedGender, ddDependents.SelectedIndex, tbSSN.Text, ddDepartment.Text, int.Parse(tbSalary.Text));
                    FrmMenu.employee.Add(emp);
                    Close();
                }
                
            }
            else
            {
                if (!(rbMale.Checked || rbFemale.Checked))
                    lblErrorGender.Visible = true;
                MessageBox.Show("One or more fields need to be corrected");
            }
            
        }
        

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrWhiteSpace(tbFirstName.Text))
            {
                lblErrorFName.Visible = true;
                e.Cancel = true;
            }
            else
            {
                lblErrorFName.Visible = false;
            }
        }

        private void FrmAddEmployee_Load(object sender, EventArgs e)
        {
            AddStates();
            AddPhoneTypes();
            AddNumbers();
            AddDepartments();
            this.AutoValidate = AutoValidate.Disable;
            
            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbLastName.Text))
            {
                lblErrorLName.Visible = true;
                e.Cancel = true;
            }
            else
            {
                lblErrorLName.Visible = false;
            }
        }

        private void tbAddress_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbAddress.Text))
            {
                lblErrorAddress.Visible = true;
                e.Cancel = true;
            }
            else
            {
                lblErrorAddress.Visible = false;
            }
        }

        private void tbCity_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbCity.Text))
            {
                lblErrorCity.Visible = true;
                e.Cancel = true;
            }
            else
            {
                lblErrorCity.Visible = false;
            }
        }

        private void DDState_Validating(object sender, CancelEventArgs e)
        {
            if (DDState.SelectedIndex == 0)
            {
                lblErrorState.Visible = true;
                e.Cancel = true;
            }
            else
            {
                lblErrorState.Visible = false;
            }
        }

        private void tbZipCode_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbZipCode.Text))
            {
                lblErrorZip.Visible = true;
                e.Cancel = true;
            }
            else
            {
                lblErrorZip.Visible = false;
            }
        }

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbPhone.Text))
            {
                lblErrorPhoneNumber.Visible = true;
                e.Cancel = true;
            }
            else
            {
                lblErrorPhoneNumber.Visible = false;
            }
        }

        private void ddPhoneType_Validating(object sender, CancelEventArgs e)
        {
            if (ddPhoneType.SelectedIndex == 0)
            {
                lblErrorPhoneType.Visible = true;
                e.Cancel = true;
            }
            else
            {
                lblErrorPhoneType.Visible = false;
            }
        }

        private void ddDependents_Validating(object sender, CancelEventArgs e)
        {
            if (ddDependents.SelectedIndex == 0)
            {
                lblErrorDependents.Visible = true;
                e.Cancel = true;
            }
            else
            {
                lblErrorDependents.Visible = false;
            }
        }

        private void tbSSN_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbSSN.Text))
            {
                lblErrorSSN.Visible = true;
                e.Cancel = true;
            }
            else
            {
                lblErrorSSN.Visible = false;
            }
        }

        private void tbSalary_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbSalary.Text))
            {
                lblErrorSalary.Visible = true;
                e.Cancel = true;
            }
            else
            {
                decimal i;
                if (decimal.TryParse(tbSalary.Text, out i))
                {
                    lblErrorSalary.Visible = false;
                }
                else
                {
                    lblErrorSalary.Visible = true;
                    e.Cancel = true;
                }
                
            }
        }

        private void ddDepartment_Validating(object sender, CancelEventArgs e)
        {
            if (ddDepartment.SelectedIndex == 0)
            {
                lblErrorDept.Visible = true;
                e.Cancel = true;
            }
            else
            {
                lblErrorDept.Visible = false;
            }
        }

        private void panel1_Validating(object sender, CancelEventArgs e)
        {
            if (rbFemale.Checked)
            {
                lblErrorGender.Visible = false;
            }
            else
            {
                if (rbMale.Checked)
                {
                    lblErrorGender.Visible = false;
                }
                else
                {
                    lblErrorGender.Visible = true;
                    e.Cancel = true;
                }
            }
           
        }
    }
}
