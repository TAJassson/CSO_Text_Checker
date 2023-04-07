namespace CSO_Text_Checker
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
            this.DisplayFileName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rtbErrors = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // DisplayFileName
            // 
            this.DisplayFileName.Location = new System.Drawing.Point(12, 12);
            this.DisplayFileName.Name = "DisplayFileName";
            this.DisplayFileName.Size = new System.Drawing.Size(870, 23);
            this.DisplayFileName.TabIndex = 0;
            this.DisplayFileName.TextChanged += new System.EventHandler(this.DisplayFileName_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(888, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            // 
            // rtbErrors
            // 
            this.rtbErrors.Location = new System.Drawing.Point(12, 41);
            this.rtbErrors.Name = "rtbErrors";
            this.rtbErrors.Size = new System.Drawing.Size(977, 881);
            this.rtbErrors.TabIndex = 2;
            this.rtbErrors.Text = "";
            this.rtbErrors.TextChanged += new System.EventHandler(this.rtbErrors_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 934);
            this.Controls.Add(this.rtbErrors);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DisplayFileName);
            this.Name = "Form1";
            this.Text = "CSO Language file checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DisplayFileName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtbErrors;
    }
}
