namespace EmployeeApp
{
    partial class Entry
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
            this.reportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.phoneReceiveTextBox = new System.Windows.Forms.TextBox();
            this.phoneDialTextBox = new System.Windows.Forms.TextBox();
            this.smsReceiveTextBox = new System.Windows.Forms.TextBox();
            this.smsSentTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.recordDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(277, 41);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(75, 23);
            this.reportButton.TabIndex = 0;
            this.reportButton.Text = "View Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Record Entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Receive";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "SMS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Receive";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sent";
            // 
            // phoneReceiveTextBox
            // 
            this.phoneReceiveTextBox.Location = new System.Drawing.Point(167, 122);
            this.phoneReceiveTextBox.Name = "phoneReceiveTextBox";
            this.phoneReceiveTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneReceiveTextBox.TabIndex = 8;
            // 
            // phoneDialTextBox
            // 
            this.phoneDialTextBox.Location = new System.Drawing.Point(166, 156);
            this.phoneDialTextBox.Name = "phoneDialTextBox";
            this.phoneDialTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneDialTextBox.TabIndex = 9;
            // 
            // smsReceiveTextBox
            // 
            this.smsReceiveTextBox.Location = new System.Drawing.Point(167, 195);
            this.smsReceiveTextBox.Name = "smsReceiveTextBox";
            this.smsReceiveTextBox.Size = new System.Drawing.Size(100, 20);
            this.smsReceiveTextBox.TabIndex = 10;
            // 
            // smsSentTextBox
            // 
            this.smsSentTextBox.Location = new System.Drawing.Point(167, 233);
            this.smsSentTextBox.Name = "smsSentTextBox";
            this.smsSentTextBox.Size = new System.Drawing.Size(100, 20);
            this.smsSentTextBox.TabIndex = 11;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(191, 304);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // recordDatePicker
            // 
            this.recordDatePicker.CustomFormat = "dd/MM/yyyy";
            this.recordDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.recordDatePicker.Location = new System.Drawing.Point(166, 278);
            this.recordDatePicker.Name = "recordDatePicker";
            this.recordDatePicker.Size = new System.Drawing.Size(101, 20);
            this.recordDatePicker.TabIndex = 13;
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 386);
            this.Controls.Add(this.recordDatePicker);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.smsSentTextBox);
            this.Controls.Add(this.smsReceiveTextBox);
            this.Controls.Add(this.phoneDialTextBox);
            this.Controls.Add(this.phoneReceiveTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportButton);
            this.Name = "Entry";
            this.Text = "Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phoneReceiveTextBox;
        private System.Windows.Forms.TextBox phoneDialTextBox;
        private System.Windows.Forms.TextBox smsReceiveTextBox;
        private System.Windows.Forms.TextBox smsSentTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DateTimePicker recordDatePicker;
    }
}