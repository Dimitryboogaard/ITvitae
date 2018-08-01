namespace Containerverhuur
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
            this.tbAantalM3 = new System.Windows.Forms.TextBox();
            this.lblAantalM3 = new System.Windows.Forms.Label();
            this.cbVasteKlant = new System.Windows.Forms.CheckBox();
            this.lblVasteKlant = new System.Windows.Forms.Label();
            this.btnPrijs = new System.Windows.Forms.Button();
            this.tbStartDatum = new System.Windows.Forms.TextBox();
            this.tbEindDatum = new System.Windows.Forms.TextBox();
            this.lblStartDatum = new System.Windows.Forms.Label();
            this.lblEindDatum = new System.Windows.Forms.Label();
            this.tbPrijs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbAantalM3
            // 
            this.tbAantalM3.Location = new System.Drawing.Point(80, 68);
            this.tbAantalM3.Name = "tbAantalM3";
            this.tbAantalM3.Size = new System.Drawing.Size(100, 20);
            this.tbAantalM3.TabIndex = 0;
            // 
            // lblAantalM3
            // 
            this.lblAantalM3.AutoSize = true;
            this.lblAantalM3.Location = new System.Drawing.Point(20, 71);
            this.lblAantalM3.Name = "lblAantalM3";
            this.lblAantalM3.Size = new System.Drawing.Size(54, 13);
            this.lblAantalM3.TabIndex = 1;
            this.lblAantalM3.Text = "Aantal m3";
            // 
            // cbVasteKlant
            // 
            this.cbVasteKlant.AutoSize = true;
            this.cbVasteKlant.Location = new System.Drawing.Point(80, 94);
            this.cbVasteKlant.Name = "cbVasteKlant";
            this.cbVasteKlant.Size = new System.Drawing.Size(15, 14);
            this.cbVasteKlant.TabIndex = 2;
            this.cbVasteKlant.UseVisualStyleBackColor = true;
            // 
            // lblVasteKlant
            // 
            this.lblVasteKlant.AutoSize = true;
            this.lblVasteKlant.Location = new System.Drawing.Point(14, 94);
            this.lblVasteKlant.Name = "lblVasteKlant";
            this.lblVasteKlant.Size = new System.Drawing.Size(60, 13);
            this.lblVasteKlant.TabIndex = 3;
            this.lblVasteKlant.Text = "Vaste klant";
            // 
            // btnPrijs
            // 
            this.btnPrijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijs.Location = new System.Drawing.Point(80, 114);
            this.btnPrijs.Name = "btnPrijs";
            this.btnPrijs.Size = new System.Drawing.Size(100, 34);
            this.btnPrijs.TabIndex = 4;
            this.btnPrijs.Text = "Prijs";
            this.btnPrijs.UseVisualStyleBackColor = true;
            this.btnPrijs.Click += new System.EventHandler(this.btnPrijs_Click);
            // 
            // tbStartDatum
            // 
            this.tbStartDatum.Location = new System.Drawing.Point(80, 14);
            this.tbStartDatum.Name = "tbStartDatum";
            this.tbStartDatum.Size = new System.Drawing.Size(100, 20);
            this.tbStartDatum.TabIndex = 5;
            // 
            // tbEindDatum
            // 
            this.tbEindDatum.Location = new System.Drawing.Point(80, 40);
            this.tbEindDatum.Name = "tbEindDatum";
            this.tbEindDatum.Size = new System.Drawing.Size(100, 20);
            this.tbEindDatum.TabIndex = 6;
            // 
            // lblStartDatum
            // 
            this.lblStartDatum.AutoSize = true;
            this.lblStartDatum.Location = new System.Drawing.Point(16, 17);
            this.lblStartDatum.Name = "lblStartDatum";
            this.lblStartDatum.Size = new System.Drawing.Size(58, 13);
            this.lblStartDatum.TabIndex = 7;
            this.lblStartDatum.Text = "Startdatum";
            // 
            // lblEindDatum
            // 
            this.lblEindDatum.AutoSize = true;
            this.lblEindDatum.Location = new System.Drawing.Point(17, 43);
            this.lblEindDatum.Name = "lblEindDatum";
            this.lblEindDatum.Size = new System.Drawing.Size(57, 13);
            this.lblEindDatum.TabIndex = 8;
            this.lblEindDatum.Text = "Einddatum";
            // 
            // tbPrijs
            // 
            this.tbPrijs.Location = new System.Drawing.Point(83, 183);
            this.tbPrijs.Name = "tbPrijs";
            this.tbPrijs.Size = new System.Drawing.Size(100, 20);
            this.tbPrijs.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 262);
            this.Controls.Add(this.tbPrijs);
            this.Controls.Add(this.lblEindDatum);
            this.Controls.Add(this.lblStartDatum);
            this.Controls.Add(this.tbEindDatum);
            this.Controls.Add(this.tbStartDatum);
            this.Controls.Add(this.btnPrijs);
            this.Controls.Add(this.lblVasteKlant);
            this.Controls.Add(this.cbVasteKlant);
            this.Controls.Add(this.lblAantalM3);
            this.Controls.Add(this.tbAantalM3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAantalM3;
        private System.Windows.Forms.Label lblAantalM3;
        private System.Windows.Forms.CheckBox cbVasteKlant;
        private System.Windows.Forms.Label lblVasteKlant;
        private System.Windows.Forms.Button btnPrijs;
        private System.Windows.Forms.TextBox tbStartDatum;
        private System.Windows.Forms.TextBox tbEindDatum;
        private System.Windows.Forms.Label lblStartDatum;
        private System.Windows.Forms.Label lblEindDatum;
        private System.Windows.Forms.TextBox tbPrijs;
    }
}

