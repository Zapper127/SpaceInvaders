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
        /*
        public LaserCannon(Form form) 
        {
            PictureBox lzrcan = new PictureBox();
            lzrcan.Image = Properties.Resources.LaserCannon;
            lzrcan.SizeMode = PictureBoxSizeMode.StretchImage;
            lzrcan.Size = new Size(50, 50);
            lzrcan.Location = new Point(335, 535);

            form.Controls.Add(lzrcan);
        }
        */
        private bool _fire;

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
            lzrcan.Size = new Size(50, 50);
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
                    if ((LzrCan.Left + 10) < (543 - 51))
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
            PictureBox blast = new PictureBox();
            blast.BackColor = Color.White;
            blast.Width = 3;
            blast.Height = 20;
            blast.Tag = "blast";
            blast.Left = (LzrCan.Left + LzrCan.Width / 2) - 2;
            blast.Top = LzrCan.Top - 20;
            
            form.Controls.Add(blast);
        }
        
    }
}