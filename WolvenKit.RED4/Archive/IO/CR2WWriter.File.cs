using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using WolvenKit.Core.Compression;
using WolvenKit.Core.CRC;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO.PreProcessor;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Archive.IO;

public partial class CR2WWriter
{
    private CR2WFile? _file;

    private static readonly Dictionary<Type, Type> s_preProcessors = new();

    static CR2WWriter()
    {
        s_preProcessors.Add(typeof(appearanceAppearanceDefinition), typeof(appearanceAppearanceDefinitionPreProcessor));
        s_preProcessors.Add(typeof(CMesh), typeof(CMeshPreProcessor));
        s_preProcessors.Add(typeof(entEntityTemplate), typeof(entEntityTemplatePreProcessor));
    }

    public void WriteFile(CR2WFile file)
    {
        if (LoggerService != null && !CompressionSettings.Get().UseOodle)
        {
            LoggerService.Warning("Oodle couldn't be loaded. Using Kraken.dll instead could cause errors.");
        }

        _file = file;

        BaseStream.WriteStruct(CR2WFile.MAGIC);

        var fileHeader = new CR2WFileHeader { version = _file.MetaData.Version, buildVersion = _file.MetaData.BuildVersion, numChunks = 6 };
        var tableHeaders = new CR2WTable[10];

        var headerPos = BaseStream.Position;
        // Write empty header, fill it later
        BaseStream.WriteStruct(fileHeader);
        BaseStream.WriteStructs(tableHeaders);

        Debug.Assert(BaseStream.Position == 160);

        var dataCollection = GenerateData();

        fileHeader.objectsEnd = (uint)BaseStream.Position;

        var (stringBuffer, stringOffsets, importOffsets) = GenerateStringBuffer(dataCollection.StringList, dataCollection.PathList);

        tableHeaders[0] = new CR2WTable()
        {
            offset = (uint)BaseStream.Position,
            itemCount = (uint)stringBuffer.Length,
            crc32 = Crc32Algorithm.Compute(stringBuffer)
        };

        BaseWriter.Write(stringBuffer);

        if (_file.Properties.Count < 1)
        {
            _file.Properties.Add(new CR2WProperty());
        }

        var afterHeaderPosition = CalculateHeaderLength(dataCollection);
        fileHeader.objectsEnd += (uint)afterHeaderPosition;

        #region Names

        tableHeaders[1].offset = (uint)BaseStream.Position;
        tableHeaders[1].itemCount = (uint)dataCollection.StringList.Count;

        var crc = new Crc32Algorithm(false);
        foreach (var str in dataCollection.StringList)
        {
            if (_file.MetaData.HashVersion == EHashVersion.Pre120)
            {
#pragma warning disable CS0618 // Typ oder Element ist veraltet
                BaseStream.WriteStruct(new CR2WNameInfo { hash = str.GetOldRedHash(), offset = stringOffsets[str] }, crc);
#pragma warning restore CS0618 // Typ oder Element ist veraltet
            }
            else
            {
                BaseStream.WriteStruct(new CR2WNameInfo { hash = str.GetShortRedHash(), offset = stringOffsets[str] }, crc);
            }
        }
        tableHeaders[1].crc32 = crc.HashUInt32;

        #endregion Names

        #region Imports

        if (dataCollection.ImportList.Count > 0)
        {
            tableHeaders[2].offset = (uint)BaseStream.Position;
            tableHeaders[2].itemCount = (uint)dataCollection.ImportList.Count;

            crc = new Crc32Algorithm(false);
            foreach (var import in dataCollection.ImportList)
            {
                var entry = new CR2WImportInfo()
                {
                    className = (ushort)dataCollection.StringList.IndexOf(import.ClassName),
                    offset = importOffsets[import.DepotPath],
                    flags = import.Flag
                };

                BaseStream.WriteStruct(entry, crc);
            }

            tableHeaders[2].crc32 = crc.HashUInt32;
        }

        #endregion Imports

        #region Properties

        tableHeaders[3].offset = (uint)BaseStream.Position;
        tableHeaders[3].itemCount = (uint)_file.Properties.Count;

        crc = new Crc32Algorithm(false);
        foreach (var property in _file.Properties)
        {
            BaseStream.WriteStruct(new CR2WPropertyInfo(), crc);
        }

        tableHeaders[3].crc32 = crc.HashUInt32;

        #endregion

        #region Chunks

        if (dataCollection.ChunkInfoList.Count > 0)
        {
            tableHeaders[4].offset = (uint)BaseStream.Position;
            tableHeaders[4].itemCount = (uint)dataCollection.ChunkInfoList.Count;

            crc = new Crc32Algorithm(false);
            foreach (var chunkInfo in dataCollection.ChunkInfoList)
            {
                var entry = chunkInfo;
                entry.dataOffset += (uint)afterHeaderPosition;

                BaseStream.WriteStruct(entry, crc);
            }
            tableHeaders[4].crc32 = crc.HashUInt32;
        }

        #endregion Chunks

        #region Buffers

        var beforeBufferTablePos = BaseStream.Position;
        if (dataCollection.BufferInfoList.Count > 0)
        {
            tableHeaders[5].offset = (uint)BaseStream.Position;
            tableHeaders[5].itemCount = (uint)dataCollection.BufferInfoList.Count;

            foreach (var buffer in dataCollection.BufferInfoList)
            {
                BaseStream.WriteStruct(buffer, crc);
            }
        }

        #endregion Buffers

        #region Embedded

        var (embeddedInfoList, embeddedData) = GenerateEmbeddedData(dataCollection.ImportList);
        if (embeddedInfoList.Count > 0)
        {
            tableHeaders[6].offset = (uint)BaseStream.Position;
            tableHeaders[6].itemCount = (uint)embeddedInfoList.Count;

            crc = new Crc32Algorithm(false);
            foreach (var embedded in embeddedInfoList)
            {
                BaseStream.WriteStruct(embedded, crc);
            }

            tableHeaders[6].crc32 = crc.HashUInt32;
        }

        #endregion Embedded

        Debug.Assert(BaseStream.Position == afterHeaderPosition);

        BaseStream.Write(dataCollection.ChunkData);
        fileHeader.objectsEnd = (uint)BaseStream.Position;

        if (dataCollection.BufferInfoList.Count > 0)
        {
            BaseStream.Position = beforeBufferTablePos;
            crc = new Crc32Algorithm(false);
            for (var i = 0; i < dataCollection.BufferInfoList.Count; i++)
            {
                var entry = dataCollection.BufferInfoList[i];
                entry.offset += fileHeader.objectsEnd;
                dataCollection.BufferInfoList[i] = entry;

                BaseStream.WriteStruct(entry, crc);
            }
            tableHeaders[5].crc32 = crc.HashUInt32;
        }

        BaseStream.Position = fileHeader.objectsEnd;
        BaseStream.Write(dataCollection.BufferData);
        fileHeader.buffersEnd = (uint)BaseStream.Position;

        fileHeader.crc32 = CalculateHeaderCRC32(fileHeader, tableHeaders);
        BaseStream.Position = headerPos;
        BaseStream.WriteStruct(fileHeader);
        BaseStream.WriteStructs(tableHeaders);

        // CheckData(dataCollection, afterHeaderPosition);
    }

    private void CheckData(DataCollection dataCollection, int afterHeaderPosition)
    {
        for (int i = 0; i < dataCollection.ChunkInfoList.Count; i++)
        {
            var newInfo = dataCollection.ChunkInfoList[i];
            var oldInfo = _file!.Info.ExportInfo[i];

            if ((newInfo.dataOffset + afterHeaderPosition) != oldInfo.dataOffset)
            {

            }

            if (newInfo.dataSize != oldInfo.dataSize)
            {

            }

            if (newInfo.parentID != oldInfo.parentID)
            {
                throw new TodoException("Invalid parent id");
            }

            if (newInfo.className != oldInfo.className)
            {

            }

            if (newInfo.objectFlags != oldInfo.objectFlags)
            {

            }

            if (newInfo.template != oldInfo.template)
            {

            }
        }

        for (int i = 0; i < dataCollection.BufferInfoList.Count; i++)
        {
            var newInfo = dataCollection.BufferInfoList[i];
            var oldInfo = _file!.Info.BufferInfo[i];

            if (newInfo.index != oldInfo.index)
            {

            }

            if (newInfo.crc32 != oldInfo.crc32)
            {

            }

            if (newInfo.diskSize != oldInfo.diskSize)
            {

            }

            if (newInfo.flags != oldInfo.flags)
            {

            }

            if (newInfo.memSize != oldInfo.memSize)
            {

            }

            if (newInfo.offset != oldInfo.offset)
            {

            }
        }
    }

    #region Write Sections

    #region Buffers

    private void WriteBufferData(RedBuffer buffer)
    {
        if (buffer.Data is RedPackage p4)
        {
            using var ms = new MemoryStream();
            if (buffer.Parent is appearanceAppearanceDefinition aad)
            {
                using var packageWriter = new appearanceAppearanceDefinitionWriter(ms) { IsRoot = false };
                packageWriter.Settings.ImportsAsHash = true;

                packageWriter.WritePackage(aad, p4);
            }
            else
            {
                using var packageWriter = new RedPackageWriter(ms) { IsRoot = false };

                if (_file!.RootChunk.GetType() == typeof(appearanceAppearanceResource) && buffer.Parent is entEntityTemplate)
                {
                    packageWriter.Settings.ImportsAsHash = true;
                } 
                    
                if (_file!.RootChunk.GetType() == typeof(gamePersistentStateDataResource))
                {
                    packageWriter.Settings.RedPackageType = RedPackageType.SaveResource;
                }
                else if (_file!.RootChunk.GetType() == typeof(inkWidgetLibraryResource))
                {
                    packageWriter.Settings.RedPackageType = RedPackageType.InkLibResource;
                }

                packageWriter.WritePackage(p4);
            }

            buffer.SetBytes(ms.ToArray());
        }

        if (buffer.Data is CR2WList list)
        {
            using var ms = new MemoryStream();
            using var listWriter = new CR2WListWriter(ms) { LoggerService = LoggerService };

            listWriter.WriteList(list, buffer.Parent);
            //listWriter.WriteList(list);

            var newData = ms.ToArray();

            buffer.SetBytes(newData);
        }

        if (buffer.Data is worldNodeDataBuffer ssb)
        {
            using var ms = new MemoryStream();
            using var transformWriter = new worldNodeDataWriter(ms);

            transformWriter.WriteBuffer(ssb);

            var newData = ms.ToArray();

            buffer.SetBytes(newData);
        }

        if (buffer.Data is CollisionBuffer cb)
        {
            using var ms = new MemoryStream();
            using var collisionWriter = new CollisionWriter(ms);

            collisionWriter.WriteBuffer(cb, (worldCollisionNode)buffer.Parent);

            var newData = ms.ToArray();

            buffer.SetBytes(newData);
        }

        if (buffer.Data is CookedInstanceTransformsBuffer citb)
        {
            using var ms = new MemoryStream();
            using var cookedInstanceTransformsWriter = new CookedInstanceTransformsWriter(ms);

            cookedInstanceTransformsWriter.WriteBuffer(citb);

            var newData = ms.ToArray();

            buffer.SetBytes(newData);
        }

        if (buffer is RedBuffer wsb && buffer.Data is WorldTransformsBuffer wtb)
        {
            using var ms = new MemoryStream();
            using var transformWriter = new WorldTransformsWriter(ms);

            transformWriter.WriteBuffer(wtb);

            var newData = ms.ToArray();

            buffer.SetBytes(newData);
        }
    }

    private CR2WBufferInfo WriteBuffer(BinaryWriter writer, RedBuffer buffer)
    {
        var result = new CR2WBufferInfo
        {
            flags = buffer.Flags,
            offset = (uint)writer.BaseStream.Position,
            memSize = buffer.MemSize
        };

        if (!IsRoot)
        {
            throw new TodoException();
        }

        var isInplaceCompressedBuffer =
            buffer.ParentTypes.Count > 0 &&
            buffer.ParentTypes.First() is "animAnimationBufferCompressed.inplaceCompressedBuffer"
                or "animAnimationBufferSimd.inplaceCompressedBuffer";

        var compBuf = buffer.GetCompressedBytes(isInplaceCompressedBuffer);
        writer.Write(compBuf);

        result.diskSize = (uint)compBuf.Length;
        result.crc32 = Crc32Algorithm.Compute(compBuf);

        if (isInplaceCompressedBuffer)
        {
            result.memSize = result.diskSize;
        }

        return result;
    }

    #endregion Buffers

    #region Embedded

    private CR2WEmbeddedInfo WriteEmbedded(CR2WWriter writer, ICR2WEmbeddedFile embeddedData, IList<ImportEntry> importsList)
    {
        var importIndex = -1;
        for (var i = 0; i < importsList.Count; i++)
        {
            if (importsList[i].DepotPath == embeddedData.FileName)
            {
                importIndex = i + 1;
                break;
            }
        }

        if (importIndex == -1)
        {
            throw new TodoException();
        }

        return new CR2WEmbeddedInfo
        {
            chunkIndex = (uint)_chunkInfos[embeddedData.Content].Id,
            importIndex = (uint)importIndex,
            pathHash = 0
        };
    }

    private (List<CR2WEmbeddedInfo>, byte[]) GenerateEmbeddedData(IList<ImportEntry> importsList)
    {
        using var ms = new MemoryStream();
        using var writer = new CR2WWriter(ms) { IsRoot = IsRoot, LoggerService = LoggerService };

        var embeddedInfoList = new List<CR2WEmbeddedInfo>();
        foreach (var embedded in _file!.EmbeddedFiles)
        {
            embeddedInfoList.Add(WriteEmbedded(writer, embedded, importsList));
        }

        return (embeddedInfoList, ms.ToArray());
    }

    #endregion Embedded

    private readonly List<RedBaseClass> _chunks = new();

    private CR2WExportInfo WriteChunk(CR2WWriter file, RedBaseClass chunkData)
    {
        var tmpQueue = file.ChunkQueue;
        file.ChunkQueue = new List<RedBaseClass>();

        if (GetClassName(chunkData) is not { } redTypeName)
        {
            throw new Exception("ClassName could not be resolved");
        }
        var typeIndex = file.GetStringIndex(redTypeName);

        var result = new CR2WExportInfo
        {
            className = typeIndex,
            dataOffset = (uint)file.BaseStream.Position
        };

        if (chunkData is CDistantLightsResource)
        {
            // TODO: Forcing CDistantLightsResource buffers to be inline, please improve
            file.IsRoot = false;
        }
        file.WriteClass(chunkData);

        result.dataSize = (uint)(file.BaseStream.Position - result.dataOffset);

        file.ChunkQueue.AddRange(tmpQueue);

        return result;
    }

    #endregion Write Sections

    #region Support

    private string? GetClassName(RedBaseClass cls)
    {
        if (cls is DynamicResource dres)
        {
            return dres.ClassName;
        }

        if (cls is DynamicBaseClass dbc)
        {
            return dbc.ClassName;
        }

        return RedReflection.GetTypeRedName(cls.GetType());
    }

    private class DataCollection
    {
        public List<CName> StringList { get; set; }
        public List<ResourcePath> PathList { get; set; }
        public List<ImportEntry> ImportList { get; set; }

        public List<CR2WExportInfo> ChunkInfoList { get; set; }
        public byte[] ChunkData { get; set; }

        public List<CR2WBufferInfo> BufferInfoList { get; set; }
        public byte[] BufferData { get; set; }
    }

    protected override void GenerateBufferBytes(RedBuffer buffer) => WriteBufferData(buffer);

    private DataCollection GenerateData()
    {
        var result = new DataCollection();

        using var ms = new MemoryStream();
        using var file = new CR2WWriter(ms) { IsRoot = IsRoot, _file = _file, LoggerService = LoggerService };

        file._chunkInfos = _chunkInfos;

        var chunkCounter = 0;
        var chunkInfoList = new List<CR2WExportInfo>();
        var chunkClassNames = new List<string>();

        var bufferInfoList = new List<CR2WBufferInfo>();

        InternalWriteChunks(_file!.RootChunk);
        foreach (var embeddedFile in _file!.EmbeddedFiles)
        {
            InternalWriteChunks(embeddedFile.Content);
        }

        void InternalWriteChunks(RedBaseClass rootChunk)
        {
            file.ChunkQueue.Insert(0, rootChunk);
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

                if (GetClassName(chunk) is not { } className)
                {
                    throw new Exception("ClassName could not be resolved");
                }
                chunkClassNames.Add(className);

                _chunkInfos[chunk].Id = chunkCounter;

                if (s_preProcessors.TryGetValue(chunk.GetType(), out var processor))
                {
                    if (System.Activator.CreateInstance(processor, LoggerService) is IPreProcessor instance)
                    {
                        instance.Process(chunk);
                    }
                }

                file.StartChunk(chunk);
                chunkInfoList.Add(WriteChunk(file, chunk));
                _chunks.Add(chunk);

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
        }

        file.GenerateStringDictionary();
        result.StringList = file.StringCacheList.ToList();
        result.ImportList = file.ImportCacheList.ToList();

        foreach (var embeddedFile in _file.EmbeddedFiles)
        {
            var typeInfo = RedReflection.GetTypeInfo(embeddedFile.Content);
            SetParent(_chunkInfos[embeddedFile.Content].Id, maxDepth: typeInfo.ChildLevel);

            var tuple = new ImportEntry(CName.Empty, embeddedFile.FileName, 8);
            if (result.ImportList.All(x => x.DepotPath != tuple.DepotPath))
            {
                result.ImportList.Add(tuple);
            }
        }

        result.PathList = new List<ResourcePath>();
        foreach (var importEntry in result.ImportList)
        {
            result.PathList.Add(importEntry.DepotPath);
        }

        for (var i = 0; i < chunkInfoList.Count; i++)
        {
            var chunkInfo = chunkInfoList[i];
            chunkInfo.className = file.StringCacheList.IndexOf(chunkClassNames[i]);
            chunkInfoList[i] = chunkInfo;
        }

        if (_file.RootChunk is worldFoliageBrush)
        {
            SetParent(0);
        }

        var ms2 = new MemoryStream();
        var bw = new BinaryWriter(ms2);

        var bufferList = file.BufferCacheList.ToList();
        for (var i = 0; i < bufferList.Count; i++)
        {
            bufferInfoList.Add(WriteBuffer(bw, bufferList[i]));
        }

        result.BufferInfoList = bufferInfoList;
        result.BufferData = ms2.ToArray();

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
            var index = (short)(file.ImportCacheList.IndexOf(kvp.Value) + 1);
            file.BaseWriter.Write(index);
        }

        foreach (var kvp in file.BufferRef)
        {
            file.BaseStream.Position = kvp.Key;
            var index = (ushort)(file.BufferCacheList.IndexOf(kvp.Value) + 1);
            file.BaseWriter.Write(index);
        }
        file.BaseStream.Position = pos;

        result.ChunkInfoList = chunkInfoList;
        result.ChunkData = ms.ToArray();

        return result;

        void SetParent(int currentIndex, int parent = -1, int depth = 0, int maxDepth = 1)
        {
            if (parent == -1)
            {
                parent = currentIndex + 1;
            }

            foreach (var guid in file.ChildChunks[currentIndex])
            {
                var child = file._chunkGuidToId[guid];
                var chunkInfo = chunkInfoList[child];
                chunkInfo.parentID = (uint)parent;
                chunkInfoList[child] = chunkInfo;

                if (depth < maxDepth)
                {
                    SetParent(child, parent, depth + 1, maxDepth);
                }
            }
        }
    }

    private (byte[], Dictionary<CName, uint>, Dictionary<ResourcePath, uint>) GenerateStringBuffer(List<CName> strings, List<ResourcePath> paths, Encoding? encoding = null)
    {
        encoding ??= Encoding.UTF8;

        var stringOffsetDict = new Dictionary<CName, uint>();
        var resOffsetDict = new Dictionary<ResourcePath, uint>();
        var bytes = new List<byte>();
        foreach (var str in strings)
        {
            stringOffsetDict.Add(str, (uint)bytes.Count);
            if (str != CName.Empty)
            {
                bytes.AddRange(encoding.GetBytes(str!));
            }
            bytes.Add(0);
        }
        foreach (var path in paths)
        {
            resOffsetDict.Add(path, (uint)bytes.Count);
            if (path != ResourcePath.Empty)
            {
                bytes.AddRange(encoding.GetBytes(path));
            }
            bytes.Add(0);
        }
        return (bytes.ToArray(), stringOffsetDict, resOffsetDict);
    }

    private int CalculateHeaderLength(DataCollection dataCollection)
    {
        var result = BaseStream.Position;

        result += Marshal.SizeOf(typeof(CR2WNameInfo)) * dataCollection.StringList.Count;
        result += Marshal.SizeOf(typeof(CR2WImportInfo)) * dataCollection.ImportList.Count;
        result += Marshal.SizeOf(typeof(CR2WPropertyInfo)) * _file!.Properties.Count;
        result += Marshal.SizeOf(typeof(CR2WExportInfo)) * dataCollection.ChunkInfoList.Count;
        result += Marshal.SizeOf(typeof(CR2WBufferInfo)) * dataCollection.BufferInfoList.Count;
        result += Marshal.SizeOf(typeof(CR2WEmbeddedInfo)) * _file!.EmbeddedFiles.Count;

        return (int)result;
    }

    public uint CalculateHeaderCRC32(CR2WFileHeader fileHeader, CR2WTable[] tableHeaders)
    {
        var hash = new Crc32Algorithm(false);
        hash.Append(BitConverter.GetBytes(CR2WFile.MAGIC));
        hash.Append(BitConverter.GetBytes(fileHeader.version));
        hash.Append(BitConverter.GetBytes(fileHeader.flags));
        hash.Append(BitConverter.GetBytes(fileHeader.timeStamp));
        hash.Append(BitConverter.GetBytes(fileHeader.buildVersion));
        hash.Append(BitConverter.GetBytes(fileHeader.objectsEnd));
        hash.Append(BitConverter.GetBytes(fileHeader.buffersEnd));
        hash.Append(BitConverter.GetBytes(CR2WFile.DEADBEEF));
        hash.Append(BitConverter.GetBytes(fileHeader.numChunks));
        foreach (var h in tableHeaders)
        {
            hash.Append(BitConverter.GetBytes(h.offset));
            hash.Append(BitConverter.GetBytes(h.itemCount));
            hash.Append(BitConverter.GetBytes(h.crc32));
        }
        return hash.HashUInt32;
    }

    #endregion Support
}