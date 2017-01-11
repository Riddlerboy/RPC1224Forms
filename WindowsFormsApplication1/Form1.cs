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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int radioButtonSelected = radioButtonCheck();
            if(radioButtonSelected!=-1)
            {
                Form Nameform = new Form3(radioButtonSelected);
                Nameform.Show();
                this.Hide();
            } else
            {
                ErrorLabel.Text = "Please pick an option";
            }

        }

        private int radioButtonCheck()
        {
            if (NewAccountButton.Checked)
            {
                return 0;
            } else if(ModificationButton.Checked)
            {
                return 1;
            } else if(TransferButton.Checked)
            {
                return 2;
            } else
            {
                return -1;
            }
        }
    }
}
