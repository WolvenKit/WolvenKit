using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.IoC;
using CP77.CR2W.Archive;
using CP77.CR2W.Types;

namespace CP77Tools.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Header
    {
        public const uint MAGIC = 1380009042;
        public const int SIZE = 40;

        
        public uint Magic { get; private set; }
        public uint Version { get; private set; }
        public ulong IndexPosition { get; set; }
        public uint IndexSize { get; set; }
        public ulong DebugPosition { get; private set; }
        public uint DebugSize { get; private set; }
        public ulong Filesize { get; set; }

        public Header()
        {
            Magic = MAGIC;
            Version = 12;
            DebugPosition = 0;
            DebugSize = 0;
        }
        
        public Header(BinaryReader br)
        {
            Read(br);
        }



        private void Read(BinaryReader br)
        {
            Magic = br.ReadUInt32();
            if (Magic != MAGIC)
                throw new NotImplementedException();

            Version = br.ReadUInt32();
            IndexPosition = br.ReadUInt64();
            IndexSize = br.ReadUInt32();
            DebugPosition = br.ReadUInt64();
            DebugSize = br.ReadUInt32();
            Filesize = br.ReadUInt64();
        }

        public void Write(BinaryWriter bw)
        {
            bw.Write(MAGIC);
            bw.Write(Version);
            bw.Write(IndexPosition);
            bw.Write(IndexSize);
            bw.Write(DebugPosition);
            bw.Write(DebugSize);
            bw.Write(Filesize);
        }
    }
}
