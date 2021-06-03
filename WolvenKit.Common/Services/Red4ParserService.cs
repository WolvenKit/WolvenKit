using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.IoC;
using CP77Tools.Model;
using WolvenKit.Common.RED4.Archive;
using WolvenKit.Interfaces.Core;
using WolvenKit.RED3.CR2W.Types;
using WolvenKit.RED4.CR2W.Archive;
using Index = CP77Tools.Model.Index;

namespace WolvenKit.Common.Services
{
    public static class Red4ParserServiceExtensions
    {
       public static Archive ReadArchive(string path, IHashService _hashService)
       {
            var ar = new Archive()
            {
                ArchiveAbsolutePath = path
            };

            using var mmf = MemoryMappedFile.CreateFromFile(path, FileMode.Open);

            using (var vs = mmf.CreateViewStream(0, Header.SIZE, MemoryMappedFileAccess.Read))
            using (var br = new BinaryReader(vs))
            {
                ar.Header = ReadHeader(br);
            }

            // custom

            try
            {

                var a = mmf.CreateViewAccessor((long)ar.Header.Filesize, 0, MemoryMappedFileAccess.Read);

                using var vs = mmf.CreateViewStream((long)ar.Header.Filesize, 0, MemoryMappedFileAccess.Read);
                using var br = new BinaryReader(vs);
                if (br.BaseStream.Length >= LxrsFooter.MIN_LENGTH)
                {
                    var lxrs = br.ReadLxrsFooter(_hashService);
                    foreach (var s in lxrs.FileInfos)
                    {
                        _hashService.Add(s);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                //Console.WriteLine(e);

            }



            using (var vs = mmf.CreateViewStream((long)ar.Header.IndexPosition, ar.Header.IndexSize,
            MemoryMappedFileAccess.Read))
            using (var br = new BinaryReader(vs))
            {
                ar.Index = ReadIndex(br, _hashService);
            }

            foreach (var file in ar.Index.FileEntries.Values)
            {
                file.Archive = ar;
                ar.Files.Add(file.Key, file);
            }

            return ar;
        }

       private static LxrsFooter ReadLxrsFooter(this BinaryReader br, IHashService _hashService)
       {
           var customPaths = new List<string>();
           var footer = new LxrsFooter(customPaths);
           footer.Read(br);

           return footer;
       }

        private static Index ReadIndex(this BinaryReader br, IHashService _hashService)
        {
            var index = new Index
            {
                FileTableOffset = br.ReadUInt32(),
                FileTableSize = br.ReadUInt32(),
                Crc = br.ReadUInt64(),
                FileEntryCount = br.ReadUInt32(),
                FileSegmentCount = br.ReadUInt32(),
                ResourceDependencyCount = br.ReadUInt32()
            };

            // read tables
            for (var i = 0; i < index.FileEntryCount; i++)
            {
                var entry = ReadFileEntry(br, _hashService);

                if (!index.FileEntries.ContainsKey(entry.NameHash64))
                {
                    index.FileEntries.Add(entry.NameHash64, entry);
                }
                else
                {
                    // TODO
                }
            }

            for (var i = 0; i < index.FileSegmentCount; i++)
            {
                index.FileSegments.Add(ReadFileSegment(br));
            }

            for (var i = 0; i < index.ResourceDependencyCount; i++)
            {
                index.Dependencies.Add(ReadDependency(br, _hashService));
            }

            foreach (var (_, value) in index.FileEntries)
            {
                var startIndex = (int)value.SegmentsStart;
                var nextIndex = (int)value.SegmentsEnd;

                value.Size = index.FileSegments[startIndex].Size;
                value.ZSize = index.FileSegments[startIndex].ZSize;

                for (var j = startIndex + 1; j < nextIndex; j++)
                {
                    value.Size += index.FileSegments[j].Size;
                    value.ZSize += index.FileSegments[j].ZSize;
                }
            }

            return index;
        }

        public static Header ReadHeader(this BinaryReader br)
        {
            var header = new Header()
            {
                Magic = br.ReadUInt32(),
                Version = br.ReadUInt32(),
                IndexPosition = br.ReadUInt64(),
                IndexSize = br.ReadUInt32(),
                DebugPosition = br.ReadUInt64(),
                DebugSize = br.ReadUInt32(),
                Filesize = br.ReadUInt64()
            };
            if (header.Magic != Header.MAGIC)
            {
                throw new InvalidParsingException("not an ArchiveHeader");
            }

            return header;
        }

        private static Dependency ReadDependency(this BinaryReader br, IHashService _hashService)
        {
            var d = new Dependency()
            {
                Hash = br.ReadUInt64(),
            };
            d.HashStr = _hashService?.Get(d.Hash);
            return d;
        }

        private static FileEntry ReadFileEntry(this BinaryReader br, IHashService _hashService)
        {
            var fileEntry = new FileEntry
            {
                NameHash64 = br.ReadUInt64(),
                Timestamp = DateTime.FromFileTime(br.ReadInt64()),
                NumInlineBufferSegments = br.ReadUInt32(),
                SegmentsStart = br.ReadUInt32(),
                SegmentsEnd = br.ReadUInt32(),
                ResourceDependenciesStart = br.ReadUInt32(),
                ResourceDependenciesEnd = br.ReadUInt32(),
                SHA1Hash = br.ReadBytes(20)
            };


            var _nameStr = _hashService?.Get(fileEntry.NameHash64);
            // x-platform support
            if (System.Runtime.InteropServices.RuntimeInformation
                .IsOSPlatform(System.Runtime.InteropServices.OSPlatform.OSX))
            {
                if (!string.IsNullOrEmpty(_nameStr) && _nameStr.Contains('\\'))
                {
                    _nameStr = _nameStr.Replace('\\', Path.DirectorySeparatorChar);
                }
            }

            fileEntry.SetNameStr(_nameStr);

            return fileEntry;
        }

        private static FileSegment ReadFileSegment(this BinaryReader br) =>
            new FileSegment()
            {
                Offset = br.ReadUInt64(),
                ZSize = br.ReadUInt32(),
                Size = br.ReadUInt32()
            };
    }

}
