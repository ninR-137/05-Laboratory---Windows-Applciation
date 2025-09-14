namespace StudentRegistrationApplication
{
    partial class frmStudentInfo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lastName = new TextBox();
            firstName = new TextBox();
            firstNameLabel = new Label();
            middleName = new TextBox();
            middleNameLabel = new Label();
            label4 = new Label();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            browse = new Button();
            RegisterButton = new Button();
            label2 = new Label();
            male_radio = new RadioButton();
            female_radio = new RadioButton();
            label5 = new Label();
            Date = new ComboBox();
            Month = new ComboBox();
            Year = new ComboBox();
            label3 = new Label();
            Programs = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Last Name *";
            // 
            // lastName
            // 
            lastName.Location = new Point(12, 87);
            lastName.Name = "lastName";
            lastName.Size = new Size(323, 23);
            lastName.TabIndex = 1;
            // 
            // firstName
            // 
            firstName.Location = new Point(12, 144);
            firstName.Name = "firstName";
            firstName.Size = new Size(323, 23);
            firstName.TabIndex = 3;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            firstNameLabel.Location = new Point(12, 126);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(75, 15);
            firstNameLabel.TabIndex = 2;
            firstNameLabel.Text = "First Name *";
            // 
            // middleName
            // 
            middleName.Location = new Point(12, 199);
            middleName.Name = "middleName";
            middleName.Size = new Size(323, 23);
            middleName.TabIndex = 5;
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            middleNameLabel.Location = new Point(12, 181);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new Size(89, 15);
            middleNameLabel.TabIndex = 4;
            middleNameLabel.Text = "Middle Name *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(406, 45);
            label4.TabIndex = 6;
            label4.Text = "Student Application Form";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Location = new Point(417, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 169);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // browse
            // 
            browse.Location = new Point(471, 255);
            browse.Name = "browse";
            browse.Size = new Size(75, 23);
            browse.TabIndex = 8;
            browse.Text = "Browse";
            browse.UseVisualStyleBackColor = true;
            browse.Click += browse_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.IndianRed;
            RegisterButton.ForeColor = SystemColors.ButtonFace;
            RegisterButton.Location = new Point(12, 408);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(207, 32);
            RegisterButton.TabIndex = 9;
            RegisterButton.Text = "Register Student";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 235);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 10;
            label2.Text = "Gender *";
            // 
            // male_radio
            // 
            male_radio.AutoSize = true;
            male_radio.Location = new Point(94, 235);
            male_radio.Name = "male_radio";
            male_radio.Size = new Size(51, 19);
            male_radio.TabIndex = 11;
            male_radio.TabStop = true;
            male_radio.Text = "Male";
            male_radio.UseVisualStyleBackColor = true;
            // 
            // female_radio
            // 
            female_radio.AutoSize = true;
            female_radio.Location = new Point(180, 235);
            female_radio.Name = "female_radio";
            female_radio.Size = new Size(63, 19);
            female_radio.TabIndex = 12;
            female_radio.TabStop = true;
            female_radio.Text = "Female";
            female_radio.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(12, 263);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 14;
            label5.Text = "Date Of Birth";
            // 
            // Date
            // 
            Date.FormattingEnabled = true;
            Date.Location = new Point(12, 290);
            Date.Name = "Date";
            Date.Size = new Size(57, 23);
            Date.TabIndex = 15;
            Date.Text = "Date";
            // 
            // Month
            // 
            Month.FormattingEnabled = true;
            Month.Location = new Point(94, 290);
            Month.Name = "Month";
            Month.Size = new Size(112, 23);
            Month.TabIndex = 16;
            Month.Text = "Month";
            // 
            // Year
            // 
            Year.FormattingEnabled = true;
            Year.Location = new Point(223, 290);
            Year.Name = "Year";
            Year.Size = new Size(112, 23);
            Year.TabIndex = 17;
            Year.Text = "Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(12, 325);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 18;
            label3.Text = "Program To Apply";
            // 
            // Programs
            // 
            Programs.FormattingEnabled = true;
            Programs.Location = new Point(12, 352);
            Programs.Name = "Programs";
            Programs.Size = new Size(323, 23);
            Programs.TabIndex = 19;
            Programs.Text = "Select Program";
            // 
            // frmStudentInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 452);
            Controls.Add(Programs);
            Controls.Add(label3);
            Controls.Add(Year);
            Controls.Add(Month);
            Controls.Add(Date);
            Controls.Add(label5);
            Controls.Add(female_radio);
            Controls.Add(male_radio);
            Controls.Add(label2);
            Controls.Add(RegisterButton);
            Controls.Add(browse);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(middleName);
            Controls.Add(middleNameLabel);
            Controls.Add(firstName);
            Controls.Add(firstNameLabel);
            Controls.Add(lastName);
            Controls.Add(label1);
            Name = "frmStudentInfo";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox lastName;
        private TextBox firstName;
        private Label firstNameLabel;
        private TextBox middleName;
        private Label middleNameLabel;
        private Label label4;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button browse;
        private Button RegisterButton;
        private Label label2;
        private RadioButton male_radio;
        private RadioButton female_radio;
        private Label label5;
        private ComboBox Date;
        private ComboBox Month;
        private ComboBox Year;
        private Label label3;
        private ComboBox Programs;
    }
}
