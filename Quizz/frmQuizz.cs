using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Quizz
{
    public partial class frmQuizz : Form
    {
        private Connection_mySQL connection;
        private Joueur joueur;

        public frmQuizz()
        {
            InitializeComponent();
            connection = new Connection_mySQL();
            joueur = new Joueur(); // Initialisation de l'objet joueur
        }

        private void cmdAjouterLePseudo_Click(object sender, EventArgs e)
        {
            string username = txtPseudo.Text.Trim();
            string password = txtPassword.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                if (!connection.UserExists(username))
                {
                    bool isAdded = connection.AddUser(username, password);
                    if (isAdded)
                    {
                        MessageBox.Show("Utilisateur ajouté avec succès !");
                        txtPseudo.Clear();
                        txtPassword.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de l'ajout de l'utilisateur.");
                    }
                }
                else
                {
                    MessageBox.Show("Un utilisateur avec ce pseudo existe déjà.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
            }
        }

        private void cmdDebut_Click(object sender, EventArgs e)
        {
            joueur.Pseudo = txtPseudo.Text; // Le pseudo est saisi ici
            frmQuestion question = new frmQuestion(joueur);
            question.ShowDialog();

            connection.UpdateScore(joueur.Pseudo, joueur.Score);
            txtPseudo.Text = "";
            List<Joueur> lstJoueur = connection.selectJoueur();

            if (lstJoueur.Count > 0)
            {
                lstClassement.Items.Clear();
                foreach (Joueur j in lstJoueur)
                {
                    lstClassement.Items.Add(j.ToString());
                }
            }
            lstJoueur.Clear();
            cmdAjouterLePseudo.Enabled = true;
            cmdDebut.Enabled = false;
        }
 
        private void frmQuizz_Load(object sender, EventArgs e)
        {
            List<Joueur> lstJoueur = connection.selectJoueur();
            if (lstJoueur.Count > 0)
            {
                lstClassement.Items.Clear();
                foreach (Joueur j in lstJoueur)
                {
                    lstClassement.Items.Add(j.ToString());
                }
            }
        }
    }
}
