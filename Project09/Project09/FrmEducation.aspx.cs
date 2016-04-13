/*
Paul Adams
Project 09
10 April 2016

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project09
{
    public partial class FrmEducation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            result.Visible = false;
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            LblEducationError.Visible = false;
            LblFirstNameError.Visible = false;
            LblLastNameError.Visible = false;
            if (ValidateEntry())
            {
                main.Visible = false;
                result.Visible = true;
                LblNameResult.Text = "Name: " + TBFirstName.Text + " " + TBLastName.Text;

                LblEducationResult.Text = "Education level: " + DDEducation.Text;
            }
            


        }

        private bool ValidateEntry()
        {
            bool valid = true;

            if (String.IsNullOrEmpty(TBFirstName.Text))
            {
                LblFirstNameError.Visible = true;
                valid = false;
            }
            if (string.IsNullOrEmpty(TBLastName.Text))
            {
                LblLastNameError.Visible = true;
                valid = false;
            }
            if (DDEducation.SelectedIndex == 0)
            {
                LblEducationError.Visible = true;
                valid = false;
            }


            return valid;
        }
    }
}