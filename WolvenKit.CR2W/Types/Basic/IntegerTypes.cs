using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CUInt64 : CVariable
    {
        

        public CUInt64(CR2WFile cr2w) : base(cr2w)
        {
            Type = "Uint64";
        }

        private ulong _val;

        [DataMember]
        public ulong val { get => _val; set => _val = value; }

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
            if (val is ulong)
            {
                this.val = (ulong)val;
            }
            if (val is string)
            {
                this.val = ulong.Parse(val as string);
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CUInt64(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CUInt64)base.Copy(context);
            var.val = val;
            return var;
        }

        public override Control GetEditor()
        {
            var editor = new TextBox();
            editor.DataBindings.Add("Text", this, "val");
            return editor;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }

    [DataContract(Namespace = "")]
    public class CUInt32 : CVariable
    {
        public CUInt32(CR2WFile cr2w)
            : base(cr2w)
        {
            Type = "Uint32";
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
            if (val is uint)
            {
                this.val = (uint) val;
            }
            if (val is string)
            {
                this.val = uint.Parse(val as string);
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CUInt32(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CUInt32) base.Copy(context);
            var.val = val;
            return var;
        }

        public override Control GetEditor()
        {
            var editor = new TextBox();
            editor.DataBindings.Add("Text", this, "val");
            return editor;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }

    [DataContract(Namespace = "")]
    public class CUInt16 : CVariable
    {
       

        public CUInt16(CR2WFile cr2w)
: base(cr2w)
        {
            Type = "Uint16";
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
            if (val is ushort)
            {
                this.val = (ushort)val;
            }
            if (val is string)
            {
                this.val = ushort.Parse(val as string);
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CUInt16(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CUInt16)base.Copy(context);
            var.val = val;
            return var;
        }

        public override Control GetEditor()
        {
            var editor = new TextBox();
            editor.DataBindings.Add("Text", this, "val");
            return editor;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }

    [DataContract(Namespace = "")]
    public class CUInt8 : CVariable
    {
        public CUInt8(CR2WFile cr2w)
            : base(cr2w)
        {
            Type = "Uint8";
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
            if (val is byte)
            {
                this.val = (byte) val;
            }
            if (val is string)
            {
                this.val = byte.Parse(val as string);
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CUInt8(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CUInt8) base.Copy(context);
            var.val = val;
            return var;
        }

        public override Control GetEditor()
        {
            var editor = new TextBox();
            editor.DataBindings.Add("Text", this, "val");
            return editor;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }


    [DataContract(Namespace = "")]
    public class CInt64 : CVariable
    {
        public CInt64(CR2WFile cr2w)
            : base(cr2w)
        {
            Type = "Int64";
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
            if (val is long)
            {
                this.val = (long) val;
            }
            if (val is string)
            {
                this.val = long.Parse(val as string);
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CInt64(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CInt64) base.Copy(context);
            var.val = val;
            return var;
        }

        public override Control GetEditor()
        {
            var editor = new TextBox();
            editor.DataBindings.Add("Text", this, "val");
            return editor;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }

    [DataContract(Namespace = "")]
    public class CInt32 : CVariable
    {
        public CInt32(CR2WFile cr2w)
            : base(cr2w)
        {
            Type = "Int32";
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
            if (val is int)
            {
                this.val = (int) val;
            }
            if (val is string)
            {
                this.val = int.Parse(val as string);
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CInt32(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CInt32) base.Copy(context);
            var.val = val;
            return var;
        }

        public override Control GetEditor()
        {
            var editor = new TextBox();
            editor.DataBindings.Add("Text", this, "val");
            return editor;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }

    [DataContract(Namespace = "")]
    public class CInt16 : CVariable
    {
        public CInt16(CR2WFile cr2w)
            : base(cr2w)
        {
            Type = "Int16";
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
            if (val is short)
            {
                this.val = (short) val;
            }
            if (val is string)
            {
                this.val = short.Parse(val as string);
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CInt16(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CInt16) base.Copy(context);
            var.val = val;
            return var;
        }

        public override Control GetEditor()
        {
            var editor = new TextBox();
            editor.DataBindings.Add("Text", this, "val");
            return editor;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }

    [DataContract(Namespace = "")]
    public class CInt8 : CVariable
    {
        public CInt8(CR2WFile cr2w)
            : base(cr2w)
        {
            Type = "Int8";
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

        public override CVariable SetValue(object val)
        {
            if (val is sbyte)
            {
                this.val = (sbyte) val;
            }
            if (val is string)
            {
                this.val = sbyte.Parse(val as string);
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CInt8(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CInt8) base.Copy(context);
            var.val = val;
            return var;
        }

        public override Control GetEditor()
        {
            var editor = new TextBox();
            editor.DataBindings.Add("Text", this, "val");
            return editor;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }

    [DataContract(Namespace = "")]
    public class CDynamicInt : CVariable
    {
        public CDynamicInt(CR2WFile cr2w)
            : base(cr2w)
        {
            Type = "";
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
            if (val is sbyte)
            {
                this.val = (sbyte) val;
            }
            if (val is string)
            {
                this.val = sbyte.Parse(val as string);
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CInt8(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CDynamicInt) base.Copy(context);
            var.val = val;
            return var;
        }

        public override Control GetEditor()
        {
            var editor = new TextBox();
            editor.DataBindings.Add("Text", this, "val");
            return editor;
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

    [DataContract(Namespace = "")]
    public class CVLQInt32 : CVariable
    {
        public CVLQInt32(CR2WFile cr2w)
            : base(cr2w)
        {
            Type = "";
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
            if (val is sbyte)
            {
                this.val = (sbyte)val;
            }
            if (val is string)
            {
                this.val = sbyte.Parse(val as string);
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CInt8(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CVLQInt32)base.Copy(context);
            var.val = val;
            return var;
        }

        public override Control GetEditor()
        {
            var editor = new TextBox();
            editor.DataBindings.Add("Text", this, "val");
            return editor;
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

    [DataContract(Namespace = "")]
    public class CBool : CVariable
    {
        public CBool(CR2WFile cr2w)
            : base(cr2w)
        {
            Type = "Bool";
        }

        [DataMember]
        public bool val { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            val = file.ReadByte() != 0;
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val ? (byte) 1 : (byte) 0);
        }

        public override CVariable SetValue(object val)
        {
            if (val is bool)
            {
                this.val = (bool) val;
            }
            if (val is string)
            {
                this.val = bool.Parse(val as string);
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CBool(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CBool) base.Copy(context);
            var.val = val;
            return var;
        }

        public override Control GetEditor()
        {
            var editor = new CheckBox();
            editor.DataBindings.Add("Checked", this, "val");
            return editor;
        }

        public override string ToString()
        {
            return val ? "True" : "False";
        }
    }
}