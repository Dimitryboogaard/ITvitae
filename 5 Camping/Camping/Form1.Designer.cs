namespace Camping
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
            this.gbMeerMinder = new System.Windows.Forms.GroupBox();
            this.tbAantalMeter = new System.Windows.Forms.TextBox();
            this.rbMeterMinder = new System.Windows.Forms.RadioButton();
            this.rbMeterMeer = new System.Windows.Forms.RadioButton();
            this.tbStartDatum = new System.Windows.Forms.TextBox();
            this.tbEindDatum = new System.Windows.Forms.TextBox();
            this.lblStartDatum = new System.Windows.Forms.Label();
            this.lblEindDatum = new System.Windows.Forms.Label();
            this.tbAantalPersonen = new System.Windows.Forms.TextBox();
            this.lblAantalPersonen = new System.Windows.Forms.Label();
            this.cbHond = new System.Windows.Forms.CheckBox();
            this.lblHond = new System.Windows.Forms.Label();
            this.cbAuto = new System.Windows.Forms.CheckBox();
            this.lblAuto = new System.Windows.Forms.Label();
            this.btnPrijs = new System.Windows.Forms.Button();
            this.tbPrijs = new System.Windows.Forms.TextBox();
            this.lblAantalMeter = new System.Windows.Forms.Label();
            this.gbMeerMinder.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMeerMinder
            // 
            this.gbMeerMinder.Controls.Add(this.lblAantalMeter);
            this.gbMeerMinder.Controls.Add(this.tbAantalMeter);
            this.gbMeerMinder.Controls.Add(this.rbMeterMinder);
            this.gbMeerMinder.Controls.Add(this.rbMeterMeer);
            this.gbMeerMinder.Location = new System.Drawing.Point(208, 19);
            this.gbMeerMinder.Name = "gbMeerMinder";
            this.gbMeerMinder.Size = new System.Drawing.Size(153, 91);
            this.gbMeerMinder.TabIndex = 0;
            this.gbMeerMinder.TabStop = false;
            // 
            // tbAantalMeter
            // 
            this.tbAantalMeter.Location = new System.Drawing.Point(78, 65);
            this.tbAantalMeter.Name = "tbAantalMeter";
            this.tbAantalMeter.Size = new System.Drawing.Size(55, 20);
            this.tbAantalMeter.TabIndex = 2;
            this.tbAantalMeter.Text = "0";
            this.tbAantalMeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbMeterMinder
            // 
            this.rbMeterMinder.AutoSize = true;
            this.rbMeterMinder.Location = new System.Drawing.Point(9, 39);
            this.rbMeterMinder.Name = "rbMeterMinder";
            this.rbMeterMinder.Size = new System.Drawing.Size(57, 17);
            this.rbMeterMinder.TabIndex = 1;
            this.rbMeterMinder.TabStop = true;
            this.rbMeterMinder.Text = "Minder";
            this.rbMeterMinder.UseVisualStyleBackColor = true;
            // 
            // rbMeterMeer
            // 
            this.rbMeterMeer.AutoSize = true;
            this.rbMeterMeer.Location = new System.Drawing.Point(9, 16);
            this.rbMeterMeer.Name = "rbMeterMeer";
            this.rbMeterMeer.Size = new System.Drawing.Size(49, 17);
            this.rbMeterMeer.TabIndex = 0;
            this.rbMeterMeer.TabStop = true;
            this.rbMeterMeer.Text = "Meer";
            this.rbMeterMeer.UseVisualStyleBackColor = true;
            // 
            // tbStartDatum
            // 
            this.tbStartDatum.Location = new System.Drawing.Point(102, 16);
            this.tbStartDatum.Name = "tbStartDatum";
            this.tbStartDatum.Size = new System.Drawing.Size(100, 20);
            this.tbStartDatum.TabIndex = 1;
            // 
            // tbEindDatum
            // 
            this.tbEindDatum.Location = new System.Drawing.Point(102, 42);
            this.tbEindDatum.Name = "tbEindDatum";
            this.tbEindDatum.Size = new System.Drawing.Size(100, 20);
            this.tbEindDatum.TabIndex = 2;
            // 
            // lblStartDatum
            // 
            this.lblStartDatum.AutoSize = true;
            this.lblStartDatum.Location = new System.Drawing.Point(38, 19);
            this.lblStartDatum.Name = "lblStartDatum";
            this.lblStartDatum.Size = new System.Drawing.Size(58, 13);
            this.lblStartDatum.TabIndex = 3;
            this.lblStartDatum.Text = "Startdatum";
            // 
            // lblEindDatum
            // 
            this.lblEindDatum.AutoSize = true;
            this.lblEindDatum.Location = new System.Drawing.Point(39, 45);
            this.lblEindDatum.Name = "lblEindDatum";
            this.lblEindDatum.Size = new System.Drawing.Size(57, 13);
            this.lblEindDatum.TabIndex = 4;
            this.lblEindDatum.Text = "Einddatum";
            // 
            // tbAantalPersonen
            // 
            this.tbAantalPersonen.Location = new System.Drawing.Point(102, 68);
            this.tbAantalPersonen.Name = "tbAantalPersonen";
            this.tbAantalPersonen.Size = new System.Drawing.Size(33, 20);
            this.tbAantalPersonen.TabIndex = 5;
            this.tbAantalPersonen.Text = "1";
            this.tbAantalPersonen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAantalPersonen
            // 
            this.lblAantalPersonen.AutoSize = true;
            this.lblAantalPersonen.Location = new System.Drawing.Point(12, 71);
            this.lblAantalPersonen.Name = "lblAantalPersonen";
            this.lblAantalPersonen.Size = new System.Drawing.Size(84, 13);
            this.lblAantalPersonen.TabIndex = 6;
            this.lblAantalPersonen.Text = "Aantal personen";
            // 
            // cbHond
            // 
            this.cbHond.AutoSize = true;
            this.cbHond.Location = new System.Drawing.Point(100, 94);
            this.cbHond.Name = "cbHond";
            this.cbHond.Size = new System.Drawing.Size(15, 14);
            this.cbHond.TabIndex = 7;
            this.cbHond.UseVisualStyleBackColor = true;
            // 
            // lblHond
            // 
            this.lblHond.AutoSize = true;
            this.lblHond.Location = new System.Drawing.Point(61, 94);
            this.lblHond.Name = "lblHond";
            this.lblHond.Size = new System.Drawing.Size(33, 13);
            this.lblHond.TabIndex = 8;
            this.lblHond.Text = "Hond";
            // 
            // cbAuto
            // 
            this.cbAuto.AutoSize = true;
            this.cbAuto.Location = new System.Drawing.Point(100, 114);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(15, 14);
            this.cbAuto.TabIndex = 9;
            this.cbAuto.UseVisualStyleBackColor = true;
            // 
            // lblAuto
            // 
            this.lblAuto.AutoSize = true;
            this.lblAuto.Location = new System.Drawing.Point(65, 114);
            this.lblAuto.Name = "lblAuto";
            this.lblAuto.Size = new System.Drawing.Size(29, 13);
            this.lblAuto.TabIndex = 10;
            this.lblAuto.Text = "Auto";
            this.lblAuto.Click += new System.EventHandler(this.lblAuto_Click);
            // 
            // btnPrijs
            // 
            this.btnPrijs.Location = new System.Drawing.Point(100, 157);
            this.btnPrijs.Name = "btnPrijs";
            this.btnPrijs.Size = new System.Drawing.Size(75, 23);
            this.btnPrijs.TabIndex = 11;
            this.btnPrijs.Text = "Prijs";
            this.btnPrijs.UseVisualStyleBackColor = true;
            this.btnPrijs.Click += new System.EventHandler(this.btnPrijs_Click);
            // 
            // tbPrijs
            // 
            this.tbPrijs.Location = new System.Drawing.Point(100, 186);
            this.tbPrijs.Name = "tbPrijs";
            this.tbPrijs.Size = new System.Drawing.Size(100, 20);
            this.tbPrijs.TabIndex = 12;
            // 
            // lblAantalMeter
            // 
            this.lblAantalMeter.AutoSize = true;
            this.lblAantalMeter.Location = new System.Drawing.Point(6, 68);
            this.lblAantalMeter.Name = "lblAantalMeter";
            this.lblAantalMeter.Size = new System.Drawing.Size(66, 13);
            this.lblAantalMeter.TabIndex = 3;
            this.lblAantalMeter.Text = "Aantal meter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 320);
            this.Controls.Add(this.tbPrijs);
            this.Controls.Add(this.btnPrijs);
            this.Controls.Add(this.lblAuto);
            this.Controls.Add(this.cbAuto);
            this.Controls.Add(this.lblHond);
            this.Controls.Add(this.cbHond);
            this.Controls.Add(this.lblAantalPersonen);
            this.Controls.Add(this.tbAantalPersonen);
            this.Controls.Add(this.lblEindDatum);
            this.Controls.Add(this.lblStartDatum);
            this.Controls.Add(this.tbEindDatum);
            this.Controls.Add(this.tbStartDatum);
            this.Controls.Add(this.gbMeerMinder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbMeerMinder.ResumeLayout(false);
            this.gbMeerMinder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMeerMinder;
        private System.Windows.Forms.RadioButton rbMeterMinder;
        private System.Windows.Forms.RadioButton rbMeterMeer;
        private System.Windows.Forms.TextBox tbAantalMeter;
        private System.Windows.Forms.TextBox tbStartDatum;
        private System.Windows.Forms.TextBox tbEindDatum;
        private System.Windows.Forms.Label lblStartDatum;
        private System.Windows.Forms.Label lblEindDatum;
        private System.Windows.Forms.TextBox tbAantalPersonen;
        private System.Windows.Forms.Label lblAantalPersonen;
        private System.Windows.Forms.CheckBox cbHond;
        private System.Windows.Forms.Label lblHond;
        private System.Windows.Forms.CheckBox cbAuto;
        private System.Windows.Forms.Label lblAuto;
        private System.Windows.Forms.Button btnPrijs;
        private System.Windows.Forms.TextBox tbPrijs;
        private System.Windows.Forms.Label lblAantalMeter;
    }
}

