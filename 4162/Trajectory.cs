using System;
using System.Drawing;
using System.Windows.Forms;

namespace _4162
{
    internal class TTrajectory
    {
        private PictureBox _pboxPPictureBox;
        private Graphics _graphicsPGraphics;

        public float floatPScaleX;
        public float floatPScaleY;

        // properties of trajectory
        private float _floatPPeriod;
        private float _floatPAmplitude;
        private float _x0;
        private float _y0;
        private int _width;
        private int _height;

        public TTrajectory(
            PictureBox pboxPPictureBox,
            Graphics graphicsPGrapchis,
            float _floatPScaleX,
            float _floatPScaleY
        )
        {
            _pboxPPictureBox = pboxPPictureBox;
            _graphicsPGraphics = graphicsPGrapchis;
            _width = _pboxPPictureBox.Width;
            _height = _pboxPPictureBox.Height;

            floatPScaleX = _floatPScaleX;
            floatPScaleY = _floatPScaleY;

            // width of sine by x with public multiplier (period)
            _floatPPeriod = _width * floatPScaleX;

            // height of sine by y with public multiplier (amplitude)
            _floatPAmplitude = (_height / 2) * floatPScaleY;

            // start point x for sine wave
            // sine drawn from right to left
            _x0 = _width / 2 + _width / 2 * floatPScaleX;

            // start point y for sine wave
            _y0 = _height / 2;
        }

        public void Draw()
        {
            // declare pan to draw
            Pen pen = new Pen(Brushes.Black, 0.01F);

            // draw back lines from 0 to 10
            for (int f = 0; f <= _width; f += (_width / 10))
            {
                _graphicsPGraphics.DrawLine(new Pen(Brushes.Silver, 0.01F), f, _height, f, 0);
            }

            // default values for x and y
            float x = 0, y = 0;

            for (float angle = 0; angle <= 2 * Math.PI; angle += 0.00001f)
            {
                x = _x0 - ((_floatPPeriod * angle) / (2 * (float)Math.PI));
                y = _y0 - _floatPAmplitude * (float)Math.Sin(angle);
                _graphicsPGraphics.DrawLine(pen, x, y, x + 1, y + 1);
            }

            // draw horizontal line
            _graphicsPGraphics.DrawLine(pen, _x0, _y0, x, y);
        }
    }
}
