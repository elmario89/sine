using System;
using System.Windows.Forms;

namespace _4162
{
    public partial class frmMain : Form
    {
        private Trajectory _trajectory;
        public frmMain()
        {
            InitializeComponent();
        }

        private void pboxFWorkSpace_Paint(object sender, PaintEventArgs e)
        {
            if (_trajectory == null) return;
            _trajectory.Draw(e.Graphics);
        }

        private void tbarFTrajectorySize_ValueChanged(object sender, EventArgs e)
        {
            _trajectory.floatPScaleX = tbarFTrajectorySizeX.Value * 0.02f;
            pboxFWorkSpace.Invalidate();
        }

        private void tbarFTrajectorySizeY_ValueChanged(object sender, EventArgs e)
        {
            _trajectory.floatPScaleY = tbarFTrajectorySizeY.Value * 0.02f;
            pboxFWorkSpace.Invalidate();
        }
        private void tbarFTrajectorySizeXY_ValueChanged(object sender, EventArgs e)
        {
            _trajectory.floatPScaleX = tbarFTrajectorySizeXY.Value * 0.02f;
            _trajectory.floatPScaleY = tbarFTrajectorySizeXY.Value * 0.02f;
            pboxFWorkSpace.Invalidate();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            _trajectory.frequency = tbarFFrequency.Value;
            pboxFWorkSpace.Invalidate();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            pboxFWorkSpace.Width = getWidth();
            pboxFWorkSpace.Height = this.ClientSize.Height;
            if (_trajectory == null) return;
            _trajectory = new Trajectory(pboxFWorkSpace);
            pboxFWorkSpace.Invalidate();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pboxFWorkSpace.Width = getWidth();
            pboxFWorkSpace.Height = this.ClientSize.Height;
            _trajectory = new Trajectory(pboxFWorkSpace);
        }

        private int getWidth()
        {
            return this.Width / 100 * (100 - pnlFControlSpace.ClientSize.Width / (this.Width / 100));
        }
    }
}
