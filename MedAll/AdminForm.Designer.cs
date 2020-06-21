namespace MedAll
{
    partial class AdminForm
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
            this.addAppointmentButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.patientComboBox = new System.Windows.Forms.ComboBox();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.roomComboBox = new System.Windows.Forms.ComboBox();
            this.appointmentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.patientLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.roomLabel = new System.Windows.Forms.Label();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.saveAppointmentButton = new System.Windows.Forms.Button();
            this.scheduleTextBox = new System.Windows.Forms.TextBox();
            this.scheduleLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addAppointmentButton
            // 
            this.addAppointmentButton.Location = new System.Drawing.Point(46, 46);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(199, 51);
            this.addAppointmentButton.TabIndex = 0;
            this.addAppointmentButton.Text = "Add appointment";
            this.addAppointmentButton.UseVisualStyleBackColor = true;
            this.addAppointmentButton.Click += new System.EventHandler(this.addAppointmentButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(46, 311);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(199, 51);
            this.addUserButton.TabIndex = 1;
            this.addUserButton.Text = "Add user";
            this.addUserButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(46, 392);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(199, 51);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search ";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // patientComboBox
            // 
            this.patientComboBox.FormattingEnabled = true;
            this.patientComboBox.Location = new System.Drawing.Point(385, 60);
            this.patientComboBox.Name = "patientComboBox";
            this.patientComboBox.Size = new System.Drawing.Size(169, 24);
            this.patientComboBox.TabIndex = 3;
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(385, 103);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(169, 24);
            this.doctorComboBox.TabIndex = 4;
            this.doctorComboBox.SelectedIndexChanged += new System.EventHandler(this.doctorComboBox_SelectedIndexChanged);
            // 
            // roomComboBox
            // 
            this.roomComboBox.FormattingEnabled = true;
            this.roomComboBox.Location = new System.Drawing.Point(385, 148);
            this.roomComboBox.Name = "roomComboBox";
            this.roomComboBox.Size = new System.Drawing.Size(169, 24);
            this.roomComboBox.TabIndex = 5;
            this.roomComboBox.SelectedIndexChanged += new System.EventHandler(this.roomComboBox_SelectedIndexChanged);
            // 
            // appointmentDatePicker
            // 
            this.appointmentDatePicker.Location = new System.Drawing.Point(385, 193);
            this.appointmentDatePicker.Name = "appointmentDatePicker";
            this.appointmentDatePicker.Size = new System.Drawing.Size(169, 22);
            this.appointmentDatePicker.TabIndex = 6;
            // 
            // patientLabel
            // 
            this.patientLabel.AutoSize = true;
            this.patientLabel.Location = new System.Drawing.Point(318, 60);
            this.patientLabel.Name = "patientLabel";
            this.patientLabel.Size = new System.Drawing.Size(52, 17);
            this.patientLabel.TabIndex = 7;
            this.patientLabel.Text = "Patient";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(319, 193);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(38, 17);
            this.dateLabel.TabIndex = 8;
            this.dateLabel.Text = "Date";
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Location = new System.Drawing.Point(318, 148);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(45, 17);
            this.roomLabel.TabIndex = 9;
            this.roomLabel.Text = "Room";
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Location = new System.Drawing.Point(318, 103);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(50, 17);
            this.doctorLabel.TabIndex = 10;
            this.doctorLabel.Text = "Doctor";
            // 
            // saveAppointmentButton
            // 
            this.saveAppointmentButton.Location = new System.Drawing.Point(456, 283);
            this.saveAppointmentButton.Name = "saveAppointmentButton";
            this.saveAppointmentButton.Size = new System.Drawing.Size(98, 26);
            this.saveAppointmentButton.TabIndex = 11;
            this.saveAppointmentButton.Text = "Save";
            this.saveAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // scheduleTextBox
            // 
            this.scheduleTextBox.Location = new System.Drawing.Point(385, 237);
            this.scheduleTextBox.Name = "scheduleTextBox";
            this.scheduleTextBox.Size = new System.Drawing.Size(169, 22);
            this.scheduleTextBox.TabIndex = 12;
            this.scheduleTextBox.TextChanged += new System.EventHandler(this.scheduleTextBox_TextChanged);
            // 
            // scheduleLabel
            // 
            this.scheduleLabel.AutoSize = true;
            this.scheduleLabel.Location = new System.Drawing.Point(316, 236);
            this.scheduleLabel.Name = "scheduleLabel";
            this.scheduleLabel.Size = new System.Drawing.Size(67, 17);
            this.scheduleLabel.TabIndex = 13;
            this.scheduleLabel.Text = "Schedule";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 51);
            this.button1.TabIndex = 14;
            this.button1.Text = "Back to main menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(975, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scheduleLabel);
            this.Controls.Add(this.scheduleTextBox);
            this.Controls.Add(this.saveAppointmentButton);
            this.Controls.Add(this.doctorLabel);
            this.Controls.Add(this.roomLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.patientLabel);
            this.Controls.Add(this.appointmentDatePicker);
            this.Controls.Add(this.roomComboBox);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.patientComboBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.addAppointmentButton);
            this.Name = "AdminForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addAppointmentButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox patientComboBox;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.ComboBox roomComboBox;
        private System.Windows.Forms.DateTimePicker appointmentDatePicker;
        private System.Windows.Forms.Label patientLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.Label doctorLabel;
        private System.Windows.Forms.Button saveAppointmentButton;
        private System.Windows.Forms.TextBox scheduleTextBox;
        private System.Windows.Forms.Label scheduleLabel;
        private System.Windows.Forms.Button button1;
    }
}