using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace P_Nim
{
    /*
     * Auteur: FauZaPespi
     * Date: 27.09.2024
     * Détails: Projet qui permet à deux joueurs (humains) de jouer au jeu des allumettes. (Nim)
     */
    public partial class Frm_Nim : Form
    {
        // Initialisation des variables


        //Constante du nombre max d'allumettes possible dans le jeux
        const int _nbMaxAllumette = 20;

        private bool _running = false;
        private bool _tour = true;
        private int nbActuelleAllumette = _nbMaxAllumette;
        private List<PictureBox> pictureBoxes = new List<PictureBox>();

        /// <summary>
        /// Constructeur de class
        /// </summary>
        public Frm_Nim()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Dans cette methode on entre nbAllumettes, elle va crée et ajouter des la liste des picturebox avec les images correctes dedans
        /// </summary>
        /// <param name="nbAllumettes">nombre d'allumettes a générée</param>
        private void DrawAllumettes(int nbAllumettes)
        {
            int lastPos = 3;
            for (int i = 0; i < nbAllumettes; i++)
            {
                PictureBox picture = new PictureBox
                {
                    Name = $"pb{i}",
                    Size = new System.Drawing.Size(41, 141),
                    SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom,
                    Location = new System.Drawing.Point(lastPos, 3),
                    Image = P_Nim.Properties.Resources.allumette,
                };
                lastPos += 38;
                pnlAllumettes.Controls.Add(picture);
                pictureBoxes.Add(picture);
            }
            lblAllumetteStill.Text = $"Allumettes restante {pictureBoxes.Count}";
        }

        /// <summary>
        /// Methode pour quitter l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Lance la partie ou non selon la condition !_running
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (!_running)
            {
                DrawAllumettes(_nbMaxAllumette);
                btnNewGame.Enabled = false;
                stateGrb(grbJ1, true);
                stateGrb(grbJ2, false);
                _tour = true;
                _running = true;
            }
            else
            {
                btnNewGame.Enabled = true;
                stateGrb(grbJ1, false);
                stateGrb(grbJ2, false);
            }
        }
        /// <summary>
        /// Méthod pour "réinitialiser" tous le jeux
        /// </summary>
        private void RestartGame()
        {
            ClearAllumettes();
            nbActuelleAllumette = _nbMaxAllumette;
            lblAllumetteStill.Text = "Allumettes restante 20";
            lblTour.Text = "Tour du Joueur 1";
            _running = false;
            _tour = true;
            pnlAllumettes.Controls.Clear();
            stateGrb(grbJ1, false);
            stateGrb(grbJ2, false);
            btnNewGame.Enabled = true;
        }
        /// <summary>
        /// Au chargement du formulaire lancement de la permière partie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Nim_Load(object sender, EventArgs e)
        {
            if (!_running)
            {
                DrawAllumettes(_nbMaxAllumette);
                btnNewGame.Enabled = false;
                _running = true;
            }
            else
            {
                btnNewGame.Enabled = true;
            }
        }
        /// <summary>
        /// Méthode pour supprimé toute les allumettes
        /// </summary>
        private void ClearAllumettes()
        {
            pnlAllumettes.Controls.Clear();
            pictureBoxes.Clear();
        }
        /// <summary>
        /// Affichage du gagnant
        /// </summary>
        /// <param name="joueur"></param>
        private void WinGame(bool joueur)
        {
            MessageBox.Show($"Joueur {(joueur ? "Joueur 2" : "Joueur 1")} à gagner", "Bravo");
            ClearAllumettes();
            RestartGame();
        }
        /// <summary>
        /// Méthode pour enlever le nombre d'allumette voulu
        /// </summary>
        /// <param name="nbRemove">nombre d'allumettes a enlever</param>
        /// <param name="joueur">joueur qui a enlever l'allumettes</param>
        private void RemoveAllumettes(int nbRemove, bool joueur)
        {
            ClearAllumettes();
            nbActuelleAllumette -= nbRemove;
            DrawAllumettes(nbActuelleAllumette);
            if (joueur)
            {
                stateGrb(grbJ1, false);
                stateGrb(grbJ2, true);
            }
            else
            {
                stateGrb(grbJ1, true);
                stateGrb(grbJ2, false);
            }
            lblTour.Text = joueur ? "Tour du Joueur 2" : "Tour du Joueur 1";
            if (pictureBoxes.Count < 3)
            {
                btnJ1A3.Enabled = false;
                btnJ2A3.Enabled = false;
            }
            if (pictureBoxes.Count < 2)
            {
                btnJ1A2.Enabled = false;
                btnJ2A2.Enabled = false;
            }
            if (pictureBoxes.Count < 1)
            {
                WinGame(joueur);
                return;
            }
            _tour = !_tour;

        }
        /// <summary>
        /// Change l'etat de tout les bouttons dans la groupbox
        /// </summary>
        /// <param name="groupbox"></param>
        /// <param name="state"></param>
        private void stateGrb(GroupBox groupbox, bool state)
        {
            try
            {
                foreach (Button button in groupbox.Controls)
                {
                    button.Enabled = state;
                }
            }
            catch { }
        }
        /// <summary>
        /// Methode de click correspondant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJ1A1_Click(object sender, EventArgs e)
        {
            if (_tour)
            {
                RemoveAllumettes(1, true);
                stateGrb((GroupBox)btnJ1A1.Parent, false);
            }
        }
        /// <summary>
        /// Methode de click correspondant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJ1A2_Click(object sender, EventArgs e)
        {
            if (_tour)
            {
                RemoveAllumettes(2, true);
                stateGrb((GroupBox)btnJ1A2.Parent, false);
            }
        }
        /// <summary>
        /// Methode de click correspondant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJ1A3_Click(object sender, EventArgs e)
        {
            if (_tour)
            {
                RemoveAllumettes(3, true);
                stateGrb((GroupBox)btnJ1A3.Parent, false);
            }
        }
        /// <summary>
        /// Methode de click correspondant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJ2A1_Click(object sender, EventArgs e)
        {
            if (!_tour)
            {
                RemoveAllumettes(1, false);
                stateGrb((GroupBox)btnJ2A1.Parent, false);
            }
        }
        /// <summary>
        /// Methode de click correspondant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJ2A2_Click(object sender, EventArgs e)
        {
            if (!_tour)
            {
                RemoveAllumettes(2, false);
                stateGrb((GroupBox)btnJ2A2.Parent, false);
            }
        }
        /// <summary>
        /// Methode de click correspondant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJ2A3_Click(object sender, EventArgs e)
        {
            if (!_tour)
            {
                RemoveAllumettes(3, false);
                stateGrb((GroupBox)btnJ2A3.Parent, false);
            }
        }
    }
}
