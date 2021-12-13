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
        UFO ufo = new UFO();
        Barrier barrier = new Barrier(66, 373);
        Barrier barrier2 = new Barrier(216, 373);
        Barrier barrier3 = new Barrier(366, 373);
        public List<PictureBox> AlienList = new List<PictureBox>();
        public int score = 0;
        public int level = 1;
        bool gameOver;
        bool gameReset;

        public Space()
        {
            InitializeComponent();
            GameStart();
        }
  
        private void Space_Shown(object sender, EventArgs e)
        {
            //GameStart();
        }
  
        //Move laser cannon
        private void SpaceInvaders_KeyDown(object sender, KeyEventArgs e)
        {
            laserCannon.MoveCannon(LzrCan, e);
        }
        //Every tick do the following instructions...
        //Basically update game form
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            UpdateForm.UpdateScore(ScoreNumLabel, score);
            ufo.SpawnGameObject(this);
            ufo.UFOGenerated = UpdateForm.UpdateUFOPosition(this);
            gameOver = UpdateForm.AlienHit(this);

            if (gameOver == true)
            {
                GameOver();
            }

            UpdateForm.UpdateShots(this, laserCannon);
            score += UpdateForm.ObjectHit(this, laserCannon, score, AlienList);
            gameOver = UpdateForm.GammaHit(this, Life1, Life2, laserCannon);

            if (gameOver == true)
            {
                GameOver();
            }

            gameReset = UpdateForm.CheckAlienCount();

            if (gameReset == true)
            {
                GameReset();
            }
        }
        //Moves the aliens accodingly. Checks how many aliens are left and increases their speed/interval time the less there are
        private void AlienTimer_Tick(object sender, EventArgs e)
        {
            UpdateForm.UpdateAlienPosition(AlienList);
            if (UpdateForm.AlienCount <= 3)
            {
                AlienTimer.Interval = 90;
            }
            else if (UpdateForm.AlienCount <= 7)
            {
                AlienTimer.Interval = 250;
            }
            else if (UpdateForm.AlienCount <= 14)
            {
                AlienTimer.Interval = 375;
            }
        }
        //Generate alien gammarays
        private void GammaRay_Tick(object sender, EventArgs e)
        {
            Random num = new Random();
            int col;

            if (gameOver == false)
            {
                col = num.Next(AlienList.Count);
                aliens.GammaRay(this, AlienList[col]);
            }
        }

        //get and set the score variable
        public int Score
        {
            get { return score; }

            set { score = value; }
        }
        //Create a list of picture boxes filled with the picutreboxes labeled as "Alien"
        private void AlienMakeList()
        {
            foreach (Control pic in this.Controls)
            {
                if (pic is PictureBox && pic.Tag.ToString() == "Alien")
                {
                    PictureBox alien = (PictureBox)pic;
                    AlienList.Add(alien);
                }
            }
        }
        // Game is started
        private void GameStart()
        {
            aliens.SpawnGameObject(this);
            AlienMakeList();
            barrier.SpawnBarrier(this);
            barrier2.SpawnBarrier(this);
            barrier3.SpawnBarrier(this);
        }
        //Reset the board and continue fighting a new wave
        private void GameReset()
        {
            gameReset = false;
            level++;
            AlienList.Clear();
            LevelNumLabel.Text = level.ToString();
            barrier.X = 66;
            barrier.Y = 373;
            barrier2.X = 216;
            barrier2.Y = 373;
            barrier3.X = 366;
            barrier3.Y = 373;
            AlienTimer.Interval = 500;
            GameStart();
        }
        //Game over
        private void GameOver()
        {
            GameTimer.Stop();
            AlienTimer.Stop();
            GammaRayTimer.Stop();
            pictureBox1.Visible = true;
            ScoreNumLabel.Text = score.ToString();
        }
    }
}

