using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WwiseSoundLib
{
  public class WwiseSoundbank
  {
    private List<WwiseSoundbank.SectionMeta> Sections_ = new List<WwiseSoundbank.SectionMeta>();
    private Dictionary<long, long> EmbeddedWemsOffsetTable_ = new Dictionary<long, long>();
    private List<WwiseSoundbank.WwiseObject> WwiseObjects_ = new List<WwiseSoundbank.WwiseObject>();
    private uint STIDUnknown1_;

    public long SoundbankVersion { get; set; }

    public long SoundbankID { get; set; }

    public long Size { get; private set; }

    public Dictionary<long, byte[]> EmbeddedWems { get; set; }

    public Dictionary<long, string> ReferencedSoundbanks { get; set; }

    public WwiseSoundbank()
    {
      this.EmbeddedWems = new Dictionary<long, byte[]>();
      this.ReferencedSoundbanks = new Dictionary<long, string>();
    }

    public WwiseSoundbank(string filename)
      : this()
    {
      FileStream fileStream = File.OpenRead(filename);
      this.ParseStream((Stream) fileStream);
      fileStream.Close();
    }

    public WwiseSoundbank(Stream stream)
      : this()
    {
      this.ParseStream(stream);
    }

    public void WriteFile(string filename)
    {
      FileStream fileStream = File.OpenWrite(filename);
      this.WriteStream((Stream) fileStream);
      fileStream.Close();
    }

    private void ParseStream(Stream stream)
    {
      BinaryReader dataReader = new BinaryReader(stream);
      while (stream.Length - stream.Position > 8L)
        this.Sections_.Add(this.ParseSection(dataReader));
    }

    private WwiseSoundbank.SectionMeta ParseSection(BinaryReader dataReader)
    {
      string @string = Encoding.ASCII.GetString(dataReader.ReadBytes(4));
      uint num = dataReader.ReadUInt32();
      long endpos = dataReader.BaseStream.Position + (long) num;
      if (!(@string == "BKHD"))
      {
        if (!(@string == "DIDX"))
        {
          if (!(@string == "DATA"))
          {
            if (!(@string == "HIRC"))
            {
              if (@string == "STID")
                this.ParseSTIDSection(dataReader, endpos);
              else
                this.ParseUnkownSection(dataReader, endpos);
            }
            else
              this.ParseHIRCSection(dataReader, endpos);
          }
          else
            this.ParseDATASection(dataReader, endpos);
        }
        else
          this.ParseDIDXSection(dataReader, endpos);
      }
      else
        this.ParseBKHDSection(dataReader, endpos);
      if (dataReader.BaseStream.Position > endpos)
        throw new ArgumentException("section parsing exceeded section bounds.", "stream");
      byte[] remainingData = dataReader.ReadBytes(Convert.ToInt32(endpos - dataReader.BaseStream.Position));
      return new WwiseSoundbank.SectionMeta(@string, remainingData);
    }

    private void ParseBKHDSection(BinaryReader dataReader, long endpos)
    {
      this.SoundbankVersion = (long) dataReader.ReadUInt32();
      this.SoundbankID = (long) dataReader.ReadUInt32();
    }

    private void ParseDIDXSection(BinaryReader dataReader, long endpos)
    {
      while (endpos - dataReader.BaseStream.Position >= 12L)
      {
        uint num1 = dataReader.ReadUInt32();
        uint num2 = dataReader.ReadUInt32();
        uint num3 = dataReader.ReadUInt32();
        this.EmbeddedWems.Add((long) num1, new byte[(int) num3]);
        this.EmbeddedWemsOffsetTable_.Add((long) num1, (long) num2);
      }
    }

    private void ParseDATASection(BinaryReader dataReader, long endpos)
    {
      long position = dataReader.BaseStream.Position;
      foreach (KeyValuePair<long, long> keyValuePair in this.EmbeddedWemsOffsetTable_)
      {
        long key = keyValuePair.Key;
        long num = keyValuePair.Value;
        int length = this.EmbeddedWems[key].Length;
        dataReader.BaseStream.Position = position + num;
        this.EmbeddedWems[key] = dataReader.ReadBytes(length);
      }
      dataReader.BaseStream.Position = endpos;
    }

    private void ParseHIRCSection(BinaryReader dataReader, long endpos)
    {
      int num1 = Convert.ToInt32(dataReader.ReadUInt32());
      while (dataReader.BaseStream.Position < endpos)
      {
        byte num2 = dataReader.ReadByte();
        int num3 = Convert.ToInt32(dataReader.ReadUInt32());
        long id = (long) dataReader.ReadUInt32();
        byte[] data = dataReader.ReadBytes(num3 - 4);
        this.WwiseObjects_.Add(new WwiseSoundbank.WwiseObject(id, (WwiseSoundbank.WwiseObjectType) num2, data));
        --num1;
      }
      if (num1 != 0)
        throw new InvalidOperationException("mismatch between wwise objects read and wwise object count");
    }

    private void ParseSTIDSection(BinaryReader dataReader, long endpos)
    {
      this.STIDUnknown1_ = dataReader.ReadUInt32();
      uint num1 = dataReader.ReadUInt32();
      for (int index = 0; (long) index < (long) num1; ++index)
      {
        uint num2 = dataReader.ReadUInt32();
        byte num3 = dataReader.ReadByte();
        string @string = Encoding.ASCII.GetString(dataReader.ReadBytes((int) num3));
        this.ReferencedSoundbanks.Add((long) num2, @string);
      }
    }

    private void ParseUnkownSection(BinaryReader dataReader, long endpos)
    {
    }

    private void WriteStream(Stream stream)
    {
      BinaryWriter dataWriter = new BinaryWriter(stream);
      foreach (WwiseSoundbank.SectionMeta section in this.Sections_)
        this.WriteSection(section, dataWriter);
    }

    private void WriteSection(WwiseSoundbank.SectionMeta section, BinaryWriter dataWriter)
    {
      dataWriter.Write(Encoding.ASCII.GetBytes(section.SectionTag));
      long position1 = dataWriter.BaseStream.Position;
      dataWriter.Write(0U);
      long position2 = dataWriter.BaseStream.Position;
      string sectionTag = section.SectionTag;
      if (!(sectionTag == "BKHD"))
      {
        if (!(sectionTag == "DIDX"))
        {
          if (!(sectionTag == "DATA"))
          {
            if (!(sectionTag == "STID"))
            {
              if (sectionTag == "HIRC")
                this.WriteHIRCSection(dataWriter);
              else
                this.WriteUnkownSection(dataWriter);
            }
            else
              this.WriteSTIDSection(dataWriter);
          }
          else
            this.WriteDATASection(dataWriter);
        }
        else
          this.WriteDIDXSection(dataWriter);
      }
      else
        this.WriteBKHDSection(dataWriter);
      dataWriter.Write(section.RemainingData);
      int num = Convert.ToInt32(dataWriter.BaseStream.Position - position2);
      dataWriter.BaseStream.Position = position1;
      dataWriter.Write((uint) num);
      dataWriter.BaseStream.Position += (long) num;
    }

    private void WriteBKHDSection(BinaryWriter dataWriter)
    {
      dataWriter.Write((uint) this.SoundbankVersion);
      dataWriter.Write((uint) this.SoundbankID);
    }

    private void WriteDIDXSection(BinaryWriter dataWriter)
    {
      foreach (KeyValuePair<long, long> keyValuePair in this.EmbeddedWemsOffsetTable_)
      {
        uint num1 = (uint) keyValuePair.Key;
        uint num2 = (uint) keyValuePair.Value;
        dataWriter.Write(num1);
        dataWriter.Write(num2);
        dataWriter.Write((uint) this.EmbeddedWems[(long) num1].Length);
      }
    }

    private void WriteDATASection(BinaryWriter dataWriter)
    {
      long position = dataWriter.BaseStream.Position;
      long num1 = position;
      foreach (KeyValuePair<long, long> keyValuePair in this.EmbeddedWemsOffsetTable_)
      {
        long key = keyValuePair.Key;
        long num2 = keyValuePair.Value;
        dataWriter.BaseStream.Position += num2;
        dataWriter.Write(this.EmbeddedWems[key]);
        if (dataWriter.BaseStream.Position > num1)
          num1 = dataWriter.BaseStream.Position;
        dataWriter.BaseStream.Position = position;
      }
      dataWriter.BaseStream.Position = num1;
    }

    private void WriteHIRCSection(BinaryWriter dataWriter)
    {
      dataWriter.Write((uint) this.WwiseObjects_.Count);
      foreach (WwiseSoundbank.WwiseObject wwiseObject in this.WwiseObjects_)
      {
        dataWriter.Write((byte) wwiseObject.Type);
        dataWriter.Write((uint) wwiseObject.Size);
        dataWriter.Write((uint) wwiseObject.ID);
        dataWriter.Write(wwiseObject.Data);
      }
    }

    private void WriteSTIDSection(BinaryWriter dataWriter)
    {
      dataWriter.Write(this.STIDUnknown1_);
      dataWriter.Write((uint) this.ReferencedSoundbanks.Count);
      foreach (KeyValuePair<long, string> keyValuePair in this.ReferencedSoundbanks)
      {
        dataWriter.Write((uint) keyValuePair.Key);
        dataWriter.Write((byte) keyValuePair.Value.Length);
        dataWriter.Write(Encoding.ASCII.GetBytes(keyValuePair.Value));
      }
    }

    private void WriteUnkownSection(BinaryWriter dataWriter)
    {
    }

    private class SectionMeta
    {
      private string SectionTag_ = "";

      public string SectionTag
      {
        get
        {
          return this.SectionTag_;
        }
        set
        {
          if (value.Length != 4)
            throw new ArgumentException("section tag has to be four characters long.", "SectionTag");
          this.SectionTag_ = value;
        }
      }

      public byte[] RemainingData { get; set; }

      public SectionMeta(string sectionTag, byte[] remainingData = null)
      {
        this.SectionTag = sectionTag;
        this.RemainingData = remainingData;
      }
    }

    private enum WwiseObjectType
    {
      Settings = 1,
      SoundSfxOrVoice = 2,
      EventAction = 3,
      EventArgs = 4,
      SequenceContainer = 5,
      SwitchContainer = 6,
      ActorMixer = 7,
      AudioBus = 8,
      BlendContainer = 9,
      MusicSegment = 10,
      MusicTrack = 11,
      MusicSwitchContainer = 12,
      MusicPlaylistContainer = 13,
      Attenuation = 14,
      DialogueEvent = 15,
      MotionBus = 16,
      MotionFX = 17,
      Effect = 18,
      AuxillaryBus = 19,
    }

    private class WwiseObject
    {
      public WwiseSoundbank.WwiseObjectType Type { get; private set; }

      public int Size
      {
        get
        {
          return this.Data.Length + 4;
        }
      }

      public long ID { get; private set; }

      public byte[] Data { get; set; }

      public WwiseObject(long id, WwiseSoundbank.WwiseObjectType type)
        : this(id, type, new byte[0])
      {
      }

      public WwiseObject(long id, WwiseSoundbank.WwiseObjectType type, byte[] data)
      {
        this.Type = type;
        this.ID = id;
        this.Data = data;
      }
    }
  }
}
