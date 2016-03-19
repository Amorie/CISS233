namespace Project06CustomerEntry
{
    partial class FrmCustomerEntry
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
            this.components = new System.ComponentModel.Container();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblStreet = new System.Windows.Forms.Label();
            this.LblCity = new System.Windows.Forms.Label();
            this.LblState = new System.Windows.Forms.Label();
            this.LblZip = new System.Windows.Forms.Label();
            this.LblPhone = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.DDState = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuDisplayCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClearCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblErrorFName = new System.Windows.Forms.Label();
            this.lblErrorLName = new System.Windows.Forms.Label();
            this.lblErrorStreet = new System.Windows.Forms.Label();
            this.lblErrorCity = new System.Windows.Forms.Label();
            this.lblErrorState = new System.Windows.Forms.Label();
            this.lblErrorZip = new System.Windows.Forms.Label();
            this.lblErrorPhone = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(13, 69);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(60, 13);
            this.LblFirstName.TabIndex = 0;
            this.LblFirstName.Text = "First Name:";
            this.LblFirstName.Click += new System.EventHandler(this.LblFirstName_Click);
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(13, 94);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(61, 13);
            this.LblLastName.TabIndex = 1;
            this.LblLastName.Text = "Last Name:";
            this.LblLastName.Click += new System.EventHandler(this.LblLastName_Click);
            // 
            // LblStreet
            // 
            this.LblStreet.AutoSize = true;
            this.LblStreet.Location = new System.Drawing.Point(13, 122);
            this.LblStreet.Name = "LblStreet";
            this.LblStreet.Size = new System.Drawing.Size(79, 13);
            this.LblStreet.TabIndex = 2;
            this.LblStreet.Text = "Street Address:";
            this.LblStreet.Click += new System.EventHandler(this.LblStreet_Click);
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(13, 150);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(27, 13);
            this.LblCity.TabIndex = 3;
            this.LblCity.Text = "City:";
            this.LblCity.Click += new System.EventHandler(this.LblCity_Click);
            // 
            // LblState
            // 
            this.LblState.AutoSize = true;
            this.LblState.Location = new System.Drawing.Point(13, 178);
            this.LblState.Name = "LblState";
            this.LblState.Size = new System.Drawing.Size(35, 13);
            this.LblState.TabIndex = 4;
            this.LblState.Text = "State:";
            this.LblState.Click += new System.EventHandler(this.LblState_Click);
            // 
            // LblZip
            // 
            this.LblZip.AutoSize = true;
            this.LblZip.Location = new System.Drawing.Point(13, 206);
            this.LblZip.Name = "LblZip";
            this.LblZip.Size = new System.Drawing.Size(53, 13);
            this.LblZip.TabIndex = 5;
            this.LblZip.Text = "Zip Code:";
            this.LblZip.Click += new System.EventHandler(this.LblZip_Click);
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Location = new System.Drawing.Point(13, 234);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(51, 13);
            this.LblPhone.TabIndex = 6;
            this.LblPhone.Text = "Phone #:";
            this.LblPhone.Click += new System.EventHandler(this.LblPhone_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(174, 96);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(142, 20);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(174, 122);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(142, 20);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(174, 150);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(142, 20);
            this.txtCity.TabIndex = 4;
            this.txtCity.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(174, 206);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(142, 20);
            this.txtZip.TabIndex = 6;
            this.txtZip.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(174, 234);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(142, 20);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(174, 66);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(142, 20);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // DDState
            // 
            this.DDState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DDState.FormattingEnabled = true;
            this.DDState.Location = new System.Drawing.Point(174, 179);
            this.DDState.Name = "DDState";
            this.DDState.Size = new System.Drawing.Size(142, 21);
            this.DDState.TabIndex = 5;
            this.DDState.SelectedIndexChanged += new System.EventHandler(this.DDState_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Customer Information";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDisplayCustomers,
            this.menuAbout,
            this.menuClearCustomers,
            this.menuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(355, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuDisplayCustomers
            // 
            this.menuDisplayCustomers.Name = "menuDisplayCustomers";
            this.menuDisplayCustomers.Size = new System.Drawing.Size(134, 20);
            this.menuDisplayCustomers.Text = "Display All Customers";
            this.menuDisplayCustomers.Click += new System.EventHandler(this.menuDisplayCustomers_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(52, 20);
            this.menuAbout.Text = "About";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // menuClearCustomers
            // 
            this.menuClearCustomers.Name = "menuClearCustomers";
            this.menuClearCustomers.Size = new System.Drawing.Size(106, 20);
            this.menuClearCustomers.Text = "Clear Customers";
            this.menuClearCustomers.Click += new System.EventHandler(this.menuClearCustomers_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(37, 20);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(239, 303);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblErrorFName
            // 
            this.lblErrorFName.AutoSize = true;
            this.lblErrorFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFName.Location = new System.Drawing.Point(153, 66);
            this.lblErrorFName.Name = "lblErrorFName";
            this.lblErrorFName.Size = new System.Drawing.Size(15, 20);
            this.lblErrorFName.TabIndex = 16;
            this.lblErrorFName.Text = "*";
            this.lblErrorFName.Visible = false;
            // 
            // lblErrorLName
            // 
            this.lblErrorLName.AutoSize = true;
            this.lblErrorLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorLName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorLName.Location = new System.Drawing.Point(153, 96);
            this.lblErrorLName.Name = "lblErrorLName";
            this.lblErrorLName.Size = new System.Drawing.Size(15, 20);
            this.lblErrorLName.TabIndex = 17;
            this.lblErrorLName.Text = "*";
            this.lblErrorLName.Visible = false;
            // 
            // lblErrorStreet
            // 
            this.lblErrorStreet.AutoSize = true;
            this.lblErrorStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorStreet.ForeColor = System.Drawing.Color.Red;
            this.lblErrorStreet.Location = new System.Drawing.Point(153, 122);
            this.lblErrorStreet.Name = "lblErrorStreet";
            this.lblErrorStreet.Size = new System.Drawing.Size(15, 20);
            this.lblErrorStreet.TabIndex = 18;
            this.lblErrorStreet.Text = "*";
            this.lblErrorStreet.Visible = false;
            // 
            // lblErrorCity
            // 
            this.lblErrorCity.AutoSize = true;
            this.lblErrorCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCity.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCity.Location = new System.Drawing.Point(153, 150);
            this.lblErrorCity.Name = "lblErrorCity";
            this.lblErrorCity.Size = new System.Drawing.Size(15, 20);
            this.lblErrorCity.TabIndex = 19;
            this.lblErrorCity.Text = "*";
            this.lblErrorCity.Visible = false;
            // 
            // lblErrorState
            // 
            this.lblErrorState.AutoSize = true;
            this.lblErrorState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorState.ForeColor = System.Drawing.Color.Red;
            this.lblErrorState.Location = new System.Drawing.Point(153, 179);
            this.lblErrorState.Name = "lblErrorState";
            this.lblErrorState.Size = new System.Drawing.Size(15, 20);
            this.lblErrorState.TabIndex = 20;
            this.lblErrorState.Text = "*";
            this.lblErrorState.Visible = false;
            // 
            // lblErrorZip
            // 
            this.lblErrorZip.AutoSize = true;
            this.lblErrorZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorZip.ForeColor = System.Drawing.Color.Red;
            this.lblErrorZip.Location = new System.Drawing.Point(153, 206);
            this.lblErrorZip.Name = "lblErrorZip";
            this.lblErrorZip.Size = new System.Drawing.Size(15, 20);
            this.lblErrorZip.TabIndex = 21;
            this.lblErrorZip.Text = "*";
            this.lblErrorZip.Visible = false;
            // 
            // lblErrorPhone
            // 
            this.lblErrorPhone.AutoSize = true;
            this.lblErrorPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPhone.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPhone.Location = new System.Drawing.Point(153, 234);
            this.lblErrorPhone.Name = "lblErrorPhone";
            this.lblErrorPhone.Size = new System.Drawing.Size(15, 20);
            this.lblErrorPhone.TabIndex = 22;
            this.lblErrorPhone.Text = "*";
            this.lblErrorPhone.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(157, 303);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmCustomerEntry
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 366);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblErrorPhone);
            this.Controls.Add(this.lblErrorZip);
            this.Controls.Add(this.lblErrorState);
            this.Controls.Add(this.lblErrorCity);
            this.Controls.Add(this.lblErrorStreet);
            this.Controls.Add(this.lblErrorLName);
            this.Controls.Add(this.lblErrorFName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DDState);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.LblPhone);
            this.Controls.Add(this.LblZip);
            this.Controls.Add(this.LblState);
            this.Controls.Add(this.LblCity);
            this.Controls.Add(this.LblStreet);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblFirstName);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmCustomerEntry";
            this.Text = "Enter Customer";
            this.Load += new System.EventHandler(this.FrmCustomerEntry_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblStreet;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.Label LblState;
        private System.Windows.Forms.Label LblZip;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox DDState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuDisplayCustomers;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripMenuItem menuClearCustomers;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblErrorPhone;
        private System.Windows.Forms.Label lblErrorZip;
        private System.Windows.Forms.Label lblErrorState;
        private System.Windows.Forms.Label lblErrorCity;
        private System.Windows.Forms.Label lblErrorStreet;
        private System.Windows.Forms.Label lblErrorLName;
        private System.Windows.Forms.Label lblErrorFName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
    }
}

