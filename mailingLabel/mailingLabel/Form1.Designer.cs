namespace mailingLabel
{
    partial class Form1
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.displayButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.printForm1 = new System.Drawing.Printing.PrintDocument();
            this.lastRichTextBox = new System.Windows.Forms.RichTextBox();
            this.addressRichTextBox = new System.Windows.Forms.RichTextBox();
            this.cityRichTextBox = new System.Windows.Forms.RichTextBox();
            this.zipRichTextBox = new System.Windows.Forms.RichTextBox();
            this.firstRichTextBox = new System.Windows.Forms.RichTextBox();
            this.stateRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(40, 70);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 15);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(40, 126);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(77, 15);
            this.addressLabel.TabIndex = 1;
            this.addressLabel.Text = "Address Line:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(40, 188);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(31, 15);
            this.cityLabel.TabIndex = 2;
            this.cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(289, 188);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(36, 15);
            this.stateLabel.TabIndex = 3;
            this.stateLabel.Text = "State:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(528, 188);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(58, 15);
            this.zipLabel.TabIndex = 4;
            this.zipLabel.Text = "ZIP Code:";
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(40, 246);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(94, 47);
            this.displayButton.TabIndex = 10;
            this.displayButton.Text = "Display Label Info";
            this.displayButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(40, 299);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(94, 47);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(40, 352);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(94, 47);
            this.printButton.TabIndex = 12;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(40, 405);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 47);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Location = new System.Drawing.Point(375, 246);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(374, 206);
            this.printPreviewControl1.TabIndex = 14;
            this.printPreviewControl1.Click += new System.EventHandler(this.printPreviewControl1_Click);
            // 
            // printForm1
            // 
            this.printForm1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printForm1_PrintPage);
            // 
            // lastRichTextBox
            // 
            this.lastRichTextBox.Location = new System.Drawing.Point(237, 67);
            this.lastRichTextBox.Name = "lastRichTextBox";
            this.lastRichTextBox.Size = new System.Drawing.Size(143, 29);
            this.lastRichTextBox.TabIndex = 17;
            this.lastRichTextBox.Text = "";
            this.lastRichTextBox.TextChanged += new System.EventHandler(this.lastRichTextBox_TextChanged);
            // 
            // addressRichTextBox
            // 
            this.addressRichTextBox.Location = new System.Drawing.Point(123, 123);
            this.addressRichTextBox.Name = "addressRichTextBox";
            this.addressRichTextBox.Size = new System.Drawing.Size(269, 29);
            this.addressRichTextBox.TabIndex = 18;
            this.addressRichTextBox.Text = "";
            // 
            // cityRichTextBox
            // 
            this.cityRichTextBox.Location = new System.Drawing.Point(77, 185);
            this.cityRichTextBox.Name = "cityRichTextBox";
            this.cityRichTextBox.Size = new System.Drawing.Size(143, 29);
            this.cityRichTextBox.TabIndex = 19;
            this.cityRichTextBox.Text = "";
            this.cityRichTextBox.TextChanged += new System.EventHandler(this.cityRichTextBox_TextChanged);
            // 
            // zipRichTextBox
            // 
            this.zipRichTextBox.Location = new System.Drawing.Point(592, 185);
            this.zipRichTextBox.Name = "zipRichTextBox";
            this.zipRichTextBox.Size = new System.Drawing.Size(143, 29);
            this.zipRichTextBox.TabIndex = 21;
            this.zipRichTextBox.Text = "";
            this.zipRichTextBox.TextChanged += new System.EventHandler(this.zipRichTextBox_TextChanged);
            // 
            // firstRichTextBox
            // 
            this.firstRichTextBox.Location = new System.Drawing.Point(88, 67);
            this.firstRichTextBox.Name = "firstRichTextBox";
            this.firstRichTextBox.Size = new System.Drawing.Size(143, 29);
            this.firstRichTextBox.TabIndex = 22;
            this.firstRichTextBox.Text = "";
            this.firstRichTextBox.TextChanged += new System.EventHandler(this.firstRichTextBox_TextChanged);
            // 
            // stateRichTextBox
            // 
            this.stateRichTextBox.Location = new System.Drawing.Point(331, 185);
            this.stateRichTextBox.Name = "stateRichTextBox";
            this.stateRichTextBox.Size = new System.Drawing.Size(143, 29);
            this.stateRichTextBox.TabIndex = 23;
            this.stateRichTextBox.Text = "";
            this.stateRichTextBox.TextChanged += new System.EventHandler(this.stateRichTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.stateRichTextBox);
            this.Controls.Add(this.firstRichTextBox);
            this.Controls.Add(this.zipRichTextBox);
            this.Controls.Add(this.cityRichTextBox);
            this.Controls.Add(this.addressRichTextBox);
            this.Controls.Add(this.lastRichTextBox);
            this.Controls.Add(this.printPreviewControl1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nameLabel;
        private Label addressLabel;
        private Label cityLabel;
        private Label stateLabel;
        private Label zipLabel;
        private Button displayButton;
        private Button clearButton;
        private Button printButton;
        private Button exitButton;
        private PrintPreviewControl printPreviewControl1;
        private System.Drawing.Printing.PrintDocument printForm1;
        private RichTextBox lastRichTextBox;
        private RichTextBox addressRichTextBox;
        private RichTextBox cityRichTextBox;
        private RichTextBox zipRichTextBox;
        private RichTextBox firstRichTextBox;
        private RichTextBox stateRichTextBox;
    }
}