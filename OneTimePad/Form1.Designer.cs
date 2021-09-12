namespace OnTimePadProgram
{
    partial class MainFrom
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.decryptionButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.ResultingText = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.enterText = new System.Windows.Forms.TextBox();
            this.labelForIntput = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.KeyLabel);
            this.mainPanel.Controls.Add(this.keyTextBox);
            this.mainPanel.Controls.Add(this.decryptionButton);
            this.mainPanel.Controls.Add(this.encryptButton);
            this.mainPanel.Controls.Add(this.ResultingText);
            this.mainPanel.Controls.Add(this.resultLabel);
            this.mainPanel.Controls.Add(this.enterText);
            this.mainPanel.Controls.Add(this.labelForIntput);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(6);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(808, 484);
            this.mainPanel.TabIndex = 0;
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyLabel.Location = new System.Drawing.Point(23, 129);
            this.KeyLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(55, 25);
            this.KeyLabel.TabIndex = 7;
            this.KeyLabel.Text = "Key:";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyTextBox.Location = new System.Drawing.Point(24, 160);
            this.keyTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(736, 44);
            this.keyTextBox.TabIndex = 6;
            // 
            // decryptionButton
            // 
            this.decryptionButton.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptionButton.Location = new System.Drawing.Point(520, 216);
            this.decryptionButton.Margin = new System.Windows.Forms.Padding(6);
            this.decryptionButton.Name = "decryptionButton";
            this.decryptionButton.Size = new System.Drawing.Size(240, 133);
            this.decryptionButton.TabIndex = 5;
            this.decryptionButton.Text = "Decrypt";
            this.decryptionButton.UseVisualStyleBackColor = true;
            this.decryptionButton.Click += new System.EventHandler(this.decryptionButton_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptButton.Location = new System.Drawing.Point(24, 216);
            this.encryptButton.Margin = new System.Windows.Forms.Padding(6);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(240, 133);
            this.encryptButton.TabIndex = 4;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // ResultingText
            // 
            this.ResultingText.Cursor = System.Windows.Forms.Cursors.No;
            this.ResultingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultingText.Location = new System.Drawing.Point(18, 416);
            this.ResultingText.Margin = new System.Windows.Forms.Padding(6);
            this.ResultingText.Name = "ResultingText";
            this.ResultingText.ReadOnly = true;
            this.ResultingText.Size = new System.Drawing.Size(736, 44);
            this.ResultingText.TabIndex = 3;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(18, 355);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(160, 55);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "Result";
            // 
            // enterText
            // 
            this.enterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterText.Location = new System.Drawing.Point(24, 79);
            this.enterText.Margin = new System.Windows.Forms.Padding(6);
            this.enterText.Name = "enterText";
            this.enterText.Size = new System.Drawing.Size(736, 44);
            this.enterText.TabIndex = 1;
            // 
            // labelForIntput
            // 
            this.labelForIntput.AutoSize = true;
            this.labelForIntput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForIntput.Location = new System.Drawing.Point(18, 17);
            this.labelForIntput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelForIntput.Name = "labelForIntput";
            this.labelForIntput.Size = new System.Drawing.Size(245, 55);
            this.labelForIntput.TabIndex = 0;
            this.labelForIntput.Text = "Enter Text";
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 484);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainFrom";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainFrom_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button decryptionButton;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.TextBox ResultingText;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox enterText;
        private System.Windows.Forms.Label labelForIntput;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.TextBox keyTextBox;
    }
}

