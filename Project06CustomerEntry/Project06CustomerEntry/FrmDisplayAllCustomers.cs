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
    public partial class FrmDisplayAllCustomers : Form
    {
        
        public FrmDisplayAllCustomers(List<ClassCustomer> myList)
        {

            
            InitializeComponent();
            foreach (ClassCustomer i in myList)
            {
                dataGridView1.Rows.Add(i.FirstName, i.LastName, i.StreetAddress, i.State, i.City, i.Zip, i.Phone);
            }
        }

        
       
    }
}
