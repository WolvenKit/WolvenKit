using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Net
{
    static class Request
    {
        public static byte[] Init()
        {
            return new byte[0];
        }
        public static byte[] Append(this byte[] payload,byte[] data)
        {
            return payload.Concat(data).ToArray();
        }

        public static byte[] AppendByte(this byte[] payload,byte Value)
        {
            return payload.Append(Const.TypeByte).Append(new byte[] { Value });
        }

        public static byte[] AppendUtf8(this byte[] payload, string text)
        {
            return payload.Append(Const.TypeStringUtf8).AppendInt16((Int16)(text.Length)).Append(Encoding.UTF8.GetBytes(text));
        }

        public static byte[] AppendUtf16(this byte[] payload, string text)
        {
            return payload.Append(Const.TypeStringUtf16).AppendInt16((Int16)(text.Length * 2)).Append(Encoding.BigEndianUnicode.GetBytes(text));
        }

        public static byte[] AppendInt64(this byte[] payload, Int64 value)
        {
            return payload.Append(Const.TypeInt64).Append(BitConverter.GetBytes(value).Reverse().ToArray());
        }

        public static byte[] AppendInt16(this byte[] payload, Int16 value)
        {
            return payload.Append(Const.TypeInt16).Append(BitConverter.GetBytes(value).Reverse().ToArray());
        }

        public static byte[] AppendUInt32(this byte[] payload, UInt32 value)
        {
            return payload.Append(Const.TypeUint32).Append(BitConverter.GetBytes(value).Reverse().ToArray());
        }

        public static byte[] AppendInt32(this byte[] payload, Int32 value)
        {
            return payload.Append(Const.TypeInt32).Append(BitConverter.GetBytes(value).Reverse().ToArray());
        }

        public static byte[] End(this byte[] payload)
        {
            return Const.PacketHead.Concat(BitConverter.GetBytes((short)(payload.Length+6)).Reverse().Concat(payload)).Concat(Const.PacketTail).ToArray();
        }
    }
}