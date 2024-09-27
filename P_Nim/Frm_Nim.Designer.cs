namespace P_Nim
{
    partial class Frm_Nim
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
            this.grbJ1 = new System.Windows.Forms.GroupBox();
            this.btnJ1A3 = new System.Windows.Forms.Button();
            this.btnJ1A2 = new System.Windows.Forms.Button();
            this.btnJ1A1 = new System.Windows.Forms.Button();
            this.grbJ2 = new System.Windows.Forms.GroupBox();
            this.btnJ2A3 = new System.Windows.Forms.Button();
            this.btnJ2A1 = new System.Windows.Forms.Button();
            this.btnJ2A2 = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.lblTour = new System.Windows.Forms.Label();
            this.lblAllumetteStill = new System.Windows.Forms.Label();
            this.pnlAllumettes = new System.Windows.Forms.Panel();
            this.grbJ1.SuspendLayout();
            this.grbJ2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbJ1
            // 
            this.grbJ1.Controls.Add(this.btnJ1A3);
            this.grbJ1.Controls.Add(this.btnJ1A2);
            this.grbJ1.Controls.Add(this.btnJ1A1);
            this.grbJ1.Location = new System.Drawing.Point(13, 240);
            this.grbJ1.Name = "grbJ1";
            this.grbJ1.Size = new System.Drawing.Size(217, 163);
            this.grbJ1.TabIndex = 3;
            this.grbJ1.TabStop = false;
            this.grbJ1.Text = "Joueur 1:";
            // 
            // btnJ1A3
            // 
            this.btnJ1A3.Location = new System.Drawing.Point(21, 110);
            this.btnJ1A3.Name = "btnJ1A3";
            this.btnJ1A3.Size = new System.Drawing.Size(174, 23);
            this.btnJ1A3.TabIndex = 2;
            this.btnJ1A3.Text = "trois allumette";
            this.btnJ1A3.UseVisualStyleBackColor = true;
            this.btnJ1A3.Click += new System.EventHandler(this.btnJ1A3_Click);
            // 
            // btnJ1A2
            // 
            this.btnJ1A2.Location = new System.Drawing.Point(21, 70);
            this.btnJ1A2.Name = "btnJ1A2";
            this.btnJ1A2.Size = new System.Drawing.Size(174, 23);
            this.btnJ1A2.TabIndex = 1;
            this.btnJ1A2.Text = "deux allumette";
            this.btnJ1A2.UseVisualStyleBackColor = true;
            this.btnJ1A2.Click += new System.EventHandler(this.btnJ1A2_Click);
            // 
            // btnJ1A1
            // 
            this.btnJ1A1.Location = new System.Drawing.Point(21, 30);
            this.btnJ1A1.Name = "btnJ1A1";
            this.btnJ1A1.Size = new System.Drawing.Size(174, 23);
            this.btnJ1A1.TabIndex = 0;
            this.btnJ1A1.Text = "une allumette";
            this.btnJ1A1.UseVisualStyleBackColor = true;
            this.btnJ1A1.Click += new System.EventHandler(this.btnJ1A1_Click);
            // 
            // grbJ2
            // 
            this.grbJ2.Controls.Add(this.btnJ2A3);
            this.grbJ2.Controls.Add(this.btnJ2A1);
            this.grbJ2.Controls.Add(this.btnJ2A2);
            this.grbJ2.Location = new System.Drawing.Point(571, 240);
            this.grbJ2.Name = "grbJ2";
            this.grbJ2.Size = new System.Drawing.Size(217, 163);
            this.grbJ2.TabIndex = 3;
            this.grbJ2.TabStop = false;
            this.grbJ2.Text = "Joueur 2:";
            // 
            // btnJ2A3
            // 
            this.btnJ2A3.Enabled = false;
            this.btnJ2A3.Location = new System.Drawing.Point(21, 110);
            this.btnJ2A3.Name = "btnJ2A3";
            this.btnJ2A3.Size = new System.Drawing.Size(174, 23);
            this.btnJ2A3.TabIndex = 2;
            this.btnJ2A3.Text = "trois allumette";
            this.btnJ2A3.UseVisualStyleBackColor = true;
            this.btnJ2A3.Click += new System.EventHandler(this.btnJ2A3_Click);
            // 
            // btnJ2A1
            // 
            this.btnJ2A1.Enabled = false;
            this.btnJ2A1.Location = new System.Drawing.Point(21, 30);
            this.btnJ2A1.Name = "btnJ2A1";
            this.btnJ2A1.Size = new System.Drawing.Size(174, 23);
            this.btnJ2A1.TabIndex = 0;
            this.btnJ2A1.Text = "une allumette";
            this.btnJ2A1.UseVisualStyleBackColor = true;
            this.btnJ2A1.Click += new System.EventHandler(this.btnJ2A1_Click);
            // 
            // btnJ2A2
            // 
            this.btnJ2A2.Enabled = false;
            this.btnJ2A2.Location = new System.Drawing.Point(21, 70);
            this.btnJ2A2.Name = "btnJ2A2";
            this.btnJ2A2.Size = new System.Drawing.Size(174, 23);
            this.btnJ2A2.TabIndex = 1;
            this.btnJ2A2.Text = "deux allumette";
            this.btnJ2A2.UseVisualStyleBackColor = true;
            this.btnJ2A2.Click += new System.EventHandler(this.btnJ2A2_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(314, 307);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(174, 23);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "Nouvelle partie";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLeave.Location = new System.Drawing.Point(314, 347);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(174, 23);
            this.btnLeave.TabIndex = 5;
            this.btnLeave.Text = "Quitter";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // lblTour
            // 
            this.lblTour.AutoSize = true;
            this.lblTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTour.Location = new System.Drawing.Point(342, 225);
            this.lblTour.Name = "lblTour";
            this.lblTour.Size = new System.Drawing.Size(116, 15);
            this.lblTour.TabIndex = 2;
            this.lblTour.Text = "Tour du Joueur 1";
            // 
            // lblAllumetteStill
            // 
            this.lblAllumetteStill.AutoSize = true;
            this.lblAllumetteStill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllumetteStill.Location = new System.Drawing.Point(335, 162);
            this.lblAllumetteStill.Name = "lblAllumetteStill";
            this.lblAllumetteStill.Size = new System.Drawing.Size(137, 16);
            this.lblAllumetteStill.TabIndex = 1;
            this.lblAllumetteStill.Text = "Allumettes restante 20";
            this.lblAllumetteStill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAllumettes
            // 
            this.pnlAllumettes.Location = new System.Drawing.Point(12, 12);
            this.pnlAllumettes.Name = "pnlAllumettes";
            this.pnlAllumettes.Size = new System.Drawing.Size(776, 147);
            this.pnlAllumettes.TabIndex = 6;
            // 
            // Frm_Nim
            // 
            this.AcceptButton = this.btnNewGame;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnLeave;
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.lblAllumetteStill);
            this.Controls.Add(this.lblTour);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.grbJ2);
            this.Controls.Add(this.grbJ1);
            this.Controls.Add(this.pnlAllumettes);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 452);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 452);
            this.Name = "Frm_Nim";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeux du Nim";
            this.Load += new System.EventHandler(this.Frm_Nim_Load);
            this.grbJ1.ResumeLayout(false);
            this.grbJ2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbJ1;
        private System.Windows.Forms.GroupBox grbJ2;
        private System.Windows.Forms.Button btnJ1A3;
        private System.Windows.Forms.Button btnJ1A2;
        private System.Windows.Forms.Button btnJ1A1;
        private System.Windows.Forms.Button btnJ2A3;
        private System.Windows.Forms.Button btnJ2A1;
        private System.Windows.Forms.Button btnJ2A2;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Label lblTour;
        private System.Windows.Forms.Label lblAllumetteStill;
        private System.Windows.Forms.Panel pnlAllumettes;
    }
}

