using System;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using CP77.CR2W.Reflection;
using WolvenKit.Common.Model.Cr2w;

namespace CP77.CR2W.Types
{
    public class CDouble : CVariable, IREDPrimitive, IREDIntegerType
    {
        public CDouble()
        {
            
        }

        public CDouble(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        [DataMember]
        public double Value { get; set; }

        public override void Read(BinaryReader file, uint size) => Value = file.ReadDouble();

        public override void Write(BinaryWriter file) => file.Write(Value);

        public override CVariable SetValue(object val)
        {
            this.Value = val switch
            {
                ulong o => o,
                string s => double.Parse(s),
                CUInt64 v => v.val,
                _ => this.Value
            };

            return this;
        }

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CDouble)base.Copy(context);
            var.Value = Value;
            return var;
        }

        public override string ToString() => Value.ToString(CultureInfo.InvariantCulture);
    }
    
    public class CUInt64 : CVariable, IREDPrimitive, IREDIntegerType
    {
        public CUInt64()
        {
            
        }

        public CUInt64(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        public double Value
        {
            get => val;
            set => val = (ulong)value;
        }

        [DataMember]
        public ulong val { get; set; }

        public override void Read(BinaryReader file, uint size) => val = file.ReadUInt64();

        public override void Write(BinaryWriter file) => file.Write(val);

        public override CVariable SetValue(object val)
        {
            this.val = val switch
            {
                ulong o => o,
                string s => ulong.Parse(s),
                CUInt64 v => v.val,
                _ => this.val
            };

            return this;
        }

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CUInt64)base.Copy(context);
            var.val = val;
            return var;
        }

        public override string ToString() => val.ToString();
    }

    public class CUInt32 : CVariable, IREDPrimitive, IREDIntegerType
    {
        public CUInt32()
        {
            
        }

        public CUInt32(CR2WFile cr2w, CVariable parent, string name)
            : base(cr2w, parent, name)
        {
        }

        public double Value
        {
            get => val;
            set => val = (uint)value;
        }

        [DataMember]
        public uint val { get; set; }

        public override void Read(BinaryReader file, uint size) => val = file.ReadUInt32();

        public override void Write(BinaryWriter file) => file.Write(val);

        public override CVariable SetValue(object val)
        {
            this.val = val switch
            {
                uint o => o,
                string s => uint.Parse(s),
                CUInt32 v => v.val,
                _ => this.val
            };

            return this;
        }

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CUInt32) base.Copy(context);
            var.val = val;
            return var;
        }

        public override string ToString() => val.ToString();
    }

    public class CUInt16 : CVariable, IREDPrimitive, IREDIntegerType
    {
        public CUInt16()
        {
            
        }

        public CUInt16(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        public double Value
        {
            get => val;
            set => val = (ushort)value;
        }

        [DataMember]
        public ushort val { get; set; }

        public override void Read(BinaryReader file, uint size) => val = file.ReadUInt16();

        public override void Write(BinaryWriter file) => file.Write(val);

        public override CVariable SetValue(object val)
        {
            this.val = val switch
            {
                ushort o => o,
                string s => ushort.Parse(s),
                CUInt16 v => v.val,
                _ => this.val
            };

            return this;
        }

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CUInt16)base.Copy(context);
            var.val = val;
            return var;
        }

        public override string ToString() => val.ToString();
    }

    public class CUInt8 : CVariable, IREDPrimitive, IREDIntegerType
    {
        public CUInt8()
        {
            
        }
        public CUInt8(CR2WFile cr2w, CVariable parent, string name)
            : base(cr2w, parent, name)
        {
        }

        public double Value
        {
            get => val;
            set => val = (byte)value;
        }

        [DataMember]
        public byte val { get; set; }

        public override void Read(BinaryReader file, uint size) => val = file.ReadByte();

        public override void Write(BinaryWriter file) => file.Write(val);

        public override CVariable SetValue(object val)
        {
            this.val = val switch
            {
                byte o => o,
                string s => byte.Parse(s),
                CUInt8 v => v.val,
                _ => this.val
            };

            return this;
        }

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CUInt8) base.Copy(context);
            var.val = val;
            return var;
        }

        public override string ToString() => val.ToString();
    }

    public class CInt64 : CVariable, IREDPrimitive, IREDIntegerType
    {
        public CInt64()
        {
            
        }
        public CInt64(CR2WFile cr2w, CVariable parent, string name)
            : base(cr2w, parent, name)
        {
        }

        public double Value
        {
            get => val;
            set => val = (long)value;
        }

        [DataMember]
        public long val { get; set; }

        public override void Read(BinaryReader file, uint size) => val = file.ReadInt64();

        public override void Write(BinaryWriter file) => file.Write(val);

        public override CVariable SetValue(object val)
        {
            this.val = val switch
            {
                long o => o,
                string s => long.Parse(s),
                CInt64 v => v.val,
                _ => this.val
            };

            return this;
        }

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CInt64) base.Copy(context);
            var.val = val;
            return var;
        }

        public override string ToString() => val.ToString();
    }

    public class CInt32 : CVariable, IREDPrimitive, IREDIntegerType
    {
        public CInt32()
        {
            
        }
        public CInt32(CR2WFile cr2w, CVariable parent, string name)
            : base(cr2w, parent, name)
        {
        }

        public double Value
        {
            get => val;
            set => val = (int)value;
        }

        [DataMember]
        public int val { get; set; }



        public override void Read(BinaryReader file, uint size) => val = file.ReadInt32();

        public override void Write(BinaryWriter file) => file.Write(val);

        public override CVariable SetValue(object val)
        {
            this.val = val switch
            {
                int o => o,
                string s => int.Parse(s),
                CInt32 v => v.val,
                _ => this.val
            };

            return this;
        }

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CInt32) base.Copy(context);
            var.val = val;
            return var;
        }

        public override string ToString() => val.ToString();
    }

    public class CInt16 : CVariable, IREDPrimitive, IREDIntegerType
    {
        public CInt16()
        {
            
        }
        public CInt16(CR2WFile cr2w, CVariable parent, string name)
            : base(cr2w, parent, name)
        {
        }

        public double Value
        {
            get => val;
            set => val = (short)value;
        }

        [DataMember]
        public short val { get; set; }

        public override void Read(BinaryReader file, uint size) => val = file.ReadInt16();

        public override void Write(BinaryWriter file) => file.Write(val);

        public override CVariable SetValue(object val)
        {
            this.val = val switch
            {
                short o => o,
                string s => short.Parse(s),
                CInt16 v => v.val,
                _ => this.val
            };

            return this;
        }

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CInt16) base.Copy(context);
            var.val = val;
            return var;
        }

        public override string ToString() => val.ToString();
    }

    public class CInt8 : CVariable, IREDPrimitive, IREDIntegerType
    {
        public CInt8()
        {
            
        }
        public CInt8(CR2WFile cr2w, CVariable parent, string name)
            : base(cr2w, parent, name)
        {
        }

        public double Value
        {
            get => val;
            set => val = (sbyte)value;
        }

        [DataMember]
        public sbyte val { get; set; }

        public override void Read(BinaryReader file, uint size) => val = file.ReadSByte();

        public override void Write(BinaryWriter file) => file.Write(val);

        public override CVariable SetValue(object newval)
        {
            this.val = newval switch
            {
                sbyte o => o,
                string s => sbyte.Parse(s),
                CInt8 v => v.val,
                _ => this.val
            };

            return this;
        }

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CInt8) base.Copy(context);
            var.val = val;
            return var;
        }

        public override string ToString() => val.ToString();
    }

    public class CDynamicInt : CVariable, IREDPrimitive, IREDIntegerType
    {
        public CDynamicInt()
        {
            
        }
        public CDynamicInt(CR2WFile cr2w, CVariable parent, string name)
            : base(cr2w, parent, name)
        {
        }

        public double Value
        {
            get => val;
            set => val = (int)value;
        }

        [DataMember]
        public int val { get; set; }

        public override void Read(BinaryReader file, uint size) => val = file.ReadBit6();

        public override void Write(BinaryWriter file) => file.WriteBit6(val);

        public override CVariable SetValue(object val)
        {
            this.val = val switch
            {
                sbyte o => o,
                string s => sbyte.Parse(s),
                CDynamicInt v => v.val,
                _ => this.val
            };

            return this;
        }

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CDynamicInt) base.Copy(context);
            var.val = val;
            return var;
        }

        public override string ToString() => val.ToString();

        internal byte ToByte()
        {
            byte.TryParse(val.ToString(), out var result);
            return result;
        }
    }

    public class CVLQInt32 : CVariable, IREDPrimitive, IREDIntegerType
    {
        public CVLQInt32()
        {
            
        }
        public CVLQInt32(CR2WFile cr2w, CVariable parent, string name)
            : base(cr2w, parent, name)
        {
        }

        public double Value
        {
            get => val;
            set => val = (int)value;
        }

        [DataMember]
        public int val { get; set; }

        public override void Read(BinaryReader file, uint size) => val = file.ReadVLQInt32();

        public override void Write(BinaryWriter file) => file.WriteVLQInt32(val);

        public override CVariable SetValue(object val)
        {
            this.val = val switch
            {
                sbyte o => o,
                string s => sbyte.Parse(s),
                CVLQInt32 v => v.val,
                _ => this.val
            };

            return this;
        }

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CVLQInt32)base.Copy(context);
            var.val = val;
            return var;
        }

        public override string ToString() => val.ToString();
    }
}
