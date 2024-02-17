using System.Diagnostics;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Archive.IO;

public partial class CR2WReader
{
    private CR2WFile _cr2wFile => (CR2WFile)_outputFile;
    private bool _parseBuffer;

    public EFileReadErrorCodes ReadFileInfo(out CR2WFileInfo? info)
    {
        var id = BaseStream.ReadStruct<uint>();
        if (id != CR2WFile.MAGIC)
        {
            info = null;
            return EFileReadErrorCodes.NoCr2w;
        }

        info = new CR2WFileInfo
        {
            FileHeader = BaseStream.ReadStruct<CR2WFileHeader>()
        };

        if (info.FileHeader.version is > 195 or < 163)
        {
            return EFileReadErrorCodes.UnsupportedVersion;
        }

        // Tables [7-9] are not used in cr2w so far.
        var tableHeaders = BaseStream.ReadStructs<CR2WTable>(10);

        // read strings - block 1 (index 0)
        info.StringDict = ReadStringDict(tableHeaders[0]);
        if (CollectData)
        {
            foreach (var pair in info.StringDict)
            {
                DataCollection.RawStringList.Add(pair.Value);
            }
        }

        // read the other tables

        info.NameInfo = ReadTable<CR2WNameInfo>(tableHeaders[1]); // block 2
        info.ImportInfo = ReadTable<CR2WImportInfo>(tableHeaders[2]); // block 3
        info.PropertyInfo = ReadTable<CR2WPropertyInfo>(tableHeaders[3]); // block 4
        info.ExportInfo = ReadTable<CR2WExportInfo>(tableHeaders[4]); // block 5
        info.BufferInfo = ReadTable<CR2WBufferInfo>(tableHeaders[5]);  // block 6
        info.EmbeddedInfo = ReadTable<CR2WEmbeddedInfo>(tableHeaders[6]); // block 7

        foreach (var nameInfo in info.NameInfo)
        {
            _namesList.Add(ReadName(nameInfo, info.StringDict));
        }

        foreach (var importInfo in info.ImportInfo)
        {
            var import = ReadImport(importInfo, info.StringDict);

            info.Imports.Add(import);
            _importsList.Add(import);
        }

        return EFileReadErrorCodes.NoError;
    }

    public EFileReadErrorCodes ReadFile(out CR2WFile? file, bool parseBuffer = true)
    {
        var result = ReadFileInfo(out var info);
        if (result == EFileReadErrorCodes.NoCr2w)
        {
            file = null;
            return result;
        }

        file = new CR2WFile() { Info = info! };

        if (result == EFileReadErrorCodes.UnsupportedVersion)
        {
            return result;
        }

        _outputFile = new CR2WFile();
        _parseBuffer = parseBuffer;

        _cr2wFile.Info = info!;
        _cr2wFile.MetaData.Version = _cr2wFile.Info.FileHeader.version;
        _cr2wFile.MetaData.BuildVersion = _cr2wFile.Info.FileHeader.buildVersion;
        _cr2wFile.MetaData.ObjectsEnd = _cr2wFile.Info.FileHeader.objectsEnd;

        // use 1 as 0 is always empty
        _cr2wFile.MetaData.HashVersion = IdentifyHash(_cr2wFile.Info.StringDict[1], _cr2wFile.Info.NameInfo[1].hash);
        if (_cr2wFile.MetaData.HashVersion == EHashVersion.Unknown)
        {
            throw new Exception();
        }

        #region Read Data

        foreach (var propertyInfo in _cr2wFile.Info.PropertyInfo)
        {
            _cr2wFile.Properties.Add(ReadProperty(propertyInfo));
        }

        if (_cr2wFile.Info.PropertyInfo.Length > 1)
        {
            throw new TodoException("Found unsupported PropertyInfo");
        }

        // Init before reading so CHandle/CWeakHandle can be resolved directly
        var chunkPos = BaseStream.Position;
        for (var i = 0; i < _cr2wFile.Info.ExportInfo.Length; i++)
        {
            InitChunk(i);
        }

        BaseStream.Position = chunkPos;
        for (var i = 0; i < _cr2wFile.Info.ExportInfo.Length; i++)
        {
            ReadChunk(i);
        }

        for (var i = 0; i < _cr2wFile.Info.BufferInfo.Length; i++)
        {
            var buffer = ReadBuffer(_cr2wFile.Info.BufferInfo[i]);
            buffer.RootChunk = _cr2wFile.RootChunk;

            if (!BufferQueue.ContainsKey(i))
            {
                LoggerService?.Warning("Unused buffer found!");
                continue;
            }

            foreach (var pointer in BufferQueue[i])
            {
                var clone = buffer.Clone();

                foreach (var parentType in pointer.GetValue().ParentTypes)
                {
                    clone.ParentTypes.Add(parentType);
                }
                clone.Parent = pointer.GetValue().Parent;

                pointer.SetValue(clone);

                ParseBuffer(clone);
            }

            BufferQueue.Remove(i);
        }

        if (BufferQueue.Count > 0)
        {
            throw new TodoException($"The CR2W file is missing {BufferQueue.Count} buffer(s)");
        }

        foreach (var embeddedInfo in _cr2wFile.Info.EmbeddedInfo)
        {
            _cr2wFile.EmbeddedFiles.Add(ReadEmbedded(embeddedInfo));
        }

        #endregion Read Data

        //if (BaseStream.Position != BaseStream.Length)
        //{
        //    throw new TodoException();
        //}

        /*if (_chunks.Count > 1)
        {
            throw new TodoException();
        }*/

        file = _cr2wFile;

        return EFileReadErrorCodes.NoError;
    }

    #region Read Sections

    private CName ReadName(CR2WNameInfo info, Dictionary<uint, string> stringDict) => !stringDict.ContainsKey(info.offset) ? throw new TodoException() : stringDict[info.offset];

    private CR2WImport ReadImport(CR2WImportInfo info, IDictionary<uint, string> stringDict)
    {
        var ret = new CR2WImport
        {
            ClassName = _namesList[info.className]!,
            DepotPath = stringDict[info.offset],
            Flags = (InternalEnums.EImportFlags)info.flags
        };

        if (CollectData && ret.DepotPath.IsResolvable)
        {
            DataCollection.RawStringList.Remove(ret.DepotPath!);
            DataCollection.RawImportList.Add(ret.DepotPath!);
        }

        return ret;
    }

    private CR2WProperty ReadProperty(CR2WPropertyInfo info) => new();

    private void InitChunk(int chunkIndex)
    {
        var info = _cr2wFile.Info.ExportInfo[chunkIndex];

        var redTypeName = GetStringValue(info.className);
        var (type, _) = RedReflection.GetCSTypeFromRedType(redTypeName!);

        var instance = RedTypeManager.Create(type);
        if (instance is DynamicBaseClass dbc)
        {
            if (chunkIndex == 0)
            {
                instance = new DynamicResource { ClassName = redTypeName! };
            }
            else
            {
                dbc.ClassName = redTypeName!;
            }
        }

        if (chunkIndex == 0)
        {
            _cr2wFile.RootChunk = instance;
        }

        _chunks.Add(chunkIndex, new ChunkInfo(instance));
    }

    private void ReadChunk(int chunkIndex)
    {
        var info = _cr2wFile.Info.ExportInfo[chunkIndex];

        Debug.Assert(BaseStream.Position == info.dataOffset);

        ReadClass(_chunks[chunkIndex].Instance, info.dataSize);

        if (BaseStream.Position - info.dataOffset != info.dataSize)
        {
            LoggerService?.Warning("Chunk size mismatch! Could lead to problems");
            BaseStream.Position = info.dataOffset + info.dataSize;
        }
    }

    private RedBuffer ReadBuffer(CR2WBufferInfo info)
    {
        Debug.Assert(BaseStream.Position == info.offset);

        var buffer = BaseReader.ReadBytes((int)info.diskSize);
        return RedBuffer.CreateBuffer(info.flags, buffer);
    }

    private void ParseBuffer(RedBuffer buffer)
    {
        if (!_parseBuffer)
        {
            return;
        }

        if (BufferHelper.TryGetReader(buffer, out var reader))
        {
            if (reader is IErrorHandler err)
            {
                err.ParsingError += HandleParsingError;
            }

            if (reader is IDataCollector collector)
            {
                collector.CollectData = CollectData;
            }

            if (reader is RedPackageReader pReader)
            {
                var rootType = _cr2wFile.RootChunk.GetType();

                if (rootType == typeof(gamePersistentStateDataResource))
                {
                    pReader.Settings.RedPackageType = RedPackageType.SaveResource;
                }
                else if (rootType == typeof(inkWidgetLibraryResource))
                {
                    pReader.Settings.RedPackageType = RedPackageType.InkLibResource;
                }
                else if (rootType == typeof(appearanceAppearanceResource))
                {
                    pReader.Settings.ImportsAsHash = true;
                }

                pReader.LoggerService = LoggerService;
            }

            reader.ReadBuffer(buffer);

            if (reader is IDataCollector { CollectData: true } collector2)
            {
                DataCollection.Buffers ??= new List<DataCollection>();
                DataCollection.Buffers.Add(collector2.DataCollection);
            }
        }
    }

    private CR2WEmbedded ReadEmbedded(CR2WEmbeddedInfo info)
    {
        if (info.pathHash != 0)
        {
            throw new TodoException();
        }

        var result = new CR2WEmbedded
        {
            FileName = _importsList[(int)info.importIndex - 1].DepotPath!,
            Content = _chunks[(int)info.chunkIndex].Instance
        };

        _chunks[(int)info.chunkIndex].IsUsed = true;

        return result;
    }

    #endregion Read Sections

    #region Support

    private Dictionary<uint, string> ReadStringDict(CR2WTable stringInfoTable)
    {
        Debug.Assert(BaseStream.Position == stringInfoTable.offset);

        var result = new Dictionary<uint, string>();
        while (BaseStream.Position < (stringInfoTable.offset + stringInfoTable.itemCount))
        {
            var pos = (uint)BaseStream.Position - stringInfoTable.offset;
            var str = _reader.ReadNullTerminatedString();
            if (string.IsNullOrEmpty(str))
            {
                str = "None";
            }
            result.Add(pos, str);
        }

        return result;
    }

    private T[] ReadTable<T>(CR2WTable tableHeader) where T : struct => BaseStream.ReadStructs<T>(tableHeader.itemCount);

    public EHashVersion IdentifyHash(CName value, uint hash)
    {
        if (value.GetShortRedHash() == hash)
        {
            return EHashVersion.Latest;
        }

#pragma warning disable CS0618 // Typ oder Element ist veraltet
        if (value.GetOldRedHash() == hash)
#pragma warning restore CS0618 // Typ oder Element ist veraltet
        {
            return EHashVersion.Pre120;
        }

        return EHashVersion.Unknown;
    }

    #endregion Support
}