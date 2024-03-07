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
            this.lblAantalKinderen = new System.Windows.Forms.Label();
            this.grbUpgrades = new System.Windows.Forms.GroupBox();
            this.lblUpgrade1VerdundKippenvoer = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picCock = new System.Windows.Forms.PictureBox();
            this.lblUpgrade1VerdundKippenvoerPrijs = new System.Windows.Forms.Label();
            this.grbUpgrades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCock)).BeginInit();
            this.SuspendLayout();
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
            // grbUpgrades
            // 
            this.grbUpgrades.Controls.Add(this.lblUpgrade1VerdundKippenvoerPrijs);
            this.grbUpgrades.Controls.Add(this.pictureBox2);
            this.grbUpgrades.Controls.Add(this.lblUpgrade1VerdundKippenvoer);
            this.grbUpgrades.Location = new System.Drawing.Point(489, 19);
            this.grbUpgrades.Name = "grbUpgrades";
            this.grbUpgrades.Size = new System.Drawing.Size(282, 410);
            this.grbUpgrades.TabIndex = 3;
            this.grbUpgrades.TabStop = false;
            this.grbUpgrades.Text = "Upgrades";
            // 
            // lblUpgrade1VerdundKippenvoer
            // 
            this.lblUpgrade1VerdundKippenvoer.AutoSize = true;
            this.lblUpgrade1VerdundKippenvoer.Location = new System.Drawing.Point(56, 20);
            this.lblUpgrade1VerdundKippenvoer.Name = "lblUpgrade1VerdundKippenvoer";
            this.lblUpgrade1VerdundKippenvoer.Size = new System.Drawing.Size(103, 13);
            this.lblUpgrade1VerdundKippenvoer.TabIndex = 0;
            this.lblUpgrade1VerdundKippenvoer.Text = "Verdund kippenvoer";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::prjCookieClicker.Properties.Resources.Kippenvoer;
            this.pictureBox2.Location = new System.Drawing.Point(12, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
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
            // lblUpgrade1VerdundKippenvoerPrijs
            // 
            this.lblUpgrade1VerdundKippenvoerPrijs.AutoSize = true;
            this.lblUpgrade1VerdundKippenvoerPrijs.Location = new System.Drawing.Point(59, 37);
            this.lblUpgrade1VerdundKippenvoerPrijs.Name = "lblUpgrade1VerdundKippenvoerPrijs";
            this.lblUpgrade1VerdundKippenvoerPrijs.Size = new System.Drawing.Size(88, 13);
            this.lblUpgrade1VerdundKippenvoerPrijs.TabIndex = 2;
            this.lblUpgrade1VerdundKippenvoerPrijs.Text = "Prijs: 15 kinderen";
            // 
            // frmCockieClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbUpgrades);
            this.Controls.Add(this.lblAantalKinderen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picCock);
            this.Name = "frmCockieClicker";
            this.Text = "Cock Clicker";
            this.grbUpgrades.ResumeLayout(false);
            this.grbUpgrades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAantalKinderen;
        private System.Windows.Forms.GroupBox grbUpgrades;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUpgrade1VerdundKippenvoer;
        private System.Windows.Forms.Label lblUpgrade1VerdundKippenvoerPrijs;
    }
}

