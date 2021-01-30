using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Catel.IoC;
using WolvenKit.Common.Services;
using WolvenKit.Common;
using WolvenKit.Common.Model;

namespace CP77.CR2W.Archive
{
    public class FileEntry : IGameFile
    {
        public ulong NameHash64 { get; set; }
        public DateTime Timestamp { get; set; }
        public uint NumInlineBufferSegments { get; set; }
        public uint SegmentsStart { get; set; }
        public uint SegmentsEnd { get; set; }
        public uint ResourceDependenciesStart { get; set; }
        public uint ResourceDependenciesEnd { get; set; }
        public byte[] SHA1Hash { get; set; }

        public string bytesAsString => BitConverter.ToString(SHA1Hash);

        private string _nameStr;
        public string NameOrHash => string.IsNullOrEmpty(_nameStr) ? $"{NameHash64}" : _nameStr;
        public string FileName => string.IsNullOrEmpty(_nameStr) ? $"{NameHash64}.bin" : _nameStr;
        public string Extension => Path.GetExtension(FileName);

        public IGameArchive Archive { get; set; }
        public string Name { get; set; }
        public uint Size { get; set; }
        public uint ZSize { get; set; }
        public long PageOffset { get; set; }

        public string CompressionType { get; set; }

        public FileEntry(BinaryReader br, IGameArchive parent)
        {
            Archive = parent;
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

        private void Read(BinaryReader br, IHashService mainController)
        {
            NameHash64 = br.ReadUInt64();

            if (mainController != null && mainController.Hashdict.ContainsKey(NameHash64))
            {
                _nameStr = mainController.Hashdict[NameHash64];
            }

            // x-platform support
            if (System.Runtime.InteropServices.RuntimeInformation
                .IsOSPlatform(System.Runtime.InteropServices.OSPlatform.OSX))
            {
                if (!string.IsNullOrEmpty(_nameStr) && _nameStr.Contains('\\'))
                    _nameStr = _nameStr.Replace('\\', Path.DirectorySeparatorChar);
            }

            Timestamp = DateTime.FromFileTime(br.ReadInt64());


            NumInlineBufferSegments = br.ReadUInt32();
            SegmentsStart = br.ReadUInt32();
            SegmentsEnd = br.ReadUInt32();
            ResourceDependenciesStart = br.ReadUInt32();
            ResourceDependenciesEnd = br.ReadUInt32();

            SHA1Hash = br.ReadBytes(20);

            if (!string.IsNullOrEmpty(_nameStr))
                Name = _nameStr;
            else
                Name = NameHash64.ToString();
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

        public void Extract(Stream output)
        {
            throw new NotImplementedException();
        }

        public string Extract(BundleFileExtractArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
