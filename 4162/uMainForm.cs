using System;
using System.Drawing;
using System.Windows.Forms;

namespace _4162
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Red, pboxFWorkSpace.ClientRectangle);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void pboxFWorkSpace_Paint(object sender, PaintEventArgs e)
        {
            TTrajectory trajectory = new TTrajectory();
            trajectory.floatPScaleX = 1f;
            trajectory.floatPAmplitude = 1f;
            trajectory.Draw(pboxFWorkSpace, e);
        }

        private void pnlFControlSpace_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
