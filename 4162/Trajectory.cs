using _4162.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Shapes;
using Rectangle = System.Drawing.Rectangle;

namespace _4162
{
    internal class TTrajectory
    {
        private Point _pointPBasePoint;
        public float floatPScaleX;
        public float floatPAmplitude;

        // properties of trajectory
        private double _dblPPeriod;
        private double _dblPAmplitude;
        private double _dblPAngle;
        private double _dblPRightEndCoordinates;
        private double _dblPHorizontalCoordinates;

        public void Draw(PictureBox box, PaintEventArgs e)
        {
            // declare pan to draw
            Pen pen = new Pen(Brushes.Black, 0.01F);

            // get box dimensions
            int width = box.Width;
            int height = box.Height;

            // draw back lines from 0 to 10
            for (int f = 0; f <= width; f += (width / 10))
            {
                e.Graphics.DrawLine(new Pen(Brushes.Silver, 0.01F), f, height, f, 0);
            }

            // start point x for sine wave
            // sine drawn from right to left
            float x0 = width / 2 + width / 2 * floatPScaleX;

            // start point y for sine wave
            float y0 = height / 2;

            // width of sine by x with public multiplier (period)
            float a = width * floatPScaleX;

            // height of sine by y with public multiplier (amplitude)
            float b = (height / 2) * floatPAmplitude;

            // default values for x and y
            float x = 0, y = 0;

            for (float angle = 0; angle <= 2 * Math.PI; angle += 0.00001f)
            {
                x = x0 - ((a * angle) / (2 * (float)Math.PI));
                y = y0 - b * (float)Math.Sin(angle);
                e.Graphics.DrawLine(pen, x, y, x + 1, y + 1);
            }

            e.Graphics.DrawLine(pen, x0, y0, x, y);
        }
    }
}
