using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using WolvenKit.RED4.CR2W.Reflection;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;

namespace WolvenKit.RED4.CR2W.Types
{
    public class CDouble : CVariable, IREDIntegerType<double>
    {
        public CDouble()
        {

        }

        public CDouble(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
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
                CUInt64 v => v.Value,
                _ => this.Value
            };

            return this;
        }

        public object GetValue() => Value;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CDouble)base.Copy(context);
            var.Value = Value;
            return var;
        }

        public override string ToString() => Value.ToString(CultureInfo.InvariantCulture);
    }

    public class CUInt64 : CVariable, IREDIntegerType<ulong>
    {
        public CUInt64()
        {

        }

        public CUInt64(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        [DataMember]
        public ulong Value { get; set; }

        public override void Read(BinaryReader file, uint size) => Value = file.ReadUInt64();

        public override void Write(BinaryWriter file) => file.Write(Value);

        public override CVariable SetValue(object val)
        {
            this.Value = val switch
            {
                ulong o => o,
                string s => ulong.Parse(s),
                CUInt64 v => v.Value,
                _ => this.Value
            };

            return this;
        }

        public object GetValue() => Value;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CUInt64)base.Copy(context);
            var.Value = Value;
            return var;
        }

        public override string ToString() => Value.ToString();
    }

    public class CUInt32 : CVariable, IREDIntegerType<uint>
    {
        public CUInt32()
        {

        }

        public CUInt32(IRed4EngineFile cr2w, CVariable parent, string name)
            : base(cr2w, parent, name)
        {
        }

        [DataMember]
        public uint Value { get; set; }

        public override void Read(BinaryReader file, uint size) => Value = file.ReadUInt32();

        public override void Write(BinaryWriter file) => file.Write(Value);

        public override CVariable SetValue(object val)
        {
            this.Value = val switch
            {
                uint o => o,
                string s => uint.Parse(s),
                CUInt32 v => v.Value,
                _ => this.Value
            };

            return this;
        }

        public object GetValue() => Value;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CUInt32) base.Copy(context);
            var.Value = Value;
            return var;
        }

        public override string ToString() => Value.ToString();
    }

    public class CUInt16 : CVariable, IREDIntegerType<ushort>
    {
        public CUInt16()
        {

        }

        public CUInt16(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        [DataMember]
        public ushort Value { get; set; }

        public override void Read(BinaryReader file, uint size) => Value = file.ReadUInt16();

        public override void Write(BinaryWriter file) => file.Write(Value);

        public override CVariable SetValue(object val)
        {
            this.Value = val switch
            {
                ushort o => o,
                string s => ushort.Parse(s),
                CUInt16 v => v.Value,
                _ => this.Value
            };

            return this;
        }

        public object GetValue() => Value;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CUInt16)base.Copy(context);
            var.Value = Value;
            return var;
        }

        public override string ToString() => Value.ToString();
    }

    public class CUInt8 : CVariable, IREDIntegerType<byte>
    {
        public CUInt8()
        {

        }
        public CUInt8(IRed4EngineFile cr2w, CVariable parent, string name)
            : base(cr2w, parent, name)
        {
        }

        [DataMember]
        public byte Value { get; set; }

        public override void Read(BinaryReader file, uint size) => Value = file.ReadByte();

        public override void Write(BinaryWriter file) => file.Write(Value);

        public override CVariable SetValue(object val)
        {
            this.Value = val switch
            {
                byte o => o,
                string s => byte.Parse(s),
                CUInt8 v => v.Value,
                _ => this.Value
            };

            return this;
        }

        public object GetValue() => Value;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CUInt8) base.Copy(context);
            var.Value = Value;
            return var;
        }

        public override string ToString() => Value.ToString();
    }

    public class CInt64 : CVariable, IREDIntegerType<long>
    {
        public CInt64()
        {

        }
        public CInt64(IRed4EngineFile cr2w, CVariable parent, string name)
            : base(cr2w, parent, name)
        {
        }

        [DataMember]
        public long Value { get; set; }

        public override void Read(BinaryReader file, uint size) => Value = file.ReadInt64();

        public override void Write(BinaryWriter file) => file.Write(Value);

        public override CVariable SetValue(object val)
        {
            this.Value = val switch
            {
                long o => o,
                string s => long.Parse(s),
                CInt64 v => v.Value,
                _ => this.Value
            };

            return this;
        }

        public object GetValue() => Value;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CInt64) base.Copy(context);
            var.Value = Value;
            return var;
        }

        public override string ToString() => Value.ToString();
    }

    public class CInt32 : CVariable, IREDIntegerType<int>
    {
        public CInt32()
        {

        }
        public CInt32(IRed4EngineFile cr2w, CVariable parent, string name)
            : base(cr2w, parent, name)
        {
        }

        [DataMember]
        public int Value { get; set; }



        public override void Read(BinaryReader file, uint size) => Value = file.ReadInt32();

        public override void Write(BinaryWriter file) => file.Write(Value);

        public override CVariable SetValue(object val)
        {
            this.Value = val switch
            {
                int o => o,
                string s => int.Parse(s),
                CInt32 v => v.Value,
                _ => this.Value
            };

            return this;
        }

        public object GetValue() => Value;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CInt32) base.Copy(context);
            var.Value = Value;
            return var;
        }

        public override string ToString() => Value.ToString();
    }

    public class CInt16 : CVariable, IREDIntegerType<short>
    {
        public CInt16()
        {

        }
        public CInt16(IRed4EngineFile cr2w, CVariable parent, string name)
            : base(cr2w, parent, name)
        {
        }

        [DataMember]
        public short Value { get; set; }

        public override void Read(BinaryReader file, uint size) => Value = file.ReadInt16();

        public override void Write(BinaryWriter file) => file.Write(Value);

        public override CVariable SetValue(object val)
        {
            this.Value = val switch
            {
                short o => o,
                string s => short.Parse(s),
                CInt16 v => v.Value,
                _ => this.Value
            };

            return this;
        }

        public object GetValue() => Value;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CInt16) base.Copy(context);
            var.Value = Value;
            return var;
        }

        public override string ToString() => Value.ToString();
    }

    public class CInt8 : CVariable, IREDIntegerType<sbyte>
    {
        public CInt8()
        {

        }
        public CInt8(IRed4EngineFile cr2w, CVariable parent, string name)
            : base(cr2w, parent, name)
        {
        }

        [DataMember]
        public sbyte Value { get; set; }

        public override void Read(BinaryReader file, uint size) => Value = file.ReadSByte();

        public override void Write(BinaryWriter file) => file.Write(Value);

        public override CVariable SetValue(object newval)
        {
            this.Value = newval switch
            {
                sbyte o => o,
                string s => sbyte.Parse(s),
                CInt8 v => v.Value,
                _ => this.Value
            };

            return this;
        }

        public object GetValue() => Value;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CInt8) base.Copy(context);
            var.Value = Value;
            return var;
        }

        public override string ToString() => Value.ToString();
    }

    public class CDynamicInt : CVariable, IREDIntegerType<int>
    {
        public CDynamicInt()
        {

        }
        public CDynamicInt(IRed4EngineFile cr2w, CVariable parent, string name)
            : base(cr2w, parent, name)
        {
        }

        [DataMember]
        public int Value { get; set; }

        public override void Read(BinaryReader file, uint size) => Value = file.ReadBit6();

        public override void Write(BinaryWriter file) => file.WriteBit6(Value);

        public override CVariable SetValue(object val)
        {
            this.Value = val switch
            {
                sbyte o => o,
                string s => sbyte.Parse(s),
                CDynamicInt v => v.Value,
                _ => this.Value
            };

            return this;
        }

        public object GetValue() => Value;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CDynamicInt) base.Copy(context);
            var.Value = Value;
            return var;
        }

        public override string ToString() => Value.ToString();

        internal byte ToByte()
        {
            byte.TryParse(Value.ToString(), out var result);
            return result;
        }
    }

    public class CVLQInt32 : CVariable, IREDIntegerType<int>
    {
        public CVLQInt32()
        {

        }
        public CVLQInt32(IRed4EngineFile cr2w, CVariable parent, string name)
            : base(cr2w, parent, name)
        {
        }

        [DataMember]
        public int Value { get; set; }

        public override void Read(BinaryReader file, uint size) => Value = file.ReadVLQInt32();

        public override void Write(BinaryWriter file) => file.WriteVLQInt32(Value);

        public override CVariable SetValue(object val)
        {
            this.Value = val switch
            {
                sbyte o => o,
                string s => sbyte.Parse(s),
                CVLQInt32 v => v.Value,
                _ => this.Value
            };

            return this;
        }

        public object GetValue() => Value;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CVLQInt32)base.Copy(context);
            var.Value = Value;
            return var;
        }

        public override string ToString() => Value.ToString();
    }
}
