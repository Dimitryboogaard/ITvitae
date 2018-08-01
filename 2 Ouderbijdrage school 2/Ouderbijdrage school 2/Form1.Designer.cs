namespace Ouderbijdrage_school_2
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
            this.cbEenOuderGezin = new System.Windows.Forms.CheckBox();
            this.btnInvoeren = new System.Windows.Forms.Button();
            this.lblGeboorteDatum = new System.Windows.Forms.Label();
            this.lblEenOuderGezin = new System.Windows.Forms.Label();
            this.btnOuderBijdrage = new System.Windows.Forms.Button();
            this.tbOuderBijdrage = new System.Windows.Forms.TextBox();
            this.lblAantal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbGeboorteDatum
            // 
            this.tbGeboorteDatum.Location = new System.Drawing.Point(166, 12);
            this.tbGeboorteDatum.Name = "tbGeboorteDatum";
            this.tbGeboorteDatum.Size = new System.Drawing.Size(100, 20);
            this.tbGeboorteDatum.TabIndex = 0;
            // 
            // cbEenOuderGezin
            // 
            this.cbEenOuderGezin.AutoSize = true;
            this.cbEenOuderGezin.Location = new System.Drawing.Point(166, 38);
            this.cbEenOuderGezin.Name = "cbEenOuderGezin";
            this.cbEenOuderGezin.Size = new System.Drawing.Size(15, 14);
            this.cbEenOuderGezin.TabIndex = 1;
            this.cbEenOuderGezin.UseVisualStyleBackColor = true;
            // 
            // btnInvoeren
            // 
            this.btnInvoeren.Location = new System.Drawing.Point(166, 58);
            this.btnInvoeren.Name = "btnInvoeren";
            this.btnInvoeren.Size = new System.Drawing.Size(75, 23);
            this.btnInvoeren.TabIndex = 2;
            this.btnInvoeren.Text = "Invoeren";
            this.btnInvoeren.UseVisualStyleBackColor = true;
            this.btnInvoeren.Click += new System.EventHandler(this.btnInvoeren_Click);
            // 
            // lblGeboorteDatum
            // 
            this.lblGeboorteDatum.AutoSize = true;
            this.lblGeboorteDatum.Location = new System.Drawing.Point(16, 15);
            this.lblGeboorteDatum.Name = "lblGeboorteDatum";
            this.lblGeboorteDatum.Size = new System.Drawing.Size(147, 13);
            this.lblGeboorteDatum.TabIndex = 3;
            this.lblGeboorteDatum.Text = "Geboortedatum (dd/mm/yyyy)";
            // 
            // lblEenOuderGezin
            // 
            this.lblEenOuderGezin.AutoSize = true;
            this.lblEenOuderGezin.Location = new System.Drawing.Point(76, 39);
            this.lblEenOuderGezin.Name = "lblEenOuderGezin";
            this.lblEenOuderGezin.Size = new System.Drawing.Size(84, 13);
            this.lblEenOuderGezin.TabIndex = 4;
            this.lblEenOuderGezin.Text = "Eén ouder gezin";
            // 
            // btnOuderBijdrage
            // 
            this.btnOuderBijdrage.Location = new System.Drawing.Point(119, 125);
            this.btnOuderBijdrage.Name = "btnOuderBijdrage";
            this.btnOuderBijdrage.Size = new System.Drawing.Size(99, 23);
            this.btnOuderBijdrage.TabIndex = 5;
            this.btnOuderBijdrage.Text = "Ouderbijdrage";
            this.btnOuderBijdrage.UseVisualStyleBackColor = true;
            this.btnOuderBijdrage.Click += new System.EventHandler(this.btnOuderBijdrage_Click);
            // 
            // tbOuderBijdrage
            // 
            this.tbOuderBijdrage.Location = new System.Drawing.Point(119, 154);
            this.tbOuderBijdrage.Name = "tbOuderBijdrage";
            this.tbOuderBijdrage.Size = new System.Drawing.Size(100, 20);
            this.tbOuderBijdrage.TabIndex = 6;
            // 
            // lblAantal
            // 
            this.lblAantal.AutoSize = true;
            this.lblAantal.Location = new System.Drawing.Point(272, 12);
            this.lblAantal.Name = "lblAantal";
            this.lblAantal.Size = new System.Drawing.Size(37, 13);
            this.lblAantal.TabIndex = 7;
            this.lblAantal.Text = "Aantal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 198);
            this.Controls.Add(this.lblAantal);
            this.Controls.Add(this.tbOuderBijdrage);
            this.Controls.Add(this.btnOuderBijdrage);
            this.Controls.Add(this.lblEenOuderGezin);
            this.Controls.Add(this.lblGeboorteDatum);
            this.Controls.Add(this.btnInvoeren);
            this.Controls.Add(this.cbEenOuderGezin);
            this.Controls.Add(this.tbGeboorteDatum);
            this.Name = "Form1";
            this.Text = "Ouderbijdrage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGeboorteDatum;
        private System.Windows.Forms.CheckBox cbEenOuderGezin;
        private System.Windows.Forms.Button btnInvoeren;
        private System.Windows.Forms.Label lblGeboorteDatum;
        private System.Windows.Forms.Label lblEenOuderGezin;
        private System.Windows.Forms.Button btnOuderBijdrage;
        private System.Windows.Forms.TextBox tbOuderBijdrage;
        private System.Windows.Forms.Label lblAantal;
    }
}

