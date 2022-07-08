namespace Name_Formatter
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
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelPreferredTitle = new System.Windows.Forms.Label();
            this.labelInstruction = new System.Windows.Forms.Label();
            this.buttonFormatName = new System.Windows.Forms.Button();
            this.textBoxPreferredTitle = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFormattedNames = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(136, 42);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(67, 15);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name:";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(121, 71);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(82, 15);
            this.labelMiddleName.TabIndex = 1;
            this.labelMiddleName.Text = "Middle Name:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(137, 100);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(66, 15);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelPreferredTitle
            // 
            this.labelPreferredTitle.AutoSize = true;
            this.labelPreferredTitle.Location = new System.Drawing.Point(12, 131);
            this.labelPreferredTitle.Name = "labelPreferredTitle";
            this.labelPreferredTitle.Size = new System.Drawing.Size(191, 15);
            this.labelPreferredTitle.TabIndex = 3;
            this.labelPreferredTitle.Text = "Preferred Title (Mr., Mrs., Ms., etc.):";
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Location = new System.Drawing.Point(12, 9);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(268, 15);
            this.labelInstruction.TabIndex = 4;
            this.labelInstruction.Text = "Please enter the following pieces of information...";
            // 
            // buttonFormatName
            // 
            this.buttonFormatName.Location = new System.Drawing.Point(209, 166);
            this.buttonFormatName.Name = "buttonFormatName";
            this.buttonFormatName.Size = new System.Drawing.Size(100, 54);
            this.buttonFormatName.TabIndex = 5;
            this.buttonFormatName.Text = "Format Name";
            this.buttonFormatName.UseVisualStyleBackColor = true;
            this.buttonFormatName.Click += new System.EventHandler(this.buttonFormatName_Click);
            // 
            // textBoxPreferredTitle
            // 
            this.textBoxPreferredTitle.Location = new System.Drawing.Point(209, 128);
            this.textBoxPreferredTitle.Name = "textBoxPreferredTitle";
            this.textBoxPreferredTitle.Size = new System.Drawing.Size(100, 23);
            this.textBoxPreferredTitle.TabIndex = 6;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(209, 97);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 23);
            this.textBoxLastName.TabIndex = 7;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(209, 68);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(100, 23);
            this.textBoxMiddleName.TabIndex = 8;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(209, 39);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 23);
            this.textBoxFirstName.TabIndex = 9;
            // 
            // labelFormattedNames
            // 
            this.labelFormattedNames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFormattedNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFormattedNames.Location = new System.Drawing.Point(315, 42);
            this.labelFormattedNames.Name = "labelFormattedNames";
            this.labelFormattedNames.Size = new System.Drawing.Size(203, 178);
            this.labelFormattedNames.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 234);
            this.Controls.Add(this.labelFormattedNames);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxPreferredTitle);
            this.Controls.Add(this.buttonFormatName);
            this.Controls.Add(this.labelInstruction);
            this.Controls.Add(this.labelPreferredTitle);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelFirstName;
        private Label labelMiddleName;
        private Label labelLastName;
        private Label labelPreferredTitle;
        private Label labelInstruction;
        private Button buttonFormatName;
        private TextBox textBoxPreferredTitle;
        private TextBox textBoxLastName;
        private TextBox textBoxMiddleName;
        private TextBox textBoxFirstName;
        private Label labelFormattedNames;
    }
}