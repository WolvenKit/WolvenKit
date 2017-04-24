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
            return Append(payload,new []{(byte)'!', (byte)'?',Value});
        }

        public static byte[] AppendUtf8(this byte[] payload, string text)
        {
            return payload.Append(Const.TypeStringUtf8).AppendByte((byte)text.Length).Append(Encoding.UTF8.GetBytes(text));
        }

        public static byte[] AppendUtf16(this byte[] payload, string text)
        {
            return payload.Append(Const.TypeStringUtf16).AppendLenShort(text.Length).Append(Encoding.Unicode.GetBytes(text));
        }

        public static byte[] AppendLenShort(this byte[] payload, int len)
        {
            return payload.Append(new[] {(byte) '!', (byte) 'H', (byte) len});
        }

        public static byte[] AppendInt32(this byte[] payload, uint value)
        {
            var iv = value;
            if ((iv & 0x80000000) != 0)
                iv = (uint)(-0x100000000 + iv);
            return payload.Append(Const.TypeInt32).Append(new[] {(byte) '!', (byte) 'l', (byte) iv});
        }

        public static byte[] AppendInt64(this byte[] payload, Int64 value)
        {
            var iv = value;
            if (((ulong)iv & 0x8000000000000000) != 0)
                iv = (-0x1000000000000000 + iv);
            return payload.Append(Const.TypeInt64).Append(new[] { (byte)'!', (byte)'q', (byte)iv });
        }

        public static byte[] AppendUInt32(this byte[] payload, int value)
        {
            return payload.Append(Const.TypeInt32).Append(new[] { (byte)'!', (byte)'L', (byte)value });
        }

        public static byte[] End(this byte[] payload)
        {
            return Const.PacketHead.Concat(new [] {(byte) '!', (byte) 'H',(byte)(payload.Length+4)}.Concat(payload)).ToArray();
        }
    }
}
