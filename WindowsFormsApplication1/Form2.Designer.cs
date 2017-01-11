namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.DriveAccessLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DriveAccess1 = new System.Windows.Forms.Panel();
            this.DriveAccess1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DriveAccessLabel
            // 
            this.DriveAccessLabel.AutoSize = true;
            this.DriveAccessLabel.Location = new System.Drawing.Point(13, 13);
            this.DriveAccessLabel.Name = "DriveAccessLabel";
            this.DriveAccessLabel.Size = new System.Drawing.Size(70, 13);
            this.DriveAccessLabel.TabIndex = 0;
            this.DriveAccessLabel.Text = "Drive Access";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "W:\\",
            "Y:\\"});
            this.comboBox1.Location = new System.Drawing.Point(4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(36, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(204, 0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DriveAccess1
            // 
            this.DriveAccess1.Controls.Add(this.AddButton);
            this.DriveAccess1.Controls.Add(this.textBox1);
            this.DriveAccess1.Controls.Add(this.comboBox1);
            this.DriveAccess1.Location = new System.Drawing.Point(8, 40);
            this.DriveAccess1.Name = "DriveAccess1";
            this.DriveAccess1.Size = new System.Drawing.Size(281, 25);
            this.DriveAccess1.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 280);
            this.Controls.Add(this.DriveAccess1);
            this.Controls.Add(this.DriveAccessLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.DriveAccess1.ResumeLayout(false);
            this.DriveAccess1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DriveAccessLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel DriveAccess1;
    }
}