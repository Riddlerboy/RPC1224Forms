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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(228, 171);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 0;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(118, 171);
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
            this.panel1.Size = new System.Drawing.Size(406, 124);
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
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(416, 206);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Name = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}