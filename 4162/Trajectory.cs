using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace _4162
{
    internal class Trajectory
    {
        // scale for both x and y
        public float floatPScaleX = 0.5f;
        public float floatPScaleY = 0.5f;

        // frequency of sine
        public int frequency = 2;
        
        // pbox itself
        private readonly PictureBox _pboxPPictureBox;

        // properties of trajectory
        private float _floatPPeriod;
        private float _floatPAmplitude;
        private float _floatPx0;
        private float _floatPy0;
        private int _intPPboxWidth;
        private int _intPPboxHeight;

        public Trajectory(PictureBox pboxPPictureBox)
        {
            _pboxPPictureBox = pboxPPictureBox;

            _intPPboxWidth = _pboxPPictureBox.Width;
            _intPPboxHeight = _pboxPPictureBox.Height;

            // width of sine by x with public multiplier (period)
            _floatPPeriod = _intPPboxWidth;

            // height of sine by y with public multiplier (amplitude)
            _floatPAmplitude = (_intPPboxHeight / 2);

            // start point y for sine wave
            _floatPy0 = _intPPboxHeight / 2;
        }

        public void Draw(Graphics g)
        {
            // declare pan to draw
            Pen pen = new Pen(Brushes.Black, 0.01F);

            // draw back lines from 0 to 10
            for (float f = 0; f < _intPPboxWidth; f += (_intPPboxWidth / 10))
            {
                g.DrawLine(new Pen(Brushes.Silver, 0.01F), f, _intPPboxHeight, f, 0);
            }

            // default values for x and y
            float x = 0, y = 0;

            // start point x for sine wave
            // sine drawn from right to left
            _floatPx0 = _intPPboxWidth / 2 + _intPPboxWidth / 2 * floatPScaleX;

            List<PointF> points = new List<PointF>();

            for (float angle = 0; angle <= frequency * Math.PI; angle += 0.001f)
            {
                x = _floatPx0 - (((_floatPPeriod * floatPScaleX) * angle) / (frequency * (float)Math.PI));
                y = _floatPy0 - (_floatPAmplitude * floatPScaleY) * (float)Math.Sin(angle);
                g.DrawLine(pen, x, y, x + 0.1f, y + 0.1f);
                points.Add(new PointF(x, y));
            }

            // draw horizontal line
            g.DrawLine(pen, _floatPx0, _floatPy0, x, y);

            //points.ForEach(p => g.DrawEllipse(new Pen(Brushes.Red, 0.0f), p.X, p.Y, 5, 5));
        }
    }
}
