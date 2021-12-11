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
        bool gameOver;
        public Space()
        {
            InitializeComponent();
            
        }
        
        //Move laser cannon
        private void SpaceInvaders_KeyDown(object sender, KeyEventArgs e)
        {
            laserCannon.MoveCannon(LzrCan, e);
            /*
            switch (e.KeyCode)
            {
                case Keys.D:
                    if ((LzrCan.Left + 10) < (this.Width - 51))
                    {
                        LzrCan.Left += 10;
                    }
                    break;
                case Keys.S:
                    if ((LzrCan.Left - 10) > 0)
                    {
                        LzrCan.Left -= 10;
                    }
                    break;
                case Keys.Space:
                        MakeBlast();
                    //MakeCannon();
                    break;
            }
            */
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {

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

