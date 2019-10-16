using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Li.Drawing
{
    public class Picture
    {
        public struct ARGB
        {
            public byte A
            {
                get;
                set;
            }

            public byte R
            {
                get;
                set;
            }

            public byte G
            {
                get;
                set;
            }

            public byte B
            {
                get;
                set;
            }

            public ARGB(byte a, byte r, byte g, byte b)
            {
                A = a;
                R = r;
                G = g;
                B = b;
            }
        }
        /// <summary>
        /// 获取图片的有效区所在的Rectangle。默认留空白4
        /// </summary>
        /// <param name="pic">需要检测的图片。</param>
        /// <returns>范围</returns>
        public static Rectangle GetRectFromPictureWithouBlank(Bitmap pic)
        {
            return GetRectFromPictureWithoutBlankUsBitmapData(pic, 4);
        }

        [Obsolete("性能太慢。")]
        public static Rectangle GetRectFromPictureWithoutBlank(Bitmap pic, int keep)
        {
            int num = 0;
            int num2 = 0;
            int width = pic.Width;
            int height = pic.Height;
            for (int i = 0; i < width; i++)
            {
                bool flag = false;
                for (int j = 0; j < height - 1; j++)
                {
                    if (Convert.ToInt32(pic.GetPixel(i, j).A) != 0)
                    {
                        num = i;
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            for (int k = 0; k < height; k++)
            {
                bool flag2 = false;
                for (int l = 0; l < width - 1; l++)
                {
                    if (Convert.ToInt32(pic.GetPixel(l, k).A) != 0)
                    {
                        num2 = k;
                        flag2 = true;
                        break;
                    }
                }
                if (flag2)
                {
                    break;
                }
            }
            int num3 = 0;
            int num4 = 0;
            for (int num5 = width - 1; num5 >= 0; num5--)
            {
                bool flag3 = false;
                for (int num6 = height - 1; num6 >= 0; num6--)
                {
                    if (Convert.ToInt32(pic.GetPixel(num5, num6).A) != 0)
                    {
                        num3 = num5;
                        flag3 = true;
                        break;
                    }
                }
                if (flag3)
                {
                    break;
                }
            }
            for (int num7 = height - 1; num7 >= 0; num7--)
            {
                bool flag4 = false;
                for (int num8 = width - 1; num8 >= 0; num8--)
                {
                    if (Convert.ToInt32(pic.GetPixel(num8, num7).A) != 0)
                    {
                        num4 = num7;
                        flag4 = true;
                        break;
                    }
                }
                if (flag4)
                {
                    break;
                }
            }
            Rectangle result = default(Rectangle);
            if (num >= keep)
            {
                result.X = num - keep;
            }
            else
            {
                result.X = num;
            }
            if (num2 >= keep)
            {
                result.Y = num2 - keep;
            }
            else
            {
                result.Y = num2;
            }
            if (num3 >= width - keep)
            {
                result.Width = num3 - result.X + 1;
            }
            else
            {
                result.Width = num3 - result.X + keep + 1;
            }
            if (num4 >= height - keep)
            {
                result.Height = num4 - result.Y + 1;
            }
            else
            {
                result.Height = num4 - result.Y + keep + 1;
            }
            return result;
        }
        /// <summary>
        /// 获取图片的有效区所在的Rectangle。
        /// </summary>
        /// <param name="pic">需要检测的图片。</param>
        /// <param name="keep">需要保留的边的像素。</param>
        /// <returns>范围</returns>
        public static Rectangle GetRectFromPictureWithoutBlankUsBitmapData(Bitmap pic, int keep)
        {
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int width = pic.Width;
            int height = pic.Height;
            BitmapData bitmapData = pic.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, pic.PixelFormat);
            IntPtr scan = bitmapData.Scan0;
            int num5 = Math.Abs(bitmapData.Stride) * height;
            byte[] array = new byte[num5];
            Marshal.Copy(scan, array, 0, num5);
            for (int i = 0; i < bitmapData.Stride; i += 4)
            {
                bool flag = false;
                for (int j = 0; j < height - 1; j++)
                {
                    if (array[bitmapData.Stride * j + i + 3] != 0)
                    {
                        num = i / 4;
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            for (int k = 0; k < height; k++)
            {
                bool flag2 = false;
                for (int l = 0; l < bitmapData.Stride - 1; l += 4)
                {
                    if (array[bitmapData.Stride * k + l + 3] != 0)
                    {
                        num2 = k;
                        flag2 = true;
                        break;
                    }
                }
                if (flag2)
                {
                    break;
                }
            }
            for (int num6 = bitmapData.Stride; num6 > 0; num6 -= 4)
            {
                bool flag3 = false;
                for (int num7 = height - 1; num7 > 0; num7--)
                {
                    if (array[bitmapData.Stride * num7 + num6 - 1] != 0)
                    {
                        num3 = num6 / 4;
                        flag3 = true;
                        break;
                    }
                }
                if (flag3)
                {
                    break;
                }
            }
            for (int num8 = height - 1; num8 > 0; num8--)
            {
                bool flag4 = false;
                for (int num9 = bitmapData.Stride; num9 > 0; num9 -= 4)
                {
                    if (array[bitmapData.Stride * num8 + num9 - 1] != 0)
                    {
                        num4 = num8 + 1;
                        flag4 = true;
                        break;
                    }
                }
                if (flag4)
                {
                    break;
                }
            }
            pic.UnlockBits(bitmapData);
            Rectangle result = default;
            if (num >= keep)
            {
                result.X = num - keep;
            }
            else
            {
                result.X = num;
            }
            if (num2 >= keep)
            {
                result.Y = num2 - keep;
            }
            else
            {
                result.Y = num2;
            }
            if (num3 >= width - keep)
            {
                result.Width = num3 - result.X;
            }
            else
            {
                result.Width = num3 - result.X + keep;
            }
            if (num4 >= height - keep)
            {
                result.Height = num4 - result.Y;
            }
            else
            {
                result.Height = num4 - result.Y + keep;
            }
            return result;
        }

        public static Bitmap CreatBackImage(int w, int h)
        {
            Bitmap bitmap = new Bitmap(w, h);

            Bitmap BlackBlock = new Bitmap(10, 10);
            using (Graphics gh = Graphics.FromImage(BlackBlock))
            {
                gh.FillRectangle(Brushes.Gray, new Rectangle(0, 0, 10, 10));
            }
            Bitmap WhiteBlock = new Bitmap(10, 10);
            using (Graphics gh = Graphics.FromImage(WhiteBlock))
            {
                gh.FillRectangle(Brushes.White, new Rectangle(0, 0, 10, 10));
            }

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.FromArgb(0, 0, 0, 0));
                for (int k = 0; k <= h / 10; k++)
                {
                    for (int c = 0; c <= w / (10 + 10); c++)
                    {
                        if (k % 2 == 1)
                        {
                            g.DrawImage(BlackBlock, new Point(0 + 20 * c + 10,
                                                              0 + 10 * k));
                            g.DrawImage(WhiteBlock, new Point(0 + c * 20,
                                                              0 + 10 * k));
                        }
                        else
                        {
                            g.DrawImage(BlackBlock, new Point(0 + c * 20,
                                                              0 + 10 * k));
                            g.DrawImage(WhiteBlock, new Point(0 + 20 * c + 10,
                                                              0 + 10 * k));
                        }
                    }
                }
            }

            return bitmap;
        }
        /// <summary>
        /// 获取alpha透明的ImageAttributes。叠加用。
        /// </summary>
        /// <param name="opcity">透明度。（0 ~ 255）</param>
        /// <returns></returns>
        public static ImageAttributes GetAlphaImgAttr(int opcity)
        {
            if (opcity < 0 || opcity > 255)
            {
                throw new ArgumentOutOfRangeException("opcity 值为 0~255");
            }
            //颜色矩阵
            float[][] matrixItems =
            {
                new float[]{1,0,0,0,0},
                new float[]{0,1,0,0,0},
                new float[]{0,0,1,0,0},
                new float[]{0,0,0,(float)opcity / 255,0},
                new float[]{0,0,0,0,1}
            };
            ColorMatrix colorMatrix = new ColorMatrix(matrixItems);
            ImageAttributes imageAtt = new ImageAttributes();
            imageAtt.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            return imageAtt;
        }
    }
}
