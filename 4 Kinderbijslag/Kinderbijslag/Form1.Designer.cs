namespace Kinderbijslag
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
            this.tbGeboorteDatum = new System.Windows.Forms.TextBox();
            this.tbKinderBijslag = new System.Windows.Forms.TextBox();
            this.btnKinderBijslag = new System.Windows.Forms.Button();
            this.lblGeboorteDatum = new System.Windows.Forms.Label();
            this.btnInvoeren = new System.Windows.Forms.Button();
            this.lblAantal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbGeboorteDatum
            // 
            this.tbGeboorteDatum.Location = new System.Drawing.Point(98, 24);
            this.tbGeboorteDatum.Name = "tbGeboorteDatum";
            this.tbGeboorteDatum.Size = new System.Drawing.Size(100, 20);
            this.tbGeboorteDatum.TabIndex = 0;
            // 
            // tbKinderBijslag
            // 
            this.tbKinderBijslag.Location = new System.Drawing.Point(98, 143);
            this.tbKinderBijslag.Name = "tbKinderBijslag";
            this.tbKinderBijslag.Size = new System.Drawing.Size(100, 20);
            this.tbKinderBijslag.TabIndex = 1;
            // 
            // btnKinderBijslag
            // 
            this.btnKinderBijslag.Location = new System.Drawing.Point(98, 114);
            this.btnKinderBijslag.Name = "btnKinderBijslag";
            this.btnKinderBijslag.Size = new System.Drawing.Size(100, 23);
            this.btnKinderBijslag.TabIndex = 2;
            this.btnKinderBijslag.Text = "Kinderbijslag";
            this.btnKinderBijslag.UseVisualStyleBackColor = true;
            this.btnKinderBijslag.Click += new System.EventHandler(this.btnKinderBijslag_Click);
            // 
            // lblGeboorteDatum
            // 
            this.lblGeboorteDatum.AutoSize = true;
            this.lblGeboorteDatum.Location = new System.Drawing.Point(12, 27);
            this.lblGeboorteDatum.Name = "lblGeboorteDatum";
            this.lblGeboorteDatum.Size = new System.Drawing.Size(80, 13);
            this.lblGeboorteDatum.TabIndex = 3;
            this.lblGeboorteDatum.Text = "Geboortedatum";
            // 
            // btnInvoeren
            // 
            this.btnInvoeren.Location = new System.Drawing.Point(98, 50);
            this.btnInvoeren.Name = "btnInvoeren";
            this.btnInvoeren.Size = new System.Drawing.Size(100, 23);
            this.btnInvoeren.TabIndex = 4;
            this.btnInvoeren.Text = "Invoeren";
            this.btnInvoeren.UseVisualStyleBackColor = true;
            this.btnInvoeren.Click += new System.EventHandler(this.btnInvoeren_Click);
            // 
            // lblAantal
            // 
            this.lblAantal.AutoSize = true;
            this.lblAantal.Location = new System.Drawing.Point(204, 27);
            this.lblAantal.Name = "lblAantal";
            this.lblAantal.Size = new System.Drawing.Size(13, 13);
            this.lblAantal.TabIndex = 5;
            this.lblAantal.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 245);
            this.Controls.Add(this.lblAantal);
            this.Controls.Add(this.btnInvoeren);
            this.Controls.Add(this.lblGeboorteDatum);
            this.Controls.Add(this.btnKinderBijslag);
            this.Controls.Add(this.tbKinderBijslag);
            this.Controls.Add(this.tbGeboorteDatum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGeboorteDatum;
        private System.Windows.Forms.TextBox tbKinderBijslag;
        private System.Windows.Forms.Button btnKinderBijslag;
        private System.Windows.Forms.Label lblGeboorteDatum;
        private System.Windows.Forms.Button btnInvoeren;
        private System.Windows.Forms.Label lblAantal;
    }
}

