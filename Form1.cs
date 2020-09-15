using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Alexandros Nicolaou
//592067
//09-13-2020
//Create a translator
namespace Homework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Translation_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //for all the translations I changed the text to the french translation whenever the button got pressed
        private void Pineapple_Click(object sender, EventArgs e)
        {
            Translation.Text = "anana";
        }

        private void Potato_Click(object sender, EventArgs e)
        {
            Translation.Text = "pomme de terre";
        }

        private void Star_Click(object sender, EventArgs e)
        {
            Translation.Text = "étoile";
        }

        private void Kira_Click(object sender, EventArgs e)
        {
            Translation.Text = "Je m’appelle Yoshikage Kira. J’ai 33 ans. Ma maison est dans la section nord-est de Morioh, où sont toutes les villas, et je ne suis pas marié. Je travaille comme employé pour les grand magasins Kame Yu, et j’arrive à la maison tous les jours au plus tard à 20 h. Je ne fume pas, mais je bois de temps en temps. Je me couche à 23 h, et je m’assure d’avoir 8h de sommeil, peu importe. Après avoir bu un verre de lait chaud, normalement, je n’ai pas des problemes pour dormir jusqu’au matin. On m’a dit que il n’y avait pas de problèmes lors de mon dernier check-up. J’essaie d’expliquer que je suis un homme qui souhaite de vivre une vie très tranquille. J'essaye de ne pas me battre avec n’importe qui. Gagner et perdre me ferait perdre le sommeil la nuit. Voilà comment je traite avec la société, et je sais que c’est ce qui me fait plaisir. Mais, si je devais combattre quelqu’un, je ne perdrais pas.";
        }
    }
}
