using ProtoBuf;

namespace WolvenKit.RED4.Archive
{
    [ProtoContract]
    public class Header
    {
        #region Fields

        public const uint MAGIC = 1380009042;
        public const int SIZE = 40;
        public const int EXTENDED_SIZE = 0xAC;

        #endregion Fields

        #region Constructors

        public Header()
        {
            Magic = MAGIC;
            Version = 12;
            DebugPosition = 0;
            DebugSize = 0;
        }

        #endregion Constructors

        #region Properties

        [ProtoMember(1)] public ulong DebugPosition { get; set; }
        [ProtoMember(2)] public uint DebugSize { get; set; }
        [ProtoMember(3)] public ulong Filesize { get; set; }
        [ProtoMember(4)] public ulong IndexPosition { get; set; }
        [ProtoMember(5)] public uint IndexSize { get; set; }
        [ProtoMember(6)] public uint Magic { get; set; }
        [ProtoMember(7)] public uint Version { get; set; }

        #endregion Properties
    }
}
