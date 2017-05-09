using System;
using System.IO;
using System.Text;

namespace Orangelynx.Multimedia
{
  public class RiffFile
  {
    protected RiffChunk RootChunk_;

    public long Size
    {
      get
      {
        return this.RootChunk_.Size + 8L;
      }
    }

    public string Type
    {
      get
      {
        return Encoding.ASCII.GetString(this.RootChunk_.Data);
      }
    }

    public RiffChunk Root
    {
      get
      {
        return this.RootChunk_;
      }
    }

    public RiffFile(Stream inStream)
    {
      this.ParseChunk(inStream, out this.RootChunk_);
    }

    public RiffFile(string filename)
    {
      this.LoadFile(filename);
    }

    public void WriteFile(string filename)
    {
      FileStream fileStream = File.Create(filename);
      this.WriteChunk(this.RootChunk_, (Stream) fileStream);
      fileStream.Close();
    }

    private void ParseChunk(Stream input, out RiffChunk chunk)
    {
      BinaryReader binaryReader = new BinaryReader(input);
      if (input.Length - input.Position < 8L)
        throw new ArgumentException("not a valid RIFF chunk - too short", "input");
      string @string = Encoding.ASCII.GetString(binaryReader.ReadBytes(4));
      long num1 = (long) binaryReader.ReadUInt32();
      chunk = new RiffChunk(@string);
      if (@string == "LIST" || @string == "RIFF")
      {
        chunk.Data = binaryReader.ReadBytes(4);
        this.ParseSubchunks(input, chunk, num1 - 4L);
      }
      else
        chunk.Data = binaryReader.ReadBytes(Convert.ToInt32(num1));
      if (num1 % 2L == 0L)
        return;
      int num2 = (int) binaryReader.ReadByte();
    }

    private void ParseSubchunks(Stream input, RiffChunk chunk, long size)
    {
      long num = input.Position + size;
      while (num - input.Position > 8L)
      {
        RiffChunk chunk1;
        this.ParseChunk(input, out chunk1);
        chunk.AddSubchunk(chunk1);
      }
      input.Position = num;
    }

    private void LoadFile(string filename)
    {
      using (FileStream fileStream = File.OpenRead(filename))
        this.ParseChunk((Stream) fileStream, out this.RootChunk_);
    }

    private void WriteChunk(RiffChunk chunk, Stream stream)
    {
      BinaryWriter binaryWriter = new BinaryWriter(stream);
      binaryWriter.Write(Encoding.ASCII.GetBytes(chunk.ID));
      binaryWriter.Write((uint) chunk.Size);
      binaryWriter.Write(chunk.Data);
      foreach (RiffChunk chunk1 in chunk.Subchunks)
        this.WriteChunk(chunk1, stream);
      if (chunk.Size % 2L == 0L)
        return;
      binaryWriter.Write((byte) 0);
    }
  }
}
