using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        //First Text Box
        String LastName;
        //Second Text Box
        String FirstName;
        //Third Text Box
        String MiddleInitial;
        //0=New 1=Modification 2=Transfer
        int AccountType;



        /// <summary>
        /// Sets account type to what was previously submitted last page
        /// </summary>
        /// <param name="AccountType">Type of Account(new, modification,transfer)</param>
        public Form3(int AccountType)
        {
            InitializeComponent();
            EmploymentStatusCombo.SelectedIndex = 0;
            this.AccountType = AccountType;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Keeps track of status of combo box, enabling datechooser when not indeterminate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmploymentStatusCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EmploymentStatusCombo.SelectedIndex == 0)
            {
                TermDate.Enabled = false;
            }
            if (EmploymentStatusCombo.SelectedIndex == 1)
            {
                TermDate.Enabled = true;
            }
        }
        /// <summary>
        /// Goes back to the previous page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            
            
        }
        /// <summary>
        /// sets variables for names entered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if(checkForValidNames())
            {
                LastName = LastNameTextBox.Text;
                FirstName = FirstNameTextBox.Text;
                MiddleInitial = MiddleInitialTextBox.Text;
            }

        }
        /// <summary>
        /// Checks for valid names (not null)
        /// </summary>
        /// <returns>True if valid names, false if invalid</returns>
        private bool checkForValidNames()
        {
            ErrorLabel.Text = " ";
            Console.WriteLine(LastNameTextBox.Text);
            if(!String.IsNullOrWhiteSpace(LastNameTextBox.Text))
            {
                ErrorLabel.Text = "Please enter Last name";
                return false;
            }
            if (!String.IsNullOrWhiteSpace(FirstNameTextBox.Text))
            {
                ErrorLabel.Text = "Please enter First name";
                return false;
            }
            for (int i = 0; i < 10; i++)
            {
                if (LastNameTextBox.Text.Contains(i.ToString()))
                {
                    ErrorLabel.Text = "Last Name cannot contain numbers!";
                    return false;
                }
                if (FirstNameTextBox.Text.Contains(i.ToString()))
                {
                    ErrorLabel.Text = "First Name cannot contain numbers!";
                    return false;
                }
                if (MiddleInitialTextBox.Text.Contains(i.ToString()))
                {
                    ErrorLabel.Text = "Middle Name cannot contain numbers!";
                    return false;
                }
            }
            return true;
        } 
    }
}
