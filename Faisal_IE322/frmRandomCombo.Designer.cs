namespace Faisal_IE322
{
    partial class frmRandomCombo
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
            this.GrpQuizAAF = new System.Windows.Forms.GroupBox();
            this.RdoGreaterthan500 = new System.Windows.Forms.RadioButton();
            this.RdoLessthan500 = new System.Windows.Forms.RadioButton();
            this.BtnReset1 = new System.Windows.Forms.Button();
            this.BtnGenerate1 = new System.Windows.Forms.Button();
            this.CmbRandom1 = new System.Windows.Forms.ComboBox();
            this.GrpQuizEAF = new System.Windows.Forms.GroupBox();
            this.LblCount = new System.Windows.Forms.Label();
            this.RdoGreaterthan50 = new System.Windows.Forms.RadioButton();
            this.RdoLessthan50 = new System.Windows.Forms.RadioButton();
            this.BtnReset2 = new System.Windows.Forms.Button();
            this.CmbRandom2 = new System.Windows.Forms.ComboBox();
            this.BtnGenerate2 = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.GrpQuizAAF.SuspendLayout();
            this.GrpQuizEAF.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpQuizAAF
            // 
            this.GrpQuizAAF.Controls.Add(this.RdoGreaterthan500);
            this.GrpQuizAAF.Controls.Add(this.RdoLessthan500);
            this.GrpQuizAAF.Controls.Add(this.BtnReset1);
            this.GrpQuizAAF.Controls.Add(this.BtnGenerate1);
            this.GrpQuizAAF.Controls.Add(this.CmbRandom1);
            this.GrpQuizAAF.Location = new System.Drawing.Point(35, 57);
            this.GrpQuizAAF.Name = "GrpQuizAAF";
            this.GrpQuizAAF.Size = new System.Drawing.Size(248, 198);
            this.GrpQuizAAF.TabIndex = 0;
            this.GrpQuizAAF.TabStop = false;
            this.GrpQuizAAF.Text = "Quiz03_AAF19";
            // 
            // RdoGreaterthan500
            // 
            this.RdoGreaterthan500.AutoSize = true;
            this.RdoGreaterthan500.Location = new System.Drawing.Point(133, 107);
            this.RdoGreaterthan500.Name = "RdoGreaterthan500";
            this.RdoGreaterthan500.Size = new System.Drawing.Size(105, 17);
            this.RdoGreaterthan500.TabIndex = 2;
            this.RdoGreaterthan500.TabStop = true;
            this.RdoGreaterthan500.Text = "Greater than 500";
            this.RdoGreaterthan500.UseVisualStyleBackColor = true;
            // 
            // RdoLessthan500
            // 
            this.RdoLessthan500.AutoSize = true;
            this.RdoLessthan500.Location = new System.Drawing.Point(133, 84);
            this.RdoLessthan500.Name = "RdoLessthan500";
            this.RdoLessthan500.Size = new System.Drawing.Size(92, 17);
            this.RdoLessthan500.TabIndex = 3;
            this.RdoLessthan500.TabStop = true;
            this.RdoLessthan500.Text = "Less than 500";
            this.RdoLessthan500.UseVisualStyleBackColor = true;
            // 
            // BtnReset1
            // 
            this.BtnReset1.Location = new System.Drawing.Point(133, 130);
            this.BtnReset1.Name = "BtnReset1";
            this.BtnReset1.Size = new System.Drawing.Size(75, 30);
            this.BtnReset1.TabIndex = 3;
            this.BtnReset1.Text = "Reset";
            this.BtnReset1.UseVisualStyleBackColor = true;
            // 
            // BtnGenerate1
            // 
            this.BtnGenerate1.Location = new System.Drawing.Point(133, 39);
            this.BtnGenerate1.Name = "BtnGenerate1";
            this.BtnGenerate1.Size = new System.Drawing.Size(92, 29);
            this.BtnGenerate1.TabIndex = 5;
            this.BtnGenerate1.Text = "Generate";
            this.BtnGenerate1.UseVisualStyleBackColor = true;
            this.BtnGenerate1.Click += new System.EventHandler(this.BtnGenerate1_Click);
            // 
            // CmbRandom1
            // 
            this.CmbRandom1.FormattingEnabled = true;
            this.CmbRandom1.Location = new System.Drawing.Point(6, 44);
            this.CmbRandom1.Name = "CmbRandom1";
            this.CmbRandom1.Size = new System.Drawing.Size(112, 21);
            this.CmbRandom1.TabIndex = 5;
            // 
            // GrpQuizEAF
            // 
            this.GrpQuizEAF.Controls.Add(this.LblCount);
            this.GrpQuizEAF.Controls.Add(this.RdoGreaterthan50);
            this.GrpQuizEAF.Controls.Add(this.RdoLessthan50);
            this.GrpQuizEAF.Controls.Add(this.BtnReset2);
            this.GrpQuizEAF.Controls.Add(this.CmbRandom2);
            this.GrpQuizEAF.Controls.Add(this.BtnGenerate2);
            this.GrpQuizEAF.Location = new System.Drawing.Point(309, 57);
            this.GrpQuizEAF.Name = "GrpQuizEAF";
            this.GrpQuizEAF.Size = new System.Drawing.Size(249, 198);
            this.GrpQuizEAF.TabIndex = 0;
            this.GrpQuizEAF.TabStop = false;
            this.GrpQuizEAF.Text = "Quiz03_EAF19";
            this.GrpQuizEAF.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Location = new System.Drawing.Point(6, 84);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(38, 13);
            this.LblCount.TabIndex = 2;
            this.LblCount.Text = "Count:";
            // 
            // RdoGreaterthan50
            // 
            this.RdoGreaterthan50.AutoSize = true;
            this.RdoGreaterthan50.Location = new System.Drawing.Point(135, 107);
            this.RdoGreaterthan50.Name = "RdoGreaterthan50";
            this.RdoGreaterthan50.Size = new System.Drawing.Size(99, 17);
            this.RdoGreaterthan50.TabIndex = 2;
            this.RdoGreaterthan50.TabStop = true;
            this.RdoGreaterthan50.Text = "Greater than 50";
            this.RdoGreaterthan50.UseVisualStyleBackColor = true;
            // 
            // RdoLessthan50
            // 
            this.RdoLessthan50.AutoSize = true;
            this.RdoLessthan50.Location = new System.Drawing.Point(135, 84);
            this.RdoLessthan50.Name = "RdoLessthan50";
            this.RdoLessthan50.Size = new System.Drawing.Size(86, 17);
            this.RdoLessthan50.TabIndex = 3;
            this.RdoLessthan50.TabStop = true;
            this.RdoLessthan50.Text = "Less than 50";
            this.RdoLessthan50.UseVisualStyleBackColor = true;
            // 
            // BtnReset2
            // 
            this.BtnReset2.Location = new System.Drawing.Point(135, 130);
            this.BtnReset2.Name = "BtnReset2";
            this.BtnReset2.Size = new System.Drawing.Size(75, 30);
            this.BtnReset2.TabIndex = 2;
            this.BtnReset2.Text = "Reset";
            this.BtnReset2.UseVisualStyleBackColor = true;
            this.BtnReset2.Click += new System.EventHandler(this.BtnReset2_Click);
            // 
            // CmbRandom2
            // 
            this.CmbRandom2.FormattingEnabled = true;
            this.CmbRandom2.Location = new System.Drawing.Point(6, 44);
            this.CmbRandom2.Name = "CmbRandom2";
            this.CmbRandom2.Size = new System.Drawing.Size(112, 21);
            this.CmbRandom2.TabIndex = 6;
            // 
            // BtnGenerate2
            // 
            this.BtnGenerate2.Location = new System.Drawing.Point(135, 39);
            this.BtnGenerate2.Name = "BtnGenerate2";
            this.BtnGenerate2.Size = new System.Drawing.Size(92, 29);
            this.BtnGenerate2.TabIndex = 4;
            this.BtnGenerate2.Text = "Generate";
            this.BtnGenerate2.UseVisualStyleBackColor = true;
            this.BtnGenerate2.Click += new System.EventHandler(this.BtnGenerate2_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(427, 330);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // frmRandomCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 402);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.GrpQuizEAF);
            this.Controls.Add(this.GrpQuizAAF);
            this.Name = "frmRandomCombo";
            this.Text = "frmRandomCombo";
            this.GrpQuizAAF.ResumeLayout(false);
            this.GrpQuizAAF.PerformLayout();
            this.GrpQuizEAF.ResumeLayout(false);
            this.GrpQuizEAF.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpQuizAAF;
        private System.Windows.Forms.GroupBox GrpQuizEAF;
        private System.Windows.Forms.RadioButton RdoGreaterthan500;
        private System.Windows.Forms.RadioButton RdoLessthan500;
        private System.Windows.Forms.Button BtnReset1;
        private System.Windows.Forms.Button BtnGenerate1;
        private System.Windows.Forms.ComboBox CmbRandom1;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.RadioButton RdoGreaterthan50;
        private System.Windows.Forms.RadioButton RdoLessthan50;
        private System.Windows.Forms.Button BtnReset2;
        private System.Windows.Forms.ComboBox CmbRandom2;
        private System.Windows.Forms.Button BtnGenerate2;
        private System.Windows.Forms.Button BtnBack;
    }
}