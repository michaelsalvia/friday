namespace Jarvis
{
    partial class Terminal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Terminal));
            this.hypothesizedRecognitionLabel = new System.Windows.Forms.Label();
            this.understoodInstructionLabel = new System.Windows.Forms.Label();
            this.hypothesizedRecognitionText = new System.Windows.Forms.Label();
            this.understoodInstructionText = new System.Windows.Forms.Label();
            this.enableButton = new System.Windows.Forms.Button();
            this.disableButton = new System.Windows.Forms.Button();
            this.consoleTextArea = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hypothesizedRecognitionLabel
            // 
            this.hypothesizedRecognitionLabel.AutoSize = true;
            this.hypothesizedRecognitionLabel.Font = new System.Drawing.Font("Lithos Pro Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hypothesizedRecognitionLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.hypothesizedRecognitionLabel.Location = new System.Drawing.Point(12, 29);
            this.hypothesizedRecognitionLabel.Name = "hypothesizedRecognitionLabel";
            this.hypothesizedRecognitionLabel.Size = new System.Drawing.Size(231, 18);
            this.hypothesizedRecognitionLabel.TabIndex = 0;
            this.hypothesizedRecognitionLabel.Text = "Hypothesized Recognition:";
            // 
            // understoodInstructionLabel
            // 
            this.understoodInstructionLabel.AutoSize = true;
            this.understoodInstructionLabel.Font = new System.Drawing.Font("Lithos Pro Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.understoodInstructionLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.understoodInstructionLabel.Location = new System.Drawing.Point(25, 68);
            this.understoodInstructionLabel.Name = "understoodInstructionLabel";
            this.understoodInstructionLabel.Size = new System.Drawing.Size(218, 18);
            this.understoodInstructionLabel.TabIndex = 1;
            this.understoodInstructionLabel.Text = "Understood Instruction:";
            // 
            // hypothesizedRecognitionText
            // 
            this.hypothesizedRecognitionText.AutoSize = true;
            this.hypothesizedRecognitionText.BackColor = System.Drawing.Color.Black;
            this.hypothesizedRecognitionText.Font = new System.Drawing.Font("Tekton Pro Ext", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hypothesizedRecognitionText.ForeColor = System.Drawing.Color.YellowGreen;
            this.hypothesizedRecognitionText.Location = new System.Drawing.Point(249, 9);
            this.hypothesizedRecognitionText.Name = "hypothesizedRecognitionText";
            this.hypothesizedRecognitionText.Padding = new System.Windows.Forms.Padding(10);
            this.hypothesizedRecognitionText.Size = new System.Drawing.Size(194, 38);
            this.hypothesizedRecognitionText.TabIndex = 2;
            this.hypothesizedRecognitionText.Text = "Currently Unavailable";
            // 
            // understoodInstructionText
            // 
            this.understoodInstructionText.AutoSize = true;
            this.understoodInstructionText.BackColor = System.Drawing.Color.Black;
            this.understoodInstructionText.Font = new System.Drawing.Font("Tekton Pro Ext", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.understoodInstructionText.ForeColor = System.Drawing.Color.YellowGreen;
            this.understoodInstructionText.Location = new System.Drawing.Point(249, 48);
            this.understoodInstructionText.Name = "understoodInstructionText";
            this.understoodInstructionText.Padding = new System.Windows.Forms.Padding(10);
            this.understoodInstructionText.Size = new System.Drawing.Size(194, 38);
            this.understoodInstructionText.TabIndex = 3;
            this.understoodInstructionText.Text = "Currently Unavailable";
            // 
            // enableButton
            // 
            this.enableButton.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableButton.Location = new System.Drawing.Point(568, 339);
            this.enableButton.Name = "enableButton";
            this.enableButton.Size = new System.Drawing.Size(75, 23);
            this.enableButton.TabIndex = 4;
            this.enableButton.Text = "Enable";
            this.enableButton.UseVisualStyleBackColor = true;
            this.enableButton.Click += new System.EventHandler(this.enableButton_Click);
            // 
            // disableButton
            // 
            this.disableButton.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableButton.Location = new System.Drawing.Point(487, 339);
            this.disableButton.Name = "disableButton";
            this.disableButton.Size = new System.Drawing.Size(75, 23);
            this.disableButton.TabIndex = 5;
            this.disableButton.Text = "Disable";
            this.disableButton.UseVisualStyleBackColor = true;
            this.disableButton.Click += new System.EventHandler(this.disableButton_click);
            // 
            // consoleTextArea
            // 
            this.consoleTextArea.BackColor = System.Drawing.Color.Black;
            this.consoleTextArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consoleTextArea.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleTextArea.ForeColor = System.Drawing.Color.White;
            this.consoleTextArea.Location = new System.Drawing.Point(19, 130);
            this.consoleTextArea.Name = "consoleTextArea";
            this.consoleTextArea.Size = new System.Drawing.Size(624, 203);
            this.consoleTextArea.TabIndex = 6;
            this.consoleTextArea.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lithos Pro Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(16, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Console:";
            // 
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(655, 374);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.consoleTextArea);
            this.Controls.Add(this.disableButton);
            this.Controls.Add(this.enableButton);
            this.Controls.Add(this.understoodInstructionText);
            this.Controls.Add(this.hypothesizedRecognitionText);
            this.Controls.Add(this.understoodInstructionLabel);
            this.Controls.Add(this.hypothesizedRecognitionLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Terminal";
            this.Text = "Jarvis by epicTEK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hypothesizedRecognitionLabel;
        private System.Windows.Forms.Label understoodInstructionLabel;
        private System.Windows.Forms.Label hypothesizedRecognitionText;
        private System.Windows.Forms.Label understoodInstructionText;
        private System.Windows.Forms.Button enableButton;
        private System.Windows.Forms.Button disableButton;
        private System.Windows.Forms.RichTextBox consoleTextArea;
        private System.Windows.Forms.Label label2;
    }
}

