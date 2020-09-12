using System;
using System.IO;
using System.Text;

namespace WolvenKit.W3SavegameEditor.Core.ChunkedLz4
{
    public class ChunkedLz4FileHeader
    {
        public int ChunkCount { get; set; }
        public int HeaderSize { get; set; }

        public static ChunkedLz4FileHeader Read(Stream input)
        {
            using (var reader = new BinaryReader(input, Encoding.ASCII, true))
            {
                string saveFileHeader = reader.ReadString(4);
                if (saveFileHeader != "SNFH")
                {
                    throw new InvalidOperationException();
                }

                string chunkedLz4FileHeader = reader.ReadString(4);
                if (chunkedLz4FileHeader != "FZLC")
                {
                    throw new InvalidOperationException();
                }

                return new ChunkedLz4FileHeader
                {
                    ChunkCount = reader.ReadInt32(),
                    HeaderSize = reader.ReadInt32()
                };
            }
        }
    }
}