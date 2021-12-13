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
    class Barrier
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
        
        public int X
        {
            get { return _x; }

            set { _x = value; _xsave = value; }
        }
        public int Y
        {
            get { return _y; }

            set { _y = value; }
        }
        public void MakeBarrier (Form form)
        {
            barrier = new PictureBox
            {
                Location = new Point(_x, _y),
                Size = new Size(_widthHeight, _widthHeight),
                BackColor = Color.Green,
                BackgroundImageLayout = ImageLayout.Stretch,
                Tag = "Barrier",
            };

            form.Controls.Add(barrier);
        }

        public void SpawnBarrier (Form form)
        {
            for (int c = 0; c < _rows; c++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    MakeBarrier(form);
                    _x += _padding;
                }
                _y += _padding;
                _x = _xsave;
            }
        }
    }
}
