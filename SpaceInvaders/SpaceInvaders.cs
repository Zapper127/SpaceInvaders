using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class Space : Form
    {
        LaserCannon laserCannon = new LaserCannon();
        Alien aliens = new Alien();
        public int score = 0;
        bool gameOver;
        public Space()
        {
            InitializeComponent();
        }
  
        private void Space_Shown(object sender, EventArgs e)
        {
            GameStart();
        }
        //Move laser cannon
        private void SpaceInvaders_KeyDown(object sender, KeyEventArgs e)
        {
            laserCannon.MoveCannon(LzrCan, e);
        }
        //Every tick do the following instructions...
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            UpdateForm.UpdateScore(ScoreNumLabel, score);

            UpdateForm.UpdateAlienPosition(Space.ActiveForm);

            UpdateForm.UpdateShots(Space.ActiveForm, laserCannon);

            score += UpdateForm.AlienHit(Space.ActiveForm, laserCannon, score);

            gameOver = UpdateForm.CheckAlienCount();

            if (gameOver == true)
            {
                GameOver();
            }
        }
        private void GameOver()
        {
            GameTimer.Stop();
            gameOver = true;
            ScoreLabel.Text = "GAME OVER";
            ScoreNumLabel.Text = score.ToString();
        }

        // Game is started
        private void GameStart()
        {
            aliens.SpawnAliens();
        }

        public int Score
        {
            get { return score; }

            set { score = value; }
        }


        /*
            private void MakeCannon()
            {
              PictureBox lzrcan = new PictureBox();
              lzrcan.Image = Properties.Resources.LaserCannon;
              lzrcan.SizeMode = PictureBoxSizeMode.StretchImage;
              lzrcan.Size = new Size(50, 50);
              lzrcan.Location = new Point(335, 535);

              this.Controls.Add(lzrcan);
            }

            private void MakeBlast()
            {
               PictureBox blast = new PictureBox();
               blast.BackColor = Color.White;
               blast.Width = 20;
               blast.Height = 20;

               blast.Left = LzrCan.Left + LzrCan.Width / 2;
               blast.Top = LzrCan.Height + 350;

               blast.Tag = "blast";

               this.Controls.Add(blast);
            }
            */
    }
}

