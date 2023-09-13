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
        public Byte[] by;

        //Converter vers Byte
        public byte[] convert_byte()
        {
            return ma.ToArray();
        }
        //Converter vers byte vers image (stream)
        public MemoryStream convert_image()
        {
            ma = new MemoryStream(by);
            return ma;
        }
    }
}
