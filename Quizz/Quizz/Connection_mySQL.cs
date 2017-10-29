using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Quizz
{
    class Connection_mySQL
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public Connection_mySQL()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "Quizz";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void InsertJoueur(string nomJoueur, int resultat)
        {
            connection.Open();
            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = this.connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "INSERT INTO Joueurs (Pseudo, Resultat) VALUES (@Pseudo, @Resultat)";

            // utilisation de l'objet contact passé en paramètre
            cmd.Parameters.AddWithValue("@Pseudo", nomJoueur);
            cmd.Parameters.AddWithValue("@Resultat", resultat);

            // Exécution de la commande SQL
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public object TestPseudo(string nomJoueur)
        {
            connection.Open();

            string sql = "SELECT Pseudo FROM joueurs WHERE Pseudo LIKE " + "'" + nomJoueur + "'";

            MySqlCommand cmd = new MySqlCommand(sql, connection);

            object resultat = cmd.ExecuteScalar();

            connection.Close();

            return resultat;

            
        }
        //Update statement
        public void UpdateScore(string nomJoueur,int resultat)
        {
            connection.Open();

            string sql = "UPDATE joueurs SET Resultat = " + resultat + " WHERE Pseudo LIKE " + "'" + nomJoueur + "'";

            MySqlCommand cmd = new MySqlCommand(sql, connection);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        //Delete statement
        public void Delete()
        {
        }
    }
}
