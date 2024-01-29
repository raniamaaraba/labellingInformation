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

namespace labellingInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void CityRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stateRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void printPreviewControl1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.PrintAction = 
                System.Drawing.Printing.PrintAction.PrintToPreview;
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstRichTextBox.Clear();
            lastRichTextBox.Clear();
            addressRichTextBox.Clear();
            stateRichTextBox.Clear();   
            zipMaskedTextBox.Clear();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            nameLabel.Text = firstRichTextBox.Text + lastRichTextBox.Text;
            addressLabel.Text = addressRichTextBox.Text;
            cityLabel.Text = CityRichTextBox.Text + stateRichTextBox.Text +  zipMaskedTextBox.Text;
        }

        private void zipMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void addressRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}