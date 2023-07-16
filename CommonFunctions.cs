using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reticle_OPC_Generator
{
    class CommonFunctions
    {
        public static Tuple<Bitmap,string> OpenImage()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                Bitmap image = new Bitmap(open.FileName);
                var file = Tuple.Create(image, open.FileName);
                return file;
            }
            else
            {
                return null;

            }


        }
        
        public static void saveImage(Image image)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Jpeg;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(dialog.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                try
                {
                    image.Save(dialog.FileName, format);
                }
                catch
                {
                    MessageBox.Show("Error detected in saving file.\nPlease try again with a different file name");
                    saveImage(image);
                }
            }
        }
    }
}
