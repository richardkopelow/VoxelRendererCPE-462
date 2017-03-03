using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoxelRendererCPE_462
{
    class Voxelmap
    {
        Color[,,] voxels;

        public Color this[int x, int y, int z]
        {
            get
            {
                return voxels[x, y, z];
            }
            set
            {
                voxels[x, y, z] = value;
            }
        }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Depth { get; set; }

        public Voxelmap(int x, int y, int z)
        {
            voxels = new Color[x, y, z];
            Width = x;
            Height = y;
            Depth = z;
            for (int ix = 0; ix < x; ix++)
            {
                for (int iy = 0; iy < y; iy++)
                {
                    for (int iz = 0; iz < z; iz++)
                    {
                        voxels[ix, iy, iz] = Color.FromArgb(0);
                    }
                }
            }
        }
        public bool ContainsPoint(int x, int y, int z)
        {
            if (x > voxels.GetUpperBound(0) || x < voxels.GetLowerBound(0))
            {
                return false;
            }
            if (y > voxels.GetUpperBound(1) || y < voxels.GetLowerBound(1))
            {
                return false;
            }
            if (z > voxels.GetUpperBound(2) || z < voxels.GetLowerBound(2))
            {
                return false;
            }
            return true;
        }
    }
}
