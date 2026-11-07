using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    public class PictureBox
    {
        public byte[] ImageToByteArray(Image image)
        {
            if (image == null)
                return null;

            using (MemoryStream mMemoryStream = new MemoryStream())
            {
                ImageFormat format = ImageFormat.Png;

                if (image.RawFormat != null &&
                    !image.RawFormat.Equals(ImageFormat.MemoryBmp))
                {
                    format = image.RawFormat;
                }

                using (Bitmap cloneBitmap = new Bitmap(image))
                {
                    cloneBitmap.Save(mMemoryStream, format);
                }

                return mMemoryStream.ToArray();
            }

        }

                    
            
    }
}
