namespace IMC
{
    partial class IMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMC));
            this.textboxTaille = new System.Windows.Forms.TextBox();
            this.textboxPoids = new System.Windows.Forms.TextBox();
            this.buttonCalcul = new System.Windows.Forms.Button();
            this.labelTaille = new System.Windows.Forms.Label();
            this.labelPoids = new System.Windows.Forms.Label();
            this.labelResultat = new System.Windows.Forms.Label();
            this.pictureIMC = new System.Windows.Forms.PictureBox();
            this.labelTitre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIMC)).BeginInit();
            this.SuspendLayout();
            // 
            // textboxTaille
            // 
            this.textboxTaille.Location = new System.Drawing.Point(259, 118);
            this.textboxTaille.Name = "textboxTaille";
            this.textboxTaille.Size = new System.Drawing.Size(100, 20);
            this.textboxTaille.TabIndex = 0;
            // 
            // textboxPoids
            // 
            this.textboxPoids.Location = new System.Drawing.Point(259, 163);
            this.textboxPoids.Name = "textboxPoids";
            this.textboxPoids.Size = new System.Drawing.Size(100, 20);
            this.textboxPoids.TabIndex = 1;
            // 
            // buttonCalcul
            // 
            this.buttonCalcul.Location = new System.Drawing.Point(168, 199);
            this.buttonCalcul.Name = "buttonCalcul";
            this.buttonCalcul.Size = new System.Drawing.Size(100, 23);
            this.buttonCalcul.TabIndex = 2;
            this.buttonCalcul.Text = "calculer";
            this.buttonCalcul.UseVisualStyleBackColor = true;
            this.buttonCalcul.Click += new System.EventHandler(this.buttonCalcul_Click);
            // 
            // labelTaille
            // 
            this.labelTaille.AutoSize = true;
            this.labelTaille.Location = new System.Drawing.Point(59, 121);
            this.labelTaille.Name = "labelTaille";
            this.labelTaille.Size = new System.Drawing.Size(195, 13);
            this.labelTaille.TabIndex = 3;
            this.labelTaille.Text = "Entrez votre taille en cm (exemple : 170)";
            this.labelTaille.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPoids
            // 
            this.labelPoids.AutoSize = true;
            this.labelPoids.Location = new System.Drawing.Point(68, 166);
            this.labelPoids.Name = "labelPoids";
            this.labelPoids.Size = new System.Drawing.Size(185, 13);
            this.labelPoids.TabIndex = 4;
            this.labelPoids.Text = "Entrez votre poids en kg (exemple 70)";
            this.labelPoids.Click += new System.EventHandler(this.labelPoids_Click);
            // 
            // labelResultat
            // 
            this.labelResultat.AutoSize = true;
            this.labelResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultat.Location = new System.Drawing.Point(126, 237);
            this.labelResultat.Name = "labelResultat";
            this.labelResultat.Size = new System.Drawing.Size(196, 25);
            this.labelResultat.TabIndex = 5;
            this.labelResultat.Text = "Votre IMC est de 0.";
            // 
            // pictureIMC
            // 
            this.pictureIMC.Image = ((System.Drawing.Image)(resources.GetObject("pictureIMC.Image")));
            this.pictureIMC.Location = new System.Drawing.Point(365, 49);
            this.pictureIMC.Name = "pictureIMC";
            this.pictureIMC.Size = new System.Drawing.Size(423, 259);
            this.pictureIMC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureIMC.TabIndex = 6;
            this.pictureIMC.TabStop = false;
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(126, 65);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(196, 31);
            this.labelTitre.TabIndex = 7;
            this.labelTitre.Text = "Calcul d\'IMC :";
            // 
            // IMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 355);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.pictureIMC);
            this.Controls.Add(this.labelResultat);
            this.Controls.Add(this.labelPoids);
            this.Controls.Add(this.labelTaille);
            this.Controls.Add(this.buttonCalcul);
            this.Controls.Add(this.textboxPoids);
            this.Controls.Add(this.textboxTaille);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IMC";
            this.Text = "IMC";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureIMC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxTaille;
        private System.Windows.Forms.TextBox textboxPoids;
        private System.Windows.Forms.Button buttonCalcul;
        private System.Windows.Forms.Label labelTaille;
        private System.Windows.Forms.Label labelPoids;
        private System.Windows.Forms.Label labelResultat;
        private System.Windows.Forms.PictureBox pictureIMC;
        private System.Windows.Forms.Label labelTitre;
    }
}

