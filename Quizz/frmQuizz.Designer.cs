﻿using System;
using System.Windows.Forms;

namespace Quizz
{
    partial class frmQuizz
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtPseudo;
        private TextBox txtPassword;
        private Button cmdAjouterLePseudo;
        private Button cmdSignUp;
        private ListBox lstClassement;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtPseudo = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmdAjouterLePseudo = new System.Windows.Forms.Button();
            this.cmdSignUp = new System.Windows.Forms.Button();
            this.lstClassement = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPseudo
            // 
            this.txtPseudo.Location = new System.Drawing.Point(378, 26);
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.Size = new System.Drawing.Size(100, 22);
            this.txtPseudo.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(378, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // cmdAjouterLePseudo
            // 
            this.cmdAjouterLePseudo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdAjouterLePseudo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAjouterLePseudo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdAjouterLePseudo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAjouterLePseudo.Location = new System.Drawing.Point(270, 219);
            this.cmdAjouterLePseudo.Name = "cmdAjouterLePseudo";
            this.cmdAjouterLePseudo.Size = new System.Drawing.Size(208, 35);
            this.cmdAjouterLePseudo.TabIndex = 2;
            this.cmdAjouterLePseudo.Text = "Jouer";
            this.cmdAjouterLePseudo.UseVisualStyleBackColor = false;
            // 
            // cmdSignUp
            // 
            this.cmdSignUp.BackColor = System.Drawing.Color.Lime;
            this.cmdSignUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdSignUp.Location = new System.Drawing.Point(270, 111);
            this.cmdSignUp.Name = "cmdSignUp";
            this.cmdSignUp.Size = new System.Drawing.Size(208, 35);
            this.cmdSignUp.TabIndex = 3;
            this.cmdSignUp.Text = "Créer Compte";
            this.cmdSignUp.UseVisualStyleBackColor = false;
            this.cmdSignUp.Click += new System.EventHandler(this.cmdAjouterLePseudo_Click);
            // 
            // lstClassement
            // 
            this.lstClassement.ItemHeight = 16;
            this.lstClassement.Location = new System.Drawing.Point(31, 26);
            this.lstClassement.Name = "lstClassement";
            this.lstClassement.Size = new System.Drawing.Size(177, 228);
            this.lstClassement.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "PSEUDO";
            this.label1.Click += new System.EventHandler(this.cmdAjouterLePseudo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "PASSWORD";
            // 
            // frmQuizz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 279);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPseudo);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cmdAjouterLePseudo);
            this.Controls.Add(this.cmdSignUp);
            this.Controls.Add(this.lstClassement);
            this.Name = "frmQuizz";
            this.Text = "Quizz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
        private Label label2;
    }
}

