using System.IO;
using ProtoBuf;
using WolvenKit.Interfaces.Core;
using WolvenKit.RED4.CR2W.Types;

namespace CP77Tools.Model
{
    [ProtoContract]
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

        [ProtoMember(1)] public ulong DebugPosition { get; private set; }
        [ProtoMember(2)] public uint DebugSize { get; private set; }
        [ProtoMember(3)] public ulong Filesize { get; set; }
        [ProtoMember(4)] public ulong IndexPosition { get; set; }
        [ProtoMember(5)] public uint IndexSize { get; set; }
        [ProtoMember(6)] public uint Magic { get; private set; }
        [ProtoMember(7)] public uint Version { get; private set; }

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
