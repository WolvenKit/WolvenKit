using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Interfaces.Extensions
{
    public static class StreamExtensions
    {
        public static byte[] ToByteArray(this Stream input)
        {
            if (input is MemoryStream memoryStream)
            {
                return memoryStream.ToArray();
            }
            else
            {
                using var ms = new MemoryStream();
                input.Position = 0;
                input.CopyTo(ms);
                return ms.ToArray();

            }
        }
    }
}
