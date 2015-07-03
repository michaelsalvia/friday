namespace Friday
{
    partial class FridayConsole
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
            this.consoleTextArea = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // consoleTextArea
            // 
            this.consoleTextArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consoleTextArea.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleTextArea.Location = new System.Drawing.Point(19, 25);
            this.consoleTextArea.Name = "consoleTextArea";
            this.consoleTextArea.Size = new System.Drawing.Size(624, 206);
            this.consoleTextArea.TabIndex = 6;
            this.consoleTextArea.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Console:";
            // 
            // Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 243);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.consoleTextArea);
            this.Name = "Console";
            this.Text = "Friday";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox consoleTextArea;
        private System.Windows.Forms.Label label2;
    }
}

