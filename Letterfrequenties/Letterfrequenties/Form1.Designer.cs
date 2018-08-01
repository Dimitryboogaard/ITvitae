namespace Letterfrequenties
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
            this.rtbTekst = new System.Windows.Forms.RichTextBox();
            this.rtbLetterFrequenties = new System.Windows.Forms.RichTextBox();
            this.btnLetterFrequenties = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbTekst
            // 
            this.rtbTekst.Location = new System.Drawing.Point(39, 32);
            this.rtbTekst.Name = "rtbTekst";
            this.rtbTekst.Size = new System.Drawing.Size(266, 301);
            this.rtbTekst.TabIndex = 0;
            this.rtbTekst.Text = "";
            // 
            // rtbLetterFrequenties
            // 
            this.rtbLetterFrequenties.Location = new System.Drawing.Point(343, 32);
            this.rtbLetterFrequenties.Name = "rtbLetterFrequenties";
            this.rtbLetterFrequenties.Size = new System.Drawing.Size(113, 300);
            this.rtbLetterFrequenties.TabIndex = 1;
            this.rtbLetterFrequenties.Text = "";
            // 
            // btnLetterFrequenties
            // 
            this.btnLetterFrequenties.Location = new System.Drawing.Point(479, 185);
            this.btnLetterFrequenties.Name = "btnLetterFrequenties";
            this.btnLetterFrequenties.Size = new System.Drawing.Size(99, 23);
            this.btnLetterFrequenties.TabIndex = 2;
            this.btnLetterFrequenties.Text = "Letterfrequenties";
            this.btnLetterFrequenties.UseVisualStyleBackColor = true;
            this.btnLetterFrequenties.Click += new System.EventHandler(this.btnLetterFrequenties_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(597, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(180, 22);
            this.mnuOpen.Text = "Open";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 384);
            this.Controls.Add(this.btnLetterFrequenties);
            this.Controls.Add(this.rtbLetterFrequenties);
            this.Controls.Add(this.rtbTekst);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTekst;
        private System.Windows.Forms.RichTextBox rtbLetterFrequenties;
        private System.Windows.Forms.Button btnLetterFrequenties;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.OpenFileDialog openFD;
    }
}

