using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.IO
{
    public class Red4Writer : IDisposable
    {
        private readonly BinaryWriter _writer;
        protected List<string> _stringList;

        private bool _disposed;

        public Red4Writer(Stream output) : this(output, Encoding.UTF8, false)
        {
        }

        public Red4Writer(Stream output, Encoding encoding) : this(output, encoding, false)
        {
        }

        public Red4Writer(Stream output, Encoding encoding, bool leaveOpen)
        {
            _writer = new BinaryWriter(output, encoding, leaveOpen);
            _stringList = new();
        }

        #region Support

        /// <summary>
        /// Writes a string to a BinaryWriter Stream
        /// First byte indicates length, where the first 2 bits are reserved
        /// bit1: 0 if widecharacterset is needed, 1 otherwise
        /// bit2: 1 if continuation byte is needed, 0 otherwise
        /// </summary>
        /// <param name="bw"></param>
        /// <param name="value"></param>
        private void WriteLengthPrefixedString(string value)
        {
            // WriteVLQInt32 but highest bit is widechar instead of sign
            if (string.IsNullOrEmpty(value))
            {
                _writer.Write((byte)0x00);
                return;
            }

            int len = value.Length;
            bool requiresWideChar = value.Any(c => c > 255);

            byte b = (byte)(len & 0x3F);
            len >>= 6;
            if (!requiresWideChar)
            {
                b |= 0x80;
            }
            bool cont = len != 0;
            if (cont)
            {
                b |= 0x40;
            }
            _writer.Write(b);
            while (cont)
            {
                b = (byte)(len & 0x7F);
                len >>= 7;
                cont = len != 0;
                if (cont)
                {
                    b |= 0x80;
                }
                _writer.Write(b);
            }

            if (requiresWideChar)
                _writer.Write(Encoding.Unicode.GetBytes(value));
            else
                _writer.Write(Encoding.GetEncoding("ISO-8859-1").GetBytes(value));
        }

        #endregion

        #region Fundamentals

        public virtual void Write(CBool val) => _writer.Write(val.Value ? (byte)1 : (byte)0);
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
        public virtual void Write(CGUID val) => _writer.Write(val.Value);

        public virtual void Write(CName val)
        {
            var index = _stringList.IndexOf(val.Text);
            if (index == -1)
            {
                _stringList.Add(val.Text);
                index = _stringList.Count - 1;
            }

            _writer.Write((ushort)index);
        }

        public virtual void Write(CRUID val) => _writer.Write(val);
        public virtual void Write(CString val) => WriteLengthPrefixedString(val);
        public virtual void Write(CVariant val) => ThrowNotImplemented();

        public virtual void Write(DataBuffer val)
        {
            _writer.Write(val.Buffer);
            _writer.Write((byte)0x00);
            _writer.Write((byte)0x80);
        }

        public virtual void Write(EditorObjectID val) => ThrowNotImplemented();

        public virtual void Write(LocalizationString val)
        {
            _writer.Write(val.Unk1);
            WriteLengthPrefixedString(val.Value);
        }

        public virtual void Write(MessageResourcePath val) => ThrowNotImplemented();
        public virtual void Write<T>(MultiChannelCurve<T> val) where T : IRedType => ThrowNotImplemented();
        public virtual void Write(NodeRef val) => WriteLengthPrefixedString(val);
        public virtual void Write(SerializationDeferredDataBuffer val) => _writer.Write(val.Buffer);
        public virtual void Write(SharedDataBuffer val) => _writer.Write(val.Buffer);
        public virtual void Write(TweakDBID val) => _writer.Write(val.Value);

        #endregion Simple

        #region General

        public virtual void Write(IRedArray instance) => ThrowNotImplemented();

        public virtual void Write(IRedEnum instance)
        {
            var enumValue = (Enum)instance.GetValue();

            var index = _stringList.IndexOf(enumValue.ToString());
            if (index == -1)
            {
                _stringList.Add(enumValue.ToString());
                index = _stringList.Count - 1;
            }

            _writer.Write((ushort)index);
        }

        public virtual void Write(IRedHandle instance) => _writer.Write(instance.GetValue());

        // TODO
        public virtual void Write(IRedLegacySingleChannelCurve instance)
        {
            ThrowNotImplemented();

            /*_writer.Write((uint)instance.Count);
            foreach (var curvePoint in instance)
            {
                _writer.Write(curvePoint.GetValue());
                _writer.Write(curvePoint.GetPoint());
            }
            _writer.Write(instance.Tail);*/
        }

        public virtual void Write(IRedResourceReference instance) => _writer.Write(instance.GetValue());

        #endregion General

        public virtual void Write(IRedClass instance) => ThrowNotImplemented();

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
    }
}
