using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Splat;
using WolvenKit.Common.FNV1A;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;
using WolvenKit.Common.Services;
using WolvenKit.RED4.Archive.Buffer;

namespace WolvenKit.RED4.Archive.IO
{
    public partial class PackageReader : IBufferReader
    {
        private Package04Header header;
        private IHashService _hashService;

        public EFileReadErrorCodes ReadBuffer(RedBuffer buffer, Type fileRootType)
        {
            _hashService = Locator.Current.GetService<IHashService>();

            var _chunks = new List<RedBaseClass>();

            var result = new Package04();
            _outputFile = result;

            header.version = BaseReader.ReadUInt16();
            if (header.version < 2 || header.version > 4)
            {
                return EFileReadErrorCodes.UnsupportedVersion;
            }

            header.numSections = _reader.ReadUInt16();
            if (header.numSections < 6 || header.numSections > 7)
            {
                return EFileReadErrorCodes.UnsupportedVersion;
            }

            result.Version = header.version;
            result.Sections = header.numSections;

            header.numComponents = _reader.ReadUInt32();

            if (header.numSections == 7)
            {
                header.refPoolDescOffset = _reader.ReadUInt32();
                header.refPoolDataOffset = _reader.ReadUInt32();
            }

            header.namePoolDescOffset = _reader.ReadUInt32();
            header.namePoolDataOffset = _reader.ReadUInt32();

            header.chunkDescOffset = _reader.ReadUInt32();
            header.chunkDataOffset = _reader.ReadUInt32();

            if (header.numSections == 7 && header.refPoolDescOffset != 0)
            {
                return EFileReadErrorCodes.NoCr2w;
            }

            if (header.refPoolDescOffset != 0)
            {
                return EFileReadErrorCodes.NoCr2w;
            }

            if (fileRootType == typeof(gamePersistentStateDataResource))
            {
                var numCruids = _reader.ReadUInt32();
                for (var i = 0; i < numCruids; i++)
                {
                    result.RootCruids.Add(_reader.ReadUInt64());
                }
            }
            else if (fileRootType != typeof(inkWidgetLibraryResource))
            {
                result.CruidIndex = _reader.ReadInt16();
                var numCruids = _reader.ReadUInt16();

                for (var i = 0; i < numCruids; i++)
                {
                    result.RootCruids.Add(_reader.ReadUInt64());
                }
            }

            var baseOff = BaseStream.Position;

            // read refs
            var refCount = (header.refPoolDataOffset - header.refPoolDescOffset) / 4;
            BaseStream.Position = baseOff + header.refPoolDescOffset;
            var refDesc = BaseStream.ReadStructs<Package04ImportHeader>(refCount);

            var readAsHash = fileRootType == typeof(appearanceAppearanceResource);
            foreach (var r in refDesc)
            {
                BaseStream.Position = baseOff + r.offset;
                importsList.Add(ReadImport(r, readAsHash));
            }

            // read strings
            var nameCount = (header.namePoolDataOffset - header.namePoolDescOffset) / 4;
            BaseStream.Position = baseOff + header.namePoolDescOffset;
            var nameDesc = BaseStream.ReadStructs<Package04NameHeader>(nameCount);

            foreach (var s in nameDesc)
            {
                BaseStream.Position = baseOff + s.offset;
                _namesList.Add(ReadName(s));
            }

            // read chunks
            var chunkCount = (header.chunkDataOffset - header.chunkDescOffset) / 8;
            BaseStream.Position = baseOff + header.chunkDescOffset;
            var chunkDesc = BaseStream.ReadStructs<Package04ChunkHeader>(chunkCount);

            for (int i = 0; i < chunkDesc.Length; i++)
            {
                _chunks.Add(ReadChunk(chunkDesc[i]));
            }

            var newChunks = new List<RedBaseClass>();
            for (int i = 0; i < _chunks.Count; i++)
            {
                if (!HandleQueue.ContainsKey(i))
                {
                    newChunks.Add(_chunks[i]);
                    continue;
                }

                foreach (var handle in HandleQueue[i])
                {
                    handle.SetValue(_chunks[i]);
                }
            }

            result.Chunks = newChunks;

            buffer.Data = result;

            return EFileReadErrorCodes.NoError;
        }

        private PackageImport ReadImport(Package04ImportHeader r, bool readAsHash)
        {
            // needs header offset
            //Debug.Assert(BaseStream.Position == r.offset);

            var import = new PackageImport()
            {
                Flags = (InternalEnums.EImportFlags)(r.unk1 ? 0b10 : 0b00)
            };
            if (readAsHash)
            {
                import.Hash = _reader.ReadUInt64();
                import.DepotPath = _hashService.Get(import.Hash);
            }
            else
            {
                var bytes = _reader.ReadBytes(r.size);
                import.DepotPath = Encoding.UTF8.GetString(bytes.ToArray());
                import.Hash = FNV1A64HashAlgorithm.HashString(import.DepotPath);
            }
            return import;
        }
        private string ReadName(Package04NameHeader n)
        {
            var s = _reader.ReadNullTerminatedString();
            //Debug.Assert(s.Length == n.size);
            return s;
        }

        private RedBaseClass ReadChunk(Package04ChunkHeader c)
        {
            // needs header offset
            //Debug.Assert(BaseStream.Position == c.offset);
            var redTypeName = GetStringValue((ushort)c.typeID);
            var (type, _) = RedReflection.GetCSTypeFromRedType(redTypeName);
            if (type == typeof(RedBaseClass))
            {
                throw new TypeNotFoundException(redTypeName);
            }

            return ReadClass(type);
        }
    }

    public class PackageImport : IRedImport
    {
        public string DepotPath { get; set; }

        public ulong Hash { get; set; }
        public InternalEnums.EImportFlags Flags { get; set;  }
    }
}
