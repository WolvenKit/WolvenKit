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
                this.val = (ulong)val;
            else if (val is string)
                this.val = ulong.Parse(val as string);
            else if (val is CUInt64 v)
                this.val = v.val;

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
                this.val = (uint) val;
            else if (val is string)
                this.val = uint.Parse(val as string);
            else if (val is CUInt32 v)
                this.val = v.val;

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
            editor.DataBindings.Add(nameof(editor.Text), this, nameof(val));
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
        public CUInt16(CR2WFile cr2w) : base(cr2w)
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
            if (val is ushort)
                this.val = (ushort)val;
            else if (val is string)
                this.val = ushort.Parse(val as string);
            else if (val is CUInt16 v)
                this.val = v.val;

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
                this.val = (byte) val;
            else if (val is string)
                this.val = byte.Parse(val as string);
            else if (val is CUInt8 v)
                this.val = v.val;

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
                this.val = (long) val;
            else if (val is string)
                this.val = long.Parse(val as string);
            else if (val is CInt64 v)
                this.val = v.val;

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
                this.val = (int) val;
            else if (val is string)
                this.val = int.Parse(val as string);
            else if (val is CInt32 v)
                this.val = v.val;

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
                this.val = (short) val;
            else if (val is string)
                this.val = short.Parse(val as string);
            else if (val is CInt16 v)
                this.val = v.val;

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
            if (newval is sbyte)
                this.val = (sbyte) newval;
            else if (newval is string)
                this.val = sbyte.Parse(newval as string);
            else if (newval is CInt8 v)
                this.val = v.val;

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
                this.val = (sbyte) val;
            else if (val is string)
                this.val = sbyte.Parse(val as string);
            else if (val is CDynamicInt v)
                this.val = v.val;

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
                this.val = (sbyte)val;
            else if (val is string)
                this.val = sbyte.Parse(val as string);
            else if (val is CVLQInt32 v)
                this.val = v.val;

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
                this.val = (bool) val;
            else if (val is string)
                this.val = bool.Parse(val as string);
            else if (val is CBool v)
                this.val = v.val;

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