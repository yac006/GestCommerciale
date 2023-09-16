using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestCommerciale.BL
{
    internal class Methods
    {
        public MemoryStream ma = new MemoryStream();
        public byte[] by { get; set; }


        //Converter vers Byte
        public byte[] convert_byte(string cheminImage)
        {
            // Lire l'image et la convertir en tableau de bytes
            using (FileStream fs = new FileStream(cheminImage, FileMode.Open, FileAccess.Read))
            {
                BinaryReader br = new BinaryReader(fs);
                return br.ReadBytes((int)fs.Length);
            }           
        }

        //Converter vers byte vers image (stream)
        public MemoryStream convert_image()
        {
            ma = new MemoryStream(by);
            return ma;
        }
    }
}
