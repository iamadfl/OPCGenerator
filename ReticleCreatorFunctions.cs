using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reticle_OPC_Generator
{
    class ReticleCreatorFunctions
    {
        public static Bitmap removeColor(Bitmap image)
        {
            Bitmap myBitmap = new Bitmap(image);
            const float limit = 0.3f;
            for (int i = 0; i < myBitmap.Width; i++)
            {
                for (int j = 0; j < myBitmap.Height; j++)
                {
                    Color c = myBitmap.GetPixel(i, j);
                    if (c.GetBrightness() > limit)
                    {
                        myBitmap.SetPixel(i, j, Color.White);
                    }
                    else
                    {
                        myBitmap.SetPixel(i, j, Color.Black);
                    }
                }
            }

            return myBitmap;
        }

        public static Bitmap invertImage(Bitmap image)
        {
            Bitmap bmp = image;
            int width = bmp.Width;
            int height = bmp.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);

                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;

                    bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            return bmp;
        }

        public static void getShapeareas()
        {

        }

    }
}
