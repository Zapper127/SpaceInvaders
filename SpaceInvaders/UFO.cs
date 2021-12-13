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
    class UFO
    {
        private Random _randomNum;
        private bool _ufoGenerated;
        private int _num;
        private int _key;
        private int _width, _height;
        private Point spawnLocation;

        public UFO()
        {
            _key = 7;
            _randomNum = new Random();
            _width = 50;
            _height = 30;
            spawnLocation = new Point (530, 63);
        }

        //Generate a random number between 1 and 300
        public void Random()
        {
            _num = _randomNum.Next(1, 300);
        }
   
        //property to change status of _ufoGenerated
        public bool UFOGenerated
        {
            get { return _ufoGenerated; }
            set { _ufoGenerated = value; }
        }

        //Attempts to make a ufo if there is not already one on the screen and the random number generated is 7
        public void MakeUFO(Form form)
        {
            Random();
            if (_ufoGenerated == false && _num == _key)
            {

                PictureBox UFO = new PictureBox 
                {
                    Image = Properties.Resources.UFO,
                    Size = new Size(_width, _height),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Tag = "UFO",
                };
                UFO.Location = spawnLocation;

                _num = 0;
                _ufoGenerated = true;
                form.Controls.Add(UFO);
            }
        }
    }
}
