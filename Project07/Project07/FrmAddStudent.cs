/*
Paul Adams
3/14/16
Project 07
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

namespace Project07
{
    public partial class FrmAddStudent : Form
    {
        public FrmAddStudent()
        {
            InitializeComponent();
        }

        private void FrmAddStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMenu.isChildOpen = false;
        }

        private void FrmAddStudent_Load(object sender, EventArgs e)
        {
            AddGradYears();
            AddMajors();
            AddStates();
            AddPhoneTypes();
            this.AutoValidate = AutoValidate.Disable;
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
        private void AddGradYears()
        {
            ddGradYear.Items.Add("Please make a selection");
            for (int i = 2016; i <= 2026; i++)
            {
                ddGradYear.Items.Add(i);
            }
            ddGradYear.SelectedIndex = 0;
        }

        private void AddMajors()
        {
            ddMajor.Items.Add("Please make a selection");
            ddMajor.Items.Add("Accounting");
            ddMajor.Items.Add("Art");
            ddMajor.Items.Add("Bio");
            ddMajor.Items.Add("Chem");
            ddMajor.Items.Add("CIS");
            ddMajor.Items.Add("Eductation");
            ddMajor.Items.Add("History");
            ddMajor.Items.Add("Math");
            ddMajor.Items.Add("Pre-Med");
            ddMajor.Items.Add("Undecided");
            ddMajor.SelectedIndex = 0;
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbFirstName.Text))
            {
                lblErrorFName.Visible = true;
                e.Cancel = true;
            }
            else
            {
                lblErrorFName.Visible = false;
            }
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

        private void ddMajor_Validating(object sender, CancelEventArgs e)
        {
            if(ddMajor.SelectedIndex == 0)
            {
                lblErrorMajor.Visible = true;
                e.Cancel = true;
            }
            else
            {
                lblErrorMajor.Visible = false;
            }
        }

        private void tbGPA_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbGPA.Text))
            {
                lblErrorGPA.Visible = true;
                e.Cancel = true;
            }
            else
            {
                decimal i;
                if (decimal.TryParse(tbGPA.Text, out i))
                {
                    lblErrorGPA.Visible = false;
                }
                else
                {
                    lblErrorGPA.Visible = true;
                    e.Cancel = true;
                }

            }
        }

        private void ddGradYear_Validating(object sender, CancelEventArgs e)
        {
            if(ddGradYear.SelectedIndex == 0)
            {
                lblErrorGradYear.Visible = true;
                e.Cancel = true;
            }
            else
            {
                lblErrorGradYear.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblErrorGender.Visible = false;

            if (this.ValidateChildren())
            {
                if (rbMale.Checked || rbFemale.Checked)
                {
                    string selectedGender;
                    if (rbFemale.Checked)
                    {
                        selectedGender = "Female";
                    }
                    else
                    {
                        selectedGender = "Male";
                    }

                    MessageBox.Show("Adding Student");
                    var stu = new StudentClass(tbFirstName.Text, tbLastName.Text, tbAddress.Text, tbCity.Text, DDState.Text, tbZipCode.Text, tbPhone.Text,
                        ddPhoneType.Text, dpDOB.Text, selectedGender, ddMajor.Text, decimal.Parse(tbGPA.Text), ddGradYear.Text);
                    FrmMenu.student.Add(stu);
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
    }
}
