namespace KaosFieldClash
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
			this.Square0 = new System.Windows.Forms.FlowLayoutPanel();
			this.pbDe = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbDe)).BeginInit();
			this.SuspendLayout();
			// 
			// Square0
			// 
			this.Square0.BackColor = System.Drawing.Color.Transparent;
			this.Square0.BackgroundImage = global::KaosFieldClash.Properties.Resources.trans;
			this.Square0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Square0.ForeColor = System.Drawing.Color.Transparent;
			this.Square0.Location = new System.Drawing.Point(93, 426);
			this.Square0.Name = "Square0";
			this.Square0.Size = new System.Drawing.Size(82, 80);
			this.Square0.TabIndex = 2;
			// 
			// pbDe
			// 
			this.pbDe.Location = new System.Drawing.Point(774, 12);
			this.pbDe.Name = "pbDe";
			this.pbDe.Size = new System.Drawing.Size(150, 150);
			this.pbDe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbDe.TabIndex = 1;
			this.pbDe.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::KaosFieldClash.Properties.Resources.plateauKFC;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(936, 518);
			this.Controls.Add(this.Square0);
			this.Controls.Add(this.pbDe);
			this.Name = "Form1";
			this.Text = "KaosFieldClash";
			((System.ComponentModel.ISupportInitialize)(this.pbDe)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion
		private System.Windows.Forms.PictureBox pbDe;
		private System.Windows.Forms.FlowLayoutPanel Square0;
	}
}

