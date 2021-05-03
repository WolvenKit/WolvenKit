using System;
using System.IO;
using Catel.IoC;
using ProtoBuf;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Interfaces.Core;
using ZeroFormatter;
using ServiceLocator = Catel.IoC.ServiceLocator;

namespace WolvenKit.RED4.CR2W.Archive
{
    [ZeroFormattable]
    [ProtoContract]
    public class FileEntry : IGameFile
    {
        #region Fields

        private string _nameStr;

        #endregion Fields

        #region Constructors

        public FileEntry()
        {
        }

        public FileEntry(BinaryReader br, IGameArchive parent)
        {
            Archive = parent;

            Read(br);
        }

        public FileEntry(ulong hash, DateTime datetime, uint flags
            , uint segmentsStart, uint segmentsEnd, uint resourceDependenciesStart, uint resourceDependenciesEnd, byte[] sha1hash)
        {
            NameHash64 = hash;
            Timestamp = datetime;
            NumInlineBufferSegments = flags;
            ResourceDependenciesStart = resourceDependenciesStart;
            ResourceDependenciesEnd = resourceDependenciesEnd;
            SegmentsStart = segmentsStart;
            SegmentsEnd = segmentsEnd;
            SHA1Hash = sha1hash;
        }

        #endregion Constructors

        #region Properties

        [Index(0)] [ProtoMember(1)] public virtual ulong NameHash64 { get; set; }
        [Index(1)] [ProtoMember(2)] public virtual DateTime Timestamp { get; set; }
        [Index(2)] [ProtoMember(3)] public virtual uint NumInlineBufferSegments { get; set; }
        [Index(3)] [ProtoMember(4)] public virtual uint SegmentsStart { get; set; }
        [Index(4)] [ProtoMember(5)] public virtual uint SegmentsEnd { get; set; }
        [Index(5)] [ProtoMember(6)] public virtual uint ResourceDependenciesStart { get; set; }
        [Index(6)] [ProtoMember(7)] public virtual uint ResourceDependenciesEnd { get; set; }
        [Index(7)] [ProtoMember(8)] public virtual byte[] SHA1Hash { get; set; }

        [IgnoreFormat] public virtual IGameArchive Archive { get; set; }

        [Index(9)] [ProtoMember(10)] public virtual uint Size { get; set; }
        [Index(10)] [ProtoMember(11)] public virtual uint ZSize { get; set; }

        [IgnoreFormat] public string Name => !string.IsNullOrEmpty(_nameStr) ? _nameStr : NameHash64.ToString();
        [IgnoreFormat] public string bytesAsString => BitConverter.ToString(SHA1Hash);
        [IgnoreFormat] public string FileName => string.IsNullOrEmpty(_nameStr) ? $"{NameHash64}.bin" : _nameStr;
        [IgnoreFormat] public string NameOrHash => string.IsNullOrEmpty(_nameStr) ? $"{NameHash64}" : _nameStr;
        [IgnoreFormat] public string Extension => Path.GetExtension(FileName);

        #endregion Properties

        #region Methods

        public void Extract(Stream output)
        {
            if (Archive is not Archive ar)
            {
                throw new InvalidParsingException($"{Archive.ArchiveAbsolutePath} is not a cyberpunk77 archive.");
            }

            ar.CopyFileToStream(output, NameHash64, false);
        }

        public void Write(BinaryWriter bw)
        {
            bw.Write(NameHash64);
            bw.Write(Timestamp.ToFileTime());
            bw.Write(NumInlineBufferSegments);
            bw.Write(SegmentsStart);
            bw.Write(SegmentsEnd);
            bw.Write(ResourceDependenciesStart);
            bw.Write(ResourceDependenciesEnd);
            bw.Write(SHA1Hash);
        }

        private void Read(BinaryReader br)
        {
            var hashService = ServiceLocator.Default.ResolveType<IHashService>();
            NameHash64 = br.ReadUInt64();
            _nameStr = hashService?.Get(NameHash64);

            // x-platform support
            if (System.Runtime.InteropServices.RuntimeInformation
                .IsOSPlatform(System.Runtime.InteropServices.OSPlatform.OSX))
            {
                if (!string.IsNullOrEmpty(_nameStr) && _nameStr.Contains('\\'))
                {
                    _nameStr = _nameStr.Replace('\\', Path.DirectorySeparatorChar);
                }
            }

            Timestamp = DateTime.FromFileTime(br.ReadInt64());

            NumInlineBufferSegments = br.ReadUInt32();
            SegmentsStart = br.ReadUInt32();
            SegmentsEnd = br.ReadUInt32();
            ResourceDependenciesStart = br.ReadUInt32();
            ResourceDependenciesEnd = br.ReadUInt32();

            SHA1Hash = br.ReadBytes(20);
        }

        #endregion Methods
    }
}
