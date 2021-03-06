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
        public enum RenderModeEnum
        {
            MIP,
            Color
        }
        public Vector3 Position { get; set; }
        public Color Background { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public float PixelsPerUnit { get { return Height / OrthographicSize; } }
        public float OrthographicSize { get; set; }
        public RenderModeEnum RenderMode { get; set; }
        public float RayStep { get; set; }
        public float Pitch { get; set; }
        public float Yaw { get; set; }
        public Vector3 Forward
        {
            get
            {
                return new Vector3((float)Math.Cos(Yaw) * (float)Math.Cos(Pitch), (float)Math.Sin(Pitch), (float)Math.Sin(Yaw) * (float)Math.Cos(Pitch)).Normalized;
                //return new Vector3(0,0,1);
            }
        }
        public Vector3 Up
        {
            get
            {
                return -1 * new Vector3((float)Math.Cos(Yaw) * (float)Math.Sin(Pitch), -(float)Math.Sin(Yaw) * (float)Math.Sin(Yaw) * (float)Math.Cos(Pitch) - (float)Math.Cos(Yaw) * (float)Math.Cos(Pitch) * (float)Math.Cos(Yaw), (float)Math.Sin(Yaw) * (float)Math.Sin(Pitch)).Normalized;
                //return new Vector3(0, 1, 0);
            }
        }
        public Vector3 Right
        {
            get
            {
                return -1 * new Vector3((float)Math.Sin(Yaw), 0, -(float)Math.Cos(Yaw)).Normalized;
                //return new Vector3(1, 0, 0);
            }
        }

        private Bitmap image;
        private List<Vector3I> hitVoxels;
        private bool bitmapNeedsUpdate;

        public Camera()
        {
            Position = new Vector3(-1f, 1f, -1f);
            Background = Color.Black;
            Height = 256;
            Width = 256;
            OrthographicSize = 3;
            RenderMode = RenderModeEnum.Color;
            RayStep = 0.05f;
            image = new Bitmap(Height, Width);
            Pitch = (float)Math.PI / 4;
            Yaw = (float)Math.PI / 4;
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
                    switch (RenderMode)
                    {
                        case RenderModeEnum.MIP:
                            float intensity = 0;
                            for (int i = 0; i < hitVoxels.Count; i++)
                            {
                                Color voxCol = map[hitVoxels[i].X, hitVoxels[i].Y, hitVoxels[i].Z];
                                float voxInten = voxCol.GetBrightness();
                                if (voxInten > intensity)
                                {
                                    intensity = voxInten;
                                }
                            }
                            int colorVal = (int)(255 * intensity);
                            image.SetPixel(bitmapX, bitmapY, Color.FromArgb(colorVal, colorVal, colorVal));
                            break;
                        case RenderModeEnum.Color:
                            Color col = Background;
                            for (int i = hitVoxels.Count - 1; i >= 0; i--)
                            {
                                Vector3I cords = hitVoxels[i];
                                Color voxCol = map[cords.X, cords.Y, cords.Z];
                                float alpha = voxCol.A / 255f;
                                col = Color.FromArgb(
                                    (int)(col.R * (1 - alpha) + (int)(voxCol.R * alpha)),
                                    (int)(col.G * (1 - alpha) + (int)(voxCol.G * alpha)),
                                    (int)(col.B * (1 - alpha) + (int)(voxCol.B * alpha))
                                    );
                            }
                            image.SetPixel(bitmapX, bitmapY, col);
                            break;
                        default:
                            break;
                    }
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
