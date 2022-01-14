using System.IO;

namespace WolvenKit.Interfaces.Extensions
{
    public static class StreamExtensions
    {
        public static byte[] ToByteArray(this Stream input, bool keepPosition = false)
        {
            if (input is MemoryStream memoryStream)
            {
                return memoryStream.ToArray();
            }
            else
            {
                using var ms = new MemoryStream();
                if (!keepPosition)
                {
                    input.Position = 0;
                }
                input.CopyTo(ms);
                return ms.ToArray();

            }
        }
    }
}
