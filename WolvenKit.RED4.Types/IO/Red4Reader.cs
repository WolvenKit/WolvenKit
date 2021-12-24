using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.IO
{
    public partial class Red4Reader : IDisposable
    {
        protected readonly BinaryReader _reader;

        protected Red4File _outputFile;
        protected List<CName> _namesList = new();
        protected List<IRedImport> importsList = new();

        private bool _disposed;

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

        public int Position => (int)_reader.BaseStream.Position;

        public List<IRedImport> ImportsList { get => importsList; set => importsList = value; }

        protected CName GetStringValue(ushort index)
        {
            if (index >= _namesList.Count)
            {
                throw new Exception();
            }

            return _namesList[index];
        }

        #region Fundamentals

        public virtual CBool ReadCBool() => _reader.ReadByte();
        public virtual CDouble ReadCDouble() => _reader.ReadDouble();
        public virtual CFloat ReadCFloat() => _reader.ReadSingle();
        public virtual CInt16 ReadCInt16() => _reader.ReadInt16();
        public virtual CInt32 ReadCInt32() => _reader.ReadInt32();
        public virtual CInt64 ReadCInt64() => _reader.ReadInt64();
        public virtual CInt8 ReadCInt8() => _reader.ReadSByte();
        public virtual CUInt16 ReadCUInt16() => _reader.ReadUInt16();
        public virtual CUInt32 ReadCUInt32() => _reader.ReadUInt32();
        public virtual CUInt64 ReadCUInt64() => _reader.ReadUInt64();
        public virtual CUInt8 ReadCUInt8() => _reader.ReadByte();

        #endregion Fundamentals

        #region Simples

        public virtual CDateTime ReadCDateTime() => _reader.ReadUInt64();

        public virtual CGuid ReadCGuid() => _reader.ReadBytes(16);
        public virtual CName ReadCName() => GetStringValue(_reader.ReadUInt16());
        public virtual CRUID ReadCRUID() => _reader.ReadUInt64();
        public virtual CString ReadCString() => _reader.ReadLengthPrefixedString();

        public virtual CVariant ReadCVariant()
        {
            var result = new CVariant();

            var typeName = GetStringValue(_reader.ReadUInt16());
            var (type, flags) = RedReflection.GetCSTypeFromRedType(typeName);
            var size = _reader.ReadUInt32() - 4;
            if (size > 0)
            {
                result.Value = Read(type, size, flags);
            }

            return result;
        }

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

        public virtual EditorObjectID ReadEditorObjectID() => (EditorObjectID)ThrowNotImplemented();

        public virtual LocalizationString ReadLocalizationString() =>
            new()
            {
                Unk1 = _reader.ReadUInt64(),
                Value = _reader.ReadLengthPrefixedString()
            };

        public virtual MessageResourcePath ReadMessageResourcePath() => (MessageResourcePath)ThrowNotImplemented();

        public virtual NodeRef ReadNodeRef() => _reader.ReadLengthPrefixedString();

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

        public virtual TweakDBID ReadTweakDBID() => _reader.ReadUInt64();

        #endregion Simples

        #region General

        public virtual IRedMultiChannelCurve ReadMultiChannelCurve(Type type)
        {
            var innerType = type.GetGenericArguments()[0];

            var method = typeof(Red4Reader).GetMethod(nameof(ReadMultiChannelCurve), Type.EmptyTypes);
            var generic = method.MakeGenericMethod(innerType);

            return (IRedMultiChannelCurve)generic.Invoke(this, null);
        }

        public virtual IRedMultiChannelCurve<T> ReadMultiChannelCurve<T>() where T : IRedType
        {
            var result = new MultiChannelCurve<T>();

            result.NumChannels = _reader.ReadUInt32();
            result.InterPolationType = (Enums.EInterPolationType)_reader.ReadByte();
            result.LinkType = (Enums.EChannelLinkType)_reader.ReadByte();
            result.Alignment = _reader.ReadUInt32();

            var size = _reader.ReadUInt32();
            result.Data = _reader.ReadBytes((int)size);

            return result;
        }

        public virtual IRedArray ReadCArray(Type type, uint size)
        {
            var innerType = type.GetGenericArguments()[0];

            var method = typeof(Red4Reader).GetMethod(nameof(ReadCArray), new[] { typeof(uint) });
            var generic = method.MakeGenericMethod(innerType);

            return (IRedArray)generic.Invoke(this, new object[] { size });
        }

        public virtual IRedArray<T> ReadCArray<T>(uint size) where T : IRedType
        {
            var array = new CArray<T>();

            var elementCount = _reader.ReadUInt32();

            uint elementSize = 0;
            if (elementCount > 0)
            {
                elementSize = (size - 4) / elementCount;
            }

            for (var i = 0; i < elementCount; i++)
            {
                var element = Read(typeof(T), elementSize, Flags.Empty);
                array.Add((T)element);
            }

            return array;
        }

        public virtual IRedArrayFixedSize ReadCArrayFixedSize(Type type, uint size, Flags flags)
        {
            var innerType = type.GetGenericArguments()[0];

            var method = typeof(Red4Reader).GetMethod(nameof(ReadCArrayFixedSize), new[] { typeof(uint), typeof(Flags) });
            var generic = method.MakeGenericMethod(innerType);

            return (IRedArrayFixedSize)generic.Invoke(this, new object[] { size, flags });
        }

        public virtual IRedArrayFixedSize<T> ReadCArrayFixedSize<T>(uint size, Flags flags) where T : IRedType
        {
            var array = new CArrayFixedSize<T>(flags.MoveNext() ? flags.Current : 0);

            var elementCount = _reader.ReadUInt32();

            uint elementSize = 0;
            if (elementCount > 0)
            {
                elementSize = (size - 4) / elementCount;
            }

            for (var i = 0; i < elementCount; i++)
            {
                var element = Read(typeof(T), elementSize, flags.Clone());
                ((IList<T>)array)[i] = (T)element;
            }

            return array;
        }

        public virtual IRedBitField ReadCBitField(Type type)
        {
            var innerType = type.GetGenericArguments()[0];

            var method = typeof(Red4Reader).GetMethod(nameof(ReadCBitField), Type.EmptyTypes);
            var generic = method.MakeGenericMethod(innerType);

            return (IRedBitField)generic.Invoke(this, null);
        }

        public virtual CBitField<T> ReadCBitField<T>() where T : struct, Enum
        {
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

                enumString += GetStringValue(index);
            }

            if (string.IsNullOrEmpty(enumString))
            {
                return default(T);
            }

            return Enum.Parse<T>(enumString);
        }

        public virtual IRedEnum ReadCEnum(Type type)
        {
            var innerType = type.GetGenericArguments()[0];

            var method = typeof(Red4Reader).GetMethod(nameof(ReadCEnum), Type.EmptyTypes);
            var generic = method.MakeGenericMethod(innerType);

            return (IRedEnum)generic.Invoke(this, null);
        }

        public virtual CEnum<T> ReadCEnum<T>() where T : struct, Enum
        {
            var index = _reader.ReadUInt16();
            var enumString = GetStringValue(index);

            return CEnum.Parse<T>(enumString);
        }

        public virtual IRedHandle ReadCHandle(Type type)
        {
            var innerType = type.GetGenericArguments()[0];

            var method = typeof(Red4Reader).GetMethod(nameof(ReadCHandle), Type.EmptyTypes);
            var generic = method.MakeGenericMethod(innerType);

            return (IRedHandle)generic.Invoke(this, null);
        }

        protected Dictionary<int, List<IRedBaseHandle>> HandleQueue = new();
        protected Dictionary<int, List<IRedBufferPointer>> BufferQueue = new();

        public virtual IRedHandle<T> ReadCHandle<T>() where T : IRedClass
        {
            var handle = new CHandle<T>();

            var pointer = _reader.ReadInt32() - 1;
            if (!HandleQueue.ContainsKey(pointer))
            {
                HandleQueue.Add(pointer, new List<IRedBaseHandle>());
            }

            HandleQueue[pointer].Add(handle);

            return handle;
        }

        public virtual IRedLegacySingleChannelCurve ReadCLegacySingleChannelCurve(Type type)
        {
            var innerType = type.GetGenericArguments()[0];

            var method = typeof(Red4Reader).GetMethod(nameof(ReadCLegacySingleChannelCurve), Type.EmptyTypes);
            var generic = method.MakeGenericMethod(innerType);

            return (IRedLegacySingleChannelCurve)generic.Invoke(this, null);
        }

        public virtual IRedLegacySingleChannelCurve<T> ReadCLegacySingleChannelCurve<T>() where T : IRedType
        {
            var instance = new CLegacySingleChannelCurve<T>();

            var elementCount = _reader.ReadUInt32();
            for (var i = 0; i < elementCount; i++)
            {
                var curvePoint = new CurvePoint<T>();

                IRedType element;
                if (typeof(IRedClass).IsAssignableFrom(typeof(T)))
                {
                    element = ReadFixedClass(typeof(T), 0);
                }
                else
                {
                    element = Read(typeof(T), 0, Flags.Empty);
                }

                var point = _reader.ReadSingle();

                if (element.GetType() == typeof(T))
                {
                    curvePoint.SetPoint(point);
                    curvePoint.SetValue(element);

                    instance.Add(curvePoint);
                }
            }

            instance.Tail = _reader.ReadUInt16();

            return instance;
        }

        public virtual IRedResourceAsyncReference ReadCResourceAsyncReference(Type type)
        {
            var innerType = type.GetGenericArguments()[0];

            var method = typeof(Red4Reader).GetMethod(nameof(ReadCResourceAsyncReference), Type.EmptyTypes);
            var generic = method.MakeGenericMethod(innerType);

            return (IRedResourceAsyncReference)generic.Invoke(this, null);
        }

        public virtual IRedResourceAsyncReference<T> ReadCResourceAsyncReference<T>() where T : IRedClass
        {
            var index = _reader.ReadUInt16();

            if (index > 0)
            {
                return new CResourceAsyncReference<T>
                {
                    DepotPath = importsList[index - 1].DepotPath,
                    Flags = importsList[index - 1].Flags
                };
            }

            return new CResourceAsyncReference<T>
            {
                DepotPath = "",
                Flags = InternalEnums.EImportFlags.Default
            };
        }

        public virtual IRedResourceReference ReadCResourceReference(Type type)
        {
            var innerType = type.GetGenericArguments()[0];

            var method = typeof(Red4Reader).GetMethod(nameof(ReadCResourceReference), Type.EmptyTypes);
            var generic = method.MakeGenericMethod(innerType);

            return (IRedResourceReference)generic.Invoke(this, null);
        }

        public virtual IRedResourceReference<T> ReadCResourceReference<T>() where T : IRedClass
        {
            var index = _reader.ReadUInt16();

            if (index > 0 && index <= importsList.Count)
            {
                return new CResourceReference<T>
                {
                    DepotPath = importsList[index - 1].DepotPath,
                    Flags = importsList[index - 1].Flags
                };
            }

            return new CResourceReference<T>
            {
                DepotPath = "",
                Flags = InternalEnums.EImportFlags.Default
            };
        }

        public virtual IRedStatic ReadCStaticArray(Type type, uint size, Flags flags)
        {
            var innerType = type.GetGenericArguments()[0];

            var method = typeof(Red4Reader).GetMethod(nameof(ReadCStaticArray), new[] { typeof(uint), typeof(Flags) });
            var generic = method.MakeGenericMethod(innerType);

            return (IRedStatic)generic.Invoke(this, new object[] { size, flags });
        }

        public virtual IRedStatic<T> ReadCStaticArray<T>(uint size, Flags flags) where T : IRedType
        {
            var array = new CStatic<T>(flags.MoveNext() ? flags.Current : 0);

            var elementCount = _reader.ReadUInt32();

            uint elementSize = 0;
            if (elementCount > 0)
            {
                elementSize = (size - 4) / elementCount;
            }

            for (var i = 0; i < elementCount; i++)
            {
                var element = Read(typeof(T), elementSize, flags.Clone());
                ((IList<T>)array)[i] = (T)element;
            }

            return array;
        }

        public virtual IRedWeakHandle ReadCWeakHandle(Type type)
        {
            var innerType = type.GetGenericArguments()[0];

            var method = typeof(Red4Reader).GetMethod(nameof(ReadCWeakHandle), Type.EmptyTypes);
            var generic = method.MakeGenericMethod(innerType);

            return (IRedWeakHandle)generic.Invoke(this, null);
        }

        public virtual IRedWeakHandle<T> ReadCWeakHandle<T>() where T : IRedClass
        {
            var handle = new CWeakHandle<T>();

            var pointer = _reader.ReadInt32() - 1;
            if (!HandleQueue.ContainsKey(pointer))
            {
                HandleQueue.Add(pointer, new List<IRedBaseHandle>());
            }

            HandleQueue[pointer].Add(handle);

            return handle;
        }

        #endregion General

        #region Helper

        protected IRedType ThrowNotImplemented([CallerMemberName] string callerMemberName = "")
        {
            throw new NotImplementedException($"{nameof(Red4Reader)}.{callerMemberName}");
        }

        protected IRedType ThrowNotSupported([CallerMemberName] string callerMemberName = "")
        {
            throw new NotSupportedException($"{nameof(Red4Reader)}.{callerMemberName}");
        }

        #endregion

        public virtual IRedClass ReadClass(Type type, uint size)
        {
            if (!typeof(IRedClass).IsAssignableFrom(type))
            {
                throw new ArgumentException(nameof(type));
            }

            var instance = RedTypeManager.Create(type);
            ReadClass(instance, size);
            return instance;
        }

        public virtual void ReadClass(IRedClass cls, uint size)
        {
            ThrowNotImplemented();
        }

        public virtual IRedClass ReadFixedClass(Type type, uint size)
        {
            var typeInfo = RedReflection.GetTypeInfo(type);

            var instance = RedTypeManager.Create(type);
            foreach (var propertyInfo in typeInfo.GetWritableProperties())
            {
                var value = Read(propertyInfo.Type, 0, Flags.Empty);
                instance.InternalSetPropertyValue(propertyInfo.RedName, value);
            }

            return instance;
        }

        public virtual IRedType Read(Type type, uint size = 0, Flags flags = null)
        {
            if (typeof(IRedClass).IsAssignableFrom(type))
            {
                return ReadClass(type, size);
            }

            if (!typeof(IRedType).IsAssignableFrom(type))
            {
                return ThrowNotSupported(type.Name);
            }

            if (type.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IRedGenericType<>)))
            {
                return ReadGeneric(type, size, flags);
            }

            switch (type)
            {
                case { } when type == typeof(CBool):
                    return ReadCBool();

                case { } when type == typeof(CDouble):
                    return ReadCDouble();

                case { } when type == typeof(CFloat):
                    return ReadCFloat();

                case { } when type == typeof(CInt16):
                    return ReadCInt16();

                case { } when type == typeof(CInt32):
                    return ReadCInt32();

                case { } when type == typeof(CInt64):
                    return ReadCInt64();

                case { } when type == typeof(CInt8):
                    return ReadCInt8();

                case { } when type == typeof(CUInt16):
                    return ReadCUInt16();

                case { } when type == typeof(CUInt32):
                    return ReadCUInt32();

                case { } when type == typeof(CUInt64):
                    return ReadCUInt64();

                case { } when type == typeof(CUInt8):
                    return ReadCUInt8();

                case { } when type == typeof(CDateTime):
                    return ReadCDateTime();

                case { } when type == typeof(CGuid):
                    return ReadCGuid();

                case { } when type == typeof(CName):
                    return ReadCName();

                case { } when type == typeof(CRUID):
                    return ReadCRUID();

                case { } when type == typeof(CString):
                    return ReadCString();

                case { } when type == typeof(CVariant):
                    return ReadCVariant();

                case { } when type == typeof(DataBuffer):
                    return ReadDataBuffer();

                case { } when type == typeof(EditorObjectID):
                    return ReadEditorObjectID();

                case { } when type == typeof(LocalizationString):
                    return ReadLocalizationString();

                case { } when type == typeof(MessageResourcePath):
                    return ReadMessageResourcePath();

                case { } when type == typeof(NodeRef):
                    return ReadNodeRef();

                case { } when type == typeof(SerializationDeferredDataBuffer):
                    return ReadSerializationDeferredDataBuffer(size);

                case { } when type == typeof(SharedDataBuffer):
                    return ReadSharedDataBuffer(size);

                case { } when type == typeof(TweakDBID):
                    return ReadTweakDBID();

                default:
                    return ThrowNotSupported(type.Name);
            }
        }

        protected virtual IRedType ReadGeneric(Type type, uint size, Flags flags)
        {
            switch (type.GetGenericTypeDefinition())
            {
                case { } cType when cType == typeof(CArray<>):
                    return ReadCArray(type, size);

                case { } cType when cType == typeof(CArrayFixedSize<>):
                    return ReadCArrayFixedSize(type, size, flags);

                case { } cType when cType == typeof(CBitField<>):
                    return ReadCBitField(type);

                case { } cType when cType == typeof(CEnum<>):
                    return ReadCEnum(type);

                case { } cType when cType == typeof(CHandle<>):
                    return ReadCHandle(type);

                case { } cType when cType == typeof(CLegacySingleChannelCurve<>):
                    return ReadCLegacySingleChannelCurve(type);

                case { } cType when cType == typeof(MultiChannelCurve<>):
                    return ReadMultiChannelCurve(type);

                case { } cType when cType == typeof(CResourceAsyncReference<>):
                    return ReadCResourceAsyncReference(type);

                case { } cType when cType == typeof(CResourceReference<>):
                    return ReadCResourceReference(type);

                case { } cType when cType == typeof(CStatic<>):
                    return ReadCStaticArray(type, size, flags);

                case { } cType when cType == typeof(CWeakHandle<>):
                    return ReadCWeakHandle(type);

                default:
                    return ThrowNotSupported(type.Name);
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
}
