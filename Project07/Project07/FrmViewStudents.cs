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
    public partial class FrmViewStudents : Form
    {
        public FrmViewStudents()
        {
            InitializeComponent();
        }

        private void FrmViewStudents_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMenu.isChildOpen = false;
        }

        private void FrmViewStudents_Load(object sender, EventArgs e)
        {
            foreach(StudentClass i in FrmMenu.student)
            {
                dataGridView1.Rows.Add(i.FirstName, i.LastName, i.Address, i.City, i.State, i.ZipCode, i.PhoneNumber, i.PhoneType, i.DateOfBirth, i.Gender, i.Major, i.GPA, i.GraduationYear);
            }
        }
    }
}
