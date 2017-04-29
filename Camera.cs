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

        private Bitmap image;
        private List<Vector3I> hitVoxels;
        private bool bitmapNeedsUpdate;

        Vector3 lookDirection = new Vector3(0, 0, 1);//this will be replaces

        public Camera()
        {
            Position = new Vector3(0f, 0f, -1f);
            Background = Color.Red;
            Height = 256;
            Width = 256;
            OrthographicSize = 3;
            RayStep = 0.5f;
            image = new Bitmap(Height, Width);
            hitVoxels = new List<Vector3I>(200);
        }

        public Bitmap Render(Voxelmap map)
        {
            if (bitmapNeedsUpdate)
            {
                image = new Bitmap(Height, Width);
            }
            Vector3 rayStep = lookDirection * RayStep;
            float rayMaxLength = 10;//quickly set so that I can test the render;
            for (int bitmapX = 0; bitmapX < image.Width; bitmapX++)
            {
                for (int bitmapY = 0; bitmapY < image.Height; bitmapY++)
                {
                    hitVoxels.Clear();
                    Vector3 rayPoint = new Vector3(bitmapX / PixelsPerUnit, bitmapY / PixelsPerUnit, 0) + Position;
                    rayPoint = rayPoint - new Vector3(OrthographicSize / 2, OrthographicSize / 2, 0);
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
