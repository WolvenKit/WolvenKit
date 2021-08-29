using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.IO
{
    public class Red4Reader : IDisposable
    {
        protected BinaryReader _reader;
        protected List<string> _stringList;

        private bool _disposed;

        public Red4Reader(Stream input) : this(input, Encoding.UTF8, false)
        {
        }

        public Red4Reader(Stream input, Encoding encoding) : this(input, encoding, false)
        {
        }

        public Red4Reader(Stream input, Encoding encoding, bool leaveOpen)
        {
            _reader = new BinaryReader(input, encoding, leaveOpen);
        }

        public BinaryReader BaseReader => _reader;
        public Stream BaseStream => _reader.BaseStream;

        public void SetStringList(List<string> stringList)
        {
            _stringList = stringList;
        }

        #region Support

        /// <summary>
        /// Reads a string from a BinaryReader Stream
        /// First byte indicates length, where the first 2 bits are reserved
        /// bit1: 0 if widecharacterset is needed, 1 otherwise
        /// bit2: 1 if continuation byte is needed, 0 otherwise
        /// </summary>
        /// <param name="br"></param>
        /// <returns></returns>
        private string ReadLengthPrefixedString()
        {
            // ReadVLQInt32 but highest bit is widechar instead of sign
            var b1 = _reader.ReadByte();
            if (b1 == 0x80)
                return null;
            if (b1 == 0x00)
                return "";

            var widechar = (b1 & 128) == 0;
            var next = (b1 & 64) == 64;
            var size = b1 % 128 % 64;
            var offset = 6;
            while (next)
            {
                var b = _reader.ReadByte();
                size = (b % 128) << offset | size;
                next = (b & 128) == 128;
                offset += 7;
            }

            string readstring;
            readstring = widechar
                ? Encoding.Unicode.GetString(_reader.ReadBytes(size * 2))
                : Encoding.GetEncoding("ISO-8859-1").GetString(_reader.ReadBytes(size));

            return readstring;
        }

        #endregion

        #region Fundamentals

        public virtual CBool ReadCBool() => _reader.ReadByte() != 0x00;
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

        public virtual CGUID ReadCGUID() => _reader.ReadBytes(16);
        public virtual CName ReadCName() => _stringList[_reader.ReadUInt16()];
        public virtual CRUID ReadCRUID() => _reader.ReadUInt64();
        public virtual CString ReadCString() => ReadLengthPrefixedString();

        // TODO: throw custom exception, other arg type?
        public virtual CVariant ReadCVariant()
        {
            throw new NotImplementedException(nameof(ReadCVariant));

            /*var typeStr = _stringList[this.ReadUInt16()];
            var varSize = this.ReadUInt32() - 4;

            if (varSize > 4)
            {
                // TODO: TypeManager.Create

            }*/
        }

        public virtual DataBuffer ReadDataBuffer(uint size)
        {
            if (size != 4)
            {
                throw new InvalidParsingException(nameof(ReadDataBuffer));
            }

            var result = new DataBuffer { Buffer = _reader.ReadUInt16() };
            _reader.ReadUInt16();

            return result;
        }

        public virtual EditorObjectID ReadEditorObjectID() => (EditorObjectID)ThrowNotImplemented();
        public virtual LocalizationString ReadLocalizationString() => (LocalizationString)ThrowNotImplemented();
        public virtual MessageResourcePath ReadMessageResourcePath() => (MessageResourcePath)ThrowNotImplemented();
        public virtual MultiChannelCurve<T> ReadMessageResourcePath<T>() where T : IRedType => (MultiChannelCurve<T>)ThrowNotImplemented();
        public virtual NodeRef ReadNodeRef() => ReadLengthPrefixedString();

        public virtual SerializationDeferredDataBuffer ReadSerializationDeferredDataBuffer(uint size)
        {
            if (size > 2)
            {
                throw new InvalidParsingException(nameof(ReadSerializationDeferredDataBuffer));
            }
            
            return new() { Buffer = ReadCUInt16() };
        }
        public virtual SharedDataBuffer ReadSharedDataBuffer() => (SharedDataBuffer)ThrowNotImplemented();
        public virtual TweakDBID ReadTweakDBID() => _reader.ReadUInt64();

        #endregion Simples

        #region General

        public virtual IRedArray<T> ReadCArray<T>(IRedArray array) where T : IRedType
        {
            var instance = new CArray<T>();
            InternalReadCArray(instance);
            return instance;
        }

        protected virtual void InternalReadCArray(IRedArray array)
        {
            ThrowNotImplemented();
        }

        public virtual IRedArray<T> ReadCArrayFixedSize<T>(IRedArray array) where T : IRedType
        {
            var instance = new CArrayFixedSize<T>();
            InternalCArrayFixedSize(instance);
            return instance;
        }

        protected virtual void InternalCArrayFixedSize(IRedArray array)
        {
            ThrowNotImplemented();
        }

        public virtual IRedEnum<T> ReadCBitField<T>() where T : Enum
        {
            var instance = new CBitField<T>();
            InternalReadCBitField(instance);
            return instance;
        }

        protected virtual void InternalReadCBitField(IRedEnum @enum)
        {
            var innerType = @enum.GetType().GetGenericArguments()[0];

            var index = _reader.ReadUInt16();
            var enumString = _stringList[index];
            var enumValue = Enum.Parse(innerType, enumString);

            @enum.SetValue(enumValue);
        }

        public virtual IRedEnum<T> ReadCEnum<T>() where T : Enum
        {
            var instance = new CEnum<T>();
            InternalReadCEnum(instance);
            return instance;
        }

        protected virtual void InternalReadCEnum(IRedEnum @enum)
        {
            var innerType = @enum.GetType().GetGenericArguments()[0];

            var index = _reader.ReadUInt16();
            var enumString = _stringList[index];
            var enumValue = Enum.Parse(innerType, enumString);

            @enum.SetValue(enumValue);
        }

        public virtual IRedHandle<T> ReadCHandle<T>() where T : IRedClass
        {
            var instance = new CHandle<T>();
            InternalReadCHandle(instance);
            return instance;
        }

        protected virtual void InternalReadCHandle(IRedHandle handle)
        {
            handle.SetValue(_reader.ReadInt32());
        }

        public virtual IRedLegacySingleChannelCurve<T> ReadCLegacySingleChannelCurve<T>() where T : IRedType
        {
            var instance = new CLegacySingleChannelCurve<T>();

            

            return instance;
        }

        protected virtual void InternalReadCLegacySingleChannelCurve(IRedLegacySingleChannelCurve singleChannelCurve)
        {
            var innerType = singleChannelCurve.GetType().GetGenericArguments()[0];

            var startPos = BaseStream.Position;

            var elementCount = _reader.ReadUInt32();
            for (var i = 0; i < elementCount; i++)
            {
                var constructedType = typeof(CurvePoint<>).MakeGenericType(innerType);
                var curvePoint = (IRedCurvePoint)System.Activator.CreateInstance(constructedType);

                var element = Read(innerType);
                var point = _reader.ReadSingle();

                if (element.GetType() == innerType)
                {
                    curvePoint.SetPoint(point);
                    curvePoint.SetValue(element);

                    singleChannelCurve.Add(curvePoint);
                }
            }
        }

        public virtual IRedResourceReference<T> ReadCResourceAsyncReference<T>(IRedArray array) where T : IRedType
        {
            var instance = new CResourceAsyncReference<T>();
            InternalReadCResourceAsyncReference(instance);
            return instance;
        }

        protected virtual void InternalReadCResourceAsyncReference(IRedResourceReference redResourceReference)
        {
            redResourceReference.SetValue(_reader.ReadUInt16());
        }

        public virtual IRedResourceReference<T> ReadCResourceReference<T>(IRedArray array) where T : IRedType
        {
            var instance = new CResourceReference<T>();
            InternalReadCResourceReference(instance);
            return instance;
        }

        protected virtual void InternalReadCResourceReference(IRedResourceReference redResourceReference)
        {
            redResourceReference.SetValue(_reader.ReadUInt16());
        }

        public virtual IRedArray<T> ReadCStaticArray<T>(IRedArray array) where T : IRedType
        {
            var instance = new CStatic<T>();
            InternalReadCStaticArray(instance);
            return instance;
        }

        protected virtual void InternalReadCStaticArray(IRedArray array)
        {
            ThrowNotImplemented();
        }

        public virtual IRedHandle<T> ReadCWeakHandle<T>(IRedHandle array) where T : IRedClass
        {
            var instance = new CWeakHandle<T>();
            InternalReadCWeakHandle(instance);
            return instance;
        }

        protected virtual void InternalReadCWeakHandle(IRedHandle handle)
        {
            handle.SetValue(_reader.ReadInt32());
        }

        #endregion General

        #region Helper

        protected IRedPrimitive ThrowNotImplemented([CallerMemberName] string callerMemberName = "")
        {
            throw new NotImplementedException($"{nameof(Red4Reader)}.{callerMemberName}");
        }

        protected IRedPrimitive ThrowNotSupported([CallerMemberName] string callerMemberName = "")
        {
            throw new NotSupportedException($"{nameof(Red4Reader)}.{callerMemberName}");
        }

        #endregion

        public virtual IRedClass ReadClass<T>(T type) where T : IRedClass
        {
            var cls = (IRedClass)System.Activator.CreateInstance<T>();
            InternalReadClass(cls);
            return cls;
        }

        protected virtual void InternalReadClass(IRedClass cls)
        {
            ThrowNotImplemented();
        }

        public virtual IRedType Read(Type type, uint size = 0)
        {
            if (typeof(IRedClass).IsAssignableFrom(type))
            {
                var instance = (IRedClass)System.Activator.CreateInstance(type);
                InternalReadClass(instance);
                return instance;
            }

            if (!typeof(IRedType).IsAssignableFrom(type))
            {
                return ThrowNotSupported(type.Name);
            }

            if (type.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IRedPrimitive<>)))
            {
                try
                {
                    var genArgs = type.GetGenericArguments();
                    return ReadGeneric(type, type.GetGenericArguments()[0]);
                }
                catch (MissingRTTIException)
                {
                    throw;
                }
                catch (Exception e)
                {
                    throw;
                }
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

                case { } when type == typeof(CGUID):
                    return ReadCGUID();

                case { } when type == typeof(CName):
                    return ReadCName();

                case { } when type == typeof(CRUID):
                    return ReadCRUID();

                case { } when type == typeof(CString):
                    return ReadCString();

                case { } when type == typeof(CVariant):
                    return ReadCVariant();

                case { } when type == typeof(DataBuffer):
                    return ReadDataBuffer(size);

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
                    return ReadSharedDataBuffer();

                case { } when type == typeof(TweakDBID):
                    return ReadTweakDBID();

                default:
                    return ThrowNotSupported(type.Name);
            }
        }

        protected virtual IRedType ReadGeneric(Type type, Type genericType)
        {
            var instance = (IRedPrimitive)System.Activator.CreateInstance(type);

            switch (type.GetGenericTypeDefinition())
            {
                case { } cType when cType == typeof(CArray<>):
                    InternalReadCArray((IRedArray)instance);
                    return instance;

                case { } cType when cType == typeof(CEnum<>):
                    InternalReadCEnum((IRedEnum)instance);
                    return instance;

                case { } cType when cType == typeof(CHandle<>):
                    InternalReadCHandle((IRedHandle)instance);
                    return instance;

                case { } cType when cType == typeof(CLegacySingleChannelCurve<>):
                    InternalReadCLegacySingleChannelCurve((IRedLegacySingleChannelCurve)instance);
                    return instance;

                case { } cType when cType == typeof(CResourceAsyncReference<>):
                    InternalReadCResourceAsyncReference((IRedResourceReference)instance);
                    return instance;

                case { } cType when cType == typeof(CResourceReference<>):
                    InternalReadCResourceReference((IRedResourceReference)instance);
                    return instance;

                case { } cType when cType == typeof(CStatic<>):
                    InternalReadCStaticArray((IRedArray)instance);
                    return instance;

                case { } cType when cType == typeof(CWeakHandle<>):
                    InternalReadCWeakHandle((IRedHandle)instance);
                    return instance;

                default:
                    return ThrowNotSupported(type.Name);
            }
        }

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
    }
}
