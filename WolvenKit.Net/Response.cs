using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Net
{
    class Response
    {
        public class Data
        {
            public byte[] Head = Const.PacketHead;
            public UInt16 Length;
            public List<Param> Params;

            public Data(byte[] recievedBytes)
            {
                using (var br = new BinaryReader(new MemoryStream(recievedBytes)))
                {
                    this.Head = br.ReadBytes(4);
                    this.Length = br.ReadUInt16();
                    this.Params = new List<Param>();
                    for (;;)
                    {
                        var type = (ParamType)br.ReadUInt16();
                        if (type == ParamType.PacketEnd)
                            break;
                        switch (type)
                        {
                            case ParamType.StringAnsi:
                            {
                                var param = new StringAnsi
                                {
                                    Unknown = br.ReadUInt16(),
                                    length = br.ReadUInt16()
                                };
                                param.Value = Encoding.ASCII.GetString(br.ReadBytes(param.length));
                                this.Params.Add(param);
                                break;
                            }
                            case ParamType.StringUtf16:
                            {
                                var param = new StringUtf16
                                {
                                    Unknown = br.ReadUInt16(),
                                    length = br.ReadUInt16()
                                };
                                param.Value = Encoding.Unicode.GetString(br.ReadBytes(param.length*2));
                                this.Params.Add(param);
                                break;
                            }
                            case ParamType.Byte:
                            {
                                var param = new Byte_ {Value = br.ReadSByte()};
                                this.Params.Add(param);
                                break;
                            }
                            case ParamType.Uint32:
                            {
                                var param = new Uint_32 {Value = br.ReadUInt32()};
                                this.Params.Add(param);
                                break;
                            }
                            case ParamType.Int32:
                            {
                                var param = new Int_32 {Value = br.ReadInt32()};
                                this.Params.Add(param);
                                break;
                            }
                            case ParamType.Int64:
                            {
                                var param = new Int_64 {Value = br.ReadInt64()};
                                this.Params.Add(param);
                                break;
                            }
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                    }
                }
            }
        }

        public abstract class Param
        {
            public ParamType Type;
        }

        public class StringAnsi : Param
        {
            public UInt16 Unknown;
            public UInt16 length;
            public string Value;
        }

        public class StringUtf16 : Param
        {
            public UInt16 Unknown;
            public UInt16 length;
            public string Value;
        }

        // ReSharper disable once InconsistentNaming
        public class Byte_ : Param
        {
            public sbyte Value;
        }

        public class Uint_32 : Param
        {
            public UInt32 Value;
        }

        public class Int_32 : Param
        {
            public Int32 Value;
        }

        public class Int_64 : Param
        {
            public Int64 Value;
        }

        public enum ParamType
        {
            StringAnsi = 0xAC08,
            StringUtf16 = 0x9C16,
            Byte = 0x8108,
            PacketEnd = 0xBEEF,
            Uint32 = 0x7132,
            Int32 = 0x8132,
            Int64 = 0x8164
        }
    }
}
