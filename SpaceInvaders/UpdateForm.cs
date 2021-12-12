using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SpaceInvaders
{
    static class UpdateForm
    {

        private static bool _moveRight;
        private static int _alienCount = 21;
        private static int _blastMove = 10;

        //Updates score label
        public static void UpdateScore(Label scorelabel, int score)
        {
            scorelabel.Text = score.ToString();
        }

        public static void UpdateShots(Form form, LaserCannon laserCannon)
        {
            
            foreach (Control findShot in form.Controls)
            {
                //If it finds a picturebox with label blast move it's position up or remove it
                //if it is going to go out of bounds
                if (findShot is PictureBox && findShot.Tag.ToString() == "blast")
                {

                    if ((findShot.Top - _blastMove) > 63)
                    {
                        findShot.Top -= _blastMove;
                    }
                    else
                    {
                        form.Controls.Remove(findShot);
                        laserCannon.Fire = false;
                    }
                }
                //Same thing as before but looks for the aliens version of blasts and updates them accordingly
                if (findShot is PictureBox && findShot.Tag.ToString() == "gammaRay")
                {
                    if ((findShot.Top + _blastMove) < 640)
                    {
                        findShot.Top += _blastMove;
                    }
                    else
                    {
                        form.Controls.Remove(findShot);
                    }
                }
            }
        }

        //Find a picturebox with an alien tag d find a picturebox with a blast tag
        //See if their bounds intersect and if they do allow lasercanno to fire again decrement alien count
        //and remove both pictureboxes from the form
        public static int AlienHit (Form form, LaserCannon laserCannon, int score)
        {
            foreach (Control alien in form.Controls)
            {
                foreach (Control blast in form.Controls)
                {
                    if (alien is PictureBox && alien.Tag.ToString() == "Alien")
                    {
                        if (blast is PictureBox && blast.Tag.ToString() == "blast")
                        {
                            if (blast.Bounds.IntersectsWith(alien.Bounds))
                            {
                                laserCannon.Fire = false;
                                _alienCount--;
                                form.Controls.Remove(alien);
                                form.Controls.Remove(blast);
                                return 10;
                            }
                        }
                    }
                }
            }
            return 0;
        }
        public static void UpdateAlienPosition (Form form)
        {
            foreach (Control findAlien in form.Controls)
            {
                if (findAlien is PictureBox && findAlien.Tag.ToString() == "Alien")
                {
                    if (_moveRight == true)
                    {
                       if ((findAlien.Left + 38) < 530 - 38) {
                            findAlien.Left += 38;
                       }
                       else
                       {
                            _moveRight = false;
                       }

                    }
                    else if (_moveRight == false)
                    {
                        if ((findAlien.Left - 38) > 0)
                        {
                            findAlien.Left += -38;

                        }
                        else
                        {
                            _moveRight = true;
                        }
                    }
                }
            }
        }

        public static bool CheckAlienCount()
        {
            if (_alienCount == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
