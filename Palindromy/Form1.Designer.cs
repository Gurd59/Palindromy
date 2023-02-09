namespace Palindromy
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtVstup = new System.Windows.Forms.TextBox();
            this.txtVystup = new System.Windows.Forms.TextBox();
            this.btnPalindrom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVstup
            // 
            this.txtVstup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtVstup.Location = new System.Drawing.Point(12, 12);
            this.txtVstup.Multiline = true;
            this.txtVstup.Name = "txtVstup";
            this.txtVstup.Size = new System.Drawing.Size(583, 262);
            this.txtVstup.TabIndex = 0;
            // 
            // txtVystup
            // 
            this.txtVystup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtVystup.Location = new System.Drawing.Point(12, 291);
            this.txtVystup.Multiline = true;
            this.txtVystup.Name = "txtVystup";
            this.txtVystup.Size = new System.Drawing.Size(583, 262);
            this.txtVystup.TabIndex = 0;
            // 
            // btnPalindrom
            // 
            this.btnPalindrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnPalindrom.Location = new System.Drawing.Point(726, 211);
            this.btnPalindrom.Name = "btnPalindrom";
            this.btnPalindrom.Size = new System.Drawing.Size(270, 137);
            this.btnPalindrom.TabIndex = 1;
            this.btnPalindrom.Text = "Palindrom";
            this.btnPalindrom.UseVisualStyleBackColor = true;
            this.btnPalindrom.Click += new System.EventHandler(this.btnPalindrom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 589);
            this.Controls.Add(this.btnPalindrom);
            this.Controls.Add(this.txtVystup);
            this.Controls.Add(this.txtVstup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVstup;
        private System.Windows.Forms.TextBox txtVystup;
        private System.Windows.Forms.Button btnPalindrom;
    }
}

