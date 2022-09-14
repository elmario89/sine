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

        private void pboxFWorkSpace_Paint(object sender, PaintEventArgs e)
        {
            TTrajectory trajectory = new TTrajectory(pboxFWorkSpace, e.Graphics, 1f, 1f);
            trajectory.Draw();
        }
    }
}
