using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using WolvenKit.Common.FNV1A;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Compression;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Archive.IO
{
    public partial class PackageWriter
    {
        private Package04 _file;

        private Package04Header _header;
        private List<CRUID> _cruids = new();
        private ushort refsAreStrings = 0;

        public void WritePackage(Package04 file)
        {
            _file = file;

            // might need to work through chunks to figure out if there are 7 sections
            // setup a separate stream for that?
            _header = new Package04Header
            {
                version = _file.Version,
                numSections = 7
            };

            if (file.RootChunk is entEntity)
            {
                refsAreStrings = 0x0000;
            }
            else if (file.RootChunk is entIComponent)
            {
                refsAreStrings = 0xffff;
            }
            //else
            //{
            //    throw new ArgumentOutOfRangeException();
            //}

            var headerStart = BaseStream.Position;
            //BaseStream.WriteStruct(_header);

            _writer.Write(_header.version);
            _writer.Write(_header.numSections);
            _writer.Write(_header.numCruids0);

            if (_header.numSections == 7)
            {
                _writer.Write(_header.refPoolDescOffset);
                _writer.Write(_header.refPoolDataOffset);
            }

            _writer.Write(_header.namePoolDescOffset);
            _writer.Write(_header.namePoolDataOffset);

            _writer.Write(_header.chunkDescOffset);
            _writer.Write(_header.chunkDataOffset);

            var (strings, imports, chunkDesc, chunkData) = GenerateChunkData();

            var unique_cruids = _cruids;
            if (refsAreStrings == 0)
            {
                unique_cruids.Insert(0, 0);
            }

            _header.numCruids0 = (ushort)unique_cruids.Count;

            _writer.Write(refsAreStrings);
            _writer.Write((ushort)_header.numCruids0);

            // write cruids
            foreach (var cruid in unique_cruids)
            {
                Write(cruid);
            }

            var headerEnd = BaseStream.Position;

            // write refs

            if (_header.numSections == 7)
            {
                _header.refPoolDescOffset = Convert.ToUInt32(BaseStream.Position - headerEnd);
                var (refData, refDesc) = GenerateRefBuffer(imports, (uint)(_header.refPoolDescOffset + imports.Count * 4));
                BaseStream.WriteStructs(refDesc.ToArray());

                _header.refPoolDataOffset = Convert.ToUInt32(BaseStream.Position - headerEnd);
                BaseStream.Write(refData);
            }

            // write names

            _header.namePoolDescOffset = Convert.ToUInt32(BaseStream.Position - headerEnd);
            var (nameData, nameDesc) = GenerateStringBuffer(strings, (uint)(_header.namePoolDescOffset + strings.Count * 4));
            BaseStream.WriteStructs(nameDesc.ToArray());

            _header.namePoolDataOffset = Convert.ToUInt32(BaseStream.Position - headerEnd);
            BaseStream.Write(nameData);

            // write chunks

            _header.chunkDescOffset = Convert.ToUInt32(BaseStream.Position - headerEnd);

            for (var i = 0; i < chunkDesc.Count; i++)
            {
                var chunkInfo = chunkDesc[i];
                chunkInfo.offset += (uint)(_header.chunkDescOffset + chunkDesc.Count * 8);
                chunkDesc[i] = chunkInfo;
            }

            BaseStream.WriteStructs(chunkDesc.ToArray());

            _header.chunkDataOffset = Convert.ToUInt32(BaseStream.Position - headerEnd);
            BaseStream.Write(chunkData);

            // rewrite header with correct info

            BaseStream.Position = headerStart;
            BaseStream.WriteStruct(_header);

        }

        private Package04ChunkHeader WriteChunk(PackageWriter file, IRedClass chunk)
        {
            var redTypeName = RedReflection.GetTypeRedName(chunk.GetType());
            var typeIndex = file.GetStringIndex(redTypeName);

            var result = new Package04ChunkHeader
            {
                typeID = typeIndex,
                offset = (uint)file.BaseStream.Position
            };

            file.WriteClass(chunk);

            return result;
        }

        private (byte[], IList<Package04ImportHeader>) GenerateRefBuffer(IList<(string, CName, ushort)> refs, uint position)
        {

            var refDesc = new List<Package04ImportHeader>();
            var refData = new List<byte>();
            foreach (var reff in refs)
            {
                if (refsAreStrings == 0)
                {
                    refDesc.Add(new Package04ImportHeader
                    {
                        offset = (uint)refData.Count + position,
                        size = (byte)reff.Item2.Length,
                        unk1 = (reff.Item3 & 0b10) > 0
                    });

                    if ((string)reff.Item2 != null)
                    {
                        refData.AddRange(Encoding.UTF8.GetBytes(reff.Item2));
                    }
                }
                else
                {
                    refDesc.Add(new Package04ImportHeader
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

        private (byte[], IList<Package04NameHeader>) GenerateStringBuffer(IList<CName> strings, uint position)
        {

            var nameDesc = new List<Package04NameHeader>();
            var nameData = new List<byte>();
            foreach (var str in strings)
            {
                nameDesc.Add(new Package04NameHeader
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

        private (IList<CName>, IList<(string, CName, ushort)>, List<Package04ChunkHeader>, byte[]) GenerateChunkData()
        {
            using var ms = new MemoryStream();
            using var file = new PackageWriter(ms);

            var chunkDesc = new List<Package04ChunkHeader>();
            var chunkClassNames = new List<string>();
            var chunkCounter = 0;

            foreach (var chunk in _file.Chunks)
            {
                file.ChunkQueue.AddLast((RedBaseClass)chunk);
            }

            while (file.ChunkQueue.Count > 0)
            {
                var chunk = file.ChunkQueue.First.Value;
                file.ChunkQueue.RemoveFirst();

                if (chunk.Chunk != -1)
                {
                    continue;
                }

                chunkClassNames.Add(RedReflection.GetTypeRedName(chunk.GetType()));

                chunk.Chunk = chunkCounter;
                file.StartChunk(chunk);
                chunkDesc.Add(WriteChunk(file, chunk));
                
                var guid = chunk.Guid;
                if (guid != Guid.Empty && file.ChunkReferences.ContainsKey(guid))
                {
                    var startPos = file.BaseStream.Position;
                    foreach (var (position, offset) in file.ChunkReferences[guid])
                    {
                        file.BaseStream.Position = position;
                        file.BaseWriter.Write(chunk.Chunk + offset);
                    }
                    file.BaseStream.Position = startPos;
                }

                chunkCounter++;
            }

            _cruids.AddRange(file._cruids);

            var (stringDict, importDict) = file.GenerateStringDictionary();

            stringDict.Remove("");

            for (int i = 0; i < chunkDesc.Count; i++)
            {
                var chunkInfo = chunkDesc[i];
                chunkInfo.typeID = stringDict[chunkClassNames[i]];
                chunkDesc[i] = chunkInfo;

                // TODO: Find a "better" way to determine that
                /*if (i != 0 || _file.Chunks[i] is worldFoliageBrush)
                {
                    var typeInfo = RedReflection.GetTypeInfo(_file.Chunks[i].GetType());
                    if (typeInfo.ChildLevel > 0)
                    {
                        SetParent(i, i, typeInfo.ChildLevel);
                    }
                }*/
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

            /*void SetParent(int chunkIndex, int parentIndex, int maxLevel = 1, int level = 0)
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
            }*/
        }

    }
}
