using System;
using System.Windows.Forms;

namespace _4162
{
    public partial class frmMain : Form
    {
        private TTrajectory _trajectory;
        public frmMain()
        {
            InitializeComponent();
            _trajectory = new TTrajectory(pboxFWorkSpace);
        }

        private void pboxFWorkSpace_Paint(object sender, PaintEventArgs e)
        {
            if (_trajectory == null) return;
            _trajectory.Draw(e.Graphics);
        }

        private void tbarFTrajectorySize_ValueChanged(object sender, EventArgs e)
        {
            _trajectory.floatPScaleX = tbarFTrajectorySizeX.Value * 0.1f;
            pboxFWorkSpace.Invalidate();
        }

        private void tbarFTrajectorySizeY_ValueChanged(object sender, EventArgs e)
        {
            _trajectory.floatPScaleY = tbarFTrajectorySizeY.Value * 0.1f;
            pboxFWorkSpace.Invalidate();
        }
    }
}
