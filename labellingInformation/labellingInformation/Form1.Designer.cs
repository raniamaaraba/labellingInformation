namespace labellingInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nameLabel = new System.Windows.Forms.Label();
            this.firstRichTextBox = new System.Windows.Forms.RichTextBox();
            this.lastRichTextBox = new System.Windows.Forms.RichTextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressRichTextBox = new System.Windows.Forms.RichTextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.CityRichTextBox = new System.Windows.Forms.RichTextBox();
            this.stateRichTextBox = new System.Windows.Forms.RichTextBox();
            this.printButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.clearButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.zipMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(21, 51);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 15);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // firstRichTextBox
            // 
            this.firstRichTextBox.Location = new System.Drawing.Point(69, 48);
            this.firstRichTextBox.Name = "firstRichTextBox";
            this.firstRichTextBox.Size = new System.Drawing.Size(124, 24);
            this.firstRichTextBox.TabIndex = 1;
            this.firstRichTextBox.Text = "";
            this.firstRichTextBox.TextChanged += new System.EventHandler(this.firstRichTextBox_TextChanged);
            // 
            // lastRichTextBox
            // 
            this.lastRichTextBox.Location = new System.Drawing.Point(199, 48);
            this.lastRichTextBox.Name = "lastRichTextBox";
            this.lastRichTextBox.Size = new System.Drawing.Size(124, 24);
            this.lastRichTextBox.TabIndex = 2;
            this.lastRichTextBox.Text = "";
            this.lastRichTextBox.TextChanged += new System.EventHandler(this.lastRichTextBox_TextChanged);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(21, 94);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(77, 15);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Address Line:";
            this.addressLabel.Click += new System.EventHandler(this.addressLabel_Click);
            // 
            // addressRichTextBox
            // 
            this.addressRichTextBox.Location = new System.Drawing.Point(104, 91);
            this.addressRichTextBox.Name = "addressRichTextBox";
            this.addressRichTextBox.Size = new System.Drawing.Size(254, 24);
            this.addressRichTextBox.TabIndex = 4;
            this.addressRichTextBox.Text = "";
            this.addressRichTextBox.TextChanged += new System.EventHandler(this.addressRichTextBox_TextChanged);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(21, 137);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(31, 15);
            this.cityLabel.TabIndex = 5;
            this.cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(199, 137);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(36, 15);
            this.stateLabel.TabIndex = 6;
            this.stateLabel.Text = "State:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(382, 137);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(58, 15);
            this.zipLabel.TabIndex = 7;
            this.zipLabel.Text = "ZIP Code:";
            // 
            // CityRichTextBox
            // 
            this.CityRichTextBox.Location = new System.Drawing.Point(58, 134);
            this.CityRichTextBox.Name = "CityRichTextBox";
            this.CityRichTextBox.Size = new System.Drawing.Size(122, 24);
            this.CityRichTextBox.TabIndex = 8;
            this.CityRichTextBox.Text = "";
            this.CityRichTextBox.TextChanged += new System.EventHandler(this.CityRichTextBox_TextChanged);
            // 
            // stateRichTextBox
            // 
            this.stateRichTextBox.Location = new System.Drawing.Point(241, 134);
            this.stateRichTextBox.Name = "stateRichTextBox";
            this.stateRichTextBox.Size = new System.Drawing.Size(122, 24);
            this.stateRichTextBox.TabIndex = 9;
            this.stateRichTextBox.Text = "";
            this.stateRichTextBox.TextChanged += new System.EventHandler(this.stateRichTextBox_TextChanged);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(23, 317);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(97, 49);
            this.printButton.TabIndex = 11;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(23, 372);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(95, 49);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(642, 317);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(97, 49);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(642, 372);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(97, 49);
            this.displayButton.TabIndex = 15;
            this.displayButton.Text = "Display Label Info";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // zipMaskedTextBox
            // 
            this.zipMaskedTextBox.Location = new System.Drawing.Point(446, 135);
            this.zipMaskedTextBox.Name = "zipMaskedTextBox";
            this.zipMaskedTextBox.Size = new System.Drawing.Size(117, 23);
            this.zipMaskedTextBox.TabIndex = 16;
            this.zipMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.zipMaskedTextBox_MaskInputRejected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zipMaskedTextBox);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.stateRichTextBox);
            this.Controls.Add(this.CityRichTextBox);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressRichTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.lastRichTextBox);
            this.Controls.Add(this.firstRichTextBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nameLabel;
        private RichTextBox firstRichTextBox;
        private RichTextBox lastRichTextBox;
        private Label addressLabel;
        private RichTextBox addressRichTextBox;
        private Label cityLabel;
        private Label stateLabel;
        private Label zipLabel;
        private RichTextBox CityRichTextBox;
        private RichTextBox stateRichTextBox;
        private Button printButton;
        private Button exitButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button clearButton;
        private Button displayButton;
        private PrintPreviewDialog printPreviewDialog1;
        private MaskedTextBox zipMaskedTextBox;
    }
}