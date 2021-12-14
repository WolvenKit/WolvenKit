using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using WolvenKit.Common.FNV1A;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Compression;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Archive.IO
{
    public partial class PackageWriter
    {
        private RedBuffer _file;

        private PackageHeader header;
        private List<CRUID> _cruids = new List<CRUID>();

        public void WritePackage(RedBuffer file)
        {
            _file = file;

            header = new PackageHeader
            {
                uk1 = _file.Version,
                numSections = 7
            };

            switch (file.Type)
            {
                case RedBuffer.BufferType.DataBuffer:
                    header.uk2 = 0x0000;
                    break;
                case RedBuffer.BufferType.SerializationDeferredDataBuffer:
                    header.uk2 = 0xffff;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            var headerStart = BaseStream.Position;
            BaseStream.WriteStruct(header);

            var (strings, imports, chunkDesc, chunkData) = GenerateChunkData();

            // write cruids

            var unique_cruids = _cruids;
            if (file.Type == RedBuffer.BufferType.DataBuffer)
            {
                unique_cruids.Insert(0, 0);
            }

            header.numCruids0 = header.numCruids1 = (ushort)unique_cruids.Count;
            foreach (var cruid in unique_cruids)
            {
                Write(cruid);
            }

            var headerEnd = BaseStream.Position;

            // write refs


            header.refPoolDescOffset = Convert.ToUInt32(BaseStream.Position - headerEnd);
            var (refData, refDesc) = GenerateRefBuffer(imports, (uint)(header.refPoolDescOffset + imports.Count * 4));
            BaseStream.WriteStructs(refDesc.ToArray());

            header.refPoolDataOffset = Convert.ToUInt32(BaseStream.Position - headerEnd);
            // do we need a condition for uk3? does it matter?
            BaseStream.Write(refData);

            // write names


            header.namePoolDescOffset = Convert.ToUInt32(BaseStream.Position - headerEnd);
            var (nameData, nameDesc) = GenerateStringBuffer(strings, (uint)(header.namePoolDescOffset + strings.Count * 4));
            BaseStream.WriteStructs(nameDesc.ToArray());

            header.namePoolDataOffset = Convert.ToUInt32(BaseStream.Position - headerEnd);
            BaseStream.Write(nameData);

            // write chunks

            header.chunkDescOffset = Convert.ToUInt32(BaseStream.Position - headerEnd);

            for (var i = 0; i < chunkDesc.Count; i++)
            {
                var chunkInfo = chunkDesc[i];
                chunkInfo.offset += (uint)(header.chunkDescOffset + chunkDesc.Count * 8);
                chunkDesc[i] = chunkInfo;
            }

            BaseStream.WriteStructs(chunkDesc.ToArray());

            header.chunkDataOffset = Convert.ToUInt32(BaseStream.Position - headerEnd);
            BaseStream.Write(chunkData);

            // rewrite header with correct info

            BaseStream.Position = headerStart;
            BaseStream.WriteStruct(header);

        }

        private PackageChunkHeader WriteChunk(PackageWriter file, IRedClass chunk)
        {
            var redTypeName = RedReflection.GetTypeRedName(chunk.GetType());
            var typeIndex = file.GetStringIndex(redTypeName);

            var result = new PackageChunkHeader
            {
                typeID = typeIndex,
                offset = (uint)file.BaseStream.Position
            };

            file.WriteClass(chunk);

            return result;
        }

        private (byte[], IList<PackageImportHeader>) GenerateRefBuffer(IList<(string, CName, ushort)> refs, uint position)
        {

            var refDesc = new List<PackageImportHeader>();
            var refData = new List<byte>();
            foreach (var reff in refs)
            {
                if (header.uk2 == 0)
                {
                    refDesc.Add(new PackageImportHeader
                    {
                        offset = (uint)refData.Count + position,
                        size = (byte)reff.Item2.Length,
                        unk1 = (reff.Item3 & 0b10) > 0
                    });
                    refData.AddRange(Encoding.UTF8.GetBytes(reff.Item2));
                }
                else
                {
                    refDesc.Add(new PackageImportHeader
                    {
                        offset = (uint)refData.Count + position,
                        size = 8,
                        unk1 = (reff.Item3 & 0b10) > 0
                    });
                    refData.AddRange(BitConverter.GetBytes(reff.Item2.GetRedHash()));
                }
            }
            return (refData.ToArray(), refDesc);
        }

        private (byte[], IList<PackageNameHeader>) GenerateStringBuffer(IList<CName> strings, uint position)
        {

            var nameDesc = new List<PackageNameHeader>();
            var nameData = new List<byte>();
            foreach (var str in strings)
            {
                nameDesc.Add(new PackageNameHeader
                {
                    offset = (uint)nameData.Count + position,
                    size = (byte)(str.Length + 1)
                });
                nameData.AddRange(Encoding.UTF8.GetBytes(str));
                nameData.Add(0);
            }
            return (nameData.ToArray(), nameDesc);
        }

        private new (Dictionary<CName, ushort>, Dictionary<(string, CName, ushort), ushort>) GenerateStringDictionary()
        {
            _chunkStringList.Add(CurrentChunk, new() { List = StringCacheList.ToList() });
            StringCacheList.Clear();
            foreach (var stringInfo in _chunkStringList)
            {
                if (stringInfo.Value.List.Contains(""))
                {
                    stringInfo.Value.List.Remove("");
                }

                StringCacheList.AddRange(stringInfo.Value.List);
            }

            _chunkImportList.Add(CurrentChunk, new() { List = ImportCacheList.ToList() });
            ImportCacheList.Clear();
            foreach (var stringInfo in _chunkImportList)
            {
                ImportCacheList.AddRange(stringInfo.Value.List);
            }

            return (StringCacheList.ToDictionary(), ImportCacheList.ToDictionary());
        }

        private (IList<CName>, IList<(string, CName, ushort)>, List<PackageChunkHeader>, byte[]) GenerateChunkData()
        {
            using var ms = new MemoryStream();
            using var file = new PackageWriter(ms);

            var chunkDesc = new List<PackageChunkHeader>();
            for (int i = 0; i < _file.Chunks.Count; i++)
            {
                file.StartChunk(i);
                chunkDesc.Add(WriteChunk(file, _file.Chunks[i]));
            }

            _cruids.AddRange(file._cruids);

            var (stringDict, importDict) = file.GenerateStringDictionary();

            stringDict.Remove("");

            for (int i = 0; i < _file.Chunks.Count; i++)
            {
                var chunkInfo = chunkDesc[i];
                chunkInfo.typeID = stringDict[RedReflection.GetTypeRedName(_file.Chunks[i].GetType())];
                chunkDesc[i] = chunkInfo;

                // TODO: Find a "better" way to determine that
                if (i != 0 || _file.Chunks[i] is worldFoliageBrush)
                {
                    var typeInfo = RedReflection.GetTypeInfo(_file.Chunks[i].GetType());
                    if (typeInfo.ChildLevel > 0)
                    {
                        SetParent(i, i, typeInfo.ChildLevel);
                    }
                }
            }

            var pos = file.BaseStream.Position;
            foreach (var kvp in file.CNameRef)
            {
                file.BaseStream.Position = kvp.Key;
                var index = stringDict[kvp.Value];
                file.BaseWriter.Write(index);
            }
            foreach (var kvp in file.ImportRef)
            {
                file.BaseStream.Position = kvp.Key;
                var index = (ushort)(importDict[kvp.Value] + 0);
                file.BaseWriter.Write(index);
            }
            file.BaseStream.Position = pos;

            return (file.StringCacheList.ToList(), file.ImportCacheList.ToList(), chunkDesc, ms.ToArray());

            void SetParent(int chunkIndex, int parentIndex, int maxLevel = 1, int level = 0)
            {
                var targets = file.GetTargets(chunkIndex);
                foreach (var target in targets)
                {
                    var chunkInfo = chunkDesc[target.Item2 - 1];
                    chunkDesc[target.Item2 - 1] = chunkInfo;

                    if (level < maxLevel)
                    {
                        SetParent(target.Item2 - 1, parentIndex, maxLevel, level + 1);
                    }
                }
            }
        }

    }
}
