namespace Romeinse_rekenmachine
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
            this.btnI = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMaal = new System.Windows.Forms.Button();
            this.btnDeel = new System.Windows.Forms.Button();
            this.btnIs = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnI
            // 
            this.btnI.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI.Location = new System.Drawing.Point(12, 108);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(50, 50);
            this.btnI.TabIndex = 1;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = true;
            this.btnI.Click += new System.EventHandler(this.btnI_Click);
            // 
            // btnV
            // 
            this.btnV.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV.Location = new System.Drawing.Point(68, 108);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(50, 50);
            this.btnV.TabIndex = 2;
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = true;
            this.btnV.Click += new System.EventHandler(this.btnV_Click);
            // 
            // btnX
            // 
            this.btnX.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(124, 108);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(50, 50);
            this.btnX.TabIndex = 3;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnL
            // 
            this.btnL.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.Location = new System.Drawing.Point(12, 164);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(50, 50);
            this.btnL.TabIndex = 4;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(68, 164);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(50, 50);
            this.btnC.TabIndex = 5;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(124, 164);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(50, 50);
            this.btnD.TabIndex = 6;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnM
            // 
            this.btnM.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.Location = new System.Drawing.Point(68, 220);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(50, 50);
            this.btnM.TabIndex = 7;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Font = new System.Drawing.Font("Arial", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDisplay.Location = new System.Drawing.Point(12, 18);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbDisplay.Size = new System.Drawing.Size(330, 59);
            this.rtbDisplay.TabIndex = 8;
            this.rtbDisplay.Text = " ";
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(236, 108);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(50, 50);
            this.btnPlus.TabIndex = 9;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMin
            // 
            this.btnMin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(292, 108);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(50, 50);
            this.btnMin.TabIndex = 10;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMaal
            // 
            this.btnMaal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaal.Location = new System.Drawing.Point(236, 164);
            this.btnMaal.Name = "btnMaal";
            this.btnMaal.Size = new System.Drawing.Size(50, 50);
            this.btnMaal.TabIndex = 11;
            this.btnMaal.Text = "X";
            this.btnMaal.UseVisualStyleBackColor = true;
            this.btnMaal.Click += new System.EventHandler(this.btnMaal_Click);
            // 
            // btnDeel
            // 
            this.btnDeel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeel.Location = new System.Drawing.Point(292, 164);
            this.btnDeel.Name = "btnDeel";
            this.btnDeel.Size = new System.Drawing.Size(50, 50);
            this.btnDeel.TabIndex = 12;
            this.btnDeel.Text = ":";
            this.btnDeel.UseVisualStyleBackColor = true;
            this.btnDeel.Click += new System.EventHandler(this.btnDeel_Click);
            // 
            // btnIs
            // 
            this.btnIs.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIs.Location = new System.Drawing.Point(292, 220);
            this.btnIs.Name = "btnIs";
            this.btnIs.Size = new System.Drawing.Size(50, 50);
            this.btnIs.TabIndex = 13;
            this.btnIs.Text = "=";
            this.btnIs.UseVisualStyleBackColor = true;
            this.btnIs.Click += new System.EventHandler(this.btnIs_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(236, 220);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 50);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 282);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnIs);
            this.Controls.Add(this.btnDeel);
            this.Controls.Add(this.btnMaal);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.btnI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMaal;
        private System.Windows.Forms.Button btnDeel;
        private System.Windows.Forms.Button btnIs;
        private System.Windows.Forms.Button btnClear;
    }
}

