using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizz
{
    public partial class frmQuestion : Form
    {
        int bonneReponse;

        public frmQuestion()
        {
            InitializeComponent();
        }

        private void frmQuestion_Load(object sender, EventArgs e)
        {
            Connection_mySQL bdd = new Connection_mySQL();
            List<Question> lstquest = bdd.selectQuestion();
            foreach (Question quest in lstquest)
            {
                lblCat.Text = quest.Categories;
                lblQuestion.Text = quest.NomQuestion;
                cmdReponseA.Text = quest.ReponseA;
                cmdReponseB.Text = quest.ReponseB;
                cmdReponseC.Text = quest.ReponseC;
                bonneReponse = quest.BonneReponse;
            }
            
        }
    }
}
