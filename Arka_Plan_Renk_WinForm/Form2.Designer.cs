namespace Arka_Plan_Renk_WinForm
{
    partial class Form2
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
            label1 = new Label();
            cmbRenkler = new ComboBox();
            btnTamam = new Button();
            btnIptal = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 58);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Renk Sec";
            // 
            // cmbRenkler
            // 
            cmbRenkler.FormattingEnabled = true;
            cmbRenkler.Location = new Point(116, 58);
            cmbRenkler.Name = "cmbRenkler";
            cmbRenkler.Size = new Size(121, 23);
            cmbRenkler.TabIndex = 1;
            // 
            // btnTamam
            // 
            btnTamam.Location = new Point(47, 104);
            btnTamam.Name = "btnTamam";
            btnTamam.Size = new Size(75, 23);
            btnTamam.TabIndex = 2;
            btnTamam.Text = "TAMAM";
            btnTamam.UseVisualStyleBackColor = true;
            btnTamam.Click += btnTamam_Click;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(162, 104);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(75, 23);
            btnIptal.TabIndex = 3;
            btnIptal.Text = "IPTAL";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 187);
            Controls.Add(btnIptal);
            Controls.Add(btnTamam);
            Controls.Add(cmbRenkler);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbRenkler;
        private Button btnTamam;
        private Button btnIptal;
    }
}