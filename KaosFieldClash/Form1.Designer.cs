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
			this.pbPlateau = new System.Windows.Forms.PictureBox();
			this.pbDe = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbPlateau)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbDe)).BeginInit();
			this.SuspendLayout();
			// 
			// pbPlateau
			// 
			this.pbPlateau.Image = global::KaosFieldClash.Properties.Resources.plateauKFC;
			this.pbPlateau.Location = new System.Drawing.Point(-3, -1);
			this.pbPlateau.Name = "pbPlateau";
			this.pbPlateau.Size = new System.Drawing.Size(940, 519);
			this.pbPlateau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbPlateau.TabIndex = 0;
			this.pbPlateau.TabStop = false;
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
			this.ClientSize = new System.Drawing.Size(936, 518);
			this.Controls.Add(this.pbDe);
			this.Controls.Add(this.pbPlateau);
			this.Name = "Form1";
			this.Text = "KaosFieldClash";
			((System.ComponentModel.ISupportInitialize)(this.pbPlateau)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbDe)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.PictureBox pbPlateau;
		private System.Windows.Forms.PictureBox pbDe;
	}
}

