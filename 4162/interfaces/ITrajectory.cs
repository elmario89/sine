using System.Drawing;
using System.Windows.Forms;

namespace _4162.interfaces
{
    internal interface ITrajectory
    {
        void Draw(Graphics g);
        PictureBox _pboxPPictureBox { get; }
        float floatPScaleX { get; set; }
        float floatPScaleY { get; set; }
        float _floatPPeriod { get; set; }
        float _floatPAmplitude { get; set; }
        float _floatPx0 { get; set; }
        float _floatPy0 { get; set; }
        int _intPPboxWidth { get; set; }
        int _intPPboxHeight { get; set; }
    }
}
