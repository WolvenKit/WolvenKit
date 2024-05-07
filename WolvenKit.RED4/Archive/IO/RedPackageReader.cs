using System.Reflection;
using System.Text;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;
using Activator = System.Activator;

namespace WolvenKit.RED4.Archive.IO;

public partial class RedPackageReader : Red4Reader
{
    public ILoggerService? LoggerService { get; set; }

    public RedPackageSettings Settings = new();

    public RedPackageReader(Stream input) : this(new BinaryReader(input, Encoding.UTF8, false))
    {
    }

    public RedPackageReader(BinaryReader reader) : base(reader)
    {
    }

    public override void ReadClass(RedBaseClass cls, uint size)
    {
        var typeInfo = RedReflection.GetTypeInfo(cls);

        var baseOff = BaseStream.Position;
        var fieldCount = _reader.ReadUInt16();
        var fields = BaseStream.ReadStructs<RedPackageFieldHeader>(fieldCount);

        var compiledPropertyData = cls as IRedCompiledPropertyData;

        foreach (var f in fields)
        {
            var varName = GetStringValue(f.nameID).GetResolvedText()!;
            var redTypeName = GetStringValue(f.typeID);

            var dataStartPos = baseOff + f.offset;
            BaseStream.Position = dataStartPos;

            var fullName = $"{RedReflection.GetRedTypeFromCSType(cls.GetType())}.{varName}";

            IRedType? value;

            var prop = typeInfo.GetPropertyInfoByRedName(varName);
            if (prop != null)
            {
                ArgumentNullException.ThrowIfNull(prop.RedName);

                var propRedType = RedReflection.GetRedTypeFromCSType(prop.Type, prop.Flags);

                if (propRedType != redTypeName)
                {
                    if (TryReadValue(varName, redTypeName, compiledPropertyData, out value))
                    {
                        var args = new InvalidRTTIEventArgs(fullName, propRedType, redTypeName!, value);
                        if (!HandleParsingError(args))
                        {
                            throw new InvalidRTTIException(fullName, propRedType, redTypeName!);
                        }

                        SetProperty(cls, prop.RedName, args.Value);
                        continue;
                    }
                }

                _reader.BaseStream.Position = dataStartPos;

                if (TryReadValue(varName, propRedType, compiledPropertyData, out value))
                {
                    SetProperty(cls, prop.RedName, value);
                    continue;
                }

                if (propRedType == redTypeName)
                {
                    LoggerService?.Warning($"Can't read data for \"{fullName}\" (\"{propRedType}\"). Skipping");
                    continue;
                }

                LoggerService?.Warning($"Invalid RedType detected for \"{fullName}\". \"{redTypeName}\" instead of \"{propRedType}\". Skipping");
                continue;
            }

            // dynamic stuff
            var redTypeInfos = RedReflection.GetRedTypeInfos(redTypeName!);
            var (hasError, errorRedName) = CheckRedTypeInfos(ref redTypeInfos);

            if (hasError)
            {
                LoggerService?.Warning($"Type \"{errorRedName}\" is not known! Non-RTTI property \"{fullName}\" will be ignored");
                continue;
            }

            var (fieldType, _) = RedReflection.GetCSTypeFromRedType(redTypeName!);
            cls.AddDynamicProperty(varName, fieldType);

            if (compiledPropertyData != null && compiledPropertyData.IsCustomReadNeeded(header))
            {
                value = compiledPropertyData.CustomRead(this, 0, varName);
            }
            else
            {
                value = Read(redTypeInfos, 0);
            }

            SetProperty(cls, varName, value);
        }
    }

    private bool TryReadValue(string redVarName, string redTypeName, IRedCompiledPropertyData? compiledPropertyData, out IRedType? value)
    {
        try
        {
            var redTypeInfos = RedReflection.GetRedTypeInfos(redTypeName);
            if (compiledPropertyData != null && compiledPropertyData.IsCustomReadNeeded(header))
            {
                value = compiledPropertyData.CustomRead(this, 0, redVarName);
            }
            else
            {
                value = Read(redTypeInfos, 0);
            }

            return true;
        }
        catch (Exception)
        {
            value = null;
            return false;
        }
    }

    private void SetProperty(RedBaseClass cls, string varName, IRedType? value)
    {
        cls.SetProperty(varName, value);
        PostProcess(value);

        if (!CollectData)
        {
            return;
        }

        if (varName.Contains("Fact", StringComparison.InvariantCultureIgnoreCase) && !varName.Contains("Factor", StringComparison.InvariantCultureIgnoreCase))
        {
            if (value is CString str1)
            {
                DataCollection.RawStringList.Remove(str1);
                DataCollection.RawFactStrings.Add(str1);
            }

            if (value is CName { IsResolvable: true } str2)
            {
                DataCollection.RawStringList.Remove(str2.GetResolvedText()!);
                DataCollection.RawFactStrings.Add(str2.GetResolvedText()!);
            }

            if (value is CArray<CName> arr1)
            {
                foreach (var cName in arr1)
                {
                    if (cName.IsResolvable)
                    {
                        DataCollection.RawStringList.Remove(cName.GetResolvedText()!);
                        DataCollection.RawFactStrings.Add(cName.GetResolvedText()!);
                    }
                }
            }
        }

        void PostProcess(IRedType? internalValue)
        {
            if (internalValue is IRedBufferPointer buf)
            {
                buf.GetValue().ParentTypes.Add($"{cls.GetType().Name}.{varName}");
                buf.GetValue().Parent = cls;
            }

            if (internalValue is SharedDataBuffer shared)
            {
                shared.Buffer.ParentTypes.Add($"{cls.GetType().Name}.{varName}");
                shared.Buffer.Parent = cls;

                ParseBuffer(shared.Buffer);
            }

            if (internalValue is IRedArray arr)
            {
                foreach (IRedType entry in arr)
                {
                    PostProcess(entry);
                }
            }
        }
    }

    private void ParseBuffer(RedBuffer buffer)
    {
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
                pReader.Settings = Settings;
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

    public override TweakDBID ReadTweakDBID()
    {
        if (header.version == 2 || header.version == 3)
        {
            var result = Encoding.UTF8.GetString(_reader.ReadBytes(_reader.ReadInt16()));

            if (CollectData)
            {
                DataCollection.RawTweakStrings.Add(result);
            }

            return result;
        }

        if (header.version == 04)
        {
            return base.ReadTweakDBID();
        }

        throw new NotImplementedException(nameof(ReadTweakDBID));
    }

    public override IRedBitField ReadCBitField(List<RedTypeInfo> redTypeInfos, uint size)
    {
        if (redTypeInfos.Count != 1)
        {
            throw new TodoException();
        }

        var enumInfo = RedReflection.GetEnumTypeInfo(redTypeInfos[0].RedObjectType);
        var cnt = _reader.ReadByte();

        var enumString = "";
        for (var i = 0; i < cnt; i++)
        {
            var index = _reader.ReadUInt16();
            if (index == 0)
            {
                throw new TodoException();
            }

            if (!string.IsNullOrEmpty(enumString))
            {
                enumString += ", ";
            }

            enumString += enumInfo.GetCSNameFromRedName(GetStringValue(index)!);
        }

        var type = RedReflection.GetFullType(redTypeInfos);
        if (string.IsNullOrEmpty(enumString))
        {
            if (Activator.CreateInstance(type) is not IRedBitField result1)
            {
                throw new Exception();
            }
            return result1;
        }
        if (Activator.CreateInstance(type, BindingFlags.NonPublic | BindingFlags.Instance, null, new[] { Enum.Parse(redTypeInfos[0].RedObjectType, enumString) }, null) is not IRedBitField result2)
        {
            throw new Exception();
        }
        return result2;
    }

    public override IRedHandle ReadCHandle(List<RedTypeInfo> redTypeInfos, uint size)
    {
        int pointer;
        if (header.version == 2)
        {
            pointer = _reader.ReadInt16();
        }
        else if (header.version == 3 || header.version == 04)
        {
            pointer = _reader.ReadInt32();
        }
        else
        {
            throw new NotImplementedException(nameof(ReadCHandle));
        }

        var type = RedReflection.GetFullType(redTypeInfos);

        RedBaseClass? instance = null;
        if (pointer >= 0)
        {
            instance = _chunks[pointer].Instance;
            _chunks[pointer].IsUsed = true;
        }

        if (instance is DynamicBaseClass dbc)
        {
            var innerType = type.GetGenericArguments()[0];
            if (innerType == typeof(inkIWidgetController))
            {
                instance = dbc.ToDynamicWidgetController();
                _chunks[pointer] = new ChunkInfo(instance);
                _chunks[pointer].IsUsed = true;
            }
            else if (innerType == typeof(inkWidgetLogicController))
            {
                instance = dbc.ToDynamicWidgetLogicController();
                _chunks[pointer] = new ChunkInfo(instance);
                _chunks[pointer].IsUsed = true;
            }
        }

        if (Activator.CreateInstance(type, instance) is not IRedHandle result)
        {
            throw new Exception();
        }

        return result;

    }

    public override IRedWeakHandle ReadCWeakHandle(List<RedTypeInfo> redTypeInfos, uint size)
    {
        var pointer = _reader.ReadInt32();
        var type = RedReflection.GetFullType(redTypeInfos);

        RedBaseClass? instance = null;
        if (pointer >= 0)
        {
            instance = _chunks[pointer].Instance;
            _chunks[pointer].IsUsed = true;
        }

        if (Activator.CreateInstance(type, instance) is not IRedWeakHandle result)
        {
            throw new Exception();
        }

        return result;
    }

    public override IRedResourceAsyncReference ReadCResourceAsyncReference(List<RedTypeInfo> redTypeInfos, uint size)
    {
        if (redTypeInfos.Count != 2)
        {
            throw new TodoException();
        }

        var depotPath = ResourcePath.Empty;
        var flags = InternalEnums.EImportFlags.Default;

        var index = _reader.ReadInt16();
        if (index >= 0 && index < _importsList.Count)
        {
            depotPath = _importsList[index].DepotPath;
            flags = _importsList[index].Flags;
        }

        var type = RedReflection.GetFullType(redTypeInfos);
        if (Activator.CreateInstance(type, depotPath, flags) is not IRedResourceAsyncReference result)
        {
            throw new Exception();
        }

        return result;
    }

    public override IRedResourceReference ReadCResourceReference(List<RedTypeInfo> redTypeInfos, uint size)
    {
        if (redTypeInfos.Count != 2)
        {
            throw new TodoException();
        }

        var depotPath = ResourcePath.Empty;
        var flags = InternalEnums.EImportFlags.Default;

        var index = _reader.ReadInt16();
        if (index >= 0 && index < _importsList.Count)
        {
            depotPath = _importsList[index].DepotPath;
            flags = _importsList[index].Flags;
        }

        var type = RedReflection.GetFullType(redTypeInfos);
        if (Activator.CreateInstance(type, depotPath, flags) is not IRedResourceReference result)
        {
            throw new Exception();
        }

        return result;
    }

    public override NodeRef ReadNodeRef()
    {
        var result = Encoding.UTF8.GetString(_reader.ReadBytes(_reader.ReadInt16()));

        if (CollectData)
        {
            DataCollection.RawStringList.Remove(result);
            DataCollection.RawNodeRefs.Add(result);
        }

        return result;
    }

    public override LocalizationString ReadLocalizationString()
    {
        return new() { Unk1 = _reader.ReadUInt64(), Value = ReadSimpleString() };
    }

    public string ReadSimpleString()
    {
        var result = Encoding.UTF8.GetString(_reader.ReadBytes(_reader.ReadUInt16()));

        if (CollectData)
        {
            DataCollection.RawStringList.Remove(result);
            DataCollection.RawUsedStrings.Add(result);
        }

        return result;
    }

    public override CString ReadCString() => ReadSimpleString();

    public override DataBuffer ReadDataBuffer()
    {
        return base.ReadDataBuffer();
    }
}