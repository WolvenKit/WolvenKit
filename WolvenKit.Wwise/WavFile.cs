using System;
using System.Collections.Generic;
using System.IO;

namespace Orangelynx.Multimedia
{
  public class WavFile
  {
    private RiffFile RiffFile_;
    private Dictionary<string, WavFile.ChunkParser> ChunkParsers_;
    private Dictionary<string, WavFile.ChunkUpdater> ChunkUpdaters_;

    public ushort FormatTag { get; set; }

    public ushort Channels { get; set; }

    public uint SamplesPerSec { get; set; }

    public uint AvgBytesPerSec { get; set; }

    public ushort BlockAlign { get; set; }

    public ushort BitsPerSample { get; set; }

    public ushort FormatExtensionSize
    {
      get
      {
        return Convert.ToUInt16(this.FormatExtension.Length);
      }
    }

    public byte[] FormatExtension { get; set; }

    public byte[] AudioData { get; set; }

    private WavFile()
    {
    }

    public WavFile(Stream inStream)
      : this()
    {
      this.ParseStream(inStream);
    }

    public WavFile(string filename)
      : this()
    {
      this.LoadFile(filename);
    }

    public void WriteFile(string filename)
    {
      foreach (RiffChunk chunk in this.RiffFile_.Root.Subchunks)
      {
        string id = chunk.ID;
        if (!(id == "fmt "))
        {
          if (id == "data")
            this.UpdateDataChunk(chunk);
        }
        else
          this.UpdateFormatChunk(chunk);
      }
      this.RiffFile_.WriteFile(filename);
    }

    private void LoadFile(string filename)
    {
      using (FileStream fileStream = File.OpenRead(filename))
        this.ParseStream((Stream) fileStream);
    }

    private void ParseStream(Stream stream)
    {
      this.RiffFile_ = new RiffFile(stream);
      foreach (RiffChunk chunk in this.RiffFile_.Root.Subchunks)
      {
        string id = chunk.ID;
        if (!(id == "fmt "))
        {
          if (id == "data")
            this.ParseDataChunk(chunk);
        }
        else
          this.ParseFormatChunk(chunk);
      }
    }

    private void ParseFormatChunk(RiffChunk chunk)
    {
      BinaryReader binaryReader = new BinaryReader((Stream) new MemoryStream(chunk.Data));
      this.FormatTag = binaryReader.ReadUInt16();
      this.Channels = binaryReader.ReadUInt16();
      this.SamplesPerSec = binaryReader.ReadUInt32();
      this.AvgBytesPerSec = binaryReader.ReadUInt32();
      this.BlockAlign = binaryReader.ReadUInt16();
      if (binaryReader.BaseStream.Length - binaryReader.BaseStream.Position > 0L)
        this.BitsPerSample = binaryReader.ReadUInt16();
      if (binaryReader.BaseStream.Length - binaryReader.BaseStream.Position > 0L)
      {
        int count = (int) binaryReader.ReadUInt16();
        this.FormatExtension = binaryReader.ReadBytes(count);
      }
      binaryReader.Close();
    }

    private void ParseDataChunk(RiffChunk chunk)
    {
      this.AudioData = chunk.Data;
    }

    private void UpdateFormatChunk(RiffChunk chunk)
    {
      using (MemoryStream memoryStream = new MemoryStream(22))
      {
        BinaryWriter binaryWriter = new BinaryWriter((Stream) memoryStream);
        binaryWriter.Write(this.FormatTag);
        binaryWriter.Write(this.Channels);
        binaryWriter.Write(this.SamplesPerSec);
        binaryWriter.Write(this.AvgBytesPerSec);
        binaryWriter.Write(this.BlockAlign);
        binaryWriter.Write(this.BitsPerSample);
        if (this.FormatExtension != null)
        {
          binaryWriter.Write((ushort) this.FormatExtension.Length);
          binaryWriter.Write(this.FormatExtension);
        }
        else
          binaryWriter.Write((ushort) 0);
        chunk.Data = memoryStream.ToArray();
      }
    }

    private void UpdateDataChunk(RiffChunk chunk)
    {
      chunk.Data = this.AudioData;
    }

    public enum WAVEFormatCategories
    {
      PCM = 1,
      MS_ADPCM = 2,
      IEEE_FLOAT = 3,
      A_LAW = 6,
      MU_LAW = 7,
    }

    private delegate void ChunkParser(RiffChunk chunk);

    private delegate void ChunkUpdater(RiffChunk chunk);
  }
}
