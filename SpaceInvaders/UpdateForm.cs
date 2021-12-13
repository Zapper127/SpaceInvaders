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
        private static int _blastMove = 15;
        private static int _alienXY = 30;
        private static int left = 30;
        private static int top = 0;
        private static int speed = 30;
        private static int cnt = 0;


        //Updates score label
        public static void UpdateScore(Label scorelabel, int score)
        {
            scorelabel.Text = score.ToString();
        }
        public static int AlienCount
        {
            get { return _alienCount; }
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
        public static int ObjectHit (Form form, LaserCannon laserCannon, int score, List<PictureBox> alienlist)
        {
            foreach (Control blast in form.Controls)
            {
                foreach (Control obj in form.Controls)
                {
                    if (blast is PictureBox && blast.Tag.ToString() == "blast")
                    {
                        if (obj is PictureBox && obj.Tag.ToString() == "Alien")
                        {
                            PictureBox alien = (PictureBox)obj;

                            if (blast.Bounds.IntersectsWith(obj.Bounds))
                            {
                                laserCannon.Fire = false;
                                _alienCount--;
                                alienlist.Remove(alien);
                                form.Controls.Remove(alien);
                                form.Controls.Remove(blast);
                                return 10;
                            }
                        }
                        //See if a blast intersects a UFO and give 200 pts if true then remove blast and UFO
                        else if (obj is PictureBox && obj.Tag.ToString() == "UFO")
                        {
                            if (blast.Bounds.IntersectsWith(obj.Bounds))
                            {
                                laserCannon.Fire = false;
                                form.Controls.Remove(obj);
                                form.Controls.Remove(blast);
                                return 200;
                            }
                        }
                        else if (obj is PictureBox && obj.Tag.ToString() == "Barrier")
                        {
                            if (blast.Bounds.IntersectsWith(obj.Bounds))
                            {
                                laserCannon.Fire = false;
                                form.Controls.Remove(obj);
                                form.Controls.Remove(blast);
                                return 0;
                            }

                        }
                    }
                }
            }
            return 0;
        }

        public static bool AlienHit (Form form)
        {
            foreach (Control alien in form.Controls)
            {
                foreach (Control obj in form.Controls)
                {
                    if (alien is PictureBox && alien.Tag.ToString() == "Alien")
                    {
                        if (obj is PictureBox && obj.Tag.ToString() == "Cannon")
                        {
                            if (alien.Bounds.IntersectsWith(obj.Bounds))
                            {
                                return true;
                            }
                        }
                        else if (obj is PictureBox && obj.Tag.ToString() == "Barrier")
                        {
                            if (alien.Bounds.IntersectsWith(obj.Bounds))
                            {
                                form.Controls.Remove(obj);
                            }
                        }
                    }
                }
            }
            return false;
        }
        //Changes the position for all the regular aliens
        /*
        public static void UpdateAlienPosition (Form form)
        {
            foreach (Control findAlien in form.Controls)
            {
                if (findAlien is PictureBox && findAlien.Tag.ToString() == "Alien")
                {
                    if (_moveRight == true)
                    {
                       if ((findAlien.Left + _alienXY) < 530 - _alienXY) {
                            if (findAlien.Bounds.IntersectsWith(findAlien.Bounds))
                            findAlien.Left += _alienXY;
                       }
                       else
                       {
                            _moveRight = false;
                            MoveDown(form);
                       }

                    }
                    else if (_moveRight == false)
                    {
                        if ((findAlien.Left - _alienXY) > 10)
                        {
                            findAlien.Left -= _alienXY;

                        }
                        else
                        {
                            _moveRight = true;
                            MoveDown(form);
                        }
                    }
                }
            }
        }
        
        */
        public static void MoveDown(Form form)
        {
            foreach (Control findAlien in form.Controls)
            {
                if (findAlien is PictureBox && findAlien.Tag.ToString() == "Alien")
                {

                    findAlien.Top += 20;
                }
            }
        }

        public static void UpdateAlienPosition (List<PictureBox> alienlist)
        {
            foreach (PictureBox alien in alienlist)
            {
                if (_moveRight == true)
                {
                    if (alien.Location.X + _alienXY <= 492)
                    {
                            alien.Left += _alienXY;
                    }
                    else
                    {
                        _moveRight = false;
                        MoveDown(Space.ActiveForm);
                    }

                }
                else if (_moveRight == false)
                {
                    if (alien.Location.X - _alienXY >= 10)
                    {
                        alien.Left -= _alienXY;

                    }
                    else
                    {
                        _moveRight = true;
                        MoveDown(Space.ActiveForm);
                    }
                }
                /*
                alien.Location = new Point(alien.Location.X + left, alien.Location.Y + top);
                int size = alien.Height;
                if (alien.Location.X <= 0 || alien.Location.X >= 492)
                {
                    /*
                    top = 30;
                    left = 0;
                    _moveRight = true;
                    
                        top = 1; left = 0; cnt++;

                        if (cnt == _alienXY)
                        {
                            top = 0; left = speed * (-1); 
                        }
                        else if (cnt == size * 2)
                        {
                            top = 0; left = speed; cnt = 0;
                        }
                    cnt++;
                }
               
                else if (alien.Location.X + size >= 492)
                {
                    top = 30;
                    left = 0;
                    _moveRight = false;
                }
                */

            }
        }
        //Change the position for the UFO
        public static bool UpdateUFOPosition (Form form)
        {
            foreach (Control findUFO in form.Controls)
            {
                if (findUFO is PictureBox && findUFO.Tag.ToString() == "UFO")
                {
                    if (findUFO.Left > -50)
                    {
                        findUFO.Left -= 5;
                        return true;
                    }
                    else
                    {
                        form.Controls.Remove(findUFO);
                        return false;
                    }
                }
            }
            return false;
        }


        public static bool CheckAlienCount()
        {
            if (_alienCount == 0)
            {
                _alienCount = 21;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
