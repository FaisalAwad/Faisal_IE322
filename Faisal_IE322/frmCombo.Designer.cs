namespace Faisal_IE322
{
    partial class frmCombo
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
            this.BtnShowSelectedMethod1 = new System.Windows.Forms.Button();
            this.BtnShowSelectedMethod2 = new System.Windows.Forms.Button();
            this.BtnRemove2ndlastitem = new System.Windows.Forms.Button();
            this.BtnRemovelastitem = new System.Windows.Forms.Button();
            this.BtnRemovebyIndex = new System.Windows.Forms.Button();
            this.BtnRemovebyName = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.LblDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnShowSelectedMethod1
            // 
            this.BtnShowSelectedMethod1.Location = new System.Drawing.Point(23, 12);
            this.BtnShowSelectedMethod1.Name = "BtnShowSelectedMethod1";
            this.BtnShowSelectedMethod1.Size = new System.Drawing.Size(99, 43);
            this.BtnShowSelectedMethod1.TabIndex = 0;
            this.BtnShowSelectedMethod1.Text = "Show Selected Method1";
            this.BtnShowSelectedMethod1.UseVisualStyleBackColor = true;
            this.BtnShowSelectedMethod1.Click += new System.EventHandler(this.BtnShowSelectedMethod1_Click);
            // 
            // BtnShowSelectedMethod2
            // 
            this.BtnShowSelectedMethod2.Location = new System.Drawing.Point(143, 12);
            this.BtnShowSelectedMethod2.Name = "BtnShowSelectedMethod2";
            this.BtnShowSelectedMethod2.Size = new System.Drawing.Size(99, 43);
            this.BtnShowSelectedMethod2.TabIndex = 1;
            this.BtnShowSelectedMethod2.Text = "Show Selected Method2";
            this.BtnShowSelectedMethod2.UseVisualStyleBackColor = true;
            // 
            // BtnRemove2ndlastitem
            // 
            this.BtnRemove2ndlastitem.Location = new System.Drawing.Point(339, 144);
            this.BtnRemove2ndlastitem.Name = "BtnRemove2ndlastitem";
            this.BtnRemove2ndlastitem.Size = new System.Drawing.Size(94, 80);
            this.BtnRemove2ndlastitem.TabIndex = 2;
            this.BtnRemove2ndlastitem.Text = "Remove 2nd last item";
            this.BtnRemove2ndlastitem.UseVisualStyleBackColor = true;
            this.BtnRemove2ndlastitem.Click += new System.EventHandler(this.BtnRemove2ndlastitem_Click);
            // 
            // BtnRemovelastitem
            // 
            this.BtnRemovelastitem.Location = new System.Drawing.Point(339, 58);
            this.BtnRemovelastitem.Name = "BtnRemovelastitem";
            this.BtnRemovelastitem.Size = new System.Drawing.Size(94, 80);
            this.BtnRemovelastitem.TabIndex = 3;
            this.BtnRemovelastitem.Text = "Remove last item";
            this.BtnRemovelastitem.UseVisualStyleBackColor = true;
            this.BtnRemovelastitem.Click += new System.EventHandler(this.BtnRemovelastitem_Click);
            // 
            // BtnRemovebyIndex
            // 
            this.BtnRemovebyIndex.Location = new System.Drawing.Point(34, 249);
            this.BtnRemovebyIndex.Name = "BtnRemovebyIndex";
            this.BtnRemovebyIndex.Size = new System.Drawing.Size(84, 46);
            this.BtnRemovebyIndex.TabIndex = 4;
            this.BtnRemovebyIndex.Text = "Remove by Index";
            this.BtnRemovebyIndex.UseVisualStyleBackColor = true;
            this.BtnRemovebyIndex.Click += new System.EventHandler(this.BtnRemovebyIndex_Click);
            // 
            // BtnRemovebyName
            // 
            this.BtnRemovebyName.Location = new System.Drawing.Point(158, 249);
            this.BtnRemovebyName.Name = "BtnRemovebyName";
            this.BtnRemovebyName.Size = new System.Drawing.Size(84, 46);
            this.BtnRemovebyName.TabIndex = 5;
            this.BtnRemovebyName.Text = "Remove by Name";
            this.BtnRemovebyName.UseVisualStyleBackColor = true;
            this.BtnRemovebyName.Click += new System.EventHandler(this.BtnRemovebyName_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(339, 319);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 6;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(76, 94);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(149, 21);
            this.CmbDays.TabIndex = 7;
            // 
            // LblDays
            // 
            this.LblDays.AutoSize = true;
            this.LblDays.Location = new System.Drawing.Point(20, 97);
            this.LblDays.Name = "LblDays";
            this.LblDays.Size = new System.Drawing.Size(34, 13);
            this.LblDays.TabIndex = 8;
            this.LblDays.Text = "Days:";
            // 
            // frmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 365);
            this.Controls.Add(this.LblDays);
            this.Controls.Add(this.CmbDays);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnRemovebyName);
            this.Controls.Add(this.BtnRemovebyIndex);
            this.Controls.Add(this.BtnRemovelastitem);
            this.Controls.Add(this.BtnRemove2ndlastitem);
            this.Controls.Add(this.BtnShowSelectedMethod2);
            this.Controls.Add(this.BtnShowSelectedMethod1);
            this.Name = "frmCombo";
            this.Text = "frmCombo";
            this.Load += new System.EventHandler(this.frmCombo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnShowSelectedMethod1;
        private System.Windows.Forms.Button BtnShowSelectedMethod2;
        private System.Windows.Forms.Button BtnRemove2ndlastitem;
        private System.Windows.Forms.Button BtnRemovelastitem;
        private System.Windows.Forms.Button BtnRemovebyIndex;
        private System.Windows.Forms.Button BtnRemovebyName;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.Label LblDays;
    }
}