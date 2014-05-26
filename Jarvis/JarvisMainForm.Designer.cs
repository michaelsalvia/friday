namespace Jarvis
{
    partial class JarvisMainForm
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
            this.hypothesized = new System.Windows.Forms.Label();
            this.recognized = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hypothesized
            // 
            this.hypothesized.AutoSize = true;
            this.hypothesized.Location = new System.Drawing.Point(12, 9);
            this.hypothesized.Name = "hypothesized";
            this.hypothesized.Size = new System.Drawing.Size(0, 13);
            this.hypothesized.TabIndex = 0;
            // 
            // recognized
            // 
            this.recognized.AutoSize = true;
            this.recognized.Location = new System.Drawing.Point(12, 22);
            this.recognized.Name = "recognized";
            this.recognized.Size = new System.Drawing.Size(0, 13);
            this.recognized.TabIndex = 1;
            // 
            // JarvisMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.recognized);
            this.Controls.Add(this.hypothesized);
            this.Name = "JarvisMainForm";
            this.Text = "Jarvis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hypothesized;
        private System.Windows.Forms.Label recognized;

    }
}

