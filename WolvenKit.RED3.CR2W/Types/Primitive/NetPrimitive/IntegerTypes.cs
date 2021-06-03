using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Core.Extensions;
using WolvenKit.RED3.CR2W.Reflection;

namespace WolvenKit.RED3.CR2W.Types
{
    [REDMeta()]
    public class CUInt64 : CVariable, IREDPrimitive
    {
        public CUInt64()
        {
        }

        public CUInt64(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        public ulong val { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            val = file.ReadUInt64();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            this.IsSerialized = true;
            switch (val)
            {
                case ulong o:
                    this.val = o;
                    break;
                case string s:
                    this.val = ulong.Parse(s);
                    break;
                case CUInt64 v:
                    this.val = v.val;
                    break;
            }

            return this;
        }

        public object GetValue() => val;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CUInt64)base.Copy(context);
            var.val = val;
            return var;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }


    public class CUInt32 : CVariable, IREDPrimitive
    {
        public CUInt32()
        {

        }

        public CUInt32(IRed3EngineFile cr2w, CVariable parent, string name)
            : base(cr2w, parent, name)
        {
        }

        [DataMember]
        public uint val { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            val = file.ReadUInt32();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            this.IsSerialized = true;
            switch (val)
            {
                case uint o:
                    this.val = o;
                    break;
                case string s:
                    this.val = uint.Parse(s);
                    break;
                case CUInt32 v:
                    this.val = v.val;
                    break;
            }

            return this;
        }

        public object GetValue() => val;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CUInt32) base.Copy(context);
            var.val = val;
            return var;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }


    public class CUInt16 : CVariable, IREDPrimitive
    {
        public CUInt16()
        {

        }

        public CUInt16(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        private ushort _val;

        [DataMember]
        public ushort val { get => _val; set => _val = value; }

        public override void Read(BinaryReader file, uint size)
        {
            val = file.ReadUInt16();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            this.IsSerialized = true;
            switch (val)
            {
                case ushort o:
                    this.val = o;
                    break;
                case string s:
                    this.val = ushort.Parse(s);
                    break;
                case CUInt16 v:
                    this.val = v.val;
                    break;
            }

            return this;
        }

        public object GetValue() => val;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CUInt16)base.Copy(context);
            var.val = val;
            return var;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }


    public class CUInt8 : CVariable, IREDPrimitive
    {
        public CUInt8()
        {

        }
        public CUInt8(IRed3EngineFile cr2w, CVariable parent, string name)
            : base(cr2w, parent, name)
        {
        }

        [DataMember]
        public byte val { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            val = file.ReadByte();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            this.IsSerialized = true;
            switch (val)
            {
                case byte o:
                    this.val = o;
                    break;
                case string s:
                    this.val = byte.Parse(s);
                    break;
                case CUInt8 v:
                    this.val = v.val;
                    break;
            }

            return this;
        }

        public object GetValue() => val;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CUInt8) base.Copy(context);
            var.val = val;
            return var;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }


    public class CInt64 : CVariable, IREDPrimitive
    {
        public CInt64()
        {

        }
        public CInt64(IRed3EngineFile cr2w, CVariable parent, string name)
            : base(cr2w, parent, name)
        {
        }

        [DataMember]
        public long val { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            val = file.ReadInt64();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            this.IsSerialized = true;
            switch (val)
            {
                case long o:
                    this.val = o;
                    break;
                case string s:
                    this.val = long.Parse(s);
                    break;
                case CInt64 v:
                    this.val = v.val;
                    break;
            }

            return this;
        }

        public object GetValue() => val;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CInt64) base.Copy(context);
            var.val = val;
            return var;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }


    public class CInt32 : CVariable, IREDPrimitive
    {
        public CInt32()
        {

        }
        public CInt32(IRed3EngineFile cr2w, CVariable parent, string name)
            : base(cr2w, parent, name)
        {
        }

        [DataMember]
        public int val { get; set; }



        public override void Read(BinaryReader file, uint size)
        {
            val = file.ReadInt32();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            this.IsSerialized = true;
            switch (val)
            {
                case int o:
                    this.val = o;
                    break;
                case string s:
                    this.val = int.Parse(s);
                    break;
                case CInt32 v:
                    this.val = v.val;
                    break;
            }

            return this;
        }

        public object GetValue() => val;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CInt32) base.Copy(context);
            var.val = val;
            return var;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }


    public class CInt16 : CVariable, IREDPrimitive
    {
        public CInt16()
        {

        }
        public CInt16(IRed3EngineFile cr2w, CVariable parent, string name)
            : base(cr2w, parent, name)
        {
        }

        [DataMember]
        public short val { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            val = file.ReadInt16();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            this.IsSerialized = true;
            switch (val)
            {
                case short o:
                    this.val = o;
                    break;
                case string s:
                    this.val = short.Parse(s);
                    break;
                case CInt16 v:
                    this.val = v.val;
                    break;
            }

            return this;
        }

        public object GetValue() => val;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CInt16) base.Copy(context);
            var.val = val;
            return var;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }


    public class CInt8 : CVariable, IREDPrimitive
    {
        public CInt8()
        {

        }
        public CInt8(IRed3EngineFile cr2w, CVariable parent, string name)
            : base(cr2w, parent, name)
        {
        }

        [DataMember]
        public sbyte val { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            val = file.ReadSByte();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val);
        }

        public override CVariable SetValue(object newval)
        {
            switch (newval)
            {
                case sbyte o:
                    this.val = o;
                    break;
                case string s:
                    this.val = sbyte.Parse(s);
                    break;
                case CInt8 v:
                    this.val = v.val;
                    break;
            }

            return this;
        }

        public object GetValue() => val;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CInt8) base.Copy(context);
            var.val = val;
            return var;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }


    public class CDynamicInt : CVariable, IREDPrimitive
    {
        public CDynamicInt()
        {

        }
        public CDynamicInt(IRed3EngineFile cr2w, CVariable parent, string name)
            : base(cr2w, parent, name)
        {
        }

        [DataMember]
        public int val { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            val = file.ReadBit6();
        }

        public override void Write(BinaryWriter file)
        {
            file.WriteBit6(val);
        }

        public override CVariable SetValue(object val)
        {
            this.IsSerialized = true;
            switch (val)
            {
                case sbyte o:
                    this.val = o;
                    break;
                case string s:
                    this.val = sbyte.Parse(s);
                    break;
                case CDynamicInt v:
                    this.val = v.val;
                    break;
            }

            return this;
        }

        public object GetValue() => val;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CDynamicInt) base.Copy(context);
            var.val = val;
            return var;
        }

        public override string ToString()
        {
            return val.ToString();
        }

        internal byte ToByte()
        {
            byte result;
            byte.TryParse(val.ToString(), out result);
            return result;
        }
    }


    public class CVLQInt32 : CVariable, IREDPrimitive
    {
        public CVLQInt32()
        {

        }
        public CVLQInt32(IRed3EngineFile cr2w, CVariable parent, string name)
            : base(cr2w, parent, name)
        {
        }

        [DataMember]
        public int val { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            val = file.ReadVLQInt32();
        }

        public override void Write(BinaryWriter file)
        {
            file.WriteVLQInt32(val);
        }

        public override CVariable SetValue(object val)
        {
            this.IsSerialized = true;
            switch (val)
            {
                case sbyte o:
                    this.val = o;
                    break;
                case string s:
                    this.val = sbyte.Parse(s);
                    break;
                case CVLQInt32 v:
                    this.val = v.val;
                    break;
            }

            return this;
        }

        public object GetValue() => val;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CVLQInt32)base.Copy(context);
            var.val = val;
            return var;
        }

        public override string ToString()
        {
            return val.ToString();
        }


    }


    public class CBool : CVariable, IREDPrimitive
    {
        public CBool()
        {

        }
        public CBool(IRed3EngineFile cr2w, CVariable parent, string name)
            : base(cr2w, parent, name)
        {
        }

        private byte backingField;

        [DataMember]
        public bool val
        {
            get => backingField != 0;
            set => backingField = value ? (byte)1 : (byte)0;
        }

        public override void Read(BinaryReader file, uint size)
        {
            backingField = file.ReadByte();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(backingField);
            //file.Write(val ? (byte) 1 : (byte) 0);
        }

        public override CVariable SetValue(object val)
        {
            this.IsSerialized = true;
            switch (val)
            {
                case bool b:
                    this.val = b;
                    break;
                case string s:
                    this.val = bool.Parse(s);
                    break;
                case CBool v:
                    this.val = v.val;
                    break;
            }

            return this;
        }

        public object GetValue() => val;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CBool) base.Copy(context);
            var.backingField = backingField;
            return var;
        }

        public override string ToString()
        {
            return val ? "True" : "False";
        }
    }
}
