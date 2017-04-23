using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Net
{
    class Request
    {
        public static byte[] Payload;

        public void Append(byte[] data)
        {
            Payload = Payload.Concat(data).ToArray();
        }

        public void AppendByte(byte Value)
        {
            Append(new []{(byte)'!', (byte)'?',Value});
        }

        //TODO: Other types

        public byte[] End()
        {
            return Const.PacketHead.Concat(new [] {(byte) '!', (byte) 'H',(byte)(Payload.Length+4)}.Concat(Payload)).ToArray();
        }
    }
}
