using System;
using System.IO;
using ProtoBuf;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.CR2W.Archive
{
    [ProtoContract]
    public class FileEntry : Cp77GameFile
    {
        #region Fields

        private IHashService _hashService;

        #endregion Fields

        #region Constructors

        public FileEntry()
        {

        }

        public FileEntry(IHashService hashService)
        {
            _hashService = hashService;
        }

        public FileEntry(
            IHashService hashService,
            ulong hash,
            DateTime datetime,
            uint flags,
            uint segmentsStart,
            uint segmentsEnd,
            uint resourceDependenciesStart,
            uint resourceDependenciesEnd,
            byte[] sha1hash)
        {
            _hashService = hashService;

            NameHash64 = hash;
            Timestamp = datetime;
            NumInlineBufferSegments = flags;
            ResourceDependenciesStart = resourceDependenciesStart;
            ResourceDependenciesEnd = resourceDependenciesEnd;
            SegmentsStart = segmentsStart;
            SegmentsEnd = segmentsEnd;
            SHA1Hash = sha1hash;
        }

        [ProtoAfterDeserialization]
        public void AfterDeserializationCallback()
        {

        }

        #endregion Constructors

        #region Properties

        public IGameArchive Archive { get; set; }


        [ProtoMember(1)] public ulong NameHash64 { get; set; }
        [ProtoMember(2)] public DateTime Timestamp { get; set; }
        [ProtoMember(3)] public uint NumInlineBufferSegments { get; set; }
        [ProtoMember(4)] public uint SegmentsStart { get; set; }
        [ProtoMember(5)] public uint SegmentsEnd { get; set; }
        [ProtoMember(6)] public uint ResourceDependenciesStart { get; set; }
        [ProtoMember(7)] public uint ResourceDependenciesEnd { get; set; }
        [ProtoMember(8)] public byte[] SHA1Hash { get; set; }
        [ProtoMember(9)] public uint Size { get; set; }
        [ProtoMember(10)] public uint ZSize { get; set; }

        public ulong Key => NameHash64;
        public string Name => !string.IsNullOrEmpty(GetNameString()) ? GetNameString() : NameHash64.ToString();
        public string bytesAsString => BitConverter.ToString(SHA1Hash);
        public string FileName => string.IsNullOrEmpty(GetNameString()) ? $"{NameHash64}.bin" : GetNameString();
        public string NameOrHash => string.IsNullOrEmpty(GetNameString()) ? $"{NameHash64}" : GetNameString();
        public string Extension => Path.GetExtension(FileName);

        public string ShortName => Path.GetFileName(FileName);

        #endregion Properties

        #region Methods

        public void SetHashService(IHashService hashService) => _hashService = hashService;


        public void Extract(Stream output)
        {
            if (Archive is not Archive ar)
            {
                throw new InvalidParsingException($"{Archive.ArchiveAbsolutePath} is not a cyberpunk77 archive.");
            }

            ar.CopyFileToStream(output, NameHash64, false);
        }

        private string GetNameString()
        {
            var _nameStr = _hashService?.Get(NameHash64);
            // x-platform support
            if (System.Runtime.InteropServices.RuntimeInformation
                .IsOSPlatform(System.Runtime.InteropServices.OSPlatform.OSX))
            {
                if (!string.IsNullOrEmpty(_nameStr) && _nameStr.Contains('\\'))
                {
                    _nameStr = _nameStr.Replace('\\', Path.DirectorySeparatorChar);
                }
            }
            return _nameStr;
        }



        #endregion Methods
    }
}
