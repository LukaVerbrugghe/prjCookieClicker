namespace prjCookieClicker
{
    partial class frmCockieClicker
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picCock = new System.Windows.Forms.PictureBox();
            this.lblAantalKinderen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCock)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prjCookieClicker.Properties.Resources.child;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // picCock
            // 
            this.picCock.Image = global::prjCookieClicker.Properties.Resources.cock;
            this.picCock.Location = new System.Drawing.Point(12, 49);
            this.picCock.Name = "picCock";
            this.picCock.Size = new System.Drawing.Size(250, 250);
            this.picCock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCock.TabIndex = 0;
            this.picCock.TabStop = false;
            this.picCock.Click += new System.EventHandler(this.picCock_Click);
            // 
            // lblAantalKinderen
            // 
            this.lblAantalKinderen.AutoSize = true;
            this.lblAantalKinderen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAantalKinderen.Location = new System.Drawing.Point(54, 19);
            this.lblAantalKinderen.Name = "lblAantalKinderen";
            this.lblAantalKinderen.Size = new System.Drawing.Size(162, 24);
            this.lblAantalKinderen.TabIndex = 2;
            this.lblAantalKinderen.Text = "Aantal kinderen:";
            // 
            // frmCockieClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAantalKinderen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picCock);
            this.Name = "frmCockieClicker";
            this.Text = "Cock Clicker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAantalKinderen;
    }
}

