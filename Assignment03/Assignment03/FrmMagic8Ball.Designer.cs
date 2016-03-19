namespace Assignment03
{
    partial class FrmMagic8Ball
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
            this.LblMessage = new System.Windows.Forms.Label();
            this.TBAnswer = new System.Windows.Forms.TextBox();
            this.BtnGetAnswer = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.Location = new System.Drawing.Point(170, 44);
            this.LblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(142, 19);
            this.LblMessage.TabIndex = 0;
            this.LblMessage.Text = "Your Answer is:";
            this.LblMessage.Click += new System.EventHandler(this.LblMessage_Click);
            // 
            // TBAnswer
            // 
            this.TBAnswer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TBAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBAnswer.Cursor = System.Windows.Forms.Cursors.Default;
            this.TBAnswer.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBAnswer.Location = new System.Drawing.Point(83, 121);
            this.TBAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBAnswer.Name = "TBAnswer";
            this.TBAnswer.ReadOnly = true;
            this.TBAnswer.Size = new System.Drawing.Size(307, 19);
            this.TBAnswer.TabIndex = 1;
            this.TBAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBAnswer.TextChanged += new System.EventHandler(this.TBAnswer_TextChanged);
            // 
            // BtnGetAnswer
            // 
            this.BtnGetAnswer.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnGetAnswer.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGetAnswer.Location = new System.Drawing.Point(174, 206);
            this.BtnGetAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnGetAnswer.Name = "BtnGetAnswer";
            this.BtnGetAnswer.Size = new System.Drawing.Size(124, 34);
            this.BtnGetAnswer.TabIndex = 2;
            this.BtnGetAnswer.Text = "Get Answer";
            this.BtnGetAnswer.UseVisualStyleBackColor = false;
            this.BtnGetAnswer.Click += new System.EventHandler(this.BtnGetAnswer_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnExit.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(174, 289);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(124, 34);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Close";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmMagic8Ball
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(473, 381);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnGetAnswer);
            this.Controls.Add(this.TBAnswer);
            this.Controls.Add(this.LblMessage);
            this.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMagic8Ball";
            this.Text = "Magic 8 Ball";
            this.Load += new System.EventHandler(this.FrmMagic8Ball_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.TextBox TBAnswer;
        private System.Windows.Forms.Button BtnGetAnswer;
        private System.Windows.Forms.Button BtnExit;
    }
}

