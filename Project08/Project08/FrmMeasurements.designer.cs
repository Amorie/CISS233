/*
Paul Adams
Project 8
4/5/16
*/
namespace Project08
{
    partial class FrmMeasurements
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnMeasurement = new System.Windows.Forms.Button();
            this.BtnViewAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlEntry = new System.Windows.Forms.Panel();
            this.LblMeasurementError = new System.Windows.Forms.Label();
            this.LblErrorDate = new System.Windows.Forms.Label();
            this.BtnEntryClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSaveEntry = new System.Windows.Forms.Button();
            this.TBMeasurement = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblPrecipDate = new System.Windows.Forms.Label();
            this.DPPrecip = new System.Windows.Forms.DateTimePicker();
            this.PnlDisplay = new System.Windows.Forms.Panel();
            this.BtnDisplayClose = new System.Windows.Forms.Button();
            this.DGViewPrecip = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Measurment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlEntry.SuspendLayout();
            this.PnlDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewPrecip)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnMeasurement
            // 
            this.BtnMeasurement.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMeasurement.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnMeasurement.Location = new System.Drawing.Point(13, 50);
            this.BtnMeasurement.Name = "BtnMeasurement";
            this.BtnMeasurement.Size = new System.Drawing.Size(338, 34);
            this.BtnMeasurement.TabIndex = 0;
            this.BtnMeasurement.Text = "Enter Measurement";
            this.BtnMeasurement.UseVisualStyleBackColor = true;
            this.BtnMeasurement.Click += new System.EventHandler(this.BtnMeasurement_Click);
            // 
            // BtnViewAll
            // 
            this.BtnViewAll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewAll.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnViewAll.Location = new System.Drawing.Point(367, 50);
            this.BtnViewAll.Name = "BtnViewAll";
            this.BtnViewAll.Size = new System.Drawing.Size(338, 34);
            this.BtnViewAll.TabIndex = 1;
            this.BtnViewAll.Text = "View All Measurements";
            this.BtnViewAll.UseVisualStyleBackColor = true;
            this.BtnViewAll.Click += new System.EventHandler(this.BtnViewAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Precipitation Measurement Application";
            // 
            // PnlEntry
            // 
            this.PnlEntry.BackColor = System.Drawing.Color.White;
            this.PnlEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlEntry.Controls.Add(this.LblMeasurementError);
            this.PnlEntry.Controls.Add(this.LblErrorDate);
            this.PnlEntry.Controls.Add(this.BtnEntryClose);
            this.PnlEntry.Controls.Add(this.label3);
            this.PnlEntry.Controls.Add(this.BtnSaveEntry);
            this.PnlEntry.Controls.Add(this.TBMeasurement);
            this.PnlEntry.Controls.Add(this.label2);
            this.PnlEntry.Controls.Add(this.LblPrecipDate);
            this.PnlEntry.Controls.Add(this.DPPrecip);
            this.PnlEntry.Location = new System.Drawing.Point(13, 90);
            this.PnlEntry.Name = "PnlEntry";
            this.PnlEntry.Size = new System.Drawing.Size(1047, 482);
            this.PnlEntry.TabIndex = 3;
            this.PnlEntry.Visible = false;
            // 
            // LblMeasurementError
            // 
            this.LblMeasurementError.AutoSize = true;
            this.LblMeasurementError.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMeasurementError.ForeColor = System.Drawing.Color.Red;
            this.LblMeasurementError.Location = new System.Drawing.Point(367, 62);
            this.LblMeasurementError.Name = "LblMeasurementError";
            this.LblMeasurementError.Size = new System.Drawing.Size(298, 23);
            this.LblMeasurementError.TabIndex = 10;
            this.LblMeasurementError.Text = "Please enter a valid measurement!!!";
            // 
            // LblErrorDate
            // 
            this.LblErrorDate.AutoSize = true;
            this.LblErrorDate.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorDate.ForeColor = System.Drawing.Color.Red;
            this.LblErrorDate.Location = new System.Drawing.Point(44, 62);
            this.LblErrorDate.Name = "LblErrorDate";
            this.LblErrorDate.Size = new System.Drawing.Size(223, 23);
            this.LblErrorDate.TabIndex = 9;
            this.LblErrorDate.Text = "Please enter a valid date!!!";
            // 
            // BtnEntryClose
            // 
            this.BtnEntryClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntryClose.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnEntryClose.Location = new System.Drawing.Point(874, 23);
            this.BtnEntryClose.Name = "BtnEntryClose";
            this.BtnEntryClose.Size = new System.Drawing.Size(163, 34);
            this.BtnEntryClose.TabIndex = 8;
            this.BtnEntryClose.Text = "Close";
            this.BtnEntryClose.UseVisualStyleBackColor = true;
            this.BtnEntryClose.Click += new System.EventHandler(this.BtnEntryClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter Precipitation Information:";
            // 
            // BtnSaveEntry
            // 
            this.BtnSaveEntry.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveEntry.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnSaveEntry.Location = new System.Drawing.Point(703, 23);
            this.BtnSaveEntry.Name = "BtnSaveEntry";
            this.BtnSaveEntry.Size = new System.Drawing.Size(163, 34);
            this.BtnSaveEntry.TabIndex = 6;
            this.BtnSaveEntry.Text = "Save";
            this.BtnSaveEntry.UseVisualStyleBackColor = true;
            this.BtnSaveEntry.Click += new System.EventHandler(this.BtnSaveEntry_Click);
            // 
            // TBMeasurement
            // 
            this.TBMeasurement.Location = new System.Drawing.Point(579, 38);
            this.TBMeasurement.Name = "TBMeasurement";
            this.TBMeasurement.Size = new System.Drawing.Size(105, 20);
            this.TBMeasurement.TabIndex = 3;
            this.TBMeasurement.Validating += new System.ComponentModel.CancelEventHandler(this.TBMeasurement_Validating);
            this.TBMeasurement.Validated += new System.EventHandler(this.TBMeasurement_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precipitation Amount (cms):";
            // 
            // LblPrecipDate
            // 
            this.LblPrecipDate.AutoSize = true;
            this.LblPrecipDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecipDate.Location = new System.Drawing.Point(18, 39);
            this.LblPrecipDate.Name = "LblPrecipDate";
            this.LblPrecipDate.Size = new System.Drawing.Size(179, 20);
            this.LblPrecipDate.TabIndex = 1;
            this.LblPrecipDate.Text = "Date of Precipitation:";
            // 
            // DPPrecip
            // 
            this.DPPrecip.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPPrecip.Location = new System.Drawing.Point(212, 39);
            this.DPPrecip.Name = "DPPrecip";
            this.DPPrecip.Size = new System.Drawing.Size(105, 20);
            this.DPPrecip.TabIndex = 0;
            this.DPPrecip.Validating += new System.ComponentModel.CancelEventHandler(this.DPPrecip_Validating);
            this.DPPrecip.Validated += new System.EventHandler(this.DPPrecip_Validated);
            // 
            // PnlDisplay
            // 
            this.PnlDisplay.BackColor = System.Drawing.Color.White;
            this.PnlDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlDisplay.Controls.Add(this.BtnDisplayClose);
            this.PnlDisplay.Controls.Add(this.DGViewPrecip);
            this.PnlDisplay.Controls.Add(this.label4);
            this.PnlDisplay.Location = new System.Drawing.Point(13, 90);
            this.PnlDisplay.Name = "PnlDisplay";
            this.PnlDisplay.Size = new System.Drawing.Size(1047, 474);
            this.PnlDisplay.TabIndex = 4;
            // 
            // BtnDisplayClose
            // 
            this.BtnDisplayClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDisplayClose.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnDisplayClose.Location = new System.Drawing.Point(874, 23);
            this.BtnDisplayClose.Name = "BtnDisplayClose";
            this.BtnDisplayClose.Size = new System.Drawing.Size(163, 34);
            this.BtnDisplayClose.TabIndex = 10;
            this.BtnDisplayClose.Text = "Close";
            this.BtnDisplayClose.UseVisualStyleBackColor = true;
            this.BtnDisplayClose.Click += new System.EventHandler(this.BtnDisplayClose_Click);
            // 
            // DGViewPrecip
            // 
            this.DGViewPrecip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGViewPrecip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Measurment});
            this.DGViewPrecip.Location = new System.Drawing.Point(353, 38);
            this.DGViewPrecip.Name = "DGViewPrecip";
            this.DGViewPrecip.Size = new System.Drawing.Size(338, 431);
            this.DGViewPrecip.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precipitation Information:";
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnClose.Location = new System.Drawing.Point(721, 50);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(338, 34);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Text = "Exit";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Measurment
            // 
            this.Measurment.HeaderText = "Measurement";
            this.Measurment.Name = "Measurment";
            // 
            // FrmMeasurements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 580);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnViewAll);
            this.Controls.Add(this.BtnMeasurement);
            this.Controls.Add(this.PnlDisplay);
            this.Controls.Add(this.PnlEntry);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMeasurements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Measurement Recorder";
            this.TopMost = true;
            this.PnlEntry.ResumeLayout(false);
            this.PnlEntry.PerformLayout();
            this.PnlDisplay.ResumeLayout(false);
            this.PnlDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewPrecip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMeasurement;
        private System.Windows.Forms.Button BtnViewAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlEntry;
        private System.Windows.Forms.Panel PnlDisplay;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DateTimePicker DPPrecip;
        private System.Windows.Forms.Button BtnSaveEntry;
        private System.Windows.Forms.TextBox TBMeasurement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblPrecipDate;
        private System.Windows.Forms.Button BtnEntryClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnDisplayClose;
        private System.Windows.Forms.DataGridView DGViewPrecip;
        private System.Windows.Forms.Label LblMeasurementError;
        private System.Windows.Forms.Label LblErrorDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Measurment;
    }
}

