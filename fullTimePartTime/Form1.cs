using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fullTimePartTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhatStatus_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtCredits.Text, out double credits)) //inline variable creation
            {
                
                if (credits > 12) //if credits entered are more than 12 assign the lblStatus.Text to full time
                {
                    lblStatus.Text = "full time";
                }
                else if (credits >= 6) //or if credits entered are equal to or greater than 6 then assign the lblStatus.Text to half time
                {
                    lblStatus.Text = "Half time";
                }
                else if (credits >= 0) //or if credits entered are greater than or equal to 0 or greater then assign the lblStatus.Text to less than half time
                {
                    lblStatus.Text = "Less than half time";
                }
                else //anything else then display the MessageBox with the error below
                {
                    MessageBox.Show("Enter a positive number", "Error");
                }
            }
            else //if above can not be executed because something else is entered then a MessageBox showing the error below will appear
            {
                MessageBox.Show("Enter a number", "Error");
            }
        }
    }
}
