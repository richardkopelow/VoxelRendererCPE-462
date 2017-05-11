using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        public void Load(string filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                string file = sr.ReadToEnd();
                string[] lines = file.Split('\n');
                Width = int.Parse(lines[0]);
                Height = int.Parse(lines[1]);
                Depth = int.Parse(lines[2]);

                voxels = new Color[Width, Height, Depth];
                for (int i = 0; i < Width; i++)
                {
                    for (int j = 0; j < Height; j++)
                    {
                        for (int k = 0; k < Depth; k++)
                        {
                            voxels[i, j, k] = Color.FromArgb(int.Parse(lines[k+j*Depth+i*Depth*Height+3]));
                        }
                    }
                }
            }
        }
        public void Save(string filename)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\n{1}\n{2}",Width,Height,Depth);
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    for (int k = 0; k < Depth; k++)
                    {
                        sb.Append('\n');
                        sb.Append(voxels[i, j, k].ToArgb());
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.Write(sb.ToString());
            }
        }
    }
}
