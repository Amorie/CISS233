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
    public partial class FrmViewEmployees : Form
    {
        public FrmViewEmployees()
        {
            InitializeComponent();
        }

        private void FrmViewEmployees_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMenu.isChildOpen = false;
        }

        private void FrmViewEmployees_Load(object sender, EventArgs e)
        {
            foreach(EmployeeClass i in FrmMenu.employee)
            {
                dataGridView1.Rows.Add(i.FirstName, i.LastName, i.Address, i.City, i.State, i.ZipCode, i.PhoneNumber, i.PhoneType, i.DateOfBirth, i.Gender, i.Dependents, i.SSN, i.Department, i.Salary);
            }
        }
    }
}
