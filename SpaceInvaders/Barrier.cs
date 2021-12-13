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
    class Barrier : GameObject
    {
        private int _widthHeight;
        private int _padding;
        private int _columns, _rows;
        private int _x, _y, _xsave;
        PictureBox barrier;
        public Barrier (int x, int y)
        {
            _widthHeight = 10;
            _padding = 10;
            _columns = 8;
            _rows = 3;
            _x = x;
            _xsave = x;
            _y = y;
            barrier = new PictureBox();
        }
        //Allows _x value to be read and set
        public int X
        {
            get { return _x; }

            set { _x = value; _xsave = value; }
        }
        //Allows _y value to be read and set
        public int Y
        {
            get { return _y; }

            set { _y = value; }
        }
        //Creates a single barrier block
        public override void SpawnGameObject (Form form)
        {
            barrier = new PictureBox
            {
                Location = new Point(_x, _y),
                Size = new Size(_widthHeight, _widthHeight),
                BackColor = Color.Green,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Tag = "Barrier",
            };

            form.Controls.Add(barrier);
        }
        //Spawns an entire barrier
        public void SpawnBarrier (Form form)
        {
            for (int c = 0; c < _rows; c++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    SpawnGameObject(form);
                    _x += _padding;
                }
                _y += _padding;
                _x = _xsave;
            }
        }
    }
}
