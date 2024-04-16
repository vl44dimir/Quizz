namespace Quizz
{
    partial class frmQuizz
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
            this.txtPseudo = new System.Windows.Forms.TextBox();
            this.cmdAjouterLePseudo = new System.Windows.Forms.Button();
            this.cmdDebut = new System.Windows.Forms.Button();
            this.lstClassement = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtPseudo
            // 
            this.txtPseudo.Location = new System.Drawing.Point(574, 54);
            this.txtPseudo.Margin = new System.Windows.Forms.Padding(6);
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.Size = new System.Drawing.Size(196, 31);
            this.txtPseudo.TabIndex = 2;
            // 
            // cmdAjouterLePseudo
            // 
            this.cmdAjouterLePseudo.Location = new System.Drawing.Point(576, 137);
            this.cmdAjouterLePseudo.Margin = new System.Windows.Forms.Padding(6);
            this.cmdAjouterLePseudo.Name = "cmdAjouterLePseudo";
            this.cmdAjouterLePseudo.Size = new System.Drawing.Size(198, 67);
            this.cmdAjouterLePseudo.TabIndex = 3;
            this.cmdAjouterLePseudo.Text = "Ajouter le Pseudo";
            this.cmdAjouterLePseudo.UseVisualStyleBackColor = true;
            this.cmdAjouterLePseudo.Click += new System.EventHandler(this.cmdAjouterLePseudo_Click);
            // 
            // cmdDebut
            // 
            this.cmdDebut.Location = new System.Drawing.Point(508, 304);
            this.cmdDebut.Margin = new System.Windows.Forms.Padding(6);
            this.cmdDebut.Name = "cmdDebut";
            this.cmdDebut.Size = new System.Drawing.Size(324, 156);
            this.cmdDebut.TabIndex = 4;
            this.cmdDebut.Text = "Début du quizz";
            this.cmdDebut.UseVisualStyleBackColor = true;
            this.cmdDebut.Click += new System.EventHandler(this.cmdDebut_Click);
            // 
            // lstClassement
            // 
            this.lstClassement.FormattingEnabled = true;
            this.lstClassement.ItemHeight = 25;
            this.lstClassement.Location = new System.Drawing.Point(58, 27);
            this.lstClassement.Margin = new System.Windows.Forms.Padding(6);
            this.lstClassement.Name = "lstClassement";
            this.lstClassement.Size = new System.Drawing.Size(350, 429);
            this.lstClassement.TabIndex = 5;
            // 
            // frmQuizz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 755);
            this.Controls.Add(this.lstClassement);
            this.Controls.Add(this.cmdDebut);
            this.Controls.Add(this.cmdAjouterLePseudo);
            this.Controls.Add(this.txtPseudo);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmQuizz";
            this.Text = "Quizz";
            this.Load += new System.EventHandler(this.frmQuizz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPseudo;
        private System.Windows.Forms.Button cmdAjouterLePseudo;
        private System.Windows.Forms.Button cmdDebut;
        private System.Windows.Forms.ListBox lstClassement;
    }
}

