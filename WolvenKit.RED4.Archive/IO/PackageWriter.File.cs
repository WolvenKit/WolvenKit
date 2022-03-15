using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO
{
    public partial class PackageWriter
    {
        private Package04 _file;

        private Package04Header _header;
        private short _cruidIndex = -1;
        private readonly List<CRUID> _cruids = new();

        public void WritePackage(Package04 file, Type fileRootType)
        {
            _file = file;

            // might need to work through chunks to figure out if there are 7 sections
            // setup a separate stream for that?
            _header = new Package04Header
            {
                version = _file.Version,
                numSections = _file.Sections,
                numComponents = (uint)_file.Chunks.Count
            };

            var headerStart = BaseStream.Position;

            WriteHeader();

            var (strings, imports, chunkDesc, chunkData) = GenerateChunkData();

            short cuidsIndex = -1;
            var cruids = new List<CRUID>();
            for (var i = 0; i < file.Chunks.Count; i++)
            {
                if (file.Chunks[i] is entIComponent comp)
                {
                    if (comp.Id != 0)
                    {
                        cruids.Add(comp.Id);
                    }
                    else
                    {
                        if (i < file.RootCruids.Count)
                        {
                            cruids.Add(file.RootCruids[i]);
                        }
                        else
                        {
                            // TODO: ...
                            cruids.Add((ulong)Random.Shared.NextInt64());
                        }
                    }
                }
                else
                {
                    if (cuidsIndex == -1)
                    {
                        cuidsIndex = (short)i;
                    }
                    cruids.Add(0);
                }
            }

            if (fileRootType == typeof(gamePersistentStateDataResource))
            {
                BaseWriter.Write(cruids.Count);
                foreach (var cruid in cruids)
                {
                    Write(cruid);
                }
            }
            else if (fileRootType != typeof(inkWidgetLibraryResource))
            {
                BaseWriter.Write(cuidsIndex);
                BaseWriter.Write((ushort)cruids.Count);
                foreach (var cruid in cruids)
                {
                    _writer.Write(cruid);
                }
            }

            var headerEnd = BaseStream.Position;

            // write refs

            if (_header.numSections == 7)
            {
                var writeRefAsHash = fileRootType == typeof(appearanceAppearanceResource);

                _header.refPoolDescOffset = Convert.ToUInt32(BaseStream.Position - headerEnd);
                var (refData, refDesc) = GenerateRefBuffer(imports, (uint)(_header.refPoolDescOffset + imports.Count * 4), writeRefAsHash);
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
            WriteHeader();
        }

        private void WriteHeader()
        {
            _writer.Write(_header.version);
            _writer.Write(_header.numSections);
            _writer.Write(_header.numComponents);

            if (_header.numSections == 7)
            {
                _writer.Write(_header.refPoolDescOffset);
                _writer.Write(_header.refPoolDataOffset);
            }

            _writer.Write(_header.namePoolDescOffset);
            _writer.Write(_header.namePoolDataOffset);

            _writer.Write(_header.chunkDescOffset);
            _writer.Write(_header.chunkDataOffset);
        }

        private Package04ChunkHeader WriteChunk(PackageWriter file, RedBaseClass chunk)
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

        private (byte[], IList<Package04ImportHeader>) GenerateRefBuffer(IList<ImportEntry> refs, uint position, bool writeRefAsHash)
        {

            var refDesc = new List<Package04ImportHeader>();
            var refData = new List<byte>();
            foreach (var reff in refs)
            {
                if (writeRefAsHash)
                {
                    refDesc.Add(new Package04ImportHeader
                    {
                        offset = (uint)refData.Count + position,
                        size = 8,
                        sync = reff.Flag > 0
                    });
                    refData.AddRange(BitConverter.GetBytes(reff.DepotPath.GetRedHash()));
                }
                else
                {
                    refDesc.Add(new Package04ImportHeader
                    {
                        offset = (uint)refData.Count + position,
                        size = (byte)reff.DepotPath.Length,
                        sync = reff.Flag > 0
                    });

                    if ((string)reff.DepotPath != null)
                    {
                        refData.AddRange(Encoding.UTF8.GetBytes(reff.DepotPath));
                    }
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
                var strBytes = Encoding.UTF8.GetBytes(str);
                nameDesc.Add(new Package04NameHeader
                {
                    offset = (uint)nameData.Count + position,
                    size = (byte)(strBytes.Length + 1)
                });
                nameData.AddRange(strBytes);
                nameData.Add(0);
            }
            return (nameData.ToArray(), nameDesc);
        }

        private new void GenerateStringDictionary()
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
        }

        private (IList<CName>, IList<ImportEntry>, List<Package04ChunkHeader>, byte[]) GenerateChunkData()
        {
            using var ms = new MemoryStream();
            using var file = new PackageWriter(ms);

            file._header = _header;
            file._chunkInfos = _chunkInfos;

            var chunkDesc = new List<Package04ChunkHeader>();
            var chunkClassNames = new List<string>();
            var chunkCounter = 0;

            foreach (var chunk in _file.Chunks)
            {
                file.ChunkQueue.Add(chunk);
            }

            while (file.ChunkQueue.Count > 0)
            {
                var chunk = file.ChunkQueue[0];
                file.ChunkQueue.RemoveAt(0);

                if (!_chunkInfos.ContainsKey(chunk))
                {
                    _chunkInfos.Add(chunk, new ChunkInfo());
                }

                if (_chunkInfos[chunk].Id != -1)
                {
                    continue;
                }

                if (chunk is entEntity)
                {
                    if (_cruidIndex == -1)
                    {
                        _cruidIndex = (short)chunkCounter;
                    }

                    _cruids.Add(1);
                }

                chunkClassNames.Add(RedReflection.GetTypeRedName(chunk.GetType()));

                _chunkInfos[chunk].Id = chunkCounter;
                file.StartChunk(chunk);
                chunkDesc.Add(WriteChunk(file, chunk));

                var guid = _chunkInfos[chunk].Guid;
                if (guid != Guid.Empty && file.ChunkReferences.ContainsKey(guid))
                {
                    var startPos = file.BaseStream.Position;
                    foreach (var (position, offset, indexType) in file.ChunkReferences[guid])
                    {
                        file.BaseStream.Position = position;
                        if (indexType == typeof(int))
                        {
                            file.BaseWriter.Write(_chunkInfos[chunk].Id + offset);
                        }
                        else if (indexType == typeof(short))
                        {
                            file.BaseWriter.Write((short)(_chunkInfos[chunk].Id + offset));
                        }
                        else
                        {
                            throw new NotSupportedException(nameof(InternalHandleWriter));
                        }
                    }
                    file.BaseStream.Position = startPos;
                }

                chunkCounter++;
            }

            _cruids.AddRange(file._cruids);

            file.GenerateStringDictionary();
            file.StringCacheList.Remove("");

            for (var i = 0; i < chunkDesc.Count; i++)
            {
                var chunkInfo = chunkDesc[i];
                chunkInfo.typeID = file.StringCacheList.IndexOf(chunkClassNames[i]);
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
                var index = file.StringCacheList.IndexOf(kvp.Value);
                file.BaseWriter.Write(index);
            }
            foreach (var kvp in file.ImportRef)
            {
                file.BaseStream.Position = kvp.Key;
                var index = (ushort)(file.ImportCacheList.IndexOf(kvp.Value) + 0);
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
