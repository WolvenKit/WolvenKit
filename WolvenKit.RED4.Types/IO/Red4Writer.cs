using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.IO
{
    public class Red4Writer : IDisposable
    {
        protected readonly BinaryWriter _writer;

        public CacheList<CName> StringCacheList = new();
        public CacheList<(string, CName, ushort)> ImportCacheList = new();

        public int CurrentChunk { get; private set; }

        public readonly Dictionary<long, string> CNameRef = new();
        public readonly Dictionary<long, (string, string, ushort)> ImportRef = new();

        protected readonly Dictionary<int, StringInfo> _chunkStringList = new();
        protected readonly Dictionary<int, ImportInfo> _chunkImportList = new();

        protected readonly List<(int, int, int, int)> _targetList = new();

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
            StringCacheList.Add("");

            _writer = new BinaryWriter(output, encoding, leaveOpen);
            _encoding = encoding;
        }

        public Stream BaseStream => _writer.BaseStream;
        public BinaryWriter BaseWriter => _writer;

        public int Position => (int)_writer.BaseStream.Position;

        #region Support

        public void WriteVLQ(int value) => _writer.WriteVLQInt32(value);

        #endregion

        public List<(int, int, int, int)> GetTargets(int chunkIndex)
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

        public ushort GetImportIndex((string, string, ushort) value, bool add = true)
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

        public void StartChunk(int i)
        {
            CurrentChunk = i;
            if (i == 0)
            {
                return;
            }

            _chunkStringList.Add(i - 1, new() {List = StringCacheList.ToList() });
            StringCacheList.Clear();

            _chunkImportList.Add(i - 1, new (){List = ImportCacheList.ToList()});
            ImportCacheList.Clear();
        }

        public (Dictionary<CName, ushort>, Dictionary<(string, CName, ushort), ushort>) GenerateStringDictionary()
        {
            _chunkStringList.Add(CurrentChunk, new() { List = StringCacheList.ToList() });
            StringCacheList.Clear();

            _chunkImportList.Add(CurrentChunk, new (){List = ImportCacheList.ToList()});
            ImportCacheList.Clear();

            var targetList = new List<(int, int, int, int)>(_targetList);

            var length = _chunkStringList.Count;
            for (int i = 0; i < length; i++)
            {
                GenerateFor(i);
            }

            return (StringCacheList.ToDictionary(), ImportCacheList.ToDictionary());

            void GenerateFor(int chunk)
            {
                if (!_chunkStringList.ContainsKey(chunk))
                {
                    return;
                }

                var stringList = _chunkStringList[chunk];
                var importList = _chunkImportList[chunk];

                var list = targetList.Where(x => x.Item1 == chunk).ToList();
                foreach (var tuple in list)
                {
                    StringCacheList.AddRange(stringList.List.GetRange(stringList.LastIndex, tuple.Item3 - stringList.LastIndex));
                    stringList.LastIndex = tuple.Item3;

                    ImportCacheList.AddRange(importList.List.GetRange(importList.LastIndex, tuple.Item4 - importList.LastIndex));
                    importList.LastIndex = tuple.Item4;

                    targetList.Remove(tuple);

                    if ((tuple.Item2) > chunk)
                    {
                        GenerateFor(tuple.Item2);
                    }
                }
                StringCacheList.AddRange(stringList.List.GetRange(stringList.LastIndex, stringList.List.Count - stringList.LastIndex));
                ImportCacheList.AddRange(importList.List.GetRange(importList.LastIndex, importList.List.Count - importList.LastIndex));

                _chunkStringList.Remove(chunk);
                _chunkImportList.Remove(chunk);
            }
        }

        protected class StringInfo
        {
            public List<CName> List { get; set; }
            public int LastIndex { get; set; }
        }

        protected class ImportInfo
        {
            public List<(string, CName, ushort)> List { get; set; }
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
            CNameRef.Add(_writer.BaseStream.Position, val);
            _writer.Write(GetStringIndex(val));
        }

        public virtual void Write(CRUID val) => _writer.Write(val);
        public virtual void Write(CString val) => _writer.WriteLengthPrefixedString(val);

        public virtual void Write(CVariant val)
        {
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

        public virtual void Write(DataBuffer val)
        {
            if (val.Pointer >= 0)
            {
                _writer.Write((uint)(val.Pointer | 0x80000000) + 1);
            }
            else
            {
                _writer.Write((uint)(val.Data.Length));
                _writer.Write(val.Data);
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
        public virtual void Write(SerializationDeferredDataBuffer val) => _writer.Write((ushort)(val.Pointer + 1));
        public virtual void Write(SharedDataBuffer val) => _writer.Write(val.Buffer);
        public virtual void Write(TweakDBID val) => _writer.Write(val.Value);

        #endregion Simple

        // TODO: Check for generic arguments
        private MethodInfo GetMethod(string name, int genericParameterCount, Type[] types)
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
            CNameRef.Add(_writer.BaseStream.Position, instance.ToEnumString());
            _writer.Write(GetStringIndex(instance.ToEnumString()));
        }

        public virtual void Write(IRedHandle instance)
        {
            if (instance.Pointer > 0)
            {
                _targetList.Add((CurrentChunk, instance.Pointer, StringCacheList.Count, ImportCacheList.Count));
            }

            _writer.Write(instance.Pointer + 1);
        }

        public virtual void Write(IRedWeakHandle instance)
        {
            if (instance.Pointer > 0)
            {
                _targetList.Add((CurrentChunk, instance.Pointer, StringCacheList.Count, ImportCacheList.Count));
            }

            _writer.Write(instance.Pointer + 1);
        }

        // TODO
        public virtual void Write(IRedLegacySingleChannelCurve instance)
        {
            _writer.Write((uint)instance.Count);
            foreach (var curvePoint in instance)
            {
                var value = curvePoint.GetValue();
                if (value is IRedClass cls)
                {
                    WriteFixedClass(cls);
                }
                else
                {
                    Write(curvePoint.GetValue());
                }

                _writer.Write(curvePoint.GetPoint());
            }
            _writer.Write(instance.Tail);
        }

        public virtual void Write(IRedMultiChannelCurve instance)
        {
            var genericType = instance.GetType().GetGenericTypeDefinition();
            var innerType = instance.GetType().GetGenericArguments()[0];

            var method = GetMethod("Write", 1, new[] { genericType });
            var generic = method.MakeGenericMethod(innerType);

            generic.Invoke(this, new object[] { instance });
        }

        public virtual void Write<T>(MultiChannelCurve<T> instance) where T : IRedType
        {
            _writer.Write(instance.NumChannels);
            _writer.Write((byte)instance.InterPolationType);
            _writer.Write((byte)instance.LinkType);
            _writer.Write(instance.Alignment);

            _writer.Write((uint)instance.Data.Length);
            _writer.Write(instance.Data);
        }

        public virtual void Write(IRedResourceReference instance)
        {
            if (instance.DepotPath == "")
            {
                _writer.Write((ushort)0);
                return;
            }

            var val = ("", instance.DepotPath, (ushort)instance.Flags);

            ImportRef.Add(_writer.BaseStream.Position, val);
            _writer.Write(GetImportIndex(val));
        }

        public virtual void Write(IRedResourceAsyncReference instance)
        {
            if (instance.DepotPath == "")
            {
                _writer.Write((ushort)0);
                return;
            }

            var val = ("", instance.DepotPath, (ushort)instance.Flags);

            ImportRef.Add(_writer.BaseStream.Position, val);
            _writer.Write(GetImportIndex(val));
        }

        #endregion General

        public virtual void Write(IRedClass instance) => ThrowNotImplemented();

        public virtual void WriteFixedClass(IRedClass instance)
        {
            var typeInfo = RedReflection.GetTypeInfo(instance.GetType());
            foreach (var propertyInfo in typeInfo.PropertyInfos)
            {
                var value = (IRedType)instance.InternalGetPropertyValue(instance.GetType(), propertyInfo.RedName, propertyInfo.Flags.Clone());
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

        public virtual void WriteClass(IRedClass instance)
        {
            ThrowNotImplemented();
        }

        public virtual void Write(IRedType instance, [CallerMemberName] string callerMemberName = "")
        {
            if (callerMemberName == nameof(WriteGeneric))
            {
                throw new Exception();
            }

            if (instance is IRedClass cls)
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

        private class HandleInfo
        {

        }
    }
}
