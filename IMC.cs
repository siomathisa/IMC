using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class IMC : Form
    {
        public IMC()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcul_Click(object sender, EventArgs e)
        {
            string poidsTexte = textboxPoids.Text;
            string tailleTexte = textboxTaille.Text;

            double poids;
            double tailleCm;
            double tailleM;

            if (double.TryParse(poidsTexte, out poids) && double.TryParse(tailleTexte, out tailleCm))
            {
                tailleM = tailleCm / 100.0;

                if (tailleM > 0)
                {
                    double imc = poids / (tailleM * tailleM);
                    labelResultat.Text = "Votre IMC est de " + imc.ToString("F2");
                }
                else
                {
                    labelResultat.Text = "La taille doit être supérieure à zéro.";
                }
            }
            else
            {
                labelResultat.Text = "Entrées invalides. Veuillez entrer des valeurs valides.";
            }
        }


        private void labelPoids_Click(object sender, EventArgs e)
        {

        }
    }
}
