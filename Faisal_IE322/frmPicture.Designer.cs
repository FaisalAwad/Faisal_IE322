namespace Faisal_IE322
{
    partial class frmPicture
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
            this.PicTry = new System.Windows.Forms.PictureBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnLoadimage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicTry)).BeginInit();
            this.SuspendLayout();
            // 
            // PicTry
            // 
            this.PicTry.Location = new System.Drawing.Point(33, 73);
            this.PicTry.Name = "PicTry";
            this.PicTry.Size = new System.Drawing.Size(296, 154);
            this.PicTry.TabIndex = 0;
            this.PicTry.TabStop = false;
            this.PicTry.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(274, 255);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click_1);
            // 
            // BtnLoadimage
            // 
            this.BtnLoadimage.Location = new System.Drawing.Point(33, 12);
            this.BtnLoadimage.Name = "BtnLoadimage";
            this.BtnLoadimage.Size = new System.Drawing.Size(75, 46);
            this.BtnLoadimage.TabIndex = 2;
            this.BtnLoadimage.Text = "Load Image";
            this.BtnLoadimage.UseVisualStyleBackColor = true;
            this.BtnLoadimage.Click += new System.EventHandler(this.BtnLoadimage_Click);
            // 
            // frmPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 290);
            this.Controls.Add(this.BtnLoadimage);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.PicTry);
            this.Name = "frmPicture";
            this.Text = "frmPicture";
            ((System.ComponentModel.ISupportInitialize)(this.PicTry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicTry;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnLoadimage;
    }
}