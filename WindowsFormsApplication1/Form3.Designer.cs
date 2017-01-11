namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.Label();
            this.MiddleInitialTextBox = new System.Windows.Forms.Label();
            this.TermDate = new System.Windows.Forms.DateTimePicker();
            this.EmploymentStatusCombo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EmploymetStatusLabel = new System.Windows.Forms.Label();
            this.TermDateLabel = new System.Windows.Forms.Label();
            this.ExtensionNumberLabel = new System.Windows.Forms.Label();
            this.ExtensionNumberTextBox = new System.Windows.Forms.TextBox();
            this.JobTitleLabel = new System.Windows.Forms.Label();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.JobTitleTextBox = new System.Windows.Forms.TextBox();
            this.DepartmentTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(111, 0);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 0;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(1, 0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(293, 18);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.AutoSize = true;
            this.LastNameTextBox.Location = new System.Drawing.Point(19, 0);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(61, 13);
            this.LastNameTextBox.TabIndex = 6;
            this.LastNameTextBox.Text = "Last Name:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.AutoSize = true;
            this.FirstNameTextBox.Location = new System.Drawing.Point(140, 0);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(60, 13);
            this.FirstNameTextBox.TabIndex = 7;
            this.FirstNameTextBox.Text = "First Name:";
            // 
            // MiddleInitialTextBox
            // 
            this.MiddleInitialTextBox.AutoSize = true;
            this.MiddleInitialTextBox.Location = new System.Drawing.Point(293, 0);
            this.MiddleInitialTextBox.Name = "MiddleInitialTextBox";
            this.MiddleInitialTextBox.Size = new System.Drawing.Size(68, 13);
            this.MiddleInitialTextBox.TabIndex = 8;
            this.MiddleInitialTextBox.Text = "Middle Initial:";
            // 
            // TermDate
            // 
            this.TermDate.Location = new System.Drawing.Point(143, 98);
            this.TermDate.Name = "TermDate";
            this.TermDate.Size = new System.Drawing.Size(148, 20);
            this.TermDate.TabIndex = 9;
            // 
            // EmploymentStatusCombo
            // 
            this.EmploymentStatusCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.EmploymentStatusCombo.FormattingEnabled = true;
            this.EmploymentStatusCombo.Items.AddRange(new object[] {
            "Indeterminate",
            "Term"});
            this.EmploymentStatusCombo.Location = new System.Drawing.Point(16, 98);
            this.EmploymentStatusCombo.Name = "EmploymentStatusCombo";
            this.EmploymentStatusCombo.Size = new System.Drawing.Size(121, 21);
            this.EmploymentStatusCombo.TabIndex = 10;
            this.EmploymentStatusCombo.SelectedIndexChanged += new System.EventHandler(this.EmploymentStatusCombo_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExtensionNumberTextBox);
            this.panel1.Controls.Add(this.ExtensionNumberLabel);
            this.panel1.Controls.Add(this.TermDateLabel);
            this.panel1.Controls.Add(this.EmploymetStatusLabel);
            this.panel1.Controls.Add(this.EmploymentStatusCombo);
            this.panel1.Controls.Add(this.TermDate);
            this.panel1.Controls.Add(this.MiddleInitialTextBox);
            this.panel1.Controls.Add(this.FirstNameTextBox);
            this.panel1.Controls.Add(this.LastNameTextBox);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 201);
            this.panel1.TabIndex = 11;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(163, 155);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BackButton);
            this.panel2.Controls.Add(this.NextButton);
            this.panel2.Location = new System.Drawing.Point(115, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 29);
            this.panel2.TabIndex = 13;
            // 
            // EmploymetStatusLabel
            // 
            this.EmploymetStatusLabel.AutoSize = true;
            this.EmploymetStatusLabel.Location = new System.Drawing.Point(13, 82);
            this.EmploymetStatusLabel.Name = "EmploymetStatusLabel";
            this.EmploymetStatusLabel.Size = new System.Drawing.Size(94, 13);
            this.EmploymetStatusLabel.TabIndex = 11;
            this.EmploymetStatusLabel.Text = "EmploymentStatus";
            // 
            // TermDateLabel
            // 
            this.TermDateLabel.AutoSize = true;
            this.TermDateLabel.Location = new System.Drawing.Point(143, 82);
            this.TermDateLabel.Name = "TermDateLabel";
            this.TermDateLabel.Size = new System.Drawing.Size(122, 13);
            this.TermDateLabel.TabIndex = 12;
            this.TermDateLabel.Text = "Account Expiration Date";
            // 
            // ExtensionNumberLabel
            // 
            this.ExtensionNumberLabel.AutoSize = true;
            this.ExtensionNumberLabel.Location = new System.Drawing.Point(293, 81);
            this.ExtensionNumberLabel.Name = "ExtensionNumberLabel";
            this.ExtensionNumberLabel.Size = new System.Drawing.Size(35, 13);
            this.ExtensionNumberLabel.TabIndex = 13;
            this.ExtensionNumberLabel.Text = "Ext #:";
            // 
            // ExtensionNumberTextBox
            // 
            this.ExtensionNumberTextBox.Location = new System.Drawing.Point(296, 98);
            this.ExtensionNumberTextBox.Name = "ExtensionNumberTextBox";
            this.ExtensionNumberTextBox.Size = new System.Drawing.Size(65, 20);
            this.ExtensionNumberTextBox.TabIndex = 14;
            // 
            // JobTitleLabel
            // 
            this.JobTitleLabel.AutoSize = true;
            this.JobTitleLabel.Location = new System.Drawing.Point(36, 167);
            this.JobTitleLabel.Name = "JobTitleLabel";
            this.JobTitleLabel.Size = new System.Drawing.Size(50, 13);
            this.JobTitleLabel.TabIndex = 14;
            this.JobTitleLabel.Text = "Job Title:";
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Location = new System.Drawing.Point(152, 167);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(65, 13);
            this.DepartmentLabel.TabIndex = 15;
            this.DepartmentLabel.Text = "Department:";
            // 
            // JobTitleTextBox
            // 
            this.JobTitleTextBox.Location = new System.Drawing.Point(39, 184);
            this.JobTitleTextBox.Name = "JobTitleTextBox";
            this.JobTitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.JobTitleTextBox.TabIndex = 16;
            // 
            // DepartmentTextBox
            // 
            this.DepartmentTextBox.Location = new System.Drawing.Point(155, 183);
            this.DepartmentTextBox.Name = "DepartmentTextBox";
            this.DepartmentTextBox.Size = new System.Drawing.Size(100, 20);
            this.DepartmentTextBox.TabIndex = 17;
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(416, 300);
            this.Controls.Add(this.DepartmentTextBox);
            this.Controls.Add(this.JobTitleTextBox);
            this.Controls.Add(this.DepartmentLabel);
            this.Controls.Add(this.JobTitleLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label LastNameTextBox;
        private System.Windows.Forms.Label FirstNameTextBox;
        private System.Windows.Forms.Label MiddleInitialTextBox;
        private System.Windows.Forms.DateTimePicker TermDate;
        private System.Windows.Forms.ComboBox EmploymentStatusCombo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TextBox ExtensionNumberTextBox;
        private System.Windows.Forms.Label ExtensionNumberLabel;
        private System.Windows.Forms.Label TermDateLabel;
        private System.Windows.Forms.Label EmploymetStatusLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label JobTitleLabel;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.TextBox JobTitleTextBox;
        private System.Windows.Forms.TextBox DepartmentTextBox;
    }
}