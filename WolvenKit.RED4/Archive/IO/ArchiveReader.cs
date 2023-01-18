using System;
using System.Collections.Generic;
using System.IO;
using WolvenKit.Common.Services;
using WolvenKit.Core.Compression;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Archive.IO;

public class ArchiveReader
{
    public EFileReadErrorCodes ReadArchive(string path, IHashService hashService, out Archive ar)
    {
        ar = new Archive()
        {
            ArchiveAbsolutePath = path
        };

        // read header
        uint customDataLength;

        using (var vs = ar.GetViewStream(0, Header.EXTENDED_SIZE))
        using (var br = new BinaryReader(vs))
        {
            ar.Header = ReadHeader(br);
            customDataLength = br.ReadUInt32();
        }

        // read custom
        try
        {
            if (customDataLength != 0)
            {
                using var vs = ar.GetViewStream(Header.EXTENDED_SIZE, customDataLength);
                using var br = new BinaryReader(vs);
                if (br.BaseStream.Length >= LxrsFooter.MIN_LENGTH)
                {
                    var lxrs = ReadLxrsFooter(br);
                    foreach (var s in lxrs.FileInfos)
                    {
                        hashService.AddCustom(s);
                    }
                }
            }
        }
        catch (UnauthorizedAccessException)
        {
            //Console.WriteLine(e);
        }

        // read files
        using (var vs = ar.GetViewStream(ar.Header.IndexPosition, ar.Header.IndexSize))
        using (var br = new BinaryReader(vs))
        {
            ar.Index = ReadIndex(br, hashService);
        }

        foreach (var file in ar.Index.FileEntries.Values)
        {
            file.Archive = ar;
            ar.Files.Add(file.Key, file);

            if (file.Extension == ".bin")
            {
                var knownGuessedExtension = hashService.GetGuessedExtension(file.Key);
                if (knownGuessedExtension != null)
                {
                    file.GuessedExtension = knownGuessedExtension;
                }
                else
                {
                    try
                    {
                        GuessFileType(ar, file);
                    }
                    catch (Exception)
                    {
                        // ignore
                    }
                }
            }
        }

        ar.ReleaseFileHandle();

        return EFileReadErrorCodes.NoError;
    }

    private void GuessFileType(Archive ar, FileEntry file)
    {
        var segment = ar.Index.FileSegments[(int)file.SegmentsStart];

        using var vs = ar.GetViewStream(segment.Offset, segment.ZSize);
        BinaryReader br;

        if (segment.ZSize != segment.Size)
        {
            try
            {
                var ms = new MemoryStream();
                vs.DecompressAndCopySegment(ms, segment.ZSize, segment.Size);
                ms.Position = 0;
                br = new BinaryReader(ms);
            }
            catch (DecompressionException e)
            {
                // todo logging
                Console.WriteLine(e.ToString());
                return;
            }
        }
        else
        {
            br = new BinaryReader(vs);
        }

        var id = br.BaseStream.ReadStruct<uint>();
        switch (id)
        {
            case CR2WFile.MAGIC:
            {
                br.BaseStream.Position = 0xA1;
                var rootClsName = br.ReadNullTerminatedString();
                var fileTypes = FileTypeHelper.GetFileExtensionsFromRootName(rootClsName);

                if (fileTypes.Length > 0)
                {
                    file.GuessedExtension = "." + fileTypes[0];
                }

                break;
            }
            case 0x44484B42:
            {
                file.GuessedExtension = ".bnk";
                break;
            }
            case 0x6A32424B:
            {
                file.GuessedExtension = ".bk2";
                break;
            }
            case 0x46464952:
            {
                file.GuessedExtension = ".wem";
                break;
            }
        }

        br.Dispose();
    }

    private LxrsFooter ReadLxrsFooter(BinaryReader br)
    {
        var customPaths = new List<string>();
        var footer = new LxrsFooter(customPaths);
        footer.Read(br);

        return footer;
    }

    private Index ReadIndex(BinaryReader br, IHashService hashService)
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
            var entry = ReadFileEntry(br, hashService);

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
            index.Dependencies.Add(ReadDependency(br));
        }

        foreach (var (_, value) in index.FileEntries)
        {
            var startIndex = (int)value.SegmentsStart;
            var nextIndex = (int)value.SegmentsEnd;

            value.Size = index.FileSegments[startIndex].Size;
            value.ZSize = index.FileSegments[startIndex].ZSize;

            for (var j = startIndex + 1; j < nextIndex; j++)
            {
                value.Size += index.FileSegments[j].ZSize;
                value.ZSize += index.FileSegments[j].ZSize;
            }
        }

        return index;
    }

    private Header ReadHeader(BinaryReader br)
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
        return header.Magic != Header.MAGIC ? throw new InvalidParsingException("not an ArchiveHeader") : header;
    }

    private Dependency ReadDependency(BinaryReader br) => new(br.ReadUInt64());

    private FileEntry ReadFileEntry(BinaryReader br, IHashService hashService)
    {
        var fileEntry = new FileEntry(hashService)
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

        return fileEntry;
    }

    private FileSegment ReadFileSegment(BinaryReader br) => new()
    {
        Offset = br.ReadUInt64(),
        ZSize = br.ReadUInt32(),
        Size = br.ReadUInt32()
    };
}