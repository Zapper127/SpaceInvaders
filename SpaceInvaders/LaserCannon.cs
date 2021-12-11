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
        private void MakeCannon(Form form, int x, int y, int sizex, int sizey)
        {
            PictureBox lzrcan = new PictureBox();
            lzrcan.Image = Properties.Resources.LaserCannon;
            lzrcan.SizeMode = PictureBoxSizeMode.StretchImage;
            lzrcan.Size = new Size(sizex, sizey);
            lzrcan.Location = new Point(x, y);

            form.Controls.Add(lzrcan);
        }
        
        private bool _fire;
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
                        ShootCannon(Space.ActiveForm, "blast", LzrCan);
                    }
                    break;
            }
        }
        public void ShootCannon(Form form, string blastTag, PictureBox LzrCan)
        {
            PictureBox blast = new PictureBox();
            blast.BackColor = Color.White;
            blast.Width = 5;
            blast.Height = 20;
            blast.Tag = blastTag;
            blast.Left = (LzrCan.Left + LzrCan.Width / 2) - 2;
            
            if ((string)blast.Tag == "blast")
            {
                blast.Top = LzrCan.Top - 20;
            }
            
            form.Controls.Add(blast);
        }
        
    }
}