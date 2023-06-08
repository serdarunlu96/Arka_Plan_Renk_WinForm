namespace Arka_Plan_Renk_WinForm
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
            btnRenkSec = new Button();
            SuspendLayout();
            // 
            // btnRenkSec
            // 
            btnRenkSec.Location = new Point(38, 34);
            btnRenkSec.Name = "btnRenkSec";
            btnRenkSec.Size = new Size(75, 23);
            btnRenkSec.TabIndex = 4;
            btnRenkSec.Text = "RENK SEC";
            btnRenkSec.UseVisualStyleBackColor = true;
            btnRenkSec.Click += btnRenkSec_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(161, 86);
            Controls.Add(btnRenkSec);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRenkSec;
    }
}