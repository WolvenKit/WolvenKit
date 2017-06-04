using System;
using System.IO;

namespace WolvenKit.W3Speech
{
    public static class StreamTools
    {
        /// <summary>
        /// Helper function to skip a lot of bytes quickly. 
        /// </summary>
        /// <param name="amount">Total amount of bytes to skip in the stream.</param>
        /// <param name="stream">The stream.</param>
        /// <exception cref="Exception">Something happened.</exception>
        public static void Skip(UInt64 amount, Stream stream)
        {
            if (stream.CanSeek)
            {
                stream.Seek((long)(amount), SeekOrigin.Current);
            }
            else
            {
                UInt32 buffer_size = 1024;
                var buffer = new byte[buffer_size];
                UInt64 total_bytes_read = 0;
                while (total_bytes_read < amount)
                {
                    var bytes_left = amount - total_bytes_read;
                    var bytes_to_read = bytes_left < buffer_size ? bytes_left : buffer_size;
                    var bytes_read = stream.Read(buffer, 0, (int)bytes_to_read);
                    total_bytes_read += (UInt64)bytes_read;
                }
            }
        }

        /// <summary>
        /// Helper function to read and write a lot of bytes quickly.
        /// </summary>
        /// <param name="amount">Total amount of bytes to copy from one stream to the other.</param>
        /// <param name="input">The input stream to read from.</param>
        /// <param name="output">The output stream to write to.</param>
        /// <exception cref="Exception">Something happened.</exception>
        public static void Transfer(UInt64 amount, Stream input, Stream output)
        {
            UInt32 buffer_size = 1024;
            var buffer = new byte[buffer_size];
            UInt64 total_bytes_read = 0;
            while (total_bytes_read < amount)
            {
                var bytes_left = amount - total_bytes_read;
                var bytes_to_read = bytes_left < buffer_size ? bytes_left : buffer_size;
                var bytes_read = input.Read(buffer, 0, (int)bytes_to_read);
                total_bytes_read += (UInt64)bytes_read;
                output.Write(buffer, 0, bytes_read);
            }
        }
    }
}
