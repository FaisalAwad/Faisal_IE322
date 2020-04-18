namespace Faisal_IE322
{
    partial class frmRandom
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
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.BtnRandomNumber = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.LblRgb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(29, 25);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(243, 51);
            this.BtnGenerate.TabIndex = 0;
            this.BtnGenerate.Text = "Generate Random Color";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // BtnRandomNumber
            // 
            this.BtnRandomNumber.Location = new System.Drawing.Point(29, 172);
            this.BtnRandomNumber.Name = "BtnRandomNumber";
            this.BtnRandomNumber.Size = new System.Drawing.Size(124, 36);
            this.BtnRandomNumber.TabIndex = 1;
            this.BtnRandomNumber.Text = "Random Number";
            this.BtnRandomNumber.UseVisualStyleBackColor = true;
            this.BtnRandomNumber.Click += new System.EventHandler(this.BtnRandomNumber_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(214, 239);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LblRgb
            // 
            this.LblRgb.AutoSize = true;
            this.LblRgb.Location = new System.Drawing.Point(131, 88);
            this.LblRgb.Name = "LblRgb";
            this.LblRgb.Size = new System.Drawing.Size(28, 13);
            this.LblRgb.TabIndex = 3;
            this.LblRgb.Text = "r-g-b";
            // 
            // frmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 274);
            this.Controls.Add(this.LblRgb);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnRandomNumber);
            this.Controls.Add(this.BtnGenerate);
            this.Name = "frmRandom";
            this.Text = "frmRandom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Button BtnRandomNumber;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label LblRgb;
    }
}