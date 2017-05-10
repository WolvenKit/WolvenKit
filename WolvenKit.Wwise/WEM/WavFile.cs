using System;
using System.Collections.Generic;
using System.IO;

namespace WolvenKit.Wwise.WEM
{
    public class WavFile
    {
        public enum WaveFormatCategories
        {
            Pcm = 1,
            MsAdpcm = 2,
            IeeeFloat = 3,
            ALaw = 6,
            MuLaw = 7
        }

        private Dictionary<string, ChunkParser> _chunkParsers;
        private Dictionary<string, ChunkUpdater> _chunkUpdaters;
        private RiffFile _riffFile;

        private WavFile()
        {
        }

        public WavFile(Stream inStream) : this()
        {
            ParseStream(inStream);
        }

        public WavFile(string filename) : this()
        {
            LoadFile(filename);
        }

        public ushort FormatTag { get; set; }
        public ushort Channels { get; set; }
        public uint SamplesPerSec { get; set; }
        public uint AvgBytesPerSec { get; set; }
        public ushort BlockAlign { get; set; }
        public ushort BitsPerSample { get; set; }

        public ushort FormatExtensionSize => Convert.ToUInt16(FormatExtension.Length);

        public byte[] FormatExtension { get; set; }
        public byte[] AudioData { get; set; }

        public void WriteFile(string filename)
        {
            foreach (var chunk in _riffFile.Root.Subchunks)
            {
                var id = chunk.Id;
                if (!(id == "fmt "))
                {
                    if (id == "data")
                        UpdateDataChunk(chunk);
                }
                else
                    UpdateFormatChunk(chunk);
            }
            _riffFile.WriteFile(filename);
        }

        private void LoadFile(string filename)
        {
            using (var fileStream = File.OpenRead(filename))
                ParseStream(fileStream);
        }

        private void ParseStream(Stream stream)
        {
            _riffFile = new RiffFile(stream);
            foreach (var chunk in _riffFile.Root.Subchunks)
            {
                var id = chunk.Id;
                if (!(id == "fmt "))
                {
                    if (id == "data")
                        ParseDataChunk(chunk);
                }
                else
                    ParseFormatChunk(chunk);
            }
        }

        private void ParseFormatChunk(RiffChunk chunk)
        {
            var binaryReader = new BinaryReader(new MemoryStream(chunk.Data));
            FormatTag = binaryReader.ReadUInt16();
            Channels = binaryReader.ReadUInt16();
            SamplesPerSec = binaryReader.ReadUInt32();
            AvgBytesPerSec = binaryReader.ReadUInt32();
            BlockAlign = binaryReader.ReadUInt16();
            if (binaryReader.BaseStream.Length - binaryReader.BaseStream.Position > 0L)
                BitsPerSample = binaryReader.ReadUInt16();
            if (binaryReader.BaseStream.Length - binaryReader.BaseStream.Position > 0L)
            {
                int count = binaryReader.ReadUInt16();
                FormatExtension = binaryReader.ReadBytes(count);
            }
            binaryReader.Close();
        }

        private void ParseDataChunk(RiffChunk chunk)
        {
            AudioData = chunk.Data;
        }

        private void UpdateFormatChunk(RiffChunk chunk)
        {
            using (var memoryStream = new MemoryStream(22))
            {
                var binaryWriter = new BinaryWriter(memoryStream);
                binaryWriter.Write(FormatTag);
                binaryWriter.Write(Channels);
                binaryWriter.Write(SamplesPerSec);
                binaryWriter.Write(AvgBytesPerSec);
                binaryWriter.Write(BlockAlign);
                binaryWriter.Write(BitsPerSample);
                if (FormatExtension != null)
                {
                    binaryWriter.Write((ushort) FormatExtension.Length);
                    binaryWriter.Write(FormatExtension);
                }
                else
                    binaryWriter.Write((ushort) 0);
                chunk.Data = memoryStream.ToArray();
            }
        }

        private void UpdateDataChunk(RiffChunk chunk)
        {
            chunk.Data = AudioData;
        }

        private delegate void ChunkParser(RiffChunk chunk);

        private delegate void ChunkUpdater(RiffChunk chunk);
    }
}