﻿namespace Quizz
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
            this.lstClassement = new System.Windows.Forms.ListBox();
            this.txtPseudo = new System.Windows.Forms.TextBox();
            this.cmdAjouterLePseudo = new System.Windows.Forms.Button();
            this.cmdDebut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstClassement
            // 
            this.lstClassement.FormattingEnabled = true;
            this.lstClassement.Location = new System.Drawing.Point(24, 16);
            this.lstClassement.Name = "lstClassement";
            this.lstClassement.Size = new System.Drawing.Size(150, 303);
            this.lstClassement.TabIndex = 0;
            // 
            // txtPseudo
            // 
            this.txtPseudo.Location = new System.Drawing.Point(282, 33);
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.Size = new System.Drawing.Size(100, 20);
            this.txtPseudo.TabIndex = 2;
            // 
            // cmdAjouterLePseudo
            // 
            this.cmdAjouterLePseudo.Location = new System.Drawing.Point(283, 76);
            this.cmdAjouterLePseudo.Name = "cmdAjouterLePseudo";
            this.cmdAjouterLePseudo.Size = new System.Drawing.Size(99, 35);
            this.cmdAjouterLePseudo.TabIndex = 3;
            this.cmdAjouterLePseudo.Text = "Ajouter le Pseudo";
            this.cmdAjouterLePseudo.UseVisualStyleBackColor = true;
            this.cmdAjouterLePseudo.Click += new System.EventHandler(this.cmdAjouterLePseudo_Click);
            // 
            // cmdDebut
            // 
            this.cmdDebut.Location = new System.Drawing.Point(249, 163);
            this.cmdDebut.Name = "cmdDebut";
            this.cmdDebut.Size = new System.Drawing.Size(162, 81);
            this.cmdDebut.TabIndex = 4;
            this.cmdDebut.Text = "Début du quizz";
            this.cmdDebut.UseVisualStyleBackColor = true;
            this.cmdDebut.Click += new System.EventHandler(this.cmdDebut_Click);
            // 
            // frmQuizz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 360);
            this.Controls.Add(this.cmdDebut);
            this.Controls.Add(this.cmdAjouterLePseudo);
            this.Controls.Add(this.txtPseudo);
            this.Controls.Add(this.lstClassement);
            this.Name = "frmQuizz";
            this.Text = "Quizz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstClassement;
        private System.Windows.Forms.TextBox txtPseudo;
        private System.Windows.Forms.Button cmdAjouterLePseudo;
        private System.Windows.Forms.Button cmdDebut;
    }
}
