using System.Text;
using WolvenKit.Common.FNV1A;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Archive.IO;

public partial class RedPackageWriter
{
    private RedPackage _file;

    private RedPackageHeader _header;

    public void WritePackage(RedPackage file)
    {
        _file = file;

        _header = new RedPackageHeader
        {
            version = _file.Version,
            unk1 = _file.Unknown1,
            numSections = 6,
            numComponents = (uint)_file.Chunks.Count
        };

        var headerStart = BaseStream.Position;

        WriteHeader();

        var cruids = new List<CRUID>();
        var chunkList = file.Chunks;

        if (Settings.RedPackageType is RedPackageType.ScriptableSystem)
        {
            var chunkDict = new Dictionary<ulong, RedBaseClass>();

            foreach (var chunk in _file.Chunks)
            {
                var className = GetClassName(chunk);
                ArgumentNullException.ThrowIfNull(className);

                chunkDict.Add(FNV1A64HashAlgorithm.HashString(className), chunk);
            }

            chunkDict = chunkDict.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            chunkList = chunkDict.Values.ToList();
            foreach (var cruid in chunkDict.Keys)
            {
                cruids.Add(cruid);
            }
        }

        var (strings, imports, chunkDesc, chunkData) = GenerateChunkData(chunkList);

        if (imports.Count > 0)
        {
            _header.numSections = 7;

            BaseStream.Position += 8;
        }

        if (Settings.RedPackageType == RedPackageType.Default)
        {
            short cruidsIndex = -1;
            for (var i = 0; i < chunkList.Count; i++)
            {
                if (file.ChunkDictionary.TryGetValue(chunkList[i], out var cruid))
                {
                    cruids.Add(cruid);
                }
                else
                {
                    if (chunkList[i] is entIComponent iComp)
                    {
                        if (iComp.Id != 0)
                        {
                            cruids.Add(iComp.Id);
                        }
                        else
                        {
                            // TODO: Proper way to get these?
                            cruids.Add(Random.Shared.NextCRUID());
                        }
                    }
                    else if (chunkList[i] is entEntity ent)
                    {
                        cruids.Add(0);
                    }
                    else
                    {
                        throw new NotSupportedException();
                    }
                }

                if (chunkList[i] is entEntity && cruidsIndex == -1)
                {
                    cruidsIndex = (short)i;
                }
            }

            BaseWriter.Write(cruidsIndex);

            BaseWriter.Write((ushort)cruids.Count);
            foreach (var cruid in cruids)
            {
                _writer.Write(cruid);
            }
        }

        if (Settings.RedPackageType is RedPackageType.SaveResource or RedPackageType.ScriptableSystem)
        {
            if (Settings.RedPackageType is RedPackageType.SaveResource)
            {
                foreach (var chunk in file.Chunks)
                {
                    if (file.ChunkDictionary.TryGetValue(chunk, out var cruid))
                    {
                        cruids.Add(cruid);
                    }
                    else
                    {
                        // TODO: Proper way to get these?
                        cruids.Add(Random.Shared.NextCRUID());
                    }
                }
            }

            BaseWriter.Write(cruids.Count);
            foreach (var cruid in cruids)
            {
                BaseWriter.Write(cruid);
            }
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
        WriteHeader();
    }

    private void WriteHeader()
    {
        _writer.Write(_header.version);
        _writer.Write(_header.unk1);
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

    protected virtual RedPackageChunkHeader WriteChunk(RedPackageWriter file, RedBaseClass chunk)
    {
        var redTypeName = GetClassName(chunk);
        ArgumentNullException.ThrowIfNull(redTypeName);
        var typeIndex = file.GetStringIndex(redTypeName);

        var result = new RedPackageChunkHeader
        {
            typeID = typeIndex,
            offset = (uint)file.BaseStream.Position
        };

        file.WriteClass(chunk);

        return result;
    }

    private (byte[], IList<RedPackageImportHeader>) GenerateRefBuffer(IList<ImportEntry> refs, uint position)
    {

        var refDesc = new List<RedPackageImportHeader>();
        var refData = new List<byte>();
        foreach (var reff in refs)
        {
            if (Settings.ImportsAsHash)
            {
                if (reff.DepotPath.IsResolvable)
                {
                    ImportHandler.AddPathHandler?.Invoke(reff.DepotPath!);
                }
                
                refDesc.Add(new RedPackageImportHeader
                {
                    offset = (uint)refData.Count + position,
                    size = 8,
                    sync = reff.Flag > 0
                });
                refData.AddRange(BitConverter.GetBytes(reff.DepotPath.GetRedHash()));
            }
            else
            {
                refDesc.Add(new RedPackageImportHeader
                {
                    offset = (uint)refData.Count + position,
                    size = (byte)reff.DepotPath.Length,
                    sync = reff.Flag > 0
                });

                if (reff.DepotPath.IsResolvable)
                {
                    refData.AddRange(Encoding.UTF8.GetBytes(reff.DepotPath!));
                }
            }
        }
        return (refData.ToArray(), refDesc);
    }

    private (byte[], IList<RedPackageNameHeader>) GenerateStringBuffer(IList<CName> strings, uint position)
    {

        var nameDesc = new List<RedPackageNameHeader>();
        var nameData = new List<byte>();
        foreach (var str in strings)
        {
            NotResolvableException.ThrowIfNotResolvable(str);

            var strBytes = Encoding.UTF8.GetBytes(str!);
            nameDesc.Add(new RedPackageNameHeader
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
            StringCacheList.AddRange(stringInfo.Value.List);
        }

        _chunkImportList.Add(CurrentChunk, new() { List = ImportCacheList.ToList() });
        ImportCacheList.Clear();
        foreach (var stringInfo in _chunkImportList)
        {
            ImportCacheList.AddRange(stringInfo.Value.List);
        }
    }

    private string? GetClassName(RedBaseClass cls)
    {
        if (cls is IDynamicClass dbc)
        {
            return dbc.ClassName;
        }

        return RedReflection.GetTypeRedName(cls.GetType());
    }

    private (IList<CName>, IList<ImportEntry>, List<RedPackageChunkHeader>, byte[]) GenerateChunkData(IList<RedBaseClass> chunkList)
    {
        using var ms = new MemoryStream();
        using var file = new RedPackageWriter(ms) { IsRoot = false };

        file._header = _header;
        file._chunkInfos = _chunkInfos;

        var chunkDesc = new List<RedPackageChunkHeader>();
        var chunkClassNames = new List<string>();
        var chunkCounter = 0;

        foreach (var chunk in chunkList)
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

            if (GetClassName(chunk) is not string className)
            {
                throw new ArgumentNullException();
            }

            chunkClassNames.Add(className);

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

        file.GenerateStringDictionary();

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