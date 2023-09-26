namespace Dikdörtgen_alan_çevre_hesap
{
    partial class Form1
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblKısa = new System.Windows.Forms.Label();
            this.lblUzun = new System.Windows.Forms.Label();
            this.lblÇevre = new System.Windows.Forms.Label();
            this.lblAlan = new System.Windows.Forms.Label();
            this.txtKısa = new System.Windows.Forms.TextBox();
            this.txtUzun = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.OrangeRed;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.ForeColor = System.Drawing.Color.Yellow;
            this.btnHesapla.Location = new System.Drawing.Point(84, 89);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 27);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "Hespla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblKısa
            // 
            this.lblKısa.AutoSize = true;
            this.lblKısa.Location = new System.Drawing.Point(12, 15);
            this.lblKısa.Name = "lblKısa";
            this.lblKısa.Size = new System.Drawing.Size(58, 13);
            this.lblKısa.TabIndex = 1;
            this.lblKısa.Text = "Kısa Kenar";
            // 
            // lblUzun
            // 
            this.lblUzun.AutoSize = true;
            this.lblUzun.Location = new System.Drawing.Point(12, 61);
            this.lblUzun.Name = "lblUzun";
            this.lblUzun.Size = new System.Drawing.Size(63, 13);
            this.lblUzun.TabIndex = 2;
            this.lblUzun.Text = "Uzun Kenar";
            // 
            // lblÇevre
            // 
            this.lblÇevre.AutoSize = true;
            this.lblÇevre.Location = new System.Drawing.Point(40, 160);
            this.lblÇevre.Name = "lblÇevre";
            this.lblÇevre.Size = new System.Drawing.Size(35, 13);
            this.lblÇevre.TabIndex = 3;
            this.lblÇevre.Text = "Çevre";
            // 
            // lblAlan
            // 
            this.lblAlan.AutoSize = true;
            this.lblAlan.Location = new System.Drawing.Point(42, 192);
            this.lblAlan.Name = "lblAlan";
            this.lblAlan.Size = new System.Drawing.Size(28, 13);
            this.lblAlan.TabIndex = 4;
            this.lblAlan.Text = "Alan";
            // 
            // txtKısa
            // 
            this.txtKısa.Location = new System.Drawing.Point(84, 12);
            this.txtKısa.Name = "txtKısa";
            this.txtKısa.Size = new System.Drawing.Size(100, 20);
            this.txtKısa.TabIndex = 5;
            // 
            // txtUzun
            // 
            this.txtUzun.Location = new System.Drawing.Point(84, 54);
            this.txtUzun.Name = "txtUzun";
            this.txtUzun.Size = new System.Drawing.Size(100, 20);
            this.txtUzun.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 243);
            this.Controls.Add(this.txtUzun);
            this.Controls.Add(this.txtKısa);
            this.Controls.Add(this.lblAlan);
            this.Controls.Add(this.lblÇevre);
            this.Controls.Add(this.lblUzun);
            this.Controls.Add(this.lblKısa);
            this.Controls.Add(this.btnHesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblKısa;
        private System.Windows.Forms.Label lblUzun;
        private System.Windows.Forms.Label lblÇevre;
        private System.Windows.Forms.Label lblAlan;
        private System.Windows.Forms.TextBox txtKısa;
        private System.Windows.Forms.TextBox txtUzun;
    }
}

