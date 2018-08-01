namespace Autoverhuur
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
            this.tbStartDatum = new System.Windows.Forms.TextBox();
            this.tbEindDatum = new System.Windows.Forms.TextBox();
            this.lblStartDatum = new System.Windows.Forms.Label();
            this.lblEindDatum = new System.Windows.Forms.Label();
            this.tbAantalKm = new System.Windows.Forms.TextBox();
            this.lblAantalKm = new System.Windows.Forms.Label();
            this.btnBerekenPrijs = new System.Windows.Forms.Button();
            this.cbPersonenBusje = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPrijs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbStartDatum
            // 
            this.tbStartDatum.Location = new System.Drawing.Point(100, 12);
            this.tbStartDatum.Name = "tbStartDatum";
            this.tbStartDatum.Size = new System.Drawing.Size(100, 20);
            this.tbStartDatum.TabIndex = 0;
            // 
            // tbEindDatum
            // 
            this.tbEindDatum.Location = new System.Drawing.Point(100, 38);
            this.tbEindDatum.Name = "tbEindDatum";
            this.tbEindDatum.Size = new System.Drawing.Size(100, 20);
            this.tbEindDatum.TabIndex = 1;
            // 
            // lblStartDatum
            // 
            this.lblStartDatum.AutoSize = true;
            this.lblStartDatum.Location = new System.Drawing.Point(36, 15);
            this.lblStartDatum.Name = "lblStartDatum";
            this.lblStartDatum.Size = new System.Drawing.Size(58, 13);
            this.lblStartDatum.TabIndex = 2;
            this.lblStartDatum.Text = "Startdatum";
            // 
            // lblEindDatum
            // 
            this.lblEindDatum.AutoSize = true;
            this.lblEindDatum.Location = new System.Drawing.Point(36, 41);
            this.lblEindDatum.Name = "lblEindDatum";
            this.lblEindDatum.Size = new System.Drawing.Size(57, 13);
            this.lblEindDatum.TabIndex = 3;
            this.lblEindDatum.Text = "Einddatum";
            // 
            // tbAantalKm
            // 
            this.tbAantalKm.Location = new System.Drawing.Point(100, 64);
            this.tbAantalKm.Name = "tbAantalKm";
            this.tbAantalKm.Size = new System.Drawing.Size(100, 20);
            this.tbAantalKm.TabIndex = 4;
            // 
            // lblAantalKm
            // 
            this.lblAantalKm.AutoSize = true;
            this.lblAantalKm.Location = new System.Drawing.Point(39, 67);
            this.lblAantalKm.Name = "lblAantalKm";
            this.lblAantalKm.Size = new System.Drawing.Size(54, 13);
            this.lblAantalKm.TabIndex = 5;
            this.lblAantalKm.Text = "Aantal km";
            // 
            // btnBerekenPrijs
            // 
            this.btnBerekenPrijs.Location = new System.Drawing.Point(100, 113);
            this.btnBerekenPrijs.Name = "btnBerekenPrijs";
            this.btnBerekenPrijs.Size = new System.Drawing.Size(100, 23);
            this.btnBerekenPrijs.TabIndex = 6;
            this.btnBerekenPrijs.Text = "Bereken prijs";
            this.btnBerekenPrijs.UseVisualStyleBackColor = true;
            this.btnBerekenPrijs.Click += new System.EventHandler(this.btnBerekenPrijs_Click);
            // 
            // cbPersonenBusje
            // 
            this.cbPersonenBusje.AutoSize = true;
            this.cbPersonenBusje.Location = new System.Drawing.Point(100, 90);
            this.cbPersonenBusje.Name = "cbPersonenBusje";
            this.cbPersonenBusje.Size = new System.Drawing.Size(15, 14);
            this.cbPersonenBusje.TabIndex = 7;
            this.cbPersonenBusje.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Personen busje";
            // 
            // tbPrijs
            // 
            this.tbPrijs.Location = new System.Drawing.Point(100, 165);
            this.tbPrijs.Name = "tbPrijs";
            this.tbPrijs.Size = new System.Drawing.Size(100, 20);
            this.tbPrijs.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 247);
            this.Controls.Add(this.tbPrijs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPersonenBusje);
            this.Controls.Add(this.btnBerekenPrijs);
            this.Controls.Add(this.lblAantalKm);
            this.Controls.Add(this.tbAantalKm);
            this.Controls.Add(this.lblEindDatum);
            this.Controls.Add(this.lblStartDatum);
            this.Controls.Add(this.tbEindDatum);
            this.Controls.Add(this.tbStartDatum);
            this.Name = "Form1";
            this.Text = "Autoverhuur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbStartDatum;
        private System.Windows.Forms.TextBox tbEindDatum;
        private System.Windows.Forms.Label lblStartDatum;
        private System.Windows.Forms.Label lblEindDatum;
        private System.Windows.Forms.TextBox tbAantalKm;
        private System.Windows.Forms.Label lblAantalKm;
        private System.Windows.Forms.Button btnBerekenPrijs;
        private System.Windows.Forms.CheckBox cbPersonenBusje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrijs;
    }
}

