using System.Diagnostics;
using System.IO;
using LZ4PCL;

namespace W3SavegameEditor.Core.ChunkedLz4
{
    public class Lz4Chunk
    {
        public int CompressedChunkSize { get; set; }

        public int DecompressedChunkSize { get; set; }

        public int EndOfChunkOffset { get; set; }

        public byte[] Read(Stream inputStream)
        {
            byte[] inputData = new byte[CompressedChunkSize];
            byte[] outputData = new byte[DecompressedChunkSize];

            inputStream.Read(inputData, 0, CompressedChunkSize);
            unsafe
            {
                fixed (byte* input = inputData)
                fixed (byte* output = outputData)
                {
                    int bytesDecoded = LZ4Codec.Decode32(input, inputData.Length, output, outputData.Length, true);
                    Debug.Assert(bytesDecoded == DecompressedChunkSize);
                }

                Debug.Assert(inputStream.Position == EndOfChunkOffset || EndOfChunkOffset == 0);
            }

            return outputData;
        }
    }
}