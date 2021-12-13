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

    class LaserCannon : System.Windows.Forms.Form
    {
        private bool _fire;
        private int _moveRate;
        private int _widthHeight;


        public LaserCannon()
        {
            _moveRate = 10;
            _widthHeight = 50;
        }

        //Property to change _fire variable so Shoot Cannon is allowed to run again
        public bool Fire
        {
            get { return _fire; }

            set { _fire = value; }

        }
        private void MakeCannon(Form form, int x, int y)
        {
            PictureBox lzrcan = new PictureBox();
            lzrcan.Image = Properties.Resources.LaserCannon;
            lzrcan.Size = new Size(_widthHeight, _widthHeight);
            lzrcan.SizeMode = PictureBoxSizeMode.StretchImage;
            lzrcan.Location = new Point(x, y);

            form.Controls.Add(lzrcan);
        }
        
        //Moves cannon left and right and makes sure it stays within its bounds using s and d respectively
        //Also activates the shoot method whe spacebar is pressed
        public void MoveCannon(PictureBox LzrCan, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                    if ((LzrCan.Left + _moveRate) < (543 - 51))
                    {
                        LzrCan.Left += _moveRate;
                    }
                    break;
                case Keys.S:
                    if ((LzrCan.Left - _moveRate) > 0)
                    {
                        LzrCan.Left -= _moveRate;
                    }
                    break;
                case Keys.Space:
                    if (_fire == false)
                    {
                        _fire = true;
                        ShootCannon(Space.ActiveForm, LzrCan);
                    }
                    break;
            }
        }

        // Creates a picturebox above the LsrCan picture box and halfway in between the -2 is to 
        // align the middle of the picture box with the middle
        public void ShootCannon(Form form, PictureBox LzrCan)
        {
            PictureBox blast = new PictureBox
            {
                BackColor = Color.White,
                Width = 3,
                Height = 20,
                Tag = "blast",
            };

            blast.Left = (LzrCan.Left + LzrCan.Width / 2) - 2;
            blast.Top = LzrCan.Top - 20;
            
            form.Controls.Add(blast);
        }
        
    }
}