using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoxelRendererCPE_462
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        Camera cam;
        Voxelmap voxmap;

        private void Main_Load(object sender, EventArgs e)
        {
            cam = new Camera();

            voxmap = new Voxelmap(2, 2, 2);
            voxmap[0, 0, 0] = Color.Green;
            voxmap[0, 1, 0] = Color.Blue;
            voxmap[1, 0, 0] = Color.Red;
            voxmap[0, 0, 1] = Color.Red;

            OrthographicSizeBox.Value = (decimal)cam.OrthographicSize;
            MIPCheckBox.Checked = cam.RenderMode == Camera.RenderModeEnum.MIP;
            RenderFrame.Image = cam.Render(voxmap);
        }

        private void OrthographicSizeBox_ValueChanged(object sender, EventArgs e)
        {
            cam.OrthographicSize = (int)OrthographicSizeBox.Value;
        }

        private void BitmapResolutionChanged(object sender, EventArgs e)
        {
            cam.Width = (int)BitmapWidthBox.Value;
            cam.Height = (int)BitmapHeightBox.Value;
            cam.UpdateBitmap();
        }

        private void RenderButton_Click(object sender, EventArgs e)
        {
            RenderFrame.Image = cam.Render(voxmap);
        }

        private void MIPCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            cam.RenderMode = MIPCheckBox.Checked ? Camera.RenderModeEnum.MIP : Camera.RenderModeEnum.Color;
        }
    }
}
