using System;
using System.IO;
using Catel.IoC;
using ProtoBuf;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Interfaces.Core;
using ServiceLocator = Catel.IoC.ServiceLocator;

namespace WolvenKit.RED4.CR2W.Archive
{
    [ProtoContract]
    public class FileEntry : Cp77GameFile
    {
        #region Fields

        [ProtoMember(11)] private string _nameStr;

        #endregion Fields

        #region Constructors

        public FileEntry()
        {
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

        [ProtoMember(1)] public ulong NameHash64 { get; set; }
        [ProtoMember(2)] public DateTime Timestamp { get; set; }
        [ProtoMember(3)] public uint NumInlineBufferSegments { get; set; }
        [ProtoMember(4)] public uint SegmentsStart { get; set; }
        [ProtoMember(5)] public uint SegmentsEnd { get; set; }
        [ProtoMember(6)] public uint ResourceDependenciesStart { get; set; }
        [ProtoMember(7)] public uint ResourceDependenciesEnd { get; set; }
        [ProtoMember(8)] public byte[] SHA1Hash { get; set; }

        public IGameArchive Archive { get; set; }

        [ProtoMember(9)] public uint Size { get; set; }
        [ProtoMember(10)] public uint ZSize { get; set; }

        public ulong Key => NameHash64;
        public string Name => !string.IsNullOrEmpty(_nameStr) ? _nameStr : NameHash64.ToString();
        public string bytesAsString => BitConverter.ToString(SHA1Hash);
        public string FileName => string.IsNullOrEmpty(_nameStr) ? $"{NameHash64}.bin" : _nameStr;
        public string NameOrHash => string.IsNullOrEmpty(_nameStr) ? $"{NameHash64}" : _nameStr;
        public string Extension => Path.GetExtension(FileName);

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

        public void SetNameStr(string s) => _nameStr = s;



        #endregion Methods
    }
}
