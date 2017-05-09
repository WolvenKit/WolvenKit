using System;
using System.Collections.Generic;
using System.Text;

namespace Orangelynx.Multimedia
{
  public class RiffChunk
  {
    private List<RiffChunk> Subchunks_ = new List<RiffChunk>();
    public const int HeaderSize = 8;
    private byte[] ID_;
    private byte[] Data_;

    public string ID
    {
      get
      {
        return Encoding.ASCII.GetString(this.ID_);
      }
      private set
      {
        if (value.Length != 4)
          throw new InvalidOperationException("header has to be of length 4 characters.");
        this.ID_ = Encoding.ASCII.GetBytes(value);
      }
    }

    public long Size
    {
      get
      {
        long num = 0L + (long) this.Data_.Length;
        foreach (RiffChunk riffChunk in this.Subchunks)
          num += riffChunk.Size + 8L + riffChunk.Size % 2L;
        return num;
      }
    }

    public byte[] Data
    {
      get
      {
        return this.Data_;
      }
      set
      {
        this.Data_ = value;
      }
    }

    public IEnumerable<RiffChunk> Subchunks
    {
      get
      {
        return (IEnumerable<RiffChunk>) this.Subchunks_.AsReadOnly();
      }
    }

    public RiffChunk(string id)
    {
      this.ID = id;
    }

    public void AddSubchunk(RiffChunk subchunk)
    {
      this.Subchunks_.Add(subchunk);
    }

    public void InsertSubchunk(RiffChunk subchunk, int index)
    {
      this.Subchunks_.Insert(index, subchunk);
    }

    public void RemoveSubchunk(RiffChunk subchunk)
    {
      this.Subchunks_.Remove(subchunk);
    }

    public void RemoveSubchunkAt(int index)
    {
      this.Subchunks_.RemoveAt(index);
    }
  }
}
