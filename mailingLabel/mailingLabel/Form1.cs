/* Project: Billing Address
 * Programmer: Rania Maaraba
 * Date: September 2022
 * Description: create a [roject based on user input that allows First name, Last name, Street Address, City, State, and ZIP code.
 * Display the information, allow a for a clear, print, and exit button 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mailingLabel
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            /*printForm1.PrintAction =
                System.Drawing.Printing.PrintAction.PrintToPreview;
            */
            printForm1.Print();
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }



        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void printForm1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            nameLabel.Text = firstRichTextBox.Text + lastRichTextBox.Text;
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void lastRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cityRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }



        private void zipRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stateRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}