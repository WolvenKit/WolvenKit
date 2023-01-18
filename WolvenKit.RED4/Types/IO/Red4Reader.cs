using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;
using Activator = System.Activator;

namespace WolvenKit.RED4.IO;

public partial class Red4Reader : IErrorHandler, IDisposable
{
    protected readonly BinaryReader _reader;

    protected Red4File _outputFile;
    protected List<CName> _namesList = new();
    protected List<IRedImport> importsList = new();

    protected Dictionary<int, List<IRedBaseHandle>> HandleQueue = new();
    protected Dictionary<int, List<IRedBufferPointer>> BufferQueue = new();

    private bool _disposed;

    public bool CollectData { get; set; } = false;
    public DataCollection DataCollection { get; } = new();

        
    public Red4Reader(Stream input) : this(input, Encoding.UTF8, false)
    {
    }

    public Red4Reader(Stream input, Encoding encoding) : this(input, encoding, false)
    {
    }

    public Red4Reader(Stream input, Encoding encoding, bool leaveOpen) : this(new BinaryReader(input, encoding, leaveOpen))
    {
    }

    public Red4Reader(BinaryReader reader)
    {
        _reader = reader;
    }

    public BinaryReader BaseReader => _reader;
    public Stream BaseStream => _reader.BaseStream;

    public int Position
    {
        get => (int)BaseStream.Position;
        set => BaseStream.Position = value;
    }

    public List<IRedImport> ImportsList { get => importsList; set => importsList = value; }

    protected CName GetStringValue(ushort index, bool isTypeInfo = true)
    {
        if (index >= _namesList.Count)
        {
            throw new Exception();
        }

        if (CollectData)
        {
            DataCollection.RawStringList.Remove(_namesList[index]);
            if (!isTypeInfo)
            {
                DataCollection.RawUsedStrings.Add(_namesList[index]);
            }
        }

        return _namesList[index];
    }

    protected string InternalReadLengthPrefixedString()
    {
        var ret = _reader.ReadLengthPrefixedString();

        if (CollectData)
        {
            DataCollection.RawStringList.Remove(ret);
            DataCollection.RawUsedStrings.Add(ret);
        }

        return ret;
    }

    #region RTTI Reader

    public virtual IRedType ReadName() => throw new NotImplementedException();

    #region Fundamentals

    public virtual CBool ReadCBool() => _reader.ReadByte();

    public virtual CInt8 ReadCInt8() => _reader.ReadSByte();

    public virtual CUInt8 ReadCUInt8() => _reader.ReadByte();

    public virtual CInt16 ReadCInt16() => _reader.ReadInt16();

    public virtual CUInt16 ReadCUInt16() => _reader.ReadUInt16();

    public virtual CInt32 ReadCInt32() => _reader.ReadInt32();

    public virtual CUInt32 ReadCUInt32() => _reader.ReadUInt32();

    public virtual CInt64 ReadCInt64() => _reader.ReadInt64();

    public virtual CUInt64 ReadCUInt64() => _reader.ReadUInt64();

    public virtual CFloat ReadCFloat() => _reader.ReadSingle();

    public virtual CDouble ReadCDouble() => _reader.ReadDouble();

    #endregion

    public virtual RedBaseClass ReadClass(List<RedTypeInfo> redTypeInfos, uint size)
    {
        if (redTypeInfos.Count != 1)
        {
            throw new TodoException();
        }

        var type = redTypeInfos[0].RedObjectType;
        if (!typeof(RedBaseClass).IsAssignableFrom(type))
        {
            throw new ArgumentException(nameof(type));
        }

        var instance = RedTypeManager.Create(type);
        if (instance is IDynamicClass dc)
        {
            dc.ClassName = redTypeInfos[0].RedObjectName;
        }

        ReadClass(instance, size);
        return instance;
    }

    public virtual RedBaseClass ReadClass(Type type, uint size)
    {
        if (!typeof(RedBaseClass).IsAssignableFrom(type))
        {
            throw new ArgumentException(nameof(type));
        }

        var instance = RedTypeManager.Create(type);
        ReadClass(instance, size);
        return instance;
    }

    public virtual IRedArray ReadCArray(List<RedTypeInfo> redTypeInfos, uint size, bool readAdditionalBytes = true)
    {
        if (redTypeInfos.Count < 2)
        {
            throw new TodoException();
        }

        var type = RedReflection.GetFullType(redTypeInfos);
        var result = (IRedArray)Activator.CreateInstance(type);

        var startPos = BaseStream.Position;

        var elementCount = _reader.ReadInt32();

        for (var i = 0; i < elementCount; i++)
        {
            result.Add(Read(redTypeInfos.Skip(1).ToList()));
        }

        var remaining = size - (BaseStream.Position - startPos);
        while (readAdditionalBytes && remaining > 0)
        {
            result.Add(Read(redTypeInfos.Skip(1).ToList()));

            remaining = size - (BaseStream.Position - startPos);
        }

        return result;
    }

    #region Simples

    public virtual CName ReadCName() => GetStringValue(_reader.ReadUInt16(), false);

    public virtual CString ReadCString() => InternalReadLengthPrefixedString();

    public virtual LocalizationString ReadLocalizationString() =>
        new()
        {
            Unk1 = _reader.ReadUInt64(),
            Value = InternalReadLengthPrefixedString()
        };

    public virtual TweakDBID ReadTweakDBID() => _reader.ReadUInt64();

    public virtual DataBuffer ReadDataBuffer()
    {
        var bufferSize = _reader.ReadUInt32();
        if (bufferSize == 0x80000000)
        {
            return new DataBuffer();
        }

        if (bufferSize > 0x80000000)
        {
            var pointer = (int)(bufferSize ^ 0x80000000) - 1;
            var result = new DataBuffer();

            if (!BufferQueue.ContainsKey(pointer))
            {
                BufferQueue.Add(pointer, new List<IRedBufferPointer>());
            }

            BufferQueue[pointer].Add(result);
            return result;
        }

        return new DataBuffer
        {
            Buffer = RedBuffer.CreateBuffer(0, _reader.ReadBytes((int)bufferSize))
        };
    }

    public virtual SerializationDeferredDataBuffer ReadSerializationDeferredDataBuffer(uint size)
    {
        if (size > 2)
        {
            throw new InvalidParsingException(nameof(ReadSerializationDeferredDataBuffer));
        }

        var pointer = (ushort)(_reader.ReadUInt16() - 1);
        var result = new SerializationDeferredDataBuffer();

        if (!BufferQueue.ContainsKey(pointer))
        {
            BufferQueue.Add(pointer, new List<IRedBufferPointer>());
        }

        BufferQueue[pointer].Add(result);

        return result;
    }

    public virtual SharedDataBuffer ReadSharedDataBuffer(uint size)
    {
        return new SharedDataBuffer { Buffer = RedBuffer.CreateBuffer(0, _reader.ReadBytes((int)size)) };
    }

    public virtual CVariant ReadCVariant()
    {
        var result = new CVariant();

        var redType = GetStringValue(_reader.ReadUInt16());
        var redTypeInfos = RedReflection.GetRedTypeInfos(redType);
        CheckRedTypeInfos(ref redTypeInfos);

        var size = _reader.ReadUInt32() - 4;
        if (size > 0)
        {
            result.Value = Read(redTypeInfos, size);
        }

        return result;
    }

    public virtual CDateTime ReadCDateTime() => _reader.ReadUInt64();

    public virtual CGuid ReadCGuid() => _reader.ReadBytes(16);

    public virtual CRUID ReadCRUID() => _reader.ReadUInt64();

    public virtual IRedType ReadCRUIDRef() => throw new NotImplementedException();

    public virtual EditorObjectID ReadEditorObjectID() => (EditorObjectID)ThrowNotImplemented();

    public virtual gamedataLocKeyWrapper ReadGamedataLocKeyWrapper() => _reader.ReadUInt64();

    public virtual MessageResourcePath ReadMessageResourcePath() => (MessageResourcePath)ThrowNotImplemented();

    public virtual NodeRef ReadNodeRef()
    {
        var ret = _reader.ReadLengthPrefixedString();

        if (CollectData)
        {
            DataCollection.RawStringList.Remove(ret);
            DataCollection.RawNodeRefs.Add(ret);
        }

        return ret;
    }

    public virtual IRedType ReadRuntimeEntityRef() => throw new NotImplementedException();

    #endregion Simples

    public virtual IRedEnum ReadCEnum(List<RedTypeInfo> redTypeInfos, uint size)
    {
        if (redTypeInfos.Count != 1)
        {
            throw new TodoException();
        }

        var value = GetStringValue(_reader.ReadUInt16());

        var enumInfo = RedReflection.GetEnumTypeInfo(redTypeInfos[0].RedObjectType);
        var enumString = enumInfo.GetCSNameFromRedName(value);

        object enumValue = null;
        if (enumString != null)
        {
            enumValue = Enum.Parse(redTypeInfos[0].RedObjectType, enumString);
        }
        if (enumString == null)
        {
            var args = new InvalidEnumValueEventArgs(redTypeInfos[0].RedObjectType, value);
            if (!HandleParsingError(args))
            {
                throw new Exception($"CEnum \"{redTypeInfos[0].RedObjectType.Name}.{value}\" could not be found!");
            }

            enumValue = args.Value;
        }

        var type = RedReflection.GetFullType(redTypeInfos);

        return (IRedEnum)Activator.CreateInstance(type, BindingFlags.NonPublic | BindingFlags.Instance, null, new[] { enumValue }, null);
    }

    public virtual IRedStatic ReadCStaticArray(List<RedTypeInfo> redTypeInfos, uint size)
    {
        if (redTypeInfos.Count < 2)
        {
            throw new TodoException();
        }

        var type = RedReflection.GetFullType(redTypeInfos);
        var result = (IRedStatic)Activator.CreateInstance(type, redTypeInfos[0].ArrayCount);

        var elementCount = _reader.ReadInt32();
        if (elementCount > redTypeInfos[0].ArrayCount)
        {
            throw new TodoException();
        }

        for (var i = 0; i < elementCount; i++)
        {
            result[i] = Read(redTypeInfos.Skip(1).ToList());
        }

        return result;
    }

    public virtual IRedArrayFixedSize ReadCArrayFixedSize(List<RedTypeInfo> redTypeInfos, uint size)
    {
        if (redTypeInfos.Count < 2)
        {
            throw new TodoException();
        }

        var type = RedReflection.GetFullType(redTypeInfos);
        var result = (IRedArrayFixedSize)Activator.CreateInstance(type, redTypeInfos[0].ArrayCount);

        var elementCount = _reader.ReadInt32();
        if (elementCount > redTypeInfos[0].ArrayCount)
        {
            throw new TodoException();
        }

        for (var i = 0; i < elementCount; i++)
        {
            result[i] = Read(redTypeInfos.Skip(1).ToList());
        }

        return result;
    }

    public virtual IRedType ReadPointer(List<RedTypeInfo> redTypeInfos, uint size) => throw new NotImplementedException();

    public virtual IRedHandle ReadCHandle(List<RedTypeInfo> redTypeInfos, uint size)
    {
        var type = RedReflection.GetFullType(redTypeInfos);
        var result = (IRedHandle)Activator.CreateInstance(type);

        var pointer = _reader.ReadInt32() - 1;
        if (!HandleQueue.ContainsKey(pointer))
        {
            HandleQueue.Add(pointer, new List<IRedBaseHandle>());
        }

        HandleQueue[pointer].Add(result);

        return result;
    }

    public virtual IRedHandle ReadCHandle<T>() where T : RedBaseClass
    {
        var result = new CHandle<T>();

        var pointer = _reader.ReadInt32() - 1;
        if (!HandleQueue.ContainsKey(pointer))
        {
            HandleQueue.Add(pointer, new List<IRedBaseHandle>());
        }

        HandleQueue[pointer].Add(result);

        return result;
    }

    public virtual IRedWeakHandle ReadCWeakHandle(List<RedTypeInfo> redTypeInfos, uint size)
    {
        var type = RedReflection.GetFullType(redTypeInfos);
        var result = (IRedWeakHandle)Activator.CreateInstance(type);

        var pointer = _reader.ReadInt32() - 1;
        if (!HandleQueue.ContainsKey(pointer))
        {
            HandleQueue.Add(pointer, new List<IRedBaseHandle>());
        }

        HandleQueue[pointer].Add(result);

        return result;
    }

    public virtual IRedResourceReference ReadCResourceReference(List<RedTypeInfo> redTypeInfos, uint size)
    {
        if (redTypeInfos.Count != 2)
        {
            throw new TodoException();
        }

        var depotPath = (CName)0;
        var flags = InternalEnums.EImportFlags.Default;

        var index = _reader.ReadUInt16();
        if (index > 0 && index <= importsList.Count)
        {
            depotPath = importsList[index - 1].DepotPath;
            flags = importsList[index - 1].Flags;
        }

        var type = RedReflection.GetFullType(redTypeInfos);
        var result = (IRedResourceReference)Activator.CreateInstance(type, depotPath, flags);

        return result;
    }

    public virtual IRedResourceAsyncReference ReadCResourceAsyncReference(List<RedTypeInfo> redTypeInfos, uint size)
    {
        if (redTypeInfos.Count != 2)
        {
            throw new TodoException();
        }

        var depotPath = (CName)0;
        var flags = InternalEnums.EImportFlags.Default;

        var index = _reader.ReadUInt16();
        if (index > 0 && index <= importsList.Count)
        {
            depotPath = importsList[index - 1].DepotPath;
            flags = importsList[index - 1].Flags;
        }

        var type = RedReflection.GetFullType(redTypeInfos);
        var result = (IRedResourceAsyncReference)Activator.CreateInstance(type, depotPath, flags);

        return result;
    }

    public virtual IRedBitField ReadCBitField(List<RedTypeInfo> redTypeInfos, uint size)
    {
        if (redTypeInfos.Count != 1)
        {
            throw new TodoException();
        }

        var enumInfo = RedReflection.GetEnumTypeInfo(redTypeInfos[0].RedObjectType);

        var enumString = "";
        while (true)
        {
            var index = _reader.ReadUInt16();
            if (index == 0)
            {
                break;
            }

            if (!string.IsNullOrEmpty(enumString))
            {
                enumString += ", ";
            }

            enumString += enumInfo.GetCSNameFromRedName(GetStringValue(index));
        }

        var type = RedReflection.GetFullType(redTypeInfos);
        if (string.IsNullOrEmpty(enumString))
        {
            return (IRedBitField)Activator.CreateInstance(type);
        }
        return (IRedBitField)Activator.CreateInstance(type, BindingFlags.NonPublic | BindingFlags.Instance, null, new[] { Enum.Parse(redTypeInfos[0].RedObjectType, enumString) }, null);
    }

    public virtual IRedLegacySingleChannelCurve ReadCLegacySingleChannelCurve(List<RedTypeInfo> redTypeInfos, uint size)
    {
        if (redTypeInfos.Count != 2)
        {
            throw new TodoException();
        }

        var type = RedReflection.GetFullType(redTypeInfos);
        var result = (IRedLegacySingleChannelCurve)Activator.CreateInstance(type);

        var elementCount = _reader.ReadUInt32();
        for (var i = 0; i < elementCount; i++)
        {
            var point = _reader.ReadSingle();

            IRedType element;
            if (redTypeInfos[1].BaseRedType is BaseRedType.Class)
            {
                element = ReadFixedClassNew(redTypeInfos[1], 0);
            }
            else
            {
                element = Read(new List<RedTypeInfo> { redTypeInfos[1] });
            }

            var constructedType = typeof(CurvePoint<>).MakeGenericType(element.GetType());
            var curvePoint = (IRedCurvePoint)Activator.CreateInstance(constructedType);
            curvePoint.SetPoint(point);
            curvePoint.SetValue(element);

            result.Add(curvePoint);
        }

        result.InterpolationType = (Enums.EInterpolationType)_reader.ReadByte();
        result.LinkType = (Enums.ESegmentsLinkType)_reader.ReadByte();

        return result;
    }

    public virtual IRedType ReadScriptReference(List<RedTypeInfo> redTypeInfos, uint size) => throw new NotImplementedException();

    public virtual IRedType ReadFixedArray(List<RedTypeInfo> redTypeInfos, uint size) => throw new NotImplementedException();

    #region Special

    public virtual IRedMultiChannelCurve ReadMultiChannelCurve(List<RedTypeInfo> redTypeInfos, uint size)
    {
        var type = RedReflection.GetFullType(redTypeInfos);
        var result = (IRedMultiChannelCurve)Activator.CreateInstance(type);

        result.NumChannels = _reader.ReadUInt32();
        result.InterpolationType = (Enums.EInterpolationType)_reader.ReadByte();
        result.LinkType = (Enums.EChannelLinkType)_reader.ReadByte();
        result.Alignment = _reader.ReadUInt32();

        var innerSize = _reader.ReadInt32();
        result.Data = _reader.ReadBytes(innerSize);

        return result;
    }

    #endregion Special

    #endregion RTTI Reader

    #region Helper

    protected internal void CheckRedTypeInfos(ref List<RedTypeInfo> redTypeInfos)
    {
        for (int i = 0; i < redTypeInfos.Count; i++)
        {
            if (redTypeInfos[i] is SpecialRedTypeInfo { SpecialRedType: SpecialRedType.Mixed } specialRedTypeInfo)
            {
                var args = new UnknownTypeEventArgs(specialRedTypeInfo.RedName);
                if (!HandleParsingError(args))
                {
                    throw new Exception($"Type \"{specialRedTypeInfo.RedName}\" is not known!");
                }
                redTypeInfos[i] = args.Result;
            }
        }
    }

    protected IRedType ThrowNotImplemented([CallerMemberName] string callerMemberName = "")
    {
        throw new NotImplementedException($"{nameof(Red4Reader)}.{callerMemberName}");
    }

    protected IRedType ThrowNotSupported([CallerMemberName] string callerMemberName = "")
    {
        throw new NotSupportedException($"{nameof(Red4Reader)}.{callerMemberName}");
    }

    public event ParsingErrorEventHandler ParsingError;

    protected virtual bool HandleParsingError(ParsingErrorEventArgs e) => ParsingError != null && ParsingError.Invoke(e);

    #endregion

    public virtual void ReadClass(RedBaseClass cls, uint size)
    {
        ThrowNotImplemented();
    }

    public virtual RedBaseClass ReadFixedClass(Type type, uint size)
    {
        var instance = RedTypeManager.Create(type);
        var typeInfo = RedReflection.GetTypeInfo(instance);

        foreach (var propertyInfo in typeInfo.GetWritableProperties())
        {
            var redTypeInfos = RedReflection.GetRedTypeInfos(propertyInfo.Type);

            var value = Read(redTypeInfos);
            instance.SetProperty(propertyInfo.RedName, value);
        }

        return instance;
    }

    public virtual RedBaseClass ReadFixedClassNew(RedTypeInfo redTypeInfo, uint size)
    {
        var instance = RedTypeManager.Create(redTypeInfo.RedObjectType);
        var typeInfo = RedReflection.GetTypeInfo(instance);

        foreach (var propertyInfo in typeInfo.GetWritableProperties())
        {
            var redTypeInfos = RedReflection.GetRedTypeInfos(propertyInfo.Type);
            instance.SetProperty(propertyInfo.RedName, Read(redTypeInfos));
        }

        return instance;
    }

    public virtual IRedType Read(List<RedTypeInfo> redTypeInfos, uint size = 0)
    {
        var currentType = redTypeInfos[0];

        switch (currentType.BaseRedType)
        {
            case BaseRedType.Name:
                return ReadName();
            case BaseRedType.Fundamental:
                switch (((FundamentalRedTypeInfo)currentType).FundamentalRedType)
                {
                    case FundamentalRedType.Bool:
                        return ReadCBool();
                    case FundamentalRedType.Int8:
                        return ReadCInt8();
                    case FundamentalRedType.Uint8:
                        return ReadCUInt8();
                    case FundamentalRedType.Int16:
                        return ReadCInt16();
                    case FundamentalRedType.Uint16:
                        return ReadCUInt16();
                    case FundamentalRedType.Int32:
                        return ReadCInt32();
                    case FundamentalRedType.Uint32:
                        return ReadCUInt32();
                    case FundamentalRedType.Int64:
                        return ReadCInt64();
                    case FundamentalRedType.Uint64:
                        return ReadCUInt64();
                    case FundamentalRedType.Float:
                        return ReadCFloat();
                    case FundamentalRedType.Double:
                        return ReadCDouble();
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            case BaseRedType.Class:
                return ReadClass(redTypeInfos, size);
            case BaseRedType.Array:
                return ReadCArray(redTypeInfos, size);
            case BaseRedType.Simple:
                switch (((SimpleRedTypeInfo)currentType).SimpleRedType)
                {
                    case SimpleRedType.CName:
                        return ReadCName();
                    case SimpleRedType.String:
                        return ReadCString();
                    case SimpleRedType.LocalizationString:
                        return ReadLocalizationString();
                    case SimpleRedType.TweakDBID:
                        return ReadTweakDBID();
                    case SimpleRedType.DataBuffer:
                        return ReadDataBuffer();
                    case SimpleRedType.serializationDeferredDataBuffer:
                        return ReadSerializationDeferredDataBuffer(size);
                    case SimpleRedType.SharedDataBuffer:
                        return ReadSharedDataBuffer(size);
                    case SimpleRedType.Variant:
                        return ReadCVariant();
                    case SimpleRedType.CDateTime:
                        return ReadCDateTime();
                    case SimpleRedType.CGUID:
                        return ReadCGuid();
                    case SimpleRedType.CRUID:
                        return ReadCRUID();
                    case SimpleRedType.CRUIDRef:
                        return ReadCRUIDRef();
                    case SimpleRedType.EditorObjectID:
                        return ReadEditorObjectID();
                    case SimpleRedType.gamedataLocKeyWrapper:
                        return ReadGamedataLocKeyWrapper();
                    case SimpleRedType.MessageResourcePath:
                        return ReadMessageResourcePath();
                    case SimpleRedType.NodeRef:
                        return ReadNodeRef();
                    case SimpleRedType.RuntimeEntityRef:
                        return ReadRuntimeEntityRef();
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            case BaseRedType.Enum:
                return ReadCEnum(redTypeInfos, size);
            case BaseRedType.StaticArray:
                return ReadCStaticArray(redTypeInfos, size);
            case BaseRedType.NativeArray:
                return ReadCArrayFixedSize(redTypeInfos, size);
            case BaseRedType.Pointer:
                return ReadPointer(redTypeInfos, size);
            case BaseRedType.Handle:
                return ReadCHandle(redTypeInfos, size);
            case BaseRedType.WeakHandle:
                return ReadCWeakHandle(redTypeInfos, size);
            case BaseRedType.ResourceReference:
                return ReadCResourceReference(redTypeInfos, size);
            case BaseRedType.ResourceAsyncReference:
                return ReadCResourceAsyncReference(redTypeInfos, size);
            case BaseRedType.BitField:
                return ReadCBitField(redTypeInfos, size);
            case BaseRedType.LegacySingleChannelCurve:
                return ReadCLegacySingleChannelCurve(redTypeInfos, size);
            case BaseRedType.ScriptReference:
                return ReadScriptReference(redTypeInfos, size);
            case BaseRedType.FixedArray:
                return ReadFixedArray(redTypeInfos, size);

            case BaseRedType.Special:
            {
                switch (((SpecialRedTypeInfo)redTypeInfos[0]).SpecialRedType)
                {
                    case SpecialRedType.MultiChannelCurve:
                        return ReadMultiChannelCurve(redTypeInfos, size);
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    #region IDisposable

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _reader.Close();
            }
            _disposed = true;
        }
    }

    public void Dispose() => Dispose(true);

    public virtual void Close() => Dispose(true);

    #endregion IDisposable
}