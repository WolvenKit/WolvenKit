using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.IO;

public class Red4Writer : IDisposable
{
    protected readonly BinaryWriter _writer;

    public ICacheList<CName> StringCacheList = new CacheList<CName>(new CNameComparer());
    public ICacheList<ImportEntry> ImportCacheList = new CacheList<ImportEntry>(new ImportComparer());
    public ICacheList<RedBuffer> BufferCacheList = new CacheList<RedBuffer>(new RedBufferComparer());

    public int CurrentChunk { get; private set; }
    public bool IsRoot = true;

    public readonly Dictionary<long, string> CNameRef = new();
    public readonly Dictionary<long, ImportEntry> ImportRef = new();
    public readonly Dictionary<long, RedBuffer> BufferRef = new();

    protected readonly Dictionary<int, StringInfo> _chunkStringList = new();
    protected readonly Dictionary<int, ImportInfo> _chunkImportList = new();
    protected readonly Dictionary<int, BufferInfo> _chunkBufferList = new();

    protected readonly List<(int, Guid, int, int, int)> _targetList = new();
    protected readonly Dictionary<int, List<Guid>> ChildChunks = new();

    public readonly Dictionary<Guid, int> _chunkGuidToId = new();

    private Encoding _encoding;
    private bool _disposed;

    public Red4Writer(Stream output) : this(output, Encoding.UTF8, false)
    {
    }

    public Red4Writer(Stream output, Encoding encoding) : this(output, encoding, false)
    {
    }

    public Red4Writer(Stream output, Encoding encoding, bool leaveOpen)
    {
        StringCacheList.Add(CName.Empty);

        _writer = new BinaryWriter(output, encoding, leaveOpen);
        _encoding = encoding;
    }

    public Stream BaseStream => _writer.BaseStream;
    public BinaryWriter BaseWriter => _writer;

    public int Position => (int)_writer.BaseStream.Position;

    protected Dictionary<RedBaseClass, ChunkInfo> _chunkInfos = new();

    #region Support

    public void WriteVLQ(int value) => _writer.WriteVLQInt32(value);

    #endregion

    public List<(int, Guid, int, int, int)> GetTargets(int chunkIndex)
    {
        return _targetList.Where(t => t.Item1 == chunkIndex).ToList();
    }

    public ushort GetStringIndex(string value, bool add = true)
    {
        var index = StringCacheList.IndexOf(value);

        if (add && index == ushort.MaxValue)
        {
            index = StringCacheList.Add(value);
        }

        if (index == ushort.MaxValue)
        {
            throw new Exception();
        }

        return index;
    }

    public ushort GetImportIndex(ImportEntry value, bool add = true)
    {
        var index = ImportCacheList.IndexOf(value);
        if (add && index == ushort.MaxValue)
        {
            index = ImportCacheList.Add(value);
        }

        if (index == ushort.MaxValue)
        {
            throw new Exception();
        }

        return (ushort)(index + 1);
    }

    public ushort GetRedBufferIndex(RedBuffer value, bool add = true)
    {
        var index = BufferCacheList.IndexOf(value);
        if (add && index == ushort.MaxValue)
        {
            index = BufferCacheList.Add(value);
        }

        if (index == ushort.MaxValue)
        {
            throw new Exception();
        }

        return (ushort)(index + 1);
    }

    public void StartChunk(RedBaseClass chunk)
    {
        CurrentChunk = _chunkInfos[chunk].Id;
        ChildChunks[_chunkInfos[chunk].Id] = new();

        if (_chunkInfos[chunk].Guid != Guid.Empty)
        {
            _chunkGuidToId.Add(_chunkInfos[chunk].Guid, _chunkInfos[chunk].Id);
        }

        if (_chunkInfos[chunk].Id == 0)
        {
            return;
        }

        _chunkStringList.Add(_chunkInfos[chunk].Id - 1, new() {List = StringCacheList.ToList() });
        StringCacheList.Clear();

        _chunkImportList.Add(_chunkInfos[chunk].Id - 1, new (){List = ImportCacheList.ToList()});
        ImportCacheList.Clear();

        _chunkBufferList.Add(_chunkInfos[chunk].Id - 1, new() { List = BufferCacheList.ToList() });
        BufferCacheList.Clear();
    }

    public void GenerateStringDictionary()
    {
        _chunkStringList.Add(CurrentChunk, new() { List = StringCacheList.ToList() });
        StringCacheList.Clear();

        _chunkImportList.Add(CurrentChunk, new (){List = ImportCacheList.ToList()});
        ImportCacheList.Clear();

        _chunkBufferList.Add(CurrentChunk, new() { List = BufferCacheList.ToList() });
        BufferCacheList.Clear();

        var targetList = new List<(int, Guid, int, int, int)>(_targetList);

        var length = _chunkStringList.Count;
        for (int i = 0; i < length; i++)
        {
            GenerateFor(i);
        }

        void GenerateFor(int chunk)
        {
            if (!_chunkStringList.ContainsKey(chunk))
            {
                return;
            }

            var stringList = _chunkStringList[chunk];
            var importList = _chunkImportList[chunk];
            var bufferList = _chunkBufferList[chunk];

            var list = targetList.Where(x => x.Item1 == chunk);
            foreach (var tuple in list)
            {
                StringCacheList.AddRange(stringList.List.GetRange(stringList.LastIndex, tuple.Item3 - stringList.LastIndex));
                stringList.LastIndex = tuple.Item3;

                ImportCacheList.AddRange(importList.List.GetRange(importList.LastIndex, tuple.Item4 - importList.LastIndex));
                importList.LastIndex = tuple.Item4;

                BufferCacheList.AddRange(bufferList.List.GetRange(bufferList.LastIndex, tuple.Item5 - bufferList.LastIndex));
                bufferList.LastIndex = tuple.Item5;

                if (_chunkGuidToId[tuple.Item2] > chunk)
                {
                    GenerateFor(_chunkGuidToId[tuple.Item2]);
                }
            }
            StringCacheList.AddRange(stringList.List.GetRange(stringList.LastIndex, stringList.List.Count - stringList.LastIndex));
            ImportCacheList.AddRange(importList.List.GetRange(importList.LastIndex, importList.List.Count - importList.LastIndex));
            BufferCacheList.AddRange(bufferList.List.GetRange(bufferList.LastIndex, bufferList.List.Count - bufferList.LastIndex));

            _chunkStringList.Remove(chunk);
            _chunkImportList.Remove(chunk);
            _chunkBufferList.Remove(chunk);
        }
    }

    protected class StringInfo
    {
        public List<CName> List { get; set; }
        public int LastIndex { get; set; }
    }

    protected class ImportInfo
    {
        public List<ImportEntry> List { get; set; }
        public int LastIndex { get; set; }
    }

    protected class BufferInfo
    {
        public List<RedBuffer> List { get; set; }
        public int LastIndex { get; set; }
    }

    #region Fundamentals

    public virtual void Write(CBool val) => _writer.Write((byte)val);
    public virtual void Write(CDouble val) => _writer.Write(val);
    public virtual void Write(CFloat val) => _writer.Write(val);
    public virtual void Write(CInt8 val) => _writer.Write(val);
    public virtual void Write(CUInt8 val) => _writer.Write(val);
    public virtual void Write(CInt16 val) => _writer.Write(val);
    public virtual void Write(CUInt16 val) => _writer.Write(val);
    public virtual void Write(CInt32 val) => _writer.Write(val);
    public virtual void Write(CUInt32 val) => _writer.Write(val);
    public virtual void Write(CInt64 val) => _writer.Write(val);
    public virtual void Write(CUInt64 val) => _writer.Write(val);

    #endregion

    #region Simple

    public virtual void Write(CDateTime val) => _writer.Write(val);
    public virtual void Write(CGuid val) => _writer.Write(val);

    public virtual void Write(CName val)
    {
        NotResolvableException.ThrowIfNotResolvable(val);

        CNameRef.Add(_writer.BaseStream.Position, val!);
        _writer.Write(GetStringIndex(val!));
    }

    public virtual void Write(CRUID val) => _writer.Write(val);
    public virtual void Write(CString val) => _writer.WriteLengthPrefixedString(val);

    public virtual void Write(CVariant val)
    {
        ArgumentNullException.ThrowIfNull(val.Value);

        var typeName = RedReflection.GetRedTypeFromCSType(val.Value.GetType(), Flags.Empty);

        CNameRef.Add(_writer.BaseStream.Position, typeName);
        _writer.Write(GetStringIndex(typeName));

        var pos = _writer.BaseStream.Position;
        _writer.Write(0);
        Write(val.Value);
        var bytesWritten = (uint)(_writer.BaseStream.Position - pos);

        _writer.BaseStream.Position -= bytesWritten;
        _writer.Write(bytesWritten);
        _writer.BaseStream.Position += bytesWritten - 4;
    }

    public List<RedBuffer> BufferStack = new();

    protected virtual void GenerateBufferBytes(RedBuffer buffer)
    {

    }

    public virtual void Write(DataBuffer val)
    {
        GenerateBufferBytes(val.Buffer);

        if (val.Buffer.IsEmpty)
        {
            _writer.Write(0x80000000);
        }
        else if (IsRoot)
        {
            BufferRef.Add(_writer.BaseStream.Position, val.Buffer);
            _writer.Write((GetRedBufferIndex(val.Buffer) | 0x80000000) + 1);
        }
        else
        {
            _writer.Write(val.Buffer.MemSize);
            _writer.Write(val.Buffer.GetBytes());
        }
    }

    public virtual void Write(EditorObjectID val) => ThrowNotImplemented();

    public virtual void Write(LocalizationString val)
    {
        _writer.Write(val.Unk1);
        _writer.WriteLengthPrefixedString(val.Value);
    }

    public virtual void Write(MessageResourcePath val) => ThrowNotImplemented();
    public virtual void Write(NodeRef val) => _writer.WriteLengthPrefixedString(val);
    public virtual void Write(SerializationDeferredDataBuffer val)
    {
        GenerateBufferBytes(val.Buffer);

        BufferRef.Add(_writer.BaseStream.Position, val.Buffer);
        _writer.Write((ushort)(GetRedBufferIndex(val.Buffer) + 1));
    }

    public virtual void Write(SharedDataBuffer val)
    {
        GenerateBufferBytes(val.Buffer);

        _writer.Write(val.Buffer.GetBytes().Length);
        _writer.Write(val.Buffer.GetBytes());
    }

    public virtual void Write(TweakDBID val) => _writer.Write((ulong)val);
    public virtual void Write(gamedataLocKeyWrapper val) => _writer.Write((ulong)val);

    #endregion Simple

    // TODO: Check for generic arguments
    private MethodInfo? GetMethod(string name, int genericParameterCount, Type[] types)
    {
        var methods = typeof(Red4Writer).GetMethods();
        foreach (var methodInfo in methods)
        {
            if (methodInfo.Name != name)
            {
                continue;
            }

            if (genericParameterCount == 0 && methodInfo.IsGenericMethod)
            {
                continue;
            }

            if (genericParameterCount > 0 && !methodInfo.IsGenericMethod)
            {
                continue;
            }

            var methodParameters = methodInfo.GetParameters();
            if (methodParameters.Length != types.Length)
            {
                continue;
            }

            var match = true;
            for (int i = 0; i < methodParameters.Length; i++)
            {
                var methodParameterType = methodParameters[i].ParameterType;
                var parameterType = types[i];

                if (methodParameterType.IsGenericType)
                {
                    if (!parameterType.IsGenericType)
                    {
                        match = false;
                        break;
                    }

                    if (methodParameterType.GetGenericTypeDefinition() != parameterType.GetGenericTypeDefinition())
                    {
                        match = false;
                        break;
                    }
                }
                else
                {
                    if (parameterType.IsGenericType)
                    {
                        match = false;
                        break;
                    }

                    if (methodParameterType != parameterType)
                    {
                        match = false;
                        break;
                    }
                }
            }

            if (match)
            {
                return methodInfo;
            }
        }

        return null;
    }

    #region General

    public virtual void Write(IRedArray instance)
    {
        var genericType = instance.GetType().GetGenericTypeDefinition();
        var innerType = instance.GetType().GetGenericArguments()[0];

        var method = GetMethod("Write", 1, new[] { genericType });
        ArgumentNullException.ThrowIfNull(method);
        var generic = method.MakeGenericMethod(innerType);

        generic.Invoke(this, new object[] { instance });
    }

    public virtual void Write<T>(CArray<T> instance) where T : IRedType
    {
        _writer.Write((uint)instance.Count);
        foreach (var element in instance)
        {
            Write(element);
        }
    }

    public virtual void Write(IRedArrayFixedSize instance)
    {
        var genericType = instance.GetType().GetGenericTypeDefinition();
        var innerType = instance.GetType().GetGenericArguments()[0];

        var method = GetMethod("Write", 1, new[] { genericType });
        ArgumentNullException.ThrowIfNull(method);
        var generic = method.MakeGenericMethod(innerType);

        generic.Invoke(this, new object[] { instance });
    }

    public virtual void Write<T>(CArrayFixedSize<T> instance) where T : IRedType
    {
        var count = instance.Count(e => e != null);

        _writer.Write((uint)count);
        foreach (var element in instance)
        {
            if (element == null)
            {
                continue;
            }

            Write(element);
        }
    }

    public virtual void Write(IRedStatic instance)
    {
        var genericType = instance.GetType().GetGenericTypeDefinition();
        var innerType = instance.GetType().GetGenericArguments()[0];

        var method = GetMethod("Write", 1, new[] { genericType });
        ArgumentNullException.ThrowIfNull(method);
        var generic = method.MakeGenericMethod(innerType);

        generic.Invoke(this, new object[] { instance });
    }

    public virtual void Write<T>(CStatic<T> instance) where T : IRedType
    {
        var count = instance.Count(e => e != null);

        _writer.Write((uint)count);
        foreach (var element in instance)
        {
            if (element == null)
            {
                continue;
            }

            Write(element);
        }
    }

    public virtual void Write(IRedBitField instance)
    {
        var enumString = instance.ToBitFieldString();
        if (enumString == "0")
        {
            _writer.Write((ushort)0);
            return;
        }

        var flags = enumString.Split(',');
        for (int i = 0; i < flags.Length; i++)
        {
            var tFlag = flags[i].Trim();
            CNameRef.Add(_writer.BaseStream.Position, tFlag);
            _writer.Write(GetStringIndex(tFlag));
        }
        _writer.Write((ushort)0);
    }

    public virtual void Write(IRedEnum instance)
    {
        var typeInfo = RedReflection.GetEnumTypeInfo(instance.GetInnerType());
        var valueName = typeInfo.GetRedNameFromCSName(instance.ToEnumString());

        CNameRef.Add(_writer.BaseStream.Position, valueName);
        _writer.Write(GetStringIndex(valueName));
    }

    public List<RedBaseClass> ChunkQueue = new();
    public Dictionary<Guid,List<(long, int, Type)>> ChunkReferences = new();

    protected void InternalHandleWriter(RedBaseClass? classRef, int pointerOffset)
    {
        InternalHandleWriter(classRef, pointerOffset, typeof(int));
    }

    protected void InternalHandleWriter(RedBaseClass? classRef, int pointerOffset, Type indexType)
    {
        if (classRef == null)
        {
            if (indexType == typeof(int))
            {
                _writer.Write(0);
            }
            else if (indexType == typeof(short))
            {
                _writer.Write((short)0);
            }
            else
            {
                throw new NotSupportedException(nameof(InternalHandleWriter));
            }
            return;
        }

        if (!_chunkInfos.ContainsKey(classRef))
        {
            _chunkInfos.Add(classRef, new ChunkInfo());
        }

        var chunkIndex = _chunkInfos[classRef].Id;
        if (chunkIndex != -1)
        {
            if (indexType == typeof(int))
            {
                _writer.Write(chunkIndex + pointerOffset);
            }
            else if (indexType == typeof(short))
            {
                _writer.Write((short)(chunkIndex + pointerOffset));
            }
            else
            {
                throw new NotSupportedException(nameof(InternalHandleWriter));
            }
                
            return;
        }

        if (_chunkInfos[classRef].Guid == Guid.Empty)
        {
            _chunkInfos[classRef].Guid = Guid.NewGuid();

            ChunkReferences.Add(_chunkInfos[classRef].Guid, new List<(long, int, Type)>());
        }

        ChunkQueue.Add(classRef);

        _targetList.Add((CurrentChunk, _chunkInfos[classRef].Guid, StringCacheList.Count, ImportCacheList.Count, BufferCacheList.Count));
        ChildChunks[CurrentChunk].Add(_chunkInfos[classRef].Guid);

        ChunkReferences[_chunkInfos[classRef].Guid].Add((BaseStream.Position, pointerOffset, indexType));
        if (indexType == typeof(int))
        {
            _writer.Write(0);
        }
        else if (indexType == typeof(short))
        {
            _writer.Write((short)0);
        }
        else
        {
            throw new NotSupportedException(nameof(InternalHandleWriter));
        }
    }

    public virtual void Write(IRedHandle instance) => InternalHandleWriter(instance.GetValue(), 1);

    public virtual void Write(IRedWeakHandle instance) => InternalHandleWriter(instance.GetValue(), 1);

    // TODO
    public virtual void Write(IRedLegacySingleChannelCurve instance)
    {
        _writer.Write((uint)instance.Count);
        foreach (var curvePoint in instance)
        {
            _writer.Write(curvePoint.GetPoint());

            var value = curvePoint.GetValue();
            if (value is RedBaseClass cls)
            {
                WriteFixedClass(cls);
            }
            else
            {
                Write(curvePoint.GetValue());
            }
        }
        _writer.Write((byte)instance.InterpolationType);
        _writer.Write((byte)instance.LinkType);
    }

    public virtual void Write(IRedMultiChannelCurve instance)
    {
        var genericType = instance.GetType().GetGenericTypeDefinition();
        var innerType = instance.GetType().GetGenericArguments()[0];

        var method = GetMethod("Write", 1, new[] { genericType });
        ArgumentNullException.ThrowIfNull(method);
        var generic = method.MakeGenericMethod(innerType);

        generic.Invoke(this, new object[] { instance });
    }

    public virtual void Write<T>(MultiChannelCurve<T> instance) where T : IRedType
    {
        _writer.Write(instance.NumChannels);
        _writer.Write((byte)instance.InterpolationType);
        _writer.Write((byte)instance.LinkType);
        _writer.Write(instance.Alignment);

        _writer.Write((uint)instance.Data.Length);
        _writer.Write(instance.Data);
    }

    public virtual void Write(IRedResourceReference instance)
    {
        if (instance.DepotPath == ResourcePath.Empty)
        {
            _writer.Write((ushort)0);
            return;
        }

        NotResolvableException.ThrowIfNotResolvable(instance.DepotPath);

        var val = new ImportEntry(CName.Empty, instance.DepotPath, (ushort)instance.Flags);

        ImportRef.Add(_writer.BaseStream.Position, val);
        _writer.Write(GetImportIndex(val));
    }

    public virtual void Write(IRedResourceAsyncReference instance)
    {
        if (instance.DepotPath == ResourcePath.Empty)
        {
            _writer.Write((ushort)0);
            return;
        }

        NotResolvableException.ThrowIfNotResolvable(instance.DepotPath);

        var val = new ImportEntry(CName.Empty, instance.DepotPath, (ushort)instance.Flags);

        ImportRef.Add(_writer.BaseStream.Position, val);
        _writer.Write(GetImportIndex(val));
    }

    #endregion General

    public virtual void Write(RedBaseClass instance) => ThrowNotImplemented();

    public virtual void WriteFixedClass(RedBaseClass instance)
    {
        var typeInfo = RedReflection.GetTypeInfo(instance);
        foreach (var propertyInfo in typeInfo.GetWritableProperties())
        {
            ArgumentNullException.ThrowIfNull(propertyInfo.RedName);

            var value = instance.GetProperty(propertyInfo.RedName);
            Write(value);
        }
    }

    #region Helper

    protected IRedPrimitive ThrowNotImplemented([CallerMemberName] string callerMemberName = "")
    {
        throw new NotImplementedException($"{nameof(Red4Writer)}.{callerMemberName}");
    }

    protected IRedPrimitive ThrowNotSupported([CallerMemberName] string callerMemberName = "")
    {
        throw new NotSupportedException($"{nameof(Red4Writer)}.{callerMemberName}");
    }

    #endregion

    public virtual void WriteClass(RedBaseClass instance)
    {
        ThrowNotImplemented();
    }

    public virtual void Write(IRedType? instance, [CallerMemberName] string callerMemberName = "")
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (callerMemberName == nameof(WriteGeneric))
        {
            throw new Exception();
        }

        if (instance is RedBaseClass cls)
        {
            WriteClass(cls);
            return;
        }

        if (instance is IRedGenericType genInstance)
        {
            WriteGeneric(genInstance);
            return;
        }

        var type = instance.GetType();
        switch (type)
        {
            case { } when type == typeof(CBool):
                Write((CBool)instance);
                return;

            case { } when type == typeof(CDouble):
                Write((CDouble)instance);
                return;

            case { } when type == typeof(CFloat):
                Write((CFloat)instance);
                return;

            case { } when type == typeof(CInt16):
                Write((CInt16)instance);
                return;

            case { } when type == typeof(CInt32):
                Write((CInt32)instance);
                return;

            case { } when type == typeof(CInt64):
                Write((CInt64)instance);
                return;

            case { } when type == typeof(CInt8):
                Write((CInt8)instance);
                return;

            case { } when type == typeof(CUInt16):
                Write((CUInt16)instance);
                return;

            case { } when type == typeof(CUInt32):
                Write((CUInt32)instance);
                return;

            case { } when type == typeof(CUInt64):
                Write((CUInt64)instance);
                return;

            case { } when type == typeof(CUInt8):
                Write((CUInt8)instance);
                return;

            case { } when type == typeof(CDateTime):
                Write((CDateTime)instance);
                return;

            case { } when type == typeof(CGuid):
                Write((CGuid)instance);
                return;

            case { } when type == typeof(CName):
                Write((CName)instance);
                return;

            case { } when type == typeof(CRUID):
                Write((CRUID)instance);
                return;

            case { } when type == typeof(CString):
                Write((CString)instance);
                return;

            case { } when type == typeof(CVariant):
                Write((CVariant)instance);
                return;

            case { } when type == typeof(DataBuffer):
                Write((DataBuffer)instance);
                return;

            case { } when type == typeof(EditorObjectID):
                Write((EditorObjectID)instance);
                return;

            case { } when type == typeof(LocalizationString):
                Write((LocalizationString)instance);
                return;

            case { } when type == typeof(MessageResourcePath):
                Write((MessageResourcePath)instance);
                return;

            case { } when type == typeof(NodeRef):
                Write((NodeRef)instance);
                return;

            case { } when type == typeof(SerializationDeferredDataBuffer):
                Write((SerializationDeferredDataBuffer)instance);
                return;

            case { } when type == typeof(SharedDataBuffer):
                Write((SharedDataBuffer)instance);
                return;

            case { } when type == typeof(TweakDBID):
                Write((TweakDBID)instance);
                return;

            case { } when type == typeof(gamedataLocKeyWrapper):
                Write((gamedataLocKeyWrapper)instance);
                return;
        }

        ThrowNotSupported(instance.GetType().Name);
    }

    public virtual void WriteGeneric(IRedGenericType genInstance)
    {
        var type = genInstance.GetType();

        if (typeof(IRedArray).IsAssignableFrom(type))
        {
            Write((IRedArray)genInstance);
            return;
        }

        if (typeof(IRedArrayFixedSize).IsAssignableFrom(type))
        {
            Write((IRedArrayFixedSize)genInstance);
            return;
        }

        if (typeof(IRedBitField).IsAssignableFrom(type))
        {
            Write((IRedBitField)genInstance);
            return;
        }

        if (typeof(IRedEnum).IsAssignableFrom(type))
        {
            Write((IRedEnum)genInstance);
            return;
        }

        if (typeof(IRedHandle).IsAssignableFrom(type))
        {
            Write((IRedHandle)genInstance);
            return;
        }

        if (typeof(IRedLegacySingleChannelCurve).IsAssignableFrom(type))
        {
            Write((IRedLegacySingleChannelCurve)genInstance);
            return;
        }

        if (typeof(IRedMultiChannelCurve).IsAssignableFrom(type))
        {
            Write((IRedMultiChannelCurve)genInstance);
            return;
        }

        if (typeof(IRedResourceReference).IsAssignableFrom(type))
        {
            Write((IRedResourceReference)genInstance);
            return;
        }

        if (typeof(IRedResourceAsyncReference).IsAssignableFrom(type))
        {
            Write((IRedResourceAsyncReference)genInstance);
            return;
        }

        if (typeof(IRedStatic).IsAssignableFrom(type))
        {
            Write((IRedStatic)genInstance);
            return;
        }

        if (typeof(IRedWeakHandle).IsAssignableFrom(type))
        {
            Write((IRedWeakHandle)genInstance);
            return;
        }

        ThrowNotSupported(genInstance.GetType().Name);
    }

    #region IDisposable

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _writer.Close();
            }
            _disposed = true;
        }
    }

    public void Dispose() => Dispose(true);

    public virtual void Close() => Dispose(true);

    #endregion IDisposable

    protected class ChunkInfo
    {
        public int Id { get; set; } = -1;
        public Guid Guid { get; set; } = Guid.Empty;
    }

    protected class CNameComparer : IEqualityComparer<CName>
    {
        public bool Equals(CName x, CName y) => string.Equals(x, y);
        public bool Equals(CName x, string y) => string.Equals(x, y);

        public int GetHashCode(CName obj) => obj.GetHashCode();
    }

    protected class ImportComparer : IEqualityComparer<ImportEntry>
    {
        public bool Equals(ImportEntry? x, ImportEntry? y) => string.Equals(x?.DepotPath, y?.DepotPath);

        public int GetHashCode(ImportEntry obj) => obj.DepotPath.GetHashCode();
    }

    protected class RedBufferComparer : IEqualityComparer<RedBuffer>
    {
        public bool Equals(RedBuffer? x, RedBuffer? y)
        {
            return object.Equals(x, y);
        }

        // ignore hashcode, return first content match
        public int GetHashCode(RedBuffer obj) => 0;
    }
}