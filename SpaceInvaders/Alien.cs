using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace SpaceInvaders
{
    class Alien
    {

        private int _fireRate;
        private int _squidx = 105, _crabx = 150, _octx = 196;
        private Image _squidImage = Properties.Resources.invader8;
        private Image _crabImage = Properties.Resources.invader3;
        private Image _octImage = Properties.Resources.invader1;

        //Spawns 1 row of aliens using an array of pictureboxes depending on specified type
        public void SpawnAlienArray(Form form, int ypos, Image image)
        {
            int c, xpos = 105;

            PictureBox[] alienarray = new PictureBox[7];

            for (c = 0; c < alienarray.Length; c++)
            {
                alienarray[c] = new PictureBox {
                    Size = new Size(38, 38),
                    Location = new Point (xpos, ypos),
                    Image = image,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Tag = "Alien",
                };
                form.Controls.Add(alienarray[c]);
                xpos += 49;
            }
        }

        //Spawns all three rows of aliens
        public void SpawnAliens()
        {
            SpawnAlienArray(Space.ActiveForm, _squidx, _squidImage);
            SpawnAlienArray(Space.ActiveForm, _crabx, _crabImage);
            SpawnAlienArray(Space.ActiveForm, _octx, _octImage);
        }
    }
}
