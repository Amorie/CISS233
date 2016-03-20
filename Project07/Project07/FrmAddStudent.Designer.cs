namespace Project07
{
    partial class FrmAddStudent
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
            this.lblErrorGradYear = new System.Windows.Forms.Label();
            this.lblErrorGPA = new System.Windows.Forms.Label();
            this.lblErrorMajor = new System.Windows.Forms.Label();
            this.lblErrorPhoneType = new System.Windows.Forms.Label();
            this.lblErrorPhoneNumber = new System.Windows.Forms.Label();
            this.lblErrorZip = new System.Windows.Forms.Label();
            this.lblErrorState = new System.Windows.Forms.Label();
            this.lblErrorCity = new System.Windows.Forms.Label();
            this.lblErrorAddress = new System.Windows.Forms.Label();
            this.lblErrorGender = new System.Windows.Forms.Label();
            this.lblErrorLName = new System.Windows.Forms.Label();
            this.lblErrorFName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.ddGradYear = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGPA = new System.Windows.Forms.TextBox();
            this.ddMajor = new System.Windows.Forms.ComboBox();
            this.ddPhoneType = new System.Windows.Forms.ComboBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbZipCode = new System.Windows.Forms.TextBox();
            this.DDState = new System.Windows.Forms.ComboBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.dpDOB = new System.Windows.Forms.DateTimePicker();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblErrorGradYear
            // 
            this.lblErrorGradYear.AutoSize = true;
            this.lblErrorGradYear.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorGradYear.Location = new System.Drawing.Point(293, 166);
            this.lblErrorGradYear.Name = "lblErrorGradYear";
            this.lblErrorGradYear.Size = new System.Drawing.Size(11, 13);
            this.lblErrorGradYear.TabIndex = 85;
            this.lblErrorGradYear.Text = "*";
            this.lblErrorGradYear.Visible = false;
            // 
            // lblErrorGPA
            // 
            this.lblErrorGPA.AutoSize = true;
            this.lblErrorGPA.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorGPA.Location = new System.Drawing.Point(293, 138);
            this.lblErrorGPA.Name = "lblErrorGPA";
            this.lblErrorGPA.Size = new System.Drawing.Size(11, 13);
            this.lblErrorGPA.TabIndex = 84;
            this.lblErrorGPA.Text = "*";
            this.lblErrorGPA.Visible = false;
            // 
            // lblErrorMajor
            // 
            this.lblErrorMajor.AutoSize = true;
            this.lblErrorMajor.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorMajor.Location = new System.Drawing.Point(293, 105);
            this.lblErrorMajor.Name = "lblErrorMajor";
            this.lblErrorMajor.Size = new System.Drawing.Size(11, 13);
            this.lblErrorMajor.TabIndex = 83;
            this.lblErrorMajor.Text = "*";
            this.lblErrorMajor.Visible = false;
            // 
            // lblErrorPhoneType
            // 
            this.lblErrorPhoneType.AutoSize = true;
            this.lblErrorPhoneType.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorPhoneType.Location = new System.Drawing.Point(293, 72);
            this.lblErrorPhoneType.Name = "lblErrorPhoneType";
            this.lblErrorPhoneType.Size = new System.Drawing.Size(11, 13);
            this.lblErrorPhoneType.TabIndex = 82;
            this.lblErrorPhoneType.Text = "*";
            this.lblErrorPhoneType.Visible = false;
            // 
            // lblErrorPhoneNumber
            // 
            this.lblErrorPhoneNumber.AutoSize = true;
            this.lblErrorPhoneNumber.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorPhoneNumber.Location = new System.Drawing.Point(293, 39);
            this.lblErrorPhoneNumber.Name = "lblErrorPhoneNumber";
            this.lblErrorPhoneNumber.Size = new System.Drawing.Size(11, 13);
            this.lblErrorPhoneNumber.TabIndex = 81;
            this.lblErrorPhoneNumber.Text = "*";
            this.lblErrorPhoneNumber.Visible = false;
            // 
            // lblErrorZip
            // 
            this.lblErrorZip.AutoSize = true;
            this.lblErrorZip.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorZip.Location = new System.Drawing.Point(106, 270);
            this.lblErrorZip.Name = "lblErrorZip";
            this.lblErrorZip.Size = new System.Drawing.Size(11, 13);
            this.lblErrorZip.TabIndex = 80;
            this.lblErrorZip.Text = "*";
            this.lblErrorZip.Visible = false;
            // 
            // lblErrorState
            // 
            this.lblErrorState.AutoSize = true;
            this.lblErrorState.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorState.Location = new System.Drawing.Point(106, 234);
            this.lblErrorState.Name = "lblErrorState";
            this.lblErrorState.Size = new System.Drawing.Size(11, 13);
            this.lblErrorState.TabIndex = 79;
            this.lblErrorState.Text = "*";
            this.lblErrorState.Visible = false;
            // 
            // lblErrorCity
            // 
            this.lblErrorCity.AutoSize = true;
            this.lblErrorCity.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorCity.Location = new System.Drawing.Point(106, 204);
            this.lblErrorCity.Name = "lblErrorCity";
            this.lblErrorCity.Size = new System.Drawing.Size(11, 13);
            this.lblErrorCity.TabIndex = 78;
            this.lblErrorCity.Text = "*";
            this.lblErrorCity.Visible = false;
            // 
            // lblErrorAddress
            // 
            this.lblErrorAddress.AutoSize = true;
            this.lblErrorAddress.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorAddress.Location = new System.Drawing.Point(106, 171);
            this.lblErrorAddress.Name = "lblErrorAddress";
            this.lblErrorAddress.Size = new System.Drawing.Size(11, 13);
            this.lblErrorAddress.TabIndex = 77;
            this.lblErrorAddress.Text = "*";
            this.lblErrorAddress.Visible = false;
            // 
            // lblErrorGender
            // 
            this.lblErrorGender.AutoSize = true;
            this.lblErrorGender.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorGender.Location = new System.Drawing.Point(106, 138);
            this.lblErrorGender.Name = "lblErrorGender";
            this.lblErrorGender.Size = new System.Drawing.Size(11, 13);
            this.lblErrorGender.TabIndex = 76;
            this.lblErrorGender.Text = "*";
            this.lblErrorGender.Visible = false;
            // 
            // lblErrorLName
            // 
            this.lblErrorLName.AutoSize = true;
            this.lblErrorLName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorLName.Location = new System.Drawing.Point(106, 72);
            this.lblErrorLName.Name = "lblErrorLName";
            this.lblErrorLName.Size = new System.Drawing.Size(11, 13);
            this.lblErrorLName.TabIndex = 75;
            this.lblErrorLName.Text = "*";
            this.lblErrorLName.Visible = false;
            // 
            // lblErrorFName
            // 
            this.lblErrorFName.AutoSize = true;
            this.lblErrorFName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorFName.Location = new System.Drawing.Point(106, 39);
            this.lblErrorFName.Name = "lblErrorFName";
            this.lblErrorFName.Size = new System.Drawing.Size(11, 13);
            this.lblErrorFName.TabIndex = 74;
            this.lblErrorFName.Text = "*";
            this.lblErrorFName.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(381, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 73;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(472, 300);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 72;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ddGradYear
            // 
            this.ddGradYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddGradYear.FormattingEnabled = true;
            this.ddGradYear.Location = new System.Drawing.Point(405, 163);
            this.ddGradYear.Name = "ddGradYear";
            this.ddGradYear.Size = new System.Drawing.Size(143, 21);
            this.ddGradYear.TabIndex = 71;
            this.ddGradYear.Validating += new System.ComponentModel.CancelEventHandler(this.ddGradYear_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Gender";
            // 
            // tbGPA
            // 
            this.tbGPA.Location = new System.Drawing.Point(405, 135);
            this.tbGPA.Name = "tbGPA";
            this.tbGPA.Size = new System.Drawing.Size(143, 20);
            this.tbGPA.TabIndex = 69;
            this.tbGPA.Validating += new System.ComponentModel.CancelEventHandler(this.tbGPA_Validating);
            // 
            // ddMajor
            // 
            this.ddMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddMajor.FormattingEnabled = true;
            this.ddMajor.Location = new System.Drawing.Point(405, 102);
            this.ddMajor.Name = "ddMajor";
            this.ddMajor.Size = new System.Drawing.Size(143, 21);
            this.ddMajor.TabIndex = 68;
            this.ddMajor.Validating += new System.ComponentModel.CancelEventHandler(this.ddMajor_Validating);
            // 
            // ddPhoneType
            // 
            this.ddPhoneType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddPhoneType.FormattingEnabled = true;
            this.ddPhoneType.Location = new System.Drawing.Point(405, 69);
            this.ddPhoneType.Name = "ddPhoneType";
            this.ddPhoneType.Size = new System.Drawing.Size(143, 21);
            this.ddPhoneType.TabIndex = 67;
            this.ddPhoneType.Validating += new System.ComponentModel.CancelEventHandler(this.ddPhoneType_Validating);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(405, 36);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(143, 20);
            this.tbPhone.TabIndex = 66;
            this.tbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.tbPhone_Validating);
            // 
            // tbZipCode
            // 
            this.tbZipCode.Location = new System.Drawing.Point(123, 267);
            this.tbZipCode.Name = "tbZipCode";
            this.tbZipCode.Size = new System.Drawing.Size(143, 20);
            this.tbZipCode.TabIndex = 65;
            this.tbZipCode.Validating += new System.ComponentModel.CancelEventHandler(this.tbZipCode_Validating);
            // 
            // DDState
            // 
            this.DDState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DDState.FormattingEnabled = true;
            this.DDState.Location = new System.Drawing.Point(123, 234);
            this.DDState.Name = "DDState";
            this.DDState.Size = new System.Drawing.Size(143, 21);
            this.DDState.TabIndex = 64;
            this.DDState.Validating += new System.ComponentModel.CancelEventHandler(this.DDState_Validating);
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(123, 201);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(143, 20);
            this.tbCity.TabIndex = 63;
            this.tbCity.Validating += new System.ComponentModel.CancelEventHandler(this.tbCity_Validating);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(123, 168);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(143, 20);
            this.tbAddress.TabIndex = 62;
            this.tbAddress.Validating += new System.ComponentModel.CancelEventHandler(this.tbAddress_Validating);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Location = new System.Drawing.Point(114, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 26);
            this.panel1.TabIndex = 61;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(93, 4);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 18;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(9, 4);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 17;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // dpDOB
            // 
            this.dpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDOB.Location = new System.Drawing.Point(123, 99);
            this.dpDOB.Name = "dpDOB";
            this.dpDOB.Size = new System.Drawing.Size(143, 20);
            this.dpDOB.TabIndex = 60;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(123, 69);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(143, 20);
            this.tbLastName.TabIndex = 59;
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tbLastName_Validating);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(123, 36);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(143, 20);
            this.tbFirstName.TabIndex = 58;
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFirstName_Validating);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(310, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 57;
            this.label14.Text = "Graduation Year";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(310, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "GPA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(310, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Major";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(310, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Phone Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(310, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Phone Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Zip Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Date of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "First Name";
            // 
            // FrmAddStudent
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 364);
            this.Controls.Add(this.lblErrorGradYear);
            this.Controls.Add(this.lblErrorGPA);
            this.Controls.Add(this.lblErrorMajor);
            this.Controls.Add(this.lblErrorPhoneType);
            this.Controls.Add(this.lblErrorPhoneNumber);
            this.Controls.Add(this.lblErrorZip);
            this.Controls.Add(this.lblErrorState);
            this.Controls.Add(this.lblErrorCity);
            this.Controls.Add(this.lblErrorAddress);
            this.Controls.Add(this.lblErrorGender);
            this.Controls.Add(this.lblErrorLName);
            this.Controls.Add(this.lblErrorFName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.ddGradYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbGPA);
            this.Controls.Add(this.ddMajor);
            this.Controls.Add(this.ddPhoneType);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbZipCode);
            this.Controls.Add(this.DDState);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dpDOB);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddStudent";
            this.Text = "Add Student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddStudent_FormClosing);
            this.Load += new System.EventHandler(this.FrmAddStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErrorGradYear;
        private System.Windows.Forms.Label lblErrorGPA;
        private System.Windows.Forms.Label lblErrorMajor;
        private System.Windows.Forms.Label lblErrorPhoneType;
        private System.Windows.Forms.Label lblErrorPhoneNumber;
        private System.Windows.Forms.Label lblErrorZip;
        private System.Windows.Forms.Label lblErrorState;
        private System.Windows.Forms.Label lblErrorCity;
        private System.Windows.Forms.Label lblErrorAddress;
        private System.Windows.Forms.Label lblErrorGender;
        private System.Windows.Forms.Label lblErrorLName;
        private System.Windows.Forms.Label lblErrorFName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox ddGradYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbGPA;
        private System.Windows.Forms.ComboBox ddMajor;
        private System.Windows.Forms.ComboBox ddPhoneType;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbZipCode;
        private System.Windows.Forms.ComboBox DDState;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.DateTimePicker dpDOB;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}