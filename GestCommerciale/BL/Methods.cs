using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace GestCommerciale.BL
{
    internal class Methods
    {

        //Converter vers Bytes
        public byte[] getJPGFromImageControl(BitmapImage imageC)
        {
            MemoryStream memStream = new MemoryStream();
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(imageC));
            encoder.Save(memStream);
            return memStream.ToArray();
        }



        //Converter vers Memory Stream "Image"
        public BitmapImage LoadImage(byte[] imageData)
        {
            var image = new BitmapImage();
            using (var memStream = new MemoryStream(imageData))
            {
                memStream.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = memStream;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }



    }
}
