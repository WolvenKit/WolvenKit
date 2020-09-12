using System.Diagnostics;
using System.IO;
using System.Linq;

namespace WolvenKit.W3SavegameEditor.Core.ChunkedLz4
{
    public static class ChunkedLz4File
    {
        public static Stream Decompress(Stream input)
        {
            ChunkedLz4FileHeader header = ChunkedLz4FileHeader.Read(input);
            var table = ChunkedLz4FileTable.Read(input, header.ChunkCount);
            input.Position = header.HeaderSize;

            var data = new byte[header.HeaderSize + table.Chunks.Sum(c => c.DecompressedChunkSize)];
            var memoryStream = new MemoryStream(data) { Position = header.HeaderSize };
            foreach (var chunk in table.Chunks)
            {
                byte[] chunkData = chunk.Read(input);
                memoryStream.Write(chunkData, 0, chunkData.Length);
                Debug.Assert(input.Position == chunk.EndOfChunkOffset || chunk.EndOfChunkOffset == 0);
            }

            memoryStream.Position = header.HeaderSize;
            return memoryStream;
        }
    }
}