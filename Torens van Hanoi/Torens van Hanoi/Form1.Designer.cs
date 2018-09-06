namespace Torens_van_Hanoi
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
            this.rtLinks = new System.Windows.Forms.RichTextBox();
            this.rtMidden = new System.Windows.Forms.RichTextBox();
            this.rtRechts = new System.Windows.Forms.RichTextBox();
            this.btnLinks = new System.Windows.Forms.Button();
            this.btnMidden = new System.Windows.Forms.Button();
            this.btnRechts = new System.Windows.Forms.Button();
            this.lblCommentaar = new System.Windows.Forms.Label();
            this.btnOpnieuw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtLinks
            // 
            this.rtLinks.Enabled = false;
            this.rtLinks.Location = new System.Drawing.Point(91, 70);
            this.rtLinks.Name = "rtLinks";
            this.rtLinks.Size = new System.Drawing.Size(23, 122);
            this.rtLinks.TabIndex = 0;
            this.rtLinks.Text = "";
            // 
            // rtMidden
            // 
            this.rtMidden.Enabled = false;
            this.rtMidden.Location = new System.Drawing.Point(165, 70);
            this.rtMidden.Name = "rtMidden";
            this.rtMidden.Size = new System.Drawing.Size(23, 122);
            this.rtMidden.TabIndex = 1;
            this.rtMidden.Text = "";
            // 
            // rtRechts
            // 
            this.rtRechts.Enabled = false;
            this.rtRechts.Location = new System.Drawing.Point(244, 70);
            this.rtRechts.Name = "rtRechts";
            this.rtRechts.Size = new System.Drawing.Size(23, 122);
            this.rtRechts.TabIndex = 2;
            this.rtRechts.Text = "";
            // 
            // btnLinks
            // 
            this.btnLinks.Location = new System.Drawing.Point(91, 198);
            this.btnLinks.Name = "btnLinks";
            this.btnLinks.Size = new System.Drawing.Size(24, 24);
            this.btnLinks.TabIndex = 3;
            this.btnLinks.UseVisualStyleBackColor = true;
            this.btnLinks.Click += new System.EventHandler(this.btnLinks_Click);
            // 
            // btnMidden
            // 
            this.btnMidden.Location = new System.Drawing.Point(165, 198);
            this.btnMidden.Name = "btnMidden";
            this.btnMidden.Size = new System.Drawing.Size(24, 24);
            this.btnMidden.TabIndex = 4;
            this.btnMidden.UseVisualStyleBackColor = true;
            this.btnMidden.Click += new System.EventHandler(this.btnMidden_Click);
            // 
            // btnRechts
            // 
            this.btnRechts.Location = new System.Drawing.Point(244, 198);
            this.btnRechts.Name = "btnRechts";
            this.btnRechts.Size = new System.Drawing.Size(24, 24);
            this.btnRechts.TabIndex = 5;
            this.btnRechts.UseVisualStyleBackColor = true;
            this.btnRechts.Click += new System.EventHandler(this.btnRechts_Click_1);
            // 
            // lblCommentaar
            // 
            this.lblCommentaar.AutoSize = true;
            this.lblCommentaar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentaar.Location = new System.Drawing.Point(61, 35);
            this.lblCommentaar.Name = "lblCommentaar";
            this.lblCommentaar.Size = new System.Drawing.Size(0, 19);
            this.lblCommentaar.TabIndex = 7;
            // 
            // btnOpnieuw
            // 
            this.btnOpnieuw.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpnieuw.Location = new System.Drawing.Point(109, 249);
            this.btnOpnieuw.Name = "btnOpnieuw";
            this.btnOpnieuw.Size = new System.Drawing.Size(130, 37);
            this.btnOpnieuw.TabIndex = 8;
            this.btnOpnieuw.Text = "Opnieuw";
            this.btnOpnieuw.UseVisualStyleBackColor = true;
            this.btnOpnieuw.Visible = false;
            this.btnOpnieuw.Click += new System.EventHandler(this.btnOpnieuw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 307);
            this.Controls.Add(this.btnOpnieuw);
            this.Controls.Add(this.lblCommentaar);
            this.Controls.Add(this.btnRechts);
            this.Controls.Add(this.btnMidden);
            this.Controls.Add(this.btnLinks);
            this.Controls.Add(this.rtRechts);
            this.Controls.Add(this.rtMidden);
            this.Controls.Add(this.rtLinks);
            this.Name = "Form1";
            this.Text = "Torens van Hanoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtLinks;
        private System.Windows.Forms.RichTextBox rtMidden;
        private System.Windows.Forms.RichTextBox rtRechts;
        private System.Windows.Forms.Button btnLinks;
        private System.Windows.Forms.Button btnMidden;
        private System.Windows.Forms.Button btnRechts;
        private System.Windows.Forms.Label lblCommentaar;
        private System.Windows.Forms.Button btnOpnieuw;
    }
}

