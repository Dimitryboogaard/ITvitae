namespace Morse_code
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
            this.btnMaakMorseCode = new System.Windows.Forms.Button();
            this.rtTekst = new System.Windows.Forms.RichTextBox();
            this.btnMaakGewoneTekst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMaakMorseCode
            // 
            this.btnMaakMorseCode.Location = new System.Drawing.Point(24, 224);
            this.btnMaakMorseCode.Name = "btnMaakMorseCode";
            this.btnMaakMorseCode.Size = new System.Drawing.Size(131, 23);
            this.btnMaakMorseCode.TabIndex = 0;
            this.btnMaakMorseCode.Text = "Maak Morse code";
            this.btnMaakMorseCode.UseVisualStyleBackColor = true;
            this.btnMaakMorseCode.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtTekst
            // 
            this.rtTekst.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtTekst.Location = new System.Drawing.Point(24, 12);
            this.rtTekst.Name = "rtTekst";
            this.rtTekst.Size = new System.Drawing.Size(281, 186);
            this.rtTekst.TabIndex = 1;
            this.rtTekst.Text = "";
            // 
            // btnMaakGewoneTekst
            // 
            this.btnMaakGewoneTekst.Location = new System.Drawing.Point(168, 224);
            this.btnMaakGewoneTekst.Name = "btnMaakGewoneTekst";
            this.btnMaakGewoneTekst.Size = new System.Drawing.Size(137, 23);
            this.btnMaakGewoneTekst.TabIndex = 2;
            this.btnMaakGewoneTekst.Text = "Maak gewone tekst";
            this.btnMaakGewoneTekst.UseVisualStyleBackColor = true;
            this.btnMaakGewoneTekst.Click += new System.EventHandler(this.btnMaakGewoneTekst_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 267);
            this.Controls.Add(this.btnMaakGewoneTekst);
            this.Controls.Add(this.rtTekst);
            this.Controls.Add(this.btnMaakMorseCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMaakMorseCode;
        private System.Windows.Forms.RichTextBox rtTekst;
        private System.Windows.Forms.Button btnMaakGewoneTekst;
    }
}

