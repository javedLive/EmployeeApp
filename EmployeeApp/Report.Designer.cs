namespace EmployeeApp
{
    partial class Report
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
            this.reportDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.reportGridView = new System.Windows.Forms.DataGridView();
            this.generateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // reportDatePicker
            // 
            this.reportDatePicker.CustomFormat = "dd/MM/yyyy";
            this.reportDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reportDatePicker.Location = new System.Drawing.Point(131, 49);
            this.reportDatePicker.Name = "reportDatePicker";
            this.reportDatePicker.Size = new System.Drawing.Size(126, 20);
            this.reportDatePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Generate Report";
            // 
            // reportGridView
            // 
            this.reportGridView.BackgroundColor = System.Drawing.Color.White;
            this.reportGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.reportGridView.Location = new System.Drawing.Point(31, 147);
            this.reportGridView.Name = "reportGridView";
            this.reportGridView.Size = new System.Drawing.Size(226, 150);
            this.reportGridView.TabIndex = 2;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(182, 93);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Report";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 323);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.reportGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportDatePicker);
            this.Name = "Report";
            this.Text = "Report";
            this.TransparencyKey = System.Drawing.Color.Black;
            ((System.ComponentModel.ISupportInitialize)(this.reportGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker reportDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView reportGridView;
        private System.Windows.Forms.Button generateButton;
    }
}