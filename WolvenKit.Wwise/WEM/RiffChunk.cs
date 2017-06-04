using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WolvenKit.Wwise.WEM
{
    public class RiffChunk
    {
        public const int HeaderSize = 8;
        private readonly List<RiffChunk> _subchunks = new List<RiffChunk>();
        private byte[] _id;

        public RiffChunk(string id)
        {
            Id = id;
        }

        public string Id
        {
            get { return Encoding.ASCII.GetString(_id); }
            private set
            {
                if (value.Length != 4)
                    throw new InvalidOperationException("header has to be of length 4 characters.");
                _id = Encoding.ASCII.GetBytes(value);
            }
        }

        public long Size
        {
            get
            {
                return 0L + Data.Length + Subchunks.Sum(riffChunk => riffChunk.Size + 8L + riffChunk.Size%2L);
            }
        }

        public byte[] Data { get; set; }

        public IEnumerable<RiffChunk> Subchunks => _subchunks.AsReadOnly();

        public void AddSubchunk(RiffChunk subchunk)
        {
            _subchunks.Add(subchunk);
        }

        public void InsertSubchunk(RiffChunk subchunk, int index)
        {
            _subchunks.Insert(index, subchunk);
        }

        public void RemoveSubchunk(RiffChunk subchunk)
        {
            _subchunks.Remove(subchunk);
        }

        public void RemoveSubchunkAt(int index)
        {
            _subchunks.RemoveAt(index);
        }
    }
}