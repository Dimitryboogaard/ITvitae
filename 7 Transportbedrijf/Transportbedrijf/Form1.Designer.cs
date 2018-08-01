namespace Transportbedrijf
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
            this.tbAantalKmInBinneland = new System.Windows.Forms.TextBox();
            this.tbAantalKmInBuitenland = new System.Windows.Forms.TextBox();
            this.lblAantalKmInBinnenland = new System.Windows.Forms.Label();
            this.lblAantalKmInBuitenland = new System.Windows.Forms.Label();
            this.btnPrijs = new System.Windows.Forms.Button();
            this.tbVolume = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.tbGewicht = new System.Windows.Forms.TextBox();
            this.lblGewicht = new System.Windows.Forms.Label();
            this.tbVolumeVloeibaar = new System.Windows.Forms.TextBox();
            this.lblVolumeVloeibaar = new System.Windows.Forms.Label();
            this.tbGewichtVloeibaar = new System.Windows.Forms.TextBox();
            this.lblGewichtVloeibaar = new System.Windows.Forms.Label();
            this.tbPrijs = new System.Windows.Forms.TextBox();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.tbWaardeLading = new System.Windows.Forms.TextBox();
            this.lblWaardeLading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAantalKmInBinneland
            // 
            this.tbAantalKmInBinneland.Location = new System.Drawing.Point(137, 32);
            this.tbAantalKmInBinneland.Name = "tbAantalKmInBinneland";
            this.tbAantalKmInBinneland.Size = new System.Drawing.Size(100, 20);
            this.tbAantalKmInBinneland.TabIndex = 0;
            this.tbAantalKmInBinneland.Text = "0";
            this.tbAantalKmInBinneland.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbAantalKmInBuitenland
            // 
            this.tbAantalKmInBuitenland.Location = new System.Drawing.Point(137, 58);
            this.tbAantalKmInBuitenland.Name = "tbAantalKmInBuitenland";
            this.tbAantalKmInBuitenland.Size = new System.Drawing.Size(100, 20);
            this.tbAantalKmInBuitenland.TabIndex = 1;
            this.tbAantalKmInBuitenland.Text = "0";
            this.tbAantalKmInBuitenland.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAantalKmInBinnenland
            // 
            this.lblAantalKmInBinnenland.AutoSize = true;
            this.lblAantalKmInBinnenland.Location = new System.Drawing.Point(11, 35);
            this.lblAantalKmInBinnenland.Name = "lblAantalKmInBinnenland";
            this.lblAantalKmInBinnenland.Size = new System.Drawing.Size(120, 13);
            this.lblAantalKmInBinnenland.TabIndex = 2;
            this.lblAantalKmInBinnenland.Text = "Aantal km in binnenland";
            // 
            // lblAantalKmInBuitenland
            // 
            this.lblAantalKmInBuitenland.AutoSize = true;
            this.lblAantalKmInBuitenland.Location = new System.Drawing.Point(16, 61);
            this.lblAantalKmInBuitenland.Name = "lblAantalKmInBuitenland";
            this.lblAantalKmInBuitenland.Size = new System.Drawing.Size(117, 13);
            this.lblAantalKmInBuitenland.TabIndex = 3;
            this.lblAantalKmInBuitenland.Text = "Aantal km in buitenland";
            // 
            // btnPrijs
            // 
            this.btnPrijs.Location = new System.Drawing.Point(136, 245);
            this.btnPrijs.Name = "btnPrijs";
            this.btnPrijs.Size = new System.Drawing.Size(99, 23);
            this.btnPrijs.TabIndex = 4;
            this.btnPrijs.Text = "Prijs";
            this.btnPrijs.UseVisualStyleBackColor = true;
            this.btnPrijs.Click += new System.EventHandler(this.btnPrijs_Click);
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(137, 84);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(100, 20);
            this.tbVolume.TabIndex = 5;
            this.tbVolume.Text = "0";
            this.tbVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(66, 87);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(65, 13);
            this.lblVolume.TabIndex = 6;
            this.lblVolume.Text = "Volume (m3)";
            // 
            // tbGewicht
            // 
            this.tbGewicht.Location = new System.Drawing.Point(137, 110);
            this.tbGewicht.Name = "tbGewicht";
            this.tbGewicht.Size = new System.Drawing.Size(100, 20);
            this.tbGewicht.TabIndex = 7;
            this.tbGewicht.Text = "0";
            this.tbGewicht.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGewicht
            // 
            this.lblGewicht.AutoSize = true;
            this.lblGewicht.Location = new System.Drawing.Point(66, 113);
            this.lblGewicht.Name = "lblGewicht";
            this.lblGewicht.Size = new System.Drawing.Size(67, 13);
            this.lblGewicht.TabIndex = 8;
            this.lblGewicht.Text = "Gewicht (kg)";
            // 
            // tbVolumeVloeibaar
            // 
            this.tbVolumeVloeibaar.Location = new System.Drawing.Point(138, 136);
            this.tbVolumeVloeibaar.Name = "tbVolumeVloeibaar";
            this.tbVolumeVloeibaar.Size = new System.Drawing.Size(100, 20);
            this.tbVolumeVloeibaar.TabIndex = 9;
            this.tbVolumeVloeibaar.Text = "0";
            this.tbVolumeVloeibaar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVolumeVloeibaar
            // 
            this.lblVolumeVloeibaar.AutoSize = true;
            this.lblVolumeVloeibaar.Location = new System.Drawing.Point(20, 139);
            this.lblVolumeVloeibaar.Name = "lblVolumeVloeibaar";
            this.lblVolumeVloeibaar.Size = new System.Drawing.Size(111, 13);
            this.lblVolumeVloeibaar.TabIndex = 10;
            this.lblVolumeVloeibaar.Text = "Volume vloeibaar (m3)";
            // 
            // tbGewichtVloeibaar
            // 
            this.tbGewichtVloeibaar.Location = new System.Drawing.Point(138, 162);
            this.tbGewichtVloeibaar.Name = "tbGewichtVloeibaar";
            this.tbGewichtVloeibaar.Size = new System.Drawing.Size(100, 20);
            this.tbGewichtVloeibaar.TabIndex = 11;
            this.tbGewichtVloeibaar.Text = "0";
            this.tbGewichtVloeibaar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGewichtVloeibaar
            // 
            this.lblGewichtVloeibaar.AutoSize = true;
            this.lblGewichtVloeibaar.Location = new System.Drawing.Point(20, 165);
            this.lblGewichtVloeibaar.Name = "lblGewichtVloeibaar";
            this.lblGewichtVloeibaar.Size = new System.Drawing.Size(113, 13);
            this.lblGewichtVloeibaar.TabIndex = 12;
            this.lblGewichtVloeibaar.Text = "Gewicht vloeibaar (kg)";
            // 
            // tbPrijs
            // 
            this.tbPrijs.Location = new System.Drawing.Point(136, 274);
            this.tbPrijs.Name = "tbPrijs";
            this.tbPrijs.Size = new System.Drawing.Size(100, 20);
            this.tbPrijs.TabIndex = 13;
            // 
            // lblPrijs
            // 
            this.lblPrijs.AutoSize = true;
            this.lblPrijs.Location = new System.Drawing.Point(105, 250);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(26, 13);
            this.lblPrijs.TabIndex = 14;
            this.lblPrijs.Text = "Prijs";
            // 
            // tbWaardeLading
            // 
            this.tbWaardeLading.Location = new System.Drawing.Point(138, 188);
            this.tbWaardeLading.Name = "tbWaardeLading";
            this.tbWaardeLading.Size = new System.Drawing.Size(100, 20);
            this.tbWaardeLading.TabIndex = 15;
            this.tbWaardeLading.Text = "0";
            this.tbWaardeLading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblWaardeLading
            // 
            this.lblWaardeLading.AutoSize = true;
            this.lblWaardeLading.Location = new System.Drawing.Point(57, 191);
            this.lblWaardeLading.Name = "lblWaardeLading";
            this.lblWaardeLading.Size = new System.Drawing.Size(76, 13);
            this.lblWaardeLading.TabIndex = 16;
            this.lblWaardeLading.Text = "Waarde lading";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 319);
            this.Controls.Add(this.lblWaardeLading);
            this.Controls.Add(this.tbWaardeLading);
            this.Controls.Add(this.lblPrijs);
            this.Controls.Add(this.tbPrijs);
            this.Controls.Add(this.lblGewichtVloeibaar);
            this.Controls.Add(this.tbGewichtVloeibaar);
            this.Controls.Add(this.lblVolumeVloeibaar);
            this.Controls.Add(this.tbVolumeVloeibaar);
            this.Controls.Add(this.lblGewicht);
            this.Controls.Add(this.tbGewicht);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.btnPrijs);
            this.Controls.Add(this.lblAantalKmInBuitenland);
            this.Controls.Add(this.lblAantalKmInBinnenland);
            this.Controls.Add(this.tbAantalKmInBuitenland);
            this.Controls.Add(this.tbAantalKmInBinneland);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAantalKmInBinneland;
        private System.Windows.Forms.TextBox tbAantalKmInBuitenland;
        private System.Windows.Forms.Label lblAantalKmInBinnenland;
        private System.Windows.Forms.Label lblAantalKmInBuitenland;
        private System.Windows.Forms.Button btnPrijs;
        private System.Windows.Forms.TextBox tbVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox tbGewicht;
        private System.Windows.Forms.Label lblGewicht;
        private System.Windows.Forms.TextBox tbVolumeVloeibaar;
        private System.Windows.Forms.Label lblVolumeVloeibaar;
        private System.Windows.Forms.TextBox tbGewichtVloeibaar;
        private System.Windows.Forms.Label lblGewichtVloeibaar;
        private System.Windows.Forms.TextBox tbPrijs;
        private System.Windows.Forms.Label lblPrijs;
        private System.Windows.Forms.TextBox tbWaardeLading;
        private System.Windows.Forms.Label lblWaardeLading;
    }
}

