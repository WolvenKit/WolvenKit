using System;
using System.IO;
using System.Runtime.InteropServices;
using RED.CRC32;

namespace WolvenKit.Common.Extensions

{
    public static class StreamExtensions
    {
        
        //https://stackoverflow.com/a/13022108
        public static void CopyToWithLength(this Stream input, Stream output, int bytes)
        {
            var buffer = new byte[4096];
            int read;
            while (bytes > 0 &&
                   (read = input.Read(buffer, 0, Math.Min(buffer.Length, bytes))) > 0)
            {
                output.Write(buffer, 0, read);
                bytes -= read;
            }
        }
    }
}
