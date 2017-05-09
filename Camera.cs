using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoxelRendererCPE_462
{
    class Camera
    {
        public Vector3 Position { get; set; }
        public Color Background { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public float PixelsPerUnit { get { return Height / OrthographicSize; } }
        public float OrthographicSize { get; set; }
        public float RayStep { get; set; }
        public Vector3 Forward
        {
            get
            {
                //TODO: Alex will make this return a vector that points Forward based on camera rotation
                return new Vector3(1, 0, 1).Normalized;
                //return new Vector3(0,0,1);
            }
        }
        public Vector3 Up
        {
            get
            {
                //TODO: Alex will make this return a vector that points Up based on camera rotation
                return new Vector3(0, 1, 0).Normalized;
                //return new Vector3(0, 1, 0);
            }
        }
        public Vector3 Right
        {
            get
            {
                //TODO: Alex will make this return a vector that points Right based on camera rotation
                return new Vector3(1, 0, -1).Normalized;
                //return new Vector3(1, 0, 0);
            }
        }

        private Bitmap image;
        private List<Vector3I> hitVoxels;
        private bool bitmapNeedsUpdate;

        public Camera()
        {
            Position = new Vector3(-1f, 0f, -1f);
            Background = Color.Black;
            Height = 256;
            Width = 256;
            OrthographicSize = 3;
            RayStep = 0.05f;
            image = new Bitmap(Height, Width);
            hitVoxels = new List<Vector3I>(200);
        }

        public Bitmap Render(Voxelmap map)
        {
            if (bitmapNeedsUpdate)
            {
                image = new Bitmap(Height, Width);
            }
            Vector3 rayStep = Forward * RayStep;
            float rayMaxLength = 5;//quickly set so that I can test the render;
            for (int bitmapX = 0; bitmapX < image.Width; bitmapX++)
            {
                for (int bitmapY = 0; bitmapY < image.Height; bitmapY++)
                {
                    hitVoxels.Clear();
                    Vector3 rayPoint = (bitmapX / PixelsPerUnit - OrthographicSize / 2f) * Right + (bitmapY / PixelsPerUnit - OrthographicSize / 2f) * Up + Position;
                    while ((rayPoint - Position).Magnitude < rayMaxLength)
                    {
                        int x = (int)Math.Round(rayPoint.X);
                        int y = (int)Math.Round(rayPoint.Y);
                        int z = (int)Math.Round(rayPoint.Z);
                        if (map.ContainsPoint(x, y, z))
                        {
                            Vector3I voxPoint = new Vector3I(x, y, z);
                            if (!hitVoxels.Contains(voxPoint))
                            {
                                hitVoxels.Add(voxPoint);
                            }
                        }
                        rayPoint = rayPoint + rayStep;
                    }
                    Color col = Background;
                    for (int i = hitVoxels.Count - 1; i >= 0; i--)
                    {
                        float alpha = map[hitVoxels[i].X, hitVoxels[i].Y, hitVoxels[i].Z].A / 255f;
                        col = Color.FromArgb(
                            (int)(col.R * (1 - alpha) + (int)(map[hitVoxels[i].X, hitVoxels[i].Y, hitVoxels[i].Z].R * alpha)),
                            (int)(col.G * (1 - alpha) + (int)(map[hitVoxels[i].X, hitVoxels[i].Y, hitVoxels[i].Z].G * alpha)),
                            (int)(col.B * (1 - alpha) + (int)(map[hitVoxels[i].X, hitVoxels[i].Y, hitVoxels[i].Z].B * alpha))
                            );
                    }
                    image.SetPixel(bitmapX, bitmapY, col);
                }
            }

            return image;
        }

        public void UpdateBitmap()
        {
            bitmapNeedsUpdate = true;
        }
    }
}
