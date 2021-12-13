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
    class Alien : GameObject
    {
        private int _widthHeight;
        private int _x, _y, _xpadding, _ypadding;
        private int _columns, _rows;
        private Image _squidImage;
        private Image _crabImage;
        private Image _octImage;
        PictureBox alien;

        public Alien ()
        {
            _widthHeight = 30;
            _columns = 7;
            _rows = 3;
            _xpadding = 49;
            _ypadding = 45;
            _x = 105;
            _y = 105;
            _squidImage = Properties.Resources.invader8;
            _crabImage = Properties.Resources.invader3;
            _octImage = Properties.Resources.invader1;
            alien = new PictureBox();
        }
        //Spawns a single alien picturebox
        private void SpawnAlien (Form form, Image alienImage)
        {
            alien = new PictureBox
            {
                Location = new Point(_x, _y),
                Size = new Size(_widthHeight, _widthHeight),
                Image = alienImage,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Tag = "Alien",
            };

            form.Controls.Add(alien);
        }
        //Spawns an array of alien pictureboxes
        public void SpawnAlienArray (Form form, Image alienImage)
        {
            for (int c = 0; c < _columns; c++)
            {
                SpawnAlien(form, alienImage);
                _x += _xpadding;
            }
            _y += _ypadding;
            _x = 105;
        }
        //Spawns an entire grid of alien pictureboxes
        public override void SpawnGameObject (Form form)
        {
            _y = 105;
            for (int c = 0; c < _rows; c++)
            {
                //Alternates the alien image every 3 rows adn then repeats
                if (c % 3 == 0)
                {
                    SpawnAlienArray(form, _squidImage);
                }
                else if (c % 3 == 1)
                {
                    SpawnAlienArray(form, _crabImage);
                }
                else if (c % 3 == 2)
                {
                    SpawnAlienArray(form, _octImage);
                }
            }
        }
        public void GammaRay(Form form, PictureBox alien)
        {
            PictureBox gammaRay = new PictureBox {
                Location = new Point(alien.Location.X + alien.Width / 3, alien.Location.Y + 20),
                Size = new Size(3, 18),
                BackColor = Color.Orange,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Tag = "GammaRay",
        };

            form.Controls.Add(gammaRay);
        }
    }
}
