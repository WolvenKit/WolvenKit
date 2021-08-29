using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.IO
{
    public class Red4Writer
    {
        private readonly BinaryWriter _writer;

        public Red4Writer(Stream output) : this(output, Encoding.UTF8, false)
        {
        }

        public Red4Writer(Stream output, Encoding encoding) : this(output, encoding, false)
        {
        }

        public Red4Writer(Stream output, Encoding encoding, bool leaveOpen)
        {
            _writer = new BinaryWriter(output, encoding, leaveOpen);
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

        // TODO: throw custom exception, other arg type?
        public virtual void Write(CName val, List<string> stringList) => _writer.Write((ushort)stringList.IndexOf(val));

        public virtual void Write(CRUID val) => _writer.Write(val);

        public virtual void Write(CString val) => WriteLengthPrefixedString(val);

        public virtual void Write(CVariant val, List<string> stringList)
        {
            throw new NotImplementedException("Write(CVariant)");

            var redTypeName = RedReflection.GetRedTypeName(val.Value.GetType());

            // TODO: Add to stringList, if not found
            var index = stringList.IndexOf(redTypeName);
            _writer.Write((ushort)index);

            // TODO: Reflection, get redType from val.Value
        }

        public virtual void Write(DataBuffer val)
        {
            _writer.Write(val.Buffer);
            _writer.Write((byte)0x00);
            _writer.Write((byte)0x80);
        }

        public virtual void Write(EditorObjectID val) => throw new NotImplementedException();

        public virtual void Write(LocalizationString val)
        {
            _writer.Write(val.Unk1);
            WriteLengthPrefixedString(val.Value);
        }

        public virtual void Write(MessageResourcePath val) => throw new NotImplementedException();
        public virtual void Write<T>(MultiChannelCurve<T> val) where T : IRedType => throw new NotImplementedException();
        public virtual void Write(NodeRef val) => WriteLengthPrefixedString(val);
        public virtual void Write(SerializationDeferredDataBuffer val) => _writer.Write(val.Buffer);
        public virtual void Write(SharedDataBuffer val) => _writer.Write(val.Buffer);
        public virtual void Write(TweakDBID val) => _writer.Write(val.Value);

        #endregion
    }
}
