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
    }
}
