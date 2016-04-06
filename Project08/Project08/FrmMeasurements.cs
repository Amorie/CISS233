/*
Paul Adams
Project 8
4/5/16
*/

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project08
{
    public partial class FrmMeasurements : Form
    {

        static List<ClassMeasurement> measurements = new List<ClassMeasurement>();
        private Decimal _precip;
        private DateTime _time;

        public FrmMeasurements()
        {
            InitializeComponent();
            PnlDisplay.Visible = false;
            PnlEntry.Visible = false;
            LblErrorDate.Visible = false;
            LblMeasurementError.Visible = false;
            this.AutoValidate = AutoValidate.Disable;
            DataUtilityClass.ConnectToDB();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSaveEntry_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
            {
                
                MessageBox.Show("Successfully added New record");
                TBMeasurement.Clear();
                DPPrecip.Value = DateTime.Today;
                PnlEntry.Visible = false;
                DataUtilityClass.AddMeasurement(new ClassMeasurement(_time, _precip));
            }
            
            

        }

       

        private void ClearMessages()
        {
            LblErrorDate.Visible = false;
            LblMeasurementError.Visible = false;
        }

        private void BtnEntryClose_Click(object sender, EventArgs e)
        {
            PnlEntry.Visible = false;
        }

        private void BtnDisplayClose_Click(object sender, EventArgs e)
        {
            PnlDisplay.Visible = false;
        }

        private void BtnViewAll_Click(object sender, EventArgs e)
        {
            PnlEntry.Visible = false;
            PnlDisplay.Visible = true;
            DGViewPrecip.Rows.Clear();
            measurements = DataUtilityClass.GetMeasurements();
            foreach (var classMeasurement in measurements)
            {
                DGViewPrecip.Rows.Add(classMeasurement.PrecipDate.ToShortDateString(), classMeasurement.PrecipAmount);
            }
            
        }

        private void BtnMeasurement_Click(object sender, EventArgs e)
        {
            PnlDisplay.Visible = false;
            PnlEntry.Visible = true;
        }

        private void DPPrecip_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _time = DPPrecip.Value.Date;
            if (_time <= DateTime.Today)
            {
                
            }
            else
            {
                LblErrorDate.Visible = true;
                e.Cancel = true;
            }
        }

        private void TBMeasurement_Validated(object sender, EventArgs e)
        {
            LblMeasurementError.Visible = false;
        }

        private void DPPrecip_Validated(object sender, EventArgs e)
        {
            LblErrorDate.Visible = false;
        }

        private void TBMeasurement_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(TBMeasurement.Text))
            {
                LblMeasurementError.Visible = true;
                e.Cancel = true;
            }
            if (Decimal.TryParse(TBMeasurement.Text, out _precip))
            {
               
            }
            else
            {
                LblMeasurementError.Visible = true;
                e.Cancel = true;
            }
            
        }
    }
}
