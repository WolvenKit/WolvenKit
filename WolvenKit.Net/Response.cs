using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

// ReSharper disable InconsistentNaming

namespace WolvenKit.Net
{
    public static class Response
    {
        #region Enums

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

        #endregion Enums

        #region Classes

        public class Byte_ : Param
        {
            #region Fields

            public sbyte Value;

            #endregion Fields

            #region Methods

            public override string ToString()
            {
                return "0x" + Value.ToString("X");
            }

            #endregion Methods
        }

        public class Data
        {
            #region Fields

            public byte[] Head = Const.PacketHead;
            public UInt16 Length;
            public List<Param> Params;

            #endregion Fields

            #region Constructors

            public Data(byte[] recievedBytes)
            {
                using (var br = new BinaryReader(new MemoryStream(recievedBytes)))
                {
                    this.Head = br.ReadBytes(2);
                    this.Length = BitConverter.ToUInt16(br.ReadBytes(2).Reverse().ToArray(), 0);
                    this.Params = new List<Param>();
                    for (; ; )
                    {
                        if (!(br.BaseStream.Length - br.BaseStream.Position > 4))
                            break;
                        var type = (ParamType)(BitConverter.ToUInt16(br.ReadBytes(2).Reverse().ToArray(), 0));
                        if (type == ParamType.PacketEnd)
                            break;
                        switch (type)
                        {
                            case ParamType.StringAnsi:
                            {
                                var param = new StringAnsi
                                {
                                    Unknown = BitConverter.ToUInt16(br.ReadBytes(2).Reverse().ToArray(), 0),
                                    length = BitConverter.ToUInt16(br.ReadBytes(2).Reverse().ToArray(), 0),
                                    Type = ParamType.StringAnsi
                                };
                                param.Value = Encoding.ASCII.GetString(br.ReadBytes(param.length));
                                this.Params.Add(param);
                                break;
                            }
                            case ParamType.StringUtf16:
                            {
                                var param = new StringUtf16
                                {
                                    Unknown = BitConverter.ToUInt16(br.ReadBytes(2).Reverse().ToArray(), 0),
                                    length = BitConverter.ToUInt16(br.ReadBytes(2).Reverse().ToArray(), 0),
                                    Type = ParamType.StringUtf16
                                };
                                param.Value = Encoding.BigEndianUnicode.GetString(br.ReadBytes(param.length * 2));
                                this.Params.Add(param);
                                break;
                            }
                            case ParamType.Byte:
                            {
                                var param = new Byte_
                                {
                                    Value = br.ReadSByte(),
                                    Type = ParamType.Byte
                                };
                                this.Params.Add(param);
                                break;
                            }
                            case ParamType.Uint32:
                            {
                                var param = new Uint_32
                                {
                                    Value = BitConverter.ToUInt32(br.ReadBytes(4).Reverse().ToArray(), 0),
                                    Type = ParamType.Uint32
                                };
                                this.Params.Add(param);
                                break;
                            }
                            case ParamType.Int32:
                            {
                                var param = new Int_32
                                {
                                    Value = BitConverter.ToInt32(br.ReadBytes(4).Reverse().ToArray(), 0),
                                    Type = ParamType.Int32
                                };
                                this.Params.Add(param);
                                break;
                            }
                            case ParamType.Int64:
                            {
                                var param = new Int_64
                                {
                                    Value = BitConverter.ToInt64(br.ReadBytes(4).Reverse().ToArray(), 0),
                                    Type = ParamType.Int64
                                };
                                this.Params.Add(param);
                                break;
                            }
                            default:
                                break;
                        }
                    }
                }
            }

            #endregion Constructors
        }

        public class Int_32 : Param
        {
            #region Fields

            public Int32 Value;

            #endregion Fields

            #region Methods

            public override string ToString()
            {
                return Value.ToString();
            }

            #endregion Methods
        }

        public class Int_64 : Param
        {
            #region Fields

            public Int64 Value;

            #endregion Fields

            #region Methods

            public override string ToString()
            {
                return Value.ToString();
            }

            #endregion Methods
        }

        public abstract class Param
        {
            #region Fields

            public ParamType Type;

            #endregion Fields
        }

        public class StringAnsi : Param
        {
            #region Fields

            public UInt16 length;
            public UInt16 Unknown;
            public string Value;

            #endregion Fields

            #region Methods

            public override string ToString()
            {
                return Value;
            }

            #endregion Methods
        }

        public class StringUtf16 : Param
        {
            #region Fields

            public UInt16 length;
            public UInt16 Unknown;
            public string Value;

            #endregion Fields

            #region Methods

            public override string ToString()
            {
                return Value;
            }

            #endregion Methods
        }

        public class Uint_32 : Param
        {
            #region Fields

            public UInt32 Value;

            #endregion Fields

            #region Methods

            public override string ToString()
            {
                return Value.ToString();
            }

            #endregion Methods
        }

        #endregion Classes
    }
}
