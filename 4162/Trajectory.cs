using System;
using System.Drawing;
using System.Windows.Forms;

namespace _4162
{
    internal class TTrajectory
    {
        // pbox itself
        private PictureBox _pboxPPictureBox;

        // scale by x and y, default is 0.5
        public float floatPScaleX = 0.5f;
        public float floatPScaleY = 0.5f;

        // properties of trajectory
        private float _floatPPeriod;
        private float _floatPAmplitude;
        private float _x0;
        private float _y0;
        private int _width;
        private int _height;

        public TTrajectory(PictureBox pboxPPictureBox)
        {
            _pboxPPictureBox = pboxPPictureBox;
            _width = _pboxPPictureBox.Width;
            _height = _pboxPPictureBox.Height;

            // width of sine by x with public multiplier (period)
            _floatPPeriod = _width;

            // height of sine by y with public multiplier (amplitude)
            _floatPAmplitude = (_height / 2);

            // start point y for sine wave
            _y0 = _height / 2;
        }

        public void Draw(Graphics g)
        {
            // declare pan to draw
            Pen pen = new Pen(Brushes.Black, 0.01F);

            // draw back lines from 0 to 10
            for (float f = 0; f <= _width; f += (_width / 10))
            {
                g.DrawLine(new Pen(Brushes.Silver, 0.01F), f, _height, f, 0);
            }

            // default values for x and y
            float x = 0, y = 0;

            // start point x for sine wave
            // sine drawn from right to left
            _x0 = _width / 2 + _width / 2 * floatPScaleX;

            for (float angle = 0; angle <= 2 * Math.PI; angle += 0.00001f)
            {

                x = _x0 - (((_floatPPeriod * floatPScaleX) * angle) / (2 * (float)Math.PI));
                y = _y0 - (_floatPAmplitude * floatPScaleY) * (float)Math.Sin(angle);
                g.DrawLine(pen, x, y, x + 1, y + 1);
            }

            // draw horizontal line
            g.DrawLine(pen, _x0, _y0, x, y);
        }
    }
}
