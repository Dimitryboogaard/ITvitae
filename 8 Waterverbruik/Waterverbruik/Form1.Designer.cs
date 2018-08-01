namespace Waterverbruik
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
            this.rbTarief1 = new System.Windows.Forms.RadioButton();
            this.rbTarief2 = new System.Windows.Forms.RadioButton();
            this.rbTarief0 = new System.Windows.Forms.RadioButton();
            this.tbVerbruik = new System.Windows.Forms.TextBox();
            this.lblVerbruik = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrijs = new System.Windows.Forms.Button();
            this.tbPrijs = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbTarief1
            // 
            this.rbTarief1.AutoSize = true;
            this.rbTarief1.Location = new System.Drawing.Point(5, 4);
            this.rbTarief1.Name = "rbTarief1";
            this.rbTarief1.Size = new System.Drawing.Size(61, 17);
            this.rbTarief1.TabIndex = 0;
            this.rbTarief1.TabStop = true;
            this.rbTarief1.Text = "Tarief 1";
            this.rbTarief1.UseVisualStyleBackColor = true;
            // 
            // rbTarief2
            // 
            this.rbTarief2.AutoSize = true;
            this.rbTarief2.Location = new System.Drawing.Point(5, 27);
            this.rbTarief2.Name = "rbTarief2";
            this.rbTarief2.Size = new System.Drawing.Size(61, 17);
            this.rbTarief2.TabIndex = 1;
            this.rbTarief2.TabStop = true;
            this.rbTarief2.Text = "Tarief 2";
            this.rbTarief2.UseVisualStyleBackColor = true;
            // 
            // rbTarief0
            // 
            this.rbTarief0.AutoSize = true;
            this.rbTarief0.Location = new System.Drawing.Point(5, 50);
            this.rbTarief0.Name = "rbTarief0";
            this.rbTarief0.Size = new System.Drawing.Size(61, 17);
            this.rbTarief0.TabIndex = 2;
            this.rbTarief0.TabStop = true;
            this.rbTarief0.Text = "Tarief 0";
            this.rbTarief0.UseVisualStyleBackColor = true;
            // 
            // tbVerbruik
            // 
            this.tbVerbruik.Location = new System.Drawing.Point(17, 114);
            this.tbVerbruik.Name = "tbVerbruik";
            this.tbVerbruik.Size = new System.Drawing.Size(61, 20);
            this.tbVerbruik.TabIndex = 3;
            // 
            // lblVerbruik
            // 
            this.lblVerbruik.AutoSize = true;
            this.lblVerbruik.Location = new System.Drawing.Point(84, 117);
            this.lblVerbruik.Name = "lblVerbruik";
            this.lblVerbruik.Size = new System.Drawing.Size(69, 13);
            this.lblVerbruik.TabIndex = 4;
            this.lblVerbruik.Text = "Verbruik (m3)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTarief0);
            this.groupBox1.Controls.Add(this.rbTarief2);
            this.groupBox1.Controls.Add(this.rbTarief1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 93);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnPrijs
            // 
            this.btnPrijs.Location = new System.Drawing.Point(17, 140);
            this.btnPrijs.Name = "btnPrijs";
            this.btnPrijs.Size = new System.Drawing.Size(61, 21);
            this.btnPrijs.TabIndex = 6;
            this.btnPrijs.Text = "Prijs";
            this.btnPrijs.UseVisualStyleBackColor = true;
            this.btnPrijs.Click += new System.EventHandler(this.btnPrijs_Click);
            // 
            // tbPrijs
            // 
            this.tbPrijs.Location = new System.Drawing.Point(18, 182);
            this.tbPrijs.Name = "tbPrijs";
            this.tbPrijs.Size = new System.Drawing.Size(60, 20);
            this.tbPrijs.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 244);
            this.Controls.Add(this.tbPrijs);
            this.Controls.Add(this.btnPrijs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblVerbruik);
            this.Controls.Add(this.tbVerbruik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbTarief1;
        private System.Windows.Forms.RadioButton rbTarief2;
        private System.Windows.Forms.RadioButton rbTarief0;
        private System.Windows.Forms.TextBox tbVerbruik;
        private System.Windows.Forms.Label lblVerbruik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrijs;
        private System.Windows.Forms.TextBox tbPrijs;
    }
}

