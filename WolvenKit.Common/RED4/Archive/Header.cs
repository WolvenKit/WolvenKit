using System.IO;
using WolvenKit.Interfaces.Core;
using WolvenKit.RED4.CR2W.Types;
using ZeroFormatter;

namespace CP77Tools.Model
{
    [ZeroFormattable]
    public class Header
    {
        #region Fields

        public const uint MAGIC = 1380009042;
        public const int SIZE = 40;

        #endregion Fields

        #region Constructors

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

        #endregion Constructors

        #region Properties

        [Index(0)] public ulong DebugPosition { get; private set; }
        [Index(1)] public uint DebugSize { get; private set; }
        [Index(2)] public ulong Filesize { get; set; }
        [Index(3)] public ulong IndexPosition { get; set; }
        [Index(4)] public uint IndexSize { get; set; }
        [Index(5)] public uint Magic { get; private set; }
        [Index(6)] public uint Version { get; private set; }

        #endregion Properties

        #region Methods

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

        private void Read(BinaryReader br)
        {
            Magic = br.ReadUInt32();
            if (Magic != MAGIC)
                throw new InvalidParsingException("not an ArchiveHeader");

            Version = br.ReadUInt32();
            IndexPosition = br.ReadUInt64();
            IndexSize = br.ReadUInt32();
            DebugPosition = br.ReadUInt64();
            DebugSize = br.ReadUInt32();
            Filesize = br.ReadUInt64();
        }

        #endregion Methods
    }
}
