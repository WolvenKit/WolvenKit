using System;
using System.IO;
using Catel.IoC;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using ZeroFormatter;

namespace WolvenKit.RED4.CR2W.Archive
{
    [ZeroFormattable]
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
            ArchiveName = parent.Name;
            var mainController = ServiceLocator.Default.ResolveType<IHashService>();

            Read(br, mainController);
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

        public ulong NameHash64 { get; set; }
        public DateTime Timestamp { get; set; }
        public uint NumInlineBufferSegments { get; set; }
        public uint SegmentsStart { get; set; }
        public uint SegmentsEnd { get; set; }
        public uint ResourceDependenciesStart { get; set; }
        public uint ResourceDependenciesEnd { get; set; }
        public byte[] SHA1Hash { get; set; }

        public string ArchiveName { get; set; }

        public uint Size { get; set; }
        public uint ZSize { get; set; }

        public string Name => !string.IsNullOrEmpty(_nameStr) ? _nameStr : NameHash64.ToString();
        public string bytesAsString => BitConverter.ToString(SHA1Hash);
        public string FileName => string.IsNullOrEmpty(_nameStr) ? $"{NameHash64}.bin" : _nameStr;
        public string NameOrHash => string.IsNullOrEmpty(_nameStr) ? $"{NameHash64}" : _nameStr;
        public string Extension => Path.GetExtension(FileName);

        #endregion Properties

        #region Methods

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

        private void Read(BinaryReader br, IHashService hashService)
        {
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
