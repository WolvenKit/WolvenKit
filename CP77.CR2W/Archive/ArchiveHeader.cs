using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.IoC;
using CP77.Common.Services;
using CP77.CR2W.Archive;
using WolvenKit.CR2W.Types;

namespace CP77Tools.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ArHeader
    {
        public const uint MAGIC = 1380009042;
        public const int SIZE = 40;

        
        public uint Magic { get; private set; }
        public uint Version { get; private set; }
        public ulong Tableoffset { get; set; }
        public uint Tablesize { get; set; }
        public uint Unk1 { get; private set; }
        public uint Unk2 { get; private set; }
        public uint Unk3 { get; private set; }
        public ulong Filesize { get; set; }

        public ArHeader()
        {
            Magic = MAGIC;
            Version = 12;
            Unk1 = 0;
            Unk2 = 0;
            Unk3 = 0;
        }
        
        public ArHeader(BinaryReader br)
        {
            Read(br);
        }



        private void Read(BinaryReader br)
        {
            Magic = br.ReadUInt32();
            if (Magic != MAGIC)
                throw new NotImplementedException();

            Version = br.ReadUInt32();
            Tableoffset = br.ReadUInt64();
            Tablesize = br.ReadUInt32();
            Unk1 = br.ReadUInt32();
            Unk2 = br.ReadUInt32();
            Unk3 = br.ReadUInt32();
            Filesize = br.ReadUInt64();
        }

        public void Write(BinaryWriter bw)
        {
            bw.Write(MAGIC);
            bw.Write(Version);
            bw.Write(Tableoffset);
            bw.Write(Tablesize);
            bw.Write(Unk1);
            bw.Write(Unk2);
            bw.Write(Unk3);
            bw.Write(Filesize);
        }
    }
}
