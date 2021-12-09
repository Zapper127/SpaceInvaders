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
    public partial class SpaceInvaders : Form
    {
        public SpaceInvaders()
        {
            InitializeComponent();
        }

        LaserCannon laserCannon = new LaserCannon();
        private void SP_Load(object sender, EventArgs e)
        {

        }
        
        private void SpaceInvaders_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                    if ((LzrCan.Left + 10) < (this.Width - 51))
                    {
                        LzrCan.Left += 10;
                    }
                    break;
                case Keys.A:
                    if ((LzrCan.Left - 10) > 0)
                    {
                        LzrCan.Left -= 10;
                    }
                    break;
            }
        }
    }
}

