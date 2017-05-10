using System;
using System.IO;
using System.Text;

// ReSharper disable RedundantJumpStatement

namespace WolvenKit.Wwise.WEM
{
    public class RiffFile
    {
        protected RiffChunk RootChunk;

        public RiffFile(Stream inStream)
        {
            ParseChunk(inStream, out RootChunk);
        }

        public RiffFile(string filename)
        {
            LoadFile(filename);
        }

        public long Size => RootChunk.Size + 8L;

        public string Type => Encoding.ASCII.GetString(RootChunk.Data);

        public RiffChunk Root => RootChunk;

        public void WriteFile(string filename)
        {
            var fileStream = File.Create(filename);
            WriteChunk(RootChunk, fileStream);
            fileStream.Close();
        }

        private void ParseChunk(Stream input, out RiffChunk chunk)
        {
            var binaryReader = new BinaryReader(input);
            if (input.Length - input.Position < 8L)
                throw new ArgumentException("not a valid RIFF chunk - too short", nameof(input));
            var magic = Encoding.ASCII.GetString(binaryReader.ReadBytes(4));
            long num1 = binaryReader.ReadUInt32();
            chunk = new RiffChunk(magic);
            if (magic == "LIST" || magic == "RIFF")
            {
                chunk.Data = binaryReader.ReadBytes(4);
                ParseSubchunks(input, chunk, num1 - 4L);
            }
            else
                chunk.Data = binaryReader.ReadBytes(Convert.ToInt32(num1));
            if (num1%2L == 0L)
                return;
            //int num2 = binaryReader.ReadByte(); 0x00 always and sometimes missing so should be ignored
            //TODO: Check this if it causes errors.
        }

        private void ParseSubchunks(Stream input, RiffChunk chunk, long size)
        {
            var num = input.Position + size;
            while (num - input.Position > 8L)
            {
                RiffChunk chunk1;
                ParseChunk(input, out chunk1);
                chunk.AddSubchunk(chunk1);
            }
            input.Position = num;
        }

        private void LoadFile(string filename)
        {
            using (var fileStream = File.OpenRead(filename))
                ParseChunk(fileStream, out RootChunk);
        }

        private static void WriteChunk(RiffChunk chunk, Stream stream)
        {
            var binaryWriter = new BinaryWriter(stream);
            binaryWriter.Write(Encoding.ASCII.GetBytes(chunk.Id));
            binaryWriter.Write((uint) chunk.Size);
            binaryWriter.Write(chunk.Data);
            foreach (var chunk1 in chunk.Subchunks)
                WriteChunk(chunk1, stream);
            if (chunk.Size%2L == 0L)
                return;
            binaryWriter.Write((byte) 0);
        }
    }
}