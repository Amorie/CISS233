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
    public partial class FrmMenu : Form
    {
        static public List<StudentClass> student = new List<StudentClass>();
        static public List<EmployeeClass> employee = new List<EmployeeClass>();
        static public bool isChildOpen = false;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void addStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isChildOpen)
            {
                isChildOpen = true;
                FrmAddStudent frmAddStudent = new FrmAddStudent();
                frmAddStudent.MdiParent = this;
                frmAddStudent.Show();
                frmAddStudent.WindowState = FormWindowState.Maximized;
            }
        }

        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isChildOpen)
            {
                isChildOpen = true;
                FrmViewStudents frmViewStudents = new FrmViewStudents();
                frmViewStudents.MdiParent = this;
                frmViewStudents.Show();
                frmViewStudents.WindowState = FormWindowState.Maximized;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isChildOpen)
            {
                isChildOpen = true;
                FrmAddEmployee frmAddEmployee = new FrmAddEmployee();
                frmAddEmployee.MdiParent = this;
                frmAddEmployee.Show();
                frmAddEmployee.WindowState = FormWindowState.Maximized;
            }
        }

        private void viewEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isChildOpen)
            {
                isChildOpen = true;
                FrmViewEmployees frmViewEmployees = new FrmViewEmployees();
                frmViewEmployees.MdiParent = this;
                frmViewEmployees.Show();
                frmViewEmployees.WindowState = FormWindowState.Maximized;
            }
        }


    }
}
