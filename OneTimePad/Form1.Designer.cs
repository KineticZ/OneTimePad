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
            this.labelForIntput = new System.Windows.Forms.Label();
            this.enterText = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.ResultingText = new System.Windows.Forms.TextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Controls.Add(this.encryptButton);
            this.mainPanel.Controls.Add(this.ResultingText);
            this.mainPanel.Controls.Add(this.resultLabel);
            this.mainPanel.Controls.Add(this.enterText);
            this.mainPanel.Controls.Add(this.labelForIntput);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(404, 232);
            this.mainPanel.TabIndex = 0;
            // 
            // labelForIntput
            // 
            this.labelForIntput.AutoSize = true;
            this.labelForIntput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForIntput.Location = new System.Drawing.Point(9, 9);
            this.labelForIntput.Name = "labelForIntput";
            this.labelForIntput.Size = new System.Drawing.Size(123, 29);
            this.labelForIntput.TabIndex = 0;
            this.labelForIntput.Text = "Enter Text";
            // 
            // enterText
            // 
            this.enterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterText.Location = new System.Drawing.Point(12, 41);
            this.enterText.Name = "enterText";
            this.enterText.Size = new System.Drawing.Size(370, 26);
            this.enterText.TabIndex = 1;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(12, 146);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(81, 29);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "Result";
            // 
            // ResultingText
            // 
            this.ResultingText.Cursor = System.Windows.Forms.Cursors.No;
            this.ResultingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultingText.Location = new System.Drawing.Point(12, 178);
            this.ResultingText.Name = "ResultingText";
            this.ResultingText.ReadOnly = true;
            this.ResultingText.Size = new System.Drawing.Size(370, 26);
            this.ResultingText.TabIndex = 3;
            // 
            // encryptButton
            // 
            this.encryptButton.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptButton.Location = new System.Drawing.Point(12, 74);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(120, 69);
            this.encryptButton.TabIndex = 4;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(262, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 69);
            this.button1.TabIndex = 5;
            this.button1.Text = "Decrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 232);
            this.Controls.Add(this.mainPanel);
            this.Name = "MainFrom";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainFrom_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.TextBox ResultingText;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox enterText;
        private System.Windows.Forms.Label labelForIntput;
    }
}

