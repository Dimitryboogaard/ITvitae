namespace Glashandel
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
            this.tbAantalM2 = new System.Windows.Forms.TextBox();
            this.cbRestant = new System.Windows.Forms.CheckBox();
            this.lblRestant = new System.Windows.Forms.Label();
            this.lblAantalM2 = new System.Windows.Forms.Label();
            this.btnPrijs = new System.Windows.Forms.Button();
            this.tbPrijs = new System.Windows.Forms.TextBox();
            this.cbSpeciaalGlas = new System.Windows.Forms.CheckBox();
            this.lblSpeciaalGlas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAantalM2
            // 
            this.tbAantalM2.Location = new System.Drawing.Point(80, 22);
            this.tbAantalM2.Name = "tbAantalM2";
            this.tbAantalM2.Size = new System.Drawing.Size(100, 20);
            this.tbAantalM2.TabIndex = 0;
            // 
            // cbRestant
            // 
            this.cbRestant.AutoSize = true;
            this.cbRestant.Location = new System.Drawing.Point(80, 48);
            this.cbRestant.Name = "cbRestant";
            this.cbRestant.Size = new System.Drawing.Size(15, 14);
            this.cbRestant.TabIndex = 1;
            this.cbRestant.UseVisualStyleBackColor = true;
            // 
            // lblRestant
            // 
            this.lblRestant.AutoSize = true;
            this.lblRestant.Location = new System.Drawing.Point(30, 48);
            this.lblRestant.Name = "lblRestant";
            this.lblRestant.Size = new System.Drawing.Size(44, 13);
            this.lblRestant.TabIndex = 2;
            this.lblRestant.Text = "Restant";
            // 
            // lblAantalM2
            // 
            this.lblAantalM2.AutoSize = true;
            this.lblAantalM2.Location = new System.Drawing.Point(20, 25);
            this.lblAantalM2.Name = "lblAantalM2";
            this.lblAantalM2.Size = new System.Drawing.Size(54, 13);
            this.lblAantalM2.TabIndex = 3;
            this.lblAantalM2.Text = "Aantal m2";
            // 
            // btnPrijs
            // 
            this.btnPrijs.Location = new System.Drawing.Point(80, 108);
            this.btnPrijs.Name = "btnPrijs";
            this.btnPrijs.Size = new System.Drawing.Size(75, 23);
            this.btnPrijs.TabIndex = 4;
            this.btnPrijs.Text = "Prijs";
            this.btnPrijs.UseVisualStyleBackColor = true;
            this.btnPrijs.Click += new System.EventHandler(this.btnPrijs_Click);
            // 
            // tbPrijs
            // 
            this.tbPrijs.Location = new System.Drawing.Point(80, 137);
            this.tbPrijs.Name = "tbPrijs";
            this.tbPrijs.Size = new System.Drawing.Size(75, 20);
            this.tbPrijs.TabIndex = 5;
            // 
            // cbSpeciaalGlas
            // 
            this.cbSpeciaalGlas.AutoSize = true;
            this.cbSpeciaalGlas.Location = new System.Drawing.Point(80, 68);
            this.cbSpeciaalGlas.Name = "cbSpeciaalGlas";
            this.cbSpeciaalGlas.Size = new System.Drawing.Size(15, 14);
            this.cbSpeciaalGlas.TabIndex = 6;
            this.cbSpeciaalGlas.UseVisualStyleBackColor = true;
            // 
            // lblSpeciaalGlas
            // 
            this.lblSpeciaalGlas.AutoSize = true;
            this.lblSpeciaalGlas.Location = new System.Drawing.Point(4, 68);
            this.lblSpeciaalGlas.Name = "lblSpeciaalGlas";
            this.lblSpeciaalGlas.Size = new System.Drawing.Size(70, 13);
            this.lblSpeciaalGlas.TabIndex = 7;
            this.lblSpeciaalGlas.Text = "Speciaal glas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 235);
            this.Controls.Add(this.lblSpeciaalGlas);
            this.Controls.Add(this.cbSpeciaalGlas);
            this.Controls.Add(this.tbPrijs);
            this.Controls.Add(this.btnPrijs);
            this.Controls.Add(this.lblAantalM2);
            this.Controls.Add(this.lblRestant);
            this.Controls.Add(this.cbRestant);
            this.Controls.Add(this.tbAantalM2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAantalM2;
        private System.Windows.Forms.CheckBox cbRestant;
        private System.Windows.Forms.Label lblRestant;
        private System.Windows.Forms.Label lblAantalM2;
        private System.Windows.Forms.Button btnPrijs;
        private System.Windows.Forms.TextBox tbPrijs;
        private System.Windows.Forms.CheckBox cbSpeciaalGlas;
        private System.Windows.Forms.Label lblSpeciaalGlas;
    }
}

